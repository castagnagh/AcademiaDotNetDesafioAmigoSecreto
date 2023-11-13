namespace AmigoSecretoWinForms
{
    partial class ParesSecretos
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
            listViewSecreto = new ListView();
            nome1 = new ColumnHeader();
            nome2 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewSecreto
            // 
            listViewSecreto.Columns.AddRange(new ColumnHeader[] { nome1, nome2 });
            listViewSecreto.Location = new Point(35, 45);
            listViewSecreto.Name = "listViewSecreto";
            listViewSecreto.Size = new Size(425, 279);
            listViewSecreto.TabIndex = 0;
            listViewSecreto.UseCompatibleStateImageBehavior = false;
            listViewSecreto.View = View.Details;
            // 
            // nome1
            // 
            nome1.Text = "Esse";
            nome1.Width = 200;
            // 
            // nome2
            // 
            nome2.Text = "Pegou esse";
            nome2.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 18);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Isso é CONFIDÊNCIAL";
            // 
            // ParesSecretos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 351);
            Controls.Add(label1);
            Controls.Add(listViewSecreto);
            Name = "ParesSecretos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ParesSecretos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewSecreto;
        private ColumnHeader nome1;
        private ColumnHeader nome2;
        private Label label1;
    }
}