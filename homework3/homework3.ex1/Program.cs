string[] stringsArr = new string[5] { "one", "two", "three", "four", "five" };
double[] doubleArr = new double[5] { 1.2, 3.34, .2, 5.67, 9.8 };
char[] charArr = new char[6] { 's', 't', 'r', 'i', 'n', 'g' };
bool[] boolArr = new bool[5] { true, false, false, true, true };
int[,] intArr = new int[5, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 6, 4 } };

for (int i = 0; i < intArr.GetLength(0); i++) {
    for(int innerI = 0; innerI < intArr.GetLength(1); innerI++) {
        Console.Write(intArr[i, innerI] + " ");
    }
    Console.Write("\n");
}