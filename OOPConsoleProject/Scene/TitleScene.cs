using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    public class TitleScene : BaseScene
    {
        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Rende()
        {
            throw new NotImplementedException();
        }

        public override void Result()
        {
            Console.WriteLine("********************");
            Console.WriteLine("       레전드 RPG     ");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요");
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
