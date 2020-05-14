namespace DBClientProject
{
    partial class EdycjaRadaru
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dopuszczlnaPredkoscLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label kierunekLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label wlascicielLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            this.dopuszczlnaPredkoscTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.kierunekTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.wlascicielTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.radarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            dopuszczlnaPredkoscLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            kierunekLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            wlascicielLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dopuszczlnaPredkoscLabel
            // 
            dopuszczlnaPredkoscLabel.AutoSize = true;
            dopuszczlnaPredkoscLabel.Location = new System.Drawing.Point(28, 33);
            dopuszczlnaPredkoscLabel.Name = "dopuszczlnaPredkoscLabel";
            dopuszczlnaPredkoscLabel.Size = new System.Drawing.Size(119, 13);
            dopuszczlnaPredkoscLabel.TabIndex = 1;
            dopuszczlnaPredkoscLabel.Text = "Dopuszczlna Predkosc:";
            // 
            // dopuszczlnaPredkoscTextBox
            // 
            this.dopuszczlnaPredkoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "DopuszczlnaPredkosc", true));
            this.dopuszczlnaPredkoscTextBox.Location = new System.Drawing.Point(153, 30);
            this.dopuszczlnaPredkoscTextBox.Name = "dopuszczlnaPredkoscTextBox";
            this.dopuszczlnaPredkoscTextBox.Size = new System.Drawing.Size(271, 20);
            this.dopuszczlnaPredkoscTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(28, 59);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(153, 56);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(271, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // kierunekLabel
            // 
            kierunekLabel.AutoSize = true;
            kierunekLabel.Location = new System.Drawing.Point(28, 85);
            kierunekLabel.Name = "kierunekLabel";
            kierunekLabel.Size = new System.Drawing.Size(52, 13);
            kierunekLabel.TabIndex = 5;
            kierunekLabel.Text = "Kierunek:";
            // 
            // kierunekTextBox
            // 
            this.kierunekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "Kierunek", true));
            this.kierunekTextBox.Location = new System.Drawing.Point(153, 82);
            this.kierunekTextBox.Name = "kierunekTextBox";
            this.kierunekTextBox.Size = new System.Drawing.Size(271, 20);
            this.kierunekTextBox.TabIndex = 6;
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(28, 111);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 7;
            nazwaLabel.Text = "Nazwa:";
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "Nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(153, 108);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(271, 20);
            this.nazwaTextBox.TabIndex = 8;
            // 
            // wlascicielLabel
            // 
            wlascicielLabel.AutoSize = true;
            wlascicielLabel.Location = new System.Drawing.Point(28, 137);
            wlascicielLabel.Name = "wlascicielLabel";
            wlascicielLabel.Size = new System.Drawing.Size(58, 13);
            wlascicielLabel.TabIndex = 9;
            wlascicielLabel.Text = "Wlasciciel:";
            // 
            // wlascicielTextBox
            // 
            this.wlascicielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "Wlasciciel", true));
            this.wlascicielTextBox.Location = new System.Drawing.Point(153, 134);
            this.wlascicielTextBox.Name = "wlascicielTextBox";
            this.wlascicielTextBox.Size = new System.Drawing.Size(271, 20);
            this.wlascicielTextBox.TabIndex = 10;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(28, 163);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(17, 13);
            xLabel.TabIndex = 11;
            xLabel.Text = "X:";
            // 
            // xTextBox
            // 
            this.xTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "X", true));
            this.xTextBox.Location = new System.Drawing.Point(153, 160);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(271, 20);
            this.xTextBox.TabIndex = 12;
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(28, 189);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(17, 13);
            yLabel.TabIndex = 13;
            yLabel.Text = "Y:";
            // 
            // yTextBox
            // 
            this.yTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radarBindingSource, "Y", true));
            this.yTextBox.Location = new System.Drawing.Point(153, 186);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(271, 20);
            this.yTextBox.TabIndex = 14;
            // 
            // radarBindingSource
            // 
            this.radarBindingSource.DataSource = typeof(DBClientProject.RadarDB.Radar);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(45, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(290, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EdycjaRadaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(dopuszczlnaPredkoscLabel);
            this.Controls.Add(this.dopuszczlnaPredkoscTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(kierunekLabel);
            this.Controls.Add(this.kierunekTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(wlascicielLabel);
            this.Controls.Add(this.wlascicielTextBox);
            this.Controls.Add(xLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(yLabel);
            this.Controls.Add(this.yTextBox);
            this.Name = "EdycjaRadaru";
            this.Text = "EdycjaRadaru";
            ((System.ComponentModel.ISupportInitialize)(this.radarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource radarBindingSource;
        private System.Windows.Forms.TextBox dopuszczlnaPredkoscTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox kierunekTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox wlascicielTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}