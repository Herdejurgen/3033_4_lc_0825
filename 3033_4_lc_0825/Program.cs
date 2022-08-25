// Jack Herdejurgen 
// Lecture Codes August 25, 2022
// C# Review
// Variables, Expressions & Statements
//string input = Console.ReadLine();
//int age = Convert.ToInt32(input);

//age = age % 5;
//Console.WriteLine($"{age}");

// comparison operators, conditional logical operators 
bool testbool = 3 <= 3;
Console.WriteLine(testbool);

int age = 5;
testbool = age < 6 || age >= 65;
Console.WriteLine(testbool);

// keyword: const
const int student1age = 30;
//student1age = 20;

// data type converstion: convert.ToDouble convert.ToInt32
double weight;
weight = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(weight);

// string interpolation
Console.WriteLine($"The weight is {weight:F3}");
string outputweight = string.Format($"The weight is {weight:F3} {weight:C}");
Console.WriteLine(outputweight);

// string.format("{0} {2}", var1, var2,...)
// string.format($"{var1} {var2}")
// Standard numeric format strings: F2, C2
// conditional statement: if ... else if...else
double grade = 89.9;
if (grade >= 90) { Console.WriteLine("A"); }
else if (grade >= 80) { Console.WriteLine("B"); }
else if (grade >= 70) { Console.WriteLine("C"); }
else if (grade >= 60) { Console.WriteLine("D"); }
else { Console.WriteLine("Fail"); }

//     loops(break continue )


// for (; ; ) { }
// while () { }
// do { } while ();
// method / function
// datatype method_name(optinal parameters) { ...return datatype_value; }

Console.ReadLine();