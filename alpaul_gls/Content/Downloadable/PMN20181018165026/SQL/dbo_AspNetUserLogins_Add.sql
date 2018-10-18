USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserLogins_Add
(
       @LoginProvider nvarchar, @ProviderKey nvarchar, @UserId nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.AspNetUserLogins
	            (
				 LoginProvider, ProviderKey, UserId
				)
		 VALUES (
		         @LoginProvider, @ProviderKey, @UserId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH