using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeWork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            if (arg.Length == 1)
            {
                IOManager.FileName = arg[0];
                
                if ( IOManager.FileName.Length == 0 )
                {
                    MessageBox.Show("Программа работает только с файлами с расширением .trains",
                                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                List<DataIO.TrainData> data;
                
                if (!IOManager.ReadXMLFile(out data))
                {
                    MessageBox.Show("Не удалось прочитать выбранный файл.\nНекорректный формат.",
                                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
