using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class AspNetUserLogins
    {
        public int Add(Models.AspNetUserLogins value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserLogins_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@LoginProvider", value.LoginProvider));
                cmd.Parameters.Add(new SqlParameter("@ProviderKey", value.ProviderKey));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));



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

        public int Edit(Models.AspNetUserLogins value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserLogins_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@LoginProvider", value.LoginProvider));
                cmd.Parameters.Add(new SqlParameter("@ProviderKey", value.ProviderKey));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));



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
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserLogins_Delete", Connection.Cnn))
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

        public Models.AspNetUserLogins GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserLogins_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.AspNetUserLogins record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.AspNetUserLogins();
                                        record.LoginProvider = (String)(drResult["LoginProvider"]);
                record.ProviderKey = (String)(drResult["ProviderKey"]);
                record.UserId = (String)(drResult["UserId"]);
                record.UserId = (String)(drResult["UserId"]);


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

        public Models.AspNetUserLogins GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserLogins_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.AspNetUserLogins record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.AspNetUserLogins();
                                        record.LoginProvider = (String)(drResult["LoginProvider"]);
                record.ProviderKey = (String)(drResult["ProviderKey"]);
                record.UserId = (String)(drResult["UserId"]);
                record.UserId = (String)(drResult["UserId"]);


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
          
        public List<Models.AspNetUserLogins> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUserLogins_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.AspNetUserLogins> records = new List<Models.AspNetUserLogins>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.AspNetUserLogins record = new Models.AspNetUserLogins();						
                                        record.LoginProvider = (String)(drResult["LoginProvider"]);
                record.ProviderKey = (String)(drResult["ProviderKey"]);
                record.UserId = (String)(drResult["UserId"]);
                record.UserId = (String)(drResult["UserId"]);


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