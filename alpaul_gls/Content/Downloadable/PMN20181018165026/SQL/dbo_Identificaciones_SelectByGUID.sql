USE PMN
GO

CREATE PROCEDURE dbo.Identificaciones_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT IdentificacionId, DscIdentificacion, TIdentificacionId, PersonaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Identificaciones 
	 WHERE IdentificacionId = @value