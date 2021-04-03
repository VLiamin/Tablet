using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;

namespace Tablet.Data.interfaces
{
    public interface IGeneralDevelopment
    {
        void createGeneralDevelopment(GeneralDevelopment general);

        void deleteGeneralDevelopment(String id);
    }
}
