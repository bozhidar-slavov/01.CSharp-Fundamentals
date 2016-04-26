using System;
using System.Collections.Generic;

class EmergencyRepairs
{
    static List<char> ConvertUlong (ulong number)
    {
        var output = new List<char>();
        while (number > 0)
        {
            output.Add(number % 2 == 0 ? '0' : '1');
            number /= 2;
        }

        while (output.Count < 64)
        {
            output.Add('0');
        }

        return output;
    }

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int repairKits = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        var list = ConvertUlong(number);

        for (int i = 0; i < n; i++)
        {
            int bitPositon = int.Parse(Console.ReadLine());
            if (list[bitPositon] == '1')
            {
                list[bitPositon] = '0';
            }
        }

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] == '0' && list[i + 1] == '0' && repairKits > 0)
            {
                while (list[i] == '0' && i != list.Count - 1 && repairKits > 0)
                {
                    list[i] = '1';
                    i++;
                    repairKits--;
                }
            }
        }

        if (repairKits > 0)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == '0' && repairKits > 0)
                {
                    list[i] = '1';
                    repairKits--;
                }
            }
        }
        
        list.Reverse();
        
        string output = string.Join("", list);
        ulong result = (ulong)Convert.ToInt64(output, 2);
        Console.WriteLine(result);
    }
}