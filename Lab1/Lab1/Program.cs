// Project1

/*
//Zadanie "domowe"
const int RequiredAge = 14;
const int SimRequiredAge = 18;
const string AccessDeniedMessage = "Musisz miec 14 lat";
const string Wiad = "Zapraszamy!";
const string SimDeniedMessage = "Jestes za mlody zeby kupic karte SIM";

int age;

Console.Write("Podaj wiek: ");
age = Convert.ToInt32(Console.ReadLine());


if (age >= SimRequiredAge)
{
    Console.WriteLine(Wiad);
}
else if (age < RequiredAge)
{
    Console.WriteLine(AccessDeniedMessage);
}
else
{
    Console.WriteLine(SimDeniedMessage);
}

//Petla While
int count = 0;

while (count < 5)
{
    Console.WriteLine("Numer Iteracji  " + count);
    count++;
}

//petla Do While
string password;
do
{
    Console.Write("Podaj haslo: ");
    password = Console.ReadLine();

} while (password != "admin123");

Console.WriteLine("Zalogowano pomyslnie!");


int number;
do
{
    Console.Write("Podaj liczbę wiekszą od 0:  ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number <= 0);
Console.WriteLine("Gratulacje");

//petla foreach

int number = 0;
string[] citys = { "Krakow", "Wroclaw", "Poznan", "Gdansk", "Warszawa" };
foreach (string city in citys)
{
    number++;
    Console.WriteLine("Miasto " + number + " " + city);   
}
*/

//Polimorfizm

class Animal
{
    public void eat() => Console.WriteLine("Zwierzak je");
}

class Dog : Animal
{
    public void Bark () => Console.WriteLine("Pies szczeka");
}

class Cat : Animal
{
    public void Miau () => Console.WriteLine("kot miauczy");
}

//zadanie 1

        string poprawneHaslo = "admin123";
        string wpisaneHaslo;

        Console.WriteLine("Logowanie");

        do
        {
            Console.Write("Podaj hasło: ");

            wpisaneHaslo = Console.ReadLine();

            if (wpisaneHaslo != poprawneHaslo)
            {
                Console.WriteLine("Błędne hasło!\n");
            }

        } while (wpisaneHaslo != poprawneHaslo);

        Console.WriteLine("Hasło zaakceptowane.");

        Console.ReadKey();
		
//zadanie 2

        int liczba = 0;

        while (liczba <= 0)
        {
            Console.Write("Podaj liczbę większą od zera: ");

            liczba = int.Parse(Console.ReadLine());

            if (liczba <= 0)
            {
                Console.WriteLine("Liczba musi być dodatnia.\n");
            }
        }

        Console.WriteLine("Sukces");

        Console.ReadKey();
    

//zadanie 3

		string[] miasta = { "Poznan", "Krakow", "Wroclaw", "Gdansk", "Warszawa" };
		foreach (string miasto in miasta)
		{
			Console.WriteLine($"Miasto: {miasto}\n");
		}
    

//zadanie 4

		class Osoba
		{
			public string Imie { get; set; }
			public int Wiek { get; set; }

			public Osoba(string imie, int wiek)
			{
				Imie = imie;
				Wiek = wiek;
			}

			public void PrzedstawSie()
			{
				Console.WriteLine($"Mam na imię {Imie} i mam {Wiek} lat.");
			}
		}

		class Program
		{
			static void Main(string[] args)
			{
				Osoba osoba1 = new Osoba("Mikolaj", 21);

				Osoba osoba2 = new Osoba("Michal", 28);

				Osoba osoba3 = new Osoba("Zuza", 22);

				osoba1.PrzedstawSie();
				osoba2.PrzedstawSie();
				osoba3.PrzedstawSie();

				Console.ReadKey();
			}
		}

//zadanie 5

		class KontoBankowe
{
			private double saldo;

			public void Wplata(double kwota)
			{
					saldo += kwota;
			}

			public void Wyplata(double kwota)
			{

				if (saldo >= kwota)
				{
					saldo -= kwota;
				}
				else
				{
					Console.WriteLine("Brak wystarczających środków.");
				}
			}
			public double PobierzSaldo()
			{
				return saldo;
			}
		}

//zadanie 6

		class Animal
		{
			public void eat() => Console.WriteLine("Zwierzak je");
		}

		class Dog : Animal
		{
			public void Bark () => Console.WriteLine("Pies szczeka");
		}

		class Cat : Animal
		{
			public void Miau () => Console.WriteLine("kot miauczy");
		}

//zadanie 7

		class Zwierze
		{
			public string Imie { get; set; }

			public Zwierze(string imie)
			{
				Imie = imie;
			}

			public virtual void DajGlos()
			{
				Console.WriteLine($"{Imie} wydaje jakiś dźwięk.");
			}
		}

		class Pies : Zwierze
		{
			public Pies(string imie) : base(imie) { }

			public override void DajGlos()
			{
				Console.WriteLine($"{Imie}: Hau hau!");
			}
		}

		class Kot : Zwierze
		{
			public Kot(string imie) : base(imie) { }

			public override void DajGlos()
			{
				Console.WriteLine($"{Imie}: Miau miau!");
			}
		}

		class Program
		{
			static void Main(string[] a)
			{

				Zwierze[] zoo = new Zwierze[]
				{
					new Pies("Reksio"),
					new Kot("Mruczek"),
					new Pies("Kora"),
				};

				foreach (Zwierze z in zoo)
				{
					z.DajGlos();
				}

				Console.ReadKey();
			}
		}

//zadanie ostatnie

		class Pojazd
		{
			public virtual void Start() => Console.WriteLine("Pojazd uruchomiony");
		}
		class Samochod : Pojazd
		{
			public void Jedz() => Console.WriteLine("Samochód jedzie");
		}
		class ElektrycznySamochod : Samochod
		{
			public void Laduj() => Console.WriteLine("Ładowanie baterii...");
		}

		class Program
		{
			static void Main(string[] a)
			{
				ElektrycznySamochod tesla = new ElektrycznySamochod();

				tesla.Start();

				tesla.Jedz();

				tesla.Laduj();

			}
		}
