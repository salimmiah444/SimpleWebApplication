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
    public class CountryApiController : BaseApiController
    {
        /// <summary>
        /// Get all country
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        [ResponseType(typeof(List<Country>))]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(CountryManager.GetAll());
        }
        
       




    }
}
