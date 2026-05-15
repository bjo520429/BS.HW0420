namespace case01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //奇偶數判斷 #1
            //請輸入一個整數數字，判斷其結果為奇數或偶數，並且在 Console 上顯示結果。

            Console.WriteLine("=== 奇偶數判斷 #1 ===");
            Console.WriteLine();
            Console.Write("請輸入需要判斷的數字：");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("此數為偶數!");
            }
            else { Console.WriteLine("此數為奇數!"); }
            Console.WriteLine();
            Console.WriteLine("=== 已運行結束 ===");
        }
    }
}
