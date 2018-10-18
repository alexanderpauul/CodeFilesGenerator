USE PMN
GO

CREATE PROCEDURE dbo.Documentos_GetAll
AS
	SELECT DocumentoId, TDocumentoId, DscDocumento, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Documentos