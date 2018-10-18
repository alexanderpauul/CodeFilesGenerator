USE PMN
GO

CREATE PROCEDURE dbo.TContactos_Edit
(
       @TContactoId int, @DscTContacto nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TContactos 
		   SET TContactoId = @TContactoId, DscTContacto = @DscTContacto, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE TContactoId = @TContactoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH