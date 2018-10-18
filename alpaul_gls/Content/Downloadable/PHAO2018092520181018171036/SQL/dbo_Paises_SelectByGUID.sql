USE PHAO20180925
GO

CREATE PROCEDURE dbo.Paises_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT PaisId, ISO, DscPais, Registro, Modificacion, Identificador 
	  FROM dbo.Paises 
	 WHERE PaisId = @value