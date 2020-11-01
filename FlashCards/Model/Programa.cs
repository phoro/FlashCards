using System;
using System.Windows.Forms;

namespace FlashCards
{
    /// <summary>
    /// Inici de l'aplicació.
    /// @Robert Guiral
    /// </summary>
    public static class Programa
    {
        /// <summary>
        /// Crea una vista.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            // Crea la vista
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vista());


        }
    }
}
