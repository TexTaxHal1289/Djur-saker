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


namespace Djur_saker
{
    public partial class Form2 : Form
    {
        public string djurInfo;
        string historyFile = Path.Combine(Application.StartupPath, "history.txt");
        
   

        public Form2(string valtDjur)
        {
            InitializeComponent();
            djurInfo = valtDjur;
        }

        private void RegisterAdoption_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Personnamn.Text) ||
                                string.IsNullOrWhiteSpace(efternamn.Text) ||

        string.IsNullOrWhiteSpace(Nummerperson.Text))
            {
                MessageBox.Show("Fyll i alla fält!");
                return;
            } 

            string person = $"{Personnamn.Text} {efternamn.Text} (PN: {Nummerperson.Text})";
            string adoptionRad = $"Adopterad av: {person}{Environment.NewLine}" +
    $"{djurInfo}";

            File.AppendAllText(historyFile, adoptionRad + Environment.NewLine);



            MessageBox.Show("Adoption registrerad!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
    }


   