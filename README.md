# Итоговая проверочная работа


**Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

*Примеры:*

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

## Решение задачи:

1. Создаем массив из строк, объявляем его длину и заполняем примерами из условия.
2. Создаем новый массив, равный длине изначального.
3. Создаем метод(_ArrayTransfer_), который проверяет длину каждого элемента из первоначального массива. Если длина элемента меньше либо равна трем символам, наш метод переносит этот элемент в новый массив.
4. Создаем метод(_PrintArray_), который выводит элементы нового массива на экран.
5. Вызываем метод _ArrayTransfer_
6. Вызываем метод _PrintArray_

P.S. Посмотреть блок-схему метода решения можно в папке **diagram**