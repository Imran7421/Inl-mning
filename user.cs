namespace Inlämning
{
    public class User
    {
        public string Email;
        public string _password;
        public string Username;  // Added 'Username' field

        // Constructor that accepts email, password, and username
        public User(string email, string password, string username)
        {
            Email = email;
            _password = password;
            Username = username;  // Correctly initialize the Username field
        }
        public string GetUserEmail() => Email;
    public string GetPassword() => _password;
    public string GetUsername() => Username;
    }
}