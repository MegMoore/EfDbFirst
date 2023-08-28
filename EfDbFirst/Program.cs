// See https://aka.ms/new-console-template for more information
using EfDbFirst.Models;


var _context = new MegMoContext();

var users = _context.Users.ToList();

foreach(var user in users)
{
    Console.WriteLine($"{user.FirstName} {user.LastName}");
}