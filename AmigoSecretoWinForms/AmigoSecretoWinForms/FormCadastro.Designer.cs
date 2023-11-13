namespace AmigoSecretoWinForms
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            buttonCadastrarAmigo = new Button();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 182);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Novo Amigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(136, 235);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 1;
            label2.Text = "Digite o nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 295);
            label3.Name = "label3";
            label3.Size = new Size(105, 18);
            label3.TabIndex = 2;
            label3.Text = "Digite o email:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(136, 253);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(309, 23);
            textBoxNome.TabIndex = 3;
            textBoxNome.KeyPress += keyPressEnterNome;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(136, 313);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(309, 23);
            textBoxEmail.TabIndex = 4;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            textBoxEmail.KeyPress += keyPressEnter;
            // 
            // buttonCadastrarAmigo
            // 
            buttonCadastrarAmigo.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrarAmigo.Location = new Point(350, 370);
            buttonCadastrarAmigo.Name = "buttonCadastrarAmigo";
            buttonCadastrarAmigo.Size = new Size(95, 31);
            buttonCadastrarAmigo.TabIndex = 5;
            buttonCadastrarAmigo.Text = "Cadastrar";
            buttonCadastrarAmigo.UseVisualStyleBackColor = true;
            buttonCadastrarAmigo.Click += buttonCadastrarAmigo_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(136, 339);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 15);
            labelStatus.TabIndex = 6;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 435);
            Controls.Add(labelStatus);
            Controls.Add(buttonCadastrarAmigo);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Amigo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private Button buttonCadastrarAmigo;
        private Label labelStatus;
    }
}