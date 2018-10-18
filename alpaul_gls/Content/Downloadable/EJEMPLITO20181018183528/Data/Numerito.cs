using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Numerito
    {
        public int Add(Models.Numerito value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Numerito_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@NumeritoId", value.NumeritoId));
                cmd.Parameters.Add(new SqlParameter("@Numero", value.Numero));
                cmd.Parameters.Add(new SqlParameter("@Fecha", value.Fecha));
                cmd.Parameters.Add(new SqlParameter("@Fecha2", value.Fecha2));
                cmd.Parameters.Add(new SqlParameter("@Identificador", value.Identificador));



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

        public int Edit(Models.Numerito value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Numerito_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@NumeritoId", value.NumeritoId));
                cmd.Parameters.Add(new SqlParameter("@Numero", value.Numero));
                cmd.Parameters.Add(new SqlParameter("@Fecha", value.Fecha));
                cmd.Parameters.Add(new SqlParameter("@Fecha2", value.Fecha2));
                cmd.Parameters.Add(new SqlParameter("@Identificador", value.Identificador));



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
            using (SqlCommand cmd = new SqlCommand("dbo.Numerito_Delete", Connection.Cnn))
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

        public Models.Numerito GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Numerito_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Numerito record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Numerito();
                                        record.NumeritoId = (int)(drResult["NumeritoId"]);
                record.Numero = (String)(drResult["Numero"]);
                record.Fecha = (DateTime)(drResult["Fecha"]);
                record.Fecha2 = (DateTime)(drResult["Fecha2"]);
                record.Identificador = (String)(drResult["Identificador"]);


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

        public Models.Numerito GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Numerito_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Numerito record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Numerito();
                                        record.NumeritoId = (int)(drResult["NumeritoId"]);
                record.Numero = (String)(drResult["Numero"]);
                record.Fecha = (DateTime)(drResult["Fecha"]);
                record.Fecha2 = (DateTime)(drResult["Fecha2"]);
                record.Identificador = (String)(drResult["Identificador"]);


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
          
        public List<Models.Numerito> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Numerito_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Numerito> records = new List<Models.Numerito>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Numerito record = new Models.Numerito();						
                                        record.NumeritoId = (int)(drResult["NumeritoId"]);
                record.Numero = (String)(drResult["Numero"]);
                record.Fecha = (DateTime)(drResult["Fecha"]);
                record.Fecha2 = (DateTime)(drResult["Fecha2"]);
                record.Identificador = (String)(drResult["Identificador"]);


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