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
    public partial class historydesign : Form
    {

        string historyfile = Path.Combine(Application.StartupPath, "history.txt");

        public historydesign()
        {
            InitializeComponent();
            this.Load += Historydesign_Load;
        }

        private void Historydesign_Load(object sender, EventArgs e)
        {
            History.Items.Clear();

            if (File.Exists(historyfile))
            {
                History.Items.AddRange(File.ReadAllLines(historyfile));

            }



            }
            private void Delete_Click(object sender, EventArgs e)

            {
            
            if (History.SelectedItem != null)
            {
                History.Items.Remove(History.SelectedItem);
                File.WriteAllLines(historyfile, History.Items.Cast<string>());
            }
            else
            {
                MessageBox.Show("Välj en adoption att ta bort.");
            }
        }
        }
    }





