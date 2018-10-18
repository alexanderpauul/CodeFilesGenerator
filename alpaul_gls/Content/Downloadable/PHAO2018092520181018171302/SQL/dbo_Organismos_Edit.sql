USE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_Edit
(
       @OrganismoId int, @DscOrganismo nvarchar, @Sigla nvarchar, @URL nvarchar, @TOrganismoId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Organismos 
		   SET OrganismoId = @OrganismoId, DscOrganismo = @DscOrganismo, Sigla = @Sigla, URL = @URL, TOrganismoId = @TOrganismoId, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, EstadoId = @EstadoId
		 WHERE OrganismoId = @OrganismoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCHUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_Edit
(
       @OrganismoId int, @DscOrganismo nvarchar, @Sigla nvarchar, @URL nvarchar, @TOrganismoId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Organismos 
		   SET OrganismoId = @OrganismoId, DscOrganismo = @DscOrganismo, Sigla = @Sigla, URL = @URL, TOrganismoId = @TOrganismoId, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, EstadoId = @EstadoId
		 WHERE OrganismoId = @OrganismoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH