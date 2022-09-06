using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examin
{
    internal class WriteFileResult
    {
        public static StreamWriter sw = null;

        /// <summary>
        /// Удаление старого файла результатов
        /// </summary>
        /// <param name="path">путь файла</param>
        public static void onStart(string path)
        {
            File.Delete(path);
            sw = new StreamWriter(path);
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="str">Строка с результатом</param>
        public static void Save(string str)
        {
            sw.WriteLine(str);
        }

        /// <summary>
        /// Закрытие файла
        /// </summary>
        public static void onEnd()
        {
            sw.Close();
        }
    }
}
