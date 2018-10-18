USE PMN
GO

CREATE PROCEDURE dbo.TDocumentos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TDocumentoId, DscTDocumento, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TDocumentos 
	 WHERE TDocumentoId = @value