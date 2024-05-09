namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 5, 7 };
            int length = myArray.Length;
            int temp = 0;
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");
            for (int i = 0; i < (myArray.Length / 2); i++)
            {
                temp = myArray[i];
                myArray[i] = myArray[myArray.Length - 1 - i];
                myArray[myArray.Length - i - 1] = temp;
            }

            foreach (int i in myArray)
            {
                Console.WriteLine(i);

                Console.WriteLine(" ");
                //this is a comment
                //this is a comment

            }
            
        }
    }
}
