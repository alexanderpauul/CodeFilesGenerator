USE PMN
GO

CREATE PROCEDURE dbo.Contactos_Edit
(
       @ContactoId int, @DscContacto nvarchar, @TContactoId int, @PersonaId int, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Contactos 
		   SET ContactoId = @ContactoId, DscContacto = @DscContacto, TContactoId = @TContactoId, PersonaId = @PersonaId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE ContactoId = @ContactoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH