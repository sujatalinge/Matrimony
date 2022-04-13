using CARINSURE.DAL;
using CARINSURE.MODELS;
using System.Collections.Generic;

namespace CARINSURE.BLL
{
    public  class InsuranceProvidersBL
    {
        InsuranceProvidersDB _db = null;
        public InsuranceProvidersBL()
        {
            _db = new InsuranceProvidersDB();
        }
        public List<InsuranceProviders> GetAllInsuranceCompanies()
        {
            return _db.GetAllInsuranceCompanies();
        }
    }


}
