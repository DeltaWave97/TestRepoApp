// 1. Wyświetl silnię dla danej losowej liczby. Możesz sobie wybrać np. int
// number = 12, i potem sprawdzać inne.
// 2. Wyświetl odległość między podanymi współrzędnymi. Skorzystaj ze
// wzorów maturalnych na stronie CKE. Jako współrzędne wybierz sobie
// dowolne dwa punkty np. [x1= 2, y1= 10], [x2= -3,y2= -7]
// 3. Wyświetl trzeci bok trójkąta prostokątnego dla podanych dwóch jego
// boków przyprostokątnych. Wybierz dowolne liczby.
// 4. Napisz program który będzie wyświetlał podaną liczbę pierwszą z kolei,
// np. pierwsza liczba to 2, piąta to 11 itd.
// 5. Wyświetl dla podanych dwóch liczb całkowitych ich największy wspólny
// dzielnik.
// 6. Wyświetl dla podanych dwóch liczb całkowitych ich największą wspólną
// wielokrotność.
// 7. Wyświetl pole prostokąta dla podanej liczby całkowitej.
// 8. Wyświetl pole trójkąta dla podanej podstawy i wysokości.
// 9. Wyświetl pole równoległoboku dla podanej podstawy i wysokości
// 10. Wyświetl pole trapezu dla podanej wysokości oraz dwóch podstaw.

Console.WriteLine("1. Wyświetl silnię dla danej losowej liczby. Możesz sobie wybrać np. int number = 12, i potem sprawdzać inne.");
int liczba = 7;
int res = 1;
int n = liczba;
Console.WriteLine("While, wybrana liczba = " + liczba);
while (n != 1)
{
    res = res * n;
    n = n - 1;
    Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res);
}
Console.WriteLine("Ostateczny wynik = " + res);

Console.WriteLine("_________________");
Console.WriteLine("Do While, wybrana liczba = " + liczba);
n = liczba;
res = 1;
do
{
    res = res * n;
    n = n - 1;
    Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res);
}
while (n != 1);
Console.WriteLine("Ostateczny wynik = " + res);

Console.WriteLine("_________________");
Console.WriteLine("For, wybrana liczba = " + liczba);

res = 1;
for (n = liczba; n != 1; n--)
{
    res = res * n;
    Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res);
}
Console.WriteLine("Ostateczny wynik = " + res);
Console.WriteLine("_________________");
// 2. Wyświetl odległość między podanymi współrzędnymi. Skorzystaj ze
// wzorów maturalnych na stronie CKE. Jako współrzędne wybierz sobie
// dowolne dwa punkty np. [x1= 2, y1= 10], [x2= -3,y2= -7]

Console.WriteLine(" 2. Wyświetl odległość między podanymi współrzędnymi. Skorzystaj ze wzorów maturalnych na stronie CKE.");
Console.WriteLine("Jako współrzędne wybierz sobie dowolne dwa punkty np. [x1= 2, y1= 10], [x2= -3,y2= -7]");
int x1 = 1;
int x2 = 2;
int y1 = 3;
int y2 = 4;
n = 0;
double res2 = 0;
Console.WriteLine("Wybrano punkty X1 = " + x1 + " y1 = " + y1 + "x2 = " + x2 + "y2 = " + y2);
Console.WriteLine("Wzór : d=√((x_2-x_1)²+(y_2-y_1)²)");
Console.WriteLine("While");
while (n != 0)
{
    res2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

    n++;
}
Console.WriteLine("Wynik = " + res2);

Console.WriteLine("_________________");
Console.WriteLine("Do While");
do
{
    res2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine("Wynik = " + res2);
}
while (n == 1);


