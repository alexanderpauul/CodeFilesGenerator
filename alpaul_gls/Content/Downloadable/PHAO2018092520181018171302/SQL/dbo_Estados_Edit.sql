USE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_Edit
(
       @EstadoId int, @TEstadoId int, @DscEstado nvarchar, @Habilitado bit, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Estados 
		   SET EstadoId = @EstadoId, TEstadoId = @TEstadoId, DscEstado = @DscEstado, Habilitado = @Habilitado, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador
		 WHERE EstadoId = @EstadoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCHUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_Edit
(
       @EstadoId int, @TEstadoId int, @DscEstado nvarchar, @Habilitado bit, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Estados 
		   SET EstadoId = @EstadoId, TEstadoId = @TEstadoId, DscEstado = @DscEstado, Habilitado = @Habilitado, UserId = @UserId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador
		 WHERE EstadoId = @EstadoId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH