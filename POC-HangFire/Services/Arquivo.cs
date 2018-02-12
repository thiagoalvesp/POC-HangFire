using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace POC_HangFire.Services
{
    public class Arquivo
    {
        public static string Criar(string texto)
        {
            try
            {
                string path = @"c:\teste";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < 30000; i++)
                {
                    sb.Append(texto);
                    sb.Append(" ");
                    sb.Append(System.Guid.NewGuid().ToString());
                    sb.AppendLine();
                }

                string filePath = @"C:\teste\" + System.Guid.NewGuid().ToString() + ".txt";
                System.IO.File.WriteAllText(filePath, sb.ToString());

                return filePath;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}