using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;

namespace Application.BLL
{
    public interface ICompanyManager
    {
        int Save(Company company);
        List<Company> GetAll();

    }
}
