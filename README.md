# c-sharp
Solutions and projects in Visual Studio on C#


<div>
 <div>
 <h2>
        Encryption
    </h2>
<p><b> 
Создан интерфейс ICipher, который определяет методы поддержки шифрования строк. В интерфейсе объявляются два метода Encode() и Decode(), которые используются для шифрования и дешифрования строк, соответственно. Реализовано 2 класса реализующих данный интерфейс. Алгоритмы: Атбаш и Сeaser.
 </b></p>
 
 <ul><b>Проекты, составляющие решение</b>
 <li> <a href="https://github.com/mikenmsl/c-sharp/tree/master/Encryption/ConsoleApp2" >ConsoleApp2 </a> -	Основная программа</li>
        <li> <a href="https://github.com/mikenmsl/c-sharp/tree/master/Encryption/ConsoleApp2.Tests" >ConsoleApp2.Tests</a> -	Модельные тесты </li>
    </ul>

<ul><b>Пользовательские типы:</b>
  <li>IChiper -	Содержит определения методов для классов Atbash и Сeaser </li>
        <li> Menu -	Считывание выбранной позиции меню</li>
        <li> InputFile -	Файловый ввод </li>
   <li>InputConsole -	Консольный ввод/вывод </li>
   <li>InputRand -	Рандомный ввод </li>
   <li>Atbash -	Реализация шифрования методом Атбаш </li>
   <li>Ceaser -	Реализация шифрования методом Ceaser </li>
   <li>End -	Сохранение в файл </li>
   <li>Program	- Основная программа </li>
  <li>Cases -	Выбор пункта меню </li>
  <li>Code -	Выбор шифровки или дешифровки </li>
    </ul>
    </div>
<div>
 <div>
 <h2>
        Division Array
    </h2>
<p><b> 
 Программа формирует из одномерного массива размером N, два массива размером N/2, включая в первый элементы исходного массива с четными индексами, а во второй — с нечетными. Вычислить суммы элементов каждого из массивов.

 </b></p>
 
 <ul><b>Проекты, составляющие решение</b>
 <li> <a href="https://github.com/mikenmsl/c-sharp/tree/master/DivisionArray/ConsoleApp1" >ConsoleApp1 </a> -	Основная программа</li>
        <li> <a href="https://github.com/mikenmsl/c-sharp/tree/master/DivisionArray/ConsoleApp1.Tests" >ConsoleApp1.Tests</a> -	Модельные тесты </li>
    </ul>

<ul><b>Пользовательские типы:</b>
        <li> Menu -	Считывание выбранной позиции меню</li>
        <li> InputFile -	Файловый ввод </li>
   <li>InputConsole -	Консольный ввод/вывод </li>
   <li>InputRand -	Рандомный ввод </li>
   <li>DivideByIndex -	Делит исходный массив на два других массива </li>
   <li>CountSum -	Считает сумму элементов массива </li>
   <li>End -	Сохранение в файл </li>
   <li>Program	- Основная программа </li>
  <li>Cases -	Выбор пункта меню </li>
    </ul>
    </div>
