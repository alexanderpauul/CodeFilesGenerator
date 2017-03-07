USE UADMISIONES
GO

CREATE PROCEDURE Academico.Carreras_GetAll
AS
	SELECT CarreraId, Codigo, DscCarrera, TCarreraId, UsuarioId, FechaRegistro, Modificacion, Identificador, EstadoId, Diccionario_Key 
	  FROM Academico.Carreras