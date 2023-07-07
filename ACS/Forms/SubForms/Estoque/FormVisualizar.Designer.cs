namespace ACS.Forms.SubForms.Estoque
{
    partial class FormVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizar));
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            textBox2 = new TextBox();
            button4 = new Button();
            comboBox2 = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(905, 289);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(503, 27);
            label3.Name = "label3";
            label3.Size = new Size(121, 33);
            label3.TabIndex = 7;
            label3.Text = "ESTOQUE";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(483, 417);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 8;
            button1.Text = "Visualizar todo estoque";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 96);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 9;
            label1.Text = "Pesquisar por :\r\n";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(373, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(880, 95);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 11;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 474);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 12;
            label2.Text = "Tipo :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Máquina", "Ferramentas", "Doméstico", "Escritório" });
            comboBox1.Location = new Point(110, 470);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(256, 474);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 14;
            label4.Text = "Localização :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(587, 474);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 16;
            label5.Text = "Status :";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.None;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Dentro de obra", "Fora de obra" });
            comboBox3.Location = new Point(650, 470);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(794, 474);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 18;
            label6.Text = "Procedência :";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.None;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Comprado", "Alugado" });
            comboBox4.Location = new Point(896, 470);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(354, 470);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 21;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(503, 526);
            button4.Name = "button4";
            button4.Size = new Size(161, 23);
            button4.TabIndex = 22;
            button4.Text = "Pesquisar :";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Codigo", "Item", "Marca", "Descrição", "Local", "Tipo", "Procedencia" });
            comboBox2.Location = new Point(211, 96);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox3);
            panel1.Location = new Point(24, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 602);
            panel1.TabIndex = 24;
            // 
            // FormVisualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 646);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVisualizar";
            Text = "FormVisualizar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private Button button4;
        private ComboBox comboBox2;
        private Panel panel1;
    }
}