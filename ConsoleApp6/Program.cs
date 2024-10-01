// 進階計算機

System.Console.Write("Please input first number: ");
double num1 = System.Convert.ToDouble(System.Console.ReadLine()); // 可進行小數點運算

System.Console.Write("Please enter an operation: ");
string oper = System.Console.ReadLine();

System.Console.Write("Please input second number: ");
double num2 = System.Convert.ToDouble(System.Console.ReadLine()); // 可進行小數點運算

if  (oper == "+")
{
    System.Console.WriteLine(num1 + num2);
}
else if (oper == "-")
{
    System.Console.WriteLine(num1 - num2);
}
else if (oper == "*")
{
    System.Console.WriteLine(num1 * num2);
}
else if (oper == "/")
{
    System.Console.WriteLine(num1 / num2);
}
else
{
    System.Console.WriteLine("Illegal operator ");
}