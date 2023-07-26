namespace ACS.Forms.SubForms.Estoque
{
    partial class FormAlterarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarItem));
            dataGridView1 = new DataGridView();
            Seleção = new DataGridViewCheckBoxColumn();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            label11 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label5 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Seleção });
            dataGridView1.Location = new Point(96, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 313);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Seleção
            // 
            Seleção.HeaderText = "Seleção";
            Seleção.Name = "Seleção";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 136);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 5;
            label3.Text = "Buscar item por :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Codigo", "Item", "Marca", "Descrição", "Local", "Tipo" });
            comboBox1.Location = new Point(221, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(477, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(391, 136);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 8;
            label1.Text = "Pesquisar :\r\n";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(907, 132);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 509);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 20;
            label2.Text = "Alterar:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Item", "Marca", "Descrição", "Local", "Tipo", "Status" });
            comboBox2.Location = new Point(114, 509);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 509);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 22;
            label4.Text = "Para:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(326, 509);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(389, 23);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(868, 559);
            button2.Name = "button2";
            button2.Size = new Size(174, 23);
            button2.TabIndex = 10;
            button2.Text = "Alterar em grande escala";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(729, 505);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 27;
            label6.Text = "Grande escala:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(841, 505);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 23);
            textBox4.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(959, 505);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 29;
            label7.Text = "Á";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(983, 505);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 23);
            textBox5.TabIndex = 9;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(490, 480);
            button3.Name = "button3";
            button3.Size = new Size(152, 23);
            button3.TabIndex = 4;
            button3.Text = "Exibir todos os Itens";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(477, 40);
            label11.Name = "label11";
            label11.Size = new Size(175, 33);
            label11.TabIndex = 32;
            label11.Text = "ALTERAR ITEM";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 626);
            panel2.TabIndex = 35;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(989, 46);
            label8.Name = "label8";
            label8.Size = new Size(49, 29);
            label8.TabIndex = 36;
            label8.Text = "......";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(841, 54);
            label5.Name = "label5";
            label5.Size = new Size(149, 19);
            label5.TabIndex = 35;
            label5.Text = "Quantidade de itens: ";
            // 
            // button4
            // 
            button4.Location = new Point(184, 559);
            button4.Name = "button4";
            button4.Size = new Size(204, 23);
            button4.TabIndex = 7;
            button4.Text = "Alterar Itens selecionados";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormAlterarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 663);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAlterarItem";
            Text = "Alterar Item";
            Load += FormAlterarItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Button button3;
        private Label label11;
        private Panel panel2;
        private DataGridViewCheckBoxColumn Seleção;
        private Button button4;
        private Label label8;
        private Label label5;
    }
}