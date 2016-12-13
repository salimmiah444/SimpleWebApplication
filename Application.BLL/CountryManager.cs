using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appliaction.DataAccess;
using Application.Entities;

namespace Application.BLL
{
    public class CountryManager : ICountryManager
    {
        private readonly DataContext _dataContext;

        public CountryManager()
        {
            _dataContext = new DataContext();

        }
        public List<Country> GetAll()
        {
            return _dataContext.Countries.ToList();
        }
    }
}
