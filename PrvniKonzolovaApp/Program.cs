using PrvniKonzolovaApp.Model;

//Person person1 = new Person("Marek","Bohanes");
//person1.DateOfBirdth = new DateTime(1986, 03, 08);

//Console.WriteLine(person1);





// pokud zadám konstruktor, už nemůžu zadat takto, popřípadě musím vložit prázdný konstruktor
//_2D bod1 = new _2D();
//bod1.X = 20;
//bod1.Y = 10;

//_2D bod2 = new _2D();
//bod2.X = 30;    
//bod2.Y = 15;


_2D bod3 = new _2D(1, 0);  // Pomocí konstruktoru

Console.WriteLine(bod3.GetQuadrant());

//Console.WriteLine($"X: {bod3.X} y: {bod3.Y}");

//bod3.Print();





//Obsah Obsah1 = new Obsah(20, 10);

//Console.WriteLine(Obsah1.VypocitejObsah());