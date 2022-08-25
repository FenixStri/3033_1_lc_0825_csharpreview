// Fenix Strickland 113437176
// 8/25 lecture codes

//Variables, Expressions & Statements
int age = 2 + 3 * 2 + 4 / 2;



//comparison operators, conditional logical operators 
bool isResult = 2 > 3; //is false
isResult = 3 <= 3; //is true
isResult = 4 == 5; //is false
isResult = 5 != 5; //is false

age = 65;

isResult = !(age >= 65 || age < 6);

int r = 7 % 4;

//keyword: const

const double taxrate = 0.0875;

//taxrate = 0.07;

//data type converstion: convert.ToDouble convert.ToInt32


double grade;

string userinputStr = Console.ReadLine();

grade = Convert.ToDouble(userinputStr);

//string interpolation



//string.format("{0} {2}", var1, var2,...)
//string.format($"{var1} {var2}")
//Standard numeric format strings: F2, C2

string outputStr = string.Format($"The grade is {grade:F3} {grade:C} ");

Console.WriteLine(outputStr);

//conditional statement: if ... else if...else

//if (bool value)
//        {

//}
//else

if (grade > 85)
{
    Console.WriteLine("Congrats! A");
    Console.WriteLine("Congrats!");
    Console.WriteLine("Congrats!");
}
else if (grade >= 75)
{
    Console.WriteLine("work harder!");
    Console.WriteLine("work harder!");
    Console.WriteLine("work harder!");
}
else
{
    Console.WriteLine("B");
    Console.WriteLine("B");
    Console.WriteLine("B");
}

//    loops(break continue )
//for (; ; ) { }
//while () { }
//do { } while ();
//method / function
//datatype method_name(optinal parameters) { ...return datatype_value; }



Console.ReadLine();
