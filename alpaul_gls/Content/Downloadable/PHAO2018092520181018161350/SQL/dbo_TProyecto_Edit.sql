USE PHAO20180925
GO

CREATE PROCEDURE dbo.TProyecto_Edit
(
       @TNormaId int, @DscTNorma nvarchar, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.TProyecto 
		   SET TNormaId = @TNormaId, DscTNorma = @DscTNorma, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, EstadoId = @EstadoId
		 WHERE TNormaId = @TNormaId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH