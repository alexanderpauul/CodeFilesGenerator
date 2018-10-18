USE PHAO20180925
GO

CREATE PROCEDURE dbo.TProyecto_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TNormaId, DscTNorma, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.TProyecto 
	 WHERE TNormaId = @valueUSE PHAO20180925
GO

CREATE PROCEDURE dbo.TProyecto_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TNormaId, DscTNorma, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.TProyecto 
	 WHERE TNormaId = @value