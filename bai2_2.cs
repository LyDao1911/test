namespace Bai1
{
    class bai2_2
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.Write("Nhap vao so a :");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b:");
            b = Convert.ToSingle(Console.ReadLine());
            //Neu a==0 thi (1)<=> b==0
            if (a == 0)
            {
                //Neu b==0 thi pt vo so nghiem
                if (b == 0)
                {
                    Console.WriteLine("PT vo so nghiem!");
                    //nguoc lai neu b!=0 thi pt vo nghiem
                }
                else Console.WriteLine("PT vo nghiem");
            }
            else Console.WriteLine($"PT co 1 nghiem : x= {-b / a}");
            //Neu a!=0 thi pt co mot nghiem x=-b/a

        }
    }
}
