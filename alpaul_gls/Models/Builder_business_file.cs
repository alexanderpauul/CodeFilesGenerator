using System.IO;
using System.Text;

namespace alpaul_gls.Models
{
    public class Builder_business_file
    {
        public static void BusinessBuilder(string table,
                                   string language,
                                   string DOWNLOABLE_NAME)
        {
            // Variables
            string lineTemplate = string.Empty;

            // Paths
            string businesstemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.businessTemplate.Replace("{language}", language));

            // Files
            string filename = string.Format("{0}.{1}", Utils.singular(table), Utils.extension(language));
            string directory = System.Web.HttpContext.Current.Server.MapPath(Paths.downloableBusinessUrl.Replace("{directoryname}", DOWNLOABLE_NAME));
            string file = System.Web.HttpContext.Current.Server.MapPath(Paths.businessfile.Replace("{database}", DOWNLOABLE_NAME).Replace("{filename}", filename));

            // Checking if directory exists
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Loading template
            using (StreamReader sr = new StreamReader(businesstemplate))
            {
                lineTemplate = sr.ReadToEnd();
            }

            StreamWriter sw = new StreamWriter(file, true, Encoding.ASCII);
            sw.Write(lineTemplate.Replace("@classname", Utils.singular(table)));
            sw.Close();
        }
    }
}