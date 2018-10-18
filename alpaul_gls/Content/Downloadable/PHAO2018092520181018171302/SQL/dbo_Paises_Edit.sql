USE PHAO20180925
GO

CREATE PROCEDURE dbo.Paises_Edit
(
       @PaisId int, @ISO nvarchar, @DscPais nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Paises 
		   SET PaisId = @PaisId, ISO = @ISO, DscPais = @DscPais, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador
		 WHERE PaisId = @PaisId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCHUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Paises_Edit
(
       @PaisId int, @ISO nvarchar, @DscPais nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Paises 
		   SET PaisId = @PaisId, ISO = @ISO, DscPais = @DscPais, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador
		 WHERE PaisId = @PaisId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH