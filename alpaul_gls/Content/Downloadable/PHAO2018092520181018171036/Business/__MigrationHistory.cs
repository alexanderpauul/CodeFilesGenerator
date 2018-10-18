using System.Collections.Generic;

namespace Business
{
    public class __MigrationHistory
    {
	    private static Data.__MigrationHistory obj = new Data.__MigrationHistory();

        public static int Add(Models.__MigrationHistory value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.__MigrationHistory value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.__MigrationHistory GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.__MigrationHistory GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.__MigrationHistory> GetAll()
        {
            return obj.GetAll();
        }
    }
}