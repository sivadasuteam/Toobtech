using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class register_yunus
    {
        public bool IsValid(string Id, string Password)
        {
            bool res = false;
            if (Id == "Test" && Password == "Test")
            {
                res = true;

            }
            return res;
        }
    }
}