USE PMN
GO

CREATE PROCEDURE dbo.TIdentificaciones_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TIdentificacionId, DscTIdentificacion, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TIdentificaciones 
	 WHERE TIdentificacionId = @value