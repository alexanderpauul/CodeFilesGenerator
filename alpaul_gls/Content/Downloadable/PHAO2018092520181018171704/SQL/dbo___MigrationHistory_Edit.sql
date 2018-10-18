USE PHAO20180925
GO

CREATE PROCEDURE dbo.__MigrationHistory_Edit
(
       @MigrationId nvarchar, @ContextKey nvarchar, @Model varbinary, @ProductVersion nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.__MigrationHistory 
		   SET MigrationId = @MigrationId, ContextKey = @ContextKey, Model = @Model, ProductVersion = @ProductVersion
		 WHERE MigrationId = @MigrationId

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH