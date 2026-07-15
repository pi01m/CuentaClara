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


        public bool ValidarIntegridad<T>(List<T> listaRegistros, string nombreTabla) where T : IVerificable
        {
            string cadenaAcumuladaParaDVV = "";

           
            var listaOrdenada = listaRegistros.OrderBy(x => x.ObtenerIdentificadorFila()).ToList();

            foreach (T registro in listaOrdenada)
            {

                string dvhCalculado = servicioCalcular.CalcularDVH(registro);
                string nombreFila = $"{nombreTabla}_{registro.ObtenerIdentificadorFila()}";
                Servicio_DigitoVerificadorVertical registroBD = dalDigito.ObtenerRegistroDigito(nombreFila);

                if (registroBD == null || dvhCalculado != registroBD.DVH)
                {
                    string msjError = $"Violación de integridad en la tabla '{nombreTabla}'. La fila alterada corresponde a: '{registro.ObtenerIdentificadorFila()}'.";

                    bllBitacora.RegistrarBitacora(msjError, "Sistema", "Seguridad", 1);
                    throw new ExcepcionIntegridad(nombreTabla, registro.ObtenerIdentificadorFila(), false, msjError);
                }

                cadenaAcumuladaParaDVV += dvhCalculado;
            }

            string dvvCalculadoFinal = servicioCalcular.CalcularHash(cadenaAcumuladaParaDVV);

            string nombreMaestro = $"{nombreTabla}_MAESTRO";
            Servicio_DigitoVerificadorVertical maestroBD = dalDigito.ObtenerRegistroDigito(nombreMaestro);
            
            if (maestroBD == null || dvvCalculadoFinal != maestroBD.DVV)
            {
                string msjError = $"Violación de integridad crítica. La tabla '{nombreTabla}' ha perdido registros o sufrió una alteración estructural masiva.";

                bllBitacora.RegistrarBitacora(msjError, "Sistema", "Seguridad", 1);
                throw new ExcepcionIntegridad(nombreTabla, "", true, msjError);
            }

            return true;
        }

        public void ActualizarDigitos<T>(T entidadModificada, List<T> listaCompleta, string nombreTabla) where T : IVerificable
        {

            string dvhCalculado = servicioCalcular.CalcularDVH(entidadModificada);
            string nombreFila = $"{nombreTabla}_{entidadModificada.ObtenerIdentificadorFila()}";

            Servicio_DigitoVerificadorVertical nuevoDVH = new Servicio_DigitoVerificadorVertical();
            nuevoDVH.Nombre = nombreFila;
            nuevoDVH.DVH = dvhCalculado;

            dalDigito.GuardarDVH(nuevoDVH);

            var listaOrdenada = listaCompleta.OrderBy(x => x.ObtenerIdentificadorFila()).ToList();

            string cadenaAcumulada = "";
            foreach (T registro in listaOrdenada)
            {

                cadenaAcumulada += servicioCalcular.CalcularDVH(registro);
            }

            string dvvFinal = servicioCalcular.CalcularHash(cadenaAcumulada);
            string nombreMaestro = $"{nombreTabla}_MAESTRO";


            Servicio_DigitoVerificadorVertical nuevoDVV = new Servicio_DigitoVerificadorVertical(dvvFinal, nombreMaestro);

            dalDigito.GuardarDVV(nuevoDVV);
        }

        public void RecalcularDigitos()
        {
            string log = SessionManager.GetInstancia().GetUsuarioActual().Login;
            RecalcularUsuarios(log);
            RecalcularRoles(log);
            RecalcularFamilias(log);
            
        }

        private void RecalcularUsuarios(string log)
        { 
            List<Servicio_Usuario> usuarios = dalUsuario.ListarUsuarios().OrderBy(u => u.ObtenerIdentificadorFila()).ToList();
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

            bllBitacora.RegistrarBitacora( "Recalculo de Dígitos Verificadores de Usuario", log,"Seguridad",1);     
        }

        private void RecalcularRoles(string log)
        {
            DAL_Rol dalRol = new DAL_Rol("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            List<Servicio_Familia> roles = dalRol.ListarRoles().OrderBy(r => r.ObtenerIdentificadorFila()) .ToList();

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

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Roles", log , "Seguridad", 2);
        }

        private void RecalcularFamilias(string log)
        {
            DAL_Familia dalFam = new DAL_Familia("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            List<Servicio_Familia> familias = dalFam.ListarFamilias() .OrderBy(f => f.ObtenerIdentificadorFila()) .ToList();

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

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Familias", log, "Seguridad", 2);
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
