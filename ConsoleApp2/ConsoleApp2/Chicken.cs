
namespace ConsoleApp2
{
    public class Chicken : IBird
    {
        public Egg Lay()
        {
            IBird Newbird() => Hatch();
            return new Egg(Newbird);
        }

        private IBird Hatch()
        {
            return new Chicken();
        }
    }

    public class Turkey : IBird
    {
        public Egg Lay()
        {
            IBird Newbird() => Hatch();
            return new Egg(Newbird);
        }

        private IBird Hatch()
        {
            return new Turkey();
        }
    }


}