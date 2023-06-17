namespace strings
{
    class StringSet
    {
        private HashSet<string> set;

        public StringSet()
        {
            set = new HashSet<string>();
        }

        public void Add(string value)
        {
            set.Add(value);
        }

        public static StringSet operator +(StringSet set1, StringSet set2)
        {
            StringSet resultSet = new StringSet();

            foreach (string value in set1.set)
            {
                resultSet.Add(value);
            }

            foreach (string value in set2.set)
            {
                resultSet.Add(value);
            }

            return resultSet;
        }

        public static StringSet operator &(StringSet set1, StringSet set2)
        {
            StringSet resultSet = new StringSet();

            foreach (string value in set1.set)
            {
                if (set2.set.Contains(value))
                {
                    resultSet.Add(value);
                }
            }

            return resultSet;
        }

        public void Print()
        {
            foreach (string value in set)
            {
                Console.WriteLine(value);
            }
        }
    }

    class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int columns;

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            this.rows = rows;
            this.columns = columns;
        }

        public int this[int row, int column]
        {
            get { return matrix[row, column]; }
            set { matrix[row, column] = value; }
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class StringCollection
    {
        private List<string> collection;

        public StringCollection()
        {
            collection = new List<string>();
        }

        public string this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }

        public void Add(string value)
        {
            collection.Add(value);
        }

        public void Print()
        {
            foreach (string value in collection)
            {
                Console.WriteLine(value);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StringSet set1 = new StringSet();
            set1.Add("apple");
            set1.Add("banana");
            set1.Add("orange");

            StringSet set2 = new StringSet();
            set2.Add("banana");
            set2.Add("grape");

            StringSet unionSet = set1 + set2;
            Console.WriteLine("Union Set:");
            unionSet.Print();

            StringSet intersectionSet = set1 & set2;
            Console.WriteLine("Intersection Set:");
            intersectionSet.Print();

            Console.WriteLine();

            Matrix matrix = new Matrix(3, 3);
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            Console.WriteLine("Matrix:");
            matrix.Print();

            Console.WriteLine();
            Console.WriteLine("Matrix[1, 1]: " + matrix[1, 1]);

            Console.WriteLine();

            StringCollection collection = new StringCollection();
            collection.Add("one");
            collection.Add("two");
            collection.Add("three");

            Console.WriteLine("String Collection:");
            collection.Print();

            Console.WriteLine();
            Console.WriteLine("String Collection[1]: " + collection[1]);
        }
    }
}