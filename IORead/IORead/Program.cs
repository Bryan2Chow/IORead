using System;
using System.IO;//添加需要的命名空间

namespace IORead
{
    class Program
    {
        private const string FILE_NAME = "TestRead.txt";//声明一个常量（通常命名大写）FILE_NAME，文件名为Test.txt
        static void Main(string[] args)
        {
            if (!File.Exists(FILE_NAME))//先判断这个文件是否存在
            {
                Console.WriteLine("{0} does not exist!",FILE_NAME);
                Console.ReadLine();
                return;
            }
            //方法一：FileStream类读文件

            ////   FileAccess打开权限 （read or write）
            //FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            //BinaryReader r = new BinaryReader(fs);//将文件流fs 传入读文件的binaryreader
            //for(int i = 0; i < 11; i++)//读取前11个字节
            //{
            //    Console.WriteLine(r.ReadString());
            //}
            //r.Close();
            //fs.Close();
            //Console.ReadLine();  

            // 方法二：streamReader类读取文件

            using(StreamReader sr = File.OpenText(FILE_NAME))//新建streamreader， 将文件传进来
            {
                string input;//新建变量， 保存streamreader读进入的字符内容
                while ((input = sr.ReadLine()) != null)//判断行是否为空  读行 ReadLine()
                {
                    Console.WriteLine(input);
                }
                Console.WriteLine("The end of the stream");
                sr.Close();
            }
            Console.ReadLine();
        }
    }
}
