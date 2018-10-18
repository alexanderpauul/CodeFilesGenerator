using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Personas
    {
        public int Add(Models.Personas value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PersonaId", value.PersonaId));
                cmd.Parameters.Add(new SqlParameter("@Nombre", value.Nombre));
                cmd.Parameters.Add(new SqlParameter("@PrimerApellido", value.PrimerApellido));
                cmd.Parameters.Add(new SqlParameter("@SegundoApellido", value.SegundoApellido));
                cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", value.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@PaisId", value.PaisId));
                cmd.Parameters.Add(new SqlParameter("@NacionalidadId", value.NacionalidadId));
                cmd.Parameters.Add(new SqlParameter("@SexoId", value.SexoId));
                cmd.Parameters.Add(new SqlParameter("@ECivilId", value.ECivilId));
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

        public int Edit(Models.Personas value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PersonaId", value.PersonaId));
                cmd.Parameters.Add(new SqlParameter("@Nombre", value.Nombre));
                cmd.Parameters.Add(new SqlParameter("@PrimerApellido", value.PrimerApellido));
                cmd.Parameters.Add(new SqlParameter("@SegundoApellido", value.SegundoApellido));
                cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", value.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@PaisId", value.PaisId));
                cmd.Parameters.Add(new SqlParameter("@NacionalidadId", value.NacionalidadId));
                cmd.Parameters.Add(new SqlParameter("@SexoId", value.SexoId));
                cmd.Parameters.Add(new SqlParameter("@ECivilId", value.ECivilId));
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
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_Delete", Connection.Cnn))
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

        public Models.Personas GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Personas record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Personas();
                                        record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.Nombre = (String)(drResult["Nombre"]);
                record.PrimerApellido = (String)(drResult["PrimerApellido"]);
                record.SegundoApellido = (String)(drResult["SegundoApellido"]);
                record.FechaNacimiento = (DateTime)(drResult["FechaNacimiento"]);
                record.PaisId = (String)(drResult["PaisId"]);
                record.NacionalidadId = (String)(drResult["NacionalidadId"]);
                record.SexoId = (String)(drResult["SexoId"]);
                record.ECivilId = (int)(drResult["ECivilId"]);
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

        public Models.Personas GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Personas record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Personas();
                                        record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.Nombre = (String)(drResult["Nombre"]);
                record.PrimerApellido = (String)(drResult["PrimerApellido"]);
                record.SegundoApellido = (String)(drResult["SegundoApellido"]);
                record.FechaNacimiento = (DateTime)(drResult["FechaNacimiento"]);
                record.PaisId = (String)(drResult["PaisId"]);
                record.NacionalidadId = (String)(drResult["NacionalidadId"]);
                record.SexoId = (String)(drResult["SexoId"]);
                record.ECivilId = (int)(drResult["ECivilId"]);
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
          
        public List<Models.Personas> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Personas> records = new List<Models.Personas>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Personas record = new Models.Personas();						
                                        record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.Nombre = (String)(drResult["Nombre"]);
                record.PrimerApellido = (String)(drResult["PrimerApellido"]);
                record.SegundoApellido = (String)(drResult["SegundoApellido"]);
                record.FechaNacimiento = (DateTime)(drResult["FechaNacimiento"]);
                record.PaisId = (String)(drResult["PaisId"]);
                record.NacionalidadId = (String)(drResult["NacionalidadId"]);
                record.SexoId = (String)(drResult["SexoId"]);
                record.ECivilId = (int)(drResult["ECivilId"]);
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
}using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Personas
    {
        public int Add(Models.Personas value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PersonaId", value.PersonaId));
                cmd.Parameters.Add(new SqlParameter("@Nombre", value.Nombre));
                cmd.Parameters.Add(new SqlParameter("@PrimerApellido", value.PrimerApellido));
                cmd.Parameters.Add(new SqlParameter("@SegundoApellido", value.SegundoApellido));
                cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", value.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@PaisId", value.PaisId));
                cmd.Parameters.Add(new SqlParameter("@NacionalidadId", value.NacionalidadId));
                cmd.Parameters.Add(new SqlParameter("@SexoId", value.SexoId));
                cmd.Parameters.Add(new SqlParameter("@ECivilId", value.ECivilId));
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

        public int Edit(Models.Personas value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@PersonaId", value.PersonaId));
                cmd.Parameters.Add(new SqlParameter("@Nombre", value.Nombre));
                cmd.Parameters.Add(new SqlParameter("@PrimerApellido", value.PrimerApellido));
                cmd.Parameters.Add(new SqlParameter("@SegundoApellido", value.SegundoApellido));
                cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", value.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@PaisId", value.PaisId));
                cmd.Parameters.Add(new SqlParameter("@NacionalidadId", value.NacionalidadId));
                cmd.Parameters.Add(new SqlParameter("@SexoId", value.SexoId));
                cmd.Parameters.Add(new SqlParameter("@ECivilId", value.ECivilId));
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
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_Delete", Connection.Cnn))
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

        public Models.Personas GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Personas record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Personas();
                                        record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.Nombre = (String)(drResult["Nombre"]);
                record.PrimerApellido = (String)(drResult["PrimerApellido"]);
                record.SegundoApellido = (String)(drResult["SegundoApellido"]);
                record.FechaNacimiento = (DateTime)(drResult["FechaNacimiento"]);
                record.PaisId = (String)(drResult["PaisId"]);
                record.NacionalidadId = (String)(drResult["NacionalidadId"]);
                record.SexoId = (String)(drResult["SexoId"]);
                record.ECivilId = (int)(drResult["ECivilId"]);
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

        public Models.Personas GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.Personas record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Personas();
                                        record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.Nombre = (String)(drResult["Nombre"]);
                record.PrimerApellido = (String)(drResult["PrimerApellido"]);
                record.SegundoApellido = (String)(drResult["SegundoApellido"]);
                record.FechaNacimiento = (DateTime)(drResult["FechaNacimiento"]);
                record.PaisId = (String)(drResult["PaisId"]);
                record.NacionalidadId = (String)(drResult["NacionalidadId"]);
                record.SexoId = (String)(drResult["SexoId"]);
                record.ECivilId = (int)(drResult["ECivilId"]);
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
          
        public List<Models.Personas> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Personas_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.Personas> records = new List<Models.Personas>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.Personas record = new Models.Personas();						
                                        record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.Nombre = (String)(drResult["Nombre"]);
                record.PrimerApellido = (String)(drResult["PrimerApellido"]);
                record.SegundoApellido = (String)(drResult["SegundoApellido"]);
                record.FechaNacimiento = (DateTime)(drResult["FechaNacimiento"]);
                record.PaisId = (String)(drResult["PaisId"]);
                record.NacionalidadId = (String)(drResult["NacionalidadId"]);
                record.SexoId = (String)(drResult["SexoId"]);
                record.ECivilId = (int)(drResult["ECivilId"]);
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