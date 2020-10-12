using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using FlashCards.net.ddns.jlzorita;


namespace FlashCards.Model
{
    class ConnexioWeb
    {

        //Connecta al webservice i torna un missatge
        public static string connecta(Vista vista)
        {
            WebService_flashcats enlinia = new WebService_flashcats();


            String resposta = enlinia.responMissatge("Hola Server :)");
            
            Console.WriteLine(resposta);
            vista.SetlabelInfo(resposta);
            return (resposta);
        }
    }

}
