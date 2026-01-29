namespace Djur_saker
{
    partial class historydesign
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
            this.History = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.ItemHeight = 20;
            this.History.Location = new System.Drawing.Point(3, 12);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1019, 444);
            this.History.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(874, 348);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 108);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "ta bort historik";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // historydesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.History);
            this.Name = "historydesign";
            this.Text = "historydesign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.Button Delete;
    }
}