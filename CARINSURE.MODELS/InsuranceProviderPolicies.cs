using System;

namespace CARINSURE.MODELS
{
    [Serializable]
    public class InsuranceProviderPolicies
    {
        public int Id { get; set; }
        public string PolicyName { get; set; }
        public string Maturity { get; set; }
        public int Price { get; set; }
        public int CompanyId { get; set; }

        public InsuranceProviders Provider { get; set; }
    }
}
