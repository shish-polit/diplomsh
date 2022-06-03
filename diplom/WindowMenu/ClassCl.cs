using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.WindowMenu
{
   public class ClassCl
    {
        public bool Check(string login, string password)
        {
            
            string LoginUser = "admin";
            string passwordUser = "123";
            bool result = true;
            if (login == LoginUser && password == passwordUser)
            {
                result = true;
            }
            return result;
        }
    }
}
