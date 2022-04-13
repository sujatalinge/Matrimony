using CARINSURE.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CARINSURE.DAL
{
    public class InsuranceProvidersDB
    {
        public List<InsuranceProviders> GetAllInsuranceCompanies()
        {
            List<InsuranceProviders> companies = new List<InsuranceProviders>();


            SqlConnection con = null;
            try
            {

                con = new SqlConnection(DBConstants.ConnectionString);
                SqlCommand cmd = new SqlCommand(DBConstants.spGetInsuranceProviders, con);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader =cmd.ExecuteReader();
                while (reader.Read())
                {
                    InsuranceProviders ip = new InsuranceProviders();
                    ip.Id = (int)reader["Id"];
                    ip.CompanyName = reader["CompanyName"].ToString();
                    ip.Headquarter = reader["Headquarter"].ToString();
                    ip.Ratings = (int)reader["Ratings"];

                    companies.Add(ip);
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();

               
            }
             return companies;
        }
    }
}
