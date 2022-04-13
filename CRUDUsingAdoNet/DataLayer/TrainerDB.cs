using CRUDUsingAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CRUDUsingAdoNet.DataLayer
{
    public class TrainerDB
    {
        public List<Trainer> GetTraianers()
        {
            List<Trainer> trainers = new List<Trainer>();
            SqlConnection con = null;

            try

            {
                con = new SqlConnection(Dbconstants.connectionString);
                SqlCommand cmd = new SqlCommand(Dbconstants.spGetTrainers, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Trainer t = new Trainer()
                        {
                            Id = (int)reader["ID"],
                            name = reader["name"].ToString(),
                            Salary =(long)reader["Salary"]

                        };
                        trainers.Add(t);
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
            return trainers;
        }

        public List<Student> GetStudentsByTrainerId(int trainerId)
        {
            List<Student> students = new List<Student>();

            SqlConnection con = null;

            try

            {
                con = new SqlConnection(Dbconstants.connectionString);
                SqlCommand cmd = new SqlCommand(Dbconstants.spGetStudentsByTrainerid, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Trainerid", trainerId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student t = new Student()
                        {
                            Rollnumber = (int)reader["RollNumber"],
                            name = reader["name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            TrainerId = (int?)reader["TrainerId"]

                        };
                        students.Add(t);
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

            return students;

        }

        public bool create(Trainer trainer)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(Dbconstants.connectionString);
                SqlCommand cmd = new SqlCommand(Dbconstants.spCreateTrainer, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", trainer.name);
                cmd.Parameters.AddWithValue("@Salary", trainer.Salary);


                SqlParameter inserstatus = new SqlParameter()
                {
                    ParameterName = "@insertStatus",
                    SqlDbType = SqlDbType.Bit,
                     Direction = ParameterDirection.Output
                };
              cmd.Parameters.Add(inserstatus);
              con.Open();
                cmd.ExecuteNonQuery();

                return (bool)inserstatus.Value;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                if(con!= null)
                {
                    con.Close();
                }

            }
        }

        public bool Update(Trainer trainer)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(Dbconstants.connectionString);
                SqlCommand cmd = new SqlCommand(Dbconstants.spUpdateTrainer, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", trainer.Id);

                cmd.Parameters.AddWithValue("@Name", trainer.name);
                cmd.Parameters.AddWithValue("@Salary", trainer.Salary);


                SqlParameter Updatestatus = new SqlParameter()
                {
                    ParameterName = "@UpdateStatus",
                    SqlDbType = SqlDbType.Bit,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(Updatestatus);
                con.Open();
                cmd.ExecuteNonQuery();

                return (bool)Updatestatus.Value;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }

        public bool Delete(int trainerId)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(Dbconstants.connectionString);
                SqlCommand cmd = new SqlCommand(Dbconstants.spDeleteTrainer, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainerId", trainerId);

                SqlParameter DeleteStatus = new SqlParameter()
                {
                    ParameterName = "@DeleteStatus",
                    SqlDbType = SqlDbType.Bit,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(DeleteStatus);
                con.Open();
                cmd.ExecuteNonQuery();

                return (bool)DeleteStatus.Value;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }


    }
}