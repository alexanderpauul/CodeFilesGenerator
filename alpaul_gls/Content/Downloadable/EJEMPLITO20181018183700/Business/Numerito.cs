using System.Collections.Generic;

namespace Business
{
    public class Numerito
    {
	    private static Data.Numerito obj = new Data.Numerito();

        public static int Add(Models.Numerito value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Numerito value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Numerito GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Numerito GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Numerito> GetAll()
        {
            return obj.GetAll();
        }
    }
}