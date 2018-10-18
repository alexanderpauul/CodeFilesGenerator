USE PHAO20180925
GO

CREATE PROCEDURE dbo.__MigrationHistory_Add
(
       @MigrationId nvarchar, @ContextKey nvarchar, @Model varbinary, @ProductVersion nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.__MigrationHistory
	            (
				 MigrationId, ContextKey, Model, ProductVersion
				)
		 VALUES (
		         @MigrationId, @ContextKey, @Model, @ProductVersion
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH