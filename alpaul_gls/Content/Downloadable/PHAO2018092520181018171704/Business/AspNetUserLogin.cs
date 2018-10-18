using System.Collections.Generic;

namespace Business
{
    public class AspNetUserLogin
    {
	    private static Data.AspNetUserLogin obj = new Data.AspNetUserLogin();

        public static int Add(Models.AspNetUserLogin value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.AspNetUserLogin value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.AspNetUserLogin GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.AspNetUserLogin GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.AspNetUserLogin> GetAll()
        {
            return obj.GetAll();
        }
    }
}