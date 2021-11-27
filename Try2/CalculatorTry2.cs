            //Karen's Basic Calculator Try2\\



static void Main()
{
    do          //Continue using Calculator using do while
{
    
    double a = 0;           //First value
    double b = 0;           //Second Value
    double ans = 0;         //Answer
    string op = "";         //String operator
    
Console.WriteLine("Let's make some Calculations!");
Console.WriteLine("-----------------------------");


            //User inputs a value\\
Console.WriteLine("Enter first number: ");
//a = Convert.ToDouble(Console.ReadLine());
a = Double.Parse(Console.ReadLine());



            //User inputs operation\\
Console.WriteLine("Please enter operator: -,+,*,/");
op = Console.ReadLine();


            //User inputs a second value\\
Console.WriteLine("\n" + "Enter second number:");
//b = Convert.ToDouble(Console.ReadLine());
b = Double.Parse(Console.ReadLine());
//Console.ReadKey();

            //The operations\\
switch (op)
{
    case "-":               //SUBTRACTIO
        ans = a - b;
        
        break;
    case "+":               //ADDITION
        ans = a+b;
        
        break;
    case "*":               //MULTIPLICATION
        ans = a*b;
        
        break;
    case "/":               //DIVISON
        ans = a/b;
        
       break;

}
            //Write Results\\
//Console.WriteLine("You answer is:" + ans);
Console.ReadKey();
//Console.WriteLine($"{a} {Operation} {b} = {ans}");
Console.WriteLine("\n" + a +" "  + op + " " + b + "" + " = " + ans);
//Console.ReadLine();



            //Do another calculation\\
Console.WriteLine("Would you like to make more calculations?:= (Y,N):");

} while (Console.ReadLine().ToUpper() == "Y");





            //Exit\\
Console.WriteLine("Thank you, Goodbye");
Console.ReadLine();
 
}

Main ();