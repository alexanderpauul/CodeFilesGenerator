USE PHAO20180925
GO

CREATE PROCEDURE dbo.TProyecto_Add
(
       @TNormaId int, @DscTNorma nvarchar, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.TProyecto
	            (
				 TNormaId, DscTNorma, UserId, Registro, Modificacion, Identificador, EstadoId
				)
		 VALUES (
		         @TNormaId, @DscTNorma, @UserId, @Registro, @Modificacion, @Identificador, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH