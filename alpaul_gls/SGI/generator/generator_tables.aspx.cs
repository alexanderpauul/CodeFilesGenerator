using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace alpaul_gls.SGI.generator
{
    public partial class generator_tables : System.Web.UI.Page
    {
        // Variables
        List<Entities.Table> records;

        // Properties
        public Entities.Properties property { get { return (Entities.Properties)HttpContext.Current.Session["Properties"]; } }
        public string _command { get { return "USE {dbname} SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_SCHEMA, TABLE_NAME"; } }
        public List<Entities.Table> _logtables { get { return (List<Entities.Table>)HttpContext.Current.Session["tables"]; } }

        // Methods
        protected void GetListOfDbTables()
        {
            //if (_logtables != null)
            //{
            //    records = _logtables;
            //}
            //else
            //{

            using (SqlConnection cnn = new SqlConnection(property.CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(_command.Replace("{dbname}", property.DATABASE), cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;

                    records = new List<Entities.Table>();
                    IDataReader drResult = null;

                    try
                    {
                        if (cnn.State == ConnectionState.Closed)
                            cnn.Open();

                        drResult = cmd.ExecuteReader();
                        while (drResult.Read())
                        {
                            Entities.Table record = new Entities.Table();
                            record.PROCESS = false;
                            record.TABLE_CATALOG = (string)(drResult["TABLE_CATALOG"]);
                            record.TABLE_SCHEMA = (string)(drResult["TABLE_SCHEMA"]);
                            record.TABLE_NAME = (string)(drResult["TABLE_NAME"]);
                            record.TABLE_TYPE = (string)(drResult["TABLE_TYPE"]);
                            records.Add(record);
                        }

                        HttpContext.Current.Session["tables"] = null;
                        HttpContext.Current.Session.Add("tables", records);
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
            //}
        }

        protected void ShowDataBaseTable()
        {
            if (records.Count > 0)
            {
                rpRegistros.DataSource = _logtables;
                rpRegistros.DataBind();
            }
        }

        private bool TableValidation()
        {
            bool Ejecutar = false;
            foreach (Entities.Table item in _logtables)
            {
                if (item.PROCESS)
                {
                    Ejecutar = true;
                }
            }
            return Ejecutar;
        }

        // Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetListOfDbTables();
                ShowDataBaseTable();
            }
        }

        protected void chk_childs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ctrl = ((CheckBox)sender);
            (from x in _logtables
            where x.TABLE_NAME == ctrl.ValidationGroup
           select x).ToList().ForEach(x => x.PROCESS = ctrl.Checked);

            if ((ctrl.Checked == false) && (chkfather.Checked == true))
            { chkfather.Checked = false; }
        }

        protected void chk_father_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ctrl = ((CheckBox)sender);
            (from x in _logtables select x).ToList().ForEach(x => x.PROCESS = ctrl.Checked);

            foreach (RepeaterItem item in rpRegistros.Items)
            {
                CheckBox chkFound = (CheckBox)item.FindControl("chkchilds");
                chkFound.Checked = ctrl.Checked;
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            if (TableValidation())
            {
                HttpContext.Current.Session["tables"] = _logtables;
                Response.Redirect("/Generator/Process");
            }
            else
            {
                CustomValidator msgError = new CustomValidator();
                msgError.IsValid = false;
                msgError.ErrorMessage = "Please select one <strong>table</strong> at least";
                Page.Validators.Add(msgError);
            }
        }
    }
}