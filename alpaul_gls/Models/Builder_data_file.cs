using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace alpaul_gls.Models
{
    public class Builder_data_file
    {
        public static void DataBuilder(string _namespace,
                              string table,
                              string language,
                              Entities.Properties property,
                              List<Entities.Fields> fields)
        {
            // Variables
            string lineTemplate = string.Empty;
            string linePropertyParameter = string.Empty;
            string linePropertyRecords = string.Empty;

            // SP Name
            string procedurename = string.Empty;

            // Paths
            string dataTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.dataTemplate.Replace("{language}", language));
            string dataParameter = System.Web.HttpContext.Current.Server.MapPath(Paths.dataPartsParameter.Replace("{language}", language));
            string dataRecords = System.Web.HttpContext.Current.Server.MapPath(Paths.dataPartsRecords.Replace("{language}", language));

            // Files
            string filename = string.Format("{0}.{1}", Utils.singular(table), Utils.extension(language));
            string directory = System.Web.HttpContext.Current.Server.MapPath(Paths.downloableDataUrl.Replace("{directoryname}", property.DOWNLOABLE_NAME));
            string file = System.Web.HttpContext.Current.Server.MapPath(Paths.datafile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", filename));

            // Checking if directory exists
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Loading template
            using (StreamReader sr = new StreamReader(dataTemplate))
            {
                lineTemplate = sr.ReadToEnd();
            }

            // Loading Property Parameter Template
            using (StreamReader sr = new StreamReader(dataParameter))
            {
                linePropertyParameter = sr.ReadToEnd();
            }

            // Loading Property Records Template
            using (StreamReader sr = new StreamReader(dataRecords))
            {
                linePropertyRecords = sr.ReadToEnd();
            }

            // Creating properties
            StringBuilder makerPropertyParameter = new StringBuilder();
            StringBuilder makerPropertyRecords = new StringBuilder();

            foreach (Entities.Fields field in fields)
            {
                makerPropertyParameter.Append(linePropertyParameter.Replace("{fieldname}", field.COLUMN_NAME) + Environment.NewLine);
                makerPropertyRecords.Append(linePropertyRecords.Replace("{fieldname}", field.COLUMN_NAME).Replace("{type}", (language == "VB" ? "Integer" : field.CLASS_TYPE)) + Environment.NewLine);
                procedurename = string.Format("{0}.{1}", field.TABLE_SCHEMA, field.TABLE_NAME);
            }

            makerPropertyParameter.AppendLine();
            makerPropertyRecords.AppendLine();

            // Adding properties
            StreamWriter sw = new StreamWriter(file, true, Encoding.ASCII);
            sw.Write(lineTemplate.Replace("@classname", table)
                                 .Replace("@procedurename", procedurename)
                                 .Replace("@sqlparameter", makerPropertyParameter.ToString())
                                 .Replace("@sqldata", makerPropertyRecords.ToString()));
            sw.Close();
        }
    }
}