using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Stored_Procedure_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

            //// This was a test to see if I could launch Notepad after the application closed
            //Process MSSQLcmdinstaller = new Process();
            
            //try
            //{
            //    MSSQLcmdinstaller.StartInfo.FileName = "notepad.exe";
            //    MSSQLcmdinstaller.Start();

            //    Console.WriteLine("ID: {0} - Name: {1}", MSSQLcmdinstaller.Id, MSSQLcmdinstaller.ProcessName);

            //    MSSQLcmdinstaller.WaitForExit();
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
        }
    }
}
