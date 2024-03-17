internal class Program
{
    public class DataGeneric<T> 
    {
        private T Data;

        public DataGeneric(T Data)
        {
            this.Data = Data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }

    class program
    {
        private static void Main(string[] args)
        {
            DataGeneric<string> dataGeneric = new DataGeneric<string>("1302223054");
            dataGeneric.PrintData();
        }
    }
    
}