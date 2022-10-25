using System;

class Program
{
    
    public static void Main()
    {
        int nbr;
        nbr = 3;
        int[] My_Num = new int[7] ;
        My_Num[0] = 1;
        My_Num[1] = 2;
        My_Num[2] = 3;
        My_Num[3] = 4;
        My_Num[4] = 5;
        My_Num[5]= 6;
        My_Num[6] = nbr;
        int tmp;
        for(int i=My_Num.Length-2 ,j= My_Num.Length-1 ; My_Num[i]> My_Num[j]; i--,j--){
            tmp = My_Num[i];
            My_Num[i] = My_Num[j];
            My_Num[j] = tmp;

        }

        for (int i = 0; i < My_Num.Length; i++)
        {
            Console.WriteLine(My_Num[i]);
        }


    }
}
