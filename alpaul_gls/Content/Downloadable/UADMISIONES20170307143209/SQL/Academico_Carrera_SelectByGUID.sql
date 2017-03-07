USE UADMISIONES
GO

CREATE PROCEDURE Academico.Carreras_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT CarreraId, Codigo, DscCarrera, TCarreraId, UsuarioId, FechaRegistro, Modificacion, Identificador, EstadoId, Diccionario_Key 
	  FROM Academico.Carreras 
	 WHERE CarreraId = @value