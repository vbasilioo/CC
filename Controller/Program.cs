using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CareerConnect.Controller;

namespace CareerConnect{
    internal static class Program{
        
        static List<Usuario> usuarios = new List<Usuario>();

        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            Application.Run(login);
        }
    }
}
