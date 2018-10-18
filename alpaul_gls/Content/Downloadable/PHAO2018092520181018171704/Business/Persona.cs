using System.Collections.Generic;

namespace Business
{
    public class Persona
    {
	    private static Data.Persona obj = new Data.Persona();

        public static int Add(Models.Persona value)
        {
            return obj.Add(value);
        }

        public static int Edit(Models.Persona value)
        {
            return obj.Edit(value);
        }

        public static int Delete(stirng value)
        {
            return obj.Delete(value);
        }

        public static Models.Persona GetById(string ID)
        {
            return obj.GetById(ID);
        }

		public static Models.Persona GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Models.Persona> GetAll()
        {
            return obj.GetAll();
        }
    }
}