using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.FrameWork
{
    internal class Router
    {
        public static void Forward(string route,BookController controller)
        {

            switch (route.Tolower())
            {
                case "Help":
                    maincontrolers.Help();
                case "List":
                    controllers.List();
                    break;
                case "Single":
                    controller.Single();
                    break;
                case "clear":
                    Console.clear();
                    break;
                default:
                    break;


            }
        }
    }
}
