using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Application.BLL;
using Application.Entities;

namespace SimpleWebApplication.Controllers
{
    public class CompanyApiController : BaseApiController
    {
        /// <summary>
        /// Get all Company
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        [ResponseType(typeof(List<Company>))]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(CompanyManager.GetAll());
        }
        
        /// <summary>
        /// Create a company
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpPost]
        public HttpResponseMessage Post([FromBody]Company company)
        {
            var model = new Company
            {
                Name = company.Name,
                CountryId = company.CountryId
            };

            var companyId = CompanyManager.Save(model);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;

        }




    }
}
