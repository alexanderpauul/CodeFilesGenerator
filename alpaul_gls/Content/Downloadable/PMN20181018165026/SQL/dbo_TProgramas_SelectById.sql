USE PMN
GO

CREATE PROCEDURE dbo.TProgramas_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT TProgramaId, Codigo, DscTProgramaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TProgramas 
	 WHERE TProgramaId = @value