using System;

namespace seaching_program_use_params_parameter
{
    class Program
    {
        static void show(int no,params int []arr)
        {
            bool flag = false;
            int ctr = 0;
            while (ctr<arr.Length)
            {
                if (arr[ctr]==no)
                {
                    flag = true;
                  
                    break;
                  
                }
                ctr = ctr + 1;
            }
            if (flag==true)
            {
                Console.WriteLine("yes :");
            }
            else
            {
                Console.WriteLine("Not Found :");
            }

        }
        static void Main(string[] args)
        {
            show(8,1,2,3,4,8,9);
            Console.WriteLine("=======");
            show(10, 1, 2, 3, 4, 8, 9);
        }
    }
}
