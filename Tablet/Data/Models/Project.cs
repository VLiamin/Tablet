using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Tablet.Data.Models
{
    public class Project
    {
        public String Id { set; get; }
        public String Name { set; get; }
        public String Customer { set; get; }
        public String Developer { set; get; }
        public String Technology { get; set; }
        public int Cost { get; set; }

    }
}
