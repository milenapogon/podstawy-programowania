using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        while (true)
        {
            Console.WriteLine("\n MENU ");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.WriteLine("0. Wyjście");

            Console.Write("Wybierz: ");
            string wybor = Console.ReadLine();

            // ZADANIE 1
            if (wybor == "1")
            {
                Console.WriteLine("\nZadanie 1 – Kalkulator");

                Console.Write("Podaj pierwszą liczbę: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Wybierz (+, -, *, /): ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine("Wynik: " + (a + b));
                        break;
                    case "-":
                        Console.WriteLine("Wynik: " + (a - b));
                        break;
                    case "*":
                        Console.WriteLine("Wynik: " + (a * b));
                        break;
                    case "/":
                        if (b != 0)
                            Console.WriteLine("Wynik: " + (a / b));
                        else
                            Console.WriteLine("Błąd: dzielenie przez zero");
                        break;
                    default:
                        Console.WriteLine("Nieznana operacja");
                        break;
                }
            }

            // ZADANIE 2
            else if (wybor == "2")
            {
                Console.WriteLine("\nZadanie 2 – Konwerter temperatur");

                Console.Write("Wybierz C lub F: ");
                string kierunek = Console.ReadLine();

                if (kierunek == "C")
                {
                    Console.Write("Podaj temperaturę w °C: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double f = c * 1.8 + 32;
                    Console.WriteLine(c + "°C = " + f + "°F");
                }
                else if (kierunek == "F")
                {
                    Console.Write("Podaj temperaturę w °F: ");
                    double f = Convert.ToDouble(Console.ReadLine());
                    double c = (f - 32) / 1.8;
                    Console.WriteLine(f + "°F = " + c + "°C");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór");
                }
            }

            // ZADANIE 3
            else if (wybor == "3")
            {
                Console.WriteLine("\nZadanie 3 – Średnia ocen ucznia");

                Console.Write("Podaj liczbę ocen: ");
                int liczbaOcen = Convert.ToInt32(Console.ReadLine());

                double suma = 0;

                for (int i = 0; i < liczbaOcen; i++)
                {
                    Console.Write("Podaj ocenę: ");
                    double ocena = Convert.ToDouble(Console.ReadLine());
                    suma += ocena;
                }

                double srednia = suma / liczbaOcen;
                Console.WriteLine("Średnia ocen: " + Math.Round(srednia, 2));

                if (srednia >= 3.0)
                    Console.WriteLine("Uczeń zdał.");
                else
                    Console.WriteLine("Uczeń nie zdał.");
            }

            // WYJŚCIE
            else if (wybor == "0")
            {
                Console.WriteLine("Koniec programu");
                break;
            }

            else
            {
                Console.WriteLine("Nieprawidłowy wybór");
            }
        }
    }
}
