/* 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();

void Print (string text){ 
   Console.Write(text);
}

void PrintArray(string [] array){
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

string [] CreateStringArray(int elementNum){
    string [] array = new string [elementNum];
    for (int i = 0; i < elementNum; i++)
    {
        Print($"Введите строку символов {i+1} => ");
        array [i] = Console.ReadLine();
    }
    return array;
}

int CkeckElementNum (string [] array, int maxLength){
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length <= maxLength){
            num++;
        }
    }
    return num;

}

string [] SellectElementsInArray (string [] array, int elementsNum, int maxLength){
    string [] selectedArray = new string [elementsNum];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array [i].Length <= maxLength){
            selectedArray[j] = array [i];
            j++;
        }
    }
    return selectedArray;
}

int elementNum = 4;
int maxLength = 3;
string [] array = CreateStringArray(elementNum);
Print("Вы ввели : ");
PrintArray(array);
int num = CkeckElementNum (array, maxLength);
string [] selectedArray = SellectElementsInArray (array, num, maxLength);
Print($"Строки не превышающие {maxLength} : ");
PrintArray(selectedArray);