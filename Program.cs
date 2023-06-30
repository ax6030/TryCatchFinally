namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLine = "No first line was read";
            try
            {
                var lines = File.ReadAllLines(args[0]);
                firstLine = (lines.Length > 0) ? lines[0] : "The file was empty";
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine("Cloud not read lines from the file : {0}", ex);
            }
            finally
            {
                Console.WriteLine(firstLine);
            }
        }
    }
}