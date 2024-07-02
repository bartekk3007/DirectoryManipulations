namespace DirectoryManipulations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\48571\Downloads\Stworzone";
            try
            {
                if(Directory.Exists(path))
                {
                    Console.WriteLine("This directory already exists!");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine($"Directory succesfully created at {Directory.GetCreationTime(path).ToString("d MMMM yyyy, HH:mm:ss")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failure has happened {ex.ToString}");
            }
        }
    }
}
