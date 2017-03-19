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
                if (text[i] == ' ') { code += " "; continue; }
                if (text[i] == 'а') { code += ".- "; continue; }
                if (text[i] == 'б') { code += "-... "; continue; }
                if (text[i] == 'в') { code += ".-- "; continue; }
                if (text[i] == 'г') { code += "--. "; continue; }
                if (text[i] == 'д') { code += "-.. "; continue; }
                if (text[i] == 'е' || text[i] == 'ё') { code += ". "; continue; }
                if (text[i] == 'ж') { code += "...- "; continue; }
                if (text[i] == 'з') { code += "--.. "; continue; }
                if (text[i] == 'и') { code += ".. "; continue; }
                if (text[i] == 'й') { code += ".--- "; continue; }
                if (text[i] == 'к') { code += "-.- "; continue; }
                if (text[i] == 'л') { code += ".-.. "; continue; }
                if (text[i] == 'м') { code += "-- "; continue; }
                if (text[i] == 'н') { code += "-. "; continue; }
                if (text[i] == 'о') { code += "--- "; continue; }
                if (text[i] == 'п') { code += ".--. "; continue; }
                if (text[i] == 'р') { code += ".-. "; continue; }
                if (text[i] == 'с') { code += "... "; continue; }
                if (text[i] == 'т') { code += "- "; continue; }
                if (text[i] == 'у') { code += "..- "; continue; }
                if (text[i] == 'ф') { code += "..-. "; continue; }
                if (text[i] == 'х') { code += ".... "; continue; }
                if (text[i] == 'ц') { code += "-.-. "; continue; }
                if (text[i] == 'ч') { code += "---. "; continue; }
                if (text[i] == 'ш') { code += "---- "; continue; }
                if (text[i] == 'щ') { code += "--.- "; continue; }
                if ((text[i] == 'ь') || (text[i] == 'ъ')) { code += "-..- "; continue; }
                if (text[i] == 'ы') { code += "-.-- "; continue; }
                if (text[i] == 'э') { code += "..-.. "; continue; }
                if (text[i] == 'ю') { code += "..-- "; continue; }
                if (text[i] == 'я') { code += ".-.- "; continue; }

                if (text[i] == '1') { code += ".---- "; continue; }
                if (text[i] == '2') { code += "..--- "; continue; }
                if (text[i] == '3') { code += "...-- "; continue; }
                if (text[i] == '4') { code += "....- "; continue; }
                if (text[i] == '5') { code += "..... "; continue; }
                if (text[i] == '6') { code += "-.... "; continue; }
                if (text[i] == '7') { code += "--... "; continue; }
                if (text[i] == '8') { code += "---.. "; continue; }
                if (text[i] == '9') { code += "----. "; continue; }
                if (text[i] == '0') { code += "----- "; continue; }

                if (text[i] == '.') { code += "...... "; continue; }
                if (text[i] == ',') { code += ".-.-.- "; continue; }
                if (text[i] == ';') { code += "-.-.-. "; continue; }
                if (text[i] == ':') { code += "---... "; continue; }
                if (text[i] == '?') { code += "..--.. "; continue; }
                if (text[i] == '!') { code += "--..-- "; continue; }
                if (text[i] == '-') { code += "-....- "; continue; }
                if (text[i] == '"') { code += ".-..-. "; continue; }
                if (text[i] == '(' || text[i] == ')') { code = code + "-.--.- "; continue; }
                if (text[i] == '/') { code += "-..-. "; continue; }
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
                    text += ' ';
                    continue;
                }
                while (code[i] != ' ')
                {
                    buff += code[i];
                    i++;
                }

                if (buff == ".-") { text += 'a'; continue; }
                if (buff == "-...") { text += 'б'; continue; }
                if (buff == ".--") { text += 'в'; continue; }
                if (buff == "--.") { text += 'г'; continue; }
                if (buff == "-..") { text += 'д'; continue; }
                if (buff == ".") { text += 'е'; continue; }
                if (buff == "...-") { text += 'ж'; continue; }
                if (buff == "--..") { text += 'з'; continue; }
                if (buff == "..") { text += 'и'; continue; }
                if (buff == ".---") { text += 'й'; continue; }
                if (buff == "-.-") { text += 'к'; continue; }
                if (buff == ".-..") { text += 'л'; continue; }
                if (buff == "--") { text += 'м'; continue; }
                if (buff == "-.") { text += 'н'; continue; }
                if (buff == "---") { text += 'о'; continue; }
                if (buff == ".--.") { text += 'п'; continue; }
                if (buff == ".-.") { text += 'р'; continue; }
                if (buff == "...") { text += 'с'; continue; }
                if (buff == "-") { text += 'т'; continue; }
                if (buff == "..-") { text += 'у'; continue; }
                if (buff == "..-.") { text += 'ф'; continue; }
                if (buff == "....") { text += 'х'; continue; }
                if (buff == "-.-.") { text += 'ц'; continue; }
                if (buff == "---.") { text += 'ч'; continue; }
                if (buff == "----") { text += 'ш'; continue; }
                if (buff == "--.-") { text += 'щ'; continue; }
                if (buff == "-..-") { text += 'ь'; continue; }
                if (buff == "-.--") { text += 'ы'; continue; }
                if (buff == "..-..") { text += 'э'; continue; }
                if (buff == "..--") { text += 'ю'; continue; }
                if (buff == ".-.-") { text += 'я'; continue; }

                if (buff == ".----") { text += '1'; continue; }
                if (buff == "..---") { text += '2'; continue; }
                if (buff == "...--") { text += '3'; continue; }
                if (buff == "....-") { text += '4'; continue; }
                if (buff == ".....") { text += '5'; continue; }
                if (buff == "-....") { text += '6'; continue; }
                if (buff == "--...") { text += '7'; continue; }
                if (buff == "---..") { text += '8'; continue; }
                if (buff == "----.") { text += '9'; continue; }
                if (buff == "-----") { text += '0'; continue; }

                if (buff == "......") { text += '.'; continue; }
                if (buff == ".-.-.-") { text += ','; continue; }
                if (buff == "-.-.-.") { text += ';'; continue; }
                if (buff == "---...") { text += ':'; continue; }
                if (buff == "..--..") { text += '?'; continue; }
                if (buff == "--..--") { text += '!'; continue; }
                if (buff == "-....-") { text += '-'; continue; }
                if (buff == ".-..-.") { text += '"'; continue; }
                if (buff == "-.--.-") { text += '('; continue; }
                if (buff == "-..-.") { text += '/'; continue; }

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
                if (text[i] == ' ') { code += " "; continue; }
                if (text[i] == 'a') { code += ".- "; continue; }
                if (text[i] == 'b') { code += "-... "; continue; }
                if (text[i] == 'c') { code += "-.-. "; continue; }
                if (text[i] == 'd') { code += "-.. "; continue; }
                if (text[i] == 'e') { code += ". "; continue; }
                if (text[i] == 'f') { code += "..-. "; continue; }
                if (text[i] == 'g') { code += "--. "; continue; }
                if (text[i] == 'h') { code += ".... "; continue; }
                if (text[i] == 'i') { code += ".. "; continue; }
                if (text[i] == 'j') { code += ".--- "; continue; }
                if (text[i] == 'k') { code += "-.- "; continue; }
                if (text[i] == 'l') { code += ".-.. "; continue; }
                if (text[i] == 'm') { code += "-- "; continue; }
                if (text[i] == 'n') { code += "-. "; continue; }
                if (text[i] == 'o') { code += "--- "; continue; }
                if (text[i] == 'p') { code += ".--. "; continue; }
                if (text[i] == 'q') { code += "--.- "; continue; }
                if (text[i] == 'r') { code += ".-. "; continue; }
                if (text[i] == 's') { code += "... "; continue; }
                if (text[i] == 't') { code += "- "; continue; }
                if (text[i] == 'u') { code += "..- "; continue; }
                if (text[i] == 'v') { code += "...- "; continue; }
                if (text[i] == 'w') { code += ".-- "; continue; }
                if (text[i] == 'x') { code += "-..- "; continue; }
                if (text[i] == 'y') { code += "-.-- "; continue; }
                if (text[i] == 'z') { code += "--.. "; continue; }

                if (text[i] == '1') { code += ".---- "; continue; }
                if (text[i] == '2') { code += "..--- "; continue; }
                if (text[i] == '3') { code += "...-- "; continue; }
                if (text[i] == '4') { code += "....- "; continue; }
                if (text[i] == '5') { code += "..... "; continue; }
                if (text[i] == '6') { code += "-.... "; continue; }
                if (text[i] == '7') { code += "--... "; continue; }
                if (text[i] == '8') { code += "---.. "; continue; }
                if (text[i] == '9') { code += "----. "; continue; }
                if (text[i] == '0') { code += "----- "; continue; }

                if (text[i] == '.') { code += "...... "; continue; }
                if (text[i] == ',') { code += ".-.-.- "; continue; }
                if (text[i] == ';') { code += "-.-.-. "; continue; }
                if (text[i] == ':') { code += "---... "; continue; }
                if (text[i] == '?') { code += "..--.. "; continue; }
                if (text[i] == '!') { code += "--..-- "; continue; }
                if (text[i] == '-') { code += "-....- "; continue; }
                if (text[i] == '"') { code += ".-..-. "; continue; }
                if (text[i] == '(' || text[i] == ')') { code += "-.--.- "; continue; }
                if (text[i] == '/') { code += "-..-. "; continue; }
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

                if (buff == ".-") { text += 'a'; continue; }
                if (buff == "-...") { text += 'b'; continue; }
                if (buff == "-.-.") { text += 'c'; continue; }
                if (buff == "-..") { text += 'd'; continue; }
                if (buff == ".") { text += 'e'; continue; }
                if (buff == "..-.") { text += 'f'; continue; }
                if (buff == "--.") { text += 'g'; continue; }
                if (buff == "....") { text += 'h'; continue; }
                if (buff == "..") { text += 'i'; continue; }
                if (buff == ".---") { text += 'j'; continue; }
                if (buff == "-.-") { text += 'k'; continue; }
                if (buff == ".-..") { text += 'l'; continue; }
                if (buff == "--") { text += 'm'; continue; }
                if (buff == "-.") { text += 'n'; continue; }
                if (buff == "---") { text += 'o'; continue; }
                if (buff == ".--.") { text += 'p'; continue; }
                if (buff == "--.-") { text += 'q'; continue; }
                if (buff == ".-.") { text += 'r'; continue; }
                if (buff == "...") { text += 's'; continue; }
                if (buff == "-") { text += 't'; continue; }
                if (buff == "..-") { text += 'u'; continue; }
                if (buff == "...-") { text += 'v'; continue; }
                if (buff == ".--") { text += 'w'; continue; }
                if (buff == "-..-") { text += 'x'; continue; }
                if (buff == "-.--") { text += 'y'; continue; }
                if (buff == "--..") { text += 'z'; continue; }

                if (buff == ".----") { text += '1'; continue; }
                if (buff == "..---") { text += '2'; continue; }
                if (buff == "...--") { text += '3'; continue; }
                if (buff == "....-") { text += '4'; continue; }
                if (buff == ".....") { text += '5'; continue; }
                if (buff == "-....") { text += '6'; continue; }
                if (buff == "--...") { text += '7'; continue; }
                if (buff == "---..") { text += '8'; continue; }
                if (buff == "----.") { text += '9'; continue; }
                if (buff == "-----") { text += '0'; continue; }

                if (buff == "......") { text += '.'; continue; }
                if (buff == ".-.-.-") { text += ','; continue; }
                if (buff == "-.-.-.") { text += ';'; continue; }
                if (buff == "---...") { text += ':'; continue; }
                if (buff == "..--..") { text += '?'; continue; }
                if (buff == "--..--") { text += '!'; continue; }
                if (buff == "-....-") { text += '-'; continue; }
                if (buff == ".-..-.") { text += '"'; continue; }
                if (buff == "-.--.-") { text += '('; continue; }
                if (buff == "-..-.") { text += '/'; continue; }
            }
            return text;
        }

        public async Task<string> TransleteCodeToEnglishAsync(string code)
        {
            return await Task<string>.Factory.StartNew(TransleteCodeToEnglish, code);
        }
    }
}
