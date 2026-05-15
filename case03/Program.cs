namespace case03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 迴圈倒置 #1
            // 輸入一串以逗號分隔的字串，並將其反向顯示
            // 例如:
            // 輸入 12,13,23,32
            // 結果 32,23,13,12

            Console.WriteLine("=== 迴圈倒置 #1 ===");
            Console.WriteLine();

            Console.Write("請輸入一串字串，並用,分隔：");
            string[] items = Console.ReadLine().Split(',');
            for(int i = 0; i < items.Length / 2 ; i++)
            {
                string temp = items[i];
                items[i] = items[items.Length - i - 1];
                items[items.Length - i - 1] = temp;
            }

            Console.Write($"倒置結果為：{string.Join(',', items)}");


            Console.WriteLine();
            Console.WriteLine("=== 已運行結束 ===");
        }
    }
}
