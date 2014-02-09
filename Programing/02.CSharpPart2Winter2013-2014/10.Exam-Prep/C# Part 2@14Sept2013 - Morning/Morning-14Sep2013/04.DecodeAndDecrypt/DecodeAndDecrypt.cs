namespace _04.DecodeAndDecrypt
{
    using System;
    using System.Text;
    class DecodeAndDecrypt
    {
        static void Main()
        {
            //to get key lenght, while(curChar is digit) add to buffer
            //when scaning arrays use % arr.Lenght for indeces
            string input = Console.ReadLine(); //"KKICXDE3P5";//"BKOXHI\\EQOGX[YSOFTWARE8"; //"ABBAA6BA7";  

            string strKeyLenght = String.Empty;

            for (int i = input.Length - 1; Char.IsDigit(input[i]); i--)
            {
                strKeyLenght = input[i] + strKeyLenght;
            }

            string decryptedText = DecryptText(input.Substring(0, input.Length - 1));

            string cipher = decryptedText.Substring((decryptedText.Length) - int.Parse(strKeyLenght), int.Parse(strKeyLenght));

            //Console.WriteLine("{0}, {1}", decryptedText, cipher);
            //Console.WriteLine(cipher);
            Console.WriteLine(Decode(decryptedText.Substring(0, decryptedText.Length - cipher.Length), cipher));
            
        }

        public static char[] Decode(string text, string cipher)
        {
            int[] lettersCodes = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                lettersCodes[i] = text[i] - 'A';
            }

            for (int i = 0; i < Math.Max(lettersCodes.Length, cipher.Length); i++)
            {
                lettersCodes[i % lettersCodes.Length] = lettersCodes[i % lettersCodes.Length] ^ (cipher[i % cipher.Length] - 'A');
            }

            char[] result = new char[lettersCodes.Length];
            for (int i = 0; i < lettersCodes.Length; i++)
            {
                result[i] = (char)(lettersCodes[i] + 'A');
            }
            return result;
        }

        public static string DecryptText(string text)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int letterCount = 1;
                StringBuilder numberBuff = new StringBuilder();

                while ( i < text.Length && char.IsDigit(text[i]))
                {
                    numberBuff.Append(text[i] + "");
                    i++;
                }
                if (numberBuff.Length >= 1)
                {
                    letterCount = int.Parse(numberBuff.ToString());
                }
                if (i < text.Length)
                {
                    result.Append(new string(text[i], letterCount));
                }
            }

            return result.ToString();
        }
    }
}
