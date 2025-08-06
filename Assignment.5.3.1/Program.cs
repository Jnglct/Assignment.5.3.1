namespace Assignment._5._3._1
{
    internal class Program
    {
        static void PlantFlowerBed(int[] flowerBed, int n)
        { 
            int availableSpace = 0;
            for (int i = 1; i + 1  < flowerBed.Length - 1; i++)
            {
                if (flowerBed[i - 1] == 0 && flowerBed[i] == 0 && flowerBed[i + 1] == 0)
                {
                    i += 2;
                    ++availableSpace;
                }
            }
            Console.WriteLine(availableSpace >= n ? "true" : "false");

        }
        static void Main(string[] args)
        {
           PlantFlowerBed(new int[] { 1, 0, 0, 0, 1}, 1);//true
           PlantFlowerBed(new int[] { 1, 0, 0, 0, 0, 0, 1}, 2);//false
           PlantFlowerBed(new int[] { 1, 0, 0, 0, 1}, 2);//false
           PlantFlowerBed(new int[] { 1, 0, 0, 0, 1, 0, 0, 0, 0}, 2);//true
        }
    }
}
