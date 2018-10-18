USE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT EstadoId, TEstadoId, DscEstado, Habilitado, UserId, Registro, Modificacion, Identificador 
	  FROM dbo.Estados 
	 WHERE EstadoId = @valueUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT EstadoId, TEstadoId, DscEstado, Habilitado, UserId, Registro, Modificacion, Identificador 
	  FROM dbo.Estados 
	 WHERE EstadoId = @value