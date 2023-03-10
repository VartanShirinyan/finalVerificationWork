# Финальное домашнее задание

## Условия выполнения задачи:
1. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
2. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
3. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## *Алгоритм выполнения задачи*
1) Данный код на C# создает два массива строк: Array и newArray. В первом массиве заданы 5 строк различной длины. Во втором массиве создается пустой массив такой же длины, как и первый массив.

2) Затем объявляется функция newArray, которая принимает два массива строк в качестве параметров. Внутри функции происходит итерация по элементам массива Array при помощи цикла for. Если длина текущей строки в Array не превышает 3 символа, то эта строка добавляется в newArray. Для этого используется условный оператор if. Также внутри условного оператора увеличивается значение переменной count, которая отслеживает количество добавленных элементов в массив newArray.

3) Далее определена функция PrintArray, которая принимает массив строк в качестве параметра и выводит его элементы на консоль при помощи цикла for.

4) В конце основной программы вызывается функция newArray с передачей ей двух массивов в качестве параметров. Затем на консоль выводятся элементы массивов Array и newArray при помощи функции PrintArray. Первым выводится оригинальный массив, а затем новый массив, в котором остались только элементы с длиной строки меньше или равной 3 символам.

# Дальнейшие действия

* Добавление блок-схемы
* Добавление файла README.md