USE PMN
GO

CREATE PROCEDURE dbo.TIdentificaciones_GetAll
AS
	SELECT TIdentificacionId, DscTIdentificacion, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TIdentificaciones