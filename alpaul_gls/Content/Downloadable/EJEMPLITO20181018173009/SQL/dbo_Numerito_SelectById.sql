USE EJEMPLITO
GO

CREATE PROCEDURE dbo.Numerito_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT NumeritoId, Numero, Fecha, Fecha2, Identificador 
	  FROM dbo.Numerito 
	 WHERE NumeritoId = @value