USE PMN
GO

CREATE PROCEDURE dbo.AspNetUsers_Add
(
       @Id nvarchar, @Email nvarchar, @EmailConfirmed bit, @PasswordHash nvarchar, @SecurityStamp nvarchar, @PhoneNumber nvarchar, @PhoneNumberConfirmed bit, @TwoFactorEnabled bit, @LockoutEndDateUtc datetime, @LockoutEnabled bit, @AccessFailedCount int, @UserName nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.AspNetUsers
	            (
				 Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName
				)
		 VALUES (
		         @Id, @Email, @EmailConfirmed, @PasswordHash, @SecurityStamp, @PhoneNumber, @PhoneNumberConfirmed, @TwoFactorEnabled, @LockoutEndDateUtc, @LockoutEnabled, @AccessFailedCount, @UserName
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH