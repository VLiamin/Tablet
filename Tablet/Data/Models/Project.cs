﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class Project
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public String Customer { set; get; }
        public String Developer { set; get; }
     //   public List<String> problems { get; set; }

        public String Technology { get; set; }

        public int Cost { get; set; }

    }
}
