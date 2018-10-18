USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserLogins_Edit
(
       @LoginProvider nvarchar, @ProviderKey nvarchar, @UserId nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.AspNetUserLogins 
		   SET LoginProvider = @LoginProvider, ProviderKey = @ProviderKey, UserId = @UserId
		 WHERE LoginProvider = @LoginProvider

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH