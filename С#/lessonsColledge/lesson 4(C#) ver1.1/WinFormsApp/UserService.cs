using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class UserService
    {
        public static UserService Instance { get; set; } = new UserService();
        private List<User> _users = [
            new User() {
                Login = "admin",
                Password = "admin",
                BirthDate = new DateTime(2000, 10, 24),
                Gender = Gender.Male,
                Email = "admin@admin.com",
                FullName = "Администратор Родион",
                Role = Role.Administrator
            },
            new User(){
                Login = "user",
                Password = "user",
                BirthDate = new DateTime(2000, 10, 24),
                Gender = Gender.Male,
                Email = "user@user.com",
                FullName = "Пользователь Виктор",
                Role = Role.User
            },
            new User(){
                Login = "masha",
                Password = "privetMasha12",
                BirthDate = new DateTime(2010, 1, 9),
                Gender = Gender.Female,
                Email = "masha@mail.ru",
                FullName = "Бот Мария",
                Role = Role.User
            }
        ];
        public void Registrate(User user)
        {
            _users.Add(user);
        }
        public bool Authorize(string login, string password)
        {
            return _users.FirstOrDefault(x=>x.Login == login && x.Password == password) != null;
        }

        public List<User> Users {  get => _users.Where(x => x.Role == Role.User).ToList(); } 
        public List<User> Admins { get => _users.Where(x => x.Role == Role.Administrator).ToList(); } 
        public List<User> AllUsers { get => _users; set => _users = value; } 
    }
}
