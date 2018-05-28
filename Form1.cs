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


namespace Build4Performance
{
    public partial class Form1 : Form
    {
        //BuildContainer builds = new BuildContainer(100);
        public Form1()
        {
            InitializeComponent();
        }

        public string kaina = "";
        public string cpu = "";
        public string gpu = "";
        public string mb = "";
        public string memType = "";
        public string oc = "";
        public string caseType = "";
        public string dedamasBuildas = "";

        public List<string> cpus;
        public List<string> gpus;
        public List<string> rams;
        public List<string> cooler;
        public List<string> psu;
        public List<string> cases;
        public List<string> mbs;
        public List<string> performance;
        public List<string> ssdhdd;
        public List<string> gams;
        public List<string> zaidimai;


       /* private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder buildas = new StringBuilder();
            if (kaina == "~ 800 e")
            {
               buildas = Priorities800();
            }
            if(kaina == "~ 1100 e")
            {
                buildas = Priorities1100();
            }
            if(kaina == "~ 1600 e")
            {
                buildas = Priorities1600();
            }
            if (kaina == "~ 2000 e")
            {
                buildas = Priorities2000();
            }
        }
        private StringBuilder Priorities1600()
        {
            StringBuilder buildas = new StringBuilder();
            double buildokaina = 0;
            if (oc == "")
            {
                MessageBox.Show("Pasirinkite OC prioriteta");
            }
            else
            {
                if (oc == "TAIP")
                {
                    if (cpu == "")
                    {
                        MessageBox.Show("Pasirinkite CPU prioriteta");
                    }
                    else
                    {

                        foreach (string procas in cpus)
                        {
                            string[] dalys = procas.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("INTEL") || buildas.ToString().Contains("AMD"))
                            {
                                break;
                            }
                            if (cpu == "Nesvarbu")
                            {
                                if (gamintojas == "INTEL" && modelis == "i7-8700k" || gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == cpu && modelis == "i7-8700k" || gamintojas == cpu && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (gpu == "")
                    {
                        MessageBox.Show("Pasirinkite GPU prioriteta");
                    }
                    else
                    {
                        if (dedamasBuildas.Contains("AMD"))
                        {
                            foreach (string vaizdo in gpus)
                            {
                                string[] dalys = vaizdo.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                int atmintis = Int32.Parse(dalys[2]);
                                double price = Double.Parse(dalys[3]);
                                if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                                if (gpu == "Nesvarbu")
                                {
                                    if (modelis == "GTX1080Ti")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == gpu && modelis == "GTX1080Ti")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (string vaizdo in gpus)
                            {
                                string[] dalys = vaizdo.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                int atmintis = Int32.Parse(dalys[2]);
                                double price = Double.Parse(dalys[3]);
                                if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                                if (gpu == "Nesvarbu")
                                {
                                    if (modelis == "GTX1080")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == gpu && modelis == "GTX1080")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string maitblokis in psu)
                    {
                        string[] dalys = maitblokis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string galingumas = dalys[2];
                        double price = Double.Parse(dalys[3]);
                        if (galingumas == "750w" && price == 84)
                        {
                            buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(modelis))
                        {
                            break;
                        }

                    }
                    if (mb == "")
                    {
                        MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                    }
                    else
                    {
                        foreach (string motinine in mbs)
                        {
                            string[] dalys = motinine.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (mb == "Nesvarbu")
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (modelis.Contains("Z370") && price <= 150)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("Z370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (gamintojas == mb && modelis.Contains("Z370") && price <= 150)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("Z370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == mb && modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string ramd in rams)
                    {
                        string[] dalys = ramd.Split(',');
                        string gamintojas = dalys[0];
                        string tipas = dalys[1];
                        int daznis = Int32.Parse(dalys[2]);
                        int dydis = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                        if (dydis == 16 && daznis == 3000)
                        {
                            buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(tipas))
                        {
                            break;
                        }
                    }
                    if (memType == "")
                    {
                        MessageBox.Show("Pasirinkite atminties prioriteta");
                    }
                    else
                    {
                        if (memType == "SSD")
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (tipas == "SSD" && talpa == 500)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                            }
                        }
                    else
                     {
                         foreach (string atmintis in ssdhdd)
                         {
                             string[] dalys = atmintis.Split(',');
                             string gamintojas = dalys[0];
                             string modelis = dalys[1];
                             string tipas = dalys[2];
                             int talpa = Int32.Parse(dalys[3]);
                             double price = Double.Parse(dalys[4]);
                         if(buildas.ToString().Contains("SSD") && buildas.ToString().Contains("HDD"))
                         {
                             break;
                         }
                         if (tipas == "HDD" && !buildas.ToString().Contains("HDD"))
                         {
                             buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                             buildokaina = buildokaina + price;
                         }
                         else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                         {
                             buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                             buildokaina = buildokaina + price;
                         }
                       }
                 }
            }
                    if (dedamasBuildas.Contains("INTEL"))
                    {
                        foreach (string cool in cooler)
                        {
                            string[] dalys = cool.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (modelis == "Hyper 212 EVO")
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                            }
                            else if (buildas.ToString().Contains("Hyper 212 EVO"))
                            {
                                break;
                            }
                        }
                    }

                    if (caseType == "")
                    {
                        MessageBox.Show("Pasirinkite korpuso prioriteta");
                    }
                    else
                    {
                        foreach (string deze in cases)
                        {
                            string[] dalys = deze.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("SILENTIUMPC"))
                            {
                                break;
                            }
                            if (caseType == "Su soniniu langeliu")
                            {
                                if (modelis.Contains("W"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (price < 35)
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (cpu == "")
                    {
                        MessageBox.Show("Pasirinkite CPU prioriteta");
                    }
                    else
                    {

                        foreach (string procas in cpus)
                        {
                            string[] dalys = procas.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("INTEL") || buildas.ToString().Contains("AMD"))
                            {
                                break;
                            }
                            if (cpu == "Nesvarbu")
                            {
                                if (gamintojas == "INTEL" && modelis == "i7-8700" || gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == cpu && modelis == "i7-8700" || gamintojas == cpu && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (gpu == "")
                    {
                        MessageBox.Show("Pasirinkite GPU prioriteta");
                    }
                    else
                    {
                        foreach (string vaizdo in gpus)
                        {
                            string[] dalys = vaizdo.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            int atmintis = Int32.Parse(dalys[2]);
                            double price = Double.Parse(dalys[3]);
                            if (buildas.ToString().Contains("GTX"))
                            {
                                break;
                            }
                            if (gpu == "Nesvarbu")
                            {
                                if (modelis == "GTX1080Ti")
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == gpu && modelis == "GTX1080Ti")
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    foreach (string maitblokis in psu)
                    {
                        string[] dalys = maitblokis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string galingumas = dalys[2];
                        double price = Double.Parse(dalys[3]);
                        if (price == 84 && galingumas == "750w")
                        {
                            buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(modelis))
                        {
                            break;
                        }

                    }
                    if (mb == "")
                    {
                        MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                    }
                    else
                    {
                        foreach (string motinine in mbs)
                        {
                            string[] dalys = motinine.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (mb == "Nesvarbu")
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (modelis.Contains("H370"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("H370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (modelis.Contains("A320"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("A320"))
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (gamintojas == mb && modelis.Contains("B360"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B360"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == mb && modelis.Contains("A320"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("A320"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string ramd in rams)
                    {
                        string[] dalys = ramd.Split(',');
                        string gamintojas = dalys[0];
                        string tipas = dalys[1];
                        int daznis = Int32.Parse(dalys[2]);
                        int dydis = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                        if (dydis == 16 && daznis == 2400)
                        {
                            buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(tipas))
                        {
                            break;
                        }
                    }

                    if (memType == "")
                    {
                        MessageBox.Show("Pasirinkite atminties prioriteta");
                    }
                    else
                    {
                        if (memType == "HDD + SSD")
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD") && buildas.ToString().Contains("HDD"))
                                {
                                    break;
                                }
                                if (tipas == "HDD" && !buildas.ToString().Contains("HDD"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                
                            }
                        }
                        else
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                                if (tipas == "SSD" && talpa == 500)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    if (caseType == "")
                    {
                        MessageBox.Show("Pasirinkite korpuso prioriteta");
                    }
                    else
                    {
                        foreach (string deze in cases)
                        {
                            string[] dalys = deze.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("SILENTIUMPC"))
                            {
                                break;
                            }
                            if (caseType == "Su soniniu langeliu")
                            {
                                if (modelis.Contains("W"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (price < 35)
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            buildas.Append(buildokaina);
            string build = buildas.ToString();
            string[] parts = build.Split(',');
            foreach (string prt in parts)
            {
                listBox9.Items.Add(prt);
            }

            return buildas;
        }

        private StringBuilder Priorities2000()
        {
            StringBuilder buildas = new StringBuilder();
            double buildokaina = 0;
            if (oc == "" && cpu == "INTEL")
            {
                MessageBox.Show("Pasirinkite OC prioriteta");
            }
            else
            {
                if (oc == "TAIP")
                {
                    if (cpu == "")
                    {
                        MessageBox.Show("Pasirinkite CPU prioriteta");
                    }
                    else
                    {

                        foreach (string procas in cpus)
                        {
                            string[] dalys = procas.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("INTEL") || buildas.ToString().Contains("AMD"))
                            {
                                break;
                            }
                            if (cpu == "Nesvarbu")
                            {
                                if (gamintojas == "INTEL" && modelis == "i7-8700k" || gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == cpu && modelis == "i7-8700k" || gamintojas == cpu && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (gpu == "")
                    {
                        MessageBox.Show("Pasirinkite GPU prioriteta");
                    }
                    else
                    {
                        if (dedamasBuildas.Contains("AMD"))
                        {
                            foreach (string vaizdo in gpus)
                            {
                                string[] dalys = vaizdo.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                int atmintis = Int32.Parse(dalys[2]);
                                double price = Double.Parse(dalys[3]);
                                if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                                if (gpu == "Nesvarbu")
                                {
                                    if (modelis == "GTX1080Ti")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == gpu && modelis == "GTX1080Ti")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (string vaizdo in gpus)
                            {
                                string[] dalys = vaizdo.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                int atmintis = Int32.Parse(dalys[2]);
                                double price = Double.Parse(dalys[3]);
                                if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                                if (gpu == "Nesvarbu")
                                {
                                    if (modelis == "GTX1080Ti")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == gpu && modelis == "GTX1080Ti")
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string maitblokis in psu)
                    {
                        string[] dalys = maitblokis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string galingumas = dalys[2];
                        double price = Double.Parse(dalys[3]);
                        if (galingumas == "750w" && modelis == "SuperNovaG3")
                        {
                            buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(modelis))
                        {
                            break;
                        }

                    }
                    if (mb == "")
                    {
                        MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                    }
                    else
                    {
                        foreach (string motinine in mbs)
                        {
                            string[] dalys = motinine.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (mb == "Nesvarbu")
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (modelis.Contains("Z370") && price >= 150)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("Z370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (gamintojas == mb && modelis.Contains("Z370") && price >= 150)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("Z370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == mb && modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string ramd in rams)
                    {
                        string[] dalys = ramd.Split(',');
                        string gamintojas = dalys[0];
                        string tipas = dalys[1];
                        int daznis = Int32.Parse(dalys[2]);
                        int dydis = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                        if (dydis == 16 && daznis == 3000)
                        {
                            buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(tipas))
                        {
                            break;
                        }
                    }

                    if (memType == "")
                    {
                        MessageBox.Show("Pasirinkite atminties prioriteta");
                    }
                    else
                    {
                        if (memType == "HDD + SSD")
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD") && buildas.ToString().Contains("HDD"))
                                {
                                    break;
                                }
                                if (tipas == "HDD" && !buildas.ToString().Contains("HDD"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 500)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }

                            }
                        }
                        else
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                                if (tipas == "SSD" && talpa == 1000)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    foreach (string cool in cooler)
                    {
                        string[] dalys = cool.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        double price = Double.Parse(dalys[2]);
                        if (modelis == "NH-D15")
                        {
                            buildas.Append(gamintojas + " " + modelis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains("NH-D15"))
                        {
                            break;
                        }
                    }


                    foreach (string deze in cases)
                    {
                        string[] dalys = deze.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        double price = Double.Parse(dalys[2]);
                        if (modelis.Contains("450D"))
                        {
                            buildas.Append(gamintojas + " " + modelis + ", ");
                            buildokaina = buildokaina + price;
                        }

                        else if (buildas.ToString().Contains("450D"))
                        {
                            break;
                        }
                    }
                }

                else
                {
                    if (cpu == "")
                    {
                        MessageBox.Show("Pasirinkite CPU prioriteta");
                    }
                    else
                    {

                        foreach (string procas in cpus)
                        {
                            string[] dalys = procas.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("INTEL") || buildas.ToString().Contains("AMD"))
                            {
                                break;
                            }
                            if (cpu == "Nesvarbu")
                            {
                                if (gamintojas == "INTEL" && modelis == "i7-8700" || gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == cpu && modelis == "i7-8700" || gamintojas == cpu && modelis == "Ryzen 7 2700x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (gpu == "")
                    {
                        MessageBox.Show("Pasirinkite GPU prioriteta");
                    }
                    else
                    {
                        foreach (string vaizdo in gpus)
                        {
                            string[] dalys = vaizdo.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            int atmintis = Int32.Parse(dalys[2]);
                            double price = Double.Parse(dalys[3]);
                            if (buildas.ToString().Contains("GTX"))
                            {
                                break;
                            }
                            if (gpu == "Nesvarbu")
                            {
                                if (modelis == "GTX1080Ti")
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == gpu && modelis == "GTX1080Ti")
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    foreach (string maitblokis in psu)
                    {
                        string[] dalys = maitblokis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string galingumas = dalys[2];
                        double price = Double.Parse(dalys[3]);
                        if (modelis == "SuperNovaG3" && galingumas == "750w")
                        {
                            buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(modelis))
                        {
                            break;
                        }

                    }
                    if (mb == "")
                    {
                        MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                    }
                    else
                    {
                        foreach (string motinine in mbs)
                        {
                            string[] dalys = motinine.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (mb == "Nesvarbu")
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (modelis.Contains("H370"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("H370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (gamintojas == mb && modelis.Contains("H370"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("H370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == mb && modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string ramd in rams)
                    {
                        string[] dalys = ramd.Split(',');
                        string gamintojas = dalys[0];
                        string tipas = dalys[1];
                        int daznis = Int32.Parse(dalys[2]);
                        int dydis = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                        if (dydis == 16 && daznis == 2400)
                        {
                            buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(tipas))
                        {
                            break;
                        }
                    }

                    if (memType == "")
                    {
                        MessageBox.Show("Pasirinkite atminties prioriteta");
                    }
                    else
                    {
                        if (memType == "HDD + SSD")
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD") && buildas.ToString().Contains("HDD"))
                                {
                                    break;
                                }
                                if (tipas == "HDD" && !buildas.ToString().Contains("HDD"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 500)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }

                            }
                        }
                        else
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                                if (tipas == "SSD" && talpa == 1000)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    foreach (string deze in cases)
                    {
                        string[] dalys = deze.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        double price = Double.Parse(dalys[2]);
                        if (modelis.Contains("450D"))
                        {
                            buildas.Append(gamintojas + " " + modelis + ", ");
                            buildokaina = buildokaina + price;
                        }

                        else if (buildas.ToString().Contains("450D"))
                        {
                            break;
                        }
                    }
                }
            }
            buildas.Append(buildokaina);
            string build = buildas.ToString();
            string[] parts = build.Split(',');
            foreach (string prt in parts)
            {
                listBox9.Items.Add(prt);
            }

            return buildas;
        }

        private StringBuilder Priorities1100()
        {
            StringBuilder buildas = new StringBuilder();
            double buildokaina = 0;
            if (oc == "")
            {
                MessageBox.Show("Pasirinkite OC prioriteta");
            }
            else
            {
                if (oc == "TAIP")
                {
                    if (cpu == "")
                    {
                        MessageBox.Show("Pasirinkite CPU prioriteta");
                    }
                    else
                    {

                        foreach (string procas in cpus)
                        {
                            string[] dalys = procas.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("INTEL") || buildas.ToString().Contains("AMD"))
                            {
                                break;
                            }
                            if (cpu == "Nesvarbu")
                            {
                                if (gamintojas == "INTEL" && modelis == "i5-8600k" || gamintojas == "AMD" && modelis == "Ryzen 5 2600x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == cpu && modelis == "i5-8600k" || gamintojas == cpu && modelis == "Ryzen 5 2600x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (gpu == "")
                    {
                        MessageBox.Show("Pasirinkite GPU prioriteta");
                    }
                    else
                    {
                        if (dedamasBuildas.Contains("AMD"))
                        {
                            foreach (string vaizdo in gpus)
                            {
                                string[] dalys = vaizdo.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                int atmintis = Int32.Parse(dalys[2]);
                                double price = Double.Parse(dalys[3]);
                                if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                                if (gpu == "Nesvarbu")
                                {
                                    if (modelis == "GTX1060" && atmintis == 6)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == gpu && modelis == "GTX1060" && atmintis == 6)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (string vaizdo in gpus)
                            {
                                string[] dalys = vaizdo.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                int atmintis = Int32.Parse(dalys[2]);
                                double price = Double.Parse(dalys[3]);
                                if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                                if (gpu == "Nesvarbu")
                                {
                                    if (modelis == "GTX1060" && atmintis == 3)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == gpu && modelis == "GTX1060" && atmintis == 3)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("GTX"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string maitblokis in psu)
                    {
                        string[] dalys = maitblokis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string galingumas = dalys[2];
                        double price = Double.Parse(dalys[3]);
                        if (galingumas == "650w" && price == 75)
                        {
                            buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(modelis))
                        {
                            break;
                        }

                    }
                    if (mb == "")
                    {
                        MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                    }
                    else
                    {
                        foreach (string motinine in mbs)
                        {
                            string[] dalys = motinine.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (mb == "Nesvarbu")
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (modelis.Contains("Z370") && price <= 150)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("Z370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (gamintojas == mb && modelis.Contains("Z370") && price <= 150)
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("Z370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == mb && modelis.Contains("B350"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B350"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string ramd in rams)
                    {
                        string[] dalys = ramd.Split(',');
                        string gamintojas = dalys[0];
                        string tipas = dalys[1];
                        int daznis = Int32.Parse(dalys[2]);
                        int dydis = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                        if (dydis == 16 && daznis == 3000)
                        {
                            buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(tipas))
                        {
                            break;
                        }
                    }
                    if (memType == "")
                    {
                        MessageBox.Show("Pasirinkite atminties prioriteta");
                    }
                    else
                    {
                        if (memType == "SSD")
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (tipas == "SSD" && talpa == 500)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD") && buildas.ToString().Contains("HDD"))
                                {
                                    break;
                                }
                                if (tipas == "HDD" && !buildas.ToString().Contains("HDD"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                            }
                        }
                    }
                    if (dedamasBuildas.Contains("INTEL"))
                    {
                        foreach (string cool in cooler)
                        {
                            string[] dalys = cool.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (modelis == "Hyper 212 EVO")
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                            }
                            else if (buildas.ToString().Contains("Hyper 212 EVO"))
                            {
                                break;
                            }
                        }
                    }

                    if (caseType == "")
                    {
                        MessageBox.Show("Pasirinkite korpuso prioriteta");
                    }
                    else
                    {
                        foreach (string deze in cases)
                        {
                            string[] dalys = deze.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("SILENTIUMPC"))
                            {
                                break;
                            }
                            if (caseType == "Su soniniu langeliu")
                            {
                                if (modelis.Contains("W"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (price < 35)
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (cpu == "")
                    {
                        MessageBox.Show("Pasirinkite CPU prioriteta");
                    }
                    else
                    {

                        foreach (string procas in cpus)
                        {
                            string[] dalys = procas.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("INTEL") || buildas.ToString().Contains("AMD"))
                            {
                                break;
                            }
                            if (cpu == "Nesvarbu")
                            {
                                if (gamintojas == "INTEL" && modelis == "i5-8600" || gamintojas == "AMD" && modelis == "Ryzen 5 2600x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == cpu && modelis == "i5-8600" || gamintojas == cpu && modelis == "Ryzen 5 2600x")
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                    dedamasBuildas = gamintojas + modelis;
                                }
                                else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (gpu == "")
                    {
                        MessageBox.Show("Pasirinkite GPU prioriteta");
                    }
                    else
                    {
                        foreach (string vaizdo in gpus)
                        {
                            string[] dalys = vaizdo.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            int atmintis = Int32.Parse(dalys[2]);
                            double price = Double.Parse(dalys[3]);
                            if (buildas.ToString().Contains("GTX"))
                            {
                                break;
                            }
                            if (gpu == "Nesvarbu")
                            {
                                if (modelis == "GTX1060" && atmintis == 6)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == gpu && modelis == "GTX1060" && atmintis == 6)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + atmintis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("GTX"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                    foreach (string maitblokis in psu)
                    {
                        string[] dalys = maitblokis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string galingumas = dalys[2];
                        double price = Double.Parse(dalys[3]);
                        if (price <= 75 && galingumas == "650w")
                        {
                            buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(modelis))
                        {
                            break;
                        }

                    }
                    if (mb == "")
                    {
                        MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                    }
                    else
                    {
                        foreach (string motinine in mbs)
                        {
                            string[] dalys = motinine.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (mb == "Nesvarbu")
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (modelis.Contains("H370"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("H370"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (modelis.Contains("A320"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("A320"))
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (dedamasBuildas.Contains("INTEL"))
                                {
                                    if (gamintojas == mb && modelis.Contains("B360"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("B360"))
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    if (gamintojas == mb && modelis.Contains("A320"))
                                    {
                                        buildas.Append(gamintojas + " " + modelis + ", ");
                                        buildokaina = buildokaina + price;
                                    }
                                    else if (buildas.ToString().Contains("A320"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    foreach (string ramd in rams)
                    {
                        string[] dalys = ramd.Split(',');
                        string gamintojas = dalys[0];
                        string tipas = dalys[1];
                        int daznis = Int32.Parse(dalys[2]);
                        int dydis = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                        if (dydis == 16 && daznis == 2400)
                        {
                            buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                            buildokaina = buildokaina + price;
                        }
                        else if (buildas.ToString().Contains(tipas))
                        {
                            break;
                        }
                    }

                    if (memType == "")
                    {
                        MessageBox.Show("Pasirinkite atminties prioriteta");
                    }
                    else
                    {
                        if (memType == "HDD + SSD")
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD") && buildas.ToString().Contains("HDD"))
                                {
                                    break;
                                }
                                if (tipas == "HDD" && !buildas.ToString().Contains("HDD"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }

                            }
                        }
                        else
                        {
                            foreach (string atmintis in ssdhdd)
                            {
                                string[] dalys = atmintis.Split(',');
                                string gamintojas = dalys[0];
                                string modelis = dalys[1];
                                string tipas = dalys[2];
                                int talpa = Int32.Parse(dalys[3]);
                                double price = Double.Parse(dalys[4]);
                                if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                                if (tipas == "SSD" && talpa == 500)
                                {
                                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("SSD"))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    if (caseType == "")
                    {
                        MessageBox.Show("Pasirinkite korpuso prioriteta");
                    }
                    else
                    {
                        foreach (string deze in cases)
                        {
                            string[] dalys = deze.Split(',');
                            string gamintojas = dalys[0];
                            string modelis = dalys[1];
                            double price = Double.Parse(dalys[2]);
                            if (buildas.ToString().Contains("SILENTIUMPC"))
                            {
                                break;
                            }
                            if (caseType == "Su soniniu langeliu")
                            {
                                if (modelis.Contains("W"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (price < 35)
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }

                                else if (buildas.ToString().Contains(gamintojas))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            buildas.Append(buildokaina);
            string build = buildas.ToString();
            string[] parts = build.Split(',');
            foreach (string prt in parts)
            {
                listBox9.Items.Add(prt);
            }

            return buildas;
        }
        private StringBuilder Priorities800()
        {
            StringBuilder buildas = new StringBuilder();
            double buildokaina = 0;
            if (cpu == "")
                {
                    MessageBox.Show("Pasirinkite CPU prioriteta");
                }
                else
                {

                    foreach (string procas in cpus)
                    {
                        string[] dalys = procas.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        double price = Double.Parse(dalys[2]);
                        if(buildas.ToString().Contains("INTEL") && buildas.ToString().Contains("AMD"))
                        {
                            break;
                        }
                        if (cpu == "Nesvarbu")
                        {
                            if (gamintojas == "INTEL" && modelis == "i5-8400" || gamintojas == "AMD" && modelis == "Ryzen 5 2600")
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                                dedamasBuildas = gamintojas + modelis;
                            }
                            else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (gamintojas == cpu && modelis == "i5-8400" || gamintojas == cpu && modelis == "Ryzen 5 2600")
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                                dedamasBuildas = gamintojas + modelis;
                            }
                            else if (buildas.ToString().Contains("AMD") || buildas.ToString().Contains("INTEL"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (gpu == "")
                {
                    MessageBox.Show("Pasirinkite GPU prioriteta");
                }
                else
                {
                    foreach (string vaizdo in gpus)
                    {
                        string[] dalys = vaizdo.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        int atmintis = Int32.Parse(dalys[2]);
                        double price = Double.Parse(dalys[3]);
                        if(buildas.ToString().Contains("GTX"))
                        {
                            break;
                        }
                        if (gpu == "Nesvarbu")
                        {
                            if (modelis == "GTX1060" && atmintis == 6)
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                            }
                            else if (buildas.ToString().Contains("GTX"))
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (gamintojas == gpu && modelis == "GTX1060" && atmintis == 6)
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                            }
                            else if (buildas.ToString().Contains("GTX"))
                            {
                                break;
                            }
                        }
                    }
                }
                foreach (string maitblokis in psu)
                {
                    string[] dalys = maitblokis.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    string galingumas = dalys[2];
                    double price = Double.Parse(dalys[3]);
                    if (price <= 52)
                    {
                        buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                        buildokaina = buildokaina + price;
                    }
                    else if (buildas.ToString().Contains(modelis))
                    {
                        break;
                    }

                }
                if (mb == "")
                {
                    MessageBox.Show("Pasirinkite pagrindines plokstes prioriteta");
                }
                else
                {
                    foreach (string motinine in mbs)
                    {
                        string[] dalys = motinine.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        double price = Double.Parse(dalys[2]);
                        if (mb == "Nesvarbu")
                        {
                            if (dedamasBuildas.Contains("INTEL"))
                            {
                                if (modelis.Contains("B360"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("B360"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (modelis.Contains("B350"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("B350"))
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (dedamasBuildas.Contains("INTEL"))
                            {
                                if (gamintojas == mb && modelis.Contains("B360"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("B360"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (gamintojas == mb && modelis.Contains("B350"))
                                {
                                    buildas.Append(gamintojas + " " + modelis + ", ");
                                    buildokaina = buildokaina + price;
                                }
                                else if (buildas.ToString().Contains("B350"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                foreach (string ramd in rams)
                {
                    string[] dalys = ramd.Split(',');
                    string gamintojas = dalys[0];
                    string tipas = dalys[1];
                    int daznis = Int32.Parse(dalys[2]);
                    int dydis = Int32.Parse(dalys[3]);
                    double price = Double.Parse(dalys[4]);
                    if (dydis == 16 && daznis == 2400)
                    {
                        buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                        buildokaina = buildokaina + price;
                    }
                    else if (buildas.ToString().Contains(tipas))
                    {
                        break;
                    }
                }
                //if (memType == "")
                //{
                    //MessageBox.Show("Pasirinkite atminties prioriteta");
               // }
                //else
                //{
                    foreach (string atmintis in ssdhdd)
                    {
                        string[] dalys = atmintis.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        string tipas = dalys[2];
                        int talpa = Int32.Parse(dalys[3]);
                        double price = Double.Parse(dalys[4]);
                       // if (buildas.ToString().Contains("SSD") || buildas.ToString().Contains("HDD"))
                       // {
                         //   break;
                       // }
                       /* if (memType == "SSD")
                        {
                            if (tipas == "HDD")
                            {
                                buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                buildokaina = buildokaina + price;
                            }
                            else if (buildas.ToString().Contains("HDD"))
                            {
                                break;
                            }
                        }
                       /* else
                        {
                            if (tipas == "HDD")
                            {
                                buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                buildokaina = buildokaina + price;
                            }
                            else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                            {
                                buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                                buildokaina = buildokaina + price;
                            }
                        }
                    //}
               // }
                if (caseType == "")
                {
                    MessageBox.Show("Pasirinkite korpuso prioriteta");
                }
                else
                {
                    foreach (string deze in cases)
                    {
                        string[] dalys = deze.Split(',');
                        string gamintojas = dalys[0];
                        string modelis = dalys[1];
                        double price = Double.Parse(dalys[2]);
                        if (buildas.ToString().Contains("SILENTIUMPC"))
                        {
                            break;
                        }
                        if (caseType == "Su soniniu langeliu")
                        {
                            if (modelis.Contains("W"))
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                            }

                            else if (buildas.ToString().Contains(gamintojas))
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (price < 35)
                            {
                                buildas.Append(gamintojas + " " + modelis + ", ");
                                buildokaina = buildokaina + price;
                            }

                            else if (buildas.ToString().Contains(gamintojas))
                            {
                                break;
                            }
                        }
                    }
                }
            buildas.Append(buildokaina);

            foreach(string perf in performance)
            {
                string[] dalys = perf.Split(',');
                string zaidimas = dalys[0];
                string bildas = dalys[1];
                int fpsLow = Int32.Parse(dalys[2]);
                int fpsHigh = Int32.Parse(dalys[3]);
                List<double> vidurkiai = new List<double>();
                if(dedamasBuildas.Contains("AMD"))
                {
                    if(bildas == "800AMD")
                    {

                    }
                }
                if(dedamasBuildas.Contains("INTEL"))
                {
                    if(bildas == "800INTEL")
                    {

                    }
                }
            }
            string build = buildas.ToString();
            string[] parts = build.Split(',');
            foreach (string prt in parts)
            {
                //listBox9.Items.Add(prt);
            }
            
            return buildas;
        }

        public void readGame()
        {
            List<string> games = new List<string>();
            List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader("games.txt"))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        games.Add(line);
                    }
                }
                gams = games;

        }
        private void readCpu()
        {
            List<string> proc = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("cpu.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    proc.Add(line);
                }
            }
            cpus = proc;
        }
        private void readRam()
        {
            List<string> ramukai = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("ram.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    ramukai.Add(line);
                }
            }
            rams = ramukai;
        }
        private void readGpu()
        {
            List<string> gp = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("gpu.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    gp.Add(line);
                }
            }
            gpus = gp;
        }
        private void readMb()
        {
            List<string> mbb = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("mb.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    mbb.Add(line);
                }
            }
            mbs = mbb;
        }
        private void readCases()
        {
            List<string> casee = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("case.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    casee.Add(line);
                }
            }
            cases = casee;
        }
        private void readPsu()
        {
            List<string> mait = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("psu.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    mait.Add(line);
                }
            }
            psu = mait;
        }
        private void readCooler()
        {
            List<string> cooleris = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("coolers.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    cooleris.Add(line);
                }
            }
            cooler = cooleris;
        }
        private void readPerformance()
        {
            List<string> perf = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("performance.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    perf.Add(line);
                }
            }
            performance = perf;
        }
        private void readSsdHdd()
        {
            List<string> ssdHddd = new List<string>();
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("ssd+hdd.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    ssdHddd.Add(line);
                }
            }
            ssdhdd = ssdHddd;
        }
        /*
        public void ClearCheckedListOfGames()
        {
            List<string> toBeRemoved = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                    toBeRemoved.Add(checkedListBox1.Items[i].ToString());
            }

            for (int i = 0; i < toBeRemoved.Count; i++)
            {
                checkedListBox1.Items.Remove(toBeRemoved[i]);
            }
        }

        public void CreateCheckedListBoxOfGames()
        {
            ClearCheckedListOfGames();
            foreach (string game in gams)
            {
                checkedListBox1.Items.Add(game);
            }
        }
        public void CreateCoolerList()
        {
            foreach (string cool in cooler)
            {
                listBox10.Items.Add(cool);
            }
        }
        public void CreateCpuList()
        {
            foreach (string cpu in cpus)
            {
                listBox1.Items.Add(cpu);
            }
        }
        public void CreateRamList()
        {
            foreach (string ramas in rams)
            {
                listBox8.Items.Add(ramas);
            }
        }
        public void CreateGpuList()
        {
            foreach (string gpu in gpus)
            {
                listBox2.Items.Add(gpu);
            }
        }
        public void CreateMbList()
        {
            foreach (string motherb in mbs)
            {
                listBox3.Items.Add(motherb);
            }
        }
        public void CreatePerformanceList()
        {
            foreach (string perf in performance)
            {
                listBox4.Items.Add(perf);
            }
        }
        public void CreatePsuList()
        {
            foreach (string psuu in psu)
            {
                listBox5.Items.Add(psuu);
            }
        }
        public void CreateSsdHddList()
        {
            foreach (string ssdhd in ssdhdd)
            {
                listBox6.Items.Add(ssdhd);
            }
        }
        public void CreateCaseList()
        {
            foreach (string cass in cases)
            {
                listBox7.Items.Add(cass);
            }
        }
        public void CreateComponentLists()
        {
            CreateCheckedListBoxOfGames();
            CreateCpuList();
            CreateRamList();
            CreateGpuList();
            CreateMbList();
            CreateCoolerList();
            CreatePsuList();
            CreatePerformanceList();
            CreateSsdHddList();
            CreateCaseList();
        }
        public void ReadInfoFromFiles()
        {
            readGame();
            readCases();
            readCpu();
            readCooler();
            readRam();
            readGpu();
            readMb();
            readPerformance();
            readSsdHdd();
            readPsu();
        }
        /*public void HideStartParts()
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox8.Enabled = false;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button3.Visible = false;
            button3.Enabled = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox8.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            button4.Visible = false;
            button4.Enabled = false;
            checkedListBox1.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            button1.Enabled = false;
        }
        public void LoadPriorities()
        {
            LoadPrices();
            LoadGPUMan();
            LoadCPUMan();
            LoadMBMan();
            LoadMemoryTypes();
            LoadOC();
            LoadCaseTypes();
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
           // HideStartParts();
           // LoadPriorities();
            //ReadInfoFromFiles();
            //CreateCheckedListBoxOfGames();
           // CreateComponentLists();
        }/*

        private void LoadPrices()
        {
            comboBox1.Items.Add("~ 800 e");
            comboBox1.Items.Add("~ 1100 e");
            comboBox1.Items.Add("~ 1600 e");
            comboBox1.Items.Add("~ 2000 e");
        }

        private void LoadCPUMan()
        {
            comboBox2.Items.Add("INTEL");
            comboBox2.Items.Add("AMD");
            comboBox2.Items.Add("Nesvarbu");
        }
        private void LoadGPUMan()
        {
            comboBox3.Items.Add("ASUS");
            comboBox3.Items.Add("EVGA");
            comboBox3.Items.Add("GIGABYTE");
            comboBox3.Items.Add("MSI");
            comboBox3.Items.Add("Nesvarbu");
        }

        private void LoadMBMan()
        {
            comboBox4.Items.Add("ASUS");
            comboBox4.Items.Add("ASROCK");
            comboBox4.Items.Add("GIGABYTE");
            comboBox4.Items.Add("MSI");
            comboBox4.Items.Add("Nesvarbu");
        }

        private void LoadMemoryTypes()
        {
            comboBox5.Items.Add("HDD + SSD");
            comboBox5.Items.Add("SSD");
        }

        private void LoadOC()
        {
            comboBox6.Items.Add("TAIP");
            comboBox6.Items.Add("NE");
        }

        private void LoadCaseTypes()
        {
            comboBox8.Items.Add("Su soniniu langeliu");
            comboBox8.Items.Add("Be soninio langelio");
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //zaidimai.Add(checkedListBox1.SelectedItem.ToString());
            //button1.Enabled = true;

        }
        private void ShowPriorAndButt()
        {
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox8.Enabled = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox8.Visible = true;
            //button1.Enabled = true;
            button1.Visible = true;
            button2.Enabled = true;
            button2.Visible = true;
            button3.Visible = true;
            button3.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Pasirinkote kaina " + comboBox1.SelectedItem.ToString());
            kaina = comboBox1.SelectedItem.ToString();
            //listBox2.Enabled = true;
            //ShowPriorAndButt();
            button2.Visible = true; button3.Visible = true;
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu = comboBox2.SelectedItem.ToString();
            if(cpu == "AMD" && kaina == "~ 2000 e" || kaina == "~ 800 e")
            {
                comboBox6.Enabled = false;
            }
            else { comboBox6.Enabled = true; }
            //else { comboBox6.Enabled = true; }
            //MessageBox.Show(kaina + comboBox2.SelectedItem.ToString());
        }

        private StringBuilder OneClick800()
        {
            double intel800suma = 0;
            double amd800suma = 0;
            double intel800BuildKaina = 0;

            StringBuilder buildas = new StringBuilder();
            foreach (string prf in performance)
            {
                string[] dalys = prf.Split(',');
                string zaidimas = dalys[0];
                string build = dalys[1];
                double fpsLow = Double.Parse(dalys[2]);
                double fpsHigh = Double.Parse(dalys[3]);
                if (build == "800Intel")
                {
                    intel800suma = intel800suma + fpsLow + fpsHigh;

                }
                if (build == "800AMD")
                {
                    amd800suma = amd800suma + fpsLow + fpsHigh;
                }
            }
            if (intel800suma > amd800suma)
            {
                
                // renku intel 800 builda is daliu
                foreach (string procas in cpus)
                {
                    string[] dalys = procas.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    double price = Double.Parse(dalys[2]);
                    if (gamintojas == "INTEL" && modelis == "i5-8400")
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("INTEL"))
                    {
                        break;
                    }
                }
                foreach (string vaizdo in gpus)
                {
                    string[] dalys = vaizdo.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    int atmintis = Int32.Parse(dalys[2]);
                    double price = Double.Parse(dalys[3]);
                    if (modelis == "GTX1060" && atmintis == 6)
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("GTX"))
                    {
                        break;
                    }
                }
                foreach (string maitblokis in psu)
                {
                    string[] dalys = maitblokis.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    string galingumas = dalys[2];
                    double price = Double.Parse(dalys[3]);
                    if (price <= 40)
                    {
                        buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains(modelis))
                    {
                        break;
                    }

                }
                
                foreach (string motinine in mbs)
                {
                    string[] dalys = motinine.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    double price = Double.Parse(dalys[2]);
                    if (modelis.Contains("B360"))
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("B360"))
                    {
                        break;
                    }
                }
                foreach (string ramd in rams)
                {
                    string[] dalys = ramd.Split(',');
                    string gamintojas = dalys[0];
                    string tipas = dalys[1];
                    int daznis = Int32.Parse(dalys[2]);
                    int dydis = Int32.Parse(dalys[3]);
                    double price = Double.Parse(dalys[4]);
                    if (dydis == 8)
                    {
                        buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains(tipas))
                    {
                        break;
                    }
                }
                foreach (string atmintis in ssdhdd)
                {
                    string[] dalys = atmintis.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    string tipas = dalys[2];
                    int talpa = Int32.Parse(dalys[3]);
                    double price = Double.Parse(dalys[4]);
                    if (tipas == "HDD")
                    {
                        buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("HDD"))
                    {
                        break;
                    }
                }
                foreach (string deze in cases)
                {
                    string[] dalys = deze.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    double price = Double.Parse(dalys[2]);
                    if (price == 35)
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains(gamintojas))
                    {
                        break;
                    }
                }


                string build = buildas.ToString();
                string[] parts = build.Split(',');
                foreach (string prt in parts)
                {
                    listBox9.Items.Add(prt);
                }
            }
            buildas.Length = 0;
            double amd800BuildKaina = 0;
            if (amd800suma > intel800suma)
            {
                // renku intel 800 builda is daliu
                foreach (string procas in cpus)
                {
                    string[] dalys = procas.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    double price = Double.Parse(dalys[2]);
                    if (gamintojas == "AMD" && modelis == "Ryzen 5 2600")
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                       amd800BuildKaina = amd800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("AMD"))
                    {
                        break;
                    }
                }
                foreach (string vaizdo in gpus)
                {
                    string[] dalys = vaizdo.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    int atmintis = Int32.Parse(dalys[2]);
                    double price = Double.Parse(dalys[3]);
                    if (modelis == "GTX1060" && atmintis == 6)
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        amd800BuildKaina = amd800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("GTX"))
                    {
                        break;
                    }
                }
                foreach (string maitblokis in psu)
                {
                    string[] dalys = maitblokis.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    string galingumas = dalys[2];
                    double price = Double.Parse(dalys[3]);
                    if (galingumas == "600w")
                    {
                        buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                        amd800BuildKaina = amd800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains(modelis))
                    {
                        break;
                    }

                }
                
                foreach (string motinine in mbs)
                {
                    string[] dalys = motinine.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    double price = Double.Parse(dalys[2]);
                    if (modelis.Contains("B350"))
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        amd800BuildKaina = amd800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("B350"))
                    {
                        break;
                    }
                }
                foreach (string ramd in rams)
                {
                    string[] dalys = ramd.Split(',');
                    string gamintojas = dalys[0];
                    string tipas = dalys[1];
                    int daznis = Int32.Parse(dalys[2]);
                    int dydis = Int32.Parse(dalys[3]);
                    double price = Double.Parse(dalys[4]);
                    if (dydis == 8)
                    {
                        buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                        amd800BuildKaina = amd800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains(tipas))
                    {
                        break;
                    }
                }
                foreach (string atmintis in ssdhdd)
                {
                    string[] dalys = atmintis.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    string tipas = dalys[2];
                    int talpa = Int32.Parse(dalys[3]);
                    double price = Double.Parse(dalys[4]);
                    if (tipas == "HDD")
                    {
                        buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                        intel800BuildKaina = intel800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains("HDD"))
                    {
                        break;
                    }
                }
                foreach (string deze in cases)
                {
                    string[] dalys = deze.Split(',');
                    string gamintojas = dalys[0];
                    string modelis = dalys[1];
                    double price = Double.Parse(dalys[2]);
                    if (price == 35)
                    {
                        buildas.Append(gamintojas + " " + modelis + ", ");
                        amd800BuildKaina = amd800BuildKaina + price;
                    }
                    else if (buildas.ToString().Contains(gamintojas))
                    {
                        break;
                    }
                }
                string build = buildas.ToString();
                string[] parts = build.Split(',');
                foreach (string prt in parts)
                {
                    listBox9.Items.Add(prt);
                }
            }
            return buildas;
        }
        private StringBuilder OneClick1100IntelOC()
        {
            double intelOC1100BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "INTEL" && modelis == "i5-8600k")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("INTEL"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1060" && atmintis == 3)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 75)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("Z370") && price <= 150)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Z370"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 3000)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }

            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
            }           
            foreach (string cool in cooler)
            {
                string[] dalys = cool.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "Hyper 212 EVO")
                {
                    buildas.Append(gamintojas + " " + modelis +  ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Hyper 212 EVO"))
                {
                    break;
                }
            }            
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intelOC1100BuildKaina = intelOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick1100Intel()
        {
            double intel1100BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "INTEL" && modelis == "i5-8600")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("INTEL"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1060" && atmintis == 6)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 75)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }
            
            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("H370"))
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("H370"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 2400)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }
            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
            }
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    intel1100BuildKaina = intel1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }

        private StringBuilder OneClick1100AMD()
        {
            double AMD1100BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "AMD" && modelis == "Ryzen 5 2600x")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("AMD"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1060" && atmintis == 6)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 84 && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }
            
            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("A320"))
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("A320"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 2400)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }
            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
            }
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1100BuildKaina = AMD1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick1100AMDOC()
        {
            double AMDOC1100BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "AMD" && modelis == "Ryzen 5 2600x")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("AMD"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1060" && atmintis == 6)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 84 && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("B350"))
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("B350"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 3000)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }

            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
            }          
            foreach (string cool in cooler)
            {
                string[] dalys = cool.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "Hyper 212 EVO")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Hyper 212 EVO"))
                {
                    break;
                }
            }          
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1100BuildKaina = AMDOC1100BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }


        private StringBuilder OneClick1100()
        {
            double intel1100suma = 0;
            double inteloc1100suma = 0;
            double amd1100suma = 0;
            double amdoc1100suma = 0;

            StringBuilder buildas = new StringBuilder();
            foreach (string prf in performance)
            {
                string[] dalys = prf.Split(',');
                string zaidimas = dalys[0];
                string build = dalys[1];
                double fpsLow = Double.Parse(dalys[2]);
                double fpsHigh = Double.Parse(dalys[3]);
                if (build == "1100Intel")
                {
                    intel1100suma = intel1100suma + fpsLow + fpsHigh;
                }
                if (build == "1100AMD")
                {
                    amd1100suma = amd1100suma + fpsLow + fpsHigh;
                }
                if (build == "1100IntelOC")
                {
                    inteloc1100suma = inteloc1100suma + fpsLow + fpsHigh;
                }
                if (build == "1100AMDOC")
                {
                    amdoc1100suma = amdoc1100suma + fpsLow + fpsHigh;
                }
            }
            if (intel1100suma > inteloc1100suma && intel1100suma > amd1100suma && intel1100suma > amdoc1100suma)
            {
                buildas = OneClick1100Intel();
            }
            if (inteloc1100suma > intel1100suma && inteloc1100suma > amd1100suma && inteloc1100suma > amdoc1100suma)
            {
                buildas = OneClick1100IntelOC();
            }
            if (amd1100suma > intel1100suma && amd1100suma > amdoc1100suma && amd1100suma > inteloc1100suma)
            {
                buildas = OneClick1100AMD();
            }
            if (amdoc1100suma > inteloc1100suma && amdoc1100suma > amd1100suma && amdoc1100suma > intel1100suma)
            {
                buildas = OneClick1100AMDOC();
            }
            string bild = buildas.ToString();
            string[] parts = bild.Split(',');
            foreach (string prt in parts)
            {
            listBox9.Items.Add(prt);
            }
            return buildas;
        }
        private StringBuilder OneClick1600Intel()
        {
            double Intel1600BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "INTEL" && modelis == "i7-8700")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("INTEL"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080Ti")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (galingumas == "650w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }
            
            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("H370"))
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("H370"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 2400)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }

            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
            }
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel1600BuildKaina = Intel1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick1600IntelOC()
        {
            double IntelOC1600BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "INTEL" && modelis == "i7-8700k")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("INTEL"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 84 && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("Z370") && price <= 150)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Z370"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 3000)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }


            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
            }          
            foreach (string cool in cooler)
            {
                string[] dalys = cool.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "Hyper 212 EVO")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Hyper 212 EVO"))
                {
                    break;
                }
            }           
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC1600BuildKaina = IntelOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }

        private StringBuilder OneClick1600AMDOC()
        {
            double AMDOC1600BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("AMD"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080Ti")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 84 && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }
            
            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("B350") && price <= 150)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("B350"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 3000)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }


            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
            }            
            foreach (string cool in cooler)
            {
                string[] dalys = cool.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "Hyper 212 EVO")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Hyper 212 EVO"))
                {
                    break;
                }
            }
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC1600BuildKaina = AMDOC1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick1600AMD()
        {
            double AMD1600BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("AMD"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080Ti")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (price == 84 && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("B350"))
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("B350"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 2400)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }

            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "HDD")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains("HDD") && tipas == "SSD" && talpa == 240)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
            }            
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (price == 35)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMD1600BuildKaina = AMD1600BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick1600()
        {
            double intel1600suma = 0;
            double inteloc1600suma = 0;
            double amd1600suma = 0;
            double amdoc1600suma = 0;

            StringBuilder buildas = new StringBuilder();
            foreach (string prf in performance)
            {
                string[] dalys = prf.Split(',');
                string zaidimas = dalys[0];
                string build = dalys[1];
                double fpsLow = Double.Parse(dalys[2]);
                double fpsHigh = Double.Parse(dalys[3]);
                if (build == "1600Intel")
                {
                    intel1600suma = intel1600suma + fpsLow + fpsHigh;

                }
                if (build == "1600AMD")
                {
                    amd1600suma = amd1600suma + fpsLow + fpsHigh;
                }
                if (build == "1600IntelOC")
                {
                    inteloc1600suma = inteloc1600suma + fpsLow + fpsHigh;
                }
                if (build == "1600AMDOC")
                {
                    amdoc1600suma = amdoc1600suma + fpsLow + fpsHigh;
                }
            }
            if (intel1600suma > inteloc1600suma && intel1600suma > amd1600suma && intel1600suma > amdoc1600suma)
            {
                buildas = OneClick1600Intel();
            }
            if (inteloc1600suma > intel1600suma && inteloc1600suma > amd1600suma && inteloc1600suma > amdoc1600suma)
            {
                buildas = OneClick1600IntelOC();
            }
            if (amd1600suma > intel1600suma && amd1600suma > amdoc1600suma && amd1600suma > inteloc1600suma)
            {
                buildas = OneClick1600AMD();
            }
            if (amdoc1600suma > inteloc1600suma && amdoc1600suma > amd1600suma && amdoc1600suma > intel1600suma)
            {
                buildas = OneClick1600AMDOC();
            }
            string bild = buildas.ToString();
            string[] parts = bild.Split(',');
            foreach (string prt in parts)
            {
                listBox9.Items.Add(prt);
            }
            return buildas;
        }
        private StringBuilder OneClick2000Intel()
        {
            double Intel2000BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "INTEL" && modelis == "i7-8700")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("INTEL"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080Ti")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (galingumas == "650w" && modelis == "SuperNovaG3")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains(modelis))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("H370"))
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("H370"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 2400)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }

            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "SSD" && talpa == 1000)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("SSD"))
                {
                    break;
                }
            }            
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "450D")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    Intel2000BuildKaina = Intel2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("450D"))
                {
                    break;
                }
            }
            return buildas;
        }

        private StringBuilder OneClick2000IntelOC()
        {
            double IntelOC2000BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "INTEL" && modelis == "i7-8700k")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("INTEL"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080Ti")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (modelis == "SuperNovaG3" && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("SuperNovaG3"))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("Z370") && price >= 150)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("Z370"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 3000)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }
            foreach (string cool in cooler)
            {
                string[] dalys = cool.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "NH-D15")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("NH-D15"))
                {
                    break;
                }
            }            
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "450D")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    IntelOC2000BuildKaina = IntelOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick2000AMDOC()
        {
            double AMDOC2000BuildKaina = 0;
            StringBuilder buildas = new StringBuilder();
            foreach (string procas in cpus)
            {
                string[] dalys = procas.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (gamintojas == "AMD" && modelis == "Ryzen 7 2700x")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("AMD"))
                {
                    break;
                }
            }
            foreach (string vaizdo in gpus)
            {
                string[] dalys = vaizdo.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                int atmintis = Int32.Parse(dalys[2]);
                double price = Double.Parse(dalys[3]);
                if (modelis == "GTX1080Ti")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("GTX"))
                {
                    break;
                }
            }
            foreach (string maitblokis in psu)
            {
                string[] dalys = maitblokis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string galingumas = dalys[2];
                double price = Double.Parse(dalys[3]);
                if (modelis == "SuperNovaG3" && galingumas == "750w")
                {
                    buildas.Append(gamintojas + " " + modelis + " " + galingumas + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("SuperNovaG3"))
                {
                    break;
                }

            }

            foreach (string motinine in mbs)
            {
                string[] dalys = motinine.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis.Contains("B350") && price <= 150)
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("B350"))
                {
                    break;
                }
            }
            foreach (string ramd in rams)
            {
                string[] dalys = ramd.Split(',');
                string gamintojas = dalys[0];
                string tipas = dalys[1];
                int daznis = Int32.Parse(dalys[2]);
                int dydis = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (dydis == 16 && daznis == 3000)
                {
                    buildas.Append(gamintojas + " " + tipas + " " + daznis + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains(tipas))
                {
                    break;
                }
            }


            foreach (string atmintis in ssdhdd)
            {
                string[] dalys = atmintis.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                string tipas = dalys[2];
                int talpa = Int32.Parse(dalys[3]);
                double price = Double.Parse(dalys[4]);
                if (tipas == "SSD" && talpa == 1000)
                {
                    buildas.Append(gamintojas + " " + modelis + " " + tipas + " " + talpa + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("SSD"))
                {
                    break;
                }
            }            
            foreach (string cool in cooler)
            {
                string[] dalys = cool.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "NH-D15")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains("NH-D15"))
                {
                    break;
                }
            }           
            foreach (string deze in cases)
            {
                string[] dalys = deze.Split(',');
                string gamintojas = dalys[0];
                string modelis = dalys[1];
                double price = Double.Parse(dalys[2]);
                if (modelis == "450D")
                {
                    buildas.Append(gamintojas + " " + modelis + ", ");
                    AMDOC2000BuildKaina = AMDOC2000BuildKaina + price;
                }
                else if (buildas.ToString().Contains(gamintojas))
                {
                    break;
                }
            }
            return buildas;
        }
        private StringBuilder OneClick2000()
        {
            double intel2000suma = 0;
            double inteloc2000suma = 0;
            double amdoc2000suma = 0;

            StringBuilder buildas = new StringBuilder();
            foreach (string prf in performance)
            {
                string[] dalys = prf.Split(',');
                string zaidimas = dalys[0];
                string build = dalys[1];
                double fpsLow = Double.Parse(dalys[2]);
                double fpsHigh = Double.Parse(dalys[3]);
                if (build == "2000Intel")
                {
                    intel2000suma = intel2000suma + fpsLow + fpsHigh;

                }
                if (build == "2000IntelOC")
                {
                    inteloc2000suma = inteloc2000suma + fpsLow + fpsHigh;
                }
                if (build == "2000AMDOC")
                {
                    amdoc2000suma = amdoc2000suma + fpsLow + fpsHigh;
                }
            }
            if (intel2000suma > inteloc2000suma && intel2000suma > amdoc2000suma)
            {
                buildas = OneClick2000Intel();
            }
            if (inteloc2000suma > intel2000suma &&  inteloc2000suma > amdoc2000suma)
            {
                buildas = OneClick2000IntelOC();
            }
            if (amdoc2000suma > inteloc2000suma && amdoc2000suma > intel2000suma)
            {
                buildas = OneClick2000AMDOC();
            }
            string bild = buildas.ToString();
            string[] parts = bild.Split(',');
            foreach (string prt in parts)
            {
                listBox9.Items.Add(prt);
            }
            return buildas;
        }

        // One click kompiuterio parinkimas
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder buildas = new StringBuilder();
            if (kaina == "~ 800 e")
            {
               buildas = OneClick800();
            }
            if (kaina == "~ 1100 e")
            {
                buildas = OneClick1100();
            }
            if(kaina == "~ 1600 e")
            {
                buildas = OneClick1600();
            }
            if(kaina == "~ 2000 e")
            {
                buildas = OneClick2000();
            }
        }
  


        private void button2_Click(object sender, EventArgs e)
        {
            ShowPriorAndButt();
            if(kaina == "~ 800 e")
            {
                comboBox5.Enabled=false;
                comboBox6.Enabled = false;
                label11.Text = "Dėl pasirinktos kainos, tam tikri laukai gali būti išjungti";
            }
            button3.Visible = false;
            button2.Enabled = false;
            button4.Visible = true;
            button4.Enabled = true;
            label11.Visible = true;
            label8.Visible = true;
            checkedListBox1.Visible = true;
            checkedListBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //label8.Visible = true;
            List<string> kazkas = new List<string>();
            foreach(string gam in checkedListBox1.Items)
            {
                kazkas.Add(gam);
            }
            zaidimai = kazkas;
            foreach(string zaidims in zaidimai)
            {
                listBox11.Items.Add(zaidims);
            }
             button1.Enabled = true;
             button4.Enabled = false;
            //checkedListBox1.Visible = true;
            //checkedListBox1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpu = comboBox3.SelectedItem.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            mb = comboBox4.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            memType = comboBox5.SelectedItem.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            oc = comboBox6.SelectedItem.ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            caseType = comboBox8.SelectedItem.ToString();
        }*/

        private void kompiuterioRinkimasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pradžiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pagalPrioritetusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prioritetai forma = new Prioritetai();
            forma.ShowDialog();
        }

        private void kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            One_click forma = new One_click();
            forma.ShowDialog();
        }



    }
}
