using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace AspnetCore_WebAPI.Models
{
    public class ConsumoApi
    {
        class Program
        {
            
            private static string _urlBase;
            private static void PercorrerAPI(HttpClient client)
            {
                var cursos = HttpClient client
                foreach (string name in cursos)
                {
                    var n= (cursos[name]);
                }

                foreach (string description in cursos)
                {
                    var d =(cursos[description]);
                }
                foreach (string imageUrl in cursos)
                {
                    var i =(cursos[imageUrl]);
                }
                return n,d,i
            }
            private static void PercorrerNomes( HttpClient client,palavra)
            {
                var cursos = HttpClient client
                foreach (string name in cursos)
                {
                    if palavra in name
                        return name;
                    else
                        break;

                }
            }
            


        }
    }
}
