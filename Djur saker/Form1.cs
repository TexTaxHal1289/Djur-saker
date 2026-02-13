using Microsoft.VisualBasic;
using Djurhundar_saker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Djur_saker
{
    public partial class Form1 : Form


    {
        private List<Djur> allaDjur = new List<Djur>();
        private string savefile = "saveditems.txt";
        public List<string> allAnimals = new List<string>();
        public List<string> AllAnimals => File.ReadAllLines(savefile).ToList();
        public string person;
        public List<Adoption> adoptioner = new List<Adoption>();
        public string adoptionFile = "adoptioner.txt";
        public string valdDjurTyp = "";



        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_Closing;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {       //sparar listboxform1 informationen när man stänger
            using (StreamWriter sw = new StreamWriter(savefile, false))
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }

            }
        }







        private void Form1_Load(object sender, EventArgs e)
        {

            // laddar up de sparade filerna
            if (File.Exists(savefile))
            {
                listBox1.Items.Clear();
                foreach (string line in File.ReadAllLines(savefile))
                {
                    listBox1.Items.Add(line);
                }
            }
        }






        private void ELGATO_Click(object sender, EventArgs e)
        {
            CATTER katter = new CATTER();
            valdDjurTyp = "Katt";


            rovfågel.Visible = false;
            kastrerad.Visible = true;
            vaccinerad.Visible = true;



            groupBox1.Visible = true;


        }

        private void DOGGO_Click(object sender, EventArgs e)
        {
            valdDjurTyp = "Hund";

            Hundar2 hund = new Hundar2();



            SortByAnimalType();

            groupBox1.Visible = true;

            rovfågel.Visible = false;
            kastrerad.Visible = true;
            vaccinerad.Visible = true;

        }

        private void FOGEL_Click(object sender, EventArgs e)
        {
            Fogel fågel = new Fogel();
            valdDjurTyp = "Fågel";

            groupBox1.Visible = true;

            kastrerad.Visible = false;
            rovfågel.Visible = true;
            vaccinerad.Visible = true;


        }
        //ta bort ett djur från listbox1 
        private void Btntabort_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                File.WriteAllLines(savefile, listBox1.Items.Cast<string>());
            }


            else
            {
                MessageBox.Show("Välj ett djur att ta bort.");
            }

            File.WriteAllLines(savefile, listBox1.Items.Cast<string>());

        }

        public class Adoption
        {
            public string DjurInfo { get; set; }
            public string Person { get; set; }
            //returnerar information om djuret och personen som adopterade det
            public override string ToString()
            {
                return $"{DjurInfo} | Adopterad av: {Person}";
            }
        }

        private void SortByAnimalType()
        {
            // Definierar  ordningen av djur Hund (1), Katt (2), Fågel (3)
            int GetTypeOrder(string item)
            {
                if (item.StartsWith("Hund", StringComparison.OrdinalIgnoreCase)) return 1;
                if (item.StartsWith("Katt", StringComparison.OrdinalIgnoreCase)) return 2;
                if (item.StartsWith("Fågel", StringComparison.OrdinalIgnoreCase)) return 3;
                return 99; // okända
            }

            var sorted = listBox1.Items.Cast<string>()
                .OrderBy(x => GetTypeOrder(x))
                .ThenBy(x => x)
                .ToList();


            foreach (var s in sorted)
            {
            }

        }
        //knappen föratt komma till form2 / skriva in sin personliga information
        private void adoptera_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Välj ett djur att adoptera!");
                return;
            }

            string valtDjur = listBox1.SelectedItem.ToString();

            Form2 form2 = new Form2(valtDjur);
            this.Hide();



            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
        // knapp för att lägga till nya djuret med all information om sig
        private void LÄGGTILL_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(valdDjurTyp))
                {
                    MessageBox.Show("Välj Katt, Hund eller Fågel först.");
                    return;
                }

                if (!int.TryParse(ålderbox1.Text, out int ålder))
                {
                    MessageBox.Show("Ålder måste vara ett nummer!");
                    return;
                }

                if (!int.TryParse(Prisbox1.Text, out int pris))
                {
                    MessageBox.Show("Pris måste vara ett nummer!");
                    return;
                }

                Djur nyttDjur = null;

                if (valdDjurTyp == "Hund")
                    nyttDjur = new Hundar2();
                else if (valdDjurTyp == "Katt")
                    nyttDjur = new CATTER();
                else if (valdDjurTyp == "Fågel")
                    nyttDjur = new Fogel();

                if (nyttDjur == null)
                {
                    MessageBox.Show("Fel: Djuret skapades inte.");
                    return;
                }
                // informationen som matas in i textboxarna och checkboxarna
                nyttDjur.namn = Namnbox1.Text;
                nyttDjur.färg = Färgbox1.Text;
                nyttDjur.ålder = ålder;
                nyttDjur.pris = pris;
                nyttDjur.favoritmat = favmatbox1.Text;
                nyttDjur.kastrerad = kastrerad.Checked;
                nyttDjur.vaccinerad = vaccinerad.Checked;
                nyttDjur.djurtyp = valdDjurTyp;

                listBox1.Items.Add(nyttDjur.Geinfo());
                groupBox1.Visible = false;
            }
        }

        // historik knappen
        private void History_Click(object sender, EventArgs e)
        {
            historydesign historydesign = new historydesign();
            this.Hide();
            if (historydesign.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        

        private void Redigerapris_Click(object sender, EventArgs e)
        
        {
            // Kontroll: djur valt
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Välj ett djur först!");
                return;
            }

            string gammalText = listBox1.SelectedItem.ToString();

            // Hämtar nuvarande pris
            Match match = Regex.Match(gammalText, @"Pris:\s*(\d+)");
            string nuvarandePris = match.Success ? match.Groups[1].Value : "";

            // popup-box för att kunna skriva in nytt pris
            string input = Interaction.InputBox(
                "Skriv nytt pris:",
                "Redigera pris",
                nuvarandePris
            );

            // Avbryt
            if (string.IsNullOrWhiteSpace(input))
                return;

            // Kontroll: nummer
            if (!int.TryParse(input, out int nyttPris))
            {
                MessageBox.Show("Pris måste vara ett nummer!");
                return;
            }

           //gör så att nya priset ersätter det gamla
            string nyText = Regex.Replace(
                gammalText,
                @"Pris:\s*\d+",
                $"Pris: {nyttPris}"
            );

           
            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = nyText;

            // sPARA ÄNDRINGARNA SOM GJORTS
            File.WriteAllLines(savefile, listBox1.Items.Cast<string>());

            MessageBox.Show("Priset har uppdaterats!");
        }

    }
    }














