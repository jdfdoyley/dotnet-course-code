namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Data Structures
        string[] myGroceryArray = new string[2];

        myGroceryArray[0] = "Chicken Breast";
        myGroceryArray[1] = "Broccoli";

        Console.WriteLine(myGroceryArray[0]);
        Console.WriteLine(myGroceryArray[1]);
        // Console.WriteLine(myGroceryArray[2]);    // This produce an error

        string[] mySecArr = { "Apple", "Eggs" };

        Console.WriteLine(mySecArr[0]);
        Console.WriteLine(mySecArr[1]);
    }
}
