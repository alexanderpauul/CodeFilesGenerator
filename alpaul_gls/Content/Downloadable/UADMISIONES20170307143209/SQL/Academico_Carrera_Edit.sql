USE UADMISIONES
GO

CREATE PROCEDURE Academico.Carreras_Edit
(
       @CarreraId int, @Codigo varchar, @DscCarrera nvarchar, @TCarreraId int, @UsuarioId int, @FechaRegistro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int, @Diccionario_Key nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE Academico.Carreras 
		   SET CarreraId = @CarreraId, Codigo = @Codigo, DscCarrera = @DscCarrera, TCarreraId = @TCarreraId, UsuarioId = @UsuarioId, FechaRegistro = @FechaRegistro, Modificacion = @Modificacion, Identificador = @Identificador, EstadoId = @EstadoId, Diccionario_Key = @Diccionario_Key
		 WHERE CarreraId = @CarreraId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH