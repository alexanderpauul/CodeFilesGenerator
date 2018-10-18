USE PHAO20180925
GO

CREATE PROCEDURE dbo.Personas_Edit
(
       @PersonaId uniqueidentifier, @Nombre nvarchar, @PrimerApellido nvarchar, @SegundoApellido nvarchar, @FechaNacimiento datetime, @PaisId nvarchar, @NacionalidadId nvarchar, @SexoId nvarchar, @ECivilId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Personas 
		   SET PersonaId = @PersonaId, Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, FechaNacimiento = @FechaNacimiento, PaisId = @PaisId, NacionalidadId = @NacionalidadId, SexoId = @SexoId, ECivilId = @ECivilId, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, EstadoId = @EstadoId
		 WHERE PersonaId = @PersonaId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH