USE PMN
GO

CREATE PROCEDURE dbo.Personas_Edit
(
       @PersonaId int, @Nombre nvarchar, @PrimerApellido nvarchar, @SegundoApellido nvarchar, @FechaNacimiento datetime, @PaisId nvarchar, @NacionalidadId nvarchar, @SexoId int, @ECivilId int, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Personas 
		   SET PersonaId = @PersonaId, Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, FechaNacimiento = @FechaNacimiento, PaisId = @PaisId, NacionalidadId = @NacionalidadId, SexoId = @SexoId, ECivilId = @ECivilId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId
		 WHERE PersonaId = @PersonaId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH