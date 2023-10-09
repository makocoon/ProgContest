//問題 Rolling Dice

//1,2,…,6 の出目がある 6 面サイコロをA 回振ったとき、出た目の合計が 
//B になることはありますか？

//入力
//A B

//出力
//Yes/No
//出た目の合計が B になり得る場合は Yes を、そうでない場合は No を出力せよ。

internal class Practice
{
    private static int MINDICE = 1;
    private static int MAXDICE = 6;
    static void Main(string[]  args)
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
        int numbersOfRolls = inputArray[0];
        int sumDice = inputArray[1];
        if(sumDice >= numbersOfRolls * MINDICE && sumDice <= numbersOfRolls * MAXDICE)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
