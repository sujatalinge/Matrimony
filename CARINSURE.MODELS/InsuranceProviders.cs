using System;

namespace CARINSURE.MODELS
{
    [Serializable]
    public  class InsuranceProviders
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string  Headquarter { get; set; }
        public int Ratings { get; set; }

    }
}
