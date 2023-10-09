//問題　A.Rock-Paper-Scissors
//サーバル、フェネック、アライグマの 3 人がじゃんけんをして、あいこになりました。

//フェネックが出した手を表す文字  とアライグマが出した手を表す文字 
//y が与えられます。それぞれ、0 はグー、1 はチョキを、2 はパーを表します。

//サーバルが出した手を表す文字を出力してください。なお、答えは一意に定まります。

internal class Practice
{
    static void Main(string[] args)
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(i=>int.Parse(i)).ToArray();
        int[] allArray = { 0, 1, 2 };
        int x = inputArray[0];
        int y = inputArray[1];
        if (x == y)
        {
            Console.WriteLine(x);
        }
        else
        {
            Console.WriteLine(string.Join(' ',allArray.Except(inputArray)));
        }
    }
}