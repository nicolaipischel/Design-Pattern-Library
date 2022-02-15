namespace Strategy.Quack
{
    public class NoQuacking : IQuackStrategy
    {
        public void Quack()
        {
            throw new System.NotImplementedException();
        }
    }
}