USE PHAO20180925
GO

CREATE PROCEDURE dbo.TEstados_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT TEstadoId, DscTEstado, Habilitado, UserId, Registro, Modificacion, Identificador 
	  FROM dbo.TEstados 
	 WHERE TEstadoId = @valueUSE PHAO20180925
GO

CREATE PROCEDURE dbo.TEstados_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT TEstadoId, DscTEstado, Habilitado, UserId, Registro, Modificacion, Identificador 
	  FROM dbo.TEstados 
	 WHERE TEstadoId = @value