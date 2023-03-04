Console.WriteLine("Please insert number:");
int userInput = int.Parse(Console.ReadLine());

//for(int i = 2;i <= userInput; i+=2)
//{
//    Console.WriteLine(i);
//}

//for(int i = 1; i <= userInput; i+=2)
//{
//    Console.WriteLine(i);
//}

for(int i = 1; i <= userInput; i++) { 
    if(i%3 == 0 || i%7 == 0)
        continue;
    if(i > 100)
    {
        Console.WriteLine("The limit has been reached");
        break;
    }
    Console.WriteLine(i);
}