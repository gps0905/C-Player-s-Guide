namespace PlayerGuide.Level24;

public class Challenge5
{

    public static void Run()
    {
        PasswordValidator validator = new PasswordValidator();


        while (true)
        {
            Console.Write("Enter a password: ");
            string? password = Console.ReadLine();
            if (password == null) break; // If the user enters a nullpassword password (Ctrl+Z) then let's be done.
            // An alternative could be to make `IsValid` handle null or to fall
            // back to some default string like the empty string ("") instead.
            // This challenge doesn't specifically call out dealing with null,
            // and it isn't easy to get a null in there in the first place. If
            // you ignored this possibility, that's fine too.

            if (validator.IsValid(password)) Console.WriteLine("That password is valid.");
            else Console.WriteLine("That password is not valid.");
        }
    }
    class PasswordValidator
    {

        public bool IsValid(String password)
        {

            if (!HasNumber(password)) return false;
            if (password.Length < 6) return false;
            if (password.Length > 13) return false;
            if (!HasUppercase(password)) return false;
            if (!HasLowercase(password)) return false;
            if (SpecialRules(password)) return false;
            return true;
        }
        

        public bool HasUppercase(String password)
        {
            foreach (var c in password)
            {
                if (Char.IsUpper(c)) return true;
            }

            return false;
        }
        
        public bool HasLowercase(String password)
        {
            foreach (var c in password)
            {
                if (Char.IsLower(c)) return true;
            }

            return false;
        }
        
        public bool HasNumber(String password)
        {
            foreach (var c in password)
            {
                if (Char.IsDigit(c)) return true;
            }

            return false;
        }

        public bool SpecialRules(String password)
        {
            foreach (var c in password)
            {
                if (c is 'T' or '&') return true; // Found an illegal character
            }

            return false;
        }
        
    }
    
    
    
}