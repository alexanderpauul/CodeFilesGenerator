using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Utils
{
    public static string conecctioncommand
    {
        get
        {
            return "Data Source={instance};Initial Catalog={database};{security}";
        }
    }

    public static string serverconnection
    {
        get
        {
            return "Data Source={instance}; Integrated Security=True;";
        }
    }

    public static string serverSecurity
    {
        get
        {
            return "Persist Security Info=True;User ID={user};Password={pwd};";
        }
    }

    public static string fieldscommand
    {
        get
        {
            return "IF OBJECT_ID('tempdb..#CSTYPES') IS NOT NULL DROP TABLE #CSTYPES  " +
                   "   SELECT SQL_TYPE, CLASS_TYPE " +
                   "     INTO #CSTYPES " +
                   "     FROM (VALUES ('bigint',           'long'), " +
                   "     ('binary',           'byte[]'), " +
                   "     ('bit',              'bool'), " +
                   "     ('char',             'String'), " +
                   "     ('date',             'DateTime'), " +
                   "     ('datetime',         'DateTime'), " +
                   "     ('datetime2',        'DateTime'), " +
                   "     ('datetimeoffset',   'DateTimeOffset'), " +
                   "     ('decimal',          'decimal'), " +
                   "     ('float',            'float'), " +
                   "     ('image',            'byte[]'), " +
                   "     ('int',              'int'), " +
                   "     ('money',            'decimal'), " +
                   "     ('nchar',            'char'), " +
                   "     ('ntext',            'string'), " +
                   "     ('numeric',          'decimal'), " +
                   "     ('nvarchar',         'String'), " +
                   "     ('real',             'double'), " +
                   "     ('smalldatetime',    'DateTime'), " +
                   "     ('smallint',         'short'), " +
                   "     ('smallmoney',       'decimal'), " +
                   "     ('text',             'String'), " +
                   "     ('time',             'TimeSpan'), " +
                   "     ('timestamp',        'DateTime'), " +
                   "     ('tinyint' ,         'byte'), " +
                   "     ('uniqueidentifier', 'Guid'), " +
                   "     ('varbinary',        'byte[]'), " +
                   "     ('varchar',          'string')) " +
                   "     E(SQL_TYPE, CLASS_TYPE) " +

                   "   USE {database} " +
                   "SELECT DISTINCT  A.TABLE_CATALOG, A.TABLE_SCHEMA, A.TABLE_NAME, A.ORDINAL_POSITION, A.COLUMN_NAME, A.DATA_TYPE, A.IS_NULLABLE, " +
                   "       ISNULL(A.CHARACTER_MAXIMUM_LENGTH, 0) CHARACTER_MAXIMUM_LENGTH, C.CONSTRAINT_TYPE, KEY_CODE = CASE WHEN C.CONSTRAINT_TYPE = 'PRIMARY KEY' THEN 1 " +
                   "                                                                                                          WHEN C.CONSTRAINT_TYPE = 'FOREIGN KEY' THEN 2 " +
                   "                                                                                                          ELSE 0 END, " +
                   "       B.CONSTRAINT_NAME, A.COLUMN_DEFAULT, D.TABLE_NAME TABLE_NAME_RELATIONSHIP, E.CLASS_TYPE  " +
                   "  FROM INFORMATION_SCHEMA.COLUMNS A " +
                   "       LEFT JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE B ON A.TABLE_NAME = B.TABLE_NAME AND A.COLUMN_NAME = B.COLUMN_NAME " +
                   "       LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS C ON B.CONSTRAINT_NAME = C.CONSTRAINT_NAME AND B.TABLE_NAME = C.TABLE_NAME " +
                   "       LEFT JOIN ( SELECT A.TABLE_CATALOG, A.CONSTRAINT_SCHEMA, A.TABLE_NAME, A.COLUMN_NAME, B.CONSTRAINT_TYPE, A.TABLE_SCHEMA " +
                   "                     FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE A " +
                   "                          INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS B ON B.CONSTRAINT_NAME = A.CONSTRAINT_NAME " +
                   "                    WHERE B.CONSTRAINT_TYPE = 'PRIMARY KEY'  ) D ON D.COLUMN_NAME = A.COLUMN_NAME " +
                   "                          AND d.TABLE_CATALOG = a.TABLE_CATALOG " +
                   "                          AND d.TABLE_SCHEMA = a.TABLE_SCHEMA " +
                   "                          AND d.TABLE_NAME = a.TABLE_NAME " +
                   "       LEFT  JOIN #CSTYPES E ON E.SQL_TYPE = A.DATA_TYPE " +
                   " WHERE A.TABLE_CATALOG = '{database}' And A.TABLE_SCHEMA = '{schema}'  AND A.TABLE_NAME = '{table}' " +
                   " ORDER BY A.ORDINAL_POSITION";
        }
    }

    public static Dictionary<string, string> language
    {
        get
        {
            var langs = new Dictionary<string, string>();
            langs.Add("CSharp", "C# .NET");
            langs.Add("VB", "VB .NET");
            //langs.Add("Java", "Java");
            return langs;
        }
    }

    public static string extension(string language)
    {
        string _extension = string.Empty;
        switch (language)
        {
            case "CSharp":
                _extension = "cs";
                break;
            case "VB":
                _extension = "vb";
                break;
        }
        return _extension;
    }

    public static string singular(string word)
    {
        string latter = string.Empty;
        if (word.EndsWith("es"))
        {
            latter = word.Substring(0, word.Length - 2);
        }
        else if (word.EndsWith("s"))
        {
            latter = word.Substring(0, word.Length - 1);
        }
        else
        {
            latter = word;
        }

        return latter;
    }

    public static string selectfields(string fields)
    {
        string[] value = { };
        value = Regex.Replace(fields, "\\r\\n", "").Split(Convert.ToChar(","));
        string result = "";

        foreach (string item in value)
        {
            if ((!result.Contains(item)) && !string.IsNullOrEmpty(item))
            {
                if (result.Length > 0) { result = result + ", " + item.ToString(); }
                else { result = item.ToString(); }
            }
        }

        return result;
    }
}
