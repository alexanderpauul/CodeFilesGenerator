using System.Collections.Generic;

namespace Business
{
    public class Organismo
    {
	    private static Data.Organismo obj = new Data.Organismo();

        public static int Add(Models.Organismo value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Organismo value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Organismo GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Organismo GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Organismo> GetAll()
        {
            return obj.GetAll();
        }
    }
}using System.Collections.Generic;

namespace Business
{
    public class Organismo
    {
	    private static Data.Organismo obj = new Data.Organismo();

        public static int Add(Models.Organismo value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Organismo value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Organismo GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Organismo GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Organismo> GetAll()
        {
            return obj.GetAll();
        }
    }
}