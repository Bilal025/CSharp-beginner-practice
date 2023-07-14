
Console.WriteLine("== Select the operation == \n");
Console.WriteLine("1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
int operation = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("\n Insert the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n Insert the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

double result;

switch (operation)
{
  case 1:
    result = firstNumber + secondNumber;
    Console.WriteLine("\n" + firstNumber + " + " + secondNumber + " = " + result);
    break;
    
  case 2:
    result = firstNumber - secondNumber;
    Console.WriteLine("\n" + firstNumber + " - " + secondNumber + " = " + result);
    break;
    
  case 3:
    result = firstNumber * secondNumber;
    Console.WriteLine("\n" + firstNumber + " x " + secondNumber + " = " + result);
    break;
    
  case 4:
    result = firstNumber / secondNumber;
    Console.WriteLine("\n" + firstNumber + " : " + secondNumber + " = " + result);
    break;
}
