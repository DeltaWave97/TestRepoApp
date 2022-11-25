/*
Do poniższych zadań nie możesz korzystać z żadnej wbudowanej metody 
która by rozwiązywała zadanie (np. Contains, Min, Max). Wszystkie 
zadania należy napisać samemu sprawdzając wartość po wartości w 
tablicy. 
Do generowania tablicy napisz metodę, która będzie ją zwracać z 
wylosowanymi wartościami z podanego przedziału. 
 
UWAGA – jeśli jest to możliwe, to do każdego zadania napisz metodę 
obsługującą liczby całkowite oraz drugą metodę obsługującą liczby 
zmiennoprzecinkowe (np. double) 
 
1.  Napisz metodę, która dla podanej tablicy zwróci największą liczbę. 
2.  Napisz metodę, która dla podanej tablicy zwróci drugą największą liczbę. 
3.  Napisz metodę, która dla podanej tablicy zwróci średnią, medianę oraz 
modę. 
4.  Napisz metodę, która dla podanej tablicy oraz podanej wartości zwróci 
informację, ile razy dana liczba występuję w owej tablicy (czyli metoda 
przyjmuje dwa argumenty: tablice oraz liczbę. następnie sprawdza ile 
razy ta liczba wystąpiła w tej tablicy i zwraca tą ilość). 
5.  Napisz metodę, która dla podanej tablicy oraz podanej wartości zwróci 
informację, czy dana wartość występuje w tablicy (czyli metoda 
przyjmuje dwa argumenty: tablice oraz liczbę. następnie sprawdza czy 
istnieje w tablicy dana liczba, a potem zwraca true/false). 
6.  Napisz metodę, która dla podanych dwóch tablic zwróci jedną tablicę 
będącą ich połączeniem. 
7.  Napisz metodę, która dla podanej tablicy zwróci nową tablicę z 
odwróconą kolejnością wartości (np. tablica A ma wartości: 1,2,3,4,5. 
Tablica B czyli wynik metody: 5,4,3,2,1). 
8.  Napisz metodę, która dla podanej tablicy zwróci nową tablicę, ale bez 
powtórzeń wartości (np. tablica A ma wartości: 1,1,2,2,3. Tablica B czyli 
wynik metody: 1,2,3). 
9.  Napisz metodę, która pozwoli do przekazanej tablicy dodawać nową 
wartość na jej początku. 
10. Napisz metodę, która przyjmuje trzy argumenty: tablicę, nową wartość, 
indeks w którym należy dodać nową wartość. Np. mamy tablicę 
[0,1,2,3,4,5], metoda AddOnIndex(tablica, nowaWartosc, 
indeksNowejWartosci) dla przekazanych wartości AddOnIndex(tablica, 
101, 2), zwróci wynik: [0,1,101,2,3,4,5]. 
11. Przeczytaj o algorytmach sortowania na stronie  https://code-
maze.com/sorting-algorithms-csharp/ i następnie dla 5 wybranych 
algorytmów napisz metodę, która dla podanej tablicy zwróci nową 
tablicę, ale z posortowanymi wartościami od największej do 
najmniejszej. 
 */


//int[] array1= Randomuse.generateArray(10);
int[] array1 = {0,1,2,3,5,8,9};
Console.Write($"Wylosowana Tablica -> ");
foreach (int item in array1)
{
    Console.Write($"{array1[item]} ");
}
Console.WriteLine("\n 1.  Napisz metodę, która dla podanej tablicy zwróci największą liczbę. ");

int x1=0;
foreach (int item in array1)
{
    if (x1<array1[item])
    {
        x1=item;
    }
    else {}
}
Console.WriteLine($"Największa liczba w tablicy to {x1} \n");
Console.WriteLine("---------------------------------------------------------------------------------------------");

Console.WriteLine("2.  Napisz metodę, która dla podanej tablicy zwróci drugą największą liczbę. ");
int x21=0;
int x22=0;

foreach (int item in array1)
{
    if (x21<item)
    {
        x22=x21;
        x21=item;
    }
    else {}
}
Console.WriteLine($"Druga Największa liczba w tablicy to {x22} \n");
Console.WriteLine("---------------------------------------------------------------------------------------------");

Console.WriteLine("3.  Napisz metodę, która dla podanej tablicy zwróci średnią, medianę oraz modę. ");
int  mediana3=0, moda3=0, i=0;
double srednia3 = 0;
foreach (int item in array1)
{
    i++;
    srednia3=srednia3+item;
}

if (i%2==0)
{
    mediana3 = array1[(1+i)/2];
}
else
{
    mediana3=array1[((1+i)/2)+1];
}

moda3 = array1.GroupBy(v => v)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

Console.WriteLine($"Suma Wszystkich Liczb = {srednia3} Wielkość tabeli = {i}"); 
Console.WriteLine($"Średnia = {srednia3/i}, Mediana={mediana3}, Moda={moda3}");
Console.WriteLine("---------------------------------------------------------------------------------------------");



Console.WriteLine("4.  Napisz metodę, która dla podanej tablicy oraz podanej wartości zwróci"); 
Console.WriteLine("informację, ile razy dana liczba występuję w owej tablicy (czyli metoda"); 
Console.WriteLine("przyjmuje dwa argumenty: tablice oraz liczbę. następnie sprawdza ile ");
Console.WriteLine("razy ta liczba wystąpiła w tej tablicy i zwraca tą ilość). ");


public static class Randomuse
{
	public static int[] generateArray(int count)
	{
		Random random = new Random();
		int[] values = new int[count];

		for (int i = 0; i < count; ++i)
			values[i] = random.Next(0,9);

		return values;
	}
}