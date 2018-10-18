USE PMN
GO

CREATE PROCEDURE dbo.TImpedimentos_Add
(
       @TImpedimentoId int, @DscTImpedimento nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TImpedimentos
	            (
				 TImpedimentoId, DscTImpedimento, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @TImpedimentoId, @DscTImpedimento, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH