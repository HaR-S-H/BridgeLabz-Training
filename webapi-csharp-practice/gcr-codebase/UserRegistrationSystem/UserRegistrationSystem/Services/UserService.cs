public class UserService
{
    private static List<User> users = new List<User>();
    private static int id = 1;

    public User Register(RegisterDto dto)
    {
        var user = new User
        {
            Id = id++,
            Name = dto.Name,
            Email = dto.Email,
            Password = dto.Password
        };

        users.Add(user);
        return user;
    }

    public List<User> GetAllUsers()
    {
        return users;
    }
}
