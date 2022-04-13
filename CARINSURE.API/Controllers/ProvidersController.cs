using CARINSURE.BLL;
using CARINSURE.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CARINSURE.API.Controllers
{
    [RoutePrefix("providers")]
    public class ProvidersController : ApiController
    {
        //  [HttpGet]
        //   public string GetName()
        // {
        //   return "Vishal";

        //  }
        //get all insurance providers

        //all providers //Get :https://localhost:44334/api/Providers

        //web api
        // [HttpGet]
        //public IEnumerable<InsuranceProviders> Providers()
        //  public HttpResponseMessage Providers()
        //  {
        //       InsuranceProvidersBL bl = new InsuranceProvidersBL(); //bll

        //      //return bl.GetAllInsuranceCompanies();
        //       var providers = bl.GetAllInsuranceCompanies();
        //     return Request.CreateResponse(HttpStatusCode.OK, providers);

        //   }

        //Web api 2

        [Route("")]
        [HttpGet]
        public IHttpActionResult Providers()
        {
            InsuranceProvidersBL bl = new InsuranceProvidersBL(); //bll

            //      return bl.GetAllInsuranceCompanies();
            var providers = bl.GetAllInsuranceCompanies();
            //return Request.CreateResponse(HttpStatusCode.OK, providers);
            return Ok(providers);

        }

        //providerbyid Get :https://localhost:44334/api/Providers/1

        [Route("{providerId}")]
        [HttpGet]
    // public InsuranceProviders ProvidersById(int ProviderId)
    public IHttpActionResult ProvidersById([FromUri] int providerId)
     {
          if (providerId > 0)

          {
              InsuranceProvidersBL bl = new InsuranceProvidersBL(); //bll

              var provider = bl.GetAllInsuranceCompanies().
                 FirstOrDefault(p => p.Id.Equals(providerId));

              if (provider == null)
              {
                  return NotFound();
              }

              return Ok(provider);
          }
          else
          {
             return BadRequest("please check your request");

          }
      }

        //create provider post: https://localhost:44334/api/Providers
        [HttpPost]
        public IHttpActionResult Create([FromBody] InsuranceProviders Provider)
        {
            //logic to insert provider to db


            return Ok(true);
        }
        [HttpPut]

        //update provider put: https://localhost:44334/api/Providers
        public IHttpActionResult Update([FromUri] int ProviderId, [FromBody] InsuranceProviders Provider)
        {
            //logic to update provider to db


            return Ok(true);



        }


        //delete provider  delete : https://localhost:44334/api/Providers/1
        [HttpDelete]
        public IHttpActionResult Delete([FromUri] int ProviderId)
        {
            //logic to delete provider from db
            return Ok(true);

        }
        public IHttpActionResult Edit()
        {
            return Ok(true);
        }
    }
}
