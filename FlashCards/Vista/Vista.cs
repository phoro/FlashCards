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
        // *****************************************
        // Codi copiat https://stackoverrun.com/es/q/309672
        // Permet moure la finestra sense necessitat de tenir barra de títol
        // Amb la funcio Vista_MouseDown
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // *****************************************



        //objecte per desar el controlador
        Controlador con;

        public Vista()
        {
            InitializeComponent();
            //label1.Text = "hola";
            //Setlabeltext();

            // Crida a la funció per crear un controlador
            CreaControlador();
           
        }

        private void btConnecta_Click(object sender, EventArgs e)
        {
            //con.Connecta();
            //con.UserPass(textboxUser.Text, textboxPass.Text);
            
            //con.Login("demo", "demo");
            con.Login("root", "root");

        }

        private void CreaControlador()
        {
            //Crea un controlador amb aquesta vista per paràmetre
            con = new Controlador(this);
            //labelinfo.Text = "controlador creat";

        }

        //Posa la imatge principal
        public void SetPicturePrincipal (Image imatge)
        {
            pictureboxprincipal.Image = imatge;
            pictureboxprincipal.Visible = true;
            //pictureboxprincipal.BringToFront();
        }
        

        // Estableix el valor de l'etiqueta
        public void SetlabelInfo(String text)
        {

            labelinfo.Text = text;
        }

        // Activa el mode admin
        // o el mode usuari
        public void AdminMode (Boolean admin)
        {
            // amaga login ui
            btConnecta.Visible = false;
            textboxUser.Visible = false;
            textboxPass.Visible = false;


            if (admin)
            {
                buttonAdminOn.Visible=true;
                panel2.Visible = true;
                buttonadmin1.Visible = true;
                buttonadmin2.Visible = true;
                panelbuttonadmin1.Visible = true;
                panelbuttonadmin2.Visible = true;
                buttonAdminOff.Visible = false;
                panelbuttonAdminOff.Visible = false;
            } else
            {
                buttonAdminOn.Visible = false;
                panel2.Visible = false;
                buttonadmin1.Visible = false;
                buttonadmin2.Visible = false;
                panelbuttonadmin1.Visible = false;
                panelbuttonadmin2.Visible = false;
            }
        }

        // Permet moure la finestra sense barra de títol
        private void Vista_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Tanca l'aplicació
        private void buttontancar_Click(object sender, EventArgs e)
        {
            con.Logout();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Canvia a mode admin off
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminMode(false);
            buttonAdminOff.Visible = true;
            panelbuttonAdminOff.Visible = true;
        }

        // Canvia a mode admin On
        private void buttonAdminOff_Click(object sender, EventArgs e)
        {
            AdminMode(true);
            
        }
    }
}
