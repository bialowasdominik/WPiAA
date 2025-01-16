namespace Adapter
{
    public class FakeAdult : Adult
    {
        public FakeAdult(int age) : base(age) { }

        public override bool IsAdult()
        {
            return true;
        }
    }
}
