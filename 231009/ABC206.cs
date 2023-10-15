//問題　A.Maxi-Buying

//ABC 国の消費税率は8 パーセントです。
//ABC 国にはエナジードリンク屋さんがあります。
//ここでは、エナジードリンク 1 本を、税抜き N 円で販売しています。
//ここに消費税を加算した後の金額は ⌊1.08×N⌋ 円となります。
//ただし、実数 x に対し、⌊x⌋ は x 以下の最大の整数を表します。
//この金額が定価の 206 円より安いなら Yay! 、定価と等しいなら so-so 、定価より高いなら :(と出力して下さい。

internal class Practice
{
    private const int LIST_PRICE = 206;
    static void Main(string[] args)
    {
        var priceN = int.Parse(Console.ReadLine());
        var taxIncludedPrice = (int)(priceN * 1.08);
        string display = JudgePrice(taxIncludedPrice);
        Console.WriteLine(display);
    }
    private static string JudgePrice(int price)
    {
        if (price == LIST_PRICE) return "so-so";
        return price > LIST_PRICE ? ":(": "Yay!";
    }
}