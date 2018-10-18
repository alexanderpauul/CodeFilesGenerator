using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class AspNetUsers
    {
        public int Add(Models.AspNetUsers value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@Id", value.Id));
                cmd.Parameters.Add(new SqlParameter("@PersonaId", value.PersonaId));
                cmd.Parameters.Add(new SqlParameter("@IsDisable", value.IsDisable));
                cmd.Parameters.Add(new SqlParameter("@Email", value.Email));
                cmd.Parameters.Add(new SqlParameter("@EmailConfirmed", value.EmailConfirmed));
                cmd.Parameters.Add(new SqlParameter("@PasswordHash", value.PasswordHash));
                cmd.Parameters.Add(new SqlParameter("@SecurityStamp", value.SecurityStamp));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", value.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumberConfirmed", value.PhoneNumberConfirmed));
                cmd.Parameters.Add(new SqlParameter("@TwoFactorEnabled", value.TwoFactorEnabled));
                cmd.Parameters.Add(new SqlParameter("@LockoutEndDateUtc", value.LockoutEndDateUtc));
                cmd.Parameters.Add(new SqlParameter("@LockoutEnabled", value.LockoutEnabled));
                cmd.Parameters.Add(new SqlParameter("@AccessFailedCount", value.AccessFailedCount));
                cmd.Parameters.Add(new SqlParameter("@UserName", value.UserName));



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

        public int Edit(Models.AspNetUsers value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@Id", value.Id));
                cmd.Parameters.Add(new SqlParameter("@PersonaId", value.PersonaId));
                cmd.Parameters.Add(new SqlParameter("@IsDisable", value.IsDisable));
                cmd.Parameters.Add(new SqlParameter("@Email", value.Email));
                cmd.Parameters.Add(new SqlParameter("@EmailConfirmed", value.EmailConfirmed));
                cmd.Parameters.Add(new SqlParameter("@PasswordHash", value.PasswordHash));
                cmd.Parameters.Add(new SqlParameter("@SecurityStamp", value.SecurityStamp));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumber", value.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@PhoneNumberConfirmed", value.PhoneNumberConfirmed));
                cmd.Parameters.Add(new SqlParameter("@TwoFactorEnabled", value.TwoFactorEnabled));
                cmd.Parameters.Add(new SqlParameter("@LockoutEndDateUtc", value.LockoutEndDateUtc));
                cmd.Parameters.Add(new SqlParameter("@LockoutEnabled", value.LockoutEnabled));
                cmd.Parameters.Add(new SqlParameter("@AccessFailedCount", value.AccessFailedCount));
                cmd.Parameters.Add(new SqlParameter("@UserName", value.UserName));



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
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_Delete", Connection.Cnn))
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

        public Models.AspNetUsers GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.AspNetUsers record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.AspNetUsers();
                                        record.Id = (String)(drResult["Id"]);
                record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.IsDisable = (bool)(drResult["IsDisable"]);
                record.Email = (String)(drResult["Email"]);
                record.EmailConfirmed = (bool)(drResult["EmailConfirmed"]);
                record.PasswordHash = (String)(drResult["PasswordHash"]);
                record.SecurityStamp = (String)(drResult["SecurityStamp"]);
                record.PhoneNumber = (String)(drResult["PhoneNumber"]);
                record.PhoneNumberConfirmed = (bool)(drResult["PhoneNumberConfirmed"]);
                record.TwoFactorEnabled = (bool)(drResult["TwoFactorEnabled"]);
                record.LockoutEndDateUtc = (DateTime)(drResult["LockoutEndDateUtc"]);
                record.LockoutEnabled = (bool)(drResult["LockoutEnabled"]);
                record.AccessFailedCount = (int)(drResult["AccessFailedCount"]);
                record.UserName = (String)(drResult["UserName"]);


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

        public Models.AspNetUsers GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Models.AspNetUsers record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Models.AspNetUsers();
                                        record.Id = (String)(drResult["Id"]);
                record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.IsDisable = (bool)(drResult["IsDisable"]);
                record.Email = (String)(drResult["Email"]);
                record.EmailConfirmed = (bool)(drResult["EmailConfirmed"]);
                record.PasswordHash = (String)(drResult["PasswordHash"]);
                record.SecurityStamp = (String)(drResult["SecurityStamp"]);
                record.PhoneNumber = (String)(drResult["PhoneNumber"]);
                record.PhoneNumberConfirmed = (bool)(drResult["PhoneNumberConfirmed"]);
                record.TwoFactorEnabled = (bool)(drResult["TwoFactorEnabled"]);
                record.LockoutEndDateUtc = (DateTime)(drResult["LockoutEndDateUtc"]);
                record.LockoutEnabled = (bool)(drResult["LockoutEnabled"]);
                record.AccessFailedCount = (int)(drResult["AccessFailedCount"]);
                record.UserName = (String)(drResult["UserName"]);


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
          
        public List<Models.AspNetUsers> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AspNetUsers_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Models.AspNetUsers> records = new List<Models.AspNetUsers>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Models.AspNetUsers record = new Models.AspNetUsers();						
                                        record.Id = (String)(drResult["Id"]);
                record.PersonaId = (Guid)(drResult["PersonaId"]);
                record.IsDisable = (bool)(drResult["IsDisable"]);
                record.Email = (String)(drResult["Email"]);
                record.EmailConfirmed = (bool)(drResult["EmailConfirmed"]);
                record.PasswordHash = (String)(drResult["PasswordHash"]);
                record.SecurityStamp = (String)(drResult["SecurityStamp"]);
                record.PhoneNumber = (String)(drResult["PhoneNumber"]);
                record.PhoneNumberConfirmed = (bool)(drResult["PhoneNumberConfirmed"]);
                record.TwoFactorEnabled = (bool)(drResult["TwoFactorEnabled"]);
                record.LockoutEndDateUtc = (DateTime)(drResult["LockoutEndDateUtc"]);
                record.LockoutEnabled = (bool)(drResult["LockoutEnabled"]);
                record.AccessFailedCount = (int)(drResult["AccessFailedCount"]);
                record.UserName = (String)(drResult["UserName"]);


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