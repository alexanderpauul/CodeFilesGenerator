USE PMN
GO

CREATE PROCEDURE dbo.Identificaciones_GetAll
AS
	SELECT IdentificacionId, DscIdentificacion, TIdentificacionId, PersonaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Identificaciones