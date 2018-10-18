USE PMN
GO

CREATE PROCEDURE dbo.Direcciones_Edit
(
       @DireccionId int, @PersonaId int, @PaisId int, @ProvinciaId nvarchar, @MunicipioId nvarchar, @SectorId nvarchar, @DscDireccion nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Direcciones 
		   SET DireccionId = @DireccionId, PersonaId = @PersonaId, PaisId = @PaisId, ProvinciaId = @ProvinciaId, MunicipioId = @MunicipioId, SectorId = @SectorId, DscDireccion = @DscDireccion, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE DireccionId = @DireccionId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH