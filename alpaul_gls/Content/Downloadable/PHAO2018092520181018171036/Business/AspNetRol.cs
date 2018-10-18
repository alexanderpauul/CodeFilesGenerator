using System.Collections.Generic;

namespace Business
{
    public class AspNetRol
    {
	    private static Data.AspNetRol obj = new Data.AspNetRol();

        public static int Add(Models.AspNetRol value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.AspNetRol value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.AspNetRol GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.AspNetRol GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.AspNetRol> GetAll()
        {
            return obj.GetAll();
        }
    }
}