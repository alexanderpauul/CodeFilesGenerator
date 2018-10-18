using System.Collections.Generic;

namespace Business
{
    public class AspNetUserRol
    {
	    private static Data.AspNetUserRol obj = new Data.AspNetUserRol();

        public static int Add(Models.AspNetUserRol value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.AspNetUserRol value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.AspNetUserRol GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.AspNetUserRol GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.AspNetUserRol> GetAll()
        {
            return obj.GetAll();
        }
    }
}