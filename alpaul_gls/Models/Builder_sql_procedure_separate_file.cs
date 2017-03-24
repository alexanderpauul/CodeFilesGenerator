using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace alpaul_gls.Models
{
    public class Builder_sql_procedure_separate_file
    {
        public static void SqlFileBuilder(string database,
                                  string schema,
                                  string table,
                                  string language,
                                  Entities.Properties property,
                                  List<Entities.Fields> fields)
        {
            // Variables
            string lineSqlAdd = string.Empty;
            string lineSqlDelete = string.Empty;
            string lineSqlEdit = string.Empty;
            string lineSqlSelectAll = string.Empty;
            string lineSqlSelectById = string.Empty;
            string lineSqlSelectByGUID = string.Empty;

            // Field ID
            var FielId = (from p in fields
                          where p.CONSTRAINT_TYPE == "PRIMARY KEY"
                          select p.COLUMN_NAME).First();

            // Paths
            string sqlAddTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlAddTemplate);
            string sqlDeleteTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlDeleteTemplate);
            string sqlEditTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlEditTemplate);
            string sqlSelectAllTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlSelectAllTemplate);
            string sqlSelectByGUIDTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlSelectByGUIDTemplate);
            string sqlSelectByIdTemplate = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlSelectByIdTemplate);

            //Directory Files
            string directory = System.Web.HttpContext.Current.Server.MapPath(Paths.downloableSqlFileUrl.Replace("{directoryname}", property.DOWNLOABLE_NAME));

            // Files
            string sqladdfilename = string.Format("{0}_{1}_Add.sql", schema, table);
            string sqldeletefilename = string.Format("{0}_{1}_Delete.sql", schema, table);
            string sqleditfilename = string.Format("{0}_{1}_Edit.sql", schema, table);
            string sqlselecctallfilename = string.Format("{0}_{1}_SelectAll.sql", schema, table);
            string sqlselecctbyidfilename = string.Format("{0}_{1}_SelectById.sql", schema, table);
            string sqlselecctbyguidfilename = string.Format("{0}_{1}_SelectByGUID.sql", schema, table);


            string sqladdfile = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", sqladdfilename));
            string sqldeletefile = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", sqldeletefilename));
            string sqleditfile = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", sqleditfilename));
            string sqlselecctallfile = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", sqlselecctallfilename));
            string sqlselecctbyidfile = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", sqlselecctbyidfilename));
            string sqlselecctbyguidfile = System.Web.HttpContext.Current.Server.MapPath(Paths.sqlfile.Replace("{database}", property.DOWNLOABLE_NAME).Replace("{filename}", sqlselecctbyguidfilename));


            // Checking if directory exists
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Loading SQL Select Add
            using (StreamReader sr = new StreamReader(sqlAddTemplate))
            {
                lineSqlAdd = sr.ReadToEnd();
            }

            // Loading SQL Select Delete
            using (StreamReader sr = new StreamReader(sqlDeleteTemplate))
            {
                lineSqlDelete = sr.ReadToEnd();
            }

            // Loading SQL Select Edit Template
            using (StreamReader sr = new StreamReader(sqlEditTemplate))
            {
                lineSqlEdit = sr.ReadToEnd();
            }

            // Loading SQL Select All Template
            using (StreamReader sr = new StreamReader(sqlSelectAllTemplate))
            {
                lineSqlSelectAll = sr.ReadToEnd();
            }

            // Loading SQL Select by ID Template
            using (StreamReader sr = new StreamReader(sqlSelectByIdTemplate))
            {
                lineSqlSelectById = sr.ReadToEnd();
            }

            // Loading SQL Select by GUID Template
            using (StreamReader sr = new StreamReader(sqlSelectByGUIDTemplate))
            {
                lineSqlSelectByGUID = sr.ReadToEnd();
            }


            // Creating builders
            StringBuilder makerSqlAdd = new StringBuilder();
            StringBuilder makerSqlAddParameters = new StringBuilder();
            StringBuilder makerSqlAddParametersType = new StringBuilder();

            StringBuilder makerSqlDelete = new StringBuilder();

            StringBuilder makerSqlEditParameters = new StringBuilder();
            StringBuilder makerSqlEditParametersType = new StringBuilder();


            StringBuilder makerSqlSelectAll = new StringBuilder();
            StringBuilder makerSqlSelectById = new StringBuilder();
            StringBuilder makerSqlSelectByGUID = new StringBuilder();

            foreach (Entities.Fields field in fields)
            {
                makerSqlAdd.Append(string.Format("{0},", field.COLUMN_NAME));
                makerSqlAddParameters.Append(string.Format("@{0},", field.COLUMN_NAME));
                makerSqlAddParametersType.Append(string.Format("@{0} {1},", field.COLUMN_NAME, field.DATA_TYPE));

                makerSqlEditParameters.Append(string.Format("{0} = @{0},", field.COLUMN_NAME));
                makerSqlEditParametersType.Append(string.Format("@{0} {1},", field.COLUMN_NAME, field.DATA_TYPE));

                makerSqlSelectAll.Append(string.Format("{0},", field.COLUMN_NAME));
                makerSqlSelectById.Append(string.Format("{0},", field.COLUMN_NAME));
                makerSqlSelectByGUID.Append(string.Format("{0},", field.COLUMN_NAME));
            }

            // Add
            string SqlAdd = makerSqlAdd.AppendLine().ToString();
            string SqlAddParameters = makerSqlAddParameters.AppendLine().ToString();
            string SqlAddParametersType = makerSqlAddParametersType.AppendLine().ToString();

            SqlAdd = Utils.selectfields(SqlAdd);
            SqlAddParameters = Utils.selectfields(SqlAddParameters);
            SqlAddParametersType = Utils.selectfields(SqlAddParametersType);


            // Delete
            string SqlDelete = makerSqlDelete.AppendLine().ToString();
            SqlDelete = Utils.selectfields(SqlDelete);


            // Edit
            string SqlEditParameters = makerSqlEditParameters.AppendLine().ToString();
            string SqlEditParametersType = makerSqlEditParametersType.AppendLine().ToString();

            SqlEditParameters = Utils.selectfields(SqlEditParameters);
            SqlEditParametersType = Utils.selectfields(SqlEditParametersType);

            // Select
            string SqlSelectAll = makerSqlSelectAll.AppendLine().ToString();
            string SqlSelectById = makerSqlSelectById.AppendLine().ToString();
            string SqlSelectByGUID = makerSqlSelectByGUID.AppendLine().ToString();

            SqlSelectAll = Utils.selectfields(SqlSelectAll);
            SqlSelectById = Utils.selectfields(SqlSelectById);
            SqlSelectByGUID = Utils.selectfields(SqlSelectByGUID);


            // Adding SQL files Select
            StreamWriter swSelect = new StreamWriter(sqlselecctallfile, true, Encoding.ASCII);
            swSelect.Write(lineSqlSelectAll.Replace("{database}", database)
                                           .Replace("{table}", string.Format("{0}.{1}", schema, table))
                                           .Replace("{fields}", SqlSelectAll));
            swSelect.Close();


            // Adding SQL files Select by Id
            StreamWriter swSelectById = new StreamWriter(sqlselecctbyidfile, true, Encoding.ASCII);
            swSelectById.Write(lineSqlSelectById.Replace("{database}", database)
                                                .Replace("{table}", string.Format("{0}.{1}", schema, table))
                                                .Replace("{fieldId}", string.Format("{0} = @value", FielId))
                                                .Replace("{fields}", SqlSelectById));
            swSelectById.Close();

            // Adding SQL files Select by GUID
            StreamWriter swSelectByGUID = new StreamWriter(sqlselecctbyguidfile, true, Encoding.ASCII);
            swSelectByGUID.Write(lineSqlSelectByGUID.Replace("{database}", database)
                                                    .Replace("{table}", string.Format("{0}.{1}", schema, table))
                                                    .Replace("{fieldId}", string.Format("{0} = @value", FielId))
                                                    .Replace("{fields}", SqlSelectByGUID));
            swSelectByGUID.Close();

            // Adding SQL files Add
            StreamWriter swAdd = new StreamWriter(sqladdfile, true, Encoding.ASCII);
            swAdd.Write(lineSqlAdd.Replace("{database}", database)
                                  .Replace("{table}", string.Format("{0}.{1}", schema, table))
                                  .Replace("{fields}", SqlAdd)
                                  .Replace("{Parameters}", SqlAddParameters)
                                  .Replace("{ParametersType}", SqlAddParametersType));
            swAdd.Close();

            // Adding SQL files Edit
            StreamWriter swEdit = new StreamWriter(sqleditfile, true, Encoding.ASCII);
            swEdit.Write(lineSqlEdit.Replace("{database}", database)
                                   .Replace("{table}", string.Format("{0}.{1}", schema, table))
                                   .Replace("{fields}", SqlEditParameters)
                                   .Replace("{fieldId}", string.Format("{0} = @{0}", FielId))
                                   .Replace("{ParametersType}", SqlEditParametersType));
            swEdit.Close();
        }
    }
}