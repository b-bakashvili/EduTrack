using System.Text;
using EduTrack.Data;
using EduTrack.Models;
using System.Security.Cryptography;

namespace EduTrack.Core;

public class AuthService
{
    private readonly UserRepository _userRepository;

    public AuthService()
    {
        _userRepository = new UserRepository();
    }

    public bool Register(string fullName, string email, string password, string role)
    {
        string hashedPassword = HashPassword(password);

        User user = new User
        {
            FullName = fullName,
            Email = email,
            Password = hashedPassword,
            Role = role
        };

        _userRepository.Register(user);
        return true;
    }
     
    public User Login(string email, string password)
    {
        string hashedPassword = HashPassword(password);
        return _userRepository.Login(email, hashedPassword);
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
