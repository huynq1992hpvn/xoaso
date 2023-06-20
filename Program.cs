using System;

class Program
{
    static void Main()
    {
        
        int[] bang = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("cac gia tri cua bang");
        for (int i = 0; i < bang.Length; i++)
        {
            Console.Write(bang[i] + " ");
        }
        Console.WriteLine();




        Console.Write("nhap gia tri can xoa: ");
        int value = Convert.ToInt32(Console.ReadLine());

       
        int vitri = -1;
        for (int i = 0; i < bang.Length; i++)
        {
            if (bang[i] == value)
            {
                vitri = i;
                break;
            }
        }

        if (vitri != -1)
        {
            Console.WriteLine("phan tu xuat hien tai vi tri thu {0} ", vitri);

            for (int i = vitri; i < bang.Length - 1; i++)
            {
                bang[i] = bang[i + 1];
            }

            
            Console.WriteLine("Mang moi la:");
            for (int i = 0; i < bang.Length - 1; i++)
            {
                Console.Write(bang[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("Phan tu khong xuat hien trong mang.");
        }
        Console.ReadKey();
    }
}
