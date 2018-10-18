USE PHAO20180925
GO

CREATE PROCEDURE dbo.TOrganismos_Add
(
       @TOrganismoId int, @DscTOrganismo nvarchar, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TOrganismos
	            (
				 TOrganismoId, DscTOrganismo, UserId, Registro, Modificacion, Identificador, EstadoId
				)
		 VALUES (
		         @TOrganismoId, @DscTOrganismo, @UserId, @Registro, @Modificacion, @Identificador, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH