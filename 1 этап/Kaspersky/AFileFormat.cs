using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspersky
{
    public abstract class AFileFormat
    {
        protected byte[] _text; //содержимое файла

        public abstract string FileParser(string fileName); //метод обработки файла

    }
}
