USE PHAO20180925
GO

CREATE PROCEDURE dbo.Paises_Add
(
       @PaisId int, @ISO nvarchar, @DscPais nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Paises
	            (
				 PaisId, ISO, DscPais, Registro, Modificacion, Identificador
				)
		 VALUES (
		         @PaisId, @ISO, @DscPais, @Registro, @Modificacion, @Identificador
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH