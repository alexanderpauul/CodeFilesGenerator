USE PMN
GO

CREATE PROCEDURE dbo.Programas_GetAll
AS
	SELECT ProgramaId, TProgramaId, Codigo, DscPrograma, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Programas