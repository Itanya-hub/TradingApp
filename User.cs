// Represent a user
namespace App;

public class User
{
    public string Email;// User Login name 
    string _password;// User Log in Password 
    public User(string email, string password)
    {
        Email = email;
        _password = password;

    }
    public bool TryLogin(string username, string password)
    {
        return username == Email && password == _password;
    }
         // Helper to get password when saving to file
    public string GetPassword()
    {
        return _password;
    }
}
