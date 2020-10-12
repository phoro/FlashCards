using FlashCards.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class Controlador
    {
        //objectes vista i model
        //private Connexio con;
        private Vista vista;

        
        // Constructor. Requereix un objecte Vista on actuar
                
        public Controlador(Vista vista)
        {
            this.vista = vista;
            

        }
        
        public void Connecta()
        {
            //TO DO
            // Inici socket client
            // Connexio.

            // connexió socket
            //Connexio.StartClient(vista);
            //vista.Setlabeltext();

            //Connexio webservice i desa la resposta
            String resposta = ConnexioWeb.connecta(vista);
            AnalitzaResposta(resposta);
            
            
        }

        public void AnalitzaResposta(string resposta)
        {
            if (resposta.Equals("Missatge rebut: Hola Server :)"))
            {
                //modo admin
                vista.AdminMode(true);

            } else
            {
                //mode usuari
            }

        }

        // Desa momentaniament usuari i pass
        public void UserPass(string user, string pass)
        {
            String usuari = user;
            String password = pass;
        }

        public void Login()
        {
            // TODO
        }
    }
       
}
