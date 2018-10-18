USE PMN
GO

CREATE PROCEDURE dbo.Direcciones_Add
(
       @DireccionId int, @PersonaId int, @PaisId int, @ProvinciaId nvarchar, @MunicipioId nvarchar, @SectorId nvarchar, @DscDireccion nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Direcciones
	            (
				 DireccionId, PersonaId, PaisId, ProvinciaId, MunicipioId, SectorId, DscDireccion, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @DireccionId, @PersonaId, @PaisId, @ProvinciaId, @MunicipioId, @SectorId, @DscDireccion, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH