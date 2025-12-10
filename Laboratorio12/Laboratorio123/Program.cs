using System;
using System.Windows.Forms;
using Laboratorio123; // Asegúrese de que el namespace coincida con el del proyecto
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