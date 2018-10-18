USE PMN
GO

CREATE PROCEDURE dbo.ECivil_Edit
(
       @ECivilId int, @DscECivil nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.ECivil 
		   SET ECivilId = @ECivilId, DscECivil = @DscECivil, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE ECivilId = @ECivilId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH