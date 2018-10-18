USE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_GetAll
AS
	SELECT EstadoId, TEstadoId, DscEstado, Habilitado, UserId, Registro, Modificacion, Identificador 
	  FROM dbo.Estados