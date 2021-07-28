namespace CSharpBasic.Services
{
    public class DemoService
    {
        public static string Property { get; set; }

        public string GetProperty()
        {
            return Property + "s";
        }

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