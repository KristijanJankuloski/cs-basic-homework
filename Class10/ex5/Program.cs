int CountAnimalLegs(int chickens, int cows, int pigs)
{
    return (chickens * 2) + (cows * 4) + (pigs * 4);
}

Console.WriteLine(CountAnimalLegs(2, 3, 5));