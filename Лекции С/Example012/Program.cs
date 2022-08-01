// Виды Методов
// Вид 1

void Method1 ()
{
    Console.WriteLine("Hello, World!");
}
//Method1();

// Вид2

void Method2 (string msg)
{
    Console.WriteLine (msg);
}
//Method2 (msg: "Текст сообщения");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
//Method21(count: 4, msg: "Текст сообщения");

// Вид3

int Method3 ()
{
    return DateTime.Now.Year;
}
//int year = Method3 ();
//Console.WriteLine(year);

// Вид4

/*string Method4 (int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4 (10, "QWERTY");
Console.WriteLine(res);*/

// Цикл for
string Method4 (int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
//string res = Method4 (10, "QWERTY");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} х {j} = {i*j}");
    }
}

//Задача: В тексте заменить пробелы черточками, к на К, С на с

string text = "Лондон ослабил российские санкции в сфере страхования судов и самолетов." + "Подробнее на РБК:";

// string s = "qwerty"
//             0123
// s[3] // r

/*string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'К', 'к');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();*/

// Задача сортировки массива: от меньшего значения к большему

int [] arr = {1,4,2,5,6,8,7,3};

void PrintArray(int[] array )
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);


