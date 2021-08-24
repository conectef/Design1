namespace Design1.Controllers
{
    public class ApiSingletonControler
    {
        [httpGet()]
        public TactionResult Get()
        {
            var singleton = Singleton.instance();
            return ok(singleton);   
        }
    }
}