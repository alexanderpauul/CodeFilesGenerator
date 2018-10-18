USE PMN
GO

CREATE PROCEDURE dbo.Universidades_Add
(
       @UniversidadId int, @DscUniversidad nvarchar, @Email nvarchar, @Telefono nvarchar, @Fax nvarchar, @SitioWeb nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Universidades
	            (
				 UniversidadId, DscUniversidad, Email, Telefono, Fax, SitioWeb, Registro, Modificacion, Identificador, UsuarioId, EstadoId
				)
		 VALUES (
		         @UniversidadId, @DscUniversidad, @Email, @Telefono, @Fax, @SitioWeb, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH