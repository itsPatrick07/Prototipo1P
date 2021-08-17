using System;
using CapaVista;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    public class Class1
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIPrincipal());
        }
    }
}
