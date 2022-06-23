# AdditionalFunctions
## Page / Сторінка / Страница

[github.com/s0urce18/AdditionalFunctions](https://github.com/s0urce18/AdditionalFunctions)

[s0urce18.github.io/AdditionalFunctions](https://s0urce18.github.io/AdditionalFunctions/)

## Packages / Пакети / Пакеты

### Links / Посилання / Ссылки

`Python`: [pypi.org/project/additional-functions](https://pypi.org/project/additional-functions/)

`JavaScript`: [npmjs.com/package/additional-functions](https://www.npmjs.com/package/additional-functions)

### Installing / Встановлення / Установка

`Python`:

```
$ pip install additional_functions
```

`JavaScript`:

```
$ npm install additional-functions
```

### Importing / Підключення / Подключение

`Python`:

```python
import additional_functions as main
from additional_functions import sortings
from additional_functions import factorials
from additional_functions import combinatorics
from additional_functions import roman_arabic_numerals
from additional_functions import arithmetic
from additional_functions.progressions import ArithmeticProgression
from additional_functions.progressions import GeometricProgression
from additional_functions.progressions import HarmonicProgression
from additional_functions.binary_search_tree import Tree
from additional_functions.linked_list import LinkedList
from additional_functions import subarrays
```

`JavaScript`:

```js
let main = require('additional_functions');
let sortings = require('additional_functions/sortings');
let factorials = require('additional_functions/factorials');
let combinatorics = require('additional_functions/combinatorics');
let romanArabicNumerals = require('additional_functions/roman-arabic-numerals');
let arithmetic = require('additional_functions/arithmetic');
let ArithmeticProgression = require('additional-functions/progressions').ArithmeticProgression;
let GeometricProgression = require('additional-functions/progressions').GeometricProgression;
let HarmonicProgression = require('additional-functions/progressions').HarmonicProgression;
let Tree = require('additional-functions/binary-search-tree').Tree;
let LinkedList = require('additional-functions/linked-list').LinkedList;
let subarrays = require('additional_functions/subarrays');
```

## Introduction / Вступ / Вступление

<ins>***English:***</ins> I have some experience in programming olympics. I think that it could help other people with preparing to competitions and get some working algorithms. There you will find algorithms on Python, JavaScript, Go, C++ and C#, but you also can easily rewrite then on your language. I'ill give link to all ideas and text descriptions of algorithms. I believe that this repo could help you :)

<ins>***Українська:***</ins> У мене є деякий досвід в олімпіадах з програмування. Я вважаю, що він може допомогти іншим людям підготуватися до змагань та отримати деякі робочі алгоритми. Тут ти знайдеш алгоритми на Python, JavaScript, Go, C++ та C#, але ти завжди можешь з легкістю переписати їх на свою мову. Я додам посилання на усі ідеї та текстові описи алгоритмів. Я вірю, що цей репозиторій допоможе тобі :)

<ins>***Русский:***</ins> У меня есть некоторый опыт в олимпиадах по программированию. Я считаю, что он моджет помочь другим людям подготовится к соревнованиям и получить некоторые рабочие алгоритмы. Тут ты найдёшь алгоритмы на Python, JavaScript, Go, C++ и C#, но ты всегда можешь с лёгкостью переписать их на свой язык. Я добавлю ссылки на все идеи и текстовые описания алгоритмов. Я верю что этот репозиторий поможет тебе :)

## Sorting / Сортування / Сотрировка

### Packages / Пакети / Пакеты

`Python`:

```python
sortings.bubble(a)
sortings.selection(a)
sortings.insertion(a)
sortings.merge(a)
sortings.quick(a)
```

`JavaScript`:

```js
sortings.bubble(a);
sortings.selection(a);
sortings.insertion(a);
sortings.merge(a);
sortings.quick(a);
```

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
        if a[j] > a[j + 1]:
            a[j], a[j + 1] = a[j + 1], a[j]
        else:
            k += 1
```

<ins>***File:***</ins> *[bubble-sort.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/bubble-sort.py)*

`JavaScript`:

```js
let k = 0;
while(k < a.length - 1){
    k = 0;
    for(let j = 0; j < a.length - 1; j ++){
        if(a[j] > a[j + 1]){
            a[j] = a[j] + a[j + 1];
            a[j+1] = a[j] - a[j + 1];
            a[j] = a[j] - a[j + 1];
        }
        else{
            k ++;
        }
    }
}
```

<ins>***File:***</ins> *[bubble-sort.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/bubble-sort.js)*

`Go`:

```go
k := 0
for k < len(a)-1 {
    k = 0
    for j := 0; j < len(a)-1; j++ {
        if a[j] > a[j+1] {
            a[j], a[j+1] = a[j+1], a[j]
        } else {
            k++
        }
    }
}
```

<ins>***File:***</ins> *[bubble-sort.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/bubble-sort.go)*

`C++`:

```cpp
int k = 0;
while(k < len - 1){
    k = 0;
    for(int j = 0; j < len - 1; j ++){
        if(a[j] > a[j + 1]){
            a[j] = a[j] + a[j + 1];
            a[j + 1] = a[j] - a[j + 1];
            a[j] = a[j] - a[j + 1];
        }
        else{
            k ++;
        }
    }
}
```

<ins>***File:***</ins> *[bubble-sort.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/bubble-sort.cpp)*


`C#`:

```cs
int k = 0;
while(k < a.Length - 1)
{
    k = 0;
    for(int j = 0; j < a.Length - 1; j ++)
    {
        if(a[j] > a[j + 1])
        {
            a[j] = a[j] + a[j + 1];
            a[j + 1] = a[j] - a[j + 1];
            a[j] = a[j] - a[j + 1];
        }
        else
        {
            k ++;
        }
    }
}
```

<ins>***File:***</ins> *[bubble-sort.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/bubble-sort.cs)*


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
        a[i], a[imin] = a[imin], a[i]
```

<ins>***File:***</ins> *[selection-sort.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/selection-sort.py)*

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

<ins>***File:***</ins> *[selection-sort.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/selection-sort.js)*

`Go`:

```go
for i := 0; i < len(a)-1; i++ {
    imin := i
    for j := i + 1; j < len(a); j++ {
        if a[j] < a[imin] {
            imin = j
        }
    }
    if imin != i {
        a[i], a[imin] = a[imin], a[i]
    }
}
```

<ins>***File:***</ins> *[selection-sort.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/selection-sort.go)*

`C++`:

```cpp
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
```

<ins>***File:***</ins> *[selection-sort.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/selection-sort.cpp)*

`C#`:

```cs
for(int i = 0; i < a.Length; i ++)
{
    int imin = i;
    for(int j = i + 1; j < a.Length; j ++)
    {
        if(a[j] < a[imin])
        {
            imin = j;
        }
    }
    if(imin != i)
    {
        a[i] = a[i] + a[imin];
        a[imin] = a[i] - a[imin];
        a[i] = a[i] - a[imin];
    }
}
```

<ins>***File:***</ins> *[selection-sort.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/selection-sort.cs)*

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
        a[i + 1] = a[i]
        i -= 1
    a[i + 1] = key
```

<ins>***File:***</ins> *[insertion-sort.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/insertion-sort.py)*

`JavaScript`:

```js
for(let j = 1; j < a.length; j ++){
    key = a[j];
    i = j - 1;
    while(i >= 0 && a[i] > key){
        a[i + 1] = a[i];
        i --;
    } 
    a[i + 1] = key;
}
```

<ins>***File:***</ins> *[insertion-sort.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/insertion-sort.js)*

`Go`:

```go
for j := 1; j < len(a); j++ {
    key := a[j]
    i := j - 1
    for i >= 0 && a[i] > key {
        a[i+1] = a[i]
        i--
    }
    a[i+1] = key
}
```

<ins>***File:***</ins> *[insertion-sort.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/insertion-sort.go)*

`C++`:

```cpp
for(int j = 1; j < len; j ++){
    int key = a[j];
    int i = j - 1;
    while (i >= 0 && a[i] > key){
        a[i + 1] = a[i];
        i --;
    }
    a[i + 1] = key;
}
```

<ins>***File:***</ins> *[insertion-sort.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/insertion-sort.cpp)*

`C#`:

```cs
for(int j = 0; j < a.Length; j ++)
{
    int key = a[j];
    int i = j - 1;
    while (i >= 0 && a[i] > key)
    {
        a[i + 1] = a[i];
        i --;
    }
    a[i + 1] = key;
}
```

<ins>***File:***</ins> *[insertion-sort.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/insertion-sort.cs)*

### Quick sort / Швидке сортування / Быстрая сортировка

**Time complexity / Часова складність / Временная сложность :** *O(n log n)*.

**Pluses / Плюси / Плюсы :** *Fast and not long / Швидка та не довга / Быстрая и не длинная*

**Minuses / Мінуси / Минусы :** *Unfixed time comlexity (the worst case is O(n<sup>2</sup>)) / Нефіксована часова скалдність (найгірший випадок O(n<sup>2</sup>)) / Нефиксированая временная сложность (наихудший случай O(n<sup>2</sup>))*

<ins>***Wikipedia:***</ins> *[Quick_Sort](https://en.wikipedia.org/wiki/Quicksort)*

<ins>***Вікіпедія:***</ins> *[Швидке сортування](https://uk.wikipedia.org/wiki/Швидке_сортування)*

<ins>***Википедия:***</ins> *[Быстрая сортировка](https://ru.wikipedia.org/wiki/Быстрая_сортировка)*

`Python`:

```python
def sort(array, b, e):
    l = b
    r = e
    p = array[int((l + r) / 2)]
    while l <= r:
        while array[l] < p:
            l += 1
        while array[r] > p:
            r -= 1
        if l <= r:
            if l < r:
                array[l], array[r] = array[r], array[l]
            l += 1
            r -= 1
    if b < r:
        sort(array, b, r)
    if e > l:
        sort(array, l, e)

sort(a, 0, len(a) - 1)
```

<ins>***File:***</ins> *[quick-sort.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/quick-sort.py)*

`JavaScript`:

```js
function sort(array, m){
    let mass = [];
    for(let i = 0; i < m; i ++){
        mass.push(array[i]);
    }
    if(m <= 1){
        array[0] = mass[0];
    }
    else{
        let l = [];
        let r = [];
        for(let i = 0; i < m; i ++){
            if(i < Math.floor(m / 2)){
                l.push(mass[i]);
            }
            else{
                r.push(mass[i]);
            }
        }
        sort(l, l.length);
        sort(r, r.length);
        let h = 0;
        let f = 0;
        let c = [];
        while(h < l.length && f < r.length){
            if(l[h] < r[f]){
                c.push(l[h]);
                h += 1;
            }
            else{
                c.push(r[f]);
                f += 1;
            }
        }
        while(h < l.length){
            c.push(l[h]);
            h += 1;
        }
        while(f < r.length){
            c.push(r[f]);
            f += 1;
        }
        for(let i = 0; i < m; i++){
            array[i] = c[i];
        }
    }
}

sort(a, 0, a.length - 1);
```

<ins>***File:***</ins> *[quick-sort.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/quick-sort.js)*

`Go`:

```go
func Sort(array []int, b int, e int) {
    l := b
    r := e
    p := array[int((l+r)/2)]
    for l <= r {
        for array[l] < p {
            l++
        }
        for array[r] > p {
            r--
        }
        if l <= r {
            if l < r {
                array[l], array[r] = array[r], array[l]
            }
        }
        l++
        r--
    }
    if b < r {
        Sort(array, b, r)
    }
    if e > l {
        Sort(array, l, e)
    }
}

Sort(a, 0, len(a)-1)
```

<ins>***File:***</ins> *[quick-sort.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/quick-sort.go)*

`C++`:

```cpp
void sort(int *array, int b, int e){
    int l = b;
    int r = e;
    int p = array[(l + r) / 2];
    while(l <= r){
        while(array[l] < p){
            l ++;
        }
        while(array[r] > p){
            r --;
        }
        if(l <= r){
            if(l < r){
                array[l] = array[l] + array[r];
                array[r] = array[l] - array[r];
                array[l] = array[l] - array[r];
            }
            l ++;
            r --;
        }
    }
    if(b < r){
        sort(array, b, r);
    }
    if(e > l){
        sort(array, l, e);
    }
}

sort(a, 0, len - 1);
```

<ins>***File:***</ins> *[quick-sort.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/quick-sort.cpp)*

`C#`:

```cs
void Sort(ref int[] array, int b, int e)
{
    int l = b;
    int r = e;
    int p = array[(l + r) / 2];
    while(l <= r)
    {
        while(array[l] < p)
        {
            l ++;
        }
        while(array[r] > p)
        {
            r --;
        }
        if(l <= r)
        {
            if(l < r)
            {
                array[l] = array[l] + array[r];
                array[r] = array[l] - array[r];
                array[l] = array[l] - array[r];
            }
            l ++;
            r --;
        }
    }
    if(b < r)
    {
        Sort(ref array, b, r);
    }
    if(e > l)
    {
        Sort(ref array, l, e);
    }
}

Sort(ref a, 0, a.Length - 1);
```

<ins>***File:***</ins> *[quick-sort.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/quick-sort.cs)*

### Merge sort / Сортування злиттям / Сортировка слиянием

**Time complexity / Часова складність / Временная сложность :** *O(n log n)*.

**Pluses / Плюси / Плюсы :** *Fast and stable / Швидка та стабільна / Быстрая и стабильная*

**Minuses / Мінуси / Минусы :** *Difficult in coding and needs additional memory / Важка в програмуванні та потрибує додаткової пам'яті / Сложная в прогаммировании и требует дополнительной памяти*

<ins>***Wikipedia:***</ins> *[Merge sort](https://en.wikipedia.org/wiki/Merge_sort)*

<ins>***Вікіпедія:***</ins> *[Сортування злиттям](https://uk.wikipedia.org/wiki/Сортування_злиттям)*

<ins>***Википедия:***</ins> *[Сортировка слиянием](https://ru.wikipedia.org/wiki/Сортировка_слиянием)*

`Python`:

```python
def sort(array, m):
    mass = []
    for i in range(0, m):
        mass.append(array[i])
    if m <= 1:
        array[0] = mass[0]
    else:
        l = []
        r = []
        for i in range(0, m):
            if i < int(m / 2):
                l.append(mass[i])
            else:
                r.append(mass[i])
        sort(l, len(l))
        sort(r, len(r))
        h = 0
        f = 0
        c = []
        while h < len(l) and f < len(r):
            if l[h] < r[f]:
                c.append(l[h])
                h += 1
            else:
                c.append(r[f])
                f += 1
        while h < len(l):
            c.append(l[h])
            h += 1
        while f < len(r):
            c.append(r[f])
            f += 1
        for i in range(0, m):
            array[i] = c[i]

sort(a, len(a))
```

<ins>***File:***</ins> *[merge-sort.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/merge-sort.py)*

`JavaScript`:

```js
function sort(array, m){
    let mass = [];
    for(let i = 0; i < m; i ++){
        mass.push(array[i]);
    }
    if(m <= 1){
        array[0] = mass[0];
    }
    else{
        let l = [];
        let r = [];
        for(let i = 0; i < m; i ++){
            if(i < Math.floor(m/2)){
                l.push(mass[i]);
            }
            else{
                r.push(mass[i]);
            }
        }
        sort(l, l.length);
        sort(r, r.length);
        let h = 0;
        let f = 0;
        let c = [];
        while(h < l.length && f < r.length){
            if(l[h] < r[f]){
                c.push(l[h]);
                h += 1;
            }
            else{
                c.push(r[f]);
                f += 1;
            }
        }
        while(h < l.length){
            c.push(l[h]);
            h += 1;
        }
        while(f < r.length){
            c.push(r[f]);
            f += 1;
        }
        for(let i = 0; i < m; i++){
            array[i] = c[i];
        }
    }
}

sort(a, a.length);
```

<ins>***File:***</ins> *[merge-sort.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/merge-sort.js)*

`Go`:

```go
func Sort(array []int, m int) {
    mass := []int{}
    for i := 0; i < m; i++ {
        mass = append(mass, array[i])
    }
    if m <= 1 {
        array[0] = mass[0]
    } else {
        var l []int
        var r []int
        for i := 0; i < m; i++ {
            if i < m/2 {
                l = append(l, mass[i])
            } else {
                r = append(r, mass[i])
            }
        }
        Sort(l, m/2)
        Sort(r, m-(m/2))
        h := 0
        f := 0
        var c []int
        for h < m/2 && f < m-(m/2) {
            if l[h] < r[f] {
                c = append(c, l[h])
                h++
            } else {
                c = append(c, r[f])
                f++
            }
        }
        for h < m/2 {
            c = append(c, l[h])
            h++
        }
        for f < m-(m/2) {
            c = append(c, r[f])
            f++
        }
        for i := 0; i < m; i++ {
            array[i] = c[i]
        }
    }
}

Sort(a, len(a))
```

<ins>***File:***</ins> *[merge-sort.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/merge-sort.go)*

`C++`:

```cpp
void sort(int *array, int m){
    int mass[m];
    for(int i = 0; i < m; i ++){
        mass[i] = array[i];
    }
    if(m <= 1){
        array[0] = mass[0];
    }
    else{
        int L[m / 2], R[m - (m / 2)];
        for(int i = 0; i < m; i ++){
            if(i < m / 2) L[i] = mass[i];
            else R[i - (m / 2)] = mass[i];
        }
        sort(L, m / 2);
        sort(R, m - (m / 2));
        int h = 0, f = 0, k = 0;
        int C[m];
        while(h < m / 2 && f < m - (m / 2)){
            if(L[h] < R[f]){
                C[k] = L[h];
                h ++;
            }
            else{
                C[k] = R[f];
                f ++;
            }
            k ++;
        }
        while(h < m / 2){
            C[k] = L[h];
            h ++;
            k ++;
        }
        while(f < m - (m / 2)){
            C[k] = R[f];
            f ++;
            k ++;
        }
        for(int i = 0; i < m; i ++){
            array[i] = C[i];
        }
    }
}

sort(a, len);
```

<ins>***File:***</ins> *[merge-sort.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/merge-sort.cpp)*

`C#`:

```cs
void Sort(ref int[] array, int m)
{
    int[] mass = new int[m];
    for(int i = 0; i < m; i ++)
    {
        mass[i] = array[i];
    }
    if(m <= 1)
    {
        array[0] = mass[0];
    }
    else
    {
        int[] L = new int[m / 2];
        int[] R = new int[m - (m / 2)];
        for(int i = 0; i < m; i ++)
        {
            if(i < m / 2) L[i] = mass[i];
            else R[i - (m / 2)] = mass[i];
        }
        Sort(ref L, m / 2);
        Sort(ref R, m - (m / 2));
        int h = 0, f = 0, k = 0;
        int[] C = new int[m];
        while(h < m / 2 && f < m - (m / 2))
        {
            if(L[h] < R[f]){
                C[k] = L[h];
                h ++;
            }
            else{
                C[k] = R[f];
                f ++;
            }
            k ++;
        }
        while(h < m / 2)
        {
            C[k] = L[h];
            h ++;
            k ++;
        }
        while(f < m - (m / 2))
        {
            C[k] = R[f];
            f ++;
            k ++;
        }
        for(int i = 0; i < m; i ++)
        {
            array[i] = C[i];
        }
    }
}

Sort(ref a, a.Length);
```

<ins>***File:***</ins> *[merge-sort.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/merge-sort.cs)*

### Heap sort / Пірамідальне сортування / Пирамидальная сортировка

**Time complexity / Часова складність / Временная сложность :** *O(n log n)*.

**Pluses / Плюси / Плюсы :** *Fast, stable and don't need additional memory / Швидка, стабільна та не потребує додаткової пам'яті / Быстрая, стабильная и не требует дополнительной памяти*

**Minuses / Мінуси / Минусы :** *Difficult in coding / Важка в програмуванні / Сложная в прогаммировании*

<ins>***Wikipedia:***</ins> *[Heap sort](https://en.wikipedia.org/wiki/Heapsort)*

<ins>***Вікіпедія:***</ins> *[Пірамідальне сортування](https://uk.wikipedia.org/wiki/Пірамідальне_сортування)*

<ins>***Википедия:***</ins> *[Пирамидальная сортировка](https://ru.wikipedia.org/wiki/Пирамидальная_сортировка)*

`Python`:

```python
def heapify(array, n, i):
    largest = i
    l = 2 * i + 1
    r = 2 * i + 2
    if l < n and array[i] < array[l]:
        largest = l
    if r < n and array[largest] < array[r]:
        largest = r
    if largest != i:
        array[i], array[largest] = array[largest], array[i]
        heapify(array, n, largest)

def sort(array):
    for i in range(len(array) // 2, -1, -1):
        heapify(array, len(array), i)
    for j in range(len(array) - 1, 0, -1):
        array[j], array[0] = array[0], array[j]
        heapify(array, j, 0)

sort(a)
```

<ins>***File:***</ins> *[heap-sort.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/heap-sort.py)*

`JavaScript`:

```js
function heapify(array, n, i){
    let largest = i;
    let l = 2 * i + 1;
    let r = 2 * i + 2;
    if(l < n && array[i] < array[l]){
        largest = l;
    }
    if(r < n && array[largest] < array[r]){
        largest = r;
    }
    if(largest != i){
        array[i] = array[i] + array[largest];
        array[largest] = array[i] - array[largest];
        array[i] = array[i] - array[largest];
        heapify(array, n, largest);
    }
}

function sort(array){
    for(let i = Math.floor(array.length / 2); i > -1; i --){
        heapify(array, array.length, i);
    }
    for(let j = array.length - 1; j > 0; j --){
        array[j] = array[j] + array[0];
        array[0] = array[j] - array[0];
        array[j] = array[j] - array[0];
        heapify(array, j, 0);
    }
}

sort(a);
```

<ins>***File:***</ins> *[heap-sort.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/heap-sort.js)*

`Go`:

```go
func Heapify(array []int, n int, i int) {
    largest := i
    l := 2*i + 1
    r := 2*i + 2
    if l < n && array[i] < array[l] {
        largest = l
    }
    if r < n && array[largest] < array[r] {
        largest = r
    }
    if largest != i {
        array[i], array[largest] = array[largest], array[i]
        Heapify(array, n, largest)
    }
}

func Sort(array []int) {
    for i := int(math.Floor(float64(len(array) / 2))); i > -1; i-- {
        Heapify(array, len(array), i)
    }
    for j := len(array) - 1; j > 0; j-- {
        array[j], array[0] = array[0], array[j]
        Heapify(array, j, 0)
    }
}

Sort(a)
```

<ins>***File:***</ins> *[heap-sort.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/heap-sort.go)*

`C++`:

```cpp
void heapify(int *array, int n, int i){
    int largest = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;
    if(l < n && array[i] < array[l]){
        largest = l;
    }
    if(r < n && array[largest] < array[r]){
        largest = r;
    }
    if(largest != i){
        array[i] = array[i] + array[largest];
        array[largest] = array[i] - array[largest];
        array[i] = array[i] - array[largest];
        heapify(array, n, largest);
    }
}

void sort(int *array, int len){
    for(int i = len / 2; i > -1; i --){
        heapify(array, len, i);
    }
    for(int j = len - 1; j > 0; j --){
        array[j] = array[j] + array[0];
        array[0] = array[j] - array[0];
        array[j] = array[j] - array[0];
        heapify(array, j, 0);
    }
}

sort(a, len);
```

<ins>***File:***</ins> *[heap-sort.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/heap-sort.cpp)*

`C#`:

```cs
void Heapify(ref int[] array, int n, int i)
{
    int largest = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;
    if(l < n && array[i] < array[l])
    {
        largest = l;
    }
    if(r < n && array[largest] < array[r])
    {
        largest = r;
    }
    if(largest != i)
    {
        array[i] = array[i] + array[largest];
        array[largest] = array[i] - array[largest];
        array[i] = array[i] - array[largest];
        Heapify(ref array, n, largest);
    }
}

void Sort(ref int[] array)
{
    for(int i = array.Length / 2; i > -1; i --)
    {
        Heapify(ref array, array.Length, i);
    }
    for(int j = array.Length - 1; j > 0; j --)
    {
        array[j] = array[j] + array[0];
        array[0] = array[j] - array[0];
        array[j] = array[j] - array[0];
        Heapify(ref array, j, 0);
    }
}

Sort(ref a);
```

<ins>***File:***</ins> *[heap-sort.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Sort/heap-sort.cs)*

## GCD | LCM / НСД | НСК / НОД | НОК

### Packages / Пакети / Пакеты

`Python`:

```python
main.gcd(a, b)
main.lcm(a, b)
```

`JavaScript`:

```js
main.gcd(a, b);
main.lcm(a, b);
```

### GCD / НСД / НОД

<ins>***Wikipedia:***</ins> *[GCD](https://en.wikipedia.org/wiki/Greatest_common_divisor)*

<ins>***Вікіпедія:***</ins> *[НСД](https://uk.wikipedia.org/wiki/Найбільший_спільний_дільник)*

<ins>***Википедия:***</ins> *[НОД](https://ru.wikipedia.org/wiki/Наибольший_общий_делитель)*

`Python`:

```python
def gcd(a, b):
    while a != 0 and b != 0:
        if a > b:
            a = a % b
        else:
            b = b % a
    return a + b
```

`JavaScript`:

```js
function gcd(a, b){
    while(a != 0 && b != 0){
        if(a > b){
            a = a % b;
        }
        else{
            b = b % a;
        }
    }
    return a + b;
}
```

`Go`:

```go
func GCD(a int, b int) int {
    for a != 0 && b != 0 {
        if a > b {
            a = a % b
        } else {
            b = b % a
        }
    }
    return a + b
}
```

`C++`:

```cpp
int gcd(int a, int b){
    while(a != 0 && b != 0){
        if(a > b){
            a = a % b;
        }
        else{
            b = b % a;
        }
    }
    return a + b;
}
```

`C#`:

```cs
int GCD(int a, int b)
{
    while(a != 0 && b != 0)
    {
        if(a > b)
        {
            a = a % b;
        }
        else
        {
            b = b % a;
        }
    }
    return a + b;
}
```


### LCM / НСК / НОК

<ins>***Wikipedia:***</ins> *[LCM](https://en.wikipedia.org/wiki/Least_common_multiple)*

<ins>***Вікіпедія:***</ins> *[НСК](https://uk.wikipedia.org/wiki/Найменше_спільне_кратне)*

<ins>***Википедия:***</ins> *[НОК](https://ru.wikipedia.org/wiki/Наименьшее_общее_кратное)*

`Python`:

```python
def gcd(a, b):
    while a != 0 and b != 0:
        if a > b:
            a = a % b
        else:
            b = b % a
    return a + b
    
def lcm(a, b):
    return int((a * b) / gcd(a, b))
```

`JavaScript`:

```js
function gcd(a, b){
    while(a != 0 && b != 0){
        if(a > b){
            a = a % b;
        }
        else{
            b = b % a;
        }
    }
    return a + b;
}

function lcm(a, b){
    return Math.floor((a * b) / gcd(a, b));
}
```

`Go`:

```go
func GCD(a int, b int) int {
    for a != 0 && b != 0 {
        if a > b {
            a = a % b
        } else {
            b = b % a
        }
    }
    return a + b
}

func LCM(a int, b int) int {
    return int((a * b) / GCD(a, b))
}
```

`C++`:

```cpp
int gcd(int a, int b){
    while(a != 0 && b != 0){
        if(a > b){
            a = a % b;
        }
        else{
            b = b % a;
        }
    }
    return a + b;
}

int lcm(int a, int b){
    return (a * b) / gcd(a, b);
}
```

`C#`:

```cs
int GCD(int a, int b)
{
    while(a != 0 && b != 0)
    {
        if(a > b)
        {
            a = a % b;
        }
        else
        {
            b = b % a;
        }
    }
    return a + b;
}

int LCM(int a, int b)
{
    return (a * b) / GCD(a, b);
}
```

## Primes / Прості числа / Простые числа

### Packages / Пакети / Пакеты

`Python`:

```python
main.iprime(n)
main.n_primes(n)
main.prime_factors(n)
```

`JavaScript`:

```js
main.iprime(n);
main.nPrimes(n);
main.primeFactors(n);
```

### Is prime? / Чи просте число? / Простое ли число?

`Python`:

```python
def isprime(n):
    result = []
    d = 2
    while d * d <= n:
        if n % d == 0:
            result.append(d)
            n //= d
        else:
            d += 1
    if n > 1:
        result.append(n)
    if len(result) > 1: return False
    else: return True
```

`JavaScript`:

```js
function isPrime(n){
    let result = [];
    let d = 2;
    while(d * d <= n){
        if(n % d == 0){
            result.push(d);
            n = Math.floor(n / d);
        }
        else{
            d ++;
        }
    }
    if(n > 1){
        result.push(n);
    }
    if(result.length > 1) return false;
    else return true;
}
```

`Go`:

```go
func IsPrime(n int) bool {
    result := []int{}
    d := 2
    for d*d <= n {
        if n%d == 0 {
            result = append(result, d)
            n = int(n / d)
        } else {
            d++
        }
    }
    if n > 1 {
        result = append(result, n)
    }
    if len(result) > 1 {
        return false
    } else {
        return true
    }
}
```

`C++`:

```cpp
bool isprime(int n){
    std::vector<int> result;
    int d = 2;
    while(d * d <= n){
        if(n % d == 0){
            result.push_back(d);
            n = n / d;
        }
        else{
            d ++;
        }
    }
    if(n > 1){
        result.push_back(n);
    }
    if(result.size() > 1) return false;
    else return true;
}
```

`C#`:

```cs
bool IsPrime(int n)
{
    List<int> result = new List<int>(){};
    int d = 2;
    while(d * d <= n)
    {
        if(n % d == 0)
        {
            result.Add(d);
            n = n / d;
        }
        else
        {
            d ++;
        }
    }
    if(n > 1)
    {
        result.Add(n);
    }
    if(result.Count() > 1) return false;
    else return true;
}
```

### Finding n prime numbers / Пошук n простих чисел / Поиск n простых чисел

`Python`:

```python
def n_primes(n):
    result = []
    i = 0
    m = 1
    while i < n:
        m += 1
        k = True
        for j in result:
            if m % j == 0:
                k = False
                break
        if k:
            result.append(m)
            i += 1
    return result
```

`JavaScript`:

```js
function nPrimes(n){
    let result = [];
    let i = 0;
    let m = 1;
    let k;
    while(i < n){
        m ++;
        k = true;
        for(j of result){
            if(m % j == 0){
                k = false;
                break;
            }
        }
        if(k){
            result.push(m);
            i ++;
        }
    }
    return result;
}
```

`Go`:

```go
func NPrimes(n int) []int {
    result := []int{}
    i := 0
    m := 1
    var k bool
    for i <= n {
        m++
        k = true
        for _, j := range result {
            if m%j == 0 {
                k = false
                break
            }
        }
        if k {
            result = append(result, m)
            i++
        }
    }
    return result
}
```

`C++`:

```cpp
std::vector <int> n_primes(a){
    std::vector <int> result;
    int i = 0;
    int m = 1;
    bool k;
    while(i < n){
        m ++;
        k = true;
        for(auto j: result){
            if(m % j == 0){
                k = false;
                break;
            }
        }
        if(k){
            result.push_back(m);
            i ++;
        }
    }
    return result;
}
```

`C#`:

```cs
List<int> NPrimes(int n)
{
    List<int> result = new List<int>(){};
    int i = 0;
    int m = 1;
    bool k;
    while(i < n)
    {
        m ++;
        k = true;
        foreach(int j in result)
        {
            if(m % j == 0){
                k = false;
                break;
            }
        }
        if(k)
        {
            result.Add(m);
            i ++;
        }
    }
    return result;
}
```

### Finding prime factors of a number / Пошук простих множників числа / Поиск простых множителей числа

`Python`:

```python
def prime_factors(a):
    result = []
    d = 2
    while d * d <= a:
        if a % d == 0:
            result.append(d)
            a //= d
        else:
            d += 1
    if a > 1:
        result.append(a)
    return result
```

`JavaScript`:

```js
function primeFactors(a){
    let result = [];
    let d = 2;
    while(d * d <= a){
        if(a % d == 0){
            result.push(d);
            a = Math.floor(a / d);
        }
        else{
            d ++;
        }
    }
    if(a > 1){
        result.push(a);
    }
    return result;
}
```

`Go`:

```go
func PrimeFactors(a int) []int {
    result := []int{}
    d := 2
    for d*d <= a {
        if a%d == 0 {
            result = append(result, d)
            a = int(a / d)
        } else {
            d++
        }
    }
    if a > 1 {
        result = append(result, a)
    }
    return result
}
```

`C++`:

```cpp
std::vector <int> prime_factors(a){
    std::vector <int> result;
    int d = 2;
    while(d * d <= a){
        if(a % d == 0){
            result.push_back(d);
            a = a / d;
        }
        else{
            d ++;
        }
    }
    if(a > 1){
        result.push_back(a);
    }
    return result;
}
```

`C#`:

```cs
List<int> PrimeFactors(int a)
{
    List<int> result = new List<int>(){};
    int d = 2;
    while(d * d <= a)
    {
        if(a % d == 0)
        {
            result.Add(d);
            a = a / d;
        }
        else
        {
            d ++;
        }
    }
    if(a > 1)
    {
        result.Add(a);
    }
    return result;
}
```

## Fibonacci number / Послідовність Фібоначчі / Числа Фибоначчи

### Packages / Пакети / Пакеты

`Python`:

```python
main.fibo(n)
```

`JavaScript`:

```js
main.fibo(n);
```

<ins>***Wikipedia:***</ins> *[Fibonacci number](https://en.wikipedia.org/wiki/Fibonacci_number)*

<ins>***Вікіпедія:***</ins> *[Послідовність Фібоначчі](https://uk.wikipedia.org/wiki/Послідовність_Фібоначчі)*

<ins>***Википедия:***</ins> *[Числа Фибоначчи](https://ru.wikipedia.org/wiki/Числа_Фибоначчи)*

`Python`:

```python
def fibo(n):
    if n <= 1:
        return n
    else:
        return fibo(n - 1) + fibo(n - 2)
```

`JavaScript`:

```js
function fibo(n){
    if(n <= 1){
        return n;
    }
    else{
        return fibo(n - 1) + fibo(n - 2);
    }
}
```

`Go`:

```go
func Fibo(n int) int {
    if n <= 1 {
        return n
    } else {
        return Fibo(n-1) + Fibo(n-2)
    }
}
```

`C++`:

```cpp
int fibo(int n){
    if(n <= 1){
        return n;
    }
    else{
        return fibo(n - 1) + fibo(n - 2);
    }
}
```

`C#`:

```cs
int Fibo(int n)
{
    if(n <= 1)
    {
        return n;
    }
    else
    {
        return Fibo(n - 1) + Fibo(n - 2);
    }
}
```

## Factorials / Факторіали / Факториалы

### Packages / Пакети / Пакеты

`Python`:

```python
factorials.factorial(n)
factorials.double_factorial(n)
factorials.subfactorial(n)
factorials.primorial(n)
factorials.p_primorial(n)
factorials.superfactorial(n)
factorials.superduperfactorial(n)
```

`JavaScript`:

```js
factorials.factorial(n);
factorials.doubleFactorial(n);
factorials.subfactorial(n);
factorials.primorial(n);
factorials.pPrimorial(n);
factorials.superfactorial(n);
factorials.superduperfactorial(n);
```

### Counting factorial / Підрахунок факторіалу / Вычисление факториала

<ins>***Wikipedia:***</ins> *[Factorial](https://en.wikipedia.org/wiki/Factorial)*

<ins>***Вікіпедія:***</ins> *[Факторіал](https://uk.wikipedia.org/wiki/Факторіал)*

<ins>***Википедия:***</ins> *[Факториал](https://ru.wikipedia.org/wiki/Факториал)*

`Python`:

```python
def factorial(n):
    result = 1
    for m in range(1, n + 1):
        result *= m;
    return result
```

`Or`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n - 1)
```

`JavaScript`:

```js
function factorial(n){
    let result = 1;
    for(let m = 1; m <= n; m ++){
        result *= m;
    }
    return result;
}
```

`Or`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}
```

`Go`:

```go
func Factorial(n int) int {
    result := 1
    for m := 1; m <= n; m++ {
        result *= m
    }
    return result
}
```

`Or`:

```go
func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}
```

`C++`:

```cpp
int factorial(int n){
    int result = 1;
    for(int m = 1; m <= n; m ++){
        result *= m;
    }
    return result;
}
```

`Or`:

```cpp
int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}
```

`C#`:

```cs
int Factorial(int n)
{
    int result = 1;
    for(int m = 1; m <= n; m ++)
    {
        result *= m;
    }
    return result;
}
```

`Or`:

```cs
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}
```

### Counting double factorial / Підрахунок подвійного факторіалу / Вычисление двойного факториала

`Python`:

```python
def double_factorial(n):
    if n <= 0: return 1
    else: return n * double_factorial(n - 2)
```

`JavaScript`:

```js
function doubleFactorial(n){
    if(n <= 0) return 1;
    else return n * doubleFactorial(n - 2);
}
```

`Go`:

```go
func DoubleFactorial(n int) int {
    if n <= 0 {
        return 1
    } else {
        return n * DoubleFactorial(n-2)
    }
}
```

`C++`:

```cpp
int double_factorial(int n){
    if(n <= 0) return 1;
    else return n * double_factorial(n - 2);
}
```

`C#`:

```cs
int DoubleFactorial(int n)
{
    if(n <= 0) return 1;
    else return n * DoubleFactorial(n - 2);
}
```

### Counting subfactorial / Підрахунок субфакторіалу / Вычисление субфакториала

<ins>***Wikipedia:***</ins> *[Subfactorial](https://en.wiktionary.org/wiki/subfactorial)*

<ins>***Вікіпедія:***</ins> *[Субфакторіал](https://uk.wikipedia.org/wiki/Субфакторіал)*

<ins>***Википедия:***</ins> *[Субфакториал](https://ru.wikipedia.org/wiki/Субфакториал)*

`Python`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n - 1)

def subfactorial(n):
    result = 1
    k = True
    for m in range(1, n + 1):
        if k:
            result -= 1 / factorial(m)
            k = False
        else:
            result += 1 / factorial(m)
            k = True
    return round(result * factorial(n))
```

`Or`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n-1)

def subfactorial(n):
    return round(factorial(n) / 2.718)
```

`JavaScript`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

function subfactorial(n){
    let result = 1;
    let k = true;
    for(let m = 1; m <= n; m ++){
        if(k){
            result -= 1 / factorial(m);
            k = false;
        }
        else{
            result += 1 / factorial(m);
            k = true;
        }
    }
    return Math.round(result * factorial(n));
}
```

`Or`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

function subfactorial(n){
    return Math.round(factorial(n) / 2.718);
}
```

`Go`:

```go
import "math"

func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}

func Subfactorial(n int) int {
    result := 1.0
    k := true
    for m := 1; m <= n; m++ {
        if k {
            result -= 1.0 / float64(Factorial(m))
            k = false
        } else {
            result += 1.0 / float64(Factorial(m))
            k = true
        }
    }
    return int(math.Round(result * float64(Factorial(n))))
}
```

`Or`:

```go
import "math"

func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}

func Subfactorial(n int) int {
    return int(math.Round(float64(Factorial(n)) / 2.718))
}
```

`C++`:

```cpp
int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int subfactorial(int n){
    double result = 1;
    bool k = true;
    for(int m = 1; m <= n; m ++){
        if(k){
            result -= 1.0 / factorial(m);
            k = false;
        }
        else{
            result += 1.0 / factorial(m);
            k = true;
        }
    }
    return result * factorial(n);
}
```

`Or`:

```cpp
#include <math.h>

int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int subfactorial(int n){
    return round(factorial(n) / 2.718);
}
```

`C#`:

```cs
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}

int SubFactorial(int n)
{
    double result = 1;
    bool k = true;
    for(int m = 1; m <= n; m ++)
    {
        if(k)
        {
            result -= 1.0 / Factorial(m);
            k = false;
        }
        else
        {
            result += 1.0 / Factorial(m);
            k = true;
        }
    }
    return result * Factorial(n);
}
```

`Or`:

```cs
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}

int SubFactorial(int n)
{
    return Math.Round(Factorial(n) / 2.718);
}
```

### Counting primorial / Підрахунок пріморіалу / Вычисление примориала

<ins>***Wikipedia:***</ins> *[Primorial](https://en.wikipedia.org/wiki/Primorial)*

<ins>***Вікіпедія:***</ins> *[Прайморіал](https://uk.wikipedia.org/wiki/Прайморіал)*

<ins>***Википедия:***</ins> *[Праймориал](https://ru.wikipedia.org/wiki/Праймориал)*

`Python`:

```python
def isprime(n):
    result = []
    d = 2
    while d * d <= n:
        if n % d == 0:
            result.append(d)
            n //= d
        else:
            d += 1
    if n > 1:
        result.append(n)
    if len(result) > 1: return False
    else: return True

def p(n):
    result = []
    i = 0
    m = 1
    while i < n:
        m += 1
        k = True
        for j in result:
            if m % j == 0:
                k = False
                break
        if k:
            result.append(m)
            i += 1
    return result[-1]

#primorial less than n
#пріморіал меньше n
#примориал меньше n
def primorial(n):
    if n == 1: return 1
    elif isprime(n): return n * primorial(n - 1)
    else: return primorial(n - 1)

#primorial for first n primes
#пріморіал для перших n простих
#примориал первых n простых
def p_primorial(n):
    return primorial(p(n))
```

`JavaScript`:

```js
function isprime(n){
    let result = [];
    let d = 2;
    while(d * d <= n){
        if(n % d == 0){
            result.push(d);
            n = Math.floor(n / d);
        }
        else{
            d ++;
        }
    }
    if(n > 1){
        result.push(n);
    }
    if(result.length > 1) return false;
    else return true;
}

function p(n){
    let result = [];
    let i = 0;
    let m = 1;
    let k;
    while(i < n){
        m ++;
        k = true;
        for(j of result){
            if(m % j == 0){
                k = false;
                break;
            }
        }
        if(k){
            result.push(m);
            i ++;
        }
    }
    return result[result.length - 1];
}

//primorial less than n
//пріморіал меньше n
//примориал меньше n
function primorial(n){
    if(n == 1) return 1;
    else if(isprime(n)) return n * primorial(n - 1);
    else return primorial(n - 1);
}

//primorial for first n primes
//пріморіал для перших n простих
//примориал первых n простых
function pPrimorial(n){
    return primorial(p(n));
}
```

`Go`:

```go
func IsPrime(n int) bool {
    result := []int{}
    d := 2
    for d*d <= n {
        if n%d == 0 {
            result = append(result, d)
            n = int(n / d)
        } else {
            d++
        }
    }
    if n > 1 {
        result = append(result, n)
    }
    if len(result) > 1 {
        return false
    } else {
        return true
    }
}

func P(n int) int {
    result := []int{}
    i := 0
    m := 1
    var k bool
    for i < n {
        m++
        k = true
        for _, j := range result {
            if m%j == 0 {
                k = false
                break
            }
        }
        if k {
            result = append(result, m)
            i++
        }
    }
    return result[len(result)-1]
}

//primorial less than n
//пріморіал меньше n
//примориал меньше n
func Primorial(n int) int {
    if n == 1 {
        return 1
    } else if IsPrime(n) {
        return n * Primorial(n-1)
    } else {
        return Primorial(n - 1)
    }
}

//primorial for first n primes
//пріморіал для перших n простих
//примориал первых n простых
func PPrimorial(n int) int {
    return Primorial(P(n))
}
```

`C++`:

```cpp
bool isprime(int n){
    std::vector <int> result;
    int d = 2;
    while(d * d <= n){
        if(n % d == 0){
            result.push_back(d);
            n = n / d;
        }
        else{
            d ++;
        }
    }
    if(n > 1){
        result.push_back(n);
    }
    if(result.size() > 1) return false;
    else return true;
}

int p(int n){
    std::vector <int> result;
    int i = 0;
    int m = 1;
    bool k;
    while(i < n){
        m ++;
        k = true;
        for(auto j: result){
            if(m % j == 0){
                k = false;
                break;
            }
        }
        if(k){
            result.push_back(m);
            i ++;
        }
    }
    return result[result.size() - 1];
}

//primorial less than n
//пріморіал меньше n
//примориал меньше n
int primorial(int n){
    if(n == 1) return 1;
    else if(isprime(n)) return n * primorial(n - 1);
    else return primorial(n - 1);
}

//primorial for first n primes
//пріморіал для перших n простих
//примориал первых n простых
int p_primorial(int n){
    return primorial(p(n));
}
```

`C#`:

```cs
bool IsPrime(int n)
{
    List<int> result = new List<int>(){};
    int d = 2;
    while(d * d <= n)
    {
        if(n % d == 0)
        {
            result.Add(d);
            n = n / d;
        }
        else
        {
            d ++;
        }
    }
    if(n > 1)
    {
        result.Add(n);
    }
    if(result.Count() > 1) return false;
    else return true;
}

int P(int n)
{
    List<int> result = new List<int>(){};
    int i = 0;
    int m = 1;
    bool k;
    while(i < n)
    {
        m ++;
        k = true;
        for(auto j: result)
        {
            if(m % j == 0)
            {
                k = false;
                break;
            }
        }
        if(k)
        {
            result.Add(m);
            i ++;
        }
    }
    return result[^1];
}

//primorial less than n
//пріморіал меньше n
//примориал меньше n
int Primorial(int n)
{
    if(n == 1) return 1;
    else if(IsPrime(n)) return n * Primorial(n - 1);
    else return Primorial(n - 1);
}

//primorial for first n primes
//пріморіал для перших n простих
//примориал первых n простых
int PPrimorial(int n)
{
    return Primorial(P(n));
}
```

### Counting superfactorial / Підрахунок суперфакторіалу / Вычисление суперфакториала

`Python`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n - 1)

def superfactorial(n):
    if n == 0: return 1
    else: return factorial(n) * superfactorial(n - 1)
```

`JavaScript`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

function superfactorial(n){
    if(n == 0) return 1;
    else return factorial(n) * superfactorial(n - 1);
}
```

`Go`:

```go
func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}

func SuperFactorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return Factorial(n) * SuperFactorial(n-1)
    }
}
```

`C++`:

```cpp
int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int superfactorial(int n){
    if(n == 0) return 1;
    else return factorial(n) * superfactorial(n - 1);
}
```

`C#`:

```cs
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}

int SuperFactorial(int n)
{
    if(n == 0) return 1;
    else return Factorial(n) * SuperFactorial(n - 1);
}
```

### Counting superduperfactorial / Підрахунок гіперфакторіалу / Вычисление гиперфакториала

`Python`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n - 1)

def superfactorial(n):
    if n == 0: return 1
    else: return factorial(n) * superfactorial(n - 1)

def superduperfactorial(n):
    if n == 0: return 1
    else: return superfactorial(n) * superduperfactorial(n - 1)
```

`JavaScript`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

function superfactorial(n){
    if(n == 0) return 1;
    else return factorial(n) * superfactorial(n - 1);
}

function superduperfactorial(n){
    if(n == 0) return 1;
    else return superfactorial(n) * superduperfactorial(n - 1);
}
```

`Go`:

```go
func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}

func SuperFactorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return Factorial(n) * SuperFactorial(n-1)
    }
}

func SuperDuperFactorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return SuperFactorial(n) * SuperDuperFactorial(n-1)
    }
}
```

`C++`:

```cpp
int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int superfactorial(int n){
    if(n == 0) return 1;
    else return factorial(n) * superfactorial(n - 1);
}

int superduperfactorial(int n){
    if(n == 0) return 1;
    else return superfactorial(n) * superduperfactorial(n - 1);
}
```

`C#`:

```cpp
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}

int SuperFactorial(int n)
{
    if(n == 0) return 1;
    else return Factorial(n) * SuperFactorial(n - 1);
}

int SuperDuperFactorial(int n){
    if(n == 0) return 1;
    else return SuperFactorial(n) * SuperDuperFactorial(n - 1);
}
```

## Combinatorics / Комбінаторика / Комбинаторика

### Packages / Пакети / Пакеты

`Python`:

```python
combinatorics.count_combinations(n, k)
combinatorics.count_permutations(n, k)
combinatorics.generate_combinations(arr, k)
combinatorics.generate_permutations(arr, k)
```

`JavaScript`:

```js
combinatorics.countCombinations(n, k);
combinatorics.countPermutations(n, k);
combinatorics.generateCombinations(arr, k);
combinatorics.generatePermutations(arr, k);
```

<ins>***Wikipedia:***</ins> *[Combinatorics](https://en.wikipedia.org/wiki/Combinatorics)*

<ins>***Вікіпедія:***</ins> *[Комбінаторика](https://uk.wikipedia.org/wiki/Комбінаторика)*

<ins>***Википедия:***</ins> *[Комбинаторика](https://ru.wikipedia.org/wiki/Комбинаторика)*

### Files / Файли / Файлы

<ins>***Python:***</ins> *[combinatorics.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Combinatorics/combinatorics.py)*

<ins>***JavaScript:***</ins> *[combinatorics.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Combinatorics/combinatorics.js)*

<ins>***Go:***</ins> *[combinatorics.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Combinatorics/combinatorics.go)*

<ins>***C++:***</ins> *[combinatorics.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Combinatorics/combinatorics.cpp)*

<ins>***C#:***</ins> *[combinatorics.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Combinatorics/combinatorics.cs)*

### Combinations / Комбінації / Сочетания

`Python`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n - 1)
    
def count_combinations(n, k):
    return factorial(n) / (factorial(k) * factorial(n - k))
    
def generate_combinations(arr, k = None):
    if(k == None):
        k = 1
    result = []
    for i in range(0, count_combinations(len(arr), k)):
        local_result = [0]
        n = len(arr)
        s = 0
        for j in range(1,k+1):
            t = local_result[j - 1] + 1;
            while (t < (n - k + j)) and ((s + count_combinations(n - t, k - j)) <= i):
                s += count_combinations(n - t, k - j)
                t += 1  
            local_result.append(t)
        for l in range(0, len(local_result)):
            local_result[l] = arr[local_result[l] - 1]
        result.append(local_result[1:])
    return result
```


`JavaScript`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

function countCombinations(n, k){
    return factorial(n) / (factorial(k) * factorial(n - k));
}

function generateCombinations(arr, k = NaN){
    if(isNaN(k)){
        k = 1;
    }
    let result = [];
    for(let i = 0; i < countCombinations(arr.length, k); i ++){
        let localResult = [0];
        let n = arr.length;
        let s = 0;
        for(let j = 1; j <= k; j ++){
            let t = localResult[j - 1] + 1;
            while((t < (n - k + j)) && ((s + countCombinations(n - t, k - j)) <= i)){
                s += countCombinations(n - t, k - j);
                t ++;   
            }
            localResult.push(t);
        }
        for(l in localResult){
            localResult[l] = arr[localResult[l] - 1];
        }
        result.push(localResult.slice(1, localResult.length));
    }
    return result;
}
```

`Go`:

```go
func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}

func CountCombinations(n int, k int) int {
    return Factorial(n) / (Factorial(k) * Factorial(n-k))
}

func GenerateCombinations(arr []int, k int) [][]int {
    result := [][]int{}
    for i := 0; i < CountCombinations(len(arr), k); i++ {
        localResult := []int{0}
        n := len(arr)
        s := 0
        for j := 1; j <= k; j++ {
            t := localResult[j-1] + 1
            for (t < (n - k + j)) && (s+CountCombinations(n-t, k-j) <= i) {
                s += CountCombinations(n-t, k-j)
                t++
            }
            localResult = append(localResult, t)
        }
        for l := 1; l < len(localResult); l++ {
            localResult[l] = arr[localResult[l]-1]
        }
        result = append(result, localResult[1:])
    }
    return result
}
```

`C++`:

```cpp
int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int count_combinations(int n, int k){
    return factorial(n) / (factorial(k) * factorial(n - k));
}

std::vector <vector <int>> generate_combinations(vector <int> arr, int k){
    std::vector <vector <int>> result;
    for(int i = 0; i < count_combinations(arr.size(), k); i ++){
        std::vector <int> local_result(1, 0);
        int n = arr.size();
        int s = 0;
        for(int j = 1; j <= k; j++){
            int t = local_result[j - 1] + 1;
            while((t < (n - k + j)) && ((s + count_combinations(n - t, k - j) <= i))){
                s += count_combinations(n - t, k - j);
                t ++;
            }
            local_result.push_back(t);
        }
        for(int l = 1; l < local_result.size(); l ++){
            local_result[l] = arr[local_result[l] - 1];
        }
        result.push_back(vector <int>(local_result.begin() + 1, local_result.end()));
    }
    return result;
}
```

`C#`:

```cs
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}

int CountCombinations(int n, int k)
{
    return Factorial(n) / (Factorial(k) * Factorial(n - k));
}

List<List <int>> GenerateCombinations(List<int> arr, int k)
{
    List<List <int>> result = new List<List <int>>(){};
    for(int i = 0; i < CountCombinations(arr.Count(), k); i ++)
    {
        List<int> localResult = new List<int>(1){0};
        int n = arr.Count();
        int s = 0;
        for(int j = 1; j <= k; j ++)
        {
            int t = localResult[j - 1] + 1;
            while((t < (n - k + j)) && ((s + CountCombinations(n - t, k - j)) <= i))
            {
                s += CountCombinations(n - t, k - j);
                t ++;
            }
            localResult.Add(t);
        }
        for(int l = 1; l < localResult.Count(); l ++){
            localResult[l] = arr[localResult[l] - 1];
        }
        result.Add(localResult.GetRange(1, localResult.Count() - 1));
    }
    return result;
}
```

### Permutations / Розміщення / Размещения

`Python`:

```python
def factorial(n):
    if n == 0: return 1
    else: return n * factorial(n - 1)

def count_combinations(n, k):
    return factorial(n) / (factorial(k) * factorial(n - k))

def count_permutations(n, k):
    return factorial(n) / factorial(n - k)
    
def generate_combinations(arr, k = None):
    if(k == None):
        k = 1
    result = []
    for i in range(0, count_combinations(len(arr), k)):
        local_result = [0]
        n = len(arr)
        s = 0
        for j in range(1,k+1):
            t = local_result[j - 1] + 1;
            while (t < (n - k + j)) and ((s + count_combinations(n - t, k - j)) <= i):
                s += count_combinations(n - t, k - j)
                t += 1  
            local_result.append(t)
        for l in range(0, len(local_result)):
            local_result[l] = arr[local_result[l] - 1]
        result.append(local_result[1:])
    return result

def generate_permutations(arr, k = None):
    if(k == None):
        k = len(arr)
    result = []
    m = generate_combinations(arr, k)
    for arr in m:
        local_result = []
        for i in range(0, factorial(len(arr))):
            ind = i + 1
            local_local_result = []
            local_local_arr = []
            for a in arr:
                local_local_arr.append(a)
            n = len(local_local_arr)
            for j in range(1, n + 1):
                f = factorial(n - j)
                g = int((ind + f - 1) / f)
                local_local_result.append(local_local_arr.pop(g - 1))
                ind -= (g - 1) * f
            if len(local_local_arr):
                local_local_result.append(local_local_arr[0])
            local_result.append(local_local_result)
        for u in local_result:
            result.append(u)
    return result
```


`JavaScript`:

```js
function factorial(n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

function countCombinations(n, k){
    return factorial(n) / (factorial(k) * factorial(n - k));
}

function countPermutations(n, k){
    return factorial(n) / factorial(n - k);
}

function generateCombinations(arr, k = NaN){
    if(isNaN(k)){
        k = 1;
    }
    let result = [];
    for(let i = 0; i < countCombinations(arr.length, k); i ++){
        let localResult = [0];
        let n = arr.length;
        let s = 0;
        for(let j = 1; j <= k; j ++){
            let t = localResult[j - 1] + 1;
            while((t < (n - k + j)) && ((s + countCombinations(n - t, k - j)) <= i)){
                s += countCombinations(n - t, k - j);
                t ++;   
            }
            localResult.push(t);
        }
        for(l in localResult){
            localResult[l] = arr[localResult[l] - 1];
        }
        result.push(localResult.slice(1, localResult.length));
    }
    return result;
}

function generatePermutations(arr, k = NaN){
    if(isNaN(k)){
        k = arr.length;
    }
    let result = [];
    let m = generateCombinations(arr, k);
    for(arr of m){
        let localResult = [];
        for(let i = 0; i < factorial(arr.length); i ++){
            let ind = i + 1;
            let localLocalResult = [];
            let localLocalArr = [];
            for(a of arr){
                localLocalArr.push(a);
            }
            let n = localLocalArr.length;
            for(let j = 1; j <= n; j ++){
                let f = factorial(n - j);
                let g = Math.floor((ind + f - 1) / f);
                localLocalResult.push(localLocalArr.splice(g - 1, 1)[0]);
                ind -= (g - 1) * f;
            }
            if(localLocalArr.length){
                localLocalResult.push(localLocalArr[0]);
            }
            localResult.push(localLocalResult);
        }
        for(u of localResult){
            result.push(u);
        }
    }
    return result;
}
```

`Go`:

```go
func Factorial(n int) int {
    if n == 0 {
        return 1
    } else {
        return n * Factorial(n-1)
    }
}

func CountCombinations(n int, k int) int {
    return Factorial(n) / (Factorial(k) * Factorial(n-k))
}

func CountPermutations(n int, k int) int {
    return Factorial(n) / Factorial(n-k)
}

func GenerateCombinations(arr []int, k int) [][]int {
    result := [][]int{}
    for i := 0; i < CountCombinations(len(arr), k); i++ {
        localResult := []int{0}
        n := len(arr)
        s := 0
        for j := 1; j <= k; j++ {
            t := localResult[j-1] + 1
            for (t < (n - k + j)) && (s+CountCombinations(n-t, k-j) <= i) {
                s += CountCombinations(n-t, k-j)
                t++
            }
            localResult = append(localResult, t)
        }
        for l := 1; l < len(localResult); l++ {
            localResult[l] = arr[localResult[l]-1]
        }
        result = append(result, localResult[1:])
    }
    return result
}

func GeneratePermutations(arr []int, k int) [][]int {
    result := [][]int{}
    m := GenerateCombinations(arr, k)
    for _, a := range m {
        localResult := [][]int{}
        for i := 0; i < Factorial(len(a)); i++ {
            ind := i + 1
            localLocalResult := []int{}
            localLocalArr := []int{}
            for _, r := range a {
                localLocalArr = append(localLocalArr, r)
            }
            n := len(localLocalArr)
            for j := 1; j <= n; j++ {
                f := Factorial(n - j)
                g := (ind + f - 1) / f
                localLocalResult = append(localLocalResult, localLocalArr[g-1])
                localLocalArr = append(localLocalArr[:g-1], localLocalArr[g:]...)
                ind -= (g - 1) * f
            }
            if len(localLocalArr) > 0 {
                localLocalResult = append(localLocalResult, localLocalArr[0])
            }
            localResult = append(localResult, localLocalResult)
        }
        for _, u := range localResult {
            result = append(result, u)
        }
    }
    return result
}
```

`C++`:

```cpp
int factorial(int n){
    if(n == 0) return 1;
    else return n * factorial(n - 1);
}

int count_combinations(int n, int k){
    return factorial(n) / (factorial(k) * factorial(n - k));
}

int count_permutations(int n, int k){
    return factorial(n) / factorial(n - k);
}

std::vector <vector <int>> generate_combinations(std::vector <int> arr, int k){
    std::vector <vector <int>> result;
    for(int i = 0; i < count_combinations(arr.size(), k); i ++){
        std::vector <int> local_result(1, 0);
        int n = arr.size();
        int s = 0;
        for(int j = 1; j <= k; j++){
            int t = local_result[j - 1] + 1;
            while((t < (n - k + j)) && ((s + count_combinations(n - t, k - j) <= i))){
                s += count_combinations(n - t, k - j);
                t ++;
            }
            local_result.push_back(t);
        }
        for(int l = 1; l < local_result.size(); l ++){
            local_result[l] = arr[local_result[l] - 1];
        }
        result.push_back(std::vector <int>(local_result.begin() + 1, local_result.end()));
    }
    return result;
}

std::vector <vector <int>> generate_permutations(std::vector <int> arr, int k){
    std::vector <vector <int>> result;
    std::vector <vector <int>> m = generate_combinations(arr, k);
    for(auto a: m){
        std::vector <vector <int>> local_result;
        for(int i = 0; i < factorial(a.size()); i ++){
            int ind = i + 1;
            std::vector <int> local_local_result;
            std::vector <int> local_local_arr;
            for(auto r: a){
                local_local_arr.push_back(r);
            }
            int n = local_local_arr.size();
            for(int j = 1; j <= n; j ++){
                int f = factorial(n - j);
                int g = (ind + f - 1) / f;
                local_local_result.push_back(local_local_arr[g - 1]);
                auto iter = local_local_arr.cbegin();
                local_local_arr.erase(iter + g - 1);
                ind -= (g - 1) * f;
            }
            if(local_local_arr.size()){
                local_local_result.push_back(local_local_arr[0]);
            }
            local_result.push_back(local_local_result);
        }
        for(auto u: local_result){
            result.push_back(u);
        }
    }
    return result;
}
```

`C#`:

```cs
int Factorial(int n)
{
    if(n == 0) return 1;
    else return n * Factorial(n - 1);
}

int CountCombinations(int n, int k)
{
    return Factorial(n) / (Factorial(k) * Factorial(n - k));
}

int CountPermutations(int n, int k)
{
    return Factorial(n) / Factorial(n - k);
}

List<List <int>> GenerateCombinations(List<int> arr, int k)
{
    List<List <int>> result = new List<List <int>>(){};
    for(int i = 0; i < CountCombinations(arr.Count(), k); i ++)
    {
        List<int> localResult = new List<int>(1){0};
        int n = arr.Count();
        int s = 0;
        for(int j = 1; j <= k; j ++)
        {
            int t = localResult[j - 1] + 1;
            while((t < (n - k + j)) && ((s + CountCombinations(n - t, k - j)) <= i))
            {
                s += CountCombinations(n - t, k - j);
                t ++;
            }
            localResult.Add(t);
        }
        for(int l = 1; l < localResult.Count(); l ++){
            localResult[l] = arr[localResult[l] - 1];
        }
        result.Add(localResult.GetRange(1, localResult.Count() - 1));
    }
    return result;
}

List<List <int>> GeneratePermutations(List<int> arr, int k)
{
    List<List <int>> result = new List<List <int>>(){};
    List<List <int>> m = GenerateCombinations(arr, k);
    foreach(List <int> a in m)
    {
        List<List <int>> localResult = new List<List <int>>(){};
        for(int i = 0; i < Factorial(a.Count()); i ++)
        {
            int ind = i + 1;
            List <int> localLocalResult = new List <int>(){};
            List <int> localLocalArr = new List <int>(){};
            foreach(int r in a)
            {
                localLocalArr.Add(r);
            }
            int n = localLocalArr.Count();
            for(int j = 1; j <= n; j ++)
            {
                int f = Factorial(n - j);
                int g = (ind + f - 1) / f;
                localLocalResult.Add(localLocalArr[g - 1]);
                localLocalArr.RemoveAt(g - 1);
                ind -= (g - 1) * f; 
            }
            if(localLocalArr.Count() > 0)
            {
                localLocalResult.Add(localLocalArr[0]);
            }
            localResult.Add(localLocalResult);
        }
        foreach(List <int> u in localResult)
        {
            result.Add(u);
        }
    }
    return result;
}
```

## Roman and arabic numerals / Римські та арабські числа / Римские и арабские числа

### Packages / Пакети / Пакеты

`Python`:

```python
roman_arabic_numerals.rom_arab(p)
roman_arabic_numerals.arab_rom(s)
```

`JavaScript`:

```js
romanArabicNumerals.romArab(p);
romanArabicNumerals.arabRom(s);
```

### Files / Файли / Файлы

<ins>***Python:***</ins> *[roman-arabic-numerals.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Roman%20arabic%20numerals/roman-arabic-numerals.py)*

<ins>***JavaScript:***</ins> *[roman-arabic-numerals.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Roman%20arabic%20numerals/roman-arabic-numerals.js)*

<ins>***Go:***</ins> *[roman-arabic-numerals.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Roman%20arabic%20numerals/roman-arabic-numerals.go)*


<ins>***C++:***</ins> *[roman-arabic-numerals.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Roman%20arabic%20numerals/roman-arabic-numerals.cpp)*


<ins>***C#:***</ins> *[roman-arabic-numerals.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Roman%20arabic%20numerals/roman-arabic-numerals.cs)*

`Python`:

```python
def rom_arab(p):
    z = 0
    try:
        p = str(p).lower()
        for i in range(0, len(p)):
            if p[i] == 'i':
                try:
                    if p[i+1] == 'v' or p[i+1] == 'x': 
                        z -= 1
                    else:
                        z += 1
                except:
                    z += 1
            elif p[i] == 'v':
                z += 5
            elif p[i] == 'x':
                try:
                    if p[i+1] == 'c' or p[i+1] == 'l': 
                        z -= 10
                    else:
                        z += 10
                except:
                    z += 10
            elif p[i] == 'l':
                z += 50
            elif p[i] == 'c':
                try:
                    if p[i+1] == 'm' or p[i+1] == 'd': 
                        z -= 100
                    else:
                        z += 100
                except:
                    z += 100
            elif p[i] == 'd':
                z += 500
            elif p[i] == 'm':
                z += 1000
            else:
                return None
    except:
        return None
    return z

def arab_rom(s):
    v = ""
    try:
        s = int(s)
        while s > 0:
            if s >= 1000:
                s -= 1000
                v += "M"
            elif s >= 900:
                s -= 900
                v += "CM"
            elif s >= 500:
                s -= 500
                v += "D"
            elif s >= 400:
                s -= 400
                v += "CD"
            elif s >= 100:
                s -= 100
                v += "C"
            elif s >= 90:
                s -= 90
                v += "XC"
            elif s >= 50:
                s -= 50
                v += "L"
            elif s >= 40:
                s -= 40
                v += "XL"
            elif s >= 10:
                s -= 10
                v += "X"
            elif s >= 9:
                s -= 9 
                v += "IX"
            elif s >= 5:
                s -= 5
                v += "V"
            elif s >= 4:
                s -= 4
                v += "IV"
            elif s >= 1:
                s -= 1
                v += "I"
    except:
        return None
    return v
```

`JavaScript`:

```js
function romArab(p){
    let z = 0;
    try{
        p = String(p).toLowerCase();
        for(let i = 0; i < p.length; i ++){
            if(p[i] == 'i'){
                try{
                    if(p[i+1] == 'v' || p[i+1] == 'x'){ 
                        z -= 1;
                    }
                    else{
                        z += 1;
                    }
                }
                catch(e){
                    z += 1;
                }
            }
            else if(p[i] == 'v'){
                z += 5;
            }
            else if(p[i] == 'x'){
                try{
                    if(p[i+1] == 'c' || p[i+1] == 'l'){
                        z -= 10;
                    }
                    else{
                        z += 10;
                    }
                }
                catch(e){
                    z += 10;
                }
            }
            else if(p[i] == 'l'){
                z += 50;
            }
            else if(p[i] == 'c'){
                try{
                    if(p[i+1] == 'm' || p[i+1] == 'd'){ 
                        z -= 100;
                    }
                    else{
                        z += 100;
                    }
                }
                catch(e){
                    z += 100;
                }
            }
            else if(p[i] == 'd'){
                z += 500;
            }
            else if(p[i] == 'm'){
                z += 1000;
            }
            else{
                return NaN;
            }
        }
    }
    catch(e){
       return NaN;
    }
    return z;
}

function arabRom(s){
    let v = "";
    try{
        s = Number(s);
        if(isNaN(s)){
            return NaN;
        }
        while(s > 0){
            if(s >= 1000){
                s -= 1000;
                v += "M";
            }
            else if(s >= 900){
                s -= 900;
                v += "CM";
            }
            else if(s >= 500){
                s -= 500;
                v += "D";
            }
            else if(s >= 400){
                s -= 400;
                v += "CD";
            }
            else if(s >= 100){
                s -= 100;
                v += "C";
            }
            else if(s >= 90){
                s -= 90;
                v += "XC";
            }
            else if(s >= 50){
                s -= 50;
                v += "L";
            }
            else if(s >= 40){
                s -= 40;
                v += "XL";
            }
            else if(s >= 10){
                s -= 10;
                v += "X";
            }
            else if(s >= 9){
                s -= 9;
                v += "IX";
            }
            else if(s >= 5){
                s -= 5;
                v += "V";
            }
            else if(s >= 4){
                s -= 4;
                v += "IV";
            }
            else if(s >= 1){
                s -= 1;
                v += "I";
            }
        }
    }
    catch(e){
        return NaN;
    }
    return v;
}
```

`Go`:

```go
func RomArab(p string) int {
    z := 0
    p = strings.ToLower(p)
    for i := 0; i < len(p); i++ {
        if p[i] == 'i' {
            if p[i+1] == 'v' || p[i+1] == 'x' {
                z--
            } else {
                z++
            }
        } else if p[i] == 'v' {
            z += 5
        } else if p[i] == 'x' {
            if p[i+1] == 'c' || p[i+1] == 'l' {
                z -= 10
            } else {
                z += 10
            }
        } else if p[i] == 'l' {
            z += 50
        } else if p[i] == 'c' {
            if p[i+1] == 'm' || p[i+1] == 'd' {
                z -= 100
            } else {
                z += 100
            }
        } else if p[i] == 'd' {
            z += 500
        } else if p[i] == 'm' {
            z += 1000
        } else {
            fmt.Println("Uncorrect input")
            return 0
        }
    }
    return z
}

func ArabRom(s int) string {
    v := ""
    for s > 0 {
        if s >= 1000 {
            s -= 1000
            v += "M"
        } else if s >= 900 {
            s -= 900
            v += "CM"
        } else if s >= 500 {
            s -= 500
            v += "D"
        } else if s >= 400 {
            s -= 400
            v += "CD"
        } else if s >= 100 {
            s -= 100
            v += "C"
        } else if s >= 90 {
            s -= 90
            v += "XC"
        } else if s >= 50 {
            s -= 50
            v += "L"
        } else if s >= 40 {
            s -= 40
            v += "XL"
        } else if s >= 10 {
            s -= 10
            v += "X"
        } else if s >= 9 {
            s -= 9
            v += "IX"
        } else if s >= 5 {
            s -= 5
            v += "V"
        } else if s >= 4 {
            s -= 4
            v += "IV"
        } else if s >= 1 {
            s -= 1
            v += "I"
        }
    }
    return v
}
```

`C++`:

```cpp
#include <string>

int rom_arab(string p){
    int z = 0;
    try{
        for(int i = 0; i < p.length(); i ++){
            if(tolower(p[i]) == 'i'){
                try{
                    if(tolower(p[i+1]) == 'v' || tolower(p[i+1]) == 'x'){ 
                        z -= 1;
                    }
                    else{
                        z += 1;
                    }
                }
                catch(...){
                    z += 1;
                }
            }
            else if(tolower(p[i]) == 'v'){
                z += 5;
            }
            else if(tolower(p[i]) == 'x'){
                try{
                    if(tolower(p[i+1]) == 'c' || tolower(p[i+1]) == 'l'){
                        z -= 10;
                    }
                    else{
                        z += 10;
                    }
                }
                catch(...){
                    z += 10;
                }
            }
            else if(tolower(p[i]) == 'l'){
                z += 50;
            }
            else if(tolower(p[i]) == 'c'){
                try{
                    if(tolower(p[i+1]) == 'm' || tolower(p[i+1]) == 'd'){ 
                        z -= 100;
                    }
                    else{
                        z += 100;
                    }
                }
                catch(...){
                    z += 100;
                }
            }
            else if(tolower(p[i]) == 'd'){
                z += 500;
            }
            else if(tolower(p[i]) == 'm'){
                z += 1000;
            }
            else{
                std::cout << "Uncorrect input" << std::endl;
                return 0;
            }
        }
    }
    catch(...){
        std::cout << "Uncorrect input" << std::endl;
        return 0;
    }
    return z;
}

std::string arab_rom(int s){
    std::string v = "";
    try{
        while(s > 0){
            if(s >= 1000){
                s -= 1000;
                v += "M";
            }
            else if(s >= 900){
                s -= 900;
                v += "CM";
            }
            else if(s >= 500){
                s -= 500;
                v += "D";
            }
            else if(s >= 400){
                s -= 400;
                v += "CD";
            }
            else if(s >= 100){
                s -= 100;
                v += "C";
            }
            else if(s >= 90){
                s -= 90;
                v += "XC";
            }
            else if(s >= 50){
                s -= 50;
                v += "L";
            }
            else if(s >= 40){
                s -= 40;
                v += "XL";
            }
            else if(s >= 10){
                s -= 10;
                v += "X";
            }
            else if(s >= 9){
                s -= 9;
                v += "IX";
            }
            else if(s >= 5){
                s -= 5;
                v += "V";
            }
            else if(s >= 4){
                s -= 4;
                v += "IV";
            }
            else if(s >= 1){
                s -= 1;
                v += "I";
            }
        }
    }
    catch(...){
        std::cout << "Uncorrect input" << std::endl;
        return "";
    }
    return v;
}
```

`C#`:

```cs
int RomArab(string p)
{
    int z = 0;
    try
    {
        for(int i = 0; i < p.Length; i ++)
        {
            if(char.ToLower(p[i]) == 'i')
            {
                try
                {
                    if(char.ToLower(p[i+1]) == 'v' || char.ToLower(p[i+1]) == 'x')
                    { 
                        z -= 1;
                    }
                    else
                    {
                        z += 1;
                    }
                }
                catch
                {
                    z += 1;
                }
            }
            else if(char.ToLower(p[i]) == 'v')
            {
                z += 5;
            }
            else if(char.ToLower(p[i]) == 'x')
            {
                try
                {
                    if(char.ToLower(p[i+1]) == 'c' || char.ToLower(p[i+1]) == 'l')
                    {
                        z -= 10;
                    }
                    else
                    {
                        z += 10;
                    }
                }
                catch
                {
                    z += 10;
                }
            }
            else if(char.ToLower(p[i]) == 'l')
            {
                z += 50;
            }
            else if(char.ToLower(p[i]) == 'c')
            {
                try
                {
                    if(char.ToLower(p[i+1]) == 'm' || char.ToLower(p[i+1]) == 'd')
                    { 
                        z -= 100;
                    }
                    else
                    {
                        z += 100;
                    }
                }
                catch
                {
                    z += 100;
                }
            }
            else if(char.ToLower(p[i]) == 'd')
            {
                z += 500;
            }
            else if(char.ToLower(p[i]) == 'm')
            {
                z += 1000;
            }
            else
            {
                Console.WriteLine("Uncorrect input");
                return 0;
            }
        }
    }
    catch
    {
        Console.WriteLine("Uncorrect input");
        return 0;
    }
    return z;
}

string ArabRom(int s)
{
    string v = "";
    try
    {
        while(s > 0)
        {
            if(s >= 1000)
            {
                s -= 1000;
                v += "M";
            }
            else if(s >= 900)
            {
                s -= 900;
                v += "CM";
            }
            else if(s >= 500)
            {
                s -= 500;
                v += "D";
            }
            else if(s >= 400)
            {
                s -= 400;
                v += "CD";
            }
            else if(s >= 100)
            {
                s -= 100;
                v += "C";
            }
            else if(s >= 90)
            {
                s -= 90;
                v += "XC";
            }
            else if(s >= 50)
            {
                s -= 50;
                v += "L";
            }
            else if(s >= 40)
            {
                s -= 40;
                v += "XL";
            }
            else if(s >= 10)
            {
                s -= 10;
                v += "X";
            }
            else if(s >= 9)
            {
                s -= 9;
                v += "IX";
            }
            else if(s >= 5)
            {
                s -= 5;
                v += "V";
            }
            else if(s >= 4)
            {
                s -= 4;
                v += "IV";
            }
            else if(s >= 1)
            {
                s -= 1;
                v += "I";
            }
        }
    }
    catch
    {
        Console.WriteLine("Uncorrect input");
        return "";
    }
    return v;
}
```

## Arithmetic for big numbers / Арифметика для великих чисел / Арифметика для больших чисел

### Packages / Пакети / Пакеты

`Python`:

```python
arithmetic.addition_big_numbers(a, b)
arithmetic.subtraction_big_numbers(a, b)
arithmetic.multiplication_big_numbers(a, b)
```

`JavaScript`:

```js
arithmetic.additionBigNumbers(a, b);
arithmetic.subtractionBigNumbers(a, b);
arithmetic.multiplicationBigNumbers(a, b);
```

### Files / Файли / Файлы

<ins>***Python:***</ins> *[arithmetic.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Arithmetic/arithmetic.py)*

<ins>***JavaScript:***</ins> *[arithmetic.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Arithmetic/arithmetic.js)*

<ins>***Go:***</ins> *[arithmetic.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Arithmetic/arithmetic.go)*

<ins>***C++:***</ins> *[arithmetic.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Arithmetic/arithmetic.cpp)*

<ins>***C#:***</ins> *[arithmetic.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Arithmetic/arithmetic.cs)*

### Addition / Додавання / Прибавление

`Python`:

```python
def addition_big_numbers(a, b):
    a = str(a)[::-1]
    b = str(b)[::-1]

    while(len(b) < len(a)):
        b += '0'
    while(len(a) < len(b)):
        a += '0'

    result = ''
    c = 0
    for i in range(0, len(a)):
        local_result = int(a[i]) + int(b[i]) + c
        c = 0
        if local_result > 9:
            local_result -= 10
            c = 1
        result += str(local_result)
    if c == 1:
        result += '1'
    return result[::-1]
```

`JavaScript`:

```js
function additionBigNumbers(a, b){
    a = String(a).split("").reverse().join("");
    b = String(b).split("").reverse().join("");

    while(b.length < a.length){
        b += '0';
    }
    while(a.length < b.length){
        a += '0';
    }

    let result = '';
    let c = 0;
    for(let i = 0; i < a.length; i ++){
        let localResult = Number(a[i]) + Number(b[i]) + c;
        c = 0;
        if(localResult > 9){
            localResult -= 10;
            c = 1;
        }
        result += String(localResult);
    }
    if(c == 1){
        result += '1';
    }
    return result.split("").reverse().join("");
}
```

`Go`:

```go
func AdditionBigNumbers(a string, b string) string {
    for len(b) < len(a) {
        b = "0" + b
    }
    for len(a) < len(b) {
        a = "0" + a
    }
    result := ""
    c := 0
    for i := len(a) - 1; i >= 0; i-- {
        localResult := int(a[i]-48) + int(b[i]-48) + c
        c = 0
        if localResult > 9 {
            localResult -= 10
            c = 1
        }
        result += strconv.Itoa(localResult)
    }
    if c == 1 {
        result += "1"
    }
    fresult := ""
    for _, s := range result {
        fresult = string(s) + fresult
    }
    return fresult
}
```

`C++`:

```cpp
#include <string>

std::string addition_big_numbers(string a, string b){
    while(b.length() < a.length()){
        b = "0" + b;
    }
    while(a.length() < b.length()){
        a = "0" + a;
    }
    std::string result = "";
    int c = 0;
    for(int i = a.length() - 1; i >= 0; i --){
        int local_result = (a[i] - 48) + (b[i] - 48) + c;
        c = 0;
        if(local_result > 9){
            local_result -= 10;
            c = 1;
        }
        result += to_string(local_result);
    }
    if(c == 1){
        result += "1";
    }
    std::string fresult = "";
    for(auto s: result){
        fresult = s + fresult;
    }
    return fresult;
}
```

`C#`:

```cs 
string AdditionBigNumbers(string a, string b)
{
    while(b.Length < a.Length)
    {
        b = "0" + b;
    }
    while(a.Length < b.Length)
    {
        a = "0" + a;
    }
    string result = "";
    int c = 0;
    for(int i = a.Length - 1; i >= 0; i --)
    {
        int localResult = (a[i] - 48) + (b[i] - 48) + c;
        c = 0;
        if(localResult > 9)
        {
            localResult -= 10;
            c = 1;
        }
        result += localResult.ToString();
    }
    if(c == 1){
        result += "1";
    }
    string fresult = "";
    foreach(char s in result)
    {
        fresult = s + fresult;
    }
    return fresult;
}
```

### Subtraction / Віднімання / Вычетание

`Python`:

```python
def subtraction_big_numbers(a, b):
    k = False
    if int(a) > int(b):
        a = str(a)[::-1]
        b = str(b)[::-1]
    else:
        k = True
        swap = str(a)[::-1]
        a = str(b)[::-1]
        b = swap
    while(len(b) < len(a)):
        b += '0'
    while(len(a) < len(b)):
        a += '0'

    result = ''
    c = 0
    for i in range(0, len(a)):
        local_result = int(a[i]) - int(b[i]) - c
        c = 0
        if local_result < 0:
            local_result += 10
            c = 1
        result += str(local_result)

    if k:
        result += '-'
    while result[-1] == '0':
        result = result[:-1]
    return result[::-1]
```

`JavaScript`:

```js
function subtractionBigNumbers(a, b){
    let k = false;
    if(Number(a) > Number(b)){
        a = String(a).split("").reverse().join("");
        b = String(b).split("").reverse().join("");
    }
    else{
        k = true;
        swap = String(a).split("").reverse().join("");
        a = String(b).split("").reverse().join("");
        b = swap;
    }

    while(b.length < a.length){
        b += '0';
    }
    while(a.length < b.length){
        a += '0';
    }

    let result = '';
    let c = 0;
    for(let i = 0; i < a.length; i ++){
        let localResult = Number(a[i]) - Number(b[i]) - c;
        c = 0;
        if(localResult < 0){
            localResult += 10;
            c = 1;
        }
        result += String(localResult);
    }
    if(k){
        result += '-'
    }
    while(result[result.length - 1] == '0'){
        result = result.slice(0, result.length - 1);
    }
    return result.split("").reverse().join("");
}
```

`Go`:

```go
func SubtractionBigNumbers(a string, b string) string {
    k := false
    if len(a) < len(b) {
        a, b = b, a
        k = true
    }
    ai, _ := strconv.Atoi(a)
    bi, _ := strconv.Atoi(b)
    if ai < bi {
        a, b = b, a
        k = true
    }
    for len(b) < len(a) {
        b = "0" + b
    }
    for len(a) < len(b) {
        a = "0" + a
    }
    result := ""
    c := 0
    for i := len(a) - 1; i >= 0; i-- {
        localResult := int(a[i]-48) - int(b[i]-48) - c
        c = 0
        if localResult < 0 {
            localResult += 10
            c = 1
        }
        result += strconv.Itoa(localResult)
    }
    if c == 1 {
        result += "1"
    }
    for result[len(result)-1] == '0' {
        result = result[:len(result)-1]
    }
    fresult := ""
    for _, s := range result {
        fresult = string(s) + fresult
    }
    if k {
        fresult = "-" + fresult
    }
    return fresult
}
```

`C++`:

```cpp
#include <string>
#include <sstream>

std::string subtraction_big_numbers(string a, string b){
    std::stringstream ssa;
    ssa << a;
    long long n = 0;
    ssa >> n;
    std::stringstream ssb;
    ssb << b;
    long long m = 0;
    ssb >> m;
    bool k = false;
    if(n < m){
        k = true;
        std::string swap = a;
        a = b;
        b = swap;
    }
    while(b.length() < a.length()){
        b = "0" + b;
    }
    while(a.length() < b.length()){
        a = "0" + a;
    }
    std::string result = "";
    int c = 0;
    for(int i = a.length() - 1; i >= 0; i --){
        int local_result = (a[i] - 48) - (b[i] - 48) - c;
        c = 0;
        if(local_result < 0){
            local_result += 10;
            c = 1;
        }
        result += to_string(local_result);
    }
    if(c == 1){
        result += "1";
    }
    while(result[result.length() - 1] == '0'){
        result = result.substr(0, result.length() - 1);
    }
    std::string fresult = "";
    for(auto s: result){
        fresult = s + fresult;
    }
    if(k){
        fresult = '-' + fresult;
    }
    return fresult;
}
```

`C#`:

```cs
string SubtractionBigNumbers(string a, string b)
{
    bool k = false;
    if(Convert.ToInt32(a) < Convert.ToInt32(b))
    {
        string swap = a;
        a = b;
        b = swap;
        k = true;
    }
    while(b.Length < a.Length)
    {
        b = "0" + b;
    }
    while(a.Length < b.Length)
    {
        a = "0" + a;
    }
    string result = "";
    int c = 0;
    for(int i = a.Length - 1; i >= 0; i --)
    {
        int localResult = (a[i] - 48) - (b[i] - 48) - c;
        c = 0;
        if(localResult < 0)
        {
            localResult += 10;
            c = 1;
        }
        result += localResult.ToString();
    }
    if(c == 1)
    {
        result += "1";
    }
    while(result[result.Length - 1] == '0')
    {
        result = result.Substring(0, result.Length - 1);
    }
    string fresult = "";
    foreach(char s in result)
    {
        fresult = s + fresult;
    }
    if(k)
    {
        fresult = '-' + fresult;
    }
    return fresult; 
}
```

### Multiplication / Множення / Умножение

`Python`:

```python
def addition_big_numbers(a, b):
    a = str(a)[::-1]
    b = str(b)[::-1]

    while(len(b) < len(a)):
        b += '0'
    while(len(a) < len(b)):
        a += '0'

    result = ''
    c = 0
    for i in range(0, len(a)):
        local_result = int(a[i]) + int(b[i]) + c
        c = 0
        if local_result > 9:
            local_result -= 10
            c = 1
        result += str(local_result)
    if c == 1:
        result += '1'
    return result[::-1]
    
def multiplication_big_numbers(a, b):
    a = str(a)[::-1]
    b = str(b)[::-1]

    result = ''
    c = 0
    for i in range(0, len(b)):
        local_result = ''
        c = 0
        for j in range(0, len(a)):
            local_local_result = int(a[j]) * int(b[i]) + c
            c = 0
            while local_local_result > 9:
                local_local_result -= 10
                c += 1
            local_result += str(local_local_result)
        if c > 0:
            local_result += str(c)
            c = 0
        result = addition_big_numbers(str(result), str(local_result)[::-1] + ('0' * i))
    return result
```

`JavaScript`:

```js
function additionBigNumbers(a, b){
    a = String(a).split("").reverse().join("");
    b = String(b).split("").reverse().join("");

    while(b.length < a.length){
        b += '0';
    }
    while(a.length < b.length){
        a += '0';
    }

    let result = '';
    let c = 0;
    for(let i = 0; i < a.length; i ++){
        let localResult = Number(a[i]) + Number(b[i]) + c;
        c = 0;
        if(localResult > 9){
            localResult -= 10;
            c = 1;
        }
        result += String(localResult);
    }
    if(c == 1){
        result += '1';
    }
    return result.split("").reverse().join("");
}

function multiplicationBigNumbers(a, b){
    a = String(a).split("").reverse().join("");
    b = String(b).split("").reverse().join("");

    let result = '';
    let c = 0;
    for(let i = 0; i < b.length; i ++){
        let localResult = '';
        c = 0;
        for(let j = 0; j < a.length; j ++){
            let localLocalResult = Number(a[j]) * Number(b[i]) + c;
            c = 0;
            while(localLocalResult > 9){
                localLocalResult -= 10;
                c += 1
            }
            localResult += String(localLocalResult);
        }
        if(c > 0){
            localResult += String(c);
            c = 0;
        }
        let flocalResult = String(localResult).split("").reverse().join("");
        for(let f = 0; f < i; f ++){
            flocalResult += '0';
        }
        result = additionBigNumbers(String(result), String(flocalResult));
    }
    return result;
}
```

`Go`:

```go
func AdditionBigNumbers(a string, b string) string {
    for len(b) < len(a) {
        b = "0" + b
    }
    for len(a) < len(b) {
        a = "0" + a
    }
    result := ""
    c := 0
    for i := len(a) - 1; i >= 0; i-- {
        localResult := int(a[i]-48) + int(b[i]-48) + c
        c = 0
        if localResult > 9 {
            localResult -= 10
            c = 1
        }
        result += strconv.Itoa(localResult)
    }
    if c == 1 {
        result += "1"
    }
    fresult := ""
    for _, s := range result {
        fresult = string(s) + fresult
    }
    return fresult
}

func MultiplicationBigNumbers(a string, b string) string {
    result := ""
    c := 0
    for i := len(b) - 1; i >= 0; i-- {
        localResult := ""
        c = 0
        for j := len(a) - 1; j >= 0; j-- {
            localLocalResult := int(a[j]-48)*int(b[i]-48) + c
            c = 0
            for localLocalResult > 9 {
                localLocalResult -= 10
                c++
            }
            localResult += strconv.Itoa(localLocalResult)
        }
        if c > 0 {
            localResult += strconv.Itoa(c)
            c = 0
        }
        flocalResult := ""
        for _, s := range localResult {
            flocalResult = string(s) + flocalResult
        }
        for f := 0; f < len(b)-i-1; f++ {
            flocalResult += "0"
        }
        result = AdditionBigNumbers(result, flocalResult)
    }
    return result
}
```

`C++`:

```cpp
#include <string>

std::string addition_big_numbers(string a, string b){
    while(b.length() < a.length()){
        b = "0" + b;
    }
    while(a.length() < b.length()){
        a = "0" + a;
    }
    std::string result = "";
    int c = 0;
    for(int i = a.length() - 1; i >= 0; i --){
        int local_result = (a[i] - 48) + (b[i] - 48) + c;
        c = 0;
        if(local_result > 9){
            local_result -= 10;
            c = 1;
        }
        result += to_string(local_result);
    }
    if(c == 1){
        result += "1";
    }
    std::string fresult = "";
    for(auto s: result){
        fresult = s + fresult;
    }
    return fresult;
}

std::string multiplication_big_numbers(string a, string b){
    std::string result = "";
    int c = 0;
    for(int i = b.length() - 1; i >= 0; i --){
        std::string local_result = "";
        c = 0;
        for(int j = a.length() - 1; j >= 0; j --){
            int local_local_result = (a[j] - 48) * (b[i] - 48) + c;
            c = 0;
            while(local_local_result > 9){
                local_local_result -= 10;
                c += 1;
            }
            local_result += to_string(local_local_result);
        }
        if(c > 0){
            local_result += to_string(c);
            c = 0;
        }
        std::string flocal_result = "";
        for(auto s: local_result){
            flocal_result = s + flocal_result;
        }
        for(int f = 0; f < b.length() - i - 1; f ++){
            flocal_result += "0";
        }
        result = addition_big_numbers(result, flocal_result);
    }
    return result;
}
```

`C#`:

```cs
string AdditionBigNumbers(string a, string b)
{
    while(b.Length < a.Length)
    {
        b = "0" + b;
    }
    while(a.Length < b.Length)
    {
        a = "0" + a;
    }
    string result = "";
    int c = 0;
    for(int i = a.Length - 1; i >= 0; i --)
    {
        int localResult = (a[i] - 48) + (b[i] - 48) + c;
        c = 0;
        if(localResult > 9)
        {
            localResult -= 10;
            c = 1;
        }
        result += localResult.ToString();
    }
    if(c == 1){
        result += "1";
    }
    string fresult = "";
    foreach(char s in result)
    {
        fresult = s + fresult;
    }
    return fresult;
}

string MultiplicationBigNumbers(string a, string b)
{
    string result = "";
    int c = 0;
    for(int i = b.Length - 1; i >= 0; i --)
    {
        string localResult = "";
        c = 0;
        for(int j = a.Length - 1; j >= 0; j --)
        {
            int localLocalResult = (a[j] - 48) * (b[i] - 48) + c;
            c = 0;
            while(localLocalResult > 9)
            {
                localLocalResult -= 10;
                c += 1;
            }
            localResult += localLocalResult.ToString();
        }
        if(c > 0)
        {
            localResult += c.ToString();
            c = 0;
        }
        string flocalResult = "";
        foreach(char s in localResult)
        {
            flocalResult = s + flocalResult;
        }
        for(int f = 0; f < b.Length - i - 1; f ++)
        {
            flocalResult += "0";
        }
        result = AdditionBigNumbers(result, flocalResult);
    }
    return result;
}
```

## Progressions / Прогресії / Прогрессии

### Packages / Пакети / Пакеты

`Python`:

```python
a = ArithmeticProgression(start_element, d)
a.get_sequence()
a.get_difference()
a.set_start_element(start_element)
a.set_difference(d)
a.get_nth(n)
a.count_to_nth(n)
a.get_to_nth(n)
a.get_sum_to_nth(n)

b = GeometricProgression(start_element, r)
b.get_sequence()
b.get_ratio()
b.set_start_element(start_element)
b.set_ratio(r)
b.get_nth(n)
b.count_to_nth(n)
b.get_to_nth(n)
b.get_sum_to_nth(n)
b.get_prod_to_nth(n)

c = HarmonicProgression(start_element, d)
c.get_sequence()
c.get_difference()
c.set_start_element(start_element)
c.set_difference(d)
c.get_nth(n)
c.count_to_nth(n)
c.get_to_nth(n)
```

`JavaScript`:

```js
let a = new ArithmeticProgression(startElement, difference);
a.sequence; // get
a.difference; // get/set
a.startElement; // set
a.getNth(n);
a.countToNth(n);
a.getToNth(n);
a.getSumToNth(n);

let b = new GeometricProgression(startElement, ration);
b.sequence; // get
b.ratio; // get/set
b.startElement; // set
b.getNth(n);
b.countToNth(n);
b.getToNth(n);
b.getSumToNth(n);
b.getProdToNth(n);

let c = new HarmonicProgression(startElement, difference);
c.sequence; // get
c.difference; // get/set
c.startElement; // set
c.getNth(n);
c.countToNth(n);
c.getToNth(n);
```

### Files / Файли / Файлы

<ins>***Python:***</ins> *[progressions.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Progressions/progressions.py)*

<ins>***JavaScript:***</ins> *[progressions.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Progressions/progressions.js)*

<ins>***Go:***</ins> *[progressions.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Progressions/progressions.go)*

<ins>***C++:***</ins> *[progressions.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Progressions/progressions.cpp)*

<ins>***C#:***</ins> *[progressions.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Progressions/progressions.cs)*

### Arithmetic progression / Арифметична прогресія / Арифметическая прогрессия

<ins>***Wikipedia:***</ins> *[Arithmetic progression](https://en.wikipedia.org/wiki/Arithmetic_progression)*

<ins>***Вікіпедія:***</ins> *[Арифметична прогресія](https://uk.wikipedia.org/wiki/Арифметична_прогресія)*

<ins>***Википедия:***</ins> *[Арифметическая прогрессия](https://ru.wikipedia.org/wiki/Арифметическая_прогрессия)*

`Python`:

```python
class ArithmeticProgression:

    __d = 0
    __a = []

    def __init__(self, start = 0, d = 0):
        self.__a.append(start)
        self.__d = d

    def get_sequence(self):
        return self.__a

    def get_difference(self):
        return self.__d

    def set_start_element(self, start):
        self.__a = [start]

    def set_difference(self, d):
        self.__a = [self.__a[0]]
        self.__d = d

    def get_nth(self, n):
        return self.__a[0] + (n - 1) * self.__d
    
    def count_to_nth(self, n):
        for _ in range(len(self.__a), n):
            self.__a.append(self.__a[-1] + self.__d)

    def get_to_nth(self, n):
        self.count_to_nth(n)
        return self.__a

    def get_sum_to_nth(self, n):
        return n * (self.__a[0] + self.get_nth(n)) // 2
```

`JavaScript`:

```js
class ArithmeticProgression{
    
    #d = 0;
    #a = [];
    
    constructor(start = 0, d = 0){
        this.#a.push(start);
        this.#d = d;
    }

    get sequence(){
        return this.#a;
    }

    get difference(){
        return this.#d;
    }

    set startElement(start){
        this.#a = [start];
    }

    set difference(d){
        this.#a = [this.#a[0]];
        this.#d = d;
    }

    getNth(n){
        return this.#a[0] + (n - 1) * this.#d;
    }

    countToNth(n){
        for(let _ = this.#a.length; _ < n; _ ++){
            this.#a.push(this.#a[this.#a.length - 1] + this.#d);
        }
    }

    getToNth(n){
        this.countToNth(n);
        return this.#a;
    }

    getSumToNth(n){
        return ~~(n * (this.#a[0] + this.getNth(n)) / 2);
    }
}
```

`Go`:

```go
type Progression interface {
    Nth(int) float64
    ToNth(int) []float64
    SumToNth(int) float64
}

type ArithmeticProgression struct {
    Start      float64
    Difference float64
}

func (ap ArithmeticProgression) Nth(n int) float64 {
    return ap.Start + float64(n-1)*ap.Difference
}

func (ap ArithmeticProgression) ToNth(n int) []float64 {
    a := []float64{ap.Start}
    for i := 1; i < n; i++ {
        a = append(a, a[len(a)-1]+ap.Difference)
    }
    return a
}

func (ap ArithmeticProgression) SumToNth(n int) float64 {
    return float64(n) * (ap.Start + ap.Nth(n)) / 2
}
```

`C++`:

```cpp
#include <vector>

class ArithmeticProgression{

    private:
    
        int d_ = 0;
        std::vector <int> a_;

    public:

        void create(int start = 0, int d = 0){
            a_.push_back(start);
            d_ = d;
        }
        
        std::vector <int> get_sequence(){
            return a_;
        }
        
        int get_difference(){
            return d_;
        }
        
        void set_start_element(int start){
            a_.clear();
            a_.push_back(start);
        }
        
        void set_difference(int d){
            int start = a_[0];
            a_.clear();
            a_.push_back(start);
            d_ = d;
        }

        int get_nth(int n){
            return a_[0] + (n - 1) * d_;
        }

        void count_to_nth(int n){
            for(int _ = a_.size(); _ < n; _ ++){
                a_.push_back(a_[a_.size() - 1] + d_);
            }
        }

        std::vector <int> get_to_nth(int n){
            count_to_nth(n);
            return a_;
        }

        int get_sum_to_nth(int n){
            return n * (a_[0] + get_nth(n)) / 2;
        }
};
```

`C#`:

```cs
class ArithmeticProgression
{
    private int _d = 0;
    private List<int> _a = new List<int>(){};

    public ArithmeticProgression(int start = 0, int d = 0)
    {
        _a.Add(start);
        _d = d;
    }

    public List<int> GetSequence()
    {
        return _a;
    }

    public int GetDifference()
    {
        return _d;
    }

    public void SetStartElement(int start)
    {
        _a.Clear();
        _a.Add(start);
    }

    public void SetDifference(int d)
    {
        int start = _a[0];
        _a.Clear();
        _a.Add(start);
        _d = d;
    }

    public int GetNth(int n)
    {
        return _a[0] + (n - 1) * _d;
    }

    public void CountToNth(int n)
    {
        for(int _ = _a.Count(); _ < n; _ ++)
        {
            _a.Add(_a[^1] + _d);
        }
    }

    public List<int> GetToNth(int n)
    {
        CountToNth(n);
        return _a;
    }

    public int GetSumToNth(int n)
    {
        return n * (_a[0] + GetNth(n)) / 2;
    }
}
```

### Geometric progression / Геометрична прогресія / Геометрическая прогрессия

<ins>***Wikipedia:***</ins> *[Geometric progression](https://en.wikipedia.org/wiki/Geometric_progression)*

<ins>***Вікіпедія:***</ins> *[Геометрична прогресія](https://uk.wikipedia.org/wiki/Геометрична_прогресія)*

<ins>***Википедия:***</ins> *[Геометрическая прогрессия](https://ru.wikipedia.org/wiki/Геометрическая_прогрессия)*

`Python`:

```python
class GeometricProgression:

    __r = 1
    __b = []

    def __init__(self, start = 1, r = 1):
        if start == 0 or r == 0:
            print("start_element or ratio can't be 0")
            return 
        self.__b.append(start)
        self.__r = r

    def get_sequence(self):
        return self.__b

    def get_ratio(self):
        return self.__r

    def set_start_element(self, start):
        if start == 0:
            print("start_element can't be 0")
            return
        self.__b = [start]

    def set_ratio(self, r):
        if r == 0:
            print("ratio can't be 0")
            return
        self.__b = [self.__r[0]]
        self.__r = r

    def get_nth(self, n):
        return self.__b[0] * (self.__r ** (n - 1))
    
    def count_to_nth(self, n):
        for _ in range(len(self.__b), n):
            self.__b.append(self.__b[-1] * self.__r)

    def get_to_nth(self, n):
        self.count_to_nth(n)
        return self.__b

    def get_sum_to_nth(self, n):
        if self.__r == 1: return n * self.__b[0]
        return (self.__b[0] * ((self.__r ** n) - 1)) // (self.__r - 1)

    def get_prod_to_nth(self, n):
        return int((self.__b[0] * self.get_nth(n)) ** (n / 2))
```

`JavaScript`:

```js
class GeometricProgression{
    
    #r = 1;
    #b = [];
    
    constructor(start = 1, r = 1){
        if(start == 0 || r == 0){
            console.log("startElement or ratio can't be 0");
            return; 
        }
        this.#b.push(start);
        this.#r = r;
    }

    get sequence(){
        return this.#b;
    }

    get ratio(){
        return this.#r;
    }

    set startElement(start){
        if(start == 0){
            console.log("startElement can't be 0");
            return; 
        }
        this.#b = [start];
    }

    set ratio(r){
        if(r == 0){
            console.log("ratio can't be 0");
            return; 
        }
        this.#b = [this.#b[0]];
        this.#r = r;
    }

    getNth(n){
        return this.#b[0] * (this.#r ** (n - 1));
    }

    countToNth(n){
        for(let _ = this.#b.length; _ < n; _ ++){
            this.#b.push(this.#b[this.#b.length - 1] * this.#r);
        }
    }

    getToNth(n){
        this.countToNth(n);
        return this.#b;
    }

    getSumToNth(n){
        if(this.#r == 1) return n * this.#b[0];
        return ~~((this.#b[0] * ((this.#r ** n) - 1)) / (this.#r - 1));
    }

    getProdToNth(n){
        return ~~((this.#b[0] * this.get_nth(n)) ** (n / 2));
    }
}
```

`Go`:

```go
type Progression interface {
    Nth(int) float64
    ToNth(int) []float64
    SumToNth(int) float64
}

type GeometricProgression struct {
    Start float64
    Ratio float64
}

func (gp GeometricProgression) Nth(n int) float64 {
    return gp.Start * math.Pow(gp.Ratio, float64(n-1))
}

func (gp GeometricProgression) ToNth(n int) []float64 {
    b := []float64{gp.Start}
    for i := 1; i < n; i++ {
        b = append(b, b[len(b)-1]*gp.Ratio)
    }
    return b
}

func (gp GeometricProgression) SumToNth(n int) float64 {
    if gp.Ratio == 1 {
        return float64(n) * gp.Start
    } else {
        return gp.Start*math.Pow(gp.Ratio, float64(n)) - 1/(gp.Ratio-1)
    }
}
```

`C++`:

```cpp
#include <vector>
#include <math.h>

class GeometricProgression{

    private:
    
        int r_ = 1;
        std::vector <int> b_;
    
    public:

        void create(int start = 1, int r = 1){
            if(start == 0 || r == 0){
                std::cout << "start_element or ratio can't be 0" << std::endl;
                return;
            }
            b_.push_back(start);
            r_ = r;
        }
        
        std::vector <int> get_sequence(){
            return b_;
        }
        
        int get_ratio(){
            return r_;
        }
        
        void set_start_element(int start){
            if(start == 0){
                std::cout << "start_element can't be 0" << std::endl;
                return; 
            }
            b_.clear();
            b_.push_back(start);
        }

        void set_ratio(int r){
            if(r == 0){
                std::cout << "ratio can't be 0" << std::endl;
                return; 
            }
            int start = b_[0];
            b_.clear();
            b_.push_back(start);
            r_ = r;
        }

        int get_nth(int n){
            return b_[0] * std::pow(r_, n - 1);
        }

        void count_to_nth(int n){
            for(int _ = b_.size(); _ < n; _ ++){
                b_.push_back(b_[b_.size() - 1] * r_);
            }
        }

        std::vector <int> get_to_nth(int n){
            count_to_nth(n);
            return b_;
        }

        int get_sum_to_nth(int n){
            if(r_ == 1) return n * b_[0];
            return (b_[0] * (std::pow(r_, n) - 1)) / (r_ - 1);
        }
};
```

`C#`:

```cs
class GeometricProgression
{
    private int _r = 0;
    private List<int> _b = new List<int>(){};

    public GeometricProgression(int start = 1, int r = 1)
    {
        if(start == 0 || r == 0)
        {
            Console.WriteLine("start_element or ratio can't be 0");
            return;
        }
        _b.Add(start);
        _r = r;
    }

    public List<int> GetSequence()
    {
        return _b;
    }

    public int GetRatio()
    {
        return _r;
    }

    public void SetStartElement(int start)
    {
        if(start == 0)
        {
            Console.WriteLine("start_element can't be 0");
            return;
        }
        _b.Clear();
        _b.Add(start);
    }

    public void SetRatio(int r)
    {
        if(r == 0)
        {
            Console.WriteLine("ratio can't be 0");
            return;
        }
        int start = _b[0];
        _b.Clear();
        _b.Add(start);
        _r = r;
    }

    public int GetNth(int n)
    {
        return (int)(_b[0] * Math.Pow(_r, n - 1));
    }

    public void CountToNth(int n)
    {
        for(int _ = _b.Count(); _ < n; _ ++)
        {
            _b.Add(_b[^1] * _r);
        }
    }

    public List<int> GetToNth(int n)
    {
        CountToNth(n);
        return _b;
    }

    public int GetSumToNth(int n)
    {
        return (int)((_b[0] * (Math.Pow(_r, n) - 1)) / (_r - 1));
    }
}
```

### Harmonic progression / Гармонічна прогресія / Гармоническая прогрессия

<ins>***Wikipedia:***</ins> *[Harmonic progression](https://en.wikipedia.org/wiki/Harmonic_progression_(mathematics))*

<ins>***Вікіпедія:***</ins> *[Гармонічна прогресія](https://ewikiuk.top/wiki/Harmonic_progression_(mathematics))*

<ins>***Википедия:***</ins> *[Гармоническая прогрессия](https://ru.wikipedia.org/wiki/Гармоническая_прогрессия)*

`Python`:

```python
class HarmonicProgression:

    __d = 0
    __c = []

    def __init__(self, start = 1, d = 0):
        self.__c.append(start)
        self.__d = d
    
    def get_sequence(self):
        return self.__с

    def get_difference(self):
        return self.__d

    def set_start_element(self, start):
        self.__с = [start]

    def set_difference(self, d):
        self.__с = [self.__с[0]]
        self.__d = d

    def get_nth(self, n):
        return ((self.__c[0] ** -1) + (n - 1) * self.__d) ** -1

    def count_to_nth(self, n):
        for _ in range(len(self.__c), n):
            self.__c.append(((self.__c[-1] ** -1) + self.__d) ** -1)

    def get_to_nth(self, n):
        self.count_to_nth(n)
        return self.__c
```

`JavaScript`:

```js
class HarmonicProgression{
    
    #d = 0;
    #c = [];
    
    constructor(start = 1, d = 0){
        this.#c.push(start);
        this.#d = d;
    }

    get sequence(){
        return this.#c;
    }

    get difference(){
        return this.#d;
    }

    set startElement(start){
        this.#c = [start];
    }

    set difference(d){
        this.#c = [this.#c[0]];
        this.#d = d;
    }

    getNth(n){
        return ((this.#c[0] ** -1) + (n - 1) * this.#d) ** -1;
    }

    countToNth(n){
        for(let _ = this.#c.length; _ < n; _ ++){
            this.#c.push(((this.#c[this.#c.length - 1] ** -1) + this.#d) ** -1);
        }
    }

    getToNth(n){
        this.countToNth(n);
        return this.#c;
    }
}
```

`Go`:

```go
type Progression interface {
    Nth(int) float64
    ToNth(int) []float64
    SumToNth(int) float64
}

type HarmonicProgression struct {
    Start      float64
    Difference float64
}

func (hp HarmonicProgression) Nth(n int) float64 {
    return math.Pow((math.Pow(hp.Start, -1) + float64(n-1)*hp.Difference), -1)
}

func (hp HarmonicProgression) ToNth(n int) []float64 {
    c := []float64{hp.Start}
    for i := 1; i < n; i++ {
        c = append(c, math.Pow((math.Pow(c[len(c)-1], -1)+hp.Difference), -1))
    }
    return c
}

func (hp HarmonicProgression) SumToNth(n int) float64 {
    sum := 0.0
    c := hp.ToNth(n)
    for _, i := range c {
        sum += i
    }
    return sum
}
```

`C++`:

```cpp
#include <vector>
#include <math.h>

class HarmonicProgression{

    private:
    
        int d_ = 0;
        std::vector <float> c_;
    
    public:
        
        void create(float start = 1.0, int d = 0){
            c_.push_back(start);
            d_ = d;
        }
        
        std::vector <float> get_sequence(){
            return c_;
        }
        
        int get_difference(){
            return d_;
        }
        
        void set_start_element(float start){
            c_.clear();
            c_.push_back(start);
        }
        
        void set_difference(int d){
            float start = c_[0];
            c_.clear();
            c_.push_back(start);
            d_ = d;
        }

        float get_nth(int n){
            return std::pow((std::pow(c_[0], -1) + (n - 1) * d_), -1);
        }

        void count_to_nth(int n){
            for(int _ = c_.size(); _ < n; _ ++){
                c_.push_back(std::pow((std::pow(c_[c_.size() - 1], -1) + d_), -1));
            }
        }

        std::vector <float> get_to_nth(int n){
            count_to_nth(n);
            return c_;
        }
};
```

`C#`:

```cs
class HarmonicProgression
{
    private int _d = 0;
    private List<float> _c = new List<float>(){};

    public HarmonicProgression(float start = 1.0f, int d = 0)
    {
        _c.Add(start);
        _d = d;
    }

    public List<float> GetSequence()
    {
        return _c;
    }

    public int GetDifference()
    {
        return _d;
    }

    public void SetStartElement(int start)
    {
        _c.Clear();
        _c.Add(start);
    }

    public void SetDifference(int d)
    {
        float start = _c[0];
        _c.Clear();
        _c.Add(start);
        _d = d;
    }

    public float GetNth(int n)
    {
        return (float)Math.Pow((Math.Pow(_c[0], -1) + (n - 1) * _d), -1);
    }

    public void CountToNth(int n)
    {
        for(int _ = _c.Count(); _ < n; _ ++)
        {
            _c.Add((float)Math.Pow((Math.Pow(_c[^1], -1) + _d), -1));
        }
    }

    public List<float> GetToNth(int n)
    {
        CountToNth(n);
        return _c;
    }
}
```

## Linked list / Зв'язаний список / Связный список

### Packages / Пакети / Пакеты

`Python`:

```python
linkedList = LinkedList()
linkedList.add(value)
linkedList.shift()
linkedList.pop()
linkedList.remove(n)
linkedList.get_node(n)
linkedList.get(n)
```

`JavaScript`:

```js
let linkedList = LinkedList()
linkedList.add(value)
linkedList.shift()
linkedList.pop()
linkedList.remove(n)
linkedList.getNode(n)
linkedList.get(n)
```

<ins>***Wikipedia:***</ins> *[Linked list](https://en.wikipedia.org/wiki/Linked_list)*

<ins>***Вікіпедія:***</ins> *[Зв'язаний список](https://uk.wikipedia.org/wiki/Зв%27язаний_список)*

<ins>***Википедия:***</ins> *[Связный список](https://ru.wikipedia.org/wiki/Связный_список)*

### Files / Файли / Файлы

<ins>***Python:***</ins> *[linked-list.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Linked%20list/linked-list.py)*

<ins>***JavaScript:***</ins> *[linked-list.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Linked%20list/linked-list.js)*

<ins>***Go:***</ins> *[linked-list.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Linked%20list/linked-list.go)*

<ins>***C++:***</ins> *[linked-list.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Linked%20list/linked-list.cpp)*

<ins>***C#:***</ins> *[linked-list.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Linked%20list/linked-list.cs)*

`Python`:

```python
from typing import Any

class Node:

    value = None
    prev = None
    next = None

    def __init__(self, value, prev = None, next = None) -> None:
        self.value = value
        self.prev = prev
        self.next = next

class LinkedList:

    head: Node = None
    tail: Node = None
    length: int = 0

    def __init__(self, value: int = None) -> None:
        if value != None:
            self.head = Node(value, None, None)
            self.length = 1
        else:
            self.head = None
            self.length = 0
        self.tail = None

    def add(self, value: int) -> None:
        if self.head == None:
            self.head = Node(value, None, None)
        elif self.tail == None:
            self.tail = Node(value, self.head, None)
            self.head.next = self.tail
        else:
            self.tail.next = Node(value, self.tail, None)
            self.tail = self.tail.next
        self.length += 1

    def shift(self) -> None:
        self.head = self.head.next
        self.length -= 1

    def pop(self) -> None:
        if self.length == 1:
            self.shift()
        else:
            self.tail.prev = None
            self.tail = self.tail.prev
            self.length -= 1

    def remove(self, n: int) -> None:
        if n < 0:
            n = self.length + n
        if self.length == 0:
            raise "List is empty"
        if n >= self.length:
            raise "Index is bigger than length"
        if n == 0:
            self.shift()
        elif n == self.length - 1:
            self.pop()
        elif n < self.length / 2:
            node = self.head
            for _ in range(0, n):
                node = node.next
            node.next.prev = node.prev
            node.prev.next = node.next
            self.length -= 1
        else:
            node = self.tail
            for _ in range(self.length - 1, n, -1):
                node = node.prev
            node.next.prev = node.prev
            node.prev.next = node.next
            self.length -= 1
    
    def get_node(self, n: int) -> Node:
        if n < 0:
            n = self.length + n
        if self.length == 0:
            raise "List is empty"
        if n >= self.length:
            raise "Index is bigger than length"
        if n == 0:
            return self.head
        elif n == self.length - 1:
            return self.tail
        elif n < self.length / 2:
            node = self.head
            for _ in range(0, n):
                node = node.next
            return node
        else:
            node = self.tail
            for _ in range(self.length - 1, n, -1):
                node = node.prev
            return node
    
    def get(self, n: int) -> Any:
        return self.get_node(n)
```

`JavaScript`:

```js
class Node{
    
    value = undefined;
    prev = undefined;
    next = undefined;

    constructor(value, prev = undefined, next = undefined){
        this.value = value;
        this.prev = prev;
        this.next = next;
    }

}

class LinkedList{

    head = undefined;
    tail = undefined;
    length = 0;

    constructor(value = undefined){
        if(value != undefined){
            this.head = new Node(value, undefined, undefined);
            this.length = 1;
        }
        else{
            this.head = undefined;
            this.length = 0;
        }
        this.tail = undefined;
    }

    add(value){
        if(this.head == undefined){
            this.head = new Node(value, undefined, undefined);
        }
        else if(this.tail == undefined){
            this.tail = new Node(value, this.head, undefined);
            this.head.next = this.tail;
        }
        else{
            this.tail.next = new Node(value, this.tail, undefined);
            this.tail = this.tail.next;
        }
        this.length ++;
    }

    shift(){
        this.head = this.head.next;
        this.length --;
    }

    pop(){
        if(this.length == 1){
            this.shift();
        }
        else{
            this.tail.prev = undefined;
            this.tail = this.tail.prev;
            this.length --;
        }
    }

    remove(n){
        if(n < 0){
            n = this.length + n;
        }
        if(this.length == 0){
            throw "List is empty";
        }
        if(n >= this.length){
            throw "Index is bigger than length";
        }
        if(n == 0){
            this.shift();
        }
        else if(n == this.length - 1){
            this.pop();
        }
        else if(n < this.length / 2){
            let node = this.head;
            for(let _ = 0; _ < n; _ ++){
                node = node.next;
            }
            node.next.prev = node.prev;
            node.prev.next = node.next;
            this.length --;
        }
        else{
            let node = this.tail;
            for(let _ = this.length - 1; _ > n; _ --){
                node = node.prev;
            }
            node.next.prev = node.prev;
            node.prev.next = node.next;
            this.length --;
        }
    }

    getNode(n){
        if(n < 0){
            n = this.length + n;
        }
        if(this.length == 0){
            throw "List is empty";
        }
        if(n >= this.length){
            throw "Index is bigger than length";
        }
        if(n == 0){
            return this.head;
        }
        else if(n == this.length - 1){
            return this.tail;
        }
        else if(n < this.length / 2){
            let node = this.head;
            for(let _ = 0; _ < n; _ ++){
                node = node.next;
            }
            return node;
        }
        else{
            let node = this.tail;
            for(let _ = this.length - 1; _ > n; _ --){
                node = node.prev;
            }
            return node;
        }
    }

    get(n){
        return this.getNode(n);
    }

}
```

`Go`:

```go
type Node[T any] struct {
	Value T
	Prev  *Node[T]
	Next  *Node[T]
}

type LinkedList[T any] struct {
	Head   *Node[T]
	Tail   *Node[T]
	Length uint
}

func NewEmptyLinkedList[T any]() LinkedList[T] {
	return LinkedList[T]{nil, nil, 0}
}

func NewLinkedList[T any](value T) LinkedList[T] {
	return LinkedList[T]{&Node[T]{value, nil, nil}, nil, 1}
}

func (ll *LinkedList[T]) Add(value T) {
	if ll.Head == nil {
		ll.Head = &Node[T]{value, nil, nil}
	} else if ll.Tail == nil {
		ll.Tail = &Node[T]{value, ll.Head, nil}
		ll.Head.Next = ll.Tail
	} else {
		ll.Tail.Next = &Node[T]{value, ll.Tail, nil}
		ll.Tail = ll.Tail.Next
	}
	ll.Length++
}

func (ll *LinkedList[T]) Shift() {
	ll.Head = ll.Head.Next
	ll.Length--
}

func (ll *LinkedList[T]) Pop() {
	if ll.Length == 1 {
		ll.Shift()
	} else {
		ll.Tail.Prev.Next = nil
		ll.Tail = ll.Tail.Prev
		ll.Length--
	}
}

func (ll *LinkedList[T]) Remove(n int) {
	if n < 0 {
		n = int(ll.Length) + n
	}
	if ll.Length == 0 {
		panic("List is empty")
	}
	if n >= int(ll.Length) {
		panic("Index is bigger than length")
	}
	if n == 0 {
		ll.Shift()
	} else if n == int(ll.Length)-1 {
		ll.Pop()
	} else if n < int(ll.Length)/2 {
		node := ll.Head
		for i := 0; i < n; i++ {
			node = node.Next
		}
		node.Next.Prev = node.Prev
		node.Prev.Next = node.Next
		ll.Length--
	} else {
		node := ll.Tail
		for i := int(ll.Length) - 1; i > n; i-- {
			node = node.Prev
		}
		node.Next.Prev = node.Prev
		node.Prev.Next = node.Next
		ll.Length--
	}
}

func (ll *LinkedList[T]) GetNode(n int) *Node[T] {
	if n < 0 {
		n = int(ll.Length) + n
	}
	if ll.Length == 0 {
		panic("List is empty")
	}
	if n >= int(ll.Length) {
		panic("Index is bigger than length")
	}
	if n == 0 {
		return ll.Head
	} else if n == int(ll.Length)-1 {
		return ll.Tail
	} else if n < int(ll.Length)/2 {
		node := ll.Head
		for i := 0; i < n; i++ {
			node = node.Next
		}
		return node
	} else {
		node := ll.Tail
		for i := int(ll.Length) - 1; i > n; i-- {
			node = node.Prev
		}
		return node
	}
}

func (ll *LinkedList[T]) Get(n int) T {
	return ll.GetNode(n).Value
}
```

`C++`

```cpp
template <typename T>

class Node{

    public:

        T value;
        Node<T>* prev = NULL;
        Node<T>* next = NULL;
        Node(T v, Node<T>* p = NULL, Node<T>* n = NULL){
            value = v;
            prev = p;
            next = n;
        }
};

template <typename T>

class LinkedList{
    
    public:

        Node<T>* head = NULL;
        Node<T>* tail = NULL;
        unsigned int length = 0;

        LinkedList(){
            head = NULL;
            length = 0;
            tail = NULL;
        }

        LinkedList(T value){
            head = new Node<T>(value);
            length = 1;
            tail = NULL;
        }

        void add(T value){
            if(head == NULL){
                head = new Node(value);
            }
            else if(tail == NULL){
                tail = new Node(value, head);
                head->next = tail;
            }
            else{
                tail->next = new Node(value, tail);
                tail = tail->next;
            }
            length ++;
        }

        void shift(){
            head = head->next;
            length --;
        }

        void pop(){
            if(length == 1){
                shift();
            }
            else{
                tail->prev = NULL;
                tail = tail->prev;
                length --;
            }
        }

        void remove(int n){
            if(n < 0){
                n = length + n;
            }
            if(length == 0){
                throw "List is empty";
            }
            if(n >= length){
                throw "Index is bigger than length";
            }
            if(n == 0){
                shift();
            }
            else if(n == length - 1){
                pop();
            }
            else if(n < length / 2){
                Node<T>* node = head;
                for(int _ = 0; _ < n; _ ++){
                    node = node->next;
                }
                node->next->prev = node->prev;
                node->prev->next = node->next;
                length --;
            }
            else{
                Node<T>* node = tail;
                for(int _ = length - 1; _ > n; _ --){
                    node = node->prev;
                }
                node->next->prev = node->prev;
                node->prev->next = node->next;
                length --;
            }
        }

        Node<T>* getNode(int n){
            if(n < 0){
                n = length + n;
            }
            if(length == 0){
                throw "List is empty";
            }
            if(n >= length){
                throw "Index is bigger than length";
            }
            if(n == 0){
                return head;
            }
            else if(n == length - 1){
                return tail;
            }
            else if(n < length / 2){
                Node<T>* node = head;
                for(int _ = 0; _ < n; _ ++){
                    node = node->next;
                }
                return node;
            }
            else{
                Node<T>* node = tail;
                for(int _ = length - 1; _ > n; _ --){
                    node = node->prev;
                }
                return node;
            }
        }

        T get(int n){
            return getNode(n);
        }

};
```

`C#`:

```cs
class Node<T>
{
    public T value;
    public Node<T> next;
    public Node<T> prev;

    public Node(T v, Node<T> p = null, Node<T> n = null)
    {
        this.value = v;
        this.prev = p;
        this.next = n;
    }

}

class LinkedList<T>
{
    public Node<T> head;
    public Node<T> tail;
    public uint length;

    public LinkedList()
    {
        this.head = null;
        this.length = 0;
        this.tail = null;
    }

    public LinkedList(T value)
    {
        this.head = new Node<T>(value);
        this.length = 1;
        this.tail = null;
    }

    public void Add(T value)
    {
        if(this.head == null)
        {
            this.head = new Node(value);
        }
        else if(this.tail == NULL)
        {
            this.tail = new Node(value, this.head);
            this.head.next = this.tail;
        }
        else
        {
            this.tail.next = new Node(value, this.tail);
            this.tail = this.tail.next;
        }
        this.length ++;
    }

    public void Shift()
    {
        this.head = this.head.next;
        this.length --;
    }

    public void Pop()
    {
        if(this.length == 1)
        {
            this.Shift();
        }
        else
        {
            this.tail.prev = null;
            this.tail = this.tail.prev;
            this.length --;
        }
    }

    public void Remove(int n)
    {
        if(n < 0)
        {
            n = this.length + n;
        }
        if(this.length == 0)
        {
            throw new Exception("List is empty");
        }
        if(n >= this.length)
        {
            throw new Exception("Index is bigger than length");
        }
        if(n == 0)
        {
            this.Shift();
        }
        else if(n == this.length - 1)
        {
            this.Pop();
        }
        else if(n < this.length / 2)
        {
            Node<T> node = this.head;
            for(int _ = 0; _ < n; _ ++)
            {
                node = node.next;
            }
            node.next.prev = node.prev;
            node.prev.next = node.next;
            this.length --;
        }
        else
        {
            Node<T> node = this.tail;
            for(int _ = this.length - 1; _ > n; _ --)
            {
                node = node.prev;
            }
            node.next.prev = node.prev;
            node.prev.next = node.next;
            this.length --;
        }
    }

    public void GetNode(int n)
    {
        if(n < 0)
        {
            n = this.length + n;
        }
        if(this.length == 0)
        {
            throw new Exception("List is empty");
        }
        if(n >= this.length)
        {
            throw new Exception("Index is bigger than length");
        }
        if(n == 0)
        {
            return this.head;
        }
        else if(n == this.length - 1)
        {
            return this.tail;
        }
        else if(n < this.length / 2)
        {
            Node<T> node = this.head;
            for(int _ = 0; _ < n; _ ++)
            {
                node = node.next;
            }
            return node;
        }
        else
        {
            Node<T> node = this.tail;
            for(int _ = this.length - 1; _ > n; _ --)
            {
                node = node.prev;
            }
            return node;
        }
    }

    public void Get(int n)
    {
        return this.GetNode(n);
    }
}
```

## Binary search tree / Двійкове дерево пошуку / Двоичное дерево поиска

### Packages / Пакети / Пакеты

`Python`:

```python
tree = Tree()
tree.get_min()
tree.get_max()
tree.add(v)
tree.remove_min()
tree.remove_max()
tree.remove(v)
tree.create(arr)
tree.get_tree_by_levels()
tree.get_tree_list()
tree.get_tree_by_nodes()
tree.get_tree_sorted()
```

`JavaScript`:

```js
let tree = new Tree()
tree.min // get
tree.max // get
tree.add(v)
tree.removeMin()
tree.removeMax()
tree.remove(v)
tree.create(arr)
tree.treeByLevels //get
tree.treeList //get
tree.treeByNodes //get
tree.treeSorted //get
tree.treeSortedReverse //get
```

<ins>***Wikipedia:***</ins> *[Binary search tree](https://en.wikipedia.org/wiki/Binary_search_tree)*

<ins>***Вікіпедія:***</ins> *[Двійкове дерево пошуку](https://uk.wikipedia.org/wiki/Двійкове_дерево_пошуку)*

<ins>***Википедия:***</ins> *[Двоичное дерево поиска](https://ru.wikipedia.org/wiki/Двоичное_дерево_поиска)*

### Files / Файли / Файлы

<ins>***Python:***</ins> *[binary-search-tree.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Binary%20search%20tree/binary-search-tree.py)*

<ins>***JavaScript:***</ins> *[binary-search-tree.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Binary%20search%20tree/binary-search-tree.js)*

<ins>***Go:***</ins> *[binary-search-tree.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Binary%20search%20tree/binary-search-tree.go)*

<ins>***C++:***</ins> *[binary-search-tree.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Binary%20search%20tree/binary-search-tree.cpp)*

<ins>***C#:***</ins> *[binary-search-tree.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Binary%20search%20tree/binary-search-tree.cs)*

`Python`:

```python
class Node:

    value = None
    height = None
    left = None
    right = None

    def __init__(self, value: int = None, height: int = 1, left = None, right = None) -> None:
        self.value = value
        self.height = height
        self.left = left
        self.right = right

class Tree:

    __head = None

    def __init__(self, head: int = None) -> None:
        if head != None:
            self.__head = Node(head)

    def __fix_height(self, node: Node) -> None:
        hl = node.left.height if node.left != None else 0
        hr = node.right.height if node.right != None else 0 
        node.height = (hl if hl > hr else hr) + 1

    def __rotate_right(self, node: Node) -> Node:
        v = node.left
        node.left = v.right
        v.right = node
        self.__fix_height(node)
        self.__fix_height(v)
        return v

    def __rotate_left(self, node: Node) -> Node:
        v = node.right
        node.right = v.left
        v.left = node
        self.__fix_height(node)
        self.__fix_height(v)
        return v

    def __b_factor(self, node: Node) -> int:
        return (node.right.height if node.right != None else 0) - (node.left.height if node.left != None else 0)

    def __balance(self, node: Node) -> Node:
        self.__fix_height(node)
        if self.__b_factor(node) == 2:
            if self.__b_factor(node.right) < 0:
                node.right = self.__rotate_right(node.right)
            return self.__rotate_left(node)
        elif self.__b_factor(node) == -2:
            if self.__b_factor(node.left) > 0:
                node.left = self.__rotate_left(node.left)
            return self.__rotate_right(node)
        return node

    def __get_min_node(self, node: Node) -> Node:
        if node.left != None:
            return self.__get_min_node(node.left)
        else:
            return node

    def get_min(self) -> int:
        if self.__head.left != None:
            return self.__get_min_node(self.__head.left)
        else:
            return self.__head.value

    def __get_max_node(self, node: Node) -> Node:
        if node.right != None:
            return self.__get_max_node(node.right)
        else:
            return node

    def get_max(self) -> int:
        if self.__head.right != None:
            return self.__get_max_node(self.__head.right)
        else:
            return self.__head.value

    def __add_node(self, v: int, node: Node) -> None:
        if node == None:
            return Node(v)
        if v < node.value:
            node.left = self.__add_node(v, node.left)
        else:
            node.right = self.__add_node(v, node.right)
        return self.__balance(node)

    def add(self, v: int) -> None:
        self.__head = self.__add_node(v, self.__head)

    def __remove_min_node(self, node: Node) -> Node:
        if node.left == None:
            return node.right
        node.left = self.__remove_min_node(node.left)
        return self.__balance(node)

    def remove_min(self) -> None:
        self.__head = self.__remove_min_node(self.__head)

    def __remove_max_node(self, node: Node) -> Node:
        if node.right == None:
            return node.left
        node.right = self.__remove_max_node(node.right)
        return self.__balance(node)

    def remove_max(self) -> None:
        self.__head = self.__remove_max_node(self.__head)

    def __remove_node(self, v: int, node: Node) -> Node:
        if node == None:
            return None
        if v < node.value:
            node.left = self.__remove_node(v, node.left)
        elif v > node.value:
            node.right = self.__remove_node(v, node.right)
        else:
            l = node.left
            r = node.right
            if r == None:
                return l
            min = self.__get_min_node(r)
            min.right = self.__remove_min_node(r)
            min.left = l
            return self.__balance(min)
        return self.__balance(node)

    def remove(self, v: int) -> Node:
        self.__head = self.__remove_node(v, self.__head)

    def create(self, arr: list) -> None:
        self.__head = Node(arr[0])
        for a in arr[1:]:
            self.add(a)

    def __bfs(self) -> list:
        q = [[self.__head, 0]]
        p = []
        while len(q) > 0:
            v = q.pop()
            p.append([v[0].value, v[1]])
            if v[0].right != None:
                q.append([v[0].right, v[1] + 1])
            if v[0].left != None:
                q.append([v[0].left, v[1] + 1])
        return p

    def get_tree_by_levels(self) -> list:
        p = self.__bfs()
        max_p = -1
        for m in p:
            if max_p < m[1]:
                max_p = m[1]
        res = [[] for _ in range(0, max_p + 1)]
        for n in p:
            res[n[1]].append(n[0])
        return res

    def get_tree_list(self) -> list:
        p = self.__bfs()
        res = []
        for n in p:
            res.append(n[0])
        return res

    def __dfs_nodes(self, node: Node, p: dict) -> None:
        p[node.value] = []
        if node.left != None:
            p[node.value].append(node.left.value)
            self.__dfs_nodes(node.left, p)
        if node.right != None:
            p[node.value].append(node.right.value)
            self.__dfs_nodes(node.right, p)

    def get_tree_by_nodes(self) -> dict:
        p = {}
        self.__dfs_nodes(self.__head, p)
        return p

    def __dfs_plain(self, node: Node, p: list) -> None:
        if node.left != None:
            self.__dfs_plain(node.left, p)
        p.append(node.value)
        if node.right != None:
            self.__dfs_plain(node.right, p)
    
    def __dfs_reverse(self, node: Node, p: list) -> None:
        if node.right != None:
            self.__dfs_reverse(node.right, p)
        p.append(node.value)
        if node.left != None:
            self.__dfs_reverse(node.left, p)

    def get_tree_sorted(self, reverse: bool = False) -> list:
        p = []
        if reverse:
            self.__dfs_reverse(self.__head, p)
        else:
            self.__dfs_plain(self.__head, p)
        return p
```

`JavaScript`:

```js
class Node{

    value = undefined;
    height = undefined;
    left = undefined;
    right = undefined;

    constructor(value = undefined, height = 1, left = undefined, right = undefined){
        this.value = value;
        this.height = height;
        this.left = left;
        this.right = right;
    }
}

class Tree{

    #head = undefined;

    constructor(head = undefined){
        if(head != undefined){
            this.#head = head;
        }
    }

    #fixHeight(node){
        let hl = node.left != undefined ? node.left.height : 0;
        let hr = node.right != undefined ? node.right.height : 0;
        node.height = (hl > hr ? hl : hr) + 1;
    }

    #rotateRight(node){
        let v = node.left;
        node.left = v.right;
        v.right = node;
        this.#fixHeight(node);
        this.#fixHeight(v);
        return v;
    }

    #rotateLeft(node){
        let v = node.right;
        node.right = v.left;
        v.left = node;
        this.#fixHeight(node);
        this.#fixHeight(v);
        return v;
    }

    #bFactor(node){
        return (node.right != undefined ? node.right.height : 0) - (node.left != undefined ? node.left.height : 0);
    }

    #balance(node){
        this.#fixHeight(node);
        if(this.#bFactor(node) == 2){
            if(this.#bFactor(node.right) < 0){
                node.right = this.#rotateRight(node.right);
            }
            return this.#rotateLeft(node);
        }
        else if(this.#bFactor(node) == -2){
            if(this.#bFactor(node.left) > 0){
                node.left = this.#rotateLeft(node.left);
            }
            return this.#rotateRight(node);
        }
        return node;
    }

    #getMinNode(node){
        if(node.left != undefined){
            return this.#getMinNode(node.left);
        }
        else{
            return node;
        }
    }

    get min(){
        if(this.#head.left != undefined){
            return this.#getMinNode(this.#head.left);
        }
        else{
            return this.#head.value;
        }
    }

    #getMaxNode(node){
        if(node.right != undefined){
            return this.#getMaxNode(node.right);
        }
        else{
            return node;
        }
    }

    get max(){
        if(this.#head.right != undefined){
            return this.#getMaxNode(this.#head.right);
        }
        else{
            return this.#head.value;
        }
    }

    #addNode(v, node){
        if(node == undefined){
            return new Node(v);
        }
        if(v < node.value){
            node.left = this.#addNode(v, node.left);
        }
        else{
            node.right = this.#addNode(v, node.right);
        }
        return this.#balance(node);
    }

    add(v){
        this.#head = this.#addNode(v, this.#head);
    }

    #removeMinNode(node){
        if(node.left == undefined){
            return node.right;
        }
        node.left = this.#removeMinNode(node.left);
        return this.#balance(node);
    }

    removeMin(){
        this.#head = this.#removeMinNode(this.#head);
    }

    #removeMaxNode(node){
        if(node.right == undefined){
            return node.left;
        }
        node.right = this.#removeMaxNode(node.right);
        return this.#balance(node);
    }

    removeMax(){
        this.#head = this.#removeMaxNode(this.#head);
    }

    #removeNode(v, node){
        if(node == undefined){
            return undefined;
        }
        if(v < node.value){
            node.left = this.#removeNode(v, node.left);
        }
        else if(v > node.value){
            node.right = this.#removeNode(v, node.right);
        }
        else{
            let l = node.left;
            let r = node.right;
            if(r == undefined){
                return l;
            }
            let min = this.#getMinNode(r);
            min.right = this.#removeMinNode(r);
            min.left = l;
            return this.#balance(min);
        }
        return this.#balance(node);
    }

    remove(v){
        this.#head = this.#removeNode(v, this.#head);
    }

    create(arr){
        this.#head = new Node(arr[0]);
        for(let a of arr.slice(1, arr.length)){
            this.add(a);
        }
    }

    #bfs(){
        let q = [[this.#head, 0]];
        let p = [];
        while(q.length > 0){
            let v = q.pop();
            p.push([v[0].value, v[1]]);
            if(v[0].right != undefined){
                q.push([v[0].right, v[1] + 1]);
            }
            if(v[0].left != undefined){
                q.push([v[0].left, v[1] + 1]);
            }
        }
        return p;
    }

    get treeByLevels(){
        let p = this.#bfs();
        let res = [];
        let maxP = -1;
        for(let n of p){
            if(maxP < n[1]){
                maxP = n[1]
            }
        }
        for(let _ = 0; _ <= maxP; _ ++){
            res.push([]);
        }
        for(let n of p){
            res[n[1]].push(n[0]);
        }
        return res;
    }

    get treeList(){
        let p = this.#bfs();
        let res = [];
        for(let n of p){
            res.push(n[0]);
        }
        return res;
    }

    #dfsNodes(node, p){
        p[node.value] = [];
        if(node.left != undefined){
            p[node.value].push(node.left.value);
            this.#dfsNodes(node.left, p);
        }
        if(node.right != undefined){
            p[node.value].push(node.right.value);
            this.#dfsNodes(node.right, p);
        }
    }

    get treeByNodes(){
        let p = {};
        this.#dfsNodes(this.#head, p);
        return p;
    }

    #dfsPlain(node, p){
        if(node.left != undefined){
            this.#dfsPlain(node.left, p);
        }
        p.push(node.value);
        if(node.right != undefined){
            this.#dfsPlain(node.right, p);
        }
    }

    #dfsReverse(node, p){
        if(node.right != undefined){
            this.#dfsReverse(node.right, p);
        }
        p.push(node.value);
        if(node.left != undefined){
            this.#dfsReverse(node.left, p);
        }
    }

    get treeSorted(){
        let p = [];
        this.#dfsPlain(this.#head, p);
        return p;
    }

    get treeSortedReverse(){
        let p = [];
        this.#dfsReverse(this.#head, p);
        return p;
    }
}
```

`Go`:

```go
type Pair[T1 any, T2 any] struct {
    First  T1
    Second T2
}

type Number interface {
    int | int8 | int16 | int32 | int64 | uint | uint8 | uint16 | uint32 | uint64 | float32 | float64
}

type Node[T Number] struct {
    Value  T
    Left   *Node[T]
    Right  *Node[T]
    Height uint
}

type Tree[T Number] struct {
    Head *Node[T]
}

func NewTree[T Number]() Tree[T] {
    t := Tree[T]{nil}
    return t
}

func NewHeadTree[T Number](head *Node[T]) Tree[T] {
    t := Tree[T]{head}
    return t
}

func (t Tree[T]) FixHeight(node *Node[T]) {
    var hl, hr uint
    if node.Left != nil {
        hl = node.Left.Height
    } else {
        hl = 0
    }
    if node.Right != nil {
        hr = node.Right.Height
    } else {
        hr = 0
    }
    if hl > hr {
        node.Height = hl + 1
    } else {
        node.Height = hr + 1
    }
}

func (t Tree[T]) RotateRight(node *Node[T]) *Node[T] {
    v := node.Left
    node.Left = v.Right
    v.Right = node
    t.FixHeight(node)
    t.FixHeight(v)
    return v
}

func (t Tree[T]) RotateLeft(node *Node[T]) *Node[T] {
    v := node.Right
    node.Right = v.Left
    v.Left = node
    t.FixHeight(node)
    t.FixHeight(v)
    return v
}

func (t Tree[T]) BFactor(node *Node[T]) int {
    if node.Left != nil && node.Right != nil {
        return int(node.Right.Height) - int(node.Left.Height)
    } else if node.Left != nil {
        return -int(node.Left.Height)
    } else if node.Right != nil {
        return int(node.Right.Height)
    }
    return 0
}

func (t Tree[T]) Balance(node *Node[T]) *Node[T] {
    t.FixHeight(node)
    if t.BFactor(node) == 2 {
        if t.BFactor(node.Right) < 0 {
            node.Right = t.RotateRight(node.Right)
        }
        return t.RotateLeft(node)
    } else if t.BFactor(node) == -2 {
        if t.BFactor(node.Left) > 0 {
            node.Left = t.RotateLeft(node.Left)
        }
        return t.RotateRight(node)
    }
    return node
}

func (t Tree[T]) MinNode(node *Node[T]) *Node[T] {
    if node.Left != nil {
        return t.MinNode(node.Left)
    } else {
        return node
    }
}

func (t Tree[T]) Min() T {
    if t.Head.Left != nil {
        return t.MinNode(t.Head.Left).Value
    } else {
        return t.Head.Value
    }
}

func (t Tree[T]) MaxNode(node *Node[T]) *Node[T] {
    if node.Right != nil {
        return t.MinNode(node.Right)
    } else {
        return node
    }
}

func (t Tree[T]) Max() T {
    if t.Head.Right != nil {
        return t.MinNode(t.Head.Right).Value
    } else {
        return t.Head.Value
    }
}

func (t Tree[T]) AddNode(v T, node *Node[T]) *Node[T] {
    if node == nil {
        return &Node[T]{v, nil, nil, 1}
    }
    if v < node.Value {
        node.Left = t.AddNode(v, node.Left)
    } else {
        node.Right = t.AddNode(v, node.Right)
    }
    return t.Balance(node)
}

func (t *Tree[T]) Add(v T) {
    t.Head = t.AddNode(v, t.Head)
}

func (t Tree[T]) RemoveMinNode(node *Node[T]) *Node[T] {
    if node.Left == nil {
        return node.Right
    }
    node.Left = t.RemoveMinNode(node.Left)
    return t.Balance(node)
}

func (t *Tree[T]) RemoveMin() {
    t.Head = t.RemoveMinNode(t.Head)
}

func (t Tree[T]) RemoveMaxNode(node *Node[T]) *Node[T] {
    if node.Right == nil {
        return node.Left
    }
    node.Left = t.RemoveMaxNode(node.Left)
    return t.Balance(node)
}

func (t *Tree[T]) RemoveMax() {
    t.Head = t.RemoveMaxNode(t.Head)
}

func (t Tree[T]) RemoveNode(v T, node *Node[T]) *Node[T] {
    if node == nil {
        return nil
    }
    if v < node.Value {
        node.Left = t.RemoveNode(v, node.Left)
    } else if v > node.Value {
        node.Right = t.RemoveNode(v, node.Right)
    } else {
        l := node.Left
        r := node.Right
        if r == nil {
            return l
        }
        min := t.MinNode(r)
        min.Right = t.RemoveMinNode(r)
        min.Left = l
        return t.Balance(min)
    }
    return t.Balance(node)
}

func (t *Tree[T]) Remove(v T) {
    t.Head = t.RemoveNode(v, t.Head)
}

func NewArrTree[T Number](arr []T) Tree[T] {
    t := Tree[T]{&Node[T]{arr[0], nil, nil, 1}}
    for i := 1; i < len(arr); i++ {
        t.Add(arr[i])
    }
    return t
}

func (t Tree[T]) BFS() []Pair[T, int] {
    q := []Pair[*Node[T], int]{{t.Head, 0}}
    p := []Pair[T, int]{}
    for len(q) > 0 {
        v := q[len(q)-1]
        q = q[:len(q)-1]
        p = append(p, Pair[T, int]{v.First.Value, v.Second})
        if v.First.Right != nil {
            q = append(q, Pair[*Node[T], int]{v.First.Right, v.Second + 1})
        }
        if v.First.Left != nil {
            q = append(q, Pair[*Node[T], int]{v.First.Left, v.Second + 1})
        }
    }
    return p
}

func (t Tree[T]) TreeByLevels() [][]T {
    p := t.BFS()
    res := [][]T{{}}
    maxP := -1
    for _, m := range p {
        if maxP < m.Second {
            maxP = m.Second
        }
    }
    for i := 0; i <= maxP; i++ {
        res = append(res, []T{})
    }
    for _, n := range p {
        res[n.Second] = append(res[n.Second], n.First)
    }
    return res
}

func (t Tree[T]) TreeList() []T {
    p := t.BFS()
    res := []T{}
    for _, n := range p {
        res = append(res, n.First)
    }
    return res
}

func (t Tree[T]) DFSPlain(node *Node[T], p *[]T) {
    if node.Left != nil {
        t.DFSPlain(node.Left, p)
    }
    *p = append(*p, node.Value)
    if node.Right != nil {
        t.DFSPlain(node.Right, p)
    }
}

func (t Tree[T]) DFSReverse(node *Node[T], p *[]T) {
    if node.Right != nil {
        t.DFSReverse(node.Right, p)
    }
    *p = append(*p, node.Value)
    if node.Left != nil {
        t.DFSReverse(node.Left, p)
    }
}

func (t Tree[T]) TreeSorted() []T {
    p := []T{}
    t.DFSPlain(t.Head, &p)
    return p
}

func (t Tree[T]) TreeSortedReverse() []T {
    p := []T{}
    t.DFSReverse(t.Head, &p)
    return p
}
```

`C++`:

```cpp
#include <vector>

class Node{

    public:

        int value;
        unsigned int height;
        Node* left;
        Node* right;
        Node(int d){
            value = d;
            height = 1;
            left = NULL;
            right = NULL;
        }
};

class Tree{

    private:

        Node* head_;

        void fix_height_(Node* node){
            unsigned int hl = node->left != NULL ? node->left->height : 0;
            unsigned int hr = node->right != NULL ? node->right->height : 0;
            node->height = (hl > hr ? hl : hr) + 1;
        }

        Node* rotate_right_(Node* node){
            Node* v = node->left;
            node->left = v->right;
            v->right = node;
            fix_height_(node);
            fix_height_(v);
            return v;
        }

        Node* rotate_left_(Node* node){
            Node* v = node->right;
            node->right = v->left;
            v->left = node;
            fix_height_(node);
            fix_height_(v);
            return v;
        }

        int b_factor_(Node* node){
            return (node->right != NULL ? node->right->height : 0) - (node->left != NULL ? node->left->height : 0);
        }

        Node* balance_(Node* node){
            fix_height_(node);
            if(b_factor_(node) == 2){
                if(b_factor_(node->right) < 0){
                    node->right = rotate_right_(node->right);
                }
                return rotate_left_(node);
            }
            else if(b_factor_(node) == -2){
                if(b_factor_(node->left) > 0){
                    node->left = rotate_left_(node->left);
                }
                return rotate_right_(node);
            }
            return node;
        }

        Node* get_min_node_(Node* node){
            if(node->left != NULL){
                return get_min_node_(node->left);
            }
            else{
                return node;
            }
        }

        Node* get_max_node_(Node* node){
            if(node->right == NULL){
                return get_max_node_(node->right);
            }
            else{
                return node;
            }
        }

        Node* add_node_(int v, Node* node) {
            if(node == NULL) {
                return new Node(v);
            }
            if(v < node->value){
                node->left = add_node_(v, node->left); 
            }
            else{
                node->right = add_node_(v, node->right);
            }
            return balance_(node);
        }

        Node* remove_min_node_(Node* node){
            if(node->left == NULL){
                return node->right;
            }
            node->left = remove_min_node_(node->left);
            return balance_(node);
        }

        Node* remove_max_node_(Node* node){
            if(node->right != NULL){
                return node->left;
            }
            node->right = remove_max_node_(node->right);
            return balance_(node);
        }

        Node* remove_node_(int v, Node* node){
            if(node == NULL){
                return NULL;
            }
            if(v < node->value){
                node->left = remove_node_(v, node->left);
            }
            else if(v > node->value){
                node->right = remove_node_(v, node->right);
            }
            else{
                Node* l = node->left;
                Node* r = node->right;
                if(r == NULL){
                    return l;
                }
                Node* min = get_min_node_(r);
                min->right = remove_min_node_(r);
                min->left = l;
                return balance_(min);
            }
            return balance_(node);
        }

        std::vector <std::pair <int, int>> bfs_(){
            std::vector <std::pair <Node*, int>> q = {std::pair <Node*, int> {head_, 0}};
            std::vector <std::pair <int, int>> p;
            while(q.size() > 0){
                std::pair <Node*, int> v = q[q.size() - 1];
                q.pop_back();
                p.push_back(std::pair <int, int> {v.first->value, v.second});
                if(v.first->right != NULL){
                    q.push_back(std::pair <Node*, int> {v.first->right, v.second + 1});
                }
                if(v.first->left != NULL){
                    q.push_back(std::pair <Node*, int> {v.first->left, v.second + 1});
                }
            }
            return p;
        }

        void dfs_plain_(Node* node, std::vector <int> &p){
            if(node->left != NULL){
                dfs_plain_(node->left, p);
            }
            p.push_back(node->value);
            if(node->right != NULL){
                dfs_plain_(node->right, p);
            }
        }

        void dfs_reverse_(Node* node, std::vector <int> &p){
            if(node->right != NULL){
                dfs_reverse_(node->right, p);
            }
            p.push_back(node->value);
            if(node->left != NULL){
                dfs_reverse_(node->left, p);
            }
        }

    public:

        Tree(){
            head_ = NULL;
        }

        int get_min(){
            if(head_->left != NULL){
                return get_min_node_(head_->left)->value;
            }
            else{
                return head_->value;
            }
        }

        int get_max(){
            if(head_->right != NULL){
                return get_max_node_(head_->right)->value;
            }
            else{
                return head_->value;
            }
        }

        void add(int v){
            head_ = add_node_(v, head_);
        }

        void remove_min(){
            head_ = remove_min_node_(head_);
        }

        void remove_max(){
            head_ = remove_max_node_(head_);
        }

        void remove(int v){
            head_ = remove_node_(v, head_);
        }

        void create(std::vector <int> arr){
            head_ = new Node(arr[0]);
            for(int i = 1; i < arr.size(); i ++){
                add(arr[i]);
            }
        }

        std::vector <std::vector <int>> get_tree_by_levels(){
            std::vector <std::pair <int, int>> p = bfs_();
            std::vector <std::vector <int>> res;
            int max_p = -1;
            for(auto m: p){
                if(max_p < m.second){
                    max_p = m.second;
                }
            }
            for(int _ = 0; _ <= max_p; _ ++){
                res.push_back(std::vector<int> {});
            }
            for(auto n: p){
                res[n.second].push_back(n.first);
            }
            return res;
        }

        std::vector <int> get_tree_list(){
            std::vector <std::pair <int, int>> p = bfs_();
            std::vector <int> res;
            for(auto n: p){
                res.push_back(n.first);
            }
            return res;
        }

        std::vector <int> get_tree_sorted(bool reverse = false){
            std::vector <int> p;
            if(reverse){
                dfs_reverse_(head_, p);
            }
            else{
                dfs_plain_(head_, p);
            }
            return p;
        }

};
```

`C#`:

```cs
class Node
{
    public int value;
    public uint height;
    public Node left;
    public Node right;

    public Node(int d)
    {
        value = d;
        height = 1;
        left = null;
        right = null;
    }

}

class Tree
{
    private Node _head;

    public Tree()
    {
        _head = null;
    }

    private void _FixHeight(Node node)
    {
        uint hl = node.left != null ? node.left.height : 0;
        uint hr = node.right != null ? node.right.height : 0;            
        node.height = (hl > hr ? hl : hr) + 1;
    }

    private Node _RotateRight(Node node)
    {
        Node v = node.left;
        node.left = v.right;
        v.right = node;
        this._FixHeight(node);
        this._FixHeight(v);
        return v;
    }

    private Node _RotateLeft(Node node)
    {
        Node v = node.right;
        node.right = v.left;
        v.left = node;
        this._FixHeight(node);
        this._FixHeight(v);
        return v;
    }

    private int _BFactor(Node node)
    {
        return (node.right != null ? node.right.height : 0) - (node.left != null ? node.left.height : 0);
    }

    private Node _Balance(Node node)
    {
        this._FixHeight(node);
        if(this._BFactor(node) == 2)
        {
            if(this._BFactor(node.right) < 0)
            {
                node.right = this._RotateRight(node.right);
            }
            return this._RotateLeft(node);
        }
        else if(this._BFactor(node) == -2)
        {
            if(this._BFactor(node.left) > 0)
            {
                node.left = this._RotateLeft(node.left);
            }
            return _RotateRight(node);
        }
        return node;
    }

    private Node _GetMinNode(Node node)
    {
        if(node.left != null)
        {
            return _GetMinNode(node.left);
        }
        else
        {
            return node;
        }
    }

    public int GetMin()
    {
        if(this._head.left != null)
        {
            return this._GetMinNode(this._head).value;
        }
        else
        {
            return this._head.value;
        }
    }

    private Node _GetMaxNode(Node node)
    {
        if(node.right != null)
        {
            return _GetMaxNode(node.right);
        }
        else
        {
            return node;
        }
    }

    public int GetMax()
    {
        if(this._head.left != null)
        {
            return this._GetMaxNode(this._head).value;
        }
        else
        {
            return this._head.value;
        }
    }

    private void _AddNode(int v, Node node = null)
    {
        if(node == null)
        {
            return new Node(v);
        }
        if(v < node.value)
        {
            node.left = _AddNode(v, node.left);
        }
        else
        {
            node.right = _AddNode(v, node.right);
        }
        return this._Balance(node);
    }

    public void Add(int v)
    {
        this._head = this._AddNode(v, this._head);
    }

    private Node _RemoveMinNode(Node node)
    {
        if(node.left == null)
        {
            return node.right;
        }
        node.left = this._RemoveMinNode(node.left);
        return this._Balance(node);
    }

    public void RemoveMin()
    {
        this._head = this._RemoveMinNode(this._head);
    }

    private Node _RemoveMaxNode(Node node)
    {
        if(node.right == null)
        {
            return node.left;
        }
        node.right = this._RemoveMaxNode(node.left);
        return this._Balance(node);
    }

    public void RemoveMax()
    {
        this._head = this._RemoveMaxNode(this._head);
    }

    private Node _RemoveNode(int v, Node node)
    {
        if(node == null)
        {
            return null;
        }
        if(v < node.value)
        {
            node.left = this._RemoveNode(v, node.left);
        }
        else if(v > node.value)
        {
            node.right = this._RemoveNode(v, node.right);
        }
        else
        {
            Node l = node.left;
            Node r = node.right;
            if(r == null)
            {
                return l;
            }
            Node min = this._GetMinNode(r);
            min.right = this._RemoveMinNode(r);
            min.left = l;
            return this._Balance(min);
        }
        return this._Balance(node);
    }

    public void Remove(int v)
    {
        this._head = this._RemoveNode(v, this._head);
    }

    public void Create(List<int> arr)
    {
        _head = new Node(arr[0]);
        for(int i = 1; i < arr.Count(); i ++)
        {
            AddNode(arr[i], _head);
        }
    }

    private List<(int, int)> _Bfs()
    {
        List<(Node, int)> q = new List<(Node, int)>(1){(_head, 0)};
        List<(int, int)> p = new List<(int, int)>(){};
        while(q.Count() > 0)
        {
            (Node, int) v = q[^1];
            q.RemoveAt(q.Count() - 1);
            p.Add((v.Item1.value, v.Item2));
            if(v.Item1.right != null)
            {
                q.Add((v.Item1.right, v.Item2 + 1));
            }
            if(v.Item1.left != null)
            {
                q.Add((v.Item1.left, v.Item2 + 1));
            }
        }
        return p;
    }

    public List<List<int>> GetTreeByLevels()
    {
        List<(int, int)> p = _Bfs();
        List<List<int>> res = new List<List<int>>(){};
        int maxP = -1;
        foreach((int, int) n in p)
        {
            if(maxP < n.Item2)
            {
                maxP = n.Item2;
            }
        }
        for(int _ = 0; _ <= maxP; _ ++)
        {
            res.Add(new List<int>(){});
        }
        foreach((int, int) n in p)
        {
            res[n.Item2].Add(n.Item1);
        }
        return res;
    }

    public List<int> GetTreeList()
    {
        List<(int, int)> p = _Bfs();
        List<int> res = new List<int>(){};
        foreach((int, int) n in p)
        {
            res.Add(n.Item1);
        }
        return res;
    }

    private void _DfsPlain(Node node, ref List<int> p)
    {
        if(node.left != null)
        {
            _DfsPlain(node.left, ref p);
        }
        p.Add(node.value);
        if(node.right != null)
        {
            _DfsPlain(node.right, ref p);
        }
    }

    private void _DfsReverse(Node node, ref List<int> p)
    {
        if(node.right != null)
        {
            _DfsReverse(node.right, ref p);
        }p.Add(node.value);
        if(node.left != null)
        {
            _DfsReverse(node.left, ref p);
        }
    }

    public List<int> GetTreeSorted(bool reverse = false)
    {
        List<int> p = new List<int>(){};
        if(reverse)
        {
            _DfsReverse(_head, ref p);
        }
        else
        {
            _DfsPlain(_head, ref p);
        }
        return p;
    }
}
```

## Subarray linear algorithms / Лінійні алгоритми підмасивів / Линейные алгоритмы подмассивов

### Packages / Пакети / Пакеты

`Python`:

```python
subarrays.max_subarray_sum(arr)
subarrays.min_subarray_sum(arr)
subarrays.max_subarray_prod(arr)
subarrays.min_subarray_prod(arr)
subarrays.max_circular_subarray_sum(arr)
subarrays.min_circular_subarray_sum(arr)
```

`JavaScript`:

```js
subarrays.maxSubarraySum(arr);
subarrays.minSubarraySum(arr);
subarrays.maxSubarrayProd(arr);
subarrays.minSubarrayProd(arr);
subarrays.maxCircularSubarraySum(arr);
subarrays.minCircularSubarraySum(arr);
```

> *Linear – time complexity* ***O(n)***
>
> *Лінійний – часова складність* ***O(n)***
>
> *Линейный – временная сложность* ***O(n)***

### Files / Файли / Файлы

<ins>***Python:***</ins> *[subarrays.py](https://github.com/s0urce18/AdditionalFunctions/blob/main/Subarrays/subarrays.py)*

<ins>***JavaScript:***</ins> *[subarrays.js](https://github.com/s0urce18/AdditionalFunctions/blob/main/Subarrays/subarrays.js)*

<ins>***Go:***</ins> *[subarrays.go](https://github.com/s0urce18/AdditionalFunctions/blob/main/Subarrays/subarrays.go)*

<ins>***C++:***</ins> *[subarrays.cpp](https://github.com/s0urce18/AdditionalFunctions/blob/main/Subarrays/subarrays.cpp)*

<ins>***C#:***</ins> *[subarrays.cs](https://github.com/s0urce18/AdditionalFunctions/blob/main/Subarrays/subarrays.cs)*

### Max | Min subarray sum / Максимальна | Мінімальна сума підмасива / Максимальная | Минимальная сумма подмассива

`Python`:

```python
def max_subarray_sum(arr):
    result = arr[0]
    local_result = arr[0]
    for i in range(1, len(arr)):
        if local_result > 0:
            local_result += arr[i]
        else:
            local_result = arr[i]
        if local_result > result:
            result = local_result
    return result

def min_subarray_sum(arr):
    result = arr[0]
    local_result = arr[0]
    for i in range(1, len(arr)):
        if local_result < 0:
            local_result += arr[i]
        else:
            local_result = arr[i]
        if local_result < result:
            result = local_result
    return result
```

`JavaScript`:

```js 
function maxSubarraySum(arr){
    let result = arr[0];
    let localResult = arr[0];
    for(let i = 1; i < arr.length; i ++){
        if(localResult > 0){
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult > result){
            result = localResult;
        }
    }
    return result;
}

function minSubarraySum(arr){
    let result = arr[0];
    let localResult = arr[0];
    for(let i = 1; i < arr.length; i ++){
        if(localResult < 0){
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult < result){
            result = localResult;
        }
    }
    return result;
}
```

`Go`:

```go
func maxSubarraySum(arr []int) int {
    result := arr[0]
    localResult := arr[0]
    for i := 1; i < len(arr); i++ {
        if localResult > 0 {
            localResult += arr[i]
        } else {
            localResult = arr[i]
        }
        if localResult > result {
            result = localResult
        }
    }
    return result
}

func minSubarraySum(arr []int) int {
    result := arr[0]
    localResult := arr[0]
    for i := 1; i < len(arr); i++ {
        if localResult < 0 {
            localResult += arr[i]
        } else {
            localResult = arr[i]
        }
        if localResult < result {
            result = localResult
        }
    }
    return result
}
```

`C++`:

```cpp
#include <vector>

int max_subarray_sum(std::vector <int> arr){
    int result = arr[0];
    int local_result = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        if(local_result > 0){
            local_result += arr[i];
        }
        else{
            local_result = arr[i];
        }
        if(local_result > result){
            result = local_result;
        }
    }
    return result;
}

int min_subarray_sum(std::vector <int> arr){
    int result = arr[0];
    int local_result = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        if(local_result < 0){
            local_result += arr[i];
        }
        else{
            local_result = arr[i];
        }
        if(local_result < result){
            result = local_result;
        }
    }
    return result;
}
```

`C#`:

```cs
int MaxSubarraySum(List<int> arr)
{
    int result = arr[0];
    int localResult = arr[0];
    for(int i = 1; i < arr.Count(); i ++)
    {
        if(localResult > 0)
        {
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult > result)
        {
            result = localResult;
        }
    }
    return result;
}

int MinSubarraySum(List<int> arr)
{
    int result = arr[0];
    int localResult = arr[0];
    for(int i = 1; i < arr.Count(); i ++)
    {
        if(localResult < 0)
        {
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult < result)
        {
            result = localResult;
        }
    }
    return result;
}
```

### Max | Min subarray prod / Максимальний | Мінімальний добуток підмасива / Максимальное | Минимальное произведение подмассива

`Python`:

```python
def max_subarray_prod(arr):
    result = arr[0]
    local_result_pos = arr[0]
    local_result_neg = arr[0]
    for i in range(1, len(arr)):
        if local_result_pos * arr[i] > local_result_neg * arr[i]:
            local_result_max = local_result_pos * arr[i]
            local_result_min = local_result_neg * arr[i]
        else:
            local_result_max = local_result_neg * arr[i]
            local_result_min = local_result_pos * arr[i]
        if arr[i] > local_result_max:
            local_result_pos = arr[i]
        else:
            local_result_pos = local_result_max
        if arr[i] < local_result_min:
            local_result_neg = arr[i]
        else:
            local_result_neg = local_result_min
        if local_result_pos > result:
            result = local_result_pos
    return result
        
def min_subarray_prod(arr):
    result = arr[0]
    local_result_pos = arr[0]
    local_result_neg = arr[0]
    for i in range(1, len(arr)):
        if local_result_pos * arr[i] > local_result_neg * arr[i]:
            local_result_max = local_result_pos * arr[i]
            local_result_min = local_result_neg * arr[i]
        else:
            local_result_max = local_result_neg * arr[i]
            local_result_min = local_result_pos * arr[i]
        if arr[i] > local_result_max:
            local_result_pos = arr[i]
        else:
            local_result_pos = local_result_max
        if arr[i] < local_result_min:
            local_result_neg = arr[i]
        else:
            local_result_neg = local_result_min
        if local_result_neg < result:
            result = local_result_neg
    return result
```

`JavaScript`:

```js 
function maxSubarrayProd(arr){
    let result = arr[0];
    let localResultPos = arr[0];
    let localResultNeg = arr[0];
    for(let i = 1; i < arr.length; i ++){
        let localResultMax, localResultMin;
        if(localResultPos * arr[i] > localResultNeg * arr[i]){
            localResultMax = localResultPos * arr[i];
            localResultMin = localResultNeg * arr[i];
        }
        else{
            localResultMax = localResultNeg * arr[i];
            localResultMin = localResultPos * arr[i];
        }
        if(arr[i] > localResultMax){
            localResultPos = arr[i];
        }
        else{
            localResultPos = localResultMax;
        }
        if(arr[i] < localResultMin){
            localResultNeg = arr[i];
        }
        else{
            localResultNeg = localResultMin;
        }
        if(localResultPos > result){
            result = localResultPos;
        }
    }
    return result;
}

function minSubarrayProd(arr){
    let result = arr[0];
    let localResultPos = arr[0];
    let localResultNeg = arr[0];
    for(let i = 1; i < arr.length; i ++){
        let localResultMax, localResultMin;
        if(localResultPos * arr[i] > localResultNeg * arr[i]){
            localResultMax = localResultPos * arr[i];
            localResultMin = localResultNeg * arr[i];
        }
        else{
            localResultMax = localResultNeg * arr[i];
            localResultMin = localResultPos * arr[i];
        }
        if(arr[i] > localResultMax){
            localResultPos = arr[i];
        }
        else{
            localResultPos = localResultMax;
        }
        if(arr[i] < localResultMin){
            localResultNeg = arr[i];
        }
        else{
            localResultNeg = localResultMin;
        }
        if(localResultNeg < result){
            result = localResultNeg;
        }
    }
    return result;
}
```

`Go`:

```go
func maxSubarrayProd(arr []int) int {
    result := arr[0]
    localResultPos := arr[0]
    localResultNeg := arr[0]
    for i := 1; i < len(arr); i++ {
        var localResultMax, localResultMin int
        if localResultPos*arr[i] > localResultNeg*arr[i] {
            localResultMax = localResultPos * arr[i]
            localResultMin = localResultNeg * arr[i]
        } else {
            localResultMax = localResultNeg * arr[i]
            localResultMin = localResultPos * arr[i]
        }
        if arr[i] > localResultMax {
            localResultPos = arr[i]
        } else {
            localResultPos = localResultMax
        }
        if arr[i] < localResultMin {
            localResultNeg = arr[i]
        } else {
            localResultNeg = localResultMin
        }
        if localResultPos > result {
            result = localResultPos
        }
    }
    return result
}

func minSubarrayProd(arr []int) int {
    result := arr[0]
    localResultPos := arr[0]
    localResultNeg := arr[0]
    for i := 1; i < len(arr); i++ {
        var localResultMax, localResultMin int
        if localResultPos*arr[i] > localResultNeg*arr[i] {
            localResultMax = localResultPos * arr[i]
            localResultMin = localResultNeg * arr[i]
        } else {
            localResultMax = localResultNeg * arr[i]
            localResultMin = localResultPos * arr[i]
        }
        if arr[i] > localResultMax {
            localResultPos = arr[i]
        } else {
            localResultPos = localResultMax
        }
        if arr[i] < localResultMin {
            localResultNeg = arr[i]
        } else {
            localResultNeg = localResultMin
        }
        if localResultNeg < result {
            result = localResultNeg
        }
    }
    return result
}
```

`C++`:

```cpp
#include <vector>

int max_subarray_prod(std::vector <int> arr){
    int result = arr[0];
    int local_result_pos = arr[0];
    int local_result_neg = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        int local_result_max, local_result_min;
        if(local_result_pos * arr[i] > local_result_neg * arr[i]){
            local_result_max = local_result_pos * arr[i];
            local_result_min = local_result_neg * arr[i];
        }
        else{
            local_result_max = local_result_neg * arr[i];
            local_result_min = local_result_pos * arr[i];
        }
        if(arr[i] > local_result_max){
            local_result_pos = arr[i];
        }
        else{
            local_result_pos = local_result_max;
        }
        if(arr[i] < local_result_min){
            local_result_neg = arr[i];
        }
        else{
            local_result_neg = local_result_min;
        }
        if(local_result_pos > result){
            result = local_result_pos;
        }
    }
    return result;
}

int min_subarray_prod(std::vector <int> arr){
    int result = arr[0];
    int local_result_pos = arr[0];
    int local_result_neg = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        int local_result_max, local_result_min;
        if(local_result_pos * arr[i] > local_result_neg * arr[i]){
            local_result_max = local_result_pos * arr[i];
            local_result_min = local_result_neg * arr[i];
        }
        else{
            local_result_max = local_result_neg * arr[i];
            local_result_min = local_result_pos * arr[i];
        }
        if(arr[i] > local_result_max){
            local_result_pos = arr[i];
        }
        else{
            local_result_pos = local_result_max;
        }
        if(arr[i] < local_result_min){
            local_result_neg = arr[i];
        }
        else{
            local_result_neg = local_result_min;
        }
        if(local_result_neg < result){
            result = local_result_neg;
        }
    }
    return result;
}
```

`C#`:

```cs
int MaxSubarrayProd(List<int> arr)
{
    int result = arr[0];
    int localResultPos = arr[0];
    int localResultNeg = arr[0];
    for(int i = 1; i < arr.Count(); i ++)
    {
        int localResultMax, localResultMin;
        if(localResultPos * arr[i] > localResultNeg * arr[i])
        {
            localResultMax = localResultPos * arr[i];
            localResultMin = localResultNeg * arr[i];
        }
        else
        {
            localResultMax = localResultNeg * arr[i];
            localResultMin = localResultPos * arr[i];
        }
        if(arr[i] > localResultMax)
        {
            localResultPos = arr[i];
        }
        else
        {
            localResultPos = localResultMax;
        }
        if(arr[i] < localResultMin)
        {
            localResultNeg = arr[i];
        }
        else
        {
            localResultNeg = localResultMin;
        }
        if(localResultPos > result)
        {
            result = localResultPos;
        }
    }
    return result;
}

int MinSubarrayProd(List<int> arr)
{
    int result = arr[0];
    int localResultPos = arr[0];
    int localResultNeg = arr[0];
    for(int i = 1; i < arr.Count(); i ++)
    {
        int localResultMax, localResultMin;
        if(localResultPos * arr[i] > localResultNeg * arr[i])
        {
            localResultMax = localResultPos * arr[i];
            localResultMin = localResultNeg * arr[i];
        }
        else
        {
            localResultMax = localResultNeg * arr[i];
            localResultMin = localResultPos * arr[i];
        }
        if(arr[i] > localResultMax)
        {
            localResultPos = arr[i];
        }
        else
        {
            localResultPos = localResultMax;
        }
        if(arr[i] < localResultMin)
        {
            localResultNeg = arr[i];
        }
        else
        {
            localResultNeg = localResultMin;
        }
        if(localResultNeg < result)
        {
            result = localResultNeg;
        }
    }
    return result;
}
```

### Max | Min circular subarray sum / Максимальна | Мінімальна сума циклічного підмасива / Максимальная | Минимальная сумма циклического подмассива

`Python`:

```python
def max_subarray_sum(arr):
    result = arr[0]
    local_result = arr[0]
    for i in range(1, len(arr)):
        if local_result > 0:
            local_result += arr[i]
        else:
            local_result = arr[i]
        if local_result > result:
            result = local_result
    return result

def min_subarray_sum(arr):
    result = arr[0]
    local_result = arr[0]
    for i in range(1, len(arr)):
        if local_result < 0:
            local_result += arr[i]
        else:
            local_result = arr[i]
        if local_result < result:
            result = local_result
    return result

def max_circular_subarray_sum(arr):
    max_elem = arr[0]
    arr_sum = 0
    for i in range(0, len(arr)):
        if arr[i] > max_elem:
            max_elem = arr[i]
        arr_sum += arr[i]
    if max_elem < 0:
        return max_elem
    max_simple_sum = max_subarray_sum(arr)
    max_circle_sum = arr_sum - min_subarray_sum(arr)
    if max_simple_sum > max_circle_sum:
        return max_simple_sum
    else:
        return max_circle_sum

def min_circular_subarray_sum(arr):
    min_elem = arr[0]
    arr_sum = 0
    for i in range(0, len(arr)):
        if arr[i] < min_elem:
            min_elem = arr[i]
        arr_sum += arr[i]
    if min_elem > 0:
        return min_elem
    min_simple_sum = min_subarray_sum(arr)
    min_circle_sum = arr_sum - max_subarray_sum(arr)
    if min_simple_sum < min_circle_sum:
        return min_simple_sum
    else:
        return min_circle_sum
```

`JavaScript`:

```js
function maxSubarraySum(arr){
    let result = arr[0];
    let localResult = arr[0];
    for(let i = 1; i < arr.length; i ++){
        if(localResult > 0){
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult > result){
            result = localResult;
        }
    }
    return result;
}

function minSubarraySum(arr){
    let result = arr[0];
    let localResult = arr[0];
    for(let i = 1; i < arr.length; i ++){
        if(localResult < 0){
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult < result){
            result = localResult;
        }
    }
    return result;
}

function maxCircularSubarraySum(arr){
    let maxElem = arr[0];
    let arrSum = 0;
    for(let i = 0; i < arr.length; i ++){
        if(arr[i] > maxElem){
            maxElem = arr[i];
        }
        arrSum += arr[i];
    }
    if(maxElem < 0){
        return maxElem;
    }
    let maxSimpleSum = maxSubarraySum(arr);
    let maxCircleSum = arrSum - minSubarraySum(arr);
    if(maxSimpleSum > maxCircleSum){
        return maxSimpleSum;
    }
    else{
        return maxCircleSum;
    }
}

function minCircularSubarraySum(arr){
    let minElem = arr[0];
    let arrSum = 0;
    for(let i = 0; i < arr.length; i ++){
        if(arr[i] < minElem){
            minElem = arr[i];
        }
        arrSum += arr[i];
    }
    if(minElem > 0){
        return minElem;
    }
    let minSimpleSum = minSubarraySum(arr);
    let minCircleSum = arrSum - maxSubarraySum(arr);
    if(minSimpleSum < minCircleSum){
        return minSimpleSum;
    }
    else{
        return minCircleSum;
    }
}
```

`Go`:

```go
func maxSubarraySum(arr []int) int {
    result := arr[0]
    localResult := arr[0]
    for i := 1; i < len(arr); i++ {
        if localResult > 0 {
            localResult += arr[i]
        } else {
            localResult = arr[i]
        }
        if localResult > result {
            result = localResult
        }
    }
    return result
}

func minSubarraySum(arr []int) int {
    result := arr[0]
    localResult := arr[0]
    for i := 1; i < len(arr); i++ {
        if localResult < 0 {
            localResult += arr[i]
        } else {
            localResult = arr[i]
        }
        if localResult < result {
            result = localResult
        }
    }
    return result
}

func maxCircularSubarraySum(arr []int) int {
    maxElem := arr[0]
    arrSum := 0
    for i := 0; i < len(arr); i++ {
        if arr[i] > maxElem {
            maxElem = arr[i]
        }
        arrSum += arr[i]
    }
    if maxElem < 0 {
        return maxElem
    }
    maxSimpleSum := maxSubarraySum(arr)
    maxCircleSum := arrSum - minSubarraySum(arr)
    if maxSimpleSum > maxCircleSum {
        return maxSimpleSum
    } else {
        return maxCircleSum
    }
}

func minCircularSubarraySum(arr []int) int {
    minElem := arr[0]
    arrSum := 0
    for i := 0; i < len(arr); i++ {
        if arr[i] < minElem {
            minElem = arr[i]
        }
        arrSum += arr[i]
    }
    if minElem > 0 {
        return minElem
    }
    minSimpleSum := minSubarraySum(arr)
    minCircleSum := arrSum - minSubarraySum(arr)
    if minSimpleSum < minCircleSum {
        return minSimpleSum
    } else {
        return minCircleSum
    }
}
```

`C++`:

```cpp
#include <vector>

int max_subarray_sum(std::vector <int> arr){
    int result = arr[0];
    int local_result = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        if(local_result > 0){
            local_result += arr[i];
        }
        else{
            local_result = arr[i];
        }
        if(local_result > result){
            result = local_result;
        }
    }
    return result;
}

int min_subarray_sum(std::vector <int> arr){
    int result = arr[0];
    int local_result = arr[0];
    for(int i = 1; i < arr.size(); i ++){
        if(local_result < 0){
            local_result += arr[i];
        }
        else{
            local_result = arr[i];
        }
        if(local_result < result){
            result = local_result;
        }
    }
    return result;
}

int max_circular_subarray_sum(std::vector <int> arr){
    int max_elem = arr[0];
    int arr_sum = 0;
    for(int i = 0; i < arr.size(); i ++){
        if(arr[i] > max_elem){
            max_elem = arr[i];
        }
        arr_sum += arr[i];
    }
    if(max_elem < 0){
        return max_elem;
    }
    int max_simple_sum = max_subarray_sum(arr);
    int max_circle_sum = arr_sum - min_subarray_sum(arr);
    if(max_simple_sum > max_circle_sum){
        return max_simple_sum;
    }
    else{
        return max_circle_sum;
    }
}

int min_circular_subarray_sum(std::vector <int> arr){
    int min_elem = arr[0];
    int arr_sum = 0;
    for(int i = 0; i < arr.size(); i ++){
        if(arr[i] < min_elem){
            min_elem = arr[i];
        }
        arr_sum += arr[i];
    }
    if(min_elem > 0){
        return min_elem;
    }
    int min_simple_sum = min_subarray_sum(arr);
    int min_circle_sum = arr_sum - max_subarray_sum(arr);
    if(min_simple_sum < min_circle_sum){
        return min_simple_sum;
    }
    else{
        return min_circle_sum;
    }
}
```

`C#`:

```cs
int MaxSubarraySum(List<int> arr)
{
    int result = arr[0];
    int localResult = arr[0];
    for(int i = 1; i < arr.Count(); i ++)
    {
        if(localResult > 0)
        {
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult > result)
        {
            result = localResult;
        }
    }
    return result;
}

int MinSubarraySum(List<int> arr)
{
    int result = arr[0];
    int localResult = arr[0];
    for(int i = 1; i < arr.Count(); i ++)
    {
        if(localResult < 0)
        {
            localResult += arr[i];
        }
        else{
            localResult = arr[i];
        }
        if(localResult < result)
        {
            result = localResult;
        }
    }
    return result;
}

int MaxCircularSubarraySum(List<int> arr)
{
    int maxElem = arr[0];
    int arrSum = 0;
    for(int i = 0; i < arr.Count(); i ++)
    {
        if(arr[i] > maxElem)
        {
            maxElem = arr[i];
        }
        arrSum += arr[i];
    }
    if(maxElem < 0)
    {
        return maxElem;
    }
    int maxSimpleSum = MaxSubarraySum(arr);
    int maxCircleSum = arrSum - MinSubarraySum(arr);
    if(maxSimpleSum > maxCircleSum)
    {
        return maxSimpleSum;
    }
    else
    {
        return maxCircleSum;
    }
}

int MinCircularSubarraySum(List<int> arr)
{
    int minElem = arr[0];
    int arrSum = 0;
    for(int i = 0; i < arr.Count(); i ++)
    {
        if(arr[i] < minElem)
        {
            minElem = arr[i];
        }
        arrSum += arr[i];
    }
    if(minElem < 0)
    {
        return minElem;
    }
    int minSimpleSum = MinSubarraySum(arr);
    int minCircleSum = arrSum - MaxSubarraySum(arr);
    if(minSimpleSum < minCircleSum)
    {
        return minSimpleSum;
    }
    else
    {
        return minCircleSum;
    }
}
```