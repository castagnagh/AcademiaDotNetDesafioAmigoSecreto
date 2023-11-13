namespace AmigoSecretoWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button3 = new Button();
            label4 = new Label();
            listViewNomes = new ListView();
            nome = new ColumnHeader();
            email = new ColumnHeader();
            button4 = new Button();
            label5 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(542, 139);
            button3.Name = "button3";
            button3.Size = new Size(86, 86);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(489, 228);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 7;
            label4.Text = "Gerar duplas de amigos";
            // 
            // listViewNomes
            // 
            listViewNomes.Anchor = AnchorStyles.None;
            listViewNomes.Columns.AddRange(new ColumnHeader[] { nome, email });
            listViewNomes.Location = new Point(176, 284);
            listViewNomes.Name = "listViewNomes";
            listViewNomes.Size = new Size(594, 344);
            listViewNomes.TabIndex = 8;
            listViewNomes.UseCompatibleStateImageBehavior = false;
            listViewNomes.View = View.Details;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 280;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 280;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(176, 634);
            button4.Name = "button4";
            button4.Size = new Size(32, 32);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(214, 639);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 10;
            label5.Text = "Apagar Lista";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(328, 139);
            button1.Name = "button1";
            button1.Size = new Size(86, 86);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(301, 228);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 5;
            label2.Text = "Cadastrar Amigo";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(883, 628);
            button2.Name = "button2";
            button2.Size = new Size(59, 58);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(883, 610);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "Espiar?";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(110, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 102);
            panel1.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(954, 698);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(listViewNomes);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Label label4;
        private ListView listViewNomes;
        private ColumnHeader nome;
        private ColumnHeader email;
        private Button button4;
        private Label label5;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Panel panel1;
    }
}