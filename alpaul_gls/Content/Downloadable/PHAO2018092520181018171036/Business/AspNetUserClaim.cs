using System.Collections.Generic;

namespace Business
{
    public class AspNetUserClaim
    {
	    private static Data.AspNetUserClaim obj = new Data.AspNetUserClaim();

        public static int Add(Models.AspNetUserClaim value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.AspNetUserClaim value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.AspNetUserClaim GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.AspNetUserClaim GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.AspNetUserClaim> GetAll()
        {
            return obj.GetAll();
        }
    }
}