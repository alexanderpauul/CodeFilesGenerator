USE PMN
GO

CREATE PROCEDURE dbo.ECivil_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT ECivilId, DscECivil, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.ECivil 
	 WHERE ECivilId = @value