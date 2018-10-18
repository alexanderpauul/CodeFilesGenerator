USE PMN
GO

CREATE PROCEDURE dbo.TImpedimentos_Edit
(
       @TImpedimentoId int, @DscTImpedimento nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TImpedimentos 
		   SET TImpedimentoId = @TImpedimentoId, DscTImpedimento = @DscTImpedimento, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE TImpedimentoId = @TImpedimentoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH