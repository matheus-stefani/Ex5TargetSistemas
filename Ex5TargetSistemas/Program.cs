namespace Ex5TargetSistemas
{
    using static Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite um texto:");
            List<char> list = new();
            while (true)
            {
                var a = ReadKey();
                if (a.Key == ConsoleKey.Enter) break;
                list.Insert(0, a.KeyChar);
            }
            Clear();
            WriteLine("String invertida:");
            foreach (var item in list) Write(item);

            WriteLine("\n-------------------------");
            WriteLine("String previamente definida sendo invertida:");

            string texto = "targetsistemas";

            char[] textoC = texto.ToCharArray();

            char[] textCInver = new char[textoC.Length];

            for (int i = 0; i < textoC.Length; i++) textCInver[textoC.Length - 1 - i] = textoC[i];

            WriteLine("Inversão da string: " + texto);

            foreach (var item in textCInver) Write(item);

            Write(", string invertido");

        }
    }
}
