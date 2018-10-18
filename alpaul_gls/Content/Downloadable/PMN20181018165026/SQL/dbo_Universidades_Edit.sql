USE PMN
GO

CREATE PROCEDURE dbo.Universidades_Edit
(
       @UniversidadId int, @DscUniversidad nvarchar, @Email nvarchar, @Telefono nvarchar, @Fax nvarchar, @SitioWeb nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Universidades 
		   SET UniversidadId = @UniversidadId, DscUniversidad = @DscUniversidad, Email = @Email, Telefono = @Telefono, Fax = @Fax, SitioWeb = @SitioWeb, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId
		 WHERE UniversidadId = @UniversidadId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH