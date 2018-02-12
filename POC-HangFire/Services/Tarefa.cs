using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_HangFire.Services
{
    public class Tarefa
    {
        public static void Executar(string texto)
        {
            string user = "AlmaNegra";
            string psw = "1234";
            string url = @"ftp://127.0.0.1:21/" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt" ;
            FTP.EnviarArquivo(Arquivo.Criar(texto), url, user, psw);
           
        }
    }
}