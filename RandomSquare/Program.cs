// See https://aka.ms/new-console-template for more information

Random random = new Random();
var list = new List<int>();
int min = 1;
int max = 50;
for (int i = 0; i < 21; i++)
{
    list.Add(random.Next(min, max));
   
    
}
//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}

IEnumerable<int> numbersSquared = list.Select(number => number * number);

//foreach (int number in numbersSquared)
//{
//    Console.WriteLine(number);
//}

var onlyEvens = numbersSquared.Where(n => n % 2 == 0);
foreach (int number in onlyEvens)
{
    Console.WriteLine(number);
}