//問題　B.AtCoder Condominium

//AtCoder マンションは 1 階からN 階までの N 階建てのマンションです。
//各階には K 室の部屋があり、1 号室から K 号室まで番号が振られています。
//ここで N, K は 1 桁の整数であり、 i 階の j 号室の部屋番号は i0j で表されます。
//例えば、1 階の 2 号室の部屋番号は 102 です。
//マンションの管理人である高橋君は各部屋番号を 3 桁の整数とみなし、
//AtCoder マンションに存在するすべての部屋について足しあわせたらいくつになるのか興味を持ちました。
//その値を求めてください。

using System.Diagnostics.CodeAnalysis;

namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var roomArray = new int[inputArray[0], inputArray[1]];
            int sum = 0;
            for (int i = 1; i <= inputArray[0]; i++)
            {
                for (int j = 1; j <= inputArray[1]; j++)
                {
                    roomArray[i - 1, j - 1] = i * 100 + j;
                    sum += roomArray[i - 1, j - 1];
                }
            }  
            Console.WriteLine(sum);
        }
    }
}