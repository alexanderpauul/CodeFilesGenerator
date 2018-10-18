USE EJEMPLITO
GO

CREATE PROCEDURE dbo.Numerito_GetAll
AS
	SELECT NumeritoId, Numero, Fecha, Fecha2, Identificador 
	  FROM dbo.Numerito