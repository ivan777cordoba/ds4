using Laboratorio122;
using System;
using System.Windows.Forms;

namespace Laboratorio121  // Cambiar según el proyecto: Laboratorio122, Laboratorio123
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}