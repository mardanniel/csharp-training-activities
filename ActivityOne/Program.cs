#region Basic Calculator

/**
int getNumInput()
{
    int userNumInput = 0;
    while (userNumInput == 0)
    {
        Console.WriteLine("Must be greater than 0:");
        userNumInput = Convert.ToInt32(Console.ReadLine());
    }

    return userNumInput;
}

int input = 1;
while (input != 0)
{
    int firstNum, secondNum, operation;

    Console.Write("Enter first number, ");
    firstNum = getNumInput();

    Console.Write("Operation: [1] Add [2] Subtract [3] Multiply [4] Divide, ");
    operation = getNumInput();

    Console.Write("Enter second number, ");
    secondNum = getNumInput();

    switch (operation)
    {
        case 1:
            Console.WriteLine(firstNum + secondNum);
            break;
        case 2:
            Console.WriteLine(firstNum - secondNum);
            break;
        case 3:
            Console.WriteLine(firstNum * secondNum);
            break;
        case 4:
            Console.WriteLine(firstNum / secondNum);
            break;
        default:
            Console.WriteLine("Invalid operation! Please try again.");
            break;
    }

    Console.WriteLine("[1] Calculate Again [0] Exit");
    input = Convert.ToInt32(Console.ReadLine());
}
*/

#endregion
#region FizzBuzz

/**
int num = 1;
while(num <= 100)
{
    string result = "";
    if(num % 3 == 0) result += "Fizz";
    if(num % 5 == 0) result += "Buzz";
    if(result.Length == 0) result += num.ToString();
    Console.WriteLine(result);
    num++;
}
*/

#endregion
#region ThreeIntegerSum

/**

int[] numStack = new int[3];
Console.WriteLine("Enter 3 numbers, ");
for(int i = 0; i < 3; i++)
{
    numStack[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = numStack.Sum();

if(sum <= 21)
{
    Console.WriteLine(sum);
}
else
{
    if (numStack.Contains(11))
    {
        sum -= 10;
    }

    if(sum <= 21)
    {
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine("BUST");
    }
}
*/

#endregion