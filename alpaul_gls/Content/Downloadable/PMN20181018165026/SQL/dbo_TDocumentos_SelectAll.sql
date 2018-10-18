USE PMN
GO

CREATE PROCEDURE dbo.TDocumentos_GetAll
AS
	SELECT TDocumentoId, DscTDocumento, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TDocumentos