Console.WriteLine("_________________");
Console.WriteLine("for");
for (int i = 0; i < 1; i++)
{
    res2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine("Wynik = " + res2);
}
res = 0;
res2 = 0;
n=0;
// 3. Wyświetl trzeci bok trójkąta prostokątnego dla podanych dwóch jego
// boków przyprostokątnych. Wybierz dowolne liczby.
Console.WriteLine("_________________");
Console.WriteLine("// 3. Wyświetl trzeci bok trójkąta prostokątnego dla podanych dwóch jego boków przyprostokątnych. Wybierz dowolne liczby.");
Console.WriteLine("Wybrałem Wartości punktów analogicnze do X1 = " + x1 + " oraz Y1 = " + y1);
Console.WriteLine("While");
while (n <= 0)
{
    res2 = (Math.Pow(x1, 2) + Math.Pow(y1, 2));

    Console.WriteLine("Wynik = " + res2);
    n++;
}


Console.WriteLine("_________________");
Console.WriteLine("Do While");

do
{
    res2 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
    Console.WriteLine("Wynik = " + res2);
}
while (res2 < 0);


Console.WriteLine("_________________");
Console.WriteLine("for");
for (int i=0; i < 1; i++)
{
    res2 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
    Console.WriteLine("Wynik = " + res2);
}
Console.WriteLine("_________________");

// 4. Napisz program który będzie wyświetlał podaną liczbę pierwszą z kolei,
// np. pierwsza liczba to 2, piąta to 11 itd.

 Console.WriteLine("4. Napisz program który będzie wyświetlał podaną liczbę pierwszą z kolei, np. pierwsza liczba to 2, piąta to 11 itd.");

// 5. Wyświetl dla podanych dwóch liczb całkowitych ich największy wspólny dzielnik.
Console.WriteLine("5. Wyświetl dla podanych dwóch liczb całkowitych ich największy wspólny dzielnik");
int Num51 = 52, Num52 = 10;
int Num53 = 0;
if (Num51<Num52){
for (int i = 2; i <= Num51; i++) 
{

    if (Num51%i==0 & Num52%i==0)
    {
        if (i>Num53)
        {
            Num53 = i;
        }
    }
}
}
else
{
    for (int i = 2; i <= Num52; i++) 
{

    if (Num51%i==0 & Num52%i==0)
    {
        if (i>Num53)
        {
            Num53 = i;
        }
    }
}
}

Console.WriteLine($"Największy wspólny dzielnik liczb {Num51} oraz {Num52} wynosi {Num53}");

// 6. Wyświetl dla podanych dwóch liczb całkowitych ich największą wspólną
// wielokrotność.
Console.WriteLine("6. Wyświetl dla podanych dwóch liczb całkowitych ich największą wspólną wielokrotność.");
int Num61 = Num51, Num62=Num52;
Console.WriteLine($"Największa wspólna wielokrotność liczb {Num61} oraz {Num62} wynosi {Num61*Num62}");

// 7. Wyświetl pole prostokąta dla podanej liczby całkowitej.
Console.WriteLine("// 7. Wyświetl pole prostokąta dla podanej liczby całkowitej. ---------- zakładam, ze chodzi o kwadrat");
int Num71 = 6;
Console.WriteLine($"Wybrałem liczbę {Num71} i pole tej figury wynosi {Num71*Num71}");


// 8. Wyświetl pole trójkąta dla podanej podstawy i wysokości.
Console.WriteLine("// 8. Wyświetl pole trójkąta dla podanej podstawy i wysokości.");
int Num81=6, Num82=15;
Console.WriteLine($"Wybrałem liczby {Num81} oraz {Num82} i pole trójkąta wynosi {(Num81*Num82)/2}");

// 9. Wyświetl pole równoległoboku dla podanej podstawy i wysokości
Console.WriteLine("// 9. Wyświetl pole równoległoboku dla podanej podstawy i wysokości");
int Num91=15, Num92 = 14;
Console.WriteLine($"Wybrałem liczby {Num91} oraz {Num92} i pole równoległoboku wynosi {(Num91*Num92)}");

// 10. Wyświetl pole trapezu dla podanej wysokości oraz dwóch podstaw.
Console.WriteLine("// 10. Wyświetl pole trapezu dla podanej wysokości oraz dwóch podstaw.");
int Num101=15, Num102 = 14, Num103=4;
Console.WriteLine($"Wybrałem liczby podstaw {Num101} oraz {Num102}, wysokość: {Num103}, a pole trapezu wynosi {((Num101+Num102)*Num103)/2}");