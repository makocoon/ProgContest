//問題
//高橋君が 
//3 つのサイコロを振ったところ、出た目はそれぞれ a, b, c でした。

//これらのサイコロについて、出た目とは反対の面が表す整数を足し合わせた値を求めてください。

//ただし、高橋君が振るサイコロは全て一般的な立方体の 
//6 面ダイスであり、ある面とその反対側の面が表す整数を足すと 7 になります。

//入力
//入力は以下の形式で標準入力から与えられる。
//a b c

//出力
//3 つのサイコロについて、出た目とは反対の面が表す整数を足し合わせた値を出力せよ。

using System.Dynamic;

internal class Practice
{
    private const int NUMBER_OF_ROLLS = 3;
    static void Main(string[] args)
    {
        int[] inputArray = new int[NUMBER_OF_ROLLS];
        inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        int sum = CalcValue(inputArray);
        Console.WriteLine(sum);
    }
    private static int CalcValue(int[] inputArray)
    {   
        int DICE_SUM_SEVEN = 7;
        int sum = 0;
        for (int i = 0; i < NUMBER_OF_ROLLS; i++)
        {
            inputArray[i] = DICE_SUM_SEVEN - inputArray[i];
            sum += inputArray[i];
        }
        return sum;
    }
}