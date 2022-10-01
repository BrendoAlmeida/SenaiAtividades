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
        public static void VerificarPastaArquivo(string path)
        {
            string pasta = path.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(path))
            {
                using (File.Create(path)) { }
            }
        }
    }

}
