USE PMN
GO

CREATE PROCEDURE dbo.Documentos_Add
(
       @DocumentoId int, @TDocumentoId int, @DscDocumento nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Documentos
	            (
				 DocumentoId, TDocumentoId, DscDocumento, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @DocumentoId, @TDocumentoId, @DscDocumento, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH