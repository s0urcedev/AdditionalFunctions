# OlympHelper
## Introduction / Вступ / Вступление

<ins>***English:***</ins> I have some experience in programming olympics. I think that it could help other people with preparing to competitions and get some working algorithms. There you will find algorithms on Python, JavaScript and C++, but you also can easily rewrite then on your language. I'ill give link to all ideas and text descriptions of algorithms. I believe that this repo could help you :)

<ins>***Українська:***</ins> У мене є деякий досвід в олімпіадах з програмування. Я вважаю, що він може допомогти іншим людям підготуватися до змагань та отримати деякі робочі алгоритми. Тут ти знайдеш алгоритми на Python, JavaScript та C++, але ти завжди можешь з легкістю переписати їх на свою мову. Я додам посилання на усі ідеї та текстові описи алгоритмів. Я вірю, що цей репозиторій допоможе тобі :)

<ins>***Русский:***</ins> У меня есть некоторый опыт в олимпиадах по программированию. Я считаю, что он моджет помочь другим людям подготовится к соревнованиям и получить некоторые рабочие алгоритмы. Тут ты найдёшь алгоритмы на Python, JavaScript и C++, но ты всегда можешь с лёгкостью переписать их на свой язык. Я добавлю ссылки на все идеи и текстовые описания алгоритмов. Я верю что этот репозиторий поможет тебе :)

## Swap / Заміна / Замена

`Python`:

```python
x = x + y
y = x - y
x = x - y
```

`JavaScript` or `C++`:

```js
x = x + y;
y = x - y;
x = x - y;
```

## Working with arrays / Робота с масивами / Работа с массивами

<ins>***English:***</ins> Array — one of the frequently used data structure in programming. In dynamic programming languages like Python or JavaScript there are built functions for working with arrays in most ways: from slicing to sorting, but in static languages like C or C++ there aren't as a lot of functions as in dynamic. So in this part I'ill show you some ways how you can edit arrays on most languages without any problems.

<ins>***Українська***</ins> Масив — одина зі структур данний, яку частіше за все використовують у програмуванні. У динамічних мовах програмування по типу Python або JavaScript є вбудовані функції для роботи з масивами з більшості сторін: від вирізання до сортування, але у статичних мовах программування по типу C або C++ немає такої ж кількості функцій як у динамічних. Тому у цій частині я покажу тобі декілька способів, як ти можешь редагувати масиви на більшості мов без проблем.

<ins>***Русский***</ins> Массив — одна из структур данный, которую чаще всего используют в программировании. В динамических языках программирования на подобии Python или JavaScript есть встроенные функции дря работы с массивами с большинства сторон: от вирезания до сортировки, но в статическихм якыках программирования на подобии C или C++ нету такого же количтва функций как в динамических. По-этому в этой части я покажу тебе несколько способов, как ты можешь редактировать массив на большинстве языков программирования.

### Iteration / Ітерація / Итерация

`Python`:

```python
for i in range(0, len(a)):
    #do something with a[i]
    #роби щось з a[i]
    #делай что-то с a[i]
```

`Or`:

```python 
for n in a:
    #do something with n
    #роби щось з n
    #делай что-то с n
```

`JavaScript`:

```js
for(let i = 0; i < a.length; i ++){
    //do something with a[i]
    //роби щось з a[i]
    //делай что-то с a[i]
}
```

`Or`:

```js
a.forEach(n => {
    //do something with n
    //роби щось з n
    //делай что-то с n
});
```

`C++`:

```cpp
for(int i = 0; i < len; i++){
    //do something with a[i]
    //роби щось з a[i]
    //делай что-то с a[i]
}
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива


### Make a slice / вирізати / вырезать

`Python`:

```python
b = a[start : end]
```

`JavaScript`:

```js
let b = a.slice(start, end);
```

`C++`:

```cpp
int b[end - start];
for(int i = start; i < end; i ++){
    b[i - start] = a[i];
}
```

`a` — old array / старий масив / старый массив

`b` — new array / новий масив / новый массив

`start` — slice start (included) / початок вирізу (включно) / начало выреза (включительно)

`end` — slice end (not included) / кінець вирізу (не включно) / коцец выреза (не включительно)

### Count element repetition / Підрахувати повторення елементу / Подсчитать повторения элемента

`Python`:

```python
counter = a.count(x)
```

`JavaScript`:

```js
let counter = a.filter(i => i == x).length;
```

`C++`:

```cpp
int counter = 0;
for(int i = 0; i < len; i ++){
    if(a[i] == x){
        counter ++;
    }
}
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

`counter` — counter / лічильник / счётчик

### Does array include element? / Чи включає в себе масив елемент? / Включает ли в себя массив элемент?

`Python`:

```python
result = x in a
```

`JavaScript`:

```js
let result = a.includes(x);
```

`C++`:

```cpp
bool result = false;
for(int i = 0; i < len; i ++){
    if(a[i] == x){
        relult = true;
        break;
    }
}
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

`result` — result / результат / результат

### Find first element index / Пошук першого індекса елементу / Поиск первого индекса элемента

`Python`:

```python
result = a.find(x)
```

`JavaScript`:

```js
result = a.indexOf(x);
```

`C++`:

```cpp
int result = -1;
for(int i = 0; i < len; i ++){
    if(a[i] == x){
        result = i;
        break;
    }
}
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

`result` — result / результат / результат

### Find last element index / Пошук останнього індекса елементу / Поиск последнего индекса элемента

`Python`:

```python
result = a.rfind(x)
```

`JavaScript`:

```js
result = a.lastIndexOf(x);
```

`C++`:

```cpp
int result = -1;
for(int i = len - 1; i >= 0; i --){
    if(a[i] == x){
        result = i;
        break;
    }
}
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

`result` — result / результат / результат

### Delete first element / Видалили перший елемент / Удилть первый элемент

`Python`:

```python
a.pop(0)
```

`JavaScript`:

```js
a.shift();
```

`C++`:

> *In C++ you can't changing number of array elemnts, so in real your array will collect some elemеnts in the end after operations, but making `len` less deal with this problem when you iterate array*
> 
> *У С++ ти не можешь змінювати кількість елементів масива, в реальності твій масив буде накопичувати елементи у кінці після операцій, але зменшування `len` вирішує цю проблему коли ти ітеруешь масив*
> 
> *В С++ ты не можешь изменять количество элементов массива, то-этому в реальности твой массив будет накапливать элементы в концу после оперций, но уменьшение  `len` решает эту проблему когда ты итерируешь массив*

```cpp
len --;
for(int i = 0; i < len; i ++){
    a[i] = a[i + 1];
}
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

### Delete last element / Видалили останній елемент / Удилть последний элемент

`Python`:

```python
a.pop()
```

`JavaScript`:

```js
a.pop();
```

`C++`:

> *In C++ you can't changing number of array elemnts, so in real your array will collect some elemеnts in the end after operations, but making `len` less deal with this problem when you iterate array*
> 
> *У С++ ти не можешь змінювати кількість елементів масива, в реальності твій масив буде накопичувати елементи у кінці після операцій, але зменшування `len` вирішує цю проблему коли ти ітеруешь масив*
> 
> *В С++ ты не можешь изменять количество элементов массива, то-этому в реальности твой массив будет накапливать элементы в концу после оперций, но уменьшение  `len` решает эту проблему когда ты итерируешь массив*

