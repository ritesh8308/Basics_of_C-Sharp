using System;

namespace Day_01
{
    class Var_Const
    {
        static void Main(string[] args)
        {
            // Variable
            int score = 100;
            score = 1000;


            //Constant:
            const double PI = 3.14159;
            // PI = 3;     // ❌ compile error


            // 'var' — type is inferred by compiler (still strongly typed!)
            var city = "Mumbai";
            var count = 10;

        }
    }
}


