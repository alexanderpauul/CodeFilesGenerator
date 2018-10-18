USE PMN
GO

CREATE PROCEDURE dbo.ECivil_Add
(
       @ECivilId int, @DscECivil nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.ECivil
	            (
				 ECivilId, DscECivil, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @ECivilId, @DscECivil, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH