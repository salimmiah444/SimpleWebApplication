using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;

namespace Application.BLL
{
   public interface ICountryManager
    {
        List<Country> GetAll();
    }
}
