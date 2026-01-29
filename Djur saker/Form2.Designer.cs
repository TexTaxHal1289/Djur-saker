namespace Djur_saker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Personnamn = new System.Windows.Forms.TextBox();
            this.Nummerperson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterAdoption = new System.Windows.Forms.Button();
            this.efternamn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Personnamn
            // 
            this.Personnamn.Location = new System.Drawing.Point(35, 73);
            this.Personnamn.Name = "Personnamn";
            this.Personnamn.Size = new System.Drawing.Size(232, 26);
            this.Personnamn.TabIndex = 0;
            // 
            // Nummerperson
            // 
            this.Nummerperson.Location = new System.Drawing.Point(35, 260);
            this.Nummerperson.Name = "Nummerperson";
            this.Nummerperson.Size = new System.Drawing.Size(232, 26);
            this.Nummerperson.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personnummer";
            // 
            // RegisterAdoption
            // 
            this.RegisterAdoption.Location = new System.Drawing.Point(500, 286);
            this.RegisterAdoption.Name = "RegisterAdoption";
            this.RegisterAdoption.Size = new System.Drawing.Size(254, 158);
            this.RegisterAdoption.TabIndex = 6;
            this.RegisterAdoption.Text = "Adoptera ditt djur!";
            this.RegisterAdoption.UseVisualStyleBackColor = true;
            this.RegisterAdoption.Click += new System.EventHandler(this.RegisterAdoption_Click);
            
            // efternamn
            // 
            this.efternamn.Location = new System.Drawing.Point(35, 148);
            this.efternamn.Name = "efternamn";
            this.efternamn.Size = new System.Drawing.Size(232, 26);
            this.efternamn.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "efternamn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.efternamn);
            this.Controls.Add(this.RegisterAdoption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nummerperson);
            this.Controls.Add(this.Personnamn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Personnamn;
        private System.Windows.Forms.TextBox Nummerperson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterAdoption;
        private System.Windows.Forms.TextBox efternamn;
        private System.Windows.Forms.Label label3;
    }
}