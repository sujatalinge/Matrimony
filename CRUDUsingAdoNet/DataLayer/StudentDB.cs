using CRUDUsingAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDUsingAdoNet.DataLayer
{
    public class StudentDB
    {
        public Student GetStudentDetailsByRollNumber(int rollNumber)
        {
            Student student = new Student();

            SqlConnection con = null;

            try

            {
                con = new SqlConnection(Dbconstants.connectionString);
                SqlCommand cmd = new SqlCommand(Dbconstants.spGetStudentsByTrainerid, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student  = new Student()
                        {
                            Rollnumber = (int)reader["RollNumber"],
                            name = reader["StudentName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            
                            Trainer =new Trainer()
                            {
                                Id=(int)reader["TrainerId"],
                                name=reader["TrainerName"].ToString(),      
                            }
                        };
                    }
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }


            }

            return student;

        }
    }
}