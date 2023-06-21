using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Application = Microsoft.Office.Interop.Word.Application;
using Word = Microsoft.Office.Interop.Word;

namespace WpfApp1
{
    internal class WordHelper
    {
        private FileInfo _fileInfo;
        public string day1;
        public WordHelper(string fileName, string day)
        {
            day1 = day;
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("Файла не существует");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Application app = null;
            
                try
                {
                    app = new Application();
                    object file = _fileInfo.FullName;
                    object missing = Type.Missing;
                    app.Documents.Open(file);
                    foreach (var item in items)
                    {
                        Find find = app.Selection.Find;
                        find.Text = item.Key;
                        find.Replacement.Text = item.Value;

                        Object wrap = WdFindWrap.wdFindContinue;
                        Object replace = WdReplace.wdReplaceAll;

                        find.Execute(FindText: Type.Missing,
                            MatchCase: false,
                            MatchWholeWord: false,
                            MatchWildcards: false,
                            MatchSoundsLike: missing,
                            MatchAllWordForms: false,
                            Forward: true,
                            Wrap: wrap,
                            Format: false,
                            ReplaceWith: missing, Replace: replace);

                    }
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string folderName = "Отчёты";
                    string folderPath = Path.Combine(desktopPath, folderName);
                    Directory.CreateDirectory(folderPath);
                    object newFileName = Path.Combine(folderPath, "Отчёт за " + day1 + ".doc");
                    app.ActiveDocument.SaveAs2(newFileName);
                    app.ActiveDocument.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (app != null)
                    {
                        app.Quit();
                    }
                }
                return false;
            
        }
    }
}
