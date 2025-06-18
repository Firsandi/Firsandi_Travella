using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Helper
{
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static bool IsLoggedIn => UserId > 0;
        public static void ClearSession()
        {
            UserId = 0;
            Username = null;
        }
        public static void Reset()
        {
            UserId = 0;
            Username = null;
        }
    }
}
