using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
PROGRAMMERS NAME:Bryan Cancel
STUDENT ID:20266067
CLASS:CSCI 3228 ASSIGNMENT #:7
DATE DUE:11/2/15 DATE TURNED IN:11/2/15
*/

namespace Assignment6CSharp
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
            Application.Run(new mainForm());
        }
    }
}
