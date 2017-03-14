using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMorseTranslator
{
    class MorseTranslator
    {

        public string TransleteRussianToCode(object textArg)
        {
            string code = string.Empty;
            string text = (string)textArg + ' ';
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') { code = code + " "; continue; }
                if (text[i] == 'а') { code = code + ".- "; continue; }
                if (text[i] == 'б') { code = code + "-... "; continue; }
                if (text[i] == 'в') { code = code + ".-- "; continue; }
                if (text[i] == 'г') { code = code + "--. "; continue; }
                if (text[i] == 'д') { code = code + "-.. "; continue; }
                if (text[i] == 'е' || text[i] == 'ё') { code = code + ". "; continue; }
                if (text[i] == 'ж') { code = code + "...- "; continue; }
                if (text[i] == 'з') { code = code + "--.. "; continue; }
                if (text[i] == 'и') { code = code + ".. "; continue; }
                if (text[i] == 'й') { code = code + ".--- "; continue; }
                if (text[i] == 'к') { code = code + "-.- "; continue; }
                if (text[i] == 'л') { code = code + ".-.. "; continue; }
                if (text[i] == 'м') { code = code + "-- "; continue; }
                if (text[i] == 'н') { code = code + "-. "; continue; }
                if (text[i] == 'о') { code = code + "--- "; continue; }
                if (text[i] == 'п') { code = code + ".--. "; continue; }
                if (text[i] == 'р') { code = code + ".-. "; continue; }
                if (text[i] == 'с') { code = code + "... "; continue; }
                if (text[i] == 'т') { code = code + "- "; continue; }
                if (text[i] == 'у') { code = code + "..- "; continue; }
                if (text[i] == 'ф') { code = code + "..-. "; continue; }
                if (text[i] == 'х') { code = code + ".... "; continue; }
                if (text[i] == 'ц') { code = code + "-.-. "; continue; }
                if (text[i] == 'ч') { code = code + "---. "; continue; }
                if (text[i] == 'ш') { code = code + "---- "; continue; }
                if (text[i] == 'щ') { code = code + "--.- "; continue; }
                if ((text[i] == 'ь') || (text[i] == 'ъ')) { code = code + "-..- "; continue; }
                if (text[i] == 'ы') { code = code + "-.-- "; continue; }
                if (text[i] == 'э') { code = code + "..-.. "; continue; }
                if (text[i] == 'ю') { code = code + "..-- "; continue; }
                if (text[i] == 'я') { code = code + ".-.- "; continue; }

                if (text[i] == '1') { code = code + ".---- "; continue; }
                if (text[i] == '2') { code = code + "..--- "; continue; }
                if (text[i] == '3') { code = code + "...-- "; continue; }
                if (text[i] == '4') { code = code + "....- "; continue; }
                if (text[i] == '5') { code = code + "..... "; continue; }
                if (text[i] == '6') { code = code + "-.... "; continue; }
                if (text[i] == '7') { code = code + "--... "; continue; }
                if (text[i] == '8') { code = code + "---.. "; continue; }
                if (text[i] == '9') { code = code + "----. "; continue; }
                if (text[i] == '0') { code = code + "----- "; continue; }

                if (text[i] == '.') { code = code + "...... "; continue; }
                if (text[i] == ',') { code = code + ".-.-.- "; continue; }
                if (text[i] == ';') { code = code + "-.-.-. "; continue; }
                if (text[i] == ':') { code = code + "---... "; continue; }
                if (text[i] == '?') { code = code + "..--.. "; continue; }
                if (text[i] == '!') { code = code + "--..-- "; continue; }
                if (text[i] == '-') { code = code + "-....- "; continue; }
                if (text[i] == '"') { code = code + ".-..-. "; continue; }
                if (text[i] == '(' || text[i] == ')') { code = code + "-.--.- "; continue; }
                if (text[i] == '/') { code = code + "-..-. "; continue; }
            }
            return code;
        }

        public async Task<string> TransleteRussianToCodeAsync(string text)
        {
            return await Task<string>.Factory.StartNew(TransleteRussianToCode, text);
        }

        public string TransleteCodeToRussian(object codeArg)
        {
            string code = (string)codeArg + ' ';
            string buff = string.Empty;
            string text = string.Empty;

            for (int i = 0; i < code.Length; i++)
            {
                buff = string.Empty;
                if (code[i] == ' ')
                {
                    text = text + ' ';
                    continue;
                }
                while (code[i] != ' ')
                {
                    buff = buff + code[i];
                    i++;
                }

                if (buff == ".-") { text = text + 'a'; continue; }
                if (buff == "-...") { text = text + 'б'; continue; }
                if (buff == ".--") { text = text + 'в'; continue; }
                if (buff == "--.") { text = text + 'г'; continue; }
                if (buff == "-..") { text = text + 'д'; continue; }
                if (buff == ".") { text = text + 'е'; continue; }
                if (buff == "...-") { text = text + 'ж'; continue; }
                if (buff == "--..") { text = text + 'з'; continue; }
                if (buff == "..") { text = text + 'и'; continue; }
                if (buff == ".---") { text = text + 'й'; continue; }
                if (buff == "-.-") { text = text + 'к'; continue; }
                if (buff == ".-..") { text = text + 'л'; continue; }
                if (buff == "--") { text = text + 'м'; continue; }
                if (buff == "-.") { text = text + 'н'; continue; }
                if (buff == "---") { text = text + 'о'; continue; }
                if (buff == ".--.") { text = text + 'п'; continue; }
                if (buff == ".-.") { text = text + 'р'; continue; }
                if (buff == "...") { text = text + 'с'; continue; }
                if (buff == "-") { text = text + 'т'; continue; }
                if (buff == "..-") { text = text + 'у'; continue; }
                if (buff == "..-.") { text = text + 'ф'; continue; }
                if (buff == "....") { text = text + 'х'; continue; }
                if (buff == "-.-.") { text = text + 'ц'; continue; }
                if (buff == "---.") { text = text + 'ч'; continue; }
                if (buff == "----") { text = text + 'ш'; continue; }
                if (buff == "--.-") { text = text + 'щ'; continue; }
                if (buff == "-..-") { text = text + 'ь'; continue; }
                if (buff == "-.--") { text = text + 'ы'; continue; }
                if (buff == "..-..") { text = text + 'э'; continue; }
                if (buff == "..--") { text = text + 'ю'; continue; }
                if (buff == ".-.-") { text = text + 'я'; continue; }

                if (buff == ".----") { text = text + '1'; continue; }
                if (buff == "..---") { text = text + '2'; continue; }
                if (buff == "...--") { text = text + '3'; continue; }
                if (buff == "....-") { text = text + '4'; continue; }
                if (buff == ".....") { text = text + '5'; continue; }
                if (buff == "-....") { text = text + '6'; continue; }
                if (buff == "--...") { text = text + '7'; continue; }
                if (buff == "---..") { text = text + '8'; continue; }
                if (buff == "----.") { text = text + '9'; continue; }
                if (buff == "-----") { text = text + '0'; continue; }

                if (buff == "......") { text = text + '.'; continue; }
                if (buff == ".-.-.-") { text = text + ','; continue; }
                if (buff == "-.-.-.") { text = text + ';'; continue; }
                if (buff == "---...") { text = text + ':'; continue; }
                if (buff == "..--..") { text = text + '?'; continue; }
                if (buff == "--..--") { text = text + '!'; continue; }
                if (buff == "-....-") { text = text + '-'; continue; }
                if (buff == ".-..-.") { text = text + '"'; continue; }
                if (buff == "-.--.-") { text = text + '('; continue; }
                if (buff == "-..-.") { text = text + '/'; continue; }

            }
            return text;
        }

        public async Task<string> TransleteCodeToRussianAsync(string code)
        {
            return await Task<string>.Factory.StartNew(TransleteCodeToRussian, code);
        }

        public string TransleteEnglishToCode(object textArg)
        {
            string code = string.Empty;
            string text = (string)textArg + ' ';
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') { code = code + " "; continue; }
                if (text[i] == 'a') { code = code + ".- "; continue; }
                if (text[i] == 'b') { code = code + "-... "; continue; }
                if (text[i] == 'c') { code = code + "-.-. "; continue; }
                if (text[i] == 'd') { code = code + "-.. "; continue; }
                if (text[i] == 'e') { code = code + ". "; continue; }
                if (text[i] == 'f') { code = code + "..-. "; continue; }
                if (text[i] == 'g') { code = code + "--. "; continue; }
                if (text[i] == 'h') { code = code + ".... "; continue; }
                if (text[i] == 'i') { code = code + ".. "; continue; }
                if (text[i] == 'j') { code = code + ".--- "; continue; }
                if (text[i] == 'k') { code = code + "-.- "; continue; }
                if (text[i] == 'l') { code = code + ".-.. "; continue; }
                if (text[i] == 'm') { code = code + "-- "; continue; }
                if (text[i] == 'n') { code = code + "-. "; continue; }
                if (text[i] == 'o') { code = code + "--- "; continue; }
                if (text[i] == 'p') { code = code + ".--. "; continue; }
                if (text[i] == 'q') { code = code + "--.- "; continue; }
                if (text[i] == 'r') { code = code + ".-. "; continue; }
                if (text[i] == 's') { code = code + "... "; continue; }
                if (text[i] == 't') { code = code + "- "; continue; }
                if (text[i] == 'u') { code = code + "..- "; continue; }
                if (text[i] == 'v') { code = code + "...- "; continue; }
                if (text[i] == 'w') { code = code + ".-- "; continue; }
                if (text[i] == 'x') { code = code + "-..- "; continue; }
                if (text[i] == 'y') { code = code + "-.-- "; continue; }
                if (text[i] == 'z') { code = code + "--.. "; continue; }

                if (text[i] == '1') { code = code + ".---- "; continue; }
                if (text[i] == '2') { code = code + "..--- "; continue; }
                if (text[i] == '3') { code = code + "...-- "; continue; }
                if (text[i] == '4') { code = code + "....- "; continue; }
                if (text[i] == '5') { code = code + "..... "; continue; }
                if (text[i] == '6') { code = code + "-.... "; continue; }
                if (text[i] == '7') { code = code + "--... "; continue; }
                if (text[i] == '8') { code = code + "---.. "; continue; }
                if (text[i] == '9') { code = code + "----. "; continue; }
                if (text[i] == '0') { code = code + "----- "; continue; }

                if (text[i] == '.') { code = code + "...... "; continue; }
                if (text[i] == ',') { code = code + ".-.-.- "; continue; }
                if (text[i] == ';') { code = code + "-.-.-. "; continue; }
                if (text[i] == ':') { code = code + "---... "; continue; }
                if (text[i] == '?') { code = code + "..--.. "; continue; }
                if (text[i] == '!') { code = code + "--..-- "; continue; }
                if (text[i] == '-') { code = code + "-....- "; continue; }
                if (text[i] == '"') { code = code + ".-..-. "; continue; }
                if (text[i] == '(' || text[i] == ')') { code = code + "-.--.- "; continue; }
                if (text[i] == '/') { code = code + "-..-. "; continue; }
            }
            return code;
        }

        public async Task<string> TransleteEnglishToCodeAsync(string text)
        {
            return await Task<string>.Factory.StartNew(TransleteEnglishToCode, text);
        }

        public string TransleteCodeToEnglish(object codeArg)
        {
            string code = (string)codeArg + ' ';
            string buff = string.Empty;
            string text = string.Empty;

            for (int i = 0; i < code.Length; i++)
            {
                buff = string.Empty;
                if (code[i] == ' ')
                {
                    text = text + ' ';
                    continue;
                }
                while (code[i] != ' ')
                {
                    buff = buff + code[i];
                    i++;
                }

                if (buff == ".-") { text = text + 'a'; continue; }
                if (buff == "-...") { text = text + 'b'; continue; }
                if (buff == "-.-.") { text = text + 'c'; continue; }
                if (buff == "-..") { text = text + 'd'; continue; }
                if (buff == ".") { text = text + 'e'; continue; }
                if (buff == "..-.") { text = text + 'f'; continue; }
                if (buff == "--.") { text = text + 'g'; continue; }
                if (buff == "....") { text = text + 'h'; continue; }
                if (buff == "..") { text = text + 'i'; continue; }
                if (buff == ".---") { text = text + 'j'; continue; }
                if (buff == "-.-") { text = text + 'k'; continue; }
                if (buff == ".-..") { text = text + 'l'; continue; }
                if (buff == "--") { text = text + 'm'; continue; }
                if (buff == "-.") { text = text + 'n'; continue; }
                if (buff == "---") { text = text + 'o'; continue; }
                if (buff == ".--.") { text = text + 'p'; continue; }
                if (buff == "--.-") { text = text + 'q'; continue; }
                if (buff == ".-.") { text = text + 'r'; continue; }
                if (buff == "...") { text = text + 's'; continue; }
                if (buff == "-") { text = text + 't'; continue; }
                if (buff == "..-") { text = text + 'u'; continue; }
                if (buff == "...-") { text = text + 'v'; continue; }
                if (buff == ".--") { text = text + 'w'; continue; }
                if (buff == "-..-") { text = text + 'x'; continue; }
                if (buff == "-.--") { text = text + 'y'; continue; }
                if (buff == "--..") { text = text + 'z'; continue; }
                
                if (buff == ".----") { text = text + '1'; continue; }
                if (buff == "..---") { text = text + '2'; continue; }
                if (buff == "...--") { text = text + '3'; continue; }
                if (buff == "....-") { text = text + '4'; continue; }
                if (buff == ".....") { text = text + '5'; continue; }
                if (buff == "-....") { text = text + '6'; continue; }
                if (buff == "--...") { text = text + '7'; continue; }
                if (buff == "---..") { text = text + '8'; continue; }
                if (buff == "----.") { text = text + '9'; continue; }
                if (buff == "-----") { text = text + '0'; continue; }

                if (buff == "......") { text = text + '.'; continue; }
                if (buff == ".-.-.-") { text = text + ','; continue; }
                if (buff == "-.-.-.") { text = text + ';'; continue; }
                if (buff == "---...") { text = text + ':'; continue; }
                if (buff == "..--..") { text = text + '?'; continue; }
                if (buff == "--..--") { text = text + '!'; continue; }
                if (buff == "-....-") { text = text + '-'; continue; }
                if (buff == ".-..-.") { text = text + '"'; continue; }
                if (buff == "-.--.-") { text = text + '('; continue; }
                if (buff == "-..-.") { text = text + '/'; continue; }

            }
            return text;
        }

        public async Task<string> TransleteCodeToEnglishAsync(string code)
        {
            return await Task<string>.Factory.StartNew(TransleteCodeToEnglish, code);
        }


    }
}
