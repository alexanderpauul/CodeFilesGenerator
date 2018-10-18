USE PMN
GO

CREATE PROCEDURE dbo.TProgramas_GetAll
AS
	SELECT TProgramaId, Codigo, DscTProgramaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TProgramas