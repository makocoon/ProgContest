//問題　Repression
//机の上に、正整数が書かれた 3 枚のカードがあります。 
//3 枚のカードにはそれぞれ整数A, B, C が書き込まれています。

//いま、この中からちょうど 2 枚のカードを選んで手に持ちました。
//手に持ったカードに書き込まれた整数の和として考えられる最大値を求めてください。

internal class Practice
{
    static void Main(string[] args)
    {
        var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        Array.Sort(inputArray);

        int maxSum = inputArray[1] + inputArray[2];
        Console.WriteLine(maxSum.ToString());
    }
}