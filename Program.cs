class MainClass
{
    public static void Main(string[] args)
    {
        static void SortArray(in int[] inputArr, out int[] sorteddesc, out int[] sortedasc)
        {
            sortedasc = SortArrayAsc(inputArr);
            sorteddesc = SortArrayDesc(inputArr);
        }

        static int[] SortArrayAsc(int[] intArr)
        {
            return intArr.OrderBy(x => x).ToArray();
        }
        static int[] SortArrayDesc(int[] intArr)
        {
            return intArr.OrderByDescending(x => x).ToArray();
        }

        SortArray(new int[] { 1, 2, 3, 10, 9 }, out int[] des, out int[] asc);

        foreach (int i in des)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-----------------------");
        foreach (int i in asc)
        {
            Console.WriteLine(i);
        }
    }
}