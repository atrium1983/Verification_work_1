# Задача: 

*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

*Примеры:*
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Решение:

Пользователь вводит заранее известное количество строковых переменнх разной длины. Действие программы:
* принять строковые переменные в матрицу;
* найти в полученной матрице количество строковых переменных, длина которых на превышает 3 символа;
* создать новую матрицу, длина которой равна количеству строковых переменных, удовлетворяющих условию выше;
* вывести обе матрицы в терминал.