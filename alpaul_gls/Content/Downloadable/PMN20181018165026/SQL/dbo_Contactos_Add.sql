USE PMN
GO

CREATE PROCEDURE dbo.Contactos_Add
(
       @ContactoId int, @DscContacto nvarchar, @TContactoId int, @PersonaId int, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Contactos
	            (
				 ContactoId, DscContacto, TContactoId, PersonaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @ContactoId, @DscContacto, @TContactoId, @PersonaId, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH