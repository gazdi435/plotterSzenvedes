namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int kezdoX = Convert.ToInt32(Console.ReadLine());
            //int kezdoY = Convert.ToInt32(Console.ReadLine());
            //int vegX = Convert.ToInt32(Console.ReadLine());
            //int vegY = Convert.ToInt32(Console.ReadLine());
            //Plotter.Draw(kezdoY,kezdoY,vegX, vegY);

            List<Tool> toolsList = [new Tool('*'), new Tool('O')];

            Map map = new Map(10,10);

            Plotter plotter = new Plotter(map,toolsList,0);

            plotter.Draw(8,0);
            plotter.Draw(8,5);
            plotter.Map();
            Console.ReadLine();
        }
    }
}
