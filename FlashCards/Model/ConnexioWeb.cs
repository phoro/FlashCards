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

        public static void connecta()
        {
            WebService_flashcats enlinia = new WebService_flashcats();


            String resposta = enlinia.responMissatge("Hola Server :)");
            
            Console.WriteLine("******************************************");
            Console.WriteLine(resposta);
            
        }
    }

}
