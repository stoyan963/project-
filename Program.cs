using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Продължава да изпълнява програмата докато не въведеш "изход"
        while (true)
        {
            Console.WriteLine("Напиши 'дай парола' за да генерираш парола или 'изход' за да излезеш:");
            string userInput = Console.ReadLine();

            // Проверка дали потребителят иска да излезе от програмата
            if (userInput.ToLower() == "изход")
            {
                break;
            }
            else if (userInput.ToLower() == "дай парола")
            {
                // Генериране на една случайна парола
                string password = GeneratePassword(12);
                Console.WriteLine($"Вашата нова парола е: {password}");
            }
            else
            {
                Console.WriteLine("Не разпознах командата. Моля, опитайте отново.");
            }
        }
    }

    // Метод за генериране на случайна парола
    static string GeneratePassword(int length)
    {
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        const string specialChars = "!@#$%^&*()_-+=<>?";

        // Обединяване на всички възможни символи
        string allChars = lowercase + uppercase + digits + specialChars;

        // Използване на Random за генериране на случайни символи
        Random random = new Random();
        StringBuilder password = new StringBuilder();

        // Генериране на паролата
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(allChars.Length);
            password.Append(allChars[index]);
        }

        return password.ToString();
    }
}
