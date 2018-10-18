using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Paises
    {
        public int Add(Models.Paises value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Paises_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PaisId", value.PaisId));
                cmd.Parameters.Add(new SqlParameter("@ISO", value.ISO));
                cmd.Parameters.Add(new SqlParameter("@DscPais", value.DscPais));
                cmd.Parameters.Add(new SqlParameter("@Registro", value.Registro));
                cmd.Parameters.Add(new SqlParameter("@Modificacion", value.Modificacion));
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

        public int Edit(Models.Paises value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Paises_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PaisId", value.PaisId));
                cmd.Parameters.Add(new SqlParameter("@ISO", value.ISO));
                cmd.Parameters.Add(new SqlParameter("@DscPais", value.DscPais));
                cmd.Parameters.Add(new SqlParameter("@Registro", value.Registro));
                cmd.Parameters.Add(new SqlParameter("@Modificacion", value.Modificacion));
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
            using (SqlCommand cmd = new SqlCommand("dbo.Paises_Delete", Connection.Cnn))
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

        public Models.Paises GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Paises_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Paises record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Paises();
                                        record.PaisId = (int)(drResult["PaisId"]);
                record.ISO = (String)(drResult["ISO"]);
                record.DscPais = (String)(drResult["DscPais"]);
                record.Registro = (DateTime)(drResult["Registro"]);
                record.Modificacion = (DateTime)(drResult["Modificacion"]);
                record.Identificador = (Guid)(drResult["Identificador"]);


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

        public Models.Paises GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Paises_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Paises record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Paises();
                                        record.PaisId = (int)(drResult["PaisId"]);
                record.ISO = (String)(drResult["ISO"]);
                record.DscPais = (String)(drResult["DscPais"]);
                record.Registro = (DateTime)(drResult["Registro"]);
                record.Modificacion = (DateTime)(drResult["Modificacion"]);
                record.Identificador = (Guid)(drResult["Identificador"]);


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
          
        public List<Models.Paises> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Paises_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Paises> records = new List<Models.Paises>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Paises record = new Models.Paises();						
                                        record.PaisId = (int)(drResult["PaisId"]);
                record.ISO = (String)(drResult["ISO"]);
                record.DscPais = (String)(drResult["DscPais"]);
                record.Registro = (DateTime)(drResult["Registro"]);
                record.Modificacion = (DateTime)(drResult["Modificacion"]);
                record.Identificador = (Guid)(drResult["Identificador"]);


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