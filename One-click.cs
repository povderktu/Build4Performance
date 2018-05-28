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
    public partial class One_click : Form
    {
        public One_click()
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



        private void button2_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            //Application.DoEvents();
        }

        private void grįžtiĮPradinįProgramosLangąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    listBox1.Items.Add(prt);
                }
            }

            if (amd800suma > intel800suma)
            {            
                buildas.Length = 0;
                double amd800BuildKaina = 0;
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
                    listBox1.Items.Add(prt);
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
                    buildas.Append(gamintojas + " " + modelis + ", ");
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
                listBox1.Items.Add(prt);
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
                listBox1.Items.Add(prt);
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
            if (inteloc2000suma > intel2000suma && inteloc2000suma > amdoc2000suma)
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
                listBox1.Items.Add(prt);
            }
            return buildas;
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
        private void LoadPrices()
        {
            comboBox1.Items.Add("~ 800 e");
            comboBox1.Items.Add("~ 1100 e");
            comboBox1.Items.Add("~ 1600 e");
            comboBox1.Items.Add("~ 2000 e");
        }
        private void One_click_Load(object sender, EventArgs e)
        {
            ReadInfoFromFiles();
            LoadPrices();
            button3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kaina = comboBox1.SelectedItem.ToString();
            button3.Enabled = true;
        }

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
            if (kaina == "~ 1600 e")
            {
                buildas = OneClick1600();
            }
            if (kaina == "~ 2000 e")
            {
                buildas = OneClick2000();
            }
            button3.Enabled = false;
            foreach(string bld in buildas)
            {
            }
            //listBox1.Items.Add(buildas.ToString());
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
