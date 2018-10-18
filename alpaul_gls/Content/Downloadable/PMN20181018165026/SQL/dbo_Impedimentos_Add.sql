USE PMN
GO

CREATE PROCEDURE dbo.Impedimentos_Add
(
       @ImpedimentoId int, @TImpedimentoId int, @DscImpedimento nvarchar, @Variable nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Impedimentos
	            (
				 ImpedimentoId, TImpedimentoId, DscImpedimento, Variable, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @ImpedimentoId, @TImpedimentoId, @DscImpedimento, @Variable, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH