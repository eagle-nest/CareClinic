using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.login
{
    class priviligeException : System.ApplicationException
    {
        public priviligeException()
            : base("This user doesnot have this privilige")
        {}
        public priviligeException(string message)
            : base("This user doesnot have this "+message+"privilige")
        { }
    }
    //****************************************************Username Password mismach exception****************************
    class mismatchException : System.ApplicationException
    {
        public mismatchException()
            : base("Incorrect User name OR Password ")
        { }
        public mismatchException(string message)
            : base(message)
        { }
    }
}
