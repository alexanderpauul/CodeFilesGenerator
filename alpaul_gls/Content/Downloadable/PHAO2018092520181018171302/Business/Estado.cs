using System.Collections.Generic;

namespace Business
{
    public class Estado
    {
	    private static Data.Estado obj = new Data.Estado();

        public static int Add(Models.Estado value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Estado value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Estado GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Estado GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Estado> GetAll()
        {
            return obj.GetAll();
        }
    }
}using System.Collections.Generic;

namespace Business
{
    public class Estado
    {
	    private static Data.Estado obj = new Data.Estado();

        public static int Add(Models.Estado value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Estado value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Estado GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Estado GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Estado> GetAll()
        {
            return obj.GetAll();
        }
    }
}