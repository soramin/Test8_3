using System;
using System.IO;

namespace Test8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string textData = string.Empty;

            Console.WriteLine("パスを入力");

            //入力したパスをstrPath に代入
            string strPath = Console.ReadLine();

            try
            {
                textData = File.ReadAllText(strPath);

                Console.WriteLine(textData);
            }

            catch (ArgumentException)
            {
                Console.WriteLine("引数が不正です。");
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("処理を終了します。");
            }
            
        }
    }
}
