namespace CSharpBasic.Services
{
    public class DemoService
    {
        public string PublicMethod()
        {
            return "result";
        }
        
        internal string InternalMethod()
        {
            return "result";
        }

        protected string ProtectedMethod()
        {
            return "result";
        }

        private string PrivateMethod()
        {
            return "result";
        }
    }
}