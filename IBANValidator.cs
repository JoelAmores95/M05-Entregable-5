public class IBANValidator
{
    public static bool validarIBAN(string iban)
    {

        // Remover espacios en blanco
        iban = iban.Replace(" ", string.Empty);

        // Validar la longitud del IBAN
        if (iban.Length < 15) return false;

        var checksum = 0;
        var ibanLength = iban.Length;
        for (int charIndex = 0; charIndex < ibanLength; charIndex++)
        {
            if (iban[charIndex] == ' ') continue;

            int value;
            var c = iban[(charIndex + 4) % ibanLength];
            if ((c >= '0') && (c <= '9'))
            {
                value = c - '0';
            }
            else if ((c >= 'A') && (c <= 'Z'))
            {
                value = c - 'A';
                checksum = (checksum * 10 + (value / 10 + 1)) % 97;
                value %= 10;
            }
            else if ((c >= 'a') && (c <= 'z'))
            {
                value = c - 'a';
                checksum = (checksum * 10 + (value / 10 + 1)) % 97;
                value %= 10;
            }
            else throw new InvalidOperationException();

            checksum = (checksum * 10 + value) % 97;

        }
        return checksum == 1;

    }

}