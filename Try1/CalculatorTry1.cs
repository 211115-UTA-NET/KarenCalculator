//Basic Calculator

Console.WriteLine("Let's make some Calculations!");

static void Main()
{
    double a;
    double b;
    double answer;
    string Operation = "";

//User inputs operation
Console.WriteLine("Please enter -,+,*,/");
Console.ReadKey();


//User inputs a value
Console.WriteLine("\n" + "Enter first number: ");
a = Convert.ToDouble(Console.ReadLine());

//User inputs a second value
Console.WriteLine("Enter second number: ");
b = Convert.ToDouble(Console.ReadLine());


//The operations
switch (Operation)
{
    case "-":               //SUBTRACTIO
        answer = a - b;
        break;
    case "+":               //ADDITION
        answer = a + b;
        break;
    case "*":               //MULTIPLICATION
        answer = a * b;
        break;
    case "/":               //DIVISON
        answer = a / b;
       break;

}

////////Console.WriteLine($"{a} {Operation} {b} = {answer}");
Console.WriteLine("\n" + a  + Operation  + b + "=" );
Console.ReadLine();
//Exit
Console.WriteLine("Enter to exit");
Console.ReadKey();
 
}

Main ();