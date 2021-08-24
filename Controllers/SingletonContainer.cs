namespace Design1.Controllers
{
    public class SingletonContainer : ControllerBase
    {
        public Guid Id { get; } = Guid.NewGuid();
             public SingletonController(SingletonContainer singletonContainer)

        {
            this.singletonContainer = singletonContainer;
        }
        [HttpGet()]
        public TactionREsult Get()
        {
        //var singleton = singletonContainer;
        return OK(singletonContainer);
        }
    }
}