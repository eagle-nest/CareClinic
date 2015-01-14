using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.login
{
    class loginLogic
    {
        string privilige = "Admin";
        string userName = "eagle";
        string password = "12345";
        public string athunticate(string privilige, string userName, string password)
        {
            
            try
            {
                if (this.userName == userName && this.password == password)
                    if (this.privilige == privilige)
                        return "true";
                    else throw new login.priviligeException();
                else
                    throw new login.mismatchException();

            }
            catch (priviligeException pe)
            { return pe.Message; }
            catch (mismatchException me)
            { return me.Message; }
        }
    }
}
