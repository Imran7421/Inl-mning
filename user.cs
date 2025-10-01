using System.Reflection.Emit;

namespace Inlämning;

class User
{
    public string Email;

    public string _password;

    //Constructor

    public User(string email, string password)
    {
        Email = email;
        _password = password;
    }
}