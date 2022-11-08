namespace UnitTestingWithTowersOfHanoi
{
    public class TowerOfHanoiGame
    {
        //private Stack<int> _a;
        //private Stack<int> _b;
        //private Stack<int> _c;
        private Stack<int>[] _stacks = new Stack<int>[]{
            new Stack<int>(),
            new Stack<int>(),
            new Stack<int>(),
        };

        public TowerOfHanoiGame()
        {
            var firstStack = _stacks[0];
            firstStack.Push(5);
            firstStack.Push(4);
            firstStack.Push(3);
            firstStack.Push(2);
            firstStack.Push(1);
        }

        public bool Move(int fromIndex, int toIndex)
        {
            var fromStack = _stacks[fromIndex];
            var toStack = _stacks[toIndex];
            var fromNumber = fromStack.Peek();
            //var toNumber = toStack.Peek();
            var hasNumbers = toStack.TryPeek(out int toNumber);
            if (hasNumbers && toNumber < fromNumber) return false;
            fromStack.Pop();
            toStack.Push(fromNumber);
            return true;
        }

        public string GetText()
        {
            return string.Join(',', _stacks[0]) + "-"
                + string.Join(',', _stacks[1]) + "-"
                + string.Join(',', _stacks[2]);
        }
    }
}
