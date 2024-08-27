# Floating Types

## Summary

Decimal point numbers require the use of floating types. Use case for types revolves around precision and memory optimization

## Floating Type Bit Size and Range Chart

![image](https://github.com/user-attachments/assets/26559764-21d2-45c1-8988-b528be98b08d)

Source: Microsoft

[Link to Characteristics of floating types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#real-literals)

[Floating Types Quizlet](https://quizlet.com/935798952/characteristics-of-the-floating-point-types-flash-cards/?i=1bkfj1&x=1jqt)

Implicit Conversion:
- Only available from Float to Double

Using Scientific Notation:
```
double d = 0.42e2;
Console.WriteLine(d);  // output 42

float f = 134.45E-2f;
Console.WriteLine(f);  // output: 1.3445

decimal m = 1.5E6m;
Console.WriteLine(m);  // output: 1500000
```
