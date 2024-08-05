/*internal class Program
{
    private static void Main(string[] args)
    {
        Print(1);
        Print("Rand");
        Print('F');
        //Print("Rand");
       // Print('R');
       // Print(new { Fname = "Rand ", Lname = "A" });
       
        //Print(new Person { FName = "Rand ", Lname = "A" });
    }
    static void Print<T>(T value)
    {
        Console.WriteLine($"Datatype: {typeof(T)}");
        Console.WriteLine(value);
    }
    class Person
    {
        public string FName { get; set; }
        public string Lname { get; set; }
    }
}*/
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        var people = new Any<Person>();
        people.Add(new Person { Fname="Ali",Lname="N"});
        people.Add(new Person { Fname = "Reem", Lname = "S" });
        people.DisplayList();
        /* var numbers = new Any<int>();
         numbers.Add(1);
         numbers.Add(2);
         numbers.Add(3);
         numbers.DisplayList();
         numbers.RemoveAt(1);
         numbers.DisplayList();
        Console.WriteLine($"Lengrh : {numbers.Count}items ");
        Console.WriteLine($"Empty : {numbers.IsEmpty} ");*/
        Console.WriteLine($"Lengrh : {people.Count}items ");
        Console.WriteLine($"Empty : {people.IsEmpty} ");
        var numbers = new Any
    }
}
public class Person
{
    public string Fname {  get; set; }
    public string Lname { get; set; }
    public override string ToString()
    {
        return $"'{Fname} {Lname}'";
    }
}  
class Any<T> where T : class
{
    private T[] _items;
    public void Add(T item)
    {
        if (_items is null)
        {
          _items = new T[] { item };
        }
        else
        {
            var length = _items.Length;
            var dest = new T[length+1];
            for (int I = 0; I < length; I++)
            { dest[I] = _items[I]; }
            dest[dest.Length - 1] = item;
            _items = dest;
        }
      
    }
    public void RemoveAt(int position)
    {
        if(position < 0 || position >= _items.Length-1)
            return;
        var index = 0;
        var dest = new T[_items.Length-1];
        for (int i = 0; i < _items.Length; i++)
        {
            if (position == i)
                continue;
            dest[index++] = _items[i];
        }
        _items = dest;
    }
     public bool IsEmpty => _items is null || _items.Length ==0;
    public int Count => _items is null ? 0 : _items.Length;
    public void DisplayList()

    {
        Console.Write("[");
        for (int i = 0; i < _items.Length; i++)
        {

            Console.Write(_items[i]);
            if (i < _items.Length - 1)
            {
                Console.Write(", ");
            }
        } Console.WriteLine("]");
} } 