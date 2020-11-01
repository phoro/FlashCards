using FlashCards.Model;
using System;
using System.Drawing;

namespace FlashCards
{
    /// <summary>
    /// Classe controlador.
    /// Intermediària entre el Model i la Vista.
    /// @Robert Guiral
    /// </summary>
    public class Controlador

    {

        // Imatge benvinguda
        Image imatge = Image.FromFile("F:/Repositori/FlashCards/FlashCards/Assets/presentacio_ROB2702.jpg");
        // Imatge bàsica neutre
        Image imatge_neutre = Image.FromFile("F:/Repositori/FlashCards/FlashCards/Assets/neutre_800x600.jpg");

        // Codi de sessió
        // Necessari per totes les crides posteriors al login
        String codisessio = "";


        private Vista vista;


        /// <summary>
        /// Constructor de la classe
        /// </summary>
        /// <param name="vista">Objecte vista on actuarà </param>
        public Controlador(Vista vista)
        {
            this.vista = vista;


        }
        /* ***************************************
         *         CONNEXIÓ     
         *****************************************/

        /// <summary>
        /// Anàlitza la resposta del servidor
        /// </summary>
        /// <param name="primera">primer element del vector</param>
        /// <param name="segona">segon element del vector</param>
        /// Es pot mirar l'encapçalament de <c>ConnexioWeb </c> per més info.
        public void AnalitzaResposta(string primera, string segona)
        {
            vista.SetlabelInfo("analitzant resposta" + " primera: " + primera + " segona: " + segona);

            if ((primera == "0") && (segona == "0"))
            {
                // Usuari no reconegut
                vista.SetlabelInfo("usuari no reconegut");

            }
            else if ((primera != "0") && (segona == "1"))
            {
                codisessio = primera;
                //modo admin

                //Mostra el botó per activar el mode admin
                vista.AdminMode(true);
                PosaImatge(imatge);
                vista.SetlabelInfo("administrador");
            }
            else if ((primera != "0") && (segona == "0"))
            {
                codisessio = primera;
                //mode usuari
                vista.AdminMode(false);
                PosaImatge(imatge);
                vista.SetlabelInfo("usuari");
            }
            else if ((primera != "0") && (segona == "-1"))
            {
                codisessio = primera;
                // sessió ja iniciada
            }

        }

        /// <summary>
        /// Carrega imatge principal
        /// </summary>
        /// <param name="imatge">imatge de benvinguda</param>
        public void PosaImatge(Image imatge)
        {
            vista.SetPicturePrincipal(imatge);
        }


        /// <summary>
        /// Fa login al servidor
        /// </summary>
        /// <param name="user">usuari</param>
        /// <param name="pass">password</param>
        public void Login(string user, string pass)
        {
            //Connexio webservice i desa la resposta
            String[] resposta = ConnexioWeb.Login(user, pass);
            AnalitzaResposta(resposta[0], resposta[1]);
        }

        /// <summary>
        /// Fa logout al servidor
        /// </summary>
        public void Logout()
        {
            ConnexioWeb.Logout(codisessio);

        }

        /* ***************************************
         *              TEMES      
         *****************************************/


        /// <summary>
        /// Carrega una flashcard
        /// </summary>
        public void CarregaFlashCard()
        {
            vista.SetPicturePrincipal(imatge_neutre);
            Temes.CarregaFlashcard(vista, "2+2 = ?", "4");
            vista.SetFlashcardMode(0);

        }

        public void NumeroFiles()
        {
            int nombre = Temes.NumeroFiles(codisessio, "temes");
            vista.SetlabelInfo(nombre.ToString());
        }

        public void AltaTema()
        {
            int resposta = Temes.AltaTema(codisessio, "Càlcul Mental", "Reptes de càlcul mental");
            // <returns>1 = alta; -1 = usuari no té permís; -2 = tema ja existeix;-3 = Error sentència SQL.</returns>
            switch (resposta)
            {
                case 1:
                    vista.SetlabelInfo("alta feta");
                    break;
                case -1:
                    vista.SetlabelInfo("usuari no té permís");
                    break;
                case -2:
                    vista.SetlabelInfo("tema ja existeix");
                    break;
                case -3:
                    vista.SetlabelInfo("Error sentència SQL");
                    break;
                default:
                    break;

            }
            vista.SetlabelInfo(resposta.ToString());

        }
        /* ***************************************
        *              AUXILIARS      
        *****************************************/
        public  void BaixaFitxer()
        {
            Temes.BaixaFitxer();
        }

    }

}
