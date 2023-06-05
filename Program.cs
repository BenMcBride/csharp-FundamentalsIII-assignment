static void PrintList(List<string> MyList)
{
  foreach (var str in MyList)
  {
    Console.WriteLine(str);
  }
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);

static void SumOfNumbers(List<int> IntList)
{
  int sum = 0;
  foreach (var num in IntList)
  {
    sum += num;
  }
  Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);

static int FindMax(List<int> IntList)
{
  int max = IntList[0];
  foreach (int num in IntList)
  {
    if (num > max)
    {
      max = num;
    }
  }
  return max;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

static List<int> SquareValues(List<int> IntList)
{
  List<int> SquaredList = new List<int>();
  foreach (int num in IntList)
  {
    SquaredList.Add(num * num);
  }
  return SquaredList;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
Console.WriteLine("SquareValues: ");
foreach (int num in SquareValues(TestIntList3))
{
  Console.WriteLine(num);
}


static int[] NonNegatives(int[] IntArray)
{
  int[] NonNegatives = new int[IntArray.Length];
  int idx = 0;
  foreach (int num in IntArray)
  {
    if (num >= 0)
    {
      NonNegatives[idx] = num;
      idx++;
    }
    else
    {
      NonNegatives[idx] = 0;
      idx++;
    }
  }
  return NonNegatives;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
Console.WriteLine("Non Negatives: ");
foreach (int num in NonNegatives(TestIntArray))
{
  Console.WriteLine(num);
}


static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
  foreach (string key in MyDictionary.Keys)
  {
    Console.WriteLine(key + " - " + MyDictionary[key]);
  }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);


static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
  foreach (string key in MyDictionary.Keys)
  {
    if (key == SearchTerm)
    {
      return true;
    }
  }
  return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
  Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
  foreach (int num in Numbers)
  {
    MyDictionary.Add(Names[Numbers.IndexOf(num)], num);
  }
  return MyDictionary;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
List<string> Names = new List<string>();
List<int> Numbers = new List<int>();
Names.Add("Julie");
Names.Add("Harold");
Names.Add("James");
Names.Add("Monica");
Numbers.Add(6);
Numbers.Add(12);
Numbers.Add(7);
Numbers.Add(10);
foreach (KeyValuePair<string, int> entry in GenerateDictionary(Names, Numbers))
{
  Console.WriteLine($"{entry.Key} - {entry.Value}");
}
