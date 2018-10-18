USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUsers_GetAll
AS
	SELECT Id, PersonaId, IsDisable, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName 
	  FROM dbo.AspNetUsers