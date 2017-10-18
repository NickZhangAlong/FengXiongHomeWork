using FengXiongHomeWork.Options;
using FengXiongHomeWork.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MainStep mainStep = new MainStep();
                mainStep.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("\r\nPress Any Key To Exist.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}
