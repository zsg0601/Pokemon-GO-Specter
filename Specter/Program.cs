﻿using System;
using System.Windows.Forms;
using Specter.Forms;
using Specter.FORMS;

namespace Specter
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmNewLogin());
        }
    }
}