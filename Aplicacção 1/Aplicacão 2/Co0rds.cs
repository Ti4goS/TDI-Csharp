using System;
namespace Aplicacão_2
{
    public partial class Co0rds
    {
        private int x;
        private int y;

        public Co0rds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Co0rds
    {
        public void PrintCo0rds()
        {
            Console.WriteLine("Co0rds: {0},{1}",x, y);
        }
    }
}

