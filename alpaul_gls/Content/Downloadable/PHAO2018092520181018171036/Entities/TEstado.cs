using System;

namespace Models
{
	public class TEstados
	{
	    public int TEstadoId { get; set; }
    public String DscTEstado { get; set; }
    public bool Habilitado { get; set; }
    public String UserId { get; set; }
    public DateTime Registro { get; set; }
    public DateTime Modificacion { get; set; }
    public Guid Identificador { get; set; }

}
}
