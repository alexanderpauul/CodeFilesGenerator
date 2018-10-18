USE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_Add
(
       @EstadoId int, @TEstadoId int, @DscEstado nvarchar, @Habilitado bit, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Estados
	            (
				 EstadoId, TEstadoId, DscEstado, Habilitado, UserId, Registro, Modificacion, Identificador
				)
		 VALUES (
		         @EstadoId, @TEstadoId, @DscEstado, @Habilitado, @UserId, @Registro, @Modificacion, @Identificador
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCHUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Estados_Add
(
       @EstadoId int, @TEstadoId int, @DscEstado nvarchar, @Habilitado bit, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Estados
	            (
				 EstadoId, TEstadoId, DscEstado, Habilitado, UserId, Registro, Modificacion, Identificador
				)
		 VALUES (
		         @EstadoId, @TEstadoId, @DscEstado, @Habilitado, @UserId, @Registro, @Modificacion, @Identificador
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH