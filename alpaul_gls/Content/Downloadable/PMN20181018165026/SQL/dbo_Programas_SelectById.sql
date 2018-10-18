USE PMN
GO

CREATE PROCEDURE dbo.Programas_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT ProgramaId, TProgramaId, Codigo, DscPrograma, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Programas 
	 WHERE ProgramaId = @value