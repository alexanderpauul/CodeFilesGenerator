﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace alpaul_gls.SGI.generator
{
    public partial class generator_process : System.Web.UI.Page
    {
        // Variables
        List<Entities.Fields> records;

        // Objects in memory
        public Entities.Properties property { get { return (Entities.Properties)HttpContext.Current.Session["Properties"]; } }
        public List<Entities.Fields> _logfields { get { return (List<Entities.Fields>)HttpContext.Current.Session["fields"]; } }
        public List<Entities.Table> _logtables { get { return (List<Entities.Table>)HttpContext.Current.Session["tables"]; } }

        // Properties
        private bool _procedure { get { return chkstoredprocedured.Checked; } }
        private bool _entities { get { return chkentitieslayer.Checked; } }
        private bool _data { get { return chkdataleyer.Checked; } }
        private bool _business { get { return chkbusinesslayer.Checked; } }
        private bool _singlefile { get { return chksingelFile.Checked; } }
        private string _language { get { return ddlLanguage.SelectedValue; } }


        protected void GetListOfFieldsInTables(string database, string table, string schema)
        {
            using (SqlConnection cnn = new SqlConnection(property.CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(Utils.fieldscommand.Replace("{database}", database).Replace("{table}", table).Replace("{schema}", schema), cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;

                    records = new List<Entities.Fields>();
                    IDataReader drResult = null;

                    try
                    {
                        if (cnn.State == ConnectionState.Closed)
                            cnn.Open();

                        drResult = cmd.ExecuteReader();
                        while (drResult.Read())
                        {
                            Entities.Fields record = new Entities.Fields();
                            record.TABLE_CATALOG = (string)(drResult["TABLE_CATALOG"].ToString());
                            record.TABLE_NAME = (string)(drResult["TABLE_NAME"].ToString());
                            record.TABLE_SCHEMA = (string)(drResult["TABLE_SCHEMA"].ToString());
                            record.ORDINAL_POSITION = (int)(drResult["ORDINAL_POSITION"]);
                            record.COLUMN_NAME = (string)(drResult["COLUMN_NAME"].ToString());
                            record.DATA_TYPE = (string)(drResult["DATA_TYPE"].ToString());
                            record.IS_NULLABLE = (string)(drResult["IS_NULLABLE"].ToString());
                            record.CHARACTER_MAXIMUM_LENGTH = (int)(drResult["CHARACTER_MAXIMUM_LENGTH"]);
                            record.CONSTRAINT_TYPE = (string)(drResult["CONSTRAINT_TYPE"].ToString());
                            record.KEY_CODE = (int)(drResult["KEY_CODE"]);
                            record.CONSTRAINT_NAME = (string)(drResult["CONSTRAINT_NAME"].ToString());
                            record.COLUMN_DEFAULT = (string)(drResult["COLUMN_DEFAULT"].ToString());
                            record.TABLE_NAME_RELATIONSHIP = (string)(drResult["TABLE_NAME_RELATIONSHIP"].ToString());
                            record.CLASS_TYPE = (string)(drResult["CLASS_TYPE"].ToString());
                            records.Add(record);
                        }

                        Session["fields"] = records;
                    }
                    catch (SqlException exception)
                    {
                        records = null;
                        string Error = exception.Message;
                    }
                    finally
                    {
                        if (cnn.State == ConnectionState.Open)
                            cnn.Close();
                    }
                }
            }
        }

        private bool Validation()
        {
            bool Ejecutar = false;
            if ((_procedure == true) || (_entities == true) || (_data == true) || (_business == true))
                Ejecutar = true;

            return Ejecutar;
        }

        // Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlLanguage.DataSource = Utils.language;
                ddlLanguage.DataTextField = "Value";
                ddlLanguage.DataValueField = "Key";
                ddlLanguage.DataBind();
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            bool Excecute = false;
            if (_procedure == true)
            {
                foreach (Entities.Table item in _logtables)
                {
                    if (item.PROCESS)
                    {
                        GetListOfFieldsInTables(property.DATABASE, item.TABLE_NAME, item.TABLE_SCHEMA);
                        Builder.SqlFileBuilder(item.TABLE_CATALOG,
                                               item.TABLE_SCHEMA,
                                               item.TABLE_NAME,
                                               _language,
                                               property,
                                               _logfields);
                    }
                }

                Excecute = true;
            }

            if (_entities == true)
            {
                foreach (Entities.Table item in _logtables)
                {
                    if (item.PROCESS)
                    {
                        GetListOfFieldsInTables(property.DATABASE, item.TABLE_NAME, item.TABLE_SCHEMA);
                        Builder.ModelsBuilder(item.TABLE_NAME,
                                              _language,
                                              property,
                                              _logfields);
                    }
                }

                Excecute = true;
            }

            if (_data == true)
            {
                foreach (Entities.Table item in _logtables)
                {
                    if (item.PROCESS)
                    {
                        GetListOfFieldsInTables(property.DATABASE, item.TABLE_NAME, item.TABLE_SCHEMA);
                        Builder.DataBuilder("UASDF",
                                            item.TABLE_NAME,
                                            _language,
                                            property,
                                            _logfields);
                    }
                }

                Excecute = true;
            }

            if (_business == true)
            {
                foreach (Entities.Table item in _logtables)
                {
                    if (item.PROCESS)
                    {
                        Builder.BusinessBuilder(item.TABLE_NAME,
                                            _language,
                                            property.DOWNLOABLE_NAME);
                    }
                }

                Excecute = true;
            }

            if (_singlefile == true)
            {
                foreach (Entities.Table item in _logtables)
                {
                    if (item.PROCESS)
                    {
                        GetListOfFieldsInTables(property.DATABASE, item.TABLE_NAME, item.TABLE_SCHEMA);
                        Builder.SingleFileBuilder("UASDF",
                                                  item.TABLE_NAME,
                                                  _language,
                                                  property,
                                                  _logfields);
                    }
                }

                Excecute = true;
            }

            if (Excecute)
            {
                Response.Redirect("/Generator/Download");
            }
            else
            {
                CustomValidator msgError = new CustomValidator();
                msgError.IsValid = false;
                msgError.ErrorMessage = "Please select one or more <strong>options</strong>.";
                Page.Validators.Add(msgError);
            }
        }
    }
}