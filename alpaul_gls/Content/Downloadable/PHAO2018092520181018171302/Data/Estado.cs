using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Estados
    {
        public int Add(Models.Estados value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));
                cmd.Parameters.Add(new SqlParameter("@TEstadoId", value.TEstadoId));
                cmd.Parameters.Add(new SqlParameter("@DscEstado", value.DscEstado));
                cmd.Parameters.Add(new SqlParameter("@Habilitado", value.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
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

        public int Edit(Models.Estados value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));
                cmd.Parameters.Add(new SqlParameter("@TEstadoId", value.TEstadoId));
                cmd.Parameters.Add(new SqlParameter("@DscEstado", value.DscEstado));
                cmd.Parameters.Add(new SqlParameter("@Habilitado", value.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
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
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_Delete", Connection.Cnn))
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

        public Models.Estados GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Estados record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Estados();
                                        record.EstadoId = (int)(drResult["EstadoId"]);
                record.TEstadoId = (int)(drResult["TEstadoId"]);
                record.DscEstado = (String)(drResult["DscEstado"]);
                record.Habilitado = (bool)(drResult["Habilitado"]);
                record.UserId = (String)(drResult["UserId"]);
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

        public Models.Estados GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Estados record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Estados();
                                        record.EstadoId = (int)(drResult["EstadoId"]);
                record.TEstadoId = (int)(drResult["TEstadoId"]);
                record.DscEstado = (String)(drResult["DscEstado"]);
                record.Habilitado = (bool)(drResult["Habilitado"]);
                record.UserId = (String)(drResult["UserId"]);
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
          
        public List<Models.Estados> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Estados> records = new List<Models.Estados>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Estados record = new Models.Estados();						
                                        record.EstadoId = (int)(drResult["EstadoId"]);
                record.TEstadoId = (int)(drResult["TEstadoId"]);
                record.DscEstado = (String)(drResult["DscEstado"]);
                record.Habilitado = (bool)(drResult["Habilitado"]);
                record.UserId = (String)(drResult["UserId"]);
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
}using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Estados
    {
        public int Add(Models.Estados value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));
                cmd.Parameters.Add(new SqlParameter("@TEstadoId", value.TEstadoId));
                cmd.Parameters.Add(new SqlParameter("@DscEstado", value.DscEstado));
                cmd.Parameters.Add(new SqlParameter("@Habilitado", value.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
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

        public int Edit(Models.Estados value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));
                cmd.Parameters.Add(new SqlParameter("@TEstadoId", value.TEstadoId));
                cmd.Parameters.Add(new SqlParameter("@DscEstado", value.DscEstado));
                cmd.Parameters.Add(new SqlParameter("@Habilitado", value.Habilitado));
                cmd.Parameters.Add(new SqlParameter("@UserId", value.UserId));
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
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_Delete", Connection.Cnn))
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

        public Models.Estados GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Estados record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Estados();
                                        record.EstadoId = (int)(drResult["EstadoId"]);
                record.TEstadoId = (int)(drResult["TEstadoId"]);
                record.DscEstado = (String)(drResult["DscEstado"]);
                record.Habilitado = (bool)(drResult["Habilitado"]);
                record.UserId = (String)(drResult["UserId"]);
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

        public Models.Estados GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Estados record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Estados();
                                        record.EstadoId = (int)(drResult["EstadoId"]);
                record.TEstadoId = (int)(drResult["TEstadoId"]);
                record.DscEstado = (String)(drResult["DscEstado"]);
                record.Habilitado = (bool)(drResult["Habilitado"]);
                record.UserId = (String)(drResult["UserId"]);
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
          
        public List<Models.Estados> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Estados_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Estados> records = new List<Models.Estados>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Estados record = new Models.Estados();						
                                        record.EstadoId = (int)(drResult["EstadoId"]);
                record.TEstadoId = (int)(drResult["TEstadoId"]);
                record.DscEstado = (String)(drResult["DscEstado"]);
                record.Habilitado = (bool)(drResult["Habilitado"]);
                record.UserId = (String)(drResult["UserId"]);
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