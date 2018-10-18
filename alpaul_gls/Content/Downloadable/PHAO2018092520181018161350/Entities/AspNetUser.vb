Imports System

Public Class AspNetUsers
        Public Property Id As String
        Public Property PersonaId As Guid
        Public Property IsDisable As bool
        Public Property Email As String
        Public Property EmailConfirmed As bool
        Public Property PasswordHash As String
        Public Property SecurityStamp As String
        Public Property PhoneNumber As String
        Public Property PhoneNumberConfirmed As bool
        Public Property TwoFactorEnabled As bool
        Public Property LockoutEndDateUtc As DateTime
        Public Property LockoutEnabled As bool
        Public Property AccessFailedCount As int
        Public Property UserName As String

End Class