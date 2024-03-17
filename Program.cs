internal class Program
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    class program
    {
        private static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser<String>("Shodiq");
        }
    }
    
}