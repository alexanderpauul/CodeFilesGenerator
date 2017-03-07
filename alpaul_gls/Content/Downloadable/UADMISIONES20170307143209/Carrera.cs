using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient;

namespace @database
{
    public class Carreras
    {
            public int CarreraId { get; set; }
    public string Codigo { get; set; }
    public String DscCarrera { get; set; }
    public int TCarreraId { get; set; }
    public int UsuarioId { get; set; }
    public DateTime FechaRegistro { get; set; }
    public DateTime Modificacion { get; set; }
    public Guid Identificador { get; set; }
    public int EstadoId { get; set; }
    public String Diccionario_Key { get; set; }

        

        public Carreras()
        { }

        public static bool Add(Carreras value)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection("ConnectionString");
            SqlCommand cmd = new SqlCommand("@procedurename_Add", connection);
			                cmd.Parameters.Add(new SqlParameter("@CarreraId", value.CarreraId));
                cmd.Parameters.Add(new SqlParameter("@Codigo", value.Codigo));
                cmd.Parameters.Add(new SqlParameter("@DscCarrera", value.DscCarrera));
                cmd.Parameters.Add(new SqlParameter("@TCarreraId", value.TCarreraId));
                cmd.Parameters.Add(new SqlParameter("@UsuarioId", value.UsuarioId));
                cmd.Parameters.Add(new SqlParameter("@FechaRegistro", value.FechaRegistro));
                cmd.Parameters.Add(new SqlParameter("@Modificacion", value.Modificacion));
                cmd.Parameters.Add(new SqlParameter("@Identificador", value.Identificador));
                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));
                cmd.Parameters.Add(new SqlParameter("@Diccionario_Key", value.Diccionario_Key));


			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;            

            try
            {
                if (connection.State == ConnectionState.Closed)
				    connection.Open();
                
                cmd.ExecuteNonQuery();
				result = true;
            }
            catch (SqlException exception)
            {
                result = false;
                string Error = exception.Message;               
            }
            finally
            {
                cmd.Dispose();
				if (connection.State == ConnectionState.Open)
				    connection.Close();
            }
            return result;
        }

        public static bool Edit(Carreras value)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection("ConnectionString");
            SqlCommand cmd = new SqlCommand("@procedurename_Edit", connection);
                            cmd.Parameters.Add(new SqlParameter("@CarreraId", value.CarreraId));
                cmd.Parameters.Add(new SqlParameter("@Codigo", value.Codigo));
                cmd.Parameters.Add(new SqlParameter("@DscCarrera", value.DscCarrera));
                cmd.Parameters.Add(new SqlParameter("@TCarreraId", value.TCarreraId));
                cmd.Parameters.Add(new SqlParameter("@UsuarioId", value.UsuarioId));
                cmd.Parameters.Add(new SqlParameter("@FechaRegistro", value.FechaRegistro));
                cmd.Parameters.Add(new SqlParameter("@Modificacion", value.Modificacion));
                cmd.Parameters.Add(new SqlParameter("@Identificador", value.Identificador));
                cmd.Parameters.Add(new SqlParameter("@EstadoId", value.EstadoId));
                cmd.Parameters.Add(new SqlParameter("@Diccionario_Key", value.Diccionario_Key));


			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;            

            try
            {
                if (connection.State == ConnectionState.Closed)
				    connection.Open();
                
                cmd.ExecuteNonQuery();
				result = true;
            }
            catch (SqlException exception)
            {
                result = false;
                string Error = exception.Message;               
            }
            finally
            {
                cmd.Dispose();
				if (connection.State == ConnectionState.Open)
				    connection.Close();
            }
            return result;
        }

		public static bool Delete(string value)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection("ConnectionString");
            SqlCommand cmd = new SqlCommand("@procedurename_Delete", connection);
            cmd.Parameters.Add(new SqlParameter("@fielId", value));
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;            

            try
            {
                if (connection.State == ConnectionState.Closed)
				    connection.Open();
                
                cmd.ExecuteNonQuery();
				result = true;
            }
            catch (SqlException exception)
            {
                result = false;
                string Error = exception.Message;               
            }
            finally
            {
                cmd.Dispose();
				if (connection.State == ConnectionState.Open)
				    connection.Close();
            }
            return result;
        }

        public static Carreras GetById(string value)
        {
            DataTable Resultado = new DataTable();

            SqlConnection connection = new SqlConnection("ConnectionString");
            SqlCommand cmd = new SqlCommand("@procedurename_GetById", connection);
            cmd.Parameters.Add(new SqlParameter("@fielId", value));
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;    

			 IDataReader drResult = null;
             Carreras record = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
				    connection.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Carreras();
                                        registro.CarreraId = (int)(drResultado["CarreraId"]);
                registro.Codigo = (string)(drResultado["Codigo"]);
                registro.DscCarrera = (String)(drResultado["DscCarrera"]);
                registro.TCarreraId = (int)(drResultado["TCarreraId"]);
                registro.UsuarioId = (int)(drResultado["UsuarioId"]);
                registro.FechaRegistro = (DateTime)(drResultado["FechaRegistro"]);
                registro.Modificacion = (DateTime)(drResultado["Modificacion"]);
                registro.Identificador = (Guid)(drResultado["Identificador"]);
                registro.EstadoId = (int)(drResultado["EstadoId"]);
                registro.Diccionario_Key = (String)(drResultado["Diccionario_Key"]);


                    }

                    return record;
            }
            catch (SqlException exception)
            {
                return record;
                string Error = exception.Message;                
            }
            finally
            {
                command.Dispose();
				if (connection.State == ConnectionState.Open)
				    connection.Close();
            }
        }

	    public static Carreras GetByGUID(string value)
        {
            DataTable Resultado = new DataTable();

            SqlConnection connection = new SqlConnection("ConnectionString");
            SqlCommand cmd = new SqlCommand("@procedurename_GetByGUID", connection);
            cmd.Parameters.Add(new SqlParameter("@fielId", value));
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;    

			 IDataReader drResult = null;
             Carreras record = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
				    connection.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.Carreras();
                                        registro.CarreraId = (int)(drResultado["CarreraId"]);
                registro.Codigo = (string)(drResultado["Codigo"]);
                registro.DscCarrera = (String)(drResultado["DscCarrera"]);
                registro.TCarreraId = (int)(drResultado["TCarreraId"]);
                registro.UsuarioId = (int)(drResultado["UsuarioId"]);
                registro.FechaRegistro = (DateTime)(drResultado["FechaRegistro"]);
                registro.Modificacion = (DateTime)(drResultado["Modificacion"]);
                registro.Identificador = (Guid)(drResultado["Identificador"]);
                registro.EstadoId = (int)(drResultado["EstadoId"]);
                registro.Diccionario_Key = (String)(drResultado["Diccionario_Key"]);


                    }

                    return record;
            }
            catch (SqlException exception)
            {
                return record;
                string Error = exception.Message;                
            }
            finally
            {
                command.Dispose();
				if (connection.State == ConnectionState.Open)
				    connection.Close();
            }
        }

	    public static List<Carreras> GetAll()
        {
            SqlConnection connection = new SqlConnection("ConnectionString");
            SqlCommand cmd = new SqlCommand("@procedurename_GetByGUID", connection);          
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;      

			 IDataReader drResult = null;
             List<Carreras> records = new List<Carreras>();

            try
            {
                if (connection.State == ConnectionState.Closed)
				    connection.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
					    Carreras record = new Carreras();
                                        registro.CarreraId = (int)(drResultado["CarreraId"]);
                registro.Codigo = (string)(drResultado["Codigo"]);
                registro.DscCarrera = (String)(drResultado["DscCarrera"]);
                registro.TCarreraId = (int)(drResultado["TCarreraId"]);
                registro.UsuarioId = (int)(drResultado["UsuarioId"]);
                registro.FechaRegistro = (DateTime)(drResultado["FechaRegistro"]);
                registro.Modificacion = (DateTime)(drResultado["Modificacion"]);
                registro.Identificador = (Guid)(drResultado["Identificador"]);
                registro.EstadoId = (int)(drResultado["EstadoId"]);
                registro.Diccionario_Key = (String)(drResultado["Diccionario_Key"]);


						records.Add(record);
                    }

                    return records;
            }
            catch (SqlException exception)
            {
                return records;
                string Error = exception.Message;                
            }
            finally
            {
                command.Dispose();
				if (connection.State == ConnectionState.Open)
				    connection.Close();
            }
        }
    }
}
