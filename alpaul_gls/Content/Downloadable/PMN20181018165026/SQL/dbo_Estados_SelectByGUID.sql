USE PMN
GO

CREATE PROCEDURE dbo.Estados_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT EstadoId, TEstadoId, DscEstado, Habilitado, Registro, Modificacion, Identificador, UsuarioId 
	  FROM dbo.Estados 
	 WHERE EstadoId = @value