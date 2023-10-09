//問題 A.kcal
//100 mL あたり A kcal のエネルギーを持つドリンクがあります。
//このドリンク B mL は何 kcal のエネルギーを持つでしょうか？
//答えは整数でないこともあります。

internal class Practice
{
    static void Main(string[] args)
    {
        double[] inputArray = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
        double Akcal = inputArray[0];
        double BmL = inputArray[1];
        Console.WriteLine(Akcal * BmL / 100);
    }
}