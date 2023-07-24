namespace ConsoleApp1._1._1._1.dars
{
    internal class Program
    {
        //static List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {
            var collection = new List<string> { "apple", "banana", "cherry", "date" };

            // Create the threads
            Thread writeThread = new Thread(() => WriteCollectionToFile(collection));
            Thread displayThread = new Thread(() => DisplayCollection(collection));

            // Start the threads
            writeThread.Start();
            displayThread.Start();

            // Wait for the threads to finish
            writeThread.Join();
            displayThread.Join();

            // Pause the console
            Console.ReadLine();






            //var collection = new[] { "element1", "element2", "element3" };

            //Thread writeToFileThread = new Thread(() => WriteToFile(collection));
            //Thread writeToConsoleThread = new Thread(() => WriteToConsole(collection));

            //writeToFileThread.Start();
            //writeToConsoleThread.Start();

            //writeToFileThread.Join();
            //writeToConsoleThread.Join();






            //Thread thread1 = new Thread(WriteToFile);
            //thread1.Start();

            //Thread thread2 = new Thread(DisplayElements);
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();
        }
        static void WriteCollectionToFile(List<string> collection)
        {
            // Open a file for writing
            using (var writer = new StreamWriter("collection.txt"))
            {
                // Write each element of the collection to the file
                foreach (var element in collection)
                {
                    writer.WriteLine(element);
                }
            }
        }

        static void DisplayCollection(List<string> collection)
        {
            // Display each element of the collection
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }





        static void WriteToFile(string[] collection)
        {
            using (StreamWriter file = new StreamWriter(@"C:\path\to\your\file.txt"))
            {
                foreach (string element in collection)
                {
                    file.WriteLine(element);
                }
            }
        }

        static void WriteToConsole(string[] collection)
        {
            foreach (string element in collection)
            {
                Console.WriteLine(element);
            }
        }

        static void WriteToFile()
        {
            FileStream fs = new FileStream("elements.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (int n in numbers)
                {
                    writer.WriteLine(n);
                }
            }
        }
        static void DisplayElements()
        {
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }








        public static void WorkLesson()
        {
            while (true)
            {
                Console.WriteLine("Microsoft");
                Thread.Sleep(1000); 
            }
        }
        public static void Darsdagi210723()
        {
            Thread thread1 = new Thread(() =>
            {
                int c = 0;
                for (int i = 0; i < 100000000; i++) { c++; }
                Console.WriteLine(c);
            });
            thread1.Start();
            Thread thread = new Thread(() =>
            {
                int a = 0;
                for (int i = 0; i < 56435; i++)
                {
                    a++;
                }
                Console.WriteLine(a);
            });
            thread.Start();
            int b = 0;
            for (int i = 0; i < 10; i++)
            {
                b++;
            }
            Console.WriteLine(b);
        }
    }
}