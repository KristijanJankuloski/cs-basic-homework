#region Task 1

Console.WriteLine("Enter first number:");
bool isParsed = double.TryParse(Console.ReadLine(), out double input1);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

Console.WriteLine("Enter second number:");
isParsed = double.TryParse(Console.ReadLine(), out double input2);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

Console.WriteLine("Enter operation:");
isParsed = char.TryParse(Console.ReadLine(), out char operation);
if (!isParsed) {
    Console.WriteLine("Input invaild");
    return;
}

switch (operation) {
    case '+':
        Console.WriteLine(input1 + input2);
        break;
    case '-':
        Console.WriteLine(input1 - input2);
        break;
    case '*':
        Console.WriteLine(input1 * input2);
        break;
    case '/':
        if (input2 == 0) {
            Console.WriteLine("Cannot tried to devide by zero");
            break;
        }
        Console.WriteLine(input1 / input2);
        break;
    default:
        Console.WriteLine("Unsupported operation");
        break;
}
#endregion

Console.WriteLine("==============");

#region Task 2

Console.WriteLine("Enter first number to average:");
isParsed = double.TryParse(Console.ReadLine(), out double avgInput1);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

Console.WriteLine("Enter second number to average:");
isParsed = double.TryParse(Console.ReadLine(), out double avgInput2);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

Console.WriteLine("Enter third number to average:");
isParsed = double.TryParse(Console.ReadLine(),out double avgInput3);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

Console.WriteLine("Enter fourth number to average:");
isParsed = double.TryParse(Console.ReadLine(), out double avgInput4);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

double averageResult = (avgInput1 + avgInput2 + avgInput3 + avgInput4) / 4;
Console.WriteLine("The average is: " + averageResult);

#endregion

Console.WriteLine("=================");

#region Task 3

Console.WriteLine("Enter first swap number:");
isParsed = int.TryParse(Console.ReadLine(), out int swapInput1);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

Console.WriteLine("Enter second swap number:");
isParsed = int.TryParse(Console.ReadLine(), out int swapInput2);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

int swapTemp = swapInput1;
swapInput1 = swapInput2;
swapInput2 = swapTemp;

Console.WriteLine("Swapped numbers are " + swapInput1 + ", " + swapInput2);
#endregion