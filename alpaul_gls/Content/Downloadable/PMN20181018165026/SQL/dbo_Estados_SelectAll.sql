USE PMN
GO

CREATE PROCEDURE dbo.Estados_GetAll
AS
	SELECT EstadoId, TEstadoId, DscEstado, Habilitado, Registro, Modificacion, Identificador, UsuarioId 
	  FROM dbo.Estados