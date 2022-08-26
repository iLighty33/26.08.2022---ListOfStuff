// See https://aka.ms/new-console-template for more information
using _26._08._2022___ListOfStuff;
using System.Collections.Generic;


// Готовые списки

List<string> hikeList = new List<string>() { "<hikeList>", "Keys", "Money", "Phone" };
List<string> raftList = new List<string>() { "<raftList>", "Keys", "Money", "Phone", "Pen" };

List<List<string>> myList = new List<List<string>>();

myList.Add(hikeList);
myList.Add(raftList);

Console.WriteLine("Готовые списки: ");

foreach (var list in myList)
{
    Console.WriteLine(String.Join($", ", list));
}

Console.WriteLine("Добавить список\n");

// Список в поход
// Список в сплав

Console.WriteLine("Введите название списка: ");
string? nameOfList = Console.ReadLine();

Console.WriteLine("[1] Ключи");
Console.WriteLine("[2] Деньги");
Console.WriteLine("[3] Телефон");

//switch (nameOfList)
//{
//    case "1":
//        hikeList.Add(new List(myList.Count + 1));
//        break;
//        case "2":

//        case "3":

//}




//hikeList.Add(new List(hikeList.Count + 1));

// Вывод элементов списка.
//foreach (var item in myList)
//{
//	Console.WriteLine(item);
//}


//int count = List.Vvod_quantity("Введите количество списков: ");

hikeList.Add("1. Ключи");
hikeList.Add("2. Деньги");
hikeList.Add("3. Телефон");

// II вариант

Console.WriteLine("Если вы ходите добавить элемент в строку нажмите Enter, если нет, то введите 0");

foreach (var item in hikeList)
{
	Console.WriteLine(item);
}

Console.WriteLine();

// Получение элемента списка по индексу.
var firstElement = hikeList[0];

Console.WriteLine(firstElement);

// Удаление элемента из списка.
hikeList.Remove(firstElement);

// Удаление элемента из списка по индексу.
hikeList.RemoveAt(1);

Console.WriteLine();

Console.ReadLine();