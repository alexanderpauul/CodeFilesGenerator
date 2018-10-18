using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class __MigrationHistory
    {
        public int Add(Models.__MigrationHistory value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.__MigrationHistory_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@MigrationId", value.MigrationId));
                cmd.Parameters.Add(new SqlParameter("@ContextKey", value.ContextKey));
                cmd.Parameters.Add(new SqlParameter("@Model", value.Model));
                cmd.Parameters.Add(new SqlParameter("@ProductVersion", value.ProductVersion));



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

        public int Edit(Models.__MigrationHistory value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.__MigrationHistory_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@MigrationId", value.MigrationId));
                cmd.Parameters.Add(new SqlParameter("@ContextKey", value.ContextKey));
                cmd.Parameters.Add(new SqlParameter("@Model", value.Model));
                cmd.Parameters.Add(new SqlParameter("@ProductVersion", value.ProductVersion));



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
            using (SqlCommand cmd = new SqlCommand("dbo.__MigrationHistory_Delete", Connection.Cnn))
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

        public Models.__MigrationHistory GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.__MigrationHistory_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.__MigrationHistory record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.__MigrationHistory();
                                        record.MigrationId = (String)(drResult["MigrationId"]);
                record.ContextKey = (String)(drResult["ContextKey"]);
                record.Model = (byte[])(drResult["Model"]);
                record.ProductVersion = (String)(drResult["ProductVersion"]);


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

        public Models.__MigrationHistory GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.__MigrationHistory_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.__MigrationHistory record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.__MigrationHistory();
                                        record.MigrationId = (String)(drResult["MigrationId"]);
                record.ContextKey = (String)(drResult["ContextKey"]);
                record.Model = (byte[])(drResult["Model"]);
                record.ProductVersion = (String)(drResult["ProductVersion"]);


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
          
        public List<Models.__MigrationHistory> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.__MigrationHistory_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.__MigrationHistory> records = new List<Models.__MigrationHistory>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.__MigrationHistory record = new Models.__MigrationHistory();						
                                        record.MigrationId = (String)(drResult["MigrationId"]);
                record.ContextKey = (String)(drResult["ContextKey"]);
                record.Model = (byte[])(drResult["Model"]);
                record.ProductVersion = (String)(drResult["ProductVersion"]);


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