namespace WebApplication1
{
    public class Foo : Base
    {
        static string Checked(string s) => s ?? throw new ArgumentNullException("s");
        public Foo(string s) : base(Checked(s).Length)
        {  
        }
    }
}
