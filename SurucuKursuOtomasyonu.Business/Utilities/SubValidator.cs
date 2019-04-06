using System.Text.RegularExpressions;

namespace SurucuKursuOtomasyonu.Business.Utilities
{
    public class SubValidator
    {
        public static bool EmailValidator(string email)
        {
            var pattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                          + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                          + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                          + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                          + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                          + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            if (string.IsNullOrEmpty(email))
                return false;
            return Regex.IsMatch(email, pattern);
        }

        public static bool ValidateNationalNumber(string arg)
        {
            var nationalNumber = arg;
            var returnValue = false;
            if (nationalNumber.Length == 11)
            {
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                var _nationalNumber = long.Parse(nationalNumber);

                var atcno = _nationalNumber / 100;
                var btcno = _nationalNumber / 100;

                C1 = atcno % 10;
                atcno = atcno / 10;
                C2 = atcno % 10;
                atcno = atcno / 10;
                C3 = atcno % 10;
                atcno = atcno / 10;
                C4 = atcno % 10;
                atcno = atcno / 10;
                C5 = atcno % 10;
                atcno = atcno / 10;
                C6 = atcno % 10;
                atcno = atcno / 10;
                C7 = atcno % 10;
                atcno = atcno / 10;
                C8 = atcno % 10;
                atcno = atcno / 10;
                C9 = atcno % 10;
                atcno = atcno / 10;
                Q1 = (10 - ((C1 + C3 + C5 + C7 + C9) * 3 + C2 + C4 + C6 + C8) % 10) % 10;
                Q2 = (10 - ((C2 + C4 + C6 + C8 + Q1) * 3 + C1 + C3 + C5 + C7 + C9) % 10) % 10;

                returnValue = btcno * 100 + Q1 * 10 + Q2 == _nationalNumber;
            }

            if (returnValue)
                return true;
            return false;
        }

        public static bool IbanValidator(string iban)
        {
            var uzunluk = iban.Length;

            if (uzunluk == 26 && !string.IsNullOrEmpty(iban) || Regex.IsMatch(iban, "^[A-Z0-9]"))
            {
                if (iban[0] != 'T' || iban[1] != 'R') return false;

                return true;
            }

            return false;
        }

        public static bool ValidateFormatPhoneNumber(string arg)
        {
            var RegexPattern = @"^(05(\d{9}))$";
            var validation = Regex.Match(arg, RegexPattern, RegexOptions.IgnoreCase);
            return validation.Success;
        }
    }
}