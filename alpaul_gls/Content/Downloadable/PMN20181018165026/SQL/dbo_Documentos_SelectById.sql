USE PMN
GO

CREATE PROCEDURE dbo.Documentos_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT DocumentoId, TDocumentoId, DscDocumento, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Documentos 
	 WHERE DocumentoId = @value