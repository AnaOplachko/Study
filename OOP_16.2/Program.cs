namespace OOP_16._2
{
    class Block
    {
        private int side1, side2, side3, side4;

        public Block(int s1, int s2, int s3, int s4)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
              return false;
            
            Block block = (Block)obj;
            return (side1 == block.side1 && side2 == block.side2 && side3 == block.side3 && side4 == block.side4);
        }

        public override int GetHashCode()
        {
            return side1 ^ side3;
        }
        //переопределить то стринг,возвращающий информацию о полях блока

        public override string ToString()
        {
            return string.Format("длина первой стороны блока: {0}\nдлина второй стороны блока: {1}\n" +
                                 "ляля {2}\nlast side{3}", this.side1, this.side2, this.side3, this.side4);
        }
    }
    
    class Program
    {
        static void Main()
        {
            Block a = new Block(1, 2, 3, 4);
            Block b = new Block(1, 2, 3, 1);
            Block c = new Block(1, 2, 3, 1);

            a = b;
            
            //сравниваем а и с
            Console.WriteLine(c.Equals(a));
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(a.GetHashCode());
            //82 93 82

            Console.WriteLine(a);
        }
    }
}