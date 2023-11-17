// ==================================================== Lista 1 =====================================================

// Zadanie 1
void CheckTime()
{
    Console.WriteLine("Aktualny Czas " + DateTime.Now);
}

// Zadanie 2
bool StringIsDigit(string s)
{
    foreach (char c in s)
    {
        if (!char.IsDigit(c)) return false;
    }
    return true;
}

void WhatsYourAge()
{
    Console.WriteLine("Podaj mi prosze swoj rok urodzenia");
    string s = Console.ReadLine();
    if (s == null || s.Length == 0 || !StringIsDigit(s)) throw new Exception("Niepoprawny format roku");
    int yearOfBirth = int.Parse(s: s);
    int currentYear = DateTime.Now.Year;
    if (yearOfBirth > currentYear) throw new Exception("Jestes z przyszlosci?");
    Console.WriteLine("Masz " + (currentYear - yearOfBirth) + " lat");
}

// ==================================================== Lista 2 =====================================================

// Zadanie 1: 16
// Zadanie 2: 2, 2, 3, 3, 6
// Zadanie 3: 10, 0, 6, 50

// zadanie 5
double SegmentLength(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

// zadanie 6
double FahrenheitToCelsius(double c)
{
    return 32 + (double)9 / 5 * c;
}

// zadanie 7

double Delta(double a, double b, double c)
{
    return Math.Pow(b, 2) - 4 * a * c;
}
