namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t\t\tLab 3 ");
            Console.WriteLine("\t\t\tTask 1 ");
            Console.WriteLine();

            DRomb[] rombs = new DRomb[5];
            rombs[0] = new DRomb(5, 8, 1); 
            rombs[1] = new DRomb(7, 7, 2); 
            rombs[2] = new DRomb(4, 4, 3); 
            rombs[3] = new DRomb(6, 6, 3); 
            rombs[4] = new DRomb(8, 3, 4); 

            int squareCount = 0; 

            
            foreach (var romb in rombs)
            {
                Console.WriteLine("Ромб з діагоналями {0} і {1}, має колір {2}.", romb.D1, romb.D2, romb.Color);
                Console.WriteLine("Периметр ромба: {0}", romb.CalculatePerimeter());
                Console.WriteLine("Площа ромба: {0}", romb.CalculateArea());
                if (romb.IsSquare())
                {
                    squareCount++;
                    Console.WriteLine("Ромб є квадратом.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ромб не є квадратом.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Загальна кількість квадратів: {0}", squareCount);


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t\t\tTask 2 ");

            Console.WriteLine();

      

            PrintedPublication[] publications = new PrintedPublication[4];

            publications[0] = new Journal { Title = "Науковий Американець", Year = 2023, IssueNumber = 5 };
            publications[1] = new Book { Title = "Великий Гетсбі", Year = 1925, Author = "Ф. Скотт Фіцджеральд" };
            publications[2] = new Textbook { Title = "Вступ до алгоритмів", Year = 2009, Author = "Томас Г. Кормен", Subject = "Комп'ютерні науки" };
            publications[3] = new Journal { Title = "National Geographic", Year = 2022, IssueNumber = 12 };

           
            Array.Sort(publications, (x, y) => x.Year.CompareTo(y.Year));
            foreach (var publication in publications)
            {
                publication.Show();
                Console.WriteLine();
            }
        }
    }

    public class DRomb
    {
        private int d1; 
        private int d2; 
        private readonly int color; 

        public DRomb(int d1, int d2, int color)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.color = color;
        }

        public int D1
        {
            get { return d1; }
            set { d1 = value; }
        }

        public int D2
        {
            get { return d2; }
            set { d2 = value; }
        }

        public int Color
        {
            get { return color; }
        }

        public double CalculatePerimeter()
        {
            return 2 * (Math.Sqrt(Math.Pow(d1 / 2.0, 2) + Math.Pow(d2 / 2.0, 2)));
        }

        public double CalculateArea()
        {
            return (d1 * d2) / 2.0;
        }

        public bool IsSquare()
        {
            return d1 == d2;
        }
    }

  
   //////////////////////////////////////////////////////
  


    class PrintedPublication
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Назва: {Title}, Рік: {Year}");
        }
    }

 

    class Journal : PrintedPublication
    {
        public int IssueNumber { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Номер випуску: {IssueNumber}");
        }
    }

    class Book : PrintedPublication
    {
        public string Author { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Автор: {Author}");
        }
    }

    class Textbook : Book
    {
        public string Subject { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Тема: {Subject}");
        }
    }


}

