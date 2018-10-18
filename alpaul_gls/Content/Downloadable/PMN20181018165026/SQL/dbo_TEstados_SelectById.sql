USE PMN
GO

CREATE PROCEDURE dbo.TEstados_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT TEstadoId, DscTEstado, Habilitado, Registro, Modificacion, Identificador, UsuarioId 
	  FROM dbo.TEstados 
	 WHERE TEstadoId = @value