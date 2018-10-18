USE PHAO20180925
GO

CREATE PROCEDURE dbo.TOrganismos_Edit
(
       @TOrganismoId int, @DscTOrganismo nvarchar, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TOrganismos 
		   SET TOrganismoId = @TOrganismoId, DscTOrganismo = @DscTOrganismo, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, EstadoId = @EstadoId
		 WHERE TOrganismoId = @TOrganismoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH