# Итоговый проект

## Описание

### Задача: ### 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:

1. Создаем метод GetNumber.
2. Инициализируем строковый массив InitArray.
3. Создаем метод PrintArray.
4. Создаем метод, который будет печатать только элементы <= 3 по длине (LessThreeCharArray).
4.1. Во время первого прохода определяем, сколько элементов массива соответствуют условию и помещаем их в переменную counter.
4.2. Создаем пустой массив длинной равной counter.
4.3. Во время второго прохода по массиву элементы, удовлетворяющие условию, записываем в новый массив.
5. Запрашиваем у пользователя длину массиву.
6. Пользователь вводит и печатает элементы массива.
7. Печатаем новый массив по методу LessThreeCharArray.
