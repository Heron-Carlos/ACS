namespace ACS.Forms.SubForms.Estoque
{
    partial class FormCadastrarUnifrome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUnifrome));
            label3 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label5 = new Label();
            comboBox5 = new ComboBox();
            label6 = new Label();
            comboBox6 = new ComboBox();
            label7 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            comboBox7 = new ComboBox();
            label10 = new Label();
            comboBox8 = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 5;
            label3.Text = "Tipo:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jaleco", "Calça", "Botina" });
            comboBox1.Location = new Point(59, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(191, 58);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 7;
            label1.Text = "Tamanho:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "P", "M", "G", "GG", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45" });
            comboBox2.Location = new Point(272, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(412, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 9;
            label2.Text = "Status:";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.None;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Novo", "Higienizado" });
            comboBox3.Location = new Point(471, 54);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(1047, 38);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(221, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 275);
            dataGridView1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(445, 383);
            button2.Name = "button2";
            button2.Size = new Size(176, 23);
            button2.TabIndex = 13;
            button2.Text = "Visualizar todo estoque";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 477);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 14;
            label4.Text = "Tipo:";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.None;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Jaleco", "Calça", "Botina" });
            comboBox4.Location = new Point(142, 473);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 473);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 16;
            label5.Text = "Tamanho:";
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.None;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "P", "M", "G", "GG", "38", "39", "40", "41", "42", "43", "44", "45" });
            comboBox5.Location = new Point(384, 473);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(539, 477);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 18;
            label6.Text = "Status:";
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.None;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Novo", "Higienizado" });
            comboBox6.Location = new Point(598, 477);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 19;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(829, 58);
            label7.Name = "label7";
            label7.Size = new Size(89, 19);
            label7.TabIndex = 20;
            label7.Text = "Quantidade:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(924, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(955, 477);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 22;
            button3.Text = "Pesquisar:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.ForeColor = Color.Red;
            button4.Location = new Point(1047, 86);
            button4.Name = "button4";
            button4.Size = new Size(97, 23);
            button4.TabIndex = 23;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1074, 64);
            label8.Name = "label8";
            label8.Size = new Size(28, 19);
            label8.TabIndex = 24;
            label8.Text = "Ou";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(608, 58);
            label9.Name = "label9";
            label9.Size = new Size(68, 19);
            label9.TabIndex = 25;
            label9.Text = "Material:";
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.None;
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Jeans", "Brim", "Polo", "Social", "Padrão" });
            comboBox7.Location = new Point(682, 54);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 26;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(735, 477);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 27;
            label10.Text = "Material:";
            // 
            // comboBox8
            // 
            comboBox8.Anchor = AnchorStyles.None;
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Jeans", "Brim", "Polo", "Social", "Padrão" });
            comboBox8.Location = new Point(809, 477);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(121, 23);
            comboBox8.TabIndex = 28;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(523, -2);
            label11.Name = "label11";
            label11.Size = new Size(153, 33);
            label11.TabIndex = 29;
            label11.Text = "UNIFORMES";
            // 
            // FormCadastrarUnifrome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 748);
            Controls.Add(label11);
            Controls.Add(comboBox8);
            Controls.Add(label10);
            Controls.Add(comboBox7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(comboBox6);
            Controls.Add(label6);
            Controls.Add(comboBox5);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastrarUnifrome";
            Text = "FormCadastrarUnifrome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label4;
        private ComboBox comboBox4;
        private Label label5;
        private ComboBox comboBox5;
        private Label label6;
        private ComboBox comboBox6;
        private Label label7;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label9;
        private ComboBox comboBox7;
        private Label label10;
        private ComboBox comboBox8;
        private Label label11;
    }
}