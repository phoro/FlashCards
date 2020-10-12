using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class Vista : Form
    {
        //objecte per desar el controlador
        Controlador con;

        public Vista()
        {
            InitializeComponent();
            //label1.Text = "hola";
            //Setlabeltext();

            CreaControlador();
        }

        private void btConnecta_Click(object sender, EventArgs e)
        {
            con.Connecta();
        }

        private void CreaControlador()
        {
            //Crea un controlador amb aquesta vista per paràmetre
            con = new Controlador(this);
            labelinfo.Text = "controlador creat";

        }

        // Estableix el valor de l'etiqueta
       public void Setlabeltext ()
        {
            
            label1.Text = "controlador funcional";
        }
        public void SetlabelInfo(String text)
        {

            labelinfo.Text = text;
        }
    }
}
