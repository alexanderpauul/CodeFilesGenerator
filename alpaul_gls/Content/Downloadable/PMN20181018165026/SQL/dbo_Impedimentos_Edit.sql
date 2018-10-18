USE PMN
GO

CREATE PROCEDURE dbo.Impedimentos_Edit
(
       @ImpedimentoId int, @TImpedimentoId int, @DscImpedimento nvarchar, @Variable nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Impedimentos 
		   SET ImpedimentoId = @ImpedimentoId, TImpedimentoId = @TImpedimentoId, DscImpedimento = @DscImpedimento, Variable = @Variable, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE ImpedimentoId = @ImpedimentoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH