using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlashCards
{
    /// <summary>
    /// Finestra principal de l'apliació.
    /// Interfície d'usuari.
    /// @Robert Guiral
    /// </summary>
    public partial class Vista : Form
    {
        // *****************************************
        // Aquestes línies de codi s'han copiat de:
        // https://stackoverrun.com/es/q/309672
        // *****************************************
        // Permet moure la finestra sense necessitat de tenir barra de títol
        // amb la funcio Vista_MouseDown
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // *****************************************


        // variable que informa de l'estat de la UI
        private Boolean adminmode = false;

        //objecte per desar el controlador
        Controlador con;

        /// <summary>
        /// Constructor de la classe.
        /// Crida a <c>CreaControlador()</c> per tenir un <c>Controlador</c> associat.
        /// </summary>
        public Vista()
        {
            InitializeComponent();

            // Crida a la funció per crear un controlador
            CreaControlador();

        }

        /// <summary>
        /// Fa Login al servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnecta_Click(object sender, EventArgs e)
        {

            string pass = "";
            string user = "";

            // captura text
            user = textboxUser.Text;
            pass = textboxPass.Text;


            //Fa login al servidor amb el text capturat dels textbox
            con.Login(user, pass);

        }
        /// <summary>
        /// Crea un controlador amb aquesta vista per paràmetre
        /// </summary>
        private void CreaControlador()
        {

            con = new Controlador(this);

        }

        /// <summary>
        /// Accepta polsar tecla 'intro' per connectar com alternativa al clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textboxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btConnecta.PerformClick();
            }

        }


        /// <summary>
        /// Carrega la imatge principal
        /// </summary>
        /// <param name="imatge"></param>
        public void SetPicturePrincipal(Image imatge)
        {
            pictureboxprincipal.Image = imatge;
            pictureboxprincipal.Visible = true;
            //pictureboxprincipal.BringToFront();
        }


        /// <summary>
        /// Estableix el valor de l'etiqueta
        /// </summary>
        /// <param name="text">text que es mostrarà a l'etiqueta</param>
        public void SetlabelInfo(String text)
        {

            labelinfo.Text = text;
        }

        /// <summary>
        /// Estableix el text de la pregunta
        /// </summary>
        /// <param name="text">text que es mostrarà a l'etiqueta</param>
        public void SetlabelPregunta(String text)
        {

            labelpregunta.Text = text;
        }

        /// <summary>
        /// Estableix el text de la resposta
        /// </summary>
        /// <param name="text">text que es mostrarà a l'etiqueta</param>
        public void SetlabelResposta(String text)
        {

            labelresposta.Text = text;
        }

        /// <summary>
        /// Activa el mode admin o el mode usuari
        /// </summary>
        /// <param name="admin"></param>
        public void AdminMode(Boolean admin)
        {
            // amaga login ui
            btConnecta.Visible = false;
            textboxUser.Visible = false;
            textboxPass.Visible = false;


            if (admin)
            {
                //Visibilitza mode admin
                labeltitoladmin.Visible = true;
                Setadminmode(true);
                buttonAdminOn.Visible = true;
                panel2.Visible = true;
                buttonadmin1.Visible = true;
                buttonadmincrea.Visible = true;
                
                buttonAdminOff.Visible = false;
                panelbuttonAdminOff.Visible = false;
                buttonadmincrea.Visible = false;
                buttonadminesborra.Visible = false;
                buttonadminflashcard.Visible = true;
            }
            else
            {
                //Amaga mode admin
                labeltitoladmin.Visible = false;
                Setadminmode(false);
                buttonAdminOn.Visible = false;
                panel2.Visible = false;
                buttonadmin1.Visible = false;
                buttonadminflashcard.Visible = false;
                
                buttonadmincrea.Visible = false;
                buttonadminesborra.Visible = false;
                buttonacttema.Visible = false;

                

                buttoncreaflashcard.Visible = false;
                buttonesborraflashcard.Visible = false;
                buttonactflashcard.Visible = false;
            }
        }


        /// <summary>
        /// Permet moure la finestra sense necessitat de tenir barra de títol.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vista_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        /// <summary>
        /// Tanca l'aplicació i fa logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttontancar_Click(object sender, EventArgs e)
        {
            con.Logout();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Canvia a mode admin off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminMode(false);
            buttonAdminOff.Visible = true;
            panelbuttonAdminOff.Visible = true;
        }


        /// <summary>
        /// Canvia a mode admin On
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdminOff_Click(object sender, EventArgs e)
        {
            AdminMode(true);

        }


        /// <summary>
        /// Selecciona tot el text quan s'entra al textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textboxPass_Enter(object sender, EventArgs e)
        {
            textboxPass.SelectAll();
        }


        /// <summary>
        /// Selecciona tot el text quan s'entra al textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textboxUser_Enter(object sender, EventArgs e)
        {
            textboxUser.SelectAll();
        }

        //Getters & Setters
        public bool Getadminmode()
        {
            return adminmode;
        }
        /// <summary>
        /// Setter de la variable adminmode
        /// </summary>
        /// <param name="adminmode">true: On ; false: Off</param>
        public void Setadminmode(bool adminmode)
        {
            this.adminmode = adminmode;
        }

        private void buttonTemes_Click(object sender, EventArgs e)
        {
            //Connexió en fase de proves
            con.CarregaFlashCard();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor">0: mode pregunta; 1: mode resposta</param>
        public void SetFlashcardMode(int valor)
        {
            if (valor > 0)
            {
                // mode resposta
                SetlabelInfo("mode resposta");

                /*
                labelpregunta.Visible = false;
                labelresposta.Visible = true;
                buttonencert.Visible = true;
                buttonerror.Visible = true;
                buttonfacil.Visible = true;
                buttonresposta.Visible = false;
                */
                panelresposta.Visible = true;
                panelpregunta.Visible = false;
            }
            else
            {
                //mode pregunta
                
                SetlabelInfo("mode pregunta");
                /*
                panelinfo.Visible = true;
                labelpregunta.Visible = true;
                labelresposta.Visible = false;

                buttonencert.Visible = false;
                buttonerror.Visible = false;
                buttonfacil.Visible = false;
                buttonresposta.Visible = true;
                */
                panelpregunta.Visible = true;
                panelresposta.Visible = false;
               
            }

        }

        private void buttonresposta_Click(object sender, EventArgs e)
        {
            SetFlashcardMode(1);
        }

        private void buttonadmin1_Click(object sender, EventArgs e)
        {
            buttonadmincrea.Visible = true;
            buttonadminesborra.Visible = true;
            buttonacttema.Visible = true;
            buttoncreaflashcard.Visible = false;
            buttonesborraflashcard.Visible = false;
            buttonactflashcard.Visible = false;
        }

        private void buttonadminesborra_Click(object sender, EventArgs e)
        {
            con.NumeroFiles();
        }

        private void buttonadmincrea_Click(object sender, EventArgs e)
        {
            con.AltaTema();
        }

        private void buttonadmincat_Click(object sender, EventArgs e)
        {
            buttonadmincrea.Visible = false;
            buttonadminesborra.Visible = false;
            buttonacttema.Visible = false;
            buttoncreaflashcard.Visible = true;
            buttonesborraflashcard.Visible = true;
            buttonactflashcard.Visible = true;

        }

        private void buttonacttema_Click(object sender, EventArgs e)
        {
            SetlabelInfo("baixar fitxer");
            con.BaixaFitxer();
        }



        /* No es fa servir?
        public void SetTextUser(string usuari)
        {
            textboxUser.Text = usuari;
        }
        public void SetTextPass(string password)
        {
            textboxPass.Text = password;
        }
        */
    }
}
