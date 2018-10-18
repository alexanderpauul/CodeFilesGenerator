using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Generic;

namespace alpaul_gls.SGI.generator
{
    public partial class generator_connection : System.Web.UI.Page
    {
        // Variables
        DataTable instance = new DataTable();

        // Properties
        private string _username { get { return txtUserName.Text.Trim(); } }
        private string _passwword { get { return txtPassword.Text.Trim(); } }
        private string _servername { get { return ddlServer.SelectedValue; } }
        private string _database { get { return ddlDataBase.SelectedValue; } }
        private string _conecction_string { get { return lblConecction.Text.Trim(); } }
        private bool _authentication { get { return rdbSerAuthentication.Checked; } }
        private string _Downloable_Name { get { return ddlDataBase.SelectedValue + DateTime.Now.ToString("yyyyMMddHHmmss"); } }

        // Methods        
        protected void GetListOfServersName()
        {
            string CurrentMachineName = Environment.MachineName;
            ddlServer.Items.Add(new ListItem("-- Not Server Selected --", string.Empty));
            ddlServer.AppendDataBoundItems = true;

            instance = SmoApplication.EnumAvailableSqlServers(true);      
            ddlServer.DataBind();

            if (instance.Rows.Count == 0)
            {
                string myServer = Environment.MachineName;
                ddlServer.Items.Add(new ListItem(myServer, myServer));
            }
            else
            {
                ddlServer.DataSource = instance;
                ddlServer.DataValueField = "Name"; //Server
                ddlServer.DataTextField = "Name";
                ddlServer.DataBind();
            }

            InitializeComponents();
        }

        protected void GetDataBasesInServer()
        {
            try
            {
                Server srvdb;
                if (_authentication)
                {
                    ServerConnection srvcnn = new ServerConnection();
                    srvcnn.ServerInstance = _servername;
                    srvcnn.LoginSecure = false;
                    srvcnn.Login = _username;
                    srvcnn.Password = _passwword;
                    srvdb = new Server(srvcnn);
                }
                else
                {
                    ServerConnection srvcnn = new ServerConnection();
                    srvcnn.ServerInstance = _servername;
                    srvcnn.LoginSecure = true;
                    srvdb = new Server(srvcnn);
                }

                ddlDataBase.Items.Clear();
                foreach (Database db in srvdb.Databases)
                {
                    if (db.IsAccessible)
                    {
                        ddlDataBase.Items.Add(new ListItem(db.Name, db.Name));
                        ddlDataBase.AppendDataBoundItems = true;
                        ddlDataBase.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                ResetErrorComponents();
                CustomValidator msgError = new CustomValidator();
                msgError.IsValid = false;
                msgError.ErrorMessage = ex.Message;
                Page.Validators.Add(msgError);
            }
        }

        protected void NoteConnectionString()
        {
            if (ddlServer.SelectedValue != string.Empty)
            {
                lblConecction.Text = Utils.conecctioncommand
                             .Replace("{instance}", ddlServer.SelectedValue)
                             .Replace("{database}", ddlDataBase.SelectedValue)
                             .Replace("{security}", "Integrated Security=True;");

                if (rdbSerAuthentication.Checked)
                {
                    lblConecction.Text = Utils.conecctioncommand
                                         .Replace("{instance}", ddlServer.SelectedValue)
                                         .Replace("{database}", ddlDataBase.SelectedValue)
                                         .Replace("{security}", Utils.serverSecurity
                                         .Replace("{user}", String.IsNullOrEmpty(_username) ? "{user}" : _username)
                                         .Replace("{pwd}", String.IsNullOrEmpty(_passwword) ? "{pwd}" : _passwword));
                }
            }
        }

        protected void AuthenticatioCertify()
        {
            if ((_username.Length > 0) & (_passwword.Length > 0))
            {
                GetDataBasesInServer();
                NoteConnectionString();
            }
        }

        protected void ResetErrorComponents()
        {
            lblConecction.Text = string.Empty;
            ddlDataBase.Items.Clear();
            btnTestConecction.Text = "Test Connection";
            btnTestConecction.CssClass = "button hollow";
        }

        protected void SessionPropertyValue()
        {
            Entities.Properties obj = new Entities.Properties();
            obj.USER_NAME = _username;
            obj.PASSWORD = _passwword;
            obj.SERVER_NAME = _servername;
            obj.DATABASE = _database;
            obj.CONNECTION_STRING = _conecction_string;
            obj.AUTHENTICATION = _authentication;
            obj.DOWNLOABLE_NAME = _Downloable_Name;

            Session["Properties"] = null;
            Session["Properties"] = obj;
        }

        protected void InitializeComponents()
        {
            Entities.Properties property = (Entities.Properties)HttpContext.Current.Session["Properties"];
            if (property != null)
            {
                txtUserName.Text = property.USER_NAME;
                txtPassword.Text = property.PASSWORD;
                ddlServer.SelectedValue = property.SERVER_NAME;
                rdbSerAuthentication.Checked = property.AUTHENTICATION;
                txtUserName.Enabled = property.AUTHENTICATION ? true : false;
                txtPassword.Enabled = property.AUTHENTICATION ? true : false;
                GetDataBasesInServer();
                ddlDataBase.SelectedValue = property.DATABASE;
                lblConecction.Text = property.CONNECTION_STRING;
            }
        }

        // Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetListOfServersName();
            }
        }

        protected void ddlServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetErrorComponents();
            GetDataBasesInServer();
            NoteConnectionString();
            SessionPropertyValue();
        }

        protected void rAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = rdbSerAuthentication.Checked ? true : false;
            txtPassword.Enabled = rdbSerAuthentication.Checked ? true : false;
            AuthenticatioCertify();
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {
            AuthenticatioCertify();
        }

        protected void Passwword_TextChanged(object sender, EventArgs e)
        {
            AuthenticatioCertify();
        }

        protected void ddlDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTestConecction.Text = "Test Connection";
            btnTestConecction.CssClass = "button hollow";
            NoteConnectionString();
            SessionPropertyValue();
        }

        protected void btnTestConecction_Click(object sender, EventArgs e)
        {
            string Error = string.Empty;
            using (SqlConnection cnn = new SqlConnection(_conecction_string))
            {
                try
                {
                    cnn.Open();
                    btnTestConecction.Text = "Connection successful";
                    btnTestConecction.CssClass = "button success hollow";
                }
                catch
                {
                     Error = "Connection Failed";
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            SessionPropertyValue();
            Response.Redirect("/Generator/Tables");
        }
    }
}