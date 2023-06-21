using Microsoft.EntityFrameworkCore;
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
using System.IO;
using System.Linq.Expressions;
using System.Windows.Navigation;
using System.Diagnostics;
//using Microsoft.Extensions.Hosting;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для DumpToWord.xaml
    /// </summary>
    public partial class DumpToWord : Window
    {
        public string dayD { get; set; }
        public DumpToWord(string day)
        {
            InitializeComponent();
            dayD = day;
        }
        // заполнение данных в базу данных и ворд
        private void change_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pso_dtp.Text))
                {
                    pso_dtp.Text = "0";
                }
                int userVal = int.Parse(pso_dtp.Text);
                if (string.IsNullOrWhiteSpace(pso_poz.Text))
                {
                    pso_poz.Text = "0";
                }
                int userVal2 = int.Parse(pso_poz.Text);
                if (string.IsNullOrWhiteSpace(pso_dver.Text))
                {
                    pso_dver.Text = "0";
                }
                int userVal3 = int.Parse(pso_dver.Text);
                if (string.IsNullOrWhiteSpace(pso_u4.Text))
                {
                    pso_u4.Text = "0";
                }
                int userVal4 = int.Parse(pso_u4.Text);

                if (string.IsNullOrWhiteSpace(p4_dtp.Text))
                {
                    p4_dtp.Text = "0";
                }
                int userVal7 = int.Parse(p4_dtp.Text);
                if (string.IsNullOrWhiteSpace(p4_poz.Text))
                {
                    p4_poz.Text = "0";
                }
                int userVal8 = int.Parse(p4_poz.Text);
                if (string.IsNullOrWhiteSpace(p4_dver.Text))
                {
                    p4_dver.Text = "0";
                }
                int userVal9 = int.Parse(p4_dver.Text);
                if (string.IsNullOrWhiteSpace(p4_u4.Text))
                {
                    p4_u4.Text = "0";
                }
                int userVal10 = int.Parse(p4_u4.Text);

                int dtp_all = userVal + userVal7;
                string dtp = dtp_all.ToString();

                int poz_all = userVal2 + userVal8;
                string poz = poz_all.ToString();

                int dver_all = userVal3 + userVal9;
                string dver = dver_all.ToString();

                int u4_all = userVal4 + userVal10;
                string u4 = u4_all.ToString();



                if (string.IsNullOrWhiteSpace(pso_odp.Text))
                {
                    pso_odp.Text = "0";
                }
                int odp1 = int.Parse(pso_odp.Text);
                if (string.IsNullOrWhiteSpace(pso_obsm.Text))
                {
                    pso_obsm.Text = "0";
                }
                int obsm1 = int.Parse(pso_obsm.Text);
                if (string.IsNullOrWhiteSpace(pso_obom.Text))
                {
                    pso_obom.Text = "0";
                }
                int obom1 = int.Parse(pso_obom.Text);
                if (string.IsNullOrWhiteSpace(pso_vzr.Text))
                {
                    pso_vzr.Text = "0";
                }
                int vzr1 = int.Parse(pso_vzr.Text);
                if (string.IsNullOrWhiteSpace(pso_vpz.Text))
                {
                    pso_vpz.Text = "0";
                }
                int vpz1 = int.Parse(pso_vpz.Text);
                if (string.IsNullOrWhiteSpace(pso_vlv.Text))
                {
                    pso_vlv.Text = "0";
                }
                int vlv1 = int.Parse(pso_vlv.Text);
                if (string.IsNullOrWhiteSpace(pso_smp.Text))
                {
                    pso_smp.Text = "0";
                }
                int smp1 = int.Parse(pso_smp.Text);
                if (string.IsNullOrWhiteSpace(pso_ovd.Text))
                {
                    pso_ovd.Text = "0";
                }
                int ovd1 = int.Parse(pso_ovd.Text);
                if (string.IsNullOrWhiteSpace(pso_gibdd.Text))
                {
                    pso_gibdd.Text = "0";
                }
                int gibdd1 = int.Parse(pso_gibdd.Text);
                if (string.IsNullOrWhiteSpace(pso_opn.Text))
                {
                    pso_opn.Text = "0";
                }
                int opn1 = int.Parse(pso_opn.Text);
                if (string.IsNullOrWhiteSpace(pso_opz.Text))
                {
                    pso_opz.Text = "0";
                }
                int opz1 = int.Parse(pso_opz.Text);
                if (string.IsNullOrWhiteSpace(pso_voda.Text))
                {
                    pso_voda.Text = "0";
                }
                int voda1 = int.Parse(pso_voda.Text);
                if (string.IsNullOrWhiteSpace(pso_patrul.Text))
                {
                    pso_patrul.Text = "0";
                }
                int patrul1 = int.Parse(pso_patrul.Text);
                if (string.IsNullOrWhiteSpace(pso_pmp.Text))
                {
                    pso_pmp.Text = "0";
                }
                int pmp1 = int.Parse(pso_pmp.Text);
                if (string.IsNullOrWhiteSpace(pso_pzs.Text))
                {
                    pso_pzs.Text = "0";
                }
                int pzs1 = int.Parse(pso_pzs.Text);
                if (string.IsNullOrWhiteSpace(pso_gt.Text))
                {
                    pso_gt.Text = "0";
                }
                int gt1 = int.Parse(pso_gt.Text);
                if (string.IsNullOrWhiteSpace(pso_gm.Text))
                {
                    pso_gm.Text = "0";
                }
                int gm1 = int.Parse(pso_gm.Text);
                if (string.IsNullOrWhiteSpace(pso_kze.Text))
                {
                    pso_kze.Text = "0";
                }
                int kze1 = int.Parse(pso_kze.Text);

                if (string.IsNullOrWhiteSpace(p4_odp.Text))
                {
                    p4_odp.Text = "0";
                }
                int odp2 = int.Parse(p4_odp.Text);
                if (string.IsNullOrWhiteSpace(p4_obsm.Text))
                {
                    p4_obsm.Text = "0";
                }
                int obsm2 = int.Parse(p4_obsm.Text);
                if (string.IsNullOrWhiteSpace(p4_obom.Text))
                {
                    p4_obom.Text = "0";
                }
                int obom2 = int.Parse(p4_obom.Text);
                if (string.IsNullOrWhiteSpace(p4_vzr.Text))
                {
                    p4_vzr.Text = "0";
                }
                int vzr2 = int.Parse(p4_vzr.Text);
                if (string.IsNullOrWhiteSpace(p4_vpz.Text))
                {
                    p4_vpz.Text = "0";
                }
                int vpz2 = int.Parse(p4_vpz.Text);
                if (string.IsNullOrWhiteSpace(p4_vlv.Text))
                {
                    p4_vlv.Text = "0";
                }
                int vlv2 = int.Parse(p4_vlv.Text);
                if (string.IsNullOrWhiteSpace(p4_smp.Text))
                {
                    p4_smp.Text = "0";
                }
                int smp2 = int.Parse(p4_smp.Text);
                if (string.IsNullOrWhiteSpace(p4_ovd.Text))
                {
                    p4_ovd.Text = "0";
                }
                int ovd2 = int.Parse(p4_ovd.Text);
                if (string.IsNullOrWhiteSpace(p4_gibdd.Text))
                {
                    p4_gibdd.Text = "0";
                }
                int gibdd2 = int.Parse(p4_gibdd.Text);
                if (string.IsNullOrWhiteSpace(p4_opn.Text))
                {
                    p4_opn.Text = "0";
                }
                int opn2 = int.Parse(p4_opn.Text);
                if (string.IsNullOrWhiteSpace(p4_opz.Text))
                {
                    p4_opz.Text = "0";
                }
                int opz2 = int.Parse(p4_opz.Text);
                if (string.IsNullOrWhiteSpace(p4_voda.Text))
                {
                    p4_voda.Text = "0";
                }
                int voda2 = int.Parse(p4_voda.Text);
                if (string.IsNullOrWhiteSpace(p4_patrul.Text))
                {
                    p4_patrul.Text = "0";
                }
                int patrul2 = int.Parse(p4_patrul.Text);
                if (string.IsNullOrWhiteSpace(p4_pmp.Text))
                {
                    p4_pmp.Text = "0";
                }
                int pmp2 = int.Parse(p4_pmp.Text);
                if (string.IsNullOrWhiteSpace(p4_pzs.Text))
                {
                    p4_pzs.Text = "0";
                }
                int pzs2 = int.Parse(p4_pzs.Text);
                if (string.IsNullOrWhiteSpace(p4_gt.Text))
                {
                    p4_gt.Text = "0";
                }
                int gt2 = int.Parse(p4_gt.Text);
                if (string.IsNullOrWhiteSpace(p4_gm.Text))
                {
                    p4_gm.Text = "0";
                }
                int gm2 = int.Parse(p4_gm.Text);
                if (string.IsNullOrWhiteSpace(p4_kze.Text))
                {
                    p4_kze.Text = "0";
                }
                int kze2 = int.Parse(p4_kze.Text);

                int odp_all = odp1 + odp2;
                string odp = odp_all.ToString();
                int obsm_all = obsm1 + obsm2;
                string obsm = obsm_all.ToString();
                int obom_all = obom1 + obom2;
                string obom = obom_all.ToString();
                int vzr_all = vzr1 + vzr2;
                string vzr = vzr_all.ToString();
                int vpz_all = vpz1 + vpz2;
                string vpz = vpz_all.ToString();
                int vlv_all = vlv1 + vlv2;
                string vlv = vlv_all.ToString();
                int smp_all = smp1 + smp2;
                string smp = smp_all.ToString();
                int ovd_all = ovd1 + ovd2;
                string ovd = ovd_all.ToString();
                int gibdd_all = gibdd1 + gibdd2;
                string gibdd = gibdd_all.ToString();
                int opn_all = opn1 + opn2;
                string opn = opn_all.ToString();
                int opz_all = opz1 + opz2;
                string opz = opz_all.ToString();
                int voda_all = voda1 + voda2;
                string voda = voda_all.ToString();
                int patrul_all = patrul1 + patrul2;
                string patrul = patrul_all.ToString();
                int pmp_all = pmp1 + pmp2;
                string pmp = pmp_all.ToString();
                int pzs_all = pzs1 + pzs2;
                string pzs = pzs_all.ToString();
                int gt_all = gt1 + gt2;
                string gt = gt_all.ToString();
                int gm_all = gm1 + gm2;
                string gm = gm_all.ToString();
                int kze_all = kze1 + kze2;
                string kze = kze_all.ToString();
                int it1 = odp1 + obsm1 + obom1 + vzr1 + vpz1 + vlv1 + smp1 + ovd1 + gibdd1 + opn1 + opz1 + voda1 + patrul1 + pmp1 + pzs1 + gt1 + gm1 + kze1;
                int it2 = odp2 + obsm2 + obom2 + vzr2 + vpz2 + vlv2 + smp2 + ovd2 + gibdd2 + opn2 + opz2 + voda2 + patrul2 + pmp2 + pzs2 + gt2 + gm2 + kze2;
                int it3 = odp_all + obsm_all + obom_all + vzr_all + vpz_all + vlv_all + smp_all + ovd_all + gibdd_all + opn_all + opz_all + voda_all + patrul_all + pmp_all + pzs_all + gt_all + gm_all + kze_all;
                string itogo1 = it1.ToString();
                string itogo2 = it2.ToString();
                string itogo = it3.ToString();

                int userVal5 = userVal + userVal2 + userVal3 + it1 + userVal4;
                string result_pso = userVal5.ToString();
                int userVal11 = userVal7 + userVal8 + userVal9 + it2 + userVal10;
                string result_p4 = userVal11.ToString();
                int all_all = int.Parse(result_pso) + int.Parse(result_p4);
                string all = all_all.ToString();


                ApplicationContext db = new ApplicationContext();
                db.Database.EnsureCreated();

                //заполнение таблицы MainCheckOuts

                db.MainCheckOuts.Load();
                MainCheckOuts pso_dtp1 = new MainCheckOuts { TypesOfDivisionId = 1, MainTypesId = 1, Count = userVal, Date = dayD };
                MainCheckOuts pso_poz1 = new MainCheckOuts { TypesOfDivisionId = 1, MainTypesId = 2, Count = userVal2, Date = dayD };
                MainCheckOuts pso_dver1 = new MainCheckOuts { TypesOfDivisionId = 1, MainTypesId = 3, Count = userVal3, Date = dayD };
                MainCheckOuts pso_dr1 = new MainCheckOuts { TypesOfDivisionId = 1, MainTypesId = 4, Count = it1, Date = dayD };
                MainCheckOuts pso_u41 = new MainCheckOuts { TypesOfDivisionId = 1, MainTypesId = 5, Count = userVal4, Date = dayD };

                MainCheckOuts p4_dtp1 = new MainCheckOuts { TypesOfDivisionId = 2, MainTypesId = 1, Count = userVal7, Date = dayD };
                MainCheckOuts p4_poz1 = new MainCheckOuts { TypesOfDivisionId = 2, MainTypesId = 2, Count = userVal8, Date = dayD };
                MainCheckOuts p4_dver1 = new MainCheckOuts { TypesOfDivisionId = 2, MainTypesId = 3, Count = userVal9, Date = dayD };
                MainCheckOuts p4_dr1 = new MainCheckOuts { TypesOfDivisionId = 2, MainTypesId = 4, Count = it2, Date = dayD };
                MainCheckOuts p4_u41 = new MainCheckOuts { TypesOfDivisionId = 2, MainTypesId = 5, Count = userVal10, Date = dayD };

                db.MainCheckOuts.Add(pso_dtp1);
                db.MainCheckOuts.Add(pso_poz1);
                db.MainCheckOuts.Add(pso_dver1);
                db.MainCheckOuts.Add(pso_dr1);
                db.MainCheckOuts.Add(pso_u41);

                db.MainCheckOuts.Add(p4_dtp1);
                db.MainCheckOuts.Add(p4_poz1);
                db.MainCheckOuts.Add(p4_dver1);
                db.MainCheckOuts.Add(p4_dr1);
                db.MainCheckOuts.Add(p4_u41);
                db.SaveChanges();

                // заполнение таблицы OtherCheckOuts

                db.OtherCheckOuts.Load();
                OtherCheckOuts pso_odp1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 1, Count = odp1, Date = dayD };
                OtherCheckOuts pso_obsm1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 2, Count = obsm1, Date = dayD };
                OtherCheckOuts pso_obom1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 3, Count = obom1, Date = dayD };
                OtherCheckOuts pso_vzr1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 4, Count = vzr1, Date = dayD };
                OtherCheckOuts pso_vpz1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 5, Count = vpz1, Date = dayD };
                OtherCheckOuts pso_vlv1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 6, Count = vlv1, Date = dayD };
                OtherCheckOuts pso_smp1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 7, Count = smp1, Date = dayD };
                OtherCheckOuts pso_ovd1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 8, Count = ovd1, Date = dayD };
                OtherCheckOuts pso_gibdd1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 9, Count = gibdd1, Date = dayD };
                OtherCheckOuts pso_opn1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 10, Count = opn1, Date = dayD };
                OtherCheckOuts pso_opz1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 11, Count = opz1, Date = dayD };
                OtherCheckOuts pso_voda1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 12, Count = voda1, Date = dayD };
                OtherCheckOuts pso_patrul1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 13, Count = patrul1, Date = dayD };
                OtherCheckOuts pso_pmp1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 14, Count = pmp1, Date = dayD };
                OtherCheckOuts pso_pzs1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 15, Count = pzs1, Date = dayD };
                OtherCheckOuts pso_gt1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 16, Count = gt1, Date = dayD };
                OtherCheckOuts pso_gm1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 17, Count = gm1, Date = dayD };
                OtherCheckOuts pso_kze1 = new OtherCheckOuts { TypesOfDivisionId = 1, OtherTypesId = 18, Count = kze1, Date = dayD };

                OtherCheckOuts p4_odp1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 1, Count = odp2, Date = dayD };
                OtherCheckOuts p4_obsm1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 2, Count = obsm2, Date = dayD };
                OtherCheckOuts p4_obom1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 3, Count = obom2, Date = dayD };
                OtherCheckOuts p4_vzr1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 4, Count = vzr2, Date = dayD };
                OtherCheckOuts p4_vpz1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 5, Count = vpz2, Date = dayD };
                OtherCheckOuts p4_vlv1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 6, Count = vlv2, Date = dayD };
                OtherCheckOuts p4_smp1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 7, Count = smp2, Date = dayD };
                OtherCheckOuts p4_ovd1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 8, Count = ovd2, Date = dayD };
                OtherCheckOuts p4_gibdd1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 9, Count = gibdd2, Date = dayD };
                OtherCheckOuts p4_opn1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 10, Count = opn2, Date = dayD };
                OtherCheckOuts p4_opz1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 11, Count = opz2, Date = dayD };
                OtherCheckOuts p4_voda1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 12, Count = voda2, Date = dayD };
                OtherCheckOuts p4_patrul1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 13, Count = patrul2, Date = dayD };
                OtherCheckOuts p4_pmp1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 14, Count = pmp2, Date = dayD };
                OtherCheckOuts p4_pzs1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 15, Count = pzs2, Date = dayD };
                OtherCheckOuts p4_gt1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 16, Count = gt2, Date = dayD };
                OtherCheckOuts p4_gm1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 17, Count = gm2, Date = dayD };
                OtherCheckOuts p4_kze1 = new OtherCheckOuts { TypesOfDivisionId = 2, OtherTypesId = 18, Count = kze2, Date = dayD };

                db.OtherCheckOuts.Add(pso_odp1);
                db.OtherCheckOuts.Add(pso_obsm1);
                db.OtherCheckOuts.Add(pso_obom1);
                db.OtherCheckOuts.Add(pso_vzr1);
                db.OtherCheckOuts.Add(pso_vpz1);
                db.OtherCheckOuts.Add(pso_vlv1);
                db.OtherCheckOuts.Add(pso_smp1);
                db.OtherCheckOuts.Add(pso_ovd1);
                db.OtherCheckOuts.Add(pso_gibdd1);
                db.OtherCheckOuts.Add(pso_opn1);
                db.OtherCheckOuts.Add(pso_opz1);
                db.OtherCheckOuts.Add(pso_voda1);
                db.OtherCheckOuts.Add(pso_patrul1);
                db.OtherCheckOuts.Add(pso_pmp1);
                db.OtherCheckOuts.Add(pso_pzs1);
                db.OtherCheckOuts.Add(pso_gt1);
                db.OtherCheckOuts.Add(pso_gm1);
                db.OtherCheckOuts.Add(pso_kze1);

                db.OtherCheckOuts.Add(p4_odp1);
                db.OtherCheckOuts.Add(p4_obsm1);
                db.OtherCheckOuts.Add(p4_obom1);
                db.OtherCheckOuts.Add(p4_vzr1);
                db.OtherCheckOuts.Add(p4_vpz1);
                db.OtherCheckOuts.Add(p4_vlv1);
                db.OtherCheckOuts.Add(p4_smp1);
                db.OtherCheckOuts.Add(p4_ovd1);
                db.OtherCheckOuts.Add(p4_gibdd1);
                db.OtherCheckOuts.Add(p4_opn1);
                db.OtherCheckOuts.Add(p4_opz1);
                db.OtherCheckOuts.Add(p4_voda1);
                db.OtherCheckOuts.Add(p4_patrul1);
                db.OtherCheckOuts.Add(p4_pmp1);
                db.OtherCheckOuts.Add(p4_pzs1);
                db.OtherCheckOuts.Add(p4_gt1);
                db.OtherCheckOuts.Add(p4_gm1);
                db.OtherCheckOuts.Add(p4_kze1);
                db.SaveChanges();

                //заполнение документа today

                var helper = new WordHelper("test.doc", dayD);
                var items = new Dictionary<string, string>
            {
                {"<dtp1>", pso_dtp.Text},
                {"<dtp2>", p4_dtp.Text},
                {"<dtp>", dtp },
                {"<poz1>", pso_poz.Text},
                {"<poz2>", p4_poz.Text},
                {"<poz>", poz },
                {"<deb1>", pso_dver.Text},
                {"<deb2>", p4_dver.Text},
                {"<deb>", dver },
                {"<u1>", pso_u4.Text},
                {"<u2>", p4_u4.Text},
                {"<u>", u4 },
                {"<dr1>", itogo1 },
                {"<dr2>", itogo2 },
                {"<dr>", itogo },
                {"<all1>", result_pso },
                {"<all2>", result_p4 },
                {"<all>", all },
                {"<odp1>", pso_odp.Text},
                {"<odp2>" , p4_odp.Text},
                {"<odp>", odp },
                {"<obsm1>", pso_obsm.Text},
                {"<obsm2>", p4_obsm.Text},
                {"<obsm>", obsm},
                {"<obom1>", pso_obom.Text},
                {"<obom2>", p4_obom.Text},
                {"<obom>", obom},
                {"<vzr1>", pso_vzr.Text},
                {"<vzr2>", p4_vzr.Text},
                {"<vzr>", vzr},
                {"<vpz1>", pso_vpz.Text},
                {"<vpz2>", p4_vpz.Text},
                {"<vpz>", vpz},
                {"<vlv1>", pso_vlv.Text},
                {"<vlv2>", p4_vlv.Text},
                {"<vlv>", vlv},
                {"<smp1>", pso_smp.Text},
                {"<smp2>", p4_smp.Text},
                {"<smp>", smp},
                {"<ovd1>", pso_ovd.Text},
                {"<ovd2>", p4_ovd.Text},
                {"<ovd>", ovd},
                {"<gibdd1>", pso_gibdd.Text},
                {"<gibdd2>", p4_gibdd.Text},
                {"<gibdd>", gibdd},
                {"<opn1>", pso_opn.Text},
                {"<opn2>", p4_opn.Text},
                {"<opn>", opn},
                {"<opz1>", pso_opz.Text},
                {"<opz2>", p4_opz.Text},
                {"<opz>", opz},
                {"<voda1>", pso_voda.Text},
                {"<voda2>", p4_voda.Text},
                {"<voda>", voda},
                {"<patrul1>", pso_patrul.Text},
                {"<patrul2>", p4_patrul.Text},
                {"<patrul>", patrul},
                {"<pmp1>", pso_pmp.Text},
                {"<pmp2>", p4_pmp.Text},
                {"<pmp>", pmp},
                {"<pzs1>", pso_pzs.Text},
                {"<pzs2>", p4_pzs.Text},
                {"<pzs>", pzs},
                {"<gt1>", pso_gt.Text},
                {"<gt2>", p4_gt.Text},
                {"<gt>", gt},
                {"<gm1>", pso_gm.Text},
                {"<gm2>", p4_gm.Text},
                {"<gm>", gm},
                {"<kze1>", pso_kze.Text},
                {"<kze2>", p4_kze.Text},
                {"<kze>", kze},
                {"<itogo1>", itogo1},
                {"<itogo2>", itogo2},
                {"<itogo>", itogo},
            };

                helper.Process(items);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();

            }
            catch (FormatException ex)
            {
                App.Logger.Error(ex, "Произошла ошибка");
                Close();
            }
        }


        // разварачивание окна другие 
        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            win1.Height += 200;
            exp1.Height += 200;
            Thickness currentMargin = change.Margin;
            currentMargin.Top += 200;
            change.Margin = currentMargin;
        }
        // сворачивание окно другие
        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            win1.Height -= 200;
            exp1.Height += 200;
            Thickness currentMargin = change.Margin;
            currentMargin.Top -= 200;
            change.Margin = currentMargin;
        }
        // открытие логов
        public string day1;
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
    }
}

