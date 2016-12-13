using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application.BLL;

namespace SimpleWebApplication.Controllers
{
    public class BaseApiController: ApiController
    {
        public ICompanyManager CompanyManager=> new CompanyManager();
        public ICountryManager CountryManager=> new CountryManager();
    }
}