﻿using DashboardTurismoReal.FormProducto;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
/*
 * Autor: Néstor Ignacio Larenas Ortega
 * Fecha: 05/07/2023
 * Copyright (c) 2023
 * Licencia: Derechos Reservados.
 */
namespace DashboardTurismoReal
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


            // Configurar el subproceso principal como STA
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

            // Crear una instancia de IConfiguration para leer la configuración
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Pasar la configuración al crear una instancia de MainForm
            Application.Run(new FormLogin());
            //Application.Run(new MainForm(configuration));
        }
    }
}
