using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Draft
{
    class LoginMananger
    {
        public static class LoginManager
        {
            private static bool isLoggedIn = false;

            public static bool IsLoggedIn
            {
                get { return isLoggedIn; }
            }

            public static void Login()
            {
                isLoggedIn = true;
            }

            public static void Logout()
            {
                isLoggedIn = false;
            }
        }
    }
}
