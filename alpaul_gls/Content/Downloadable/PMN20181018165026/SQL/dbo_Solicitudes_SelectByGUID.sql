USE PMN
GO

CREATE PROCEDURE dbo.Solicitudes_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT SolicitudId, TSolicitudId, NoAprobacion, FechaAprobacion, Indice, CreditosCursados, PeriodoIngreso, PersonaId, TProgramaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId, DestinoId_UniversidadId, OrigenId_UniversidadId 
	  FROM dbo.Solicitudes 
	 WHERE SolicitudId = @value