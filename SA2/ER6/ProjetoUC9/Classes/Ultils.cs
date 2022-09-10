namespace ProjetoUC9.Classes
{
    public static class Ultils
    {
        public static void BarraCarregamento(string Texto)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Texto);

            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }

            Console.ResetColor();
        }
    }
}