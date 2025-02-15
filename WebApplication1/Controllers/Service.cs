using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Controllers
{
    public class Service
    {
        public Service() { }

        public async Task Method1()
        {
            await Method2();
        }
        public async Task Method36()
        {
            Service2 service2 = new Service2();
            await service2.Method1();
            String str = null;
            Console.WriteLine(str.Substring(1));
            await Task.Delay(1000);
        }

        public async Task Method2()
        {
            await Method3();
        }



        public async Task Method3()
        {
            await Method4();
        }

        public async Task Method4()
        {
            await Method5();
        }

        public async Task Method5()
        {
            await Method6();
        }

        public async Task Method6()
        {
            await Method7();
        }

        public async Task Method7()
        {
            await Method8();
        }

        public async Task Method8()
        {
            await Method9();
        }

        public async Task Method9()
        {
            await Method10();
        }

        public async Task Method10()
        {
            await Method11();
        }

        public async Task Method11()
        {
            await Method12();
        }

        public async Task Method12()
        {
            await Method13();
        }

        public async Task Method13()
        {
            await Method14();
        }

        public async Task Method14()
        {
            await Method15();
        }

        public async Task Method15()
        {
            await Method16();
        }

        public async Task Method16()
        {
            await Method17();
        }

        public async Task Method17()
        {
            await Method18();
        }

        public async Task Method18()
        {
            await Method19();
        }

        public async Task Method19()
        {
            await Method20();
        }

        public async Task Method20()
        {
            await Method21();
        }

        public async Task Method21()
        {
            await Method22();
        }

        public async Task Method22()
        {
            await Method23();
        }

        public async Task Method23()
        {
            await Method24();
        }

        public async Task Method24()
        {
            await Method25();
        }

        public async Task Method25()
        {
            await Method26();
        }

        public async Task Method26()
        {
            await Method27();
        }

        public async Task Method27()
        {
            await Method28();
        }

        public async Task Method28()
        {
            await Method29();
        }

        public async Task Method29()
        {
            await Method30();
        }

        public async Task Method30()
        {
            await Method31();
        }

        public async Task Method31()
        {
            await Method32();
        }

        public async Task Method32()
        {
            await Method33();
        }

        public async Task Method33()
        {
            await Method34();
        }

        public async Task Method34()
        {
            await Method35();
        }

        public async Task Method35()
        {
            await Method36();
        }

        public async Task Method361()
        {
            await Method37();
        }

        public async Task Method37()
        {
            await Method38();
        }

        public async Task Method38()
        {
            await Method39();
        }

        public async Task Method39()
        {
            //await Method40();
        }


    }
}
