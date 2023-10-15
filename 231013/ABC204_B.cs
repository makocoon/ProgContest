//問題 B.Nuts
//N本の木があり、 i 番目の木には Ai個の木の実が実っています。
//シマリスは、次のルールで全ての木から木の実を収穫します。

//実っている木の実が 10 個以下の木からは木の実を収穫しない。
//実っている木の実が 10 個より多い木からは、10 個を残して残りの全てを収穫する。
//シマリスが収穫する木の実の個数の合計を求めてください。

namespace Practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            //木の数を入力
            var numberOfTrees = int.Parse(Console.ReadLine());
            var numberOfTreeFruits = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            int answer = 0;
            for (int i = 0; i < numberOfTrees; i++)
            {
                if (numberOfTreeFruits[i] > 10) 
                {
                    answer += numberOfTreeFruits[i] - 10;
                }
            }
            Console.WriteLine(answer);
        }
    }
}