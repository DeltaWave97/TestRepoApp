// Każde zadanie wykonaj korzystając ze wszystkich znanych Ci pętli jedna
// pod drugą.

// 1. Wyświetl wszystkie liczby od -100 do 100
// 2. Wyświetl ilość liczb parzystych z przedziału od -100 do 100
// 3. Wyświetl ilość liczb podzielnych przez 5 z przedziału od -100 do 100
// 4. Wyświetl ilość liczb podzielnych przez 5 z przedziału od -000 do 100
// 5. Wyświetl liczby od -100 do 100, ale wszystkie liczby, których reszta z
// dzielenia przez 8 jest większa od 4 mają zostać pomnożone przez ich
// resztę z dzielenia.
// 6. Wyświetl liczby od 0 do 10 z dokładnością do jednego miejsca po
// przecinku. *- dla chętnego, bo trzeba poszukać w necie jak to zrobic
// 7. Wyświetl wszystkie liczby pierwsze z przedziału -100 do 100.
// 8. Wyświetl wszystkie znane Ci typy wartościowe wraz z ich rozmiarem (w
// bitach) oraz minimalną i maksymalną obsługiwaną liczbą.

// 1. Wyświetl wszystkie liczby od -100 do 100
Console.WriteLine("1. Wyświetl wszystkie liczby od -100 do 100");
Console.WriteLine("Pętla While");
int a = -100;
while (a <= 100)
{
    Console.WriteLine(a);
    a++;
}

Console.WriteLine("Pętla do While");
int b = -100;
do
{
    Console.WriteLine(b);
    b++;
}
while (b <= 100);

Console.WriteLine("Pętla For");
for (int i = -100; i < 101; i++)
{
    Console.WriteLine(i);
}

// 2. Wyświetl ilość liczb parzystych z przedziału od -100 do 100
Console.WriteLine("2.Wyświetl ilość liczb parzystych z przedziału od -100 do 100");

Console.WriteLine("Pętla While");
int e = -100;
int ei = -1;
while (e <= 100)
{
    e = e + 2;
    ei++;
}
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + ei);

Console.WriteLine("Pętla do While");
int f = -100;
int fi = -1;
do
{
    f = f + 2;
    fi++;
}
while (f <= 100);
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + fi);

Console.WriteLine("Pętla For");
int ki = -1;
for (int k = -100; k < 101; k = k + 2)
{
    ki++;
}
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + ki);

// 3. Wyświetl ilość liczb podzielnych przez 5 z przedziału od -100 do 100
Console.WriteLine(" 3. Wyświetl ilość liczb podzielnych przez 5 z przedziału od -100 do 100");

Console.WriteLine("Pętla While");
int c = -100;
int ci = -1;
while (c <= 100)
{
    c = c + 5;
    ci++;
}
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + ci);

Console.WriteLine("Pętla do While");
int d = -100;
int di = -1;
do
{
    d = d + 5;
    di++;
}
while (d <= 100);
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + di);

Console.WriteLine("Pętla For");
int ji = -1;
for (int j = -100; j < 101; j = j + 5)
{
    ji++;
}
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + ji);

// 4. Wyświetl ilość liczb podzielnych przez 5 z przedziału od -000 do 100
Console.WriteLine("4. Wyświetl ilość liczb podzielnych przez 5 z przedziału od -000 do 100");

Console.WriteLine("Pętla While");
int g = 0;
int gi = -1;
while (g <= 100)
{
    g = g + 5;
    gi++;
}
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + gi);

Console.WriteLine("Pętla do While");
int h = 0;
int hi = -1;
do
{
    h = h + 5;
    hi++;
}
while (h <= 100);
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + hi);

Console.WriteLine("Pętla For");
int li = -1;
for (int k = 0; k < 101; k = k + 5)
{
    li++;
}
Console.WriteLine("Ilość Liczb wymaganych w zadaniu -> " + li);

// 5. Wyświetl liczby od -100 do 100, ale wszystkie liczby, których reszta z
// dzielenia przez 8 jest większa od 4 mają zostać pomnożone przez ich
// resztę z dzielenia.
Console.WriteLine("5. Wyświetl liczby od -100 do 100, ale wszystkie liczby, których reszta z");

Console.WriteLine("Pętla While");
int a5 = -100;
while (a5 <= 100)
{
    if (Math.Abs(a5 % 8) > 4)
    {
        Console.WriteLine(a5 * (a5 % 8));
        a5++;
    }
    else
    {
        Console.WriteLine(a5);
        a5++;
    }
}

Console.WriteLine("Pętla do While");
int b5 = -100;
do
{
    if (Math.Abs(b5 % 8) > 4)
    {
        Console.WriteLine(b5 * (b5 % 8));
        b5++;
    }
    else
    {
        Console.WriteLine(b5);
        b5++;
    }
}
while (b5 <= 100);

Console.WriteLine("Pętla For");
for (int i = -100; i < 101; i++)
{
    if (Math.Abs(i % 8) > 4)
    {
        Console.WriteLine(i * (i % 8));
    }
    else
    {
        Console.WriteLine(i);
    }

}

// 6. Wyświetl liczby od 0 do 10 z dokładnością do jednego miejsca po
// przecinku. *- dla chętnego, bo trzeba poszukać w necie jak to zrobic
Console.WriteLine("6. Wyświetl liczby od 0 do 10 z dokładnością do jednego miejsca po przecinku");

Console.WriteLine("Pętla While");
decimal a6 = 0;
while (a6 <= 10)
{
    Console.WriteLine(a6);
    a6 = a6 + 0.1m;
}

Console.WriteLine("Pętla do While");
decimal b6 = 0;
do
{
    Console.WriteLine(b6);
    b6 = b6 + 0.1m;
}
while (b6 <= 10);

Console.WriteLine("Pętla For");
for (decimal i = 0; i < 10; i = i + 0.1m)
{
    Console.WriteLine(i);
}

// 7. Wyświetl wszystkie liczby pierwsze z przedziału -100 do 100.
Console.WriteLine("7. Wyświetl wszystkie liczby pierwsze z przedziału -100 do 100.");

for (int i = -100; i <= 100; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (Math.Abs(i) % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(i);
    }
}