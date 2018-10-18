USE PMN
GO

CREATE PROCEDURE dbo.Solicitudes_GetAll
AS
	SELECT SolicitudId, TSolicitudId, NoAprobacion, FechaAprobacion, Indice, CreditosCursados, PeriodoIngreso, PersonaId, TProgramaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId, DestinoId_UniversidadId, OrigenId_UniversidadId 
	  FROM dbo.Solicitudes