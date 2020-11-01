using FlashCards.net.ddns.jlzorita;
using System;


/*
 * 
 * **** info resposta servidor *****
 * 
 * comunicació servidor:
 * login (user, pass)
 * 0 0 -> no reconegut
 * clau i 0 o 1 (usuari normal o admin)
 * clau i -1 (sessió ja iniciada, retorna clau en memòria)
 * la clau única té el primer número 0 si és user i 1 si és admin
 * 
 *  
 * logout(clau) -> esborra la clau del hashmap d'usuaris
 * 
 *   
 * */


namespace FlashCards.Model
{

    /// <summary>
    /// Aquesta classe és l'encarregada de connectar-se amb el servidor.
    /// @Robert Guiral
    /// </summary>
    public class ConnexioWeb
    {
        /// <value> Per desar el codi de connexió actual</value>
        private String codi = "";


        /// <summary>
        /// Fa login al servidor
        /// </summary>
        /// <param name="user">Usuari</param>
        /// <param name="pass">Password</param>
        /// <returns> Torna la resposta del servidor</returns>
        public static string[] Login(string user, string pass)
        {
            WebService_flashcats enlinia = new WebService_flashcats();

            String[] resposta = enlinia.login(user, pass);

            return (resposta);
        }

        /// <summary>
        /// Fa logout al servidor
        /// </summary>
        /// <param name="codi">codi de sessió</param>
        public static void Logout(string codi)
        {
            WebService_flashcats enlinia = new WebService_flashcats();

            enlinia.logout(codi);
        }
        /* No cal aquest setter
        //***** getters && setters *******
        public void Setcodi (string codi)
        {
            this.codi = codi;
        }
     */
    }

}
