namespace AmigoSecretoWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonEntrar = new Button();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.Anchor = AnchorStyles.None;
            buttonEntrar.AutoSize = true;
            buttonEntrar.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEntrar.Location = new Point(377, 304);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(106, 43);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 617);
            Controls.Add(buttonEntrar);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEntrar;
    }
}