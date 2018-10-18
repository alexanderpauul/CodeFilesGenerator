USE PMN
GO

CREATE PROCEDURE dbo.Documentos_Edit
(
       @DocumentoId int, @TDocumentoId int, @DscDocumento nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Documentos 
		   SET DocumentoId = @DocumentoId, TDocumentoId = @TDocumentoId, DscDocumento = @DscDocumento, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE DocumentoId = @DocumentoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH