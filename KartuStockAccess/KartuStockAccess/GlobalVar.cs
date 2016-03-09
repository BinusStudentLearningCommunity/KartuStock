using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartuStockAccess
{
    class GlobalVar
    {
        static String user;
        static String pass;
        public static String User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }

        public static String Pass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }
    }
}
