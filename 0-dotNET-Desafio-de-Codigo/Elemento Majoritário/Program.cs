using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for ( int i = 0; i < num.Length; i++ )
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num, num.Length));
        
    }
    public static int MajorityElement(int[] nums, int j)
    {
        int major = nums[0];
        int count = 0;
        
        for (int i = 0; i < j; i++ )
        {
            if (count == 0)
            {
                major = nums[i];
                count++;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return major;
    }
}
