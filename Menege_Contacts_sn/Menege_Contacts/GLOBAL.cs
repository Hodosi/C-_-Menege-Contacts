using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menege_Contacts
{
    class GLOBAL
    {
        public static int GlobalUserId { get; private set; }

        public static void setGlobalUserId(int globid)
        {
            GlobalUserId = globid;
        }
    }
}
