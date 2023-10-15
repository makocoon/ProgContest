//問題

//0、1、6、8、9 からなる文字列S が与えられます。
//S を 180 度回転したものを出力してください。すなわち、
//S に次の操作を施してできる文字列を出力してください。

//S を反転する。
//0 を 0 に、1 を 1 に、6 を 9 に、8 を 8 に、9 を 6 に変換する。

namespace practice
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().ToCharArray();
            Array.Reverse(inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
                switch (inputArray[i])
                {
                    case '6':
                        inputArray[i] = '9';
                        break;
                    case '9':
                        inputArray[i] = '6';
                        break;
                }
            }
            string answer = new string(inputArray);
            Console.Write(answer);
        }
    }
}