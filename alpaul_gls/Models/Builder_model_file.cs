using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace alpaul_gls.Models
{
    public class Builder_model_file
    {
        public static void ModelsBuilder(string table,
                                 string language,
                                 Entities.Properties property,
                                 List<Entities.Fields> fields)
        {
            // Variables
            string lineTemplate = string.Empty;
            string lineProperty = string.Empty;

            // Paths
            string modelTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.modelTemplate.Replace("{language}", language));
            string modelPartTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.modelParts.Replace("{language}", language));

            // Files
            string filename = string.Format("{0}.{1}", Utils.singular(table), Utils.extension(language));
            string directory = System.Web.HttpContext.Current.Server.MapPath(Paths.downloableModelsUrl.Replace("{directoryname}", property.DOWNLOABLE_NAME));
            string file = System.Web.HttpContext.Current.Server.MapPath(Paths.modelfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", filename));

            // Checking if directory exists
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Loading template
            using (StreamReader sr = new StreamReader(modelTemplate))
            {
                lineTemplate = sr.ReadToEnd();
            }

            // Loading template
            using (StreamReader sr = new StreamReader(modelPartTemplate))
            {
                lineProperty = sr.ReadToEnd();
            }

            // Creating properties
            StringBuilder maker = new StringBuilder();
            foreach (Entities.Fields field in fields)
            {
                maker.Append(lineProperty.Replace("{type}", field.CLASS_TYPE).Replace("{fieldname}", field.COLUMN_NAME) + Environment.NewLine);
            }
            maker.AppendLine();

            // Adding properties
            StreamWriter sw = new StreamWriter(file, true, Encoding.ASCII);
            sw.Write(lineTemplate.Replace("@classname", table).Replace("@property", maker.ToString()));
            sw.Close();
        }
    }
}