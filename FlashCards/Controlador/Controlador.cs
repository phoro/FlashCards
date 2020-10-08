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
            Connexio.StartClient();


            vista.Setlabeltext();
            
            
        }

        public void Login()
        {
            // TODO
        }
    }
       
}
