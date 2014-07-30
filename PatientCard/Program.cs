using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PatientCard.Forms;

namespace PatientCard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            domain.UnhandledException += domain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }


        static void domain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Произошла ошибка! Свяжитесь с администратором для выяснения причин", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
