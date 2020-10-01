using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Code
{
    class Program
    {
        static void Main()
        {
         
             FormLogin loginForm = new FormLogin();
             Application.Run(loginForm);

                if (loginForm.UserSuccessfullyAuthenticated)
                {
                    // MainForm is defined elsewhere
                    Application.Run(new FormMain());
                }
            
            
        }
    }
}
