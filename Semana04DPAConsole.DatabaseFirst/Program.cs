// See https://aka.ms/new-console-template for more information
using Semana04DPAConsole.DatabaseFirst.Models;

Console.WriteLine("Hello, World!");

var context = new Qatar2022DbContext();

//Insert player
var player1 = new Player()
{
    FullName = "Raul Ruidíaz",
    Dorsal = 11,
    Status = true
};

context.Player.Add(player1);
context.SaveChanges();
