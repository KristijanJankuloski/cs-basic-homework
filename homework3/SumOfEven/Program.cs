int[] intArr = new int[6];

for(int i = 0;i < intArr.Length; i++) {
    bool isParsed = false;
    while (!isParsed) {
        Console.WriteLine("Please enter " + (i+1) + " number");
        isParsed = int.TryParse(Console.ReadLine(), out int inputNum);
        intArr[i] = inputNum;
    }
}

int sum = 0;
foreach(int num in intArr) {
    if(num % 2 == 0) {
        sum += num;
    }
}
Console.WriteLine("The sum of all even numbers is " + sum);