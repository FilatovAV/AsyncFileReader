using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AsyncFileReader
{
    public partial class Form1 : Form
    {
        string nLine;
        string[] nString;
        double nResult;
        StreamWriter sw;
        Stopwatch stopWatch;

        int numberOfFile; //число файлов

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateFile_Click(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();

            var progress_informer = new Progress<double>(progress => lblProcessing.Text = $"{progress:p2}");
            var time_informer = new Progress<Stopwatch>(elapsed_t => lblElapsedT.Text = $"{elapsed_t.Elapsed}");
            var filecount_informer = new Progress<int>(file_c => lblFileProc.Text = $"{file_c} for out {numberOfFile}");

            var task = CreateFilesAsync(progress_informer, time_informer, filecount_informer);
        }

        private async Task CreateFilesAsync(IProgress<double> progress, IProgress<Stopwatch> elapsed_t, IProgress<int> filecount_informer)
        {
            //возвращаемся в поток приложения
            await Task.Yield();

            int numberOfString; //число строк в файле
            Random rnd = new Random();
            string curFileName;

            numberOfFile = rnd.Next(1, 101);

            string workPath = $"{AppDomain.CurrentDomain.BaseDirectory}workDirectory";
            Directory.CreateDirectory(workPath);

            for (int i = 1; i <= numberOfFile; i++)
            {
                curFileName = $"{workPath}\\{System.IO.Path.GetRandomFileName()}";

                await Task.Run(async () =>
                {
                    using (StreamWriter sw = new StreamWriter(curFileName, false, System.Text.Encoding.Default))
                    {
                        numberOfString = rnd.Next(1, 10500);
                        for (int ii = 0; ii < numberOfString; ii++)
                        {
                            await sw.WriteLineAsync($"{rnd.Next(1, 3)} {(double)rnd.Next(1, 10000) / rnd.Next(1, 4)} {(double)rnd.Next(1, 10000) / rnd.Next(1, 11)}");
                        }
                    }

                    progress.Report((double)i / numberOfFile);
                    elapsed_t.Report(stopWatch);
                    filecount_informer.Report(i);
                });
            }
        }

        private void BtnNewFile_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}result.txt"))
            {
                System.IO.File.Delete($"{AppDomain.CurrentDomain.BaseDirectory}result.txt");
            }

            stopWatch = new Stopwatch();
            stopWatch.Start();
            var progress_informer = new Progress<double>(progress => lblProcessing.Text=$"{progress:p2}");
            var time_informer = new Progress<Stopwatch>(elapsed_t => lblElapsedT.Text = $"{elapsed_t.Elapsed}");
            var filecount_informer = new Progress<int>(file_c => lblFileProc.Text = $"{file_c}");

            var task = TaskMethod(progress_informer, time_informer, filecount_informer);
        }

        private async Task TaskMethod(IProgress<double> progress, IProgress<Stopwatch> elapsed_t, IProgress<int> filecount_informer)
        {
            BtnNewFile.Enabled = false;
            //возвращаемся в поток приложения
            await Task.Yield();

            string nameFile = $"{AppDomain.CurrentDomain.BaseDirectory}result.txt";

            IEnumerable<string> files = Directory.EnumerateFiles($"{AppDomain.CurrentDomain.BaseDirectory}workDirectory");
            int c = files.Count();
            int inx = 0;

            using (sw = new StreamWriter(nameFile, false))
            {
                foreach (var f in files)
                {
                    await Task.Run(async () => 
                    {
                        using (StreamReader sr = new StreamReader(f))
                        {
                            while (!sr.EndOfStream)
                            {
                                nLine = await sr.ReadLineAsync();
                                nString = nLine.Split(' ');

                                nResult = nString[0] == "1" ?
                                    double.Parse(nString[1]) * double.Parse(nString[2]) : double.Parse(nString[1]) / double.Parse(nString[2]);

                                await sw.WriteLineAsync(nResult.ToString());
                            }
                        };
                    });

                    progress.Report((double)++inx / c);
                    elapsed_t.Report(stopWatch);
                    filecount_informer.Report(inx);
                }
            }

            BtnNewFile.Enabled = true;
        }
    }
}
