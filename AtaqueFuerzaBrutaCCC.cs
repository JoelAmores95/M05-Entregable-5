public class AtaqueFuerzaBruta
{
    public static void AtaqueCCC(string numCCC)
    {

        while (!CCCValidator.ValidarCCC(numCCC))
        {

            // Eliminar espacios y / o guiones
            numCCC = numCCC.Replace(" ", "").Replace("-", "");
            // Reemplazar 
            for (int i = 1; i <= 999999; i++)
            {
                string number = i.ToString().PadLeft(6, '0');
                numCCC = numCCC.Replace("X", number);

                if (CCCValidator.ValidarCCC(numCCC))
                {
                    Console.WriteLine("Encontrado! " + i);
                    break;
                }
            }
        }
    }
}