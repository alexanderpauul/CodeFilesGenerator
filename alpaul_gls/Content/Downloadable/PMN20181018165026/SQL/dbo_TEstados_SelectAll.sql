USE PMN
GO

CREATE PROCEDURE dbo.TEstados_GetAll
AS
	SELECT TEstadoId, DscTEstado, Habilitado, Registro, Modificacion, Identificador, UsuarioId 
	  FROM dbo.TEstados