using System.IO;
using System.Text;
static string EncryptSkitala(string text, int d)
{
    var k = text.Length % d;
    if (k > 0)
    {
        //дополняем строку пробелами
        text += new string(' ', d - k);
    }

    var column = text.Length / d;
    var result = "";

    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < d; j++)
        {
            result += text[i + column * j].ToString();
        }
    }

    return result;
}
static string InputCodeWord()
{
    
    string codeWord4 = Console.ReadLine();
    codeWord4.Replace(" ", "").ToUpper();
    string codeWord3 = codeWord4.Replace(" ", "").ToUpper();
    return codeWord3;
}
static string SayVingere()
{
    string alphabet = "";
    for (char c = 'А'; c <= 'Я'; c++)
        alphabet += c;
    alphabet = alphabet.Replace(" ", "").ToUpper();
    alphabet = alphabet.Replace("Ч", ""); // для консперации

    return alphabet;

}
static string DecryptSkitala(string text, int d)
{
    var column = text.Length / d;
    var symbols = new char[text.Length];
    int index = 0;
    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < d; j++)
        {
            symbols[i + column * j] = text[index];
            index++;
        }
    }
    return string.Join("", symbols);
}
static string VigenereCoderCode(string alphabet, string codeWord, string question)
{
    int n = alphabet.Length;

    string answer = "";
    for (int i = 0; i < question.Length; i++)
        answer += alphabet[(alphabet.IndexOf(question[i]) + alphabet.IndexOf(codeWord[i % codeWord.Length])) % n];

    return answer;
}
static string VigenereCoderDecode(string alphabet, string codeWord, string question)
{
    int n = alphabet.Length;

    string answer = "";
    for (int i = 0; i < question.Length; i++)
        answer += alphabet[(alphabet.IndexOf(question[i]) + n - alphabet.IndexOf(codeWord[i % codeWord.Length])) % n];

    return answer;
}
static void Menu()
{
    Console.WriteLine("1.Шифровка винжера");
    Console.WriteLine("2.Шифровка XOR");
    Console.WriteLine("3.Шифровка Скитала");
    Console.WriteLine("7.Выход");
}
//генератор повторений пароля
static string GetRepeatKey(string s, int n)
{
    var r = s;
    while (r.Length < n)
    {
        r += r;
    }

    return r.Substring(0, n);
}

//метод шифрования/дешифровки
static string Cipher(string text, string secretKey)
{
    var currentKey = GetRepeatKey(secretKey, text.Length);
    var res = string.Empty;
    for (var i = 0; i < text.Length; i++)
    {
        res += ((char)(text[i] ^ currentKey[i])).ToString();
    }

    return res;
}

//шифрование текста
static string Encrypt(string plainText, string password)
    => Cipher(plainText, password);

//расшифровка текста
static string Decrypt(string encryptedText, string password)
    => Cipher(encryptedText, password);
string s;
int opt;
do
{
    Console.WriteLine("1.Считать из файла");
    Console.WriteLine("2.Ввести самим");
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 1:
            string path = "Input.txt";
            s = File.ReadAllText(path);
            Console.WriteLine($"Ваша строка - {s}");
            
            int opt2;
            
            do
            {
                Menu();
                opt2 = int.Parse(Console.ReadLine());
                switch (opt2)
                {
                    case 1:
                        string alphabet = SayVingere();
                        string codeWord3 = InputCodeWord();
                        string question4 = s.Replace(" ", "").ToUpper();
                        string answer2 = VigenereCoderCode(alphabet, codeWord3, question4);
                        Console.WriteLine("{0} => {1}", question4, answer2);
                        string decoded2 = VigenereCoderDecode(alphabet, codeWord3, answer2);
                        Console.WriteLine("{0} <= {1}", decoded2, answer2);
                        break;
                    case 2:
                        
                        Console.Write("Введите пароль: ");
                        var pass = Console.ReadLine();
                        var encryptedMessageByPass = Encrypt(s, pass);
                        Console.WriteLine("Зашифрованное сообщение {0}", encryptedMessageByPass);
                        Console.WriteLine("Расшифрованное сообщение {0}", Decrypt(encryptedMessageByPass, pass));
                        Console.ReadLine();
                        
                        break;
                    case 3:
                        
                        Console.Write("Введите диаметр цилиндра: ");
                        var diameter = Convert.ToInt32(Console.ReadLine());
                        var encText = EncryptSkitala(s, diameter);
                        Console.WriteLine("Зашифрованный текст: {0}", encText);
                        Console.WriteLine("Расшифрованный текст: {0}", DecryptSkitala(encText, diameter));
                        Console.ReadLine();
                        break;
                        break;
                }
            } while (opt2 != 7);
            break;
        case 2:
            Console.WriteLine("Введите вашу строку");
            string str = Console.ReadLine();
            int opt3;

            do
            {
                Menu();
                opt2 = int.Parse(Console.ReadLine());
                switch (opt2)
                {
                    case 1:
                        string alphabet = SayVingere();
                        Console.WriteLine("Введите кодовое слово");
                        string codeWord3 = InputCodeWord();
                        string question4 = str.Replace(" ", "").ToUpper();
                        string answer2 = VigenereCoderCode(alphabet, codeWord3, question4);
                        Console.WriteLine("{0} => {1}", question4, answer2);
                        string decoded2 = VigenereCoderDecode(alphabet, codeWord3, answer2);
                        Console.WriteLine("{0} <= {1}", decoded2, answer2);
                        break;
                    case 2:

                        Console.Write("Введите пароль: ");
                        var pass = Console.ReadLine();
                        var encryptedMessageByPass = Encrypt(str, pass);
                        Console.WriteLine("Зашифрованное сообщение {0}", encryptedMessageByPass);
                        Console.WriteLine("Расшифрованное сообщение {0}", Decrypt(encryptedMessageByPass, pass));
                        Console.ReadLine();

                        break;
                    case 3:

                        Console.Write("Введите диаметр цилиндра: ");
                        var diameter = Convert.ToInt32(Console.ReadLine());
                        var encText = EncryptSkitala(str, diameter);
                        Console.WriteLine("Зашифрованный текст: {0}", encText);
                        Console.WriteLine("Расшифрованный текст: {0}", DecryptSkitala(encText, diameter));
                        Console.ReadLine();
                        break;
                        break;
                }
            } while (opt2 != 7);
            break;
    }
//}
} while (opt != 3);