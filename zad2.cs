Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int c = Convert.ToInt32(Console.ReadLine());
if(a > b) {
  Console.WriteLine("Max: A");
} else if(b > c){
  Console.WriteLine("Max: B");
} else {
  Console.WriteLine("Max: C");
}