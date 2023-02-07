/* Найти max из девяти чисел (СТИХИЙНЫЙ ПОДХОД)*/ 

int a1 = 12;
int b1 = 15;
int c1 = 122;
int a2 = 23;
int b2 = 2;
int c2 = 1;
int a3 = 145;
int b3 = 4565;
int c3 = 234;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
