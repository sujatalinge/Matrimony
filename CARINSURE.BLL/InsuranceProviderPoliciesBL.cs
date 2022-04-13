using CARINSURE.DAL;
using CARINSURE.MODELS;
using System.Collections.Generic;

namespace CARINSURE.BLL
{
    public  class InsuranceProviderPoliciesBL
    {
        InsuranceProviderPoliciesDB _db;
        public InsuranceProviderPoliciesBL()
        {
            _db = new InsuranceProviderPoliciesDB();
        }
        public List<InsuranceProviderPolicies> GetAllInsuranceCompanies()
        {
            return _db.GetAllInsuranceCompanies();
        }
    }
}
