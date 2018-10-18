USE PMN
GO

CREATE PROCEDURE dbo.AspNetUsers_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName 
	  FROM dbo.AspNetUsers 
	 WHERE Id = @value