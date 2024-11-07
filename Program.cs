using System;
using BasesDiccionario.Connection;
namespace BasesDiccionario
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MianForm());
            Connect dbConnect = new Connect(
                "chancar",
                "oracle",
                "localhost",
                1521,
                "Bases"
            );

            dbConnect.Conectar();    
        }
    }
}