```cpp
len --;
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

### Delete element by index / Видалили елемент по індексу / Удилть элемент по индексу

`Python`:

```python
a.pop(x)
```

`JavaScript`:

```js
a.splice(x, 1);
```

`C++`:

> *In C++ you can't changing number of array elemnts, so in real your array will collect some elemеnts in the end after operations, but making `len` less deal with this problem when you iterate array*
> 
> *У С++ ти не можешь змінювати кількість елементів масива, в реальності твій масив буде накопичувати елементи у кінці після операцій, але зменшування `len` вирішує цю проблему коли ти ітеруешь масив*
> 
> *В С++ ты не можешь изменять количество элементов массива, то-этому в реальности твой массив будет накапливать элементы в концу после оперций, но уменьшение  `len` решает эту проблему когда ты итерируешь массив*

```cpp
for(int i = x; i < len; i ++){
    a[i] = a[i + 1];
}
len --;
```

`a` — array / масив / массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

### Add element to start / Додавання елемента у початок / Добавление элемента в начало

`Python`:

```python
a.insert(0, x);
```

`JavaScript`:

```js
a.splice(0, 0, x);
```

`C++`:

> *In C++ you can't changing number of array elemnts, so you have to create new one*
> 
> *У С++ ти не можешь змінювати кількість елементів масива, тому ти повинен створити новий*
> 
> *В С++ ты не можешь изменять количество элементов массива, то-этому ти должен создать новый*

```cpp
int b[len + 1];
b[0] = x;
for(int i = 0; i < len; i ++){
    b[i + 1] = a[i];
}
```

`a` — old array / старий масив / старый массив

`b` — new array / новий масив / новый массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

### Add element to end / Додавання елемента у кінець / Добавление элемента в конец

`Python`:

```python
a.append(x);
```

`JavaScript`:

```js
a.push(x);
```

`C++`:

> *In C++ you can't changing number of array elemnts, so you have to create new one*
> 
> *У С++ ти не можешь змінювати кількість елементів масива, тому ти повинен створити новий*
> 
> *В С++ ты не можешь изменять количество элементов массива, то-этому ти должен создать новый*

```cpp
int b[len + 1];
for(int i = 0; i < len; i ++){
    b[i] = a[i];
}
b[len] = x;
```

`a` — old array / старий масив / старый массив

`b` — new array / новий масив / новый массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

### Add element by index / Додавання елемента по індексу / Добавление элемента по индексу

`Python`:

```python
a.insert(y, x);
```

`JavaScript`:

```js
a.splice(y, 0, x);
```

`C++`:

> *In C++ you can't changing number of array elemnts, so you have to create new one*
> 
> *У С++ ти не можешь змінювати кількість елементів масива, тому ти повинен створити новий*
> 
> *В С++ ты не можешь изменять количество элементов массива, то-этому ти должен создать новый*

```cpp
int b[len + 1];
for(int i = 0; i < y; i ++){
    b[i] = a[i];
}
b[y] = x;
for(int i = y; i < len; i ++){
    b[i + 1] = a[i];
}
```

`a` — old array / старий масив / старый массив

`b` — new array / новий масив / новый массив

`len` — array length / довжина масива / длина массива

`x` — element / елемент / элемент

`y` — element index / індекс елемента / индекс элемента


## Sorting / Сортування / Сотрировка

<ins>***English:***</ins> Continuing topix about array I'll tell you about sortring arrays. For better understanding I recomend you to read about [algorythm's time complexity](https://en.wikipedia.org/wiki/Time_complexity). In this part you could know most ways how you can sort your array. Understand pluses and minuses of all algorythms and get cases when and where you might use them.

<ins>***Українська:***</ins> Продовженням теми про масиви я розповім тобі про сортування масивів. Для більш гарного розуміння я рекомендую тобі почитати про [часову складність алгоритму](https://uk.wikipedia.org/wiki/Часова_складність). У цій частині ти зможеш дізнатися про більшість способів, як ти можешь відсортувати твій масив. Зрозуміти плюси на мінуси усіх алгоритмів та отримати ситуаціх коли ти маешь їх використовувати.

<ins>***Русский:***</ins> Продолжением темы про массивы я расскажу тебя про сортировку массивов. Для лучшего понимания я рекомендую тебе почитать про [временную сложность алгоритма](https://ru.wikipedia.org/wiki/Временная_сложность_алгоритма). В этой части ты сможеш узнать про большинство способов, как ты можешь отсортировать твой массив. Понять плюсы и минусы всех алгоритмов и получить ситуации когда ты должен их использовать.

### Bubble sort / Бульбашкове сортування / Пузырьковая сортировка

**Time complexity / Часова складність / Временная сложность :** *O(n<sup>2</sup>)*.

**Pluses / Плюси / Плюсы :** *Easy and short / Простий та короткий / Простой и которкий*

**Minuses / Мінуси / Минусы :** *Slow / Повільний / Медленний*

<ins>***Wikipedia:***</ins> *[Bubble sort](https://en.wikipedia.org/wiki/Bubble_sort)*

<ins>***Вікіпедія:***</ins> *[Бульбашкове сортування](https://uk.wikipedia.org/wiki/Сортування_бульбашкою)*

<ins>***Википедия:***</ins> *[Пузырьковая сортировка](https://ru.wikipedia.org/wiki/Сортировка_пузырьком)*

`Python`:

```python
k = 0
while k < len(a) - 1:
    k = 0
    for j in range(0, len(a)-1):
        if a[j] > a[j+1]:
            a[j] = a[j] + a[j+1]
            a[j+1] = a[j] - a[j+1]
            a[j] = a[j] - a[j+1]
        else:
            k += 1
