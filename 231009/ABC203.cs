//問題 A.Three Dice
//高橋君が3 つのサイコロを振ったところそれぞれ a, b, c の目が出ました。
//a, b, c のうちある2 つが同じときは残りの1 つのサイコロの目を、同じものがないときは0 を出力してください。

//入力例 3
//1 1 1
//出力例 3
//1
//どの 2 つのサイコロの目も同じであり、そのいずれを選んだ場合でも残り1 つの目は 1 となります。

internal class Practice
{
    static void Main(string[] args)
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
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