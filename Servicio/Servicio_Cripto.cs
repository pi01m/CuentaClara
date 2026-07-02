using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Servicio
{
    public class Servicio_Cripto
    {
        public string CalcularHash(string cadena)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(cadena);
                byte[] hashBytes = sha.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
