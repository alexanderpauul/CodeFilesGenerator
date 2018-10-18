using System.Collections.Generic;

namespace Business
{
    public class TOrganismo
    {
	    private static Data.TOrganismo obj = new Data.TOrganismo();

        public static int Add(Models.TOrganismo value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.TOrganismo value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.TOrganismo GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.TOrganismo GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.TOrganismo> GetAll()
        {
            return obj.GetAll();
        }
    }
}using System.Collections.Generic;

namespace Business
{
    public class TOrganismo
    {
	    private static Data.TOrganismo obj = new Data.TOrganismo();

        public static int Add(Models.TOrganismo value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.TOrganismo value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.TOrganismo GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.TOrganismo GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.TOrganismo> GetAll()
        {
            return obj.GetAll();
        }
    }
}