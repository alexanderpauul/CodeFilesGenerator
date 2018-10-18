using System.Collections.Generic;

namespace Business
{
    public class TEstado
    {
	    private static Data.TEstado obj = new Data.TEstado();

        public static int Add(Models.TEstado value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.TEstado value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.TEstado GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.TEstado GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.TEstado> GetAll()
        {
            return obj.GetAll();
        }
    }
}