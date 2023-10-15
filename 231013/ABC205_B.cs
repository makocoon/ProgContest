//問題　B.Permutation Check
//1 以上N 以下の整数からなる長さ N の数列 A=(A1, A2, ...,AN)が与えられます。
//A が (1,2,…, N) の並び替えによって得られるかどうか判定してください。

using System.Security;

namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            var lengthN = int.Parse(Console.ReadLine());
            //重複を除いて昇順に並べる
            var inputArray = Console.ReadLine().Split().Select(i => int.Parse(i)).Distinct().OrderBy(i=>i).ToArray();
            //要素の数を比較する
            if (lengthN == inputArray.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
