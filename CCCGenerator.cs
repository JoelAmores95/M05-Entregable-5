public class CCCGenerator
{
     public static string GenerateValidCCC(string cccWithX)
    {
        // Quitar espacios en blanco y convertir a mayúsculas
        cccWithX = cccWithX.Replace(" ", "").ToUpper();

        // Comprobar que el tamaño del CCC es correcto
        if (cccWithX.Length != 20)
            throw new ArgumentException("Longitud del CCC no válida");

        int lastX = cccWithX.LastIndexOf('X');
        if (lastX < 18)
            throw new ArgumentException("El CCC debe contener al menos 2 digitos 'x' al final.");

        // Generar números aleatorios
        Random random = new Random();
        string ccc;
        do
        {
            string randomNumbers =  random.Next(0, 10).ToString() + random.Next(0, 10).ToString();
            ccc = cccWithX.Substring(0, lastX - randomNumbers.Length +1) + randomNumbers;
        } while (!CCCValidator.ValidarCCC(ccc));

        Console.WriteLine(ccc);
        return ccc;
    }

}