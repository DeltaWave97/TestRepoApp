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
Console.WriteLine("While, wybrana liczba = "+ liczba  );
    while (n != 1) {
            res = res * n;
            n = n - 1;
     Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res );  
     }
    Console.WriteLine("Ostateczny wynik = " + res );

 Console.WriteLine("_________________" );
 Console.WriteLine("Do While, wybrana liczba = "+ liczba  );
n = liczba;
res = 1;
 do {
    res = res * n;
        n=n-1;
     Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res );  
    }
 while (n != 1);
    Console.WriteLine("Ostateczny wynik = " + res );

 Console.WriteLine("_________________" );
 Console.WriteLine("For, wybrana liczba = "+ liczba  );

res = 1;
for (n=liczba;n!=1;n--)
{
    res = res * n;
     Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res );  
}
    Console.WriteLine("Ostateczny wynik = " + res );

Console.WriteLine("1. Wyświetl silnię dla danej losowej liczby. Możesz sobie wybrać np. int number = 12, i potem sprawdzać inne.");
int liczba = 7;
int res = 1;
int n = liczba;
Console.WriteLine("While, wybrana liczba = "+ liczba  );
    while (n != 1) {
            res = res * n;
            n = n - 1;
     Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res );  
     }
    Console.WriteLine("Ostateczny wynik = " + res );

 Console.WriteLine("_________________" );
 Console.WriteLine("Do While, wybrana liczba = "+ liczba  );
n = liczba;
res = 1;
 do {
    res = res * n;
        n=n-1;
     Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res );  
    }
 while (n != 1);
    Console.WriteLine("Ostateczny wynik = " + res );

 Console.WriteLine("_________________" );
 Console.WriteLine("For, wybrana liczba = "+ liczba  );

res = 1;
for (n=liczba;n!=1;n--)
{
    res = res * n;
     Console.WriteLine("Pozostalych obliczeń " + n + " Wynik póki co jest równy = " + res );  
}
    Console.WriteLine("Ostateczny wynik = " + res );