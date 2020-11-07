using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class Project
    {
        public int id { set; get; }
        public String name { set; get; }
        public String customer { set; get; }
        public String developer { set; get; }
     //   public List<String> problems { get; set; }

        public String technology { get; set; }

        public int cost { get; set; }

    }
}
