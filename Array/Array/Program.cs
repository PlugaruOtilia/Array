using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                ////Declare arrays

                int[] MyFirstArray = new int[5];
                MyFirstArray[0] = 10;
                MyFirstArray[1] = 9;
                MyFirstArray[2] = 8;
                MyFirstArray[3] = 7;
                MyFirstArray[4] = 6;

                int[] mySecondArray = { 1, 2, 3, 4, 5 };

                
                for (int i = 0; i < MyFirstArray.Length; i++)
                {
                    Console.WriteLine($"Firstelement{i}={MyFirstArray[i]}");
                }

                
               for (int i = 0; i <mySecondArray.Length; i++)
                {
                    Console.WriteLine($"Secondelement{i}={mySecondArray[i]}");
                }



                ////Read and print an array adeed by user
                ////1. Get array length

                int length = int.Parse(Console.ReadLine());

                ////2. Initialize array
                int[] myThirdArray = new int[length];

                ////3. Add elements to array
                for (int i = 0; i < length; i++)
                {
                   Console.WriteLine($"Add element {i}");
                    myThirdArray[i] = int.Parse(Console.ReadLine());
                }


                ////4. Print elements
                foreach (var element in myThirdArray)
                {
                    Console.WriteLine(element);

                }

                //ReverseArray();
                GetSum();
            }

            

             static int[] GetArrayFromUser()
            {
                //get lenght
                Console.WriteLine("Add the lenght of the array");
                int lenght = int.Parse(Console.ReadLine());
                //initialize
                int[] MyArray = new int[lenght];
                //Add elements to array
                for (int i = 0; i < lenght; i++)
                {
                    Console.WriteLine($"Add element {i}");
                    MyArray[i] = int.Parse(Console.ReadLine());
                }

                return MyArray;
            }
            //Reverse an array

             static void ReverseArray()
            {
                var myArray = GetArrayFromUser();
                for (int i = myArray.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{myArray[i]}, ");
                }

            }




            //Sum of all elements of on array
             static void GetSum()
            {
                var myArray = GetArrayFromUser();
                var sum = 0;
                for (int i = 0; i < myArray.Length; i++)
                {
                    sum = sum + myArray[i];// sum+=myArray[i]
                }
                Console.WriteLine($"Sum of my array is {sum}");
            }
            //Number of occurences of an element

            //Sum of all odd/even elements

            //Multiply elements from two arrays
            int[] first_array = { 1, 20, -5, 4 };
            int[] second_array = { 3, 25, 5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", first_array));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

            Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < first_array.Length; i++)
            {

                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.WriteLine("\n");



        }
    }


}
    

