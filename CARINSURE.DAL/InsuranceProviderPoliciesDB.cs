using CARINSURE.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CARINSURE.DAL
{
    public   class InsuranceProviderPoliciesDB
    {
        public List<InsuranceProviderPolicies> GetAllInsuranceCompanies()
        {
            List<InsuranceProviderPolicies> policies = new List<InsuranceProviderPolicies>();


            SqlConnection con = null;
            try
            {

                con = new SqlConnection(DBConstants.ConnectionString);
                SqlCommand cmd = new SqlCommand(DBConstants.spGetPoliciesAllProviders, con);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InsuranceProviderPolicies ip = new InsuranceProviderPolicies();
                    ip.Id = (int)reader["PolicyId"];
                    ip.PolicyName = reader["PolicyName"].ToString();
                    ip.Price = (int) reader["Price"];
                    ip.CompanyId = (int)reader["ProviderId"];

                    ip.Provider = new InsuranceProviders();

                    ip.Provider.Id = (int)reader["ProviderId"];
                    ip.Provider.CompanyName =  reader["CompanyName"].ToString();

                    policies.Add(ip);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();


            }
            return policies;
        }
    }
}
