using System.Collections.Generic;

namespace Business
{
    public class TProyecto
    {
	    private static Data.TProyecto obj = new Data.TProyecto();

        public static int Add(Models.TProyecto value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.TProyecto value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.TProyecto GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.TProyecto GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.TProyecto> GetAll()
        {
            return obj.GetAll();
        }
    }
}