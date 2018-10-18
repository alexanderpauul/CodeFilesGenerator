USE PMN
GO

CREATE PROCEDURE dbo.TDocumentos_Edit
(
       @TDocumentoId int, @DscTDocumento nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TDocumentos 
		   SET TDocumentoId = @TDocumentoId, DscTDocumento = @DscTDocumento, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE TDocumentoId = @TDocumentoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH