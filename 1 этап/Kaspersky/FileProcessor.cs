using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspersky
{
    public class FileProcessor
    {

        private string _parseText;//текст после обработки
        public string parseText => _parseText;

        public void ProcessFile(string fileName)
        {
            var name_Format = fileName.Split('.');
            if (name_Format.Length == 1)
                throw new Exception("Неверное название файла");

            switch (name_Format.Last())//Last на случай, если файл имеет название с множеством точек
            {
                case "txt":
                    FileTXT fileTXT = new FileTXT();
                    _parseText = fileTXT.FileParser(fileName);
                    break;
                case "html":
                    FileHTML fileHTML = new FileHTML();
                    _parseText = fileHTML.FileParser(fileName);
                    break;
                case "json":
                    FileJSON fileJSON = new FileJSON();
                    _parseText = fileJSON.FileParser(fileName);
                    break;
                default:
                    throw new Exception("Данный формат не был заявлен");
            }
        }
    }
}
