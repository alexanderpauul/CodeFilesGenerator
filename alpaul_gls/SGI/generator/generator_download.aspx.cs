using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace alpaul_gls.SGI.generator
{
    public partial class generator_download : System.Web.UI.Page
    {
        public Entities.Properties _property { get { return (Entities.Properties)HttpContext.Current.Session["Properties"]; } }

        protected void BtnDownload_Click(object sender, EventArgs e)
        {
            string directory = Server.MapPath(string.Format("/Content/Downloadable/{0}", _property.DOWNLOABLE_NAME));
            DirectoryInfo files = new DirectoryInfo(directory);

            Response.AddHeader("Content-Disposition", "attachment; filename=" + _property.DOWNLOABLE_NAME  + ".zip");
            Response.ContentType = "application/zip";

            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(directory);
                zip.Save(Response.OutputStream);
            }
        }
    }
}