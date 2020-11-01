using FlashCards.net.ddns.jlzorita;
using OpenQA.Selenium;
using System.IO;
namespace FlashCards.Model
{
    /// <summary>
    /// Altes, baixes i modificacions de 
    /// temes, categories i targetes.
    /// @Robert Guiral
    /// </summary>
    class Temes
    {
        /* ***************************************
         *          AUXILIARS   
         *****************************************/
        /// <summary>
        /// Mètode que retorna el número de files d'una taula de la base de dades.
        /// </summary>
        /// <param name="codi_sessio"></param>
        /// <param name="nom_taula"></param>
        /// <returns>Mètode que retorna el número de files d'una taula de la base de dades.</returns>
        public static int NumeroFiles(string codi_sessio, string nom_taula)
        {
            WebService_flashcats enlinia = new WebService_flashcats();
            int nombre = enlinia.numeroFiles(codi_sessio, nom_taula);
            return nombre;
        }

        public static void BaixaFitxer()
        {
            WebService_flashcats enlinia = new WebService_flashcats();
            byte[] baixa = enlinia.baixaFitxer();
            System.IO.File.WriteAllBytes("imatge.png", baixa);
        }

        /* ***************************************
         *             
         *****************************************/
        /// <summary>
        /// Carrega una flashcard
        /// </summary>
        /// <param name="anvers_text">text de la pregunta</param>
        /// <param name="revers_text">text de la resposta</param>
        public static void CarregaFlashcard(Vista vista, string anvers_text, string revers_text)
        {
            vista.SetlabelPregunta(anvers_text);
            vista.SetlabelResposta(revers_text);
        }

        /* ***************************************
         *              ALTES 
         *****************************************/

        /// <summary>
        /// Dona d'alta un tema, assignant-li un nom i una descripció
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="nom">nom del tema</param>
        /// <param name="descripcio">descripció</param>
        /// returns> 1 = alta; -1 = usuari no té permís; -2 = tema ja existeix;-3 = Error sentència SQL.</returns>
        public static int AltaTema(string codi_sessio, string nom, string descripcio)
        {

            //TODO

            WebService_flashcats enlinia = new WebService_flashcats();
            int resposta = enlinia.altaTema(codi_sessio, nom, descripcio);

            return resposta;
        }

        /// <summary>
        /// dona d'alta una categoria especificant el tema, el nom i una descripció
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi_tema">codi del tema</param>
        /// <param name="nom">nom de la categoria</param>
        /// <param name="descripcio">descripció</param>
        /// <returns>retorna true / false si s'ha pogut donar d'alta o no</returns>
        public bool AltaCategoria(string codi_sessio, string codi_tema, string nom, string descripcio)
        {
            bool altaFeta = false;
            //TODO
            return altaFeta;
        }
        /// <summary>
        /// donar d'alta una flashcard especificant un tema i una categoria
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi_tema">codi del tema</param>
        /// <param name="codi_categoria">codi de la categoria</param>
        /// <param name="anvers_text">text de l'anvers</param>
        /// <param name="anvers_imatge">imatge de l'anvers</param>
        /// <param name="anvers_so">so de l'anvers</param>
        /// <param name="anvers_video">video de l'anvers</param>
        /// <param name="revers_text">text del revers</param>
        /// <returns>retorna true / false si s'ha pogut donar d'alta o no</returns>
        public bool AltaFlashcard(string codi_sessio, string codi_tema, string codi_categoria, string anvers_text, string anvers_imatge, string anvers_so, string anvers_video, string revers_text)
        {
            bool altaFeta = false;
            //TODO
            return altaFeta;
        }

        /* ***************************************
         *          ACTUALITZAR
         *****************************************/

        /// <summary>
        /// Modifica una tema existent
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi">codi del tema</param>
        /// <param name="nom"></param>
        /// <param name="descripcio"></param>
        /// <returns>retorna true / false si s'ha pogut modificar o no</returns>
        public bool CanviTema(string codi_sessio, string codi, string nom, string descripcio)
        {
            bool canviFet = false;
            //TODO
            return canviFet;
        }

        /// <summary>
        /// Modifica una categoria existent
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi">codi de la categoria</param>
        /// <param name="nom"></param>
        /// <param name="descripcio"></param>
        /// <returns>retorna true / false si s'ha pogut modificar o no</returns>
        public bool CanviCategoria(string codi_sessio, string codi, string nom, string descripcio)
        {
            bool canviFet = false;
            //TODO
            return canviFet;
        }

        /// <summary>
        /// Modifica una targeta existent
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi">codi de la targeta</param>
        /// <param name="anvers_text"></param>
        /// <param name="anvers_imatge"></param>
        /// <param name="anvers_so"></param>
        /// <param name="anvers_video"></param>
        /// <param name="revers_text"></param>
        /// <returns>retorna true / false si s'ha pogut modificar o no</returns>
        public bool CanviFlashcard(string codi_sessio, string codi, string anvers_text, string anvers_imatge, string anvers_so, string anvers_video, string revers_text)
        {
            bool canviFet = false;
            //TODO
            return canviFet;
        }

        /* ***************************************
         *              ESBORRAR
         *****************************************/

        /// <summary>
        /// Esborra un tema
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi">codi del tema</param>
        /// <returns>retorna true / false si s'ha pogut esborrar o no</returns>
        public bool EsborraTema(string codi_sessio, string codi)
        {
            bool esborratFet = false;
            //TODO
            return esborratFet;

        }

        /// <summary>
        /// Esborra una categoria
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi">codi de la categoria</param>
        /// <returns>retorna true / false si s'ha pogut esborrar o no</returns>
        public bool EsborraCategoria(string codi_sessio, string codi)
        {
            bool esborratFet = false;
            //TODO
            return esborratFet;
        }

        /// <summary>
        /// Esborra una targeta
        /// </summary>
        /// <param name="codi_sessio">codi de la sessió</param>
        /// <param name="codi">codi de la targeta</param>
        /// <returns>retorna true / false si s'ha pogut esborrar o no</returns>
        public bool EsborraFlashcard(string codi_sessio, string codi)
        {
            bool esborratFet = false;
            //TODO
            return esborratFet;
        }
    }
}
