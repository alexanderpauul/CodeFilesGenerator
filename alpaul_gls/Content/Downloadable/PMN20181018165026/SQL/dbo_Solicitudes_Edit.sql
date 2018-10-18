USE PMN
GO

CREATE PROCEDURE dbo.Solicitudes_Edit
(
       @SolicitudId int, @TSolicitudId int, @NoAprobacion nvarchar, @FechaAprobacion datetime, @Indice nvarchar, @CreditosCursados nvarchar, @PeriodoIngreso nvarchar, @PersonaId int, @TProgramaId nvarchar, @ProgramaId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int, @DestinoId_UniversidadId int, @OrigenId_UniversidadId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.Solicitudes 
		   SET SolicitudId = @SolicitudId, TSolicitudId = @TSolicitudId, NoAprobacion = @NoAprobacion, FechaAprobacion = @FechaAprobacion, Indice = @Indice, CreditosCursados = @CreditosCursados, PeriodoIngreso = @PeriodoIngreso, PersonaId = @PersonaId, TProgramaId = @TProgramaId, ProgramaId = @ProgramaId, Registro = @Registro, Modificacion = @Modificacion, Identificador = @Identificador, UsuarioId = @UsuarioId, EstadoId = @EstadoId, DestinoId_UniversidadId = @DestinoId_UniversidadId, OrigenId_UniversidadId = @OrigenId_UniversidadId
		 WHERE SolicitudId = @SolicitudId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH