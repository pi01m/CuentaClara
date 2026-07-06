using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_DigitoVerificador
    {
        private Servicio_Calcular servicioCalcular;
        private BLL_BitacoraEvento bllBitacora;
        private DAL_DigitoVerificador dalDigito;
        private DAL_Usuario dalUsuario;
        
        public BLL_DigitoVerificador()
        {
            servicioCalcular = new Servicio_Calcular();
            bllBitacora = new BLL_BitacoraEvento();
            dalDigito = new DAL_DigitoVerificador();
            dalUsuario = new DAL_Usuario();
        }

        // =================================================================
        // Refleja el diagrama: "Modulo Verif DV"
        // =================================================================
        public bool ValidarIntegridad<T>(List<T> listaRegistros, string nombreTabla) where T : IVerificable
        {
            string cadenaAcumuladaParaDVV = "";

            // CRÍTICO: Ordenar la lista siempre por el identificador para asegurar el mismo resultado
            var listaOrdenada = listaRegistros.OrderBy(x => x.ObtenerIdentificadorFila()).ToList();

            // 1. Bucle: Por cada registro de la lista ordenada (Comprobación DVH - Fila por fila)
            foreach (T registro in listaOrdenada)
            {
                // Llama al servicio para calcular el hash del registro
                string dvhCalculado = servicioCalcular.CalcularDVH(registro);

                // Obtiene el registro de la BD usando la convención de nombres
                string nombreFila = $"{nombreTabla}_{registro.ObtenerIdentificadorFila()}";
                Servicio_DigitoVerificadorVertical registroBD = dalDigito.ObtenerRegistroDigito(nombreFila);

                // alt: EsValido == false
                if (registroBD == null || dvhCalculado != registroBD.DVH)
                {
                    string msjError = $"Violación de integridad en la tabla '{nombreTabla}'. La fila alterada corresponde a: '{registro.ObtenerIdentificadorFila()}'.";

                    bllBitacora.RegistrarBitacora(msjError, "SISTEMA", "Módulo Verif DV", 3);
                    throw new ExcepcionIntegridad(nombreTabla, registro.ObtenerIdentificadorFila(), false, msjError);
                }

                // Concatena el hash válido para el posterior cálculo del DVV
                cadenaAcumuladaParaDVV += dvhCalculado;
            }

            // 2. Comprobación Vertical (El Maestro / DVV)
            string dvvCalculadoFinal = servicioCalcular.CalcularHash(cadenaAcumuladaParaDVV);

            string nombreMaestro = $"{nombreTabla}_MAESTRO";
            Servicio_DigitoVerificadorVertical maestroBD = dalDigito.ObtenerRegistroDigito(nombreMaestro);

            // alt: integridad == false
            if (maestroBD == null || dvvCalculadoFinal != maestroBD.DVV)
            {
                string msjError = $"Violación de integridad crítica. La tabla '{nombreTabla}' ha perdido registros o sufrió una alteración estructural masiva.";

                bllBitacora.RegistrarBitacora(msjError, "SISTEMA", "Módulo Verif DV", 3);
                throw new ExcepcionIntegridad(nombreTabla, "", true, msjError);
            }

            return true;
        }

        // =================================================================
        // Refleja el diagrama: "Mod DV" (Guardar/Modificar)
        // =================================================================
        public void ActualizarDigitos<T>(T entidadModificada, List<T> listaCompleta, string nombreTabla) where T : IVerificable
        {
            // 1. Calcular y actualizar el DVH para la entidad que se acaba de modificar/crear
            string dvhCalculado = servicioCalcular.CalcularDVH(entidadModificada);
            string nombreFila = $"{nombreTabla}_{entidadModificada.ObtenerIdentificadorFila()}";

            Servicio_DigitoVerificadorVertical nuevoDVH = new Servicio_DigitoVerificadorVertical();
            nuevoDVH.Nombre = nombreFila;
            nuevoDVH.DVH = dvhCalculado;

            dalDigito.GuardarDVH(nuevoDVH); // Equivale a "ModificarFilaLocal" en el diagrama

            // CRÍTICO: Ordenar la lista completa antes de recalcular el maestro
            var listaOrdenada = listaCompleta.OrderBy(x => x.ObtenerIdentificadorFila()).ToList();

            // 2. Recalcular el DVV Maestro con todos los registros actuales
            string cadenaAcumulada = "";
            foreach (T registro in listaOrdenada)
            {
                // Se debe sumar el hash de cada entidad para armar el gran total
                cadenaAcumulada += servicioCalcular.CalcularDVH(registro);
            }

            string dvvFinal = servicioCalcular.CalcularHash(cadenaAcumulada);
            string nombreMaestro = $"{nombreTabla}_MAESTRO";

            // Usamos el constructor que diseñamos para el maestro (GenerarDVV)
            Servicio_DigitoVerificadorVertical nuevoDVV = new Servicio_DigitoVerificadorVertical(dvvFinal, nombreMaestro);

            dalDigito.GuardarDVV(nuevoDVV); // Equivale a "ModificarRegistroMaestro" en el diagrama
        }

        public void RecalcularDigitos()
        {
            RecalcularUsuarios();
            RecalcularRoles();
            RecalcularFamilias();
            
        }

        private void RecalcularUsuarios()
        {
            // CRÍTICO: Ordenar la lista de usuarios al traerla de la BD
            List<Servicio_Usuario> usuarios = dalUsuario.ListarUsuarios()
                                                        .OrderBy(u => u.ObtenerIdentificadorFila())
                                                        .ToList();

            string cadenaDVV = "";

            foreach (Servicio_Usuario usuario in usuarios)
            {
                string dvh = servicioCalcular.CalcularDVH(usuario);

                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();

                reg.Nombre = "Usuario_" + usuario.ObtenerIdentificadorFila();
                reg.DVH = dvh;

                dalDigito.GuardarDVH(reg);

                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);

            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical();

            maestro.Nombre = "Usuario_MAESTRO";
            maestro.DVV = dvv;

            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora(
                "Recalculo de Dígitos Verificadores de Usuario",
                "Sistema",
                "Seguridad",
                2);
        }

        private void RecalcularRoles()
        {
            DAL_Rol dalRol = new DAL_Rol("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            List<Servicio_Familia> roles = dalRol.ListarRoles()
                                                 .OrderBy(r => r.ObtenerIdentificadorFila())
                                                 .ToList();

            string cadenaDVV = "";

            foreach (Servicio_Familia rol in roles)
            {
                string dvh = servicioCalcular.CalcularDVH(rol);
                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical
                {
                    Nombre = "Rol_" + rol.ObtenerIdentificadorFila(),
                    DVH = dvh
                };

                dalDigito.GuardarDVH(reg);
                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical("Rol_MAESTRO", dvv);
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Roles", "Sistema", "Seguridad", 2);
        }

        private void RecalcularFamilias()
        {
            DAL_Familia dalFam = new DAL_Familia("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            List<Servicio_Familia> familias = dalFam.ListarFamilias()
                                                    .OrderBy(f => f.ObtenerIdentificadorFila())
                                                    .ToList();

            string cadenaDVV = "";

            foreach (Servicio_Familia familia in familias)
            {
                string dvh = servicioCalcular.CalcularDVH(familia);
                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical
                {
                    Nombre = "Familia_" + familia.ObtenerIdentificadorFila(),
                    DVH = dvh
                };

                dalDigito.GuardarDVH(reg);
                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical("Familia_MAESTRO", dvv);
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Familias", "Sistema", "Seguridad", 2);
        }
    }
}
