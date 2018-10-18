USE PMN
GO

CREATE PROCEDURE dbo.TDocumentos_Add
(
       @TDocumentoId int, @DscTDocumento nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TDocumentos
	            (
				 TDocumentoId, DscTDocumento, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @TDocumentoId, @DscTDocumento, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH