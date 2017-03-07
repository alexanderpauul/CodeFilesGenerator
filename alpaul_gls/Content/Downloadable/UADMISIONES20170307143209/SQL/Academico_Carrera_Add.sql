USE UADMISIONES
GO

CREATE PROCEDURE Academico.Carreras_Add
(
       @CarreraId int, @Codigo varchar, @DscCarrera nvarchar, @TCarreraId int, @UsuarioId int, @FechaRegistro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int, @Diccionario_Key nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO Academico.Carreras
	            (
				 CarreraId, Codigo, DscCarrera, TCarreraId, UsuarioId, FechaRegistro, Modificacion, Identificador, EstadoId, Diccionario_Key
				)
		 VALUES (
		         @CarreraId, @Codigo, @DscCarrera, @TCarreraId, @UsuarioId, @FechaRegistro, @Modificacion, @Identificador, @EstadoId, @Diccionario_Key
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH