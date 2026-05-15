namespace case04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 迴圈倒置 #2
            // 請輸入一個整數數字，利用迴圈顯示以下結果：
            // 若輸入是 5 則結果為
            // 5
            // 44
            // 333
            // 2222
            // 11111
            // 請使用迴圈

            Console.WriteLine("=== 迴圈倒置 #2 ===");
            Console.WriteLine();
            int times = 1;
            Console.Write("請輸入一個數字：");
            int input = int.Parse(Console.ReadLine());
            for (int j = input; j > 0; j--)             //每層數字列印的數字
            {
                for (int i = 0; i < times; i++)        //每層印的次數
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                times++;
            }
            Console.WriteLine();
            Console.WriteLine("=== 已運行結束 ===");
        }
    }
}
