using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class register_yunus
    {
        public bool IsValid(string Id, string Password, string address, string phno)
        {
            bool res = false;
            if (Id == "Test" && Password == "Test")
            {
                
                res = true;

            }
            return res;
        }

        internal bool IsValid(string uid, string pwd, string add, string phno)
        {
            throw new NotImplementedException();
        }
    }
}