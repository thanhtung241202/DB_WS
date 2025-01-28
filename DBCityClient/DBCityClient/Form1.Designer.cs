namespace DBCityClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Showallcountry = new Button();
            CountrybyCode = new TextBox();
            getcountry = new Label();
            label1 = new Label();
            Enternamecity = new TextBox();
            Enternamecountry = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Countcity = new Button();
            Code = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 423);
            dataGridView1.TabIndex = 0;
            // 
            // Showallcountry
            // 
            Showallcountry.Location = new Point(205, 140);
            Showallcountry.Name = "Showallcountry";
            Showallcountry.Size = new Size(130, 36);
            Showallcountry.TabIndex = 1;
            Showallcountry.Text = "ShowAll";
            Showallcountry.UseVisualStyleBackColor = true;
            Showallcountry.Click += button1_Click;
            // 
            // CountrybyCode
            // 
            CountrybyCode.Location = new Point(113, 79);
            CountrybyCode.Multiline = true;
            CountrybyCode.Name = "CountrybyCode";
            CountrybyCode.Size = new Size(222, 34);
            CountrybyCode.TabIndex = 2;
            CountrybyCode.TextChanged += textBox1_TextChanged;
            // 
            // getcountry
            // 
            getcountry.AutoSize = true;
            getcountry.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getcountry.Location = new Point(43, 35);
            getcountry.Name = "getcountry";
            getcountry.Size = new Size(166, 38);
            getcountry.TabIndex = 3;
            getcountry.Text = "Get Country";
            getcountry.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 185);
            label1.Name = "label1";
            label1.Size = new Size(115, 38);
            label1.TabIndex = 4;
            label1.Text = "Get City";
            label1.Click += label1_Click_1;
            // 
            // Enternamecity
            // 
            Enternamecity.Location = new Point(113, 233);
            Enternamecity.Multiline = true;
            Enternamecity.Name = "Enternamecity";
            Enternamecity.Size = new Size(222, 34);
            Enternamecity.TabIndex = 5;
            // 
            // Enternamecountry
            // 
            Enternamecountry.Location = new Point(113, 306);
            Enternamecountry.Multiline = true;
            Enternamecountry.Name = "Enternamecountry";
            Enternamecountry.Size = new Size(222, 34);
            Enternamecountry.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 247);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 309);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "Country";
            label3.Click += label3_Click;
            // 
            // Countcity
            // 
            Countcity.Location = new Point(241, 346);
            Countcity.Name = "Countcity";
            Countcity.Size = new Size(94, 29);
            Countcity.TabIndex = 9;
            Countcity.Text = "Count";
            Countcity.UseVisualStyleBackColor = true;
            // 
            // Code
            // 
            Code.AutoSize = true;
            Code.Location = new Point(47, 93);
            Code.Name = "Code";
            Code.Size = new Size(44, 20);
            Code.TabIndex = 10;
            Code.Text = "Code";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 487);
            Controls.Add(Code);
            Controls.Add(Countcity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Enternamecountry);
            Controls.Add(Enternamecity);
            Controls.Add(label1);
            Controls.Add(getcountry);
            Controls.Add(CountrybyCode);
            Controls.Add(Showallcountry);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Showallcountry;
        private TextBox CountrybyCode;
        private Label getcountry;
        private Label label1;
        private TextBox Enternamecity;
        private TextBox Enternamecountry;
        private Label label2;
        private Label label3;
        private Button Countcity;
        private Label Code;
    }
}
