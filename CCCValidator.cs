using System.Text.RegularExpressions;
public class CCCValidator
{
    public static bool ValidarCCC(string ccc)
    {

        // Eliminar caracteres que no sean números
        // ccc = new string(ccc.Where(char.IsDigit).ToArray());
        ccc = ccc.Replace(" ","").Replace("-","");

        // Validar el formato del CCC
        if (!Regex.IsMatch(ccc, @"^[0-9]{20}$"))
        {
            return false;
        }

        int[] pesos = { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
        int suma = 0;
        for (int i = 0; i < pesos.Length; i++)
        {
            suma += int.Parse(ccc[i].ToString()) * pesos[i];
        }

        int digitoControl = 11 - (suma % 11);
        if (digitoControl == 11) digitoControl = 0;
        if (digitoControl == 10) digitoControl = 1;

        // Validar el dígito de control
        if (digitoControl != int.Parse(ccc[10].ToString()))
        {
            return false;
        }
        return true;
    }

}

