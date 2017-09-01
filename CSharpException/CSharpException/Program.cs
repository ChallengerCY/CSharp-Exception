using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSharpException
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptiopBase();
        }

        //C#的异常处理的基本语法
        public static void ExceptiopBase()
        {
            //C#中处理异常
            int x = 0;
            //通过try catch捕获异常
            //在catch和finally是处理异常的地方
            //可以写多个catch
            try
            {
                int y = 100 / x;
            }
                //最好不要写Exception来捕获所有的异常，这样性能开销会很大
                //如果异常全部捕获，但是处理得不好，也会成为另外一种问题
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //这里捕获异常再抛出，外部可以获取这个异常
                //throw;
            }
            finally
            {
                Console.WriteLine("finally中的代码始终执行始终执行");
            }
            //如果上面程序出错，这段代码不会执行
            Console.WriteLine("finally中的代码始终执行始终执行");
            //抛出一个异常
            //throw new NullReferenceException();
            Console.ReadLine();
        }

        //c#中常见的异常
        public static void CommonException()
        {
            //参数异常
            var ae = new ArgumentException();
            //为空参数异常
            var ane = new ArgumentNullException();
            //参数超出范围异常
            var aore = new ArgumentOutOfRangeException();
            //I/O异常 需要加载System.io,文件路径没找到异常
            var dne = new DirectoryNotFoundException();
            //文件没有找到异常
            var fne = new FileNotFoundException();
            //非法运算符异常
            var ioe = new InvalidOperationException();
            //未实现异常
            var nie = new NotImplementedException();
        }


    }
}
