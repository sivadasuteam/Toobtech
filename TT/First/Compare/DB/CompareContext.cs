using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Compare.DB
{
    public class CompareContext:DbContext
    {
      
        public CompareContext():base("CompareContext")
        {

        }

        public System.Data.Entity.DbSet<Compare.DB.Product> Products { get; set; }
    }


}