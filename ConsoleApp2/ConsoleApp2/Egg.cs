using System;

namespace ConsoleApp2
{
    public class Egg
    {
        private readonly Func<IBird> _createBird;
        private bool _hasHatched ;

        public Egg(Func<IBird> createBird)
        {
            _createBird = createBird;
            _hasHatched = false;
        }

        public virtual IBird Hatch()
        {
            if (!_hasHatched)
            {
                var bird = _createBird.Invoke();
                _hasHatched = true;
                return bird;
            }

            throw new InvalidOperationException();
        }
    }
}