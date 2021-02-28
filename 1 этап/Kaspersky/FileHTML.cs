using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspersky
{
    class FileHTML : AFileFormat
    {

        public override string FileParser(string fileName)
        {
            using (FileStream fStream = File.OpenRead($"{Environment.CurrentDirectory}\\{fileName}"))
            {
                _text = new byte[fStream.Length];
                fStream.Read(_text, 0, _text.Length);

                //обработка файла

            }

            return Encoding.UTF8.GetString(_text);//возвращаем что-нибудь для проверки
        }
    }
}
