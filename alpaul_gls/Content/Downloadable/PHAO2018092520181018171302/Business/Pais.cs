using System.Collections.Generic;

namespace Business
{
    public class Pais
    {
	    private static Data.Pais obj = new Data.Pais();

        public static int Add(Models.Pais value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Pais value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Pais GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Pais GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Pais> GetAll()
        {
            return obj.GetAll();
        }
    }
}using System.Collections.Generic;

namespace Business
{
    public class Pais
    {
	    private static Data.Pais obj = new Data.Pais();

        public static int Add(Models.Pais value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Pais value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Pais GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Pais GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Pais> GetAll()
        {
            return obj.GetAll();
        }
    }
}