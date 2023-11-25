// See https://aka.ms/new-console-template for more information
using Changing.Models;

Console.WriteLine("Hello, World!");
User user = new("Orxan ibrahimzade", "Orxaan12@gmail.com", "Teymur123");
user.checkPssword(user.Password);
user.ShowingInfo();