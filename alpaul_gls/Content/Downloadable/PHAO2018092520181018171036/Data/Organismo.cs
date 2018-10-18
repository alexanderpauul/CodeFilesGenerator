using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Organismos
    {
        public int Add(Models.Organismos value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Organismos_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@OrganismoId", value.OrganismoId));
                cmd.Parameters.Add(new SqlParameter("@DscOrganismo", value.DscOrganismo));
                cmd.Parameters.Add(new SqlParameter("@Sigla", value.Sigla));
                cmd.Parameters.Add(new SqlParameter("@URL", value.URL));
                cmd.Parameters.Add(new SqlParameter("@TOrganismoId", value.TOrganismoId));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
                cmd.Parameters.Add(new SqlParameter("@Registro", value.Registro));
                cmd.Parameters.Add(new SqlParameter("@Modificacion", value.Modificacion));
                cmd.Parameters.Add(new SqlParameter("@Identificador", value.Identificador));
                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));



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

        public int Edit(Models.Organismos value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Organismos_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@OrganismoId", value.OrganismoId));
                cmd.Parameters.Add(new SqlParameter("@DscOrganismo", value.DscOrganismo));
                cmd.Parameters.Add(new SqlParameter("@Sigla", value.Sigla));
                cmd.Parameters.Add(new SqlParameter("@URL", value.URL));
                cmd.Parameters.Add(new SqlParameter("@TOrganismoId", value.TOrganismoId));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
                cmd.Parameters.Add(new SqlParameter("@Registro", value.Registro));
                cmd.Parameters.Add(new SqlParameter("@Modificacion", value.Modificacion));
                cmd.Parameters.Add(new SqlParameter("@Identificador", value.Identificador));
                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));



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
            using (SqlCommand cmd = new SqlCommand("dbo.Organismos_Delete", Connection.Cnn))
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

        public Models.Organismos GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Organismos_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Organismos record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Organismos();
                                        record.OrganismoId = (int)(drResult["OrganismoId"]);
                record.DscOrganismo = (String)(drResult["DscOrganismo"]);
                record.Sigla = (String)(drResult["Sigla"]);
                record.URL = (String)(drResult["URL"]);
                record.TOrganismoId = (int)(drResult["TOrganismoId"]);
                record.UserId = (String)(drResult["UserId"]);
                record.Registro = (DateTime)(drResult["Registro"]);
                record.Modificacion = (DateTime)(drResult["Modificacion"]);
                record.Identificador = (Guid)(drResult["Identificador"]);
                record.EstadoId = (int)(drResult["EstadoId"]);


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

        public Models.Organismos GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Organismos_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Organismos record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Organismos();
                                        record.OrganismoId = (int)(drResult["OrganismoId"]);
                record.DscOrganismo = (String)(drResult["DscOrganismo"]);
                record.Sigla = (String)(drResult["Sigla"]);
                record.URL = (String)(drResult["URL"]);
                record.TOrganismoId = (int)(drResult["TOrganismoId"]);
                record.UserId = (String)(drResult["UserId"]);
                record.Registro = (DateTime)(drResult["Registro"]);
                record.Modificacion = (DateTime)(drResult["Modificacion"]);
                record.Identificador = (Guid)(drResult["Identificador"]);
                record.EstadoId = (int)(drResult["EstadoId"]);


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
          
        public List<Models.Organismos> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Organismos_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Organismos> records = new List<Models.Organismos>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Organismos record = new Models.Organismos();						
                                        record.OrganismoId = (int)(drResult["OrganismoId"]);
                record.DscOrganismo = (String)(drResult["DscOrganismo"]);
                record.Sigla = (String)(drResult["Sigla"]);
                record.URL = (String)(drResult["URL"]);
                record.TOrganismoId = (int)(drResult["TOrganismoId"]);
                record.UserId = (String)(drResult["UserId"]);
                record.Registro = (DateTime)(drResult["Registro"]);
                record.Modificacion = (DateTime)(drResult["Modificacion"]);
                record.Identificador = (Guid)(drResult["Identificador"]);
                record.EstadoId = (int)(drResult["EstadoId"]);


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