```

<ins>***File:***</ins> *[Bubble_Sort.py](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Bubble_Sort.py)*

`JavaScript`:

```js
let k = 0;
while(k < a.length - 1){
    k = 0;
    for(let j = 0; j < a.length - 1; j ++){
        if(a[j] > a[j+1]){
            a[j] = a[j] + a[j+1];
            a[j+1] = a[j] - a[j+1];
            a[j] = a[j] - a[j+1];
        }
        else{
            k ++;
        }
    }
}
```

<ins>***File:***</ins> *[Bubble_Sort.js](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Bubble_Sort.js)*

`C++`:

```cpp
while(k < len - 1){
    k = 0;
    for(int j = 0; j < len - 1; j ++){
        if(a[j] > a[j+1]){
            a[j] = a[j] + a[j+1];
            a[j+1] = a[j] - a[j+1];
            a[j] = a[j] - a[j+1];
        }
        else{
            k ++;
        }
    }
}
```

<ins>***File:***</ins> *[Bubble_Sort.cpp](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Bubble_Sort.cpp)*

### Selection sort / Сортування вибором / Сортировка выбором

**Time complexity / Часова складність / Временная сложность :** *O(n<sup>2</sup>)*.

**Pluses / Плюси / Плюсы :** *Easy and short / Простий та короткий / Простой и которкий*

**Minuses / Мінуси / Минусы :** *Slow / Повільний / Медленний*

<ins>***Wikipedia:***</ins> *[Selection sort](https://en.wikipedia.org/wiki/Selection_sort)*

<ins>***Вікіпедія:***</ins> *[Сортування вибором](https://uk.wikipedia.org/wiki/Сортування_вибором)*

<ins>***Википедия:***</ins> *[Сортировка выбором](https://ru.wikipedia.org/wiki/Сортировка_выбором)*

`Python`:

```python
for i in range(0, len(a) - 1):
    imin = i
    for j in range(i + 1, len(a)):
        if a[j] < a[imin]:
            imin = j
    if imin != i:
        a[i] = a[i] + a[imin]
        a[imin] = a[i] - a[imin]
        a[i] = a[i] - a[imin]
```

<ins>***File:***</ins> *[Selection_Sort.py](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Selection_Sort.py)*

`JavaScript`:

```js
for(let i = 0; i < a.length - 1; i ++){
    let imin = i;
    for(let j = i + 1; j < a.length; j ++){
        if(a[j] < a[imin]){
            imin = j;
        }
    }
    if(imin != i){
        a[i] = a[i] + a[imin];
        a[imin] = a[i] - a[imin];
        a[i] = a[i] - a[imin];
    }
}
```

<ins>***File:***</ins> *[Selection_Sort.js](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Selection_Sort.js)*

`C++`:

```cpp
while(k < len - 1){
    for(int i = 0; i < len - 1; i ++){
        int imin = i;
        for(int j = i + 1; j < len; j ++){
            if(a[j] < a[imin]){
                imin = j;
            }
        }
        if(imin != i){
            a[i] = a[i] + a[imin];
            a[imin] = a[i] - a[imin];
            a[i] = a[i] - a[imin];
        }
    }
}
```

<ins>***File:***</ins> *[Selection_Sort.cpp](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Selection_Sort.cpp)*

<ins>***File:***</ins> *[Bubble_Sort.cpp](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Bubble_Sort.cpp)*

### Insertion sort / Сортування включенням / Сортировка вставками

**Time complexity / Часова складність / Временная сложность :** *O(n<sup>2</sup>)*.

**Pluses / Плюси / Плюсы :** *Easy and short / Простий та короткий / Простой и которкий*

**Minuses / Мінуси / Минусы :** *Slow / Повільний / Медленний*

<ins>***Wikipedia:***</ins> *[Insertion_Sort](https://en.wikipedia.org/wiki/Insertion_sort)*

<ins>***Вікіпедія:***</ins> *[Сортування включенням](https://uk.wikipedia.org/wiki/Сортування_включенням)*

<ins>***Википедия:***</ins> *[Сортировка вставками](https://ru.wikipedia.org/wiki/Сортировка_вставками)*

`Python`:

```python
for j in range(1, len(a)):
    key = a[j]
    i = j - 1
    while i >= 0 and a[i] > key:
        a[i+1] = a[i]
        i -= 1
    a[i+1] = key
```

<ins>***File:***</ins> *[Insertion_Sort.py](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Insertion_Sort.py)*

`JavaScript`:

```js
for(let j = 1; j < a.length; j ++){
    key = a[j];
    i = j - 1;
    while(i >= 0 && a[i] > key){
        a[i+1] = a[i];
        i --;
    } 
    a[i+1] = key;
}
```

<ins>***File:***</ins> *[Insertion_Sort.js](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Insertion_Sort.js)*

`C++`:

```cpp
for(int j = 1; j < len; j ++){
    int key = a[j];
    int i = j - 1;
    while (i >= 0 && a[i] > key){
        a[i+1] = a[i];
        i --;
    }
    a[i+1] = key;
}
```

<ins>***File:***</ins> *[Insertion_Sort.cpp](https://github.com/s0urce18/OlympHelper/blob/main/Sort/Insertion_Sort.cpp)*
