USE PHAO20180925
GO

CREATE PROCEDURE dbo.Paises_GetAll
AS
	SELECT PaisId, ISO, DscPais, Registro, Modificacion, Identificador 
	  FROM dbo.Paises