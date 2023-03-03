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

Console.WriteLine("=================");

#region Exercise 6

Console.WriteLine("Enter two numbers to test");
isParsed = int.TryParse(Console.ReadLine(), out int testNumber1);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}
isParsed = int.TryParse(Console.ReadLine(), out int testNumber2);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}

int largerNumber;
if(testNumber1 > testNumber2) {
    largerNumber = testNumber1;
}
else if(testNumber2 > testNumber1) {
    largerNumber = testNumber2;
}
else {
    Console.WriteLine("The numbers are equal");
    largerNumber = testNumber1;
}

Console.WriteLine(largerNumber + " is larger");

bool isLargerEven = largerNumber % 2 == 0;

if (isLargerEven) {
    Console.WriteLine("The larger number is even");
}
else {
    Console.WriteLine("The larger number is odd");
}

#endregion

Console.WriteLine("=================");

#region Exercise 7

Console.WriteLine("Enter a number between 1 and 3");
isParsed = int.TryParse(Console.ReadLine(), out int numberOutOf3);
if (!isParsed) {
    Console.WriteLine("Input is invalid");
    return;
}
switch(numberOutOf3) {
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("You entered an incorrec number");
        break;
}
#endregion