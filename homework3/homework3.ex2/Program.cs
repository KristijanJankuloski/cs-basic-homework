int[] intsArr = new int[5];

for(int i = 0; i < intsArr.Length; i++) {
    Console.WriteLine("Enter number " + (i+1));
    bool isParsed = int.TryParse(Console.ReadLine(), out int inputNum);
    while(!isParsed) {
        Console.WriteLine("You havent entered a number. Try agian");
        isParsed = int.TryParse(Console.ReadLine(), out inputNum);
    }
    intsArr[i] = inputNum;
}

int sum = 0;
foreach(int num in intsArr) {
    sum += num;
}

Console.WriteLine("The sum is " + sum);