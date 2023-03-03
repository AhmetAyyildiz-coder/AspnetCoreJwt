using Microsoft.AspNetCore.Identity;

namespace AuthServer.Core.Models;

public class UserApp : IdentityUser<string> // string olarak id değerinin türünü belirtiriz.
{
    public string City { get; set; }
}