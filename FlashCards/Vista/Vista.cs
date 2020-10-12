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

            // Crida a la funció per crear un controlador
            CreaControlador();
            MessageBox.Show("Are you sure ...", "Login",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void btConnecta_Click(object sender, EventArgs e)
        {
            con.Connecta();
            con.UserPass(textboxUser.Text, textboxPass.Text);

        }

        private void CreaControlador()
        {
            //Crea un controlador amb aquesta vista per paràmetre
            con = new Controlador(this);
            labelinfo.Text = "controlador creat";

        }

        

        // Estableix el valor de l'etiqueta
        public void SetlabelInfo(String text)
        {

            labelinfo.Text = text;
        }

        // Activa el mode admin
        public void AdminMode (Boolean admin)
        {
            if (admin)
            {
                buttonAdmin.Visible=true;
            } else
            {
                buttonAdmin.Visible = false;
            }
        }
    }
}
