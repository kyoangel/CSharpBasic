namespace CSharpBasic.Services
{
    public class DemoService
    {
        public static string Property { get; set; }
        public const string Const = "123";
        public int Care { get; set; }
        public int DonCare { get; set; }


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