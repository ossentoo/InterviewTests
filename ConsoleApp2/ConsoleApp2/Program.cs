
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken1 = new Chicken();
            var egg = chicken1.Lay();
            var childChicken = egg.Hatch();
            childChicken = egg.Hatch();
        }
    }
}
