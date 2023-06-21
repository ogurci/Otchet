using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.module;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowChoice.xaml
    /// </summary>
    public partial class WindowChoice : Window
    {
        public string day1 { get; set; }
        public WindowChoice(string day)
        {
            day1 = day;
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();
            db.MainCheckOuts.Load();

            var test = (from MainCheckOuts in db.MainCheckOuts
                        where MainCheckOuts.Date == day1
                        select MainCheckOuts).ToList();
            foreach (MainCheckOuts element in test)
                db.MainCheckOuts.Remove(element);
            DumpToWord dumpToWord = new DumpToWord(day1);
            dumpToWord.Show();
            this.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();
            db.MainCheckOuts.Load();

            var test = (from MainCheckOuts in db.MainCheckOuts
                        where MainCheckOuts.Date == day1
                        select MainCheckOuts).ToList();
            int countDtp1 = 0;
            int countDtp2 = 0;
            int countPoz1 = 0;
            int countPoz2 = 0;
            int countDeb1 = 0;
            int countDeb2 = 0;
            int countDr1 = 0;
            int countDr2 = 0;
            int countU1 = 0;
            int countU2 = 0;
            foreach (MainCheckOuts element in test)
                if ($"{element.TypesOfDivisionId}" == "1" && $"{element.MainTypesId}" == "1")
                {
                    countDtp1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.MainTypesId}" == "1")
                {
                    countDtp2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.MainTypesId}" == "2")
                {
                    countPoz1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.MainTypesId}" == "2")
                {
                    countPoz2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.MainTypesId}" == "3")
                {
                    countDeb1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.MainTypesId}" == "3")
                {
                    countDeb2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.MainTypesId}" == "4")
                {
                    countDr1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.MainTypesId}" == "4")
                {
                    countDr2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.MainTypesId}" == "5")
                {
                    countU1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.MainTypesId}" == "5")
                {
                    countU2 = element.Count;
                }



            db.OtherCheckOuts.Load();

            var test1 = (from OtherCheckOuts in db.OtherCheckOuts
                         where OtherCheckOuts.Date == day1
                         select OtherCheckOuts).ToList();

            int countOdp1 = 0;
            int countOdp2 = 0;
            int countObsm1 = 0;
            int countObsm2 = 0;
            int countObom1 = 0;
            int countObom2 = 0;
            int countVzr1 = 0;
            int countVzr2 = 0;
            int countVpz1 = 0;
            int countVpz2 = 0;
            int countVlv1 = 0;
            int countVlv2 = 0;
            int countSmp1 = 0;
            int countSmp2 = 0;
            int countOvd1 = 0;
            int countOvd2 = 0;
            int countGibdd1 = 0;
            int countGibdd2 = 0;
            int countOpn1 = 0;
            int countOpn2 = 0;
            int countOpz1 = 0;
            int countOpz2 = 0;
            int countVoda1 = 0;
            int countVoda2 = 0;
            int countPatrul1 = 0;
            int countPatrul2 = 0;
            int countPmp1 = 0;
            int countPmp2 = 0;
            int countPzs1 = 0;
            int countPzs2 = 0;
            int countGt1 = 0;
            int countGt2 = 0;
            int countGm1 = 0;
            int countGm2 = 0;
            int countKze1 = 0;
            int countKze2 = 0;


            foreach (OtherCheckOuts element in test1)
                if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "1")
                {
                    countOdp1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "1")
                {
                    countOdp2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "2")
                {
                    countObsm1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "2")
                {
                    countObsm2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "3")
                {
                    countObom1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "3")
                {
                    countObom2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "4")
                {
                    countVzr1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "4")
                {
                    countVzr2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "5")
                {
                    countVpz1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "5")
                {
                    countVpz2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "6")
                {
                    countVlv1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "6")
                {
                    countVlv2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "7")
                {
                    countSmp1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "7")
                {
                    countSmp2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "8")
                {
                    countOvd1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "8")
                {
                    countOvd2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "9")
                {
                    countGibdd1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "9")
                {
                    countGibdd2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "10")
                {
                    countOpn1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "10")
                {
                    countOpn2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "11")
                {
                    countOpz1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "11")
                {
                    countOpz2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "12")
                {
                    countVoda1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "12")
                {
                    countVoda2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "13")
                {
                    countPatrul1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "13")
                {
                    countPatrul2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "14")
                {
                    countPmp1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "14")
                {
                    countPmp2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "15")
                {
                    countPzs1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "15")
                {
                    countPzs2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "16")
                {
                    countGt1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "16")
                {
                    countGt2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "17")
                {
                    countGm1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "17")
                {
                    countGm2 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "1" && $"{element.OtherTypesId}" == "18")
                {
                    countKze1 = element.Count;
                }
                else if ($"{element.TypesOfDivisionId}" == "2" && $"{element.OtherTypesId}" == "18")
                {
                    countKze2 = element.Count;
                }



            int countDtp = countDtp1 + countDtp2;
            int countPoz = countPoz1 + countPoz2;
            int countDeb = countDeb1 + countDeb2;
            int countDr = countDr1 + countDr2;
            int countU = countU1 + countU2;
            int psoAll1 = countDtp1 + countPoz1 + countDeb1 + countDr1 + countU1;
            int p4All2 = countDtp2 + countPoz2 + countDeb2 + countDr2 + countU2;
            int psoAll = psoAll1 + p4All2;
            int countOdp = countOdp1 + countOdp2;
            int countObsm = countObsm1 + countObsm2;
            int countObom = countObom1 + countObom2;
            int countVzr = countVzr1 + countVzr2;
            int countVpz = countVpz1 + countVpz2;
            int countVlv = countVlv1 + countVlv2;
            int countSmp = countSmp1 + countSmp2;
            int countOvd = countOvd1 + countOvd2;
            int countGibdd = countGibdd1 + countGibdd2;
            int countOpn = countOpn1 + countOpn2;
            int countOpz = countOpz1 + countOpz2;
            int countVoda = countVoda1 + countVoda2;
            int countPatrul = countPatrul1 + countPatrul2;
            int countPmp = countPmp1 + countPmp2;
            int countPzs = countPzs1 + countPzs2;
            int countGt = countGt1 + countGt2;
            int countGm = countGm1 + countGm2;
            int countKze = countKze1 + countKze2;
            int psoItogo = countOdp1 + countObsm1 + countObom1 + countVzr1 + countVpz1 + countVlv1 + countSmp1 + countOvd1 + countGibdd1 + countOpn1 + countOpz1 + countVoda1 + countPatrul1 + countPmp1 + countPzs1 + countGt1 + countGm1 + countKze1;
            int p4Itogo = countOdp2 + countObsm2 + countObom2 + countVzr2 + countVpz2 + countVlv2 + countSmp2 + countOvd2 + countGibdd2 + countOpn2 + countOpz2 + countVoda2 + countPatrul2 + countPmp2 + countPzs2 + countGt2 + countGm2 + countKze2;
            int Itogo = countOdp + countObsm + countObom + countVzr + countVpz + countVlv + countSmp + countOvd + countGibdd + countOpn + countOpz + countVoda + countPatrul + countPmp + countPzs + countGt + countGm + countKze;
            var helper = new WordHelper("test.doc", day1);
            var items = new Dictionary<string, string>
            {
                {"<dtp1>", countDtp1.ToString()},
                {"<dtp2>", countDtp2.ToString()},
                {"<dtp>", countDtp.ToString()},
                {"<poz1>", countPoz1.ToString()},
                {"<poz2>", countPoz2.ToString()},
                {"<poz>", countPoz.ToString()},
                {"<deb1>", countDeb1.ToString()},
                {"<deb2>", countDeb2.ToString()},
                {"<deb>", countDeb.ToString()},
                {"<dr1>", countDr1.ToString()},
                {"<dr2>", countDr2.ToString()},
                {"<dr>", countDr.ToString()},
                {"<u1>", countU1.ToString()},
                {"<u2>", countU2.ToString()},
                {"<u>", countU.ToString()},
                {"<all1>", psoAll1.ToString()},
                {"<all2>", p4All2.ToString()},
                {"<all>", psoAll.ToString()},
                {"<odp1>", countOdp1.ToString()},
                {"<odp2>", countOdp2.ToString()},
                {"<odp>", countOdp.ToString()},
                {"<obsm1>", countObsm1.ToString()},
                {"<obsm2>", countObsm2.ToString()},
                {"<obsm>", countObsm.ToString()},
                {"<obom1>", countObom1.ToString()},
                {"<obom2>", countObom2.ToString()},
                {"<obom>", countObom.ToString()},
                {"<vzr1>", countVzr1.ToString()},
                {"<vzr2>", countVzr2.ToString()},
                {"<vzr>", countVzr.ToString()},
                {"<vpz1>", countVpz1.ToString()},
                {"<vpz2>", countVpz2.ToString()},
                {"<vpz>", countVpz.ToString()},
                {"<vlv1>", countVlv1.ToString()},
                {"<vlv2>", countVlv2.ToString()},
                {"<vlv>", countVlv.ToString()},
                {"<smp1>", countSmp1.ToString()},
                {"<smp2>", countSmp2.ToString()},
                {"<smp>", countSmp.ToString()},
                {"<ovd1>", countSmp1.ToString()},
                {"<ovd2>", countSmp2.ToString()},
                {"<ovd>", countSmp.ToString()},
                {"<gibdd1>", countGibdd1.ToString()},
                {"<gibdd2>", countGibdd2.ToString()},
                {"<gibdd>", countGibdd.ToString()},
                {"<opn1>", countOpn1.ToString()},
                {"<opn2>", countOpn2.ToString()},
                {"<opn>", countOpn.ToString()},
                {"<opz1>", countOpz1.ToString()},
                {"<opz2>", countOpz2.ToString()},
                {"<opz>", countOpz.ToString()},
                {"<voda1>", countVoda1.ToString()},
                {"<voda2>", countVoda2.ToString()},
                {"<voda>", countVoda.ToString()},
                {"<patrul1>", countPatrul1.ToString()},
                {"<patrul2>", countPatrul2.ToString()},
                {"<patrul>", countPatrul.ToString()},
                {"<pmp1>", countPmp1.ToString()},
                {"<pmp2>", countPmp2.ToString()},
                {"<pmp>", countPmp.ToString()},
                {"<pzs1>", countPzs1.ToString()},
                {"<pzs2>", countPzs2.ToString()},
                {"<pzs>", countPzs.ToString()},
                {"<gt1>", countGt1.ToString()},
                {"<gt2>", countGt2.ToString()},
                {"<gt>", countGt.ToString()},
                {"<gm1>", countGm1.ToString()},
                {"<gm2>", countGm2.ToString()},
                {"<gm>", countGm.ToString()},
                {"<kze1>", countKze1.ToString()},
                {"<kze2>", countKze2.ToString()},
                {"<kze>", countKze.ToString()},
                {"<itogo1>", psoItogo.ToString()},
                {"<itogo2>", p4Itogo.ToString()},
                {"<itogo>", Itogo.ToString()}
            };
            helper.Process(items);
            MessageBox.Show("Данные успешно внесены в файл!");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileWindow fileWindow = new FileWindow();
            fileWindow.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }
    }
}
