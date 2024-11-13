using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FortuneTigerGame.Forms.LoginForm;

namespace FortuneTigerGame.Models
{
    internal class User
    {
        public static User CurrentUser { get; private set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public int Balance { get; set; }

        private const int initialBalance = 1_000_000;


        public User(string name, string password, string email, string cpf)
        {
            Name = name;
            Password = password;
            Email = email;
            CPF = cpf;
            Balance = initialBalance;
        }


        public User()
        {
            Name = "tom";
            Password = string.Empty;
            Email = string.Empty;
            CPF = string.Empty;
            Balance = initialBalance;
        }



        public override string ToString()
        {
            return $"== USER ==\nName: {Name}\nPassword: {Password}\nEmail: {Email}\nCPF: {CPF}\n\nBalance: {Balance}";
        }

        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

        public void SetBalance(int balance)
        {
            Balance = balance;
        }
    }
}
