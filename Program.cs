using desafio.src.Entities;

Fire Charmander = new Fire ("Charmander", 15, "Fogo");
Water Squitler = new Water ("Squirtle", 25, "Aquatico");
Grass Bulbasaur = new Grass ("Bulbasaur", 17, "Planta");
Eletric Pikachu = new Eletric ("Pikachu", 26, "Eletrico");

System.Console.WriteLine(Charmander.Attack());
System.Console.WriteLine(Squitler.Attack(0));
System.Console.WriteLine(Bulbasaur.Attack(4));
System.Console.WriteLine(Pikachu.Attack(8));