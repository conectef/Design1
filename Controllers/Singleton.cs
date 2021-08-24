namespace Design1.Controllers
{
    public sealed class Singleton
    {
        public Guid Id { get; } = Guid.NewGuid();
        private static Singleton instance = null;
        private Singleton() { }

        public static Singleton instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}