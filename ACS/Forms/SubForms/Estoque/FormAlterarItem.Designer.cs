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
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            label11 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 63);
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
            comboBox1.Location = new Point(174, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(481, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(395, 63);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 8;
            label1.Text = "Pesquisar :\r\n";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(918, 59);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 19;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 492);
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
            comboBox2.Location = new Point(121, 492);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(384, 492);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 22;
            label4.Text = "Para:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(432, 488);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(389, 23);
            textBox2.TabIndex = 23;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(931, 487);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 24;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 428);
            label5.Name = "label5";
            label5.Size = new Size(246, 19);
            label5.TabIndex = 25;
            label5.Text = "Código do Item que deseja atualizar:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(320, 428);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 23);
            textBox3.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(627, 432);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 27;
            label6.Text = "Grande escala:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(739, 428);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 23);
            textBox4.TabIndex = 28;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(873, 432);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 29;
            label7.Text = "Á";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(923, 428);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 23);
            textBox5.TabIndex = 30;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(481, 117);
            button3.Name = "button3";
            button3.Size = new Size(152, 23);
            button3.TabIndex = 31;
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
            label11.Location = new Point(481, -4);
            label11.Name = "label11";
            label11.Size = new Size(175, 33);
            label11.TabIndex = 32;
            label11.Text = "ALTERAR ITEM";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(566, 432);
            label8.Name = "label8";
            label8.Size = new Size(30, 19);
            label8.TabIndex = 33;
            label8.Text = "OU";
            // 
            // FormAlterarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 580);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAlterarItem";
            Text = "Alterar Item";
            Load += FormAlterarItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Button button3;
        private Label label11;
        private Label label8;
    }
}