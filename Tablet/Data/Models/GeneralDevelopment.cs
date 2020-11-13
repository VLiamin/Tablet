using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tablet.Data.Models
{
    public class GeneralDevelopment
    {
        private readonly AppDBContent appDBContent;

        public GeneralDevelopment(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public String Id { get; set; }
        public DateTime Date { get; set; }
        public int Forecast { get; set; }
        public int Progress { get; set; }

    }
}
