//問題　Counting
//A 以上かつ B 以下の整数はいくつありますか？

//入力
//入力は以下の形式で標準入力から与えられる。
//A B

//出力
//A 以上かつ B 以下の整数の個数を出力せよ。

//入力例
//3 2

//出力例
//0
//3 以上かつ 2 以下の整数は存在しないので、0 を出力してください。

internal class Practice
{
    static void Main(string[] args)
    {
        var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();//型推論使いましょう。
        var minNumberA = inputArray[0];
        var maxNumberB = inputArray[1];
        if(minNumberA <= maxNumberB)
        {
        Console.WriteLine(maxNumberB - minNumberA + 1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}