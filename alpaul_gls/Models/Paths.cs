
public class Paths
{
    // Templates Basic
    public static string modelTemplate { get { return "/Content/Templates/{language}/models.txt"; } }
    public static string dataTemplate { get { return "/Content/Templates/{language}/data.txt"; } }
    public static string businessTemplate { get { return "/Content/Templates/{language}/business.txt"; } }
    public static string singleFileTemplate { get { return "/Content/Templates/{language}/single_file.txt"; } }
    public static string sqlAddTemplate { get { return "/Content/Templates/SQL/Add.txt"; } }
    public static string sqlEditTemplate { get { return "/Content/Templates/SQL/Edit.txt"; } }
    public static string sqlDeleteTemplate { get { return "/Content/Templates/SQL/Delete.txt"; } }
    public static string sqlSelectAllTemplate { get { return "/Content/Templates/SQL/SelectAll.txt"; } }
    public static string sqlSelectByGUIDTemplate { get { return "/Content/Templates/SQL/SelectByGUID.txt"; } }
    public static string sqlSelectByIdTemplate { get { return "/Content/Templates/SQL/SelectById.txt"; } }

    // Templates Parts
    public static string modelParts { get { return "/Content/Templates/Parts/models/{language}.txt"; } }
    public static string dataPartsParameter { get { return "/Content/Templates/Parts/data/{language}-sqlparameter.txt"; } }
    public static string dataPartsRecords { get { return "/Content/Templates/Parts/data/{language}-sqlrecords.txt"; } }


    // Paths
    public static string modelfile { get { return "/Content/Downloadable/{database}/Entities/{filename}"; } } // Models Path
    public static string datafile { get { return "/Content/Downloadable/{database}/Data/{filename}"; } } // Data Path
    public static string businessfile { get { return "/Content/Downloadable/{database}/Business/{filename}"; } } // Business Path
    public static string singlefile { get { return "/Content/Downloadable/{database}/{filename}"; } } // Single File Path
    public static string sqlfile { get { return "/Content/Downloadable/{database}/SQL/{filename}"; } } // Single File Path


    // Download Directory
    public static string downloableModelsUrl { get { return "/Content/Downloadable/{directoryname}/Entities"; } }
    public static string downloableDataUrl { get { return "/Content/Downloadable/{directoryname}/Data"; } }
    public static string downloableBusinessUrl { get { return "/Content/Downloadable/{directoryname}/Business"; } }
    public static string downloableSingleFileUrl { get { return "/Content/Downloadable/{directoryname}"; } }
    public static string downloableSqlFileUrl { get { return "/Content/Downloadable/{directoryname}/SQL"; } }
}
