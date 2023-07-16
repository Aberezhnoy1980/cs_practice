namespace lesson003_Task1;

class Program
{
    static void Main(string[] args)
    {
        //======Работа с текстом
        //Дат текст. В тексте нужно все пробелы заменить черточками,
        // маленькие буквы "к" заменить большими "К",
        // а большие "С" заменить маленькими "с".

        // Ясна ли задача?

        string text = "- Я думаю, сказал князь, улыбаясь, - что, "
        + "ежели бы вас послали вместо нашего милого Винценгероде, "
        + "вы бы взяли приступом согласие прусского короля. "
        + "Вы так красноречивы. Вы дадите мне чаю?";

        // string s = "qwerty";
        //             012345
        // s[3] // r

        string TextConverter(string message)
        {
            char[] chars = message.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ') chars[i] = '_';
                if (chars[i] == 'к') chars[i] = char.ToUpper(chars[i]);
                if (chars[i] == 'С') char.ToLower(chars[i]);
            }
            return new String(chars);
        }

        string Replace(string text, char oldValue, char newValue)
        {
            string result = String.Empty;

            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                if (text[i] == oldValue) result += $"{newValue}";
                else result += $"{text[i]}";
            }

            return result;
        }

        Console.WriteLine(TextConverter(text));
        
        string newText = Replace(text, ' ', '|');

        Console.WriteLine(newText);
        Console.WriteLine();
        newText = Replace(newText, 'к', 'К');
        Console.WriteLine(newText);
        Console.WriteLine();
        newText = Replace(newText, 'В', 'в');
        Console.WriteLine(newText);
    }
}
