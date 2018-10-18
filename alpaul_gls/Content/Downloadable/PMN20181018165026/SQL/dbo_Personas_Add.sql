USE PMN
GO

CREATE PROCEDURE dbo.Personas_Add
(
       @PersonaId int, @Nombre nvarchar, @PrimerApellido nvarchar, @SegundoApellido nvarchar, @FechaNacimiento datetime, @PaisId nvarchar, @NacionalidadId nvarchar, @SexoId int, @ECivilId int, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Personas
	            (
				 PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, Registro, Modificacion, Identificador, UsuarioId
				)
		 VALUES (
		         @PersonaId, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @PaisId, @NacionalidadId, @SexoId, @ECivilId, @Registro, @Modificacion, @Identificador, @UsuarioId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH