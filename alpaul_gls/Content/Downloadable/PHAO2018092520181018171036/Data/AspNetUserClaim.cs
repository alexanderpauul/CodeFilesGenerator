using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class AspNetUserClaims
    {
        public int Add(Models.AspNetUserClaims value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserClaims_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@Id", value.Id));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
                cmd.Parameters.Add(new SqlParameter("@ClaimType", value.ClaimType));
                cmd.Parameters.Add(new SqlParameter("@ClaimValue", value.ClaimValue));



                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    return (int)(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                 {
                    return 0;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public int Edit(Models.AspNetUserClaims value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserClaims_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@Id", value.Id));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
                cmd.Parameters.Add(new SqlParameter("@ClaimType", value.ClaimType));
                cmd.Parameters.Add(new SqlParameter("@ClaimValue", value.ClaimValue));



                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    return (int)(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    return 0;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public int Delete(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserClaims_Delete", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    return (int)(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    return 0;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public Models.AspNetUserClaims GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserClaims_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.AspNetUserClaims record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.AspNetUserClaims();
                                        record.Id = (int)(drResult["Id"]);
                record.UserId = (String)(drResult["UserId"]);
                record.ClaimType = (String)(drResult["ClaimType"]);
                record.ClaimValue = (String)(drResult["ClaimValue"]);


                    }

                    return record;
                }
                catch (SqlException ex)
                {
                    return record;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public Models.AspNetUserClaims GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserClaims_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.AspNetUserClaims record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.AspNetUserClaims();
                                        record.Id = (int)(drResult["Id"]);
                record.UserId = (String)(drResult["UserId"]);
                record.ClaimType = (String)(drResult["ClaimType"]);
                record.ClaimValue = (String)(drResult["ClaimValue"]);


                    }

                    return record;
                }
                catch (SqlException ex)
                {
                    return record;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }
          
        public List<Models.AspNetUserClaims> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserClaims_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.AspNetUserClaims> records = new List<Models.AspNetUserClaims>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.AspNetUserClaims record = new Models.AspNetUserClaims();						
                                        record.Id = (int)(drResult["Id"]);
                record.UserId = (String)(drResult["UserId"]);
                record.ClaimType = (String)(drResult["ClaimType"]);
                record.ClaimValue = (String)(drResult["ClaimValue"]);


                        records.Add(record);
                    }

                    return registros;
                }
                catch (SqlException ex)
                {
                    return registros;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }
    }
}