class Program
{
    static void Main(string[] args)
    {
        Queue<char> q1 = new Queue<char>();
        char flowerself = 'f';
        while(flowerself == 'J'|| flowerself =='G'|| flowerself == 'O'|| flowerself == 'R'|| flowerself == 'f')
        {
            flowerself = char.Parse(Console.ReadLine());
        }
    }
}