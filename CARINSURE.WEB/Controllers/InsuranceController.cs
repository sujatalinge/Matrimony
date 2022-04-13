using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using CARINSURE.WEB.CarInsuranceService;
using CARINSURE.WEB.MyWCFService;


namespace CARINSURE.WEB.Controllers
{
    public class InsuranceController : Controller
    {
        // GET: Insurance
        public ActionResult Index()
        {
            //with the help of wsdl we get proxy classess
            //proxy class helps us to craete object and call service method

            //called asmx service method
            //    CarinsureSoapClient client = new CarinsureSoapClient();

            //   List<CarInsuranceService.InsuranceProviders> providers =
            //                     client.GetInsuranceProviders().ToList();
            //  return View(providers);

            //called wcf service method

      //     Service1Client client = new Service1Client();
        //    var providers = client.GetProviders().ToList();

         //   call api method
            IEnumerable<MODELS.InsuranceProviders> providers = GetProviders();

            return View(providers);
        }
        private IEnumerable<MODELS.InsuranceProviders> GetProviders()
        {
            IEnumerable<MODELS.InsuranceProviders> providers = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44315/api");
                //HTTP GET
                var responseTask = client.GetAsync("providers");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.
                        ReadAsAsync<IList<MODELS.InsuranceProviders>>();
                    readTask.Wait();

                 providers = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                   providers = Enumerable.Empty<MODELS.InsuranceProviders>();

                    ModelState.AddModelError
                        (string.Empty, "Server error. Please contact administrator.");
               }
            }
          return providers;
        } 
    }
}