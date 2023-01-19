using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = numbers.Count();
Console.WriteLine(count);
int sum = numbers.Sum();
Console.WriteLine(sum);
