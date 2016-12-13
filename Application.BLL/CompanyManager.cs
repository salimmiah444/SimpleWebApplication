using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appliaction.DataAccess;
using Application.Entities;

namespace Application.BLL
{
    public class CompanyManager : ICompanyManager
    {
        private readonly DataContext _dataContext;

        public CompanyManager()
        {
            _dataContext = new DataContext();
        }

        public int Save(Company company)
        {
            _dataContext.Companies.Add(company);
            _dataContext.SaveChanges();
            return company.Id;
        }

        public List<Company> GetAll()
        {
            return _dataContext.Companies.ToList();
        }
    }
}
