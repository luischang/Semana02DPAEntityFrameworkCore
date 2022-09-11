// See https://aka.ms/new-console-template for more information

using Semana02DPAConsole.CodeFirst.Models;

Console.WriteLine("Hello, World!");

var context = new Qatar2022DbContext();
//Insert player
//var player1 = new Player()
//{
//    FullName = "Lionel Messi",
//    Dorsal = 10,
//    Status = true
//};

//context.Player.Add(player1);
//context.SaveChanges();

//var player2 = new Player()
//{
//    FullName = "Paolo Guerrero",
//    Dorsal = 99,
//    Status = true
//};

//var player3 = new Player()
//{
//    FullName = "Cristiano Ronaldo",
//    Dorsal = 7,
//    Status = true
//};


//var player4 = new Player()
//{
//    FullName = "Gianluca Lapadula",
//    Dorsal = 21,
//    Status = true
//};

//var player5 = new Player()
//{
//    FullName = "Zinedine Zidane",
//    Dorsal = 20,
//    Status = false
//};

//var listadoJugadores = new List<Player>();
//listadoJugadores.Add(player2);
//listadoJugadores.Add(player3);
//listadoJugadores.Add(player4);
//listadoJugadores.Add(player5);

//context.Player.AddRange(listadoJugadores);
//context.SaveChanges();

//Search player
//LINQ query expressions
//var todosLosJugadores = (from p in context.Player
//                         where p.Status == true
//                         select p).ToList();
//Lambda expressions
//var todosLosJugadores = context.Player.Where(p=>p.Status==true).ToList();

//foreach (var item in todosLosJugadores)
//{
//    Console.WriteLine(item.FullName + " | " + item.Dorsal);
//}

var buscarJugador = (from p in context.Player
                     where p.Dorsal == 30
                     select p).FirstOrDefault();
Console.WriteLine("El jugador encontrado es: " + buscarJugador.FullName);
//Update player
//buscarJugador.Dorsal = 30;
//context.SaveChanges();

//Delete player

context.Player.Remove(buscarJugador);
context.SaveChanges();



