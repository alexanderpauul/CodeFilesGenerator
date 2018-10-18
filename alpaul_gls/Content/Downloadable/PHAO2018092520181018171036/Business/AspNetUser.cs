using System.Collections.Generic;

namespace Business
{
    public class AspNetUser
    {
	    private static Data.AspNetUser obj = new Data.AspNetUser();

        public static int Add(Models.AspNetUser value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.AspNetUser value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.AspNetUser GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.AspNetUser GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.AspNetUser> GetAll()
        {
            return obj.GetAll();
        }
    }
}