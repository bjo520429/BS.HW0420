namespace case02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 奇偶數判斷 #2
            // 輸入一串以逗號分隔的整數數字字串，將其依照奇偶數分割為兩個數列，並且予以排序顯示結果分割逗號請參考 String.Split 方法
            // 例如：
            // 輸入 8,7,9,3,11,6,2,18
            // 結果為兩列
            // 奇數: 3,7,9,11 
            // 偶數: 2,6,8,18

            Console.WriteLine("=== 奇偶數判斷 #2 ===");
            Console.WriteLine();

            Console.Write("請輸入需要分類排序的數列，並用,分隔：");
            string[] input = Console.ReadLine().Split(",");
            int[] numsArr = new int[input.Length];
            for ( int i = 0;  i < input.Length; i++ )
            {
                numsArr[i] = int.Parse(input[i]);
            }
            BubbleSort(numsArr);
            string oddStr = string.Empty;
            string evensStr = string.Empty;
            foreach(int num in numsArr)
            {
                if( num % 2 == 1 )
                {
                    oddStr = $"{oddStr}{num},";
                }
                else
                {
                    evensStr = $"{evensStr}{num},";
                }
            }
            oddStr = oddStr.Remove(oddStr.Length - 1);
            evensStr = evensStr.Remove(evensStr.Length - 1);

            Console.WriteLine($"奇數：{oddStr}\n偶數：{evensStr}");

            Console.WriteLine();
            Console.WriteLine("=== 已運行結束 ===");
        }
        static void BubbleSort(int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                for (int idx = 1; idx < numsArray.Length; idx++)
                {
                    if (numsArray[idx] < numsArray[idx - 1])
                    {
                        int temp = numsArray[idx];
                        numsArray[idx] = numsArray[idx - 1];
                        numsArray[idx - 1] = temp;
                    }
                }
            }
        }
    }
}
