USE PHAO20180925
GO

CREATE PROCEDURE dbo.Personas_Add
(
       @PersonaId uniqueidentifier, @Nombre nvarchar, @PrimerApellido nvarchar, @SegundoApellido nvarchar, @FechaNacimiento datetime, @PaisId nvarchar, @NacionalidadId nvarchar, @SexoId nvarchar, @ECivilId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Personas
	            (
				 PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, UserId, Registro, Modificacion, Identificador, EstadoId
				)
		 VALUES (
		         @PersonaId, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @PaisId, @NacionalidadId, @SexoId, @ECivilId, @UserId, @Registro, @Modificacion, @Identificador, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCHUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Personas_Add
(
       @PersonaId uniqueidentifier, @Nombre nvarchar, @PrimerApellido nvarchar, @SegundoApellido nvarchar, @FechaNacimiento datetime, @PaisId nvarchar, @NacionalidadId nvarchar, @SexoId nvarchar, @ECivilId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Personas
	            (
				 PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, UserId, Registro, Modificacion, Identificador, EstadoId
				)
		 VALUES (
		         @PersonaId, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @PaisId, @NacionalidadId, @SexoId, @ECivilId, @UserId, @Registro, @Modificacion, @Identificador, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH