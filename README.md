1. Имеется функция CertainSizeOfElement, которая на вход принимает одномерный строковой масссив InitialArray и переменную типа int SizeOfElement, при помощи которой определяется элемент массива InitialArray, который необходимо оставить исходя из количества символов в нем, которое не превышает значение данной переменной. На выходе функции представляется строковый массив с результирующими данными. Работа функции заключается в следующем:
* при помощи цикла FOR определяется количество эллементов в массиве InitialArray, длина которых не превышает размерность, указанной в переменной SizeOfElement, количество таких элементов подсчитывается в переменной NumberOfElements;
* создается новый строковой массив "ResultArray" с размерностью равной NumberOfElements;
* создается переменная ElementRA равной первоначально 0 (нулю), которая является счетчиком для элементов массива ResultArray, требующийся в дальнейшем для перебора элементов данного массива;
* создается цикл FOR с условием IF длина элемента InitialArray не превышает SizeOfArray, в случае положительного результата происходит присваивание элементу массива ResultArray с индексом ElementRA значения элемента массива InitialArray с индексом равным показателю переменной i из структуры цикла FOR, а переменной ElementRA прибавляется 1 (единица) для перехода на следующий элемент массива ResultArray.
2. Вывод массива на печать:
Для вывода массива в консоль создается функция void PrintArray, которая принимает на вход строковый массив, алгоритм функции заключатеся в следующем:
* При помощи команды Console.Write выводится открывающая скобка массива "[";
* Создается цикл FOR, в котором перебирается каждый элемент массива и командой Console.Write выводится в консоль. В данном цикле есть условие IF индекс элемента массива меньше длины массива минус 1 (один) (т.е. элемент не является последним в массиве), выводится ", " после значения действующего элемента массива;
* После цикла FOR при помощи команды Console.Write выводится закрывающая скобка массива "]".
