using System;

namespace Models
{
	public class AspNetUsers
	{
	    public String Id { get; set; }
    public Guid PersonaId { get; set; }
    public bool IsDisable { get; set; }
    public String Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public String PasswordHash { get; set; }
    public String SecurityStamp { get; set; }
    public String PhoneNumber { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public DateTime LockoutEndDateUtc { get; set; }
    public bool LockoutEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    public String UserName { get; set; }

}
}
