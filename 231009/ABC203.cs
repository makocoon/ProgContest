internal class Ptractice
{
    static void Main(string[] args)
    {
        var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        Array.Sort(inputArray);
        if (inputArray[0] == inputArray[1] || inputArray[1] == inputArray[2])
        {
            if (inputArray[0] == inputArray[1])
            {
                Console.WriteLine(inputArray[2]);
            }
            else
            {
                Console.WriteLine(inputArray[0]);
            }
        }
        else 
        {
            Console.WriteLine(0);
        }
    }
}