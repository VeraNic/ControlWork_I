// Итоговая проверочная работа
//  Выполнила Фролова В.  2123

// "Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. 
// Мы должны убедиться что базовое знакомство с it прошло успешно.
// Задача алгоритмически не самая сложная, однако для полненного выполнения проверочной работы необходимо:

// 1.	Создать репозиторий на GitHub
// 2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
// 3.	Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4.	Написать программу, решающую поставленную задачу
// 5.	Использовать контроль версий в работе над этим небольшим проектом 
// (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 
// должны быть расположены в разных коммитах)".

// Задача: Написать программу, которая 
// из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 

// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello”, "2", "world”,-> ["2”]
// ["1234”, ”1567", ”-2”, "computer science"] -> ["-2"]
// ["Russia”, "Denmark", "Kazan"] -> []

// ДЕКОМПОЗИЦИЯ ЗАДАЧИ:
// - создать массив строк arrayInput,
// - подсчитать quantity элементов - строк, длина которых меньше либо равна 3,
// - задать массив, количество элементов которого равно quantity,
// - заполнить заданный массив строками из первого массива, длина которых меньше либо равна 3,
// - ввывести полученный массив.

textTask();
string[] arrayInput = {"Moscow", "gorod", "rose", "Yes", "it", "go"}; 
// string[] arrayInput = {"hallo”, "2”, "world”}; // - для тестирования программы
// string[] arrayInput = {"1234", "1567", "-2", "computer_science"};
// string[] arrayInput = {"Russia", "Denmark", "Kazan"};

int len = arrayInput.Length; //длина имеющегося массива
int quantity = 0; //количество элементов нового массива
quantity = lengthArrayOutput(arrayInput); //подсчет элементов, удовлетворяющих условию
string[] arrayOutput = new string[quantity]; //задание нового массива
arrayOutput = FillArray(arrayInput, arrayOutput); //заполнение нового массива
Console.WriteLine("Имеющийся массив строк:\n");
PrintArray(arrayInput);
Console.WriteLine("Сформированный массив строк:\n"); //вывод полученного массива
PrintArray(arrayOutput); 
Console.WriteLine("\n"); Console.ReadKey();

int lengthArrayOutput (string[] array) //функция определения длины нового массива
{   
    int counter = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++) 
        if (array[i].Length <= 3) counter++;
    return counter;
}

string[] FillArray(string[] array1, string[] array2) // функция заполнения нового массива в соотвестввии с условием задачи
{
    int size = array1.Length;
    int i = 0;
    int j = 0;
    while (i < size)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
        i++;
    }
    return array2;
}

void PrintArray (string[] matrix) //метод вывода массива в консоль
{Console.Write("[");
    for (int i = 0; i < matrix.Length; i++)
        {
        Console.ForegroundColor = ConsoleColor.Green; Console.Write($"'{matrix[i]}'"); Console.ResetColor(); 
         if (i == matrix.Length - 1) Console.Write("]");
                else Console.Write(", ");
        }
        Console.WriteLine("\n");
}

void textTask() //метод оформления вывода решения задачи
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "КОНТРОЛЬНАЯ РАБОТА\n"
        + "\nЗадача: Написать программу, которая из имеющегося массива строк"
        + "\nформирует массив из строк, длина которых меньше либо равна 3 символа.\n"
        ); 
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}