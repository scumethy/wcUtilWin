# Проект студентов 1 курса ФНН КНИТУ
* Студент: Ахмеджанов Ильгиз
* Студент: Кашапов Нияз
* Студент: Мажаров Максим
* Наставник: <code>Мангушева Алина</code>
____
**Цель проекта:** создать аналог bash-команды wc для ОС Windows.

**Краткое описание проекта:**
 
**Использованные технологии:**
  * Язык программирования C# на платформе: .NETCore v3.1
  * Сторонняя библиотека для парсинга аргументов командной строки: CommandLineParser
  * Фреймворк для юнит-тестирования .NET приложений: NUnit 3
____
### Памятка
Стандартная инструкция выглядит так:
<strong><code>wc file</code></strong>

Подробный синтаксис команды:
<strong><code>wc [-c][-l][-w] File1 File2 File3...</code></strong>

- wc — имя утилиты;
- file — название обрабатываемого файла.

##### Флаги
  - **-c**	--bytes	Отобразить размер объекта в байтах
  - **-w**	--words	Показать количесто слов в объекте
  - **-l**	--lines	Вывести количество строк в объекте
  - **--help** Вывести описание флагов
  
#### Вывод команды
Стандартно вывод команды выглядит следующим образом:
<strong><code>[line_count] [word_count] [byte_count] FileName</code></strong>

Для случаев, когда подано множество файлов, строк вывода информации о файле будет столько же, сколько и поданных файлов.

**Примечание:** При использовании каких-либо флагов, в вывод команды включается информация **только** от указанных флагов. 
