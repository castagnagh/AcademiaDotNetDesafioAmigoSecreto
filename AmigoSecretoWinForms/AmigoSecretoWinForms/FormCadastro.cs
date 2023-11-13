using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AmigoSecretoWinForms
{
    public partial class FormCadastro : Form
    {
        private List<Amigo> lista;
        private Form2 form2;

        public FormCadastro(List<Amigo> lista, Form2 form2)
        {
            InitializeComponent();
            this.lista = lista;
            this.form2 = form2;
        }

        private void buttonCadastrarAmigo_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (!Util.EmailIsValid(email))
            {
                labelStatus.Text = "Email inválido";
                labelStatus.ForeColor = System.Drawing.Color.Red;
                textBoxEmail.Text = "";
                textBoxEmail.Focus();
                return;
            }
            CadastrarAmigo();
        }

        private void keyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string email = textBoxEmail.Text;
                if (!Util.EmailIsValid(email))
                {
                    labelStatus.Text = "Email inválido";
                    labelStatus.ForeColor = System.Drawing.Color.Red;
                    textBoxEmail.Text = "";
                    textBoxEmail.Focus();
                    return;
                }
                CadastrarAmigo();
            }
        }

        private void CadastrarAmigo()
        {
            if (textBoxNome.Text.Length == 0 || textBoxEmail.Text.Length == 0)
            {
                MessageBox.Show("Os campos não podem ser vazios!");
            }
            else
            {
                Amigo amigo = new Amigo(textBoxNome.Text, textBoxEmail.Text);

                if (lista.Contains(amigo))
                {
                    MessageBox.Show("O E-mail digitado já está em uso", "Aviso");
                }
                else
                {
                    // Se não existir, então adiciona o objeto na lista
                    lista.Add(amigo);
                    // Ordena pelo nome
                    lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                    // E grava no arquivo (no arquivo não tem ordenação)
                    Persistencia.gravarSimples(amigo, "amigos.csv");

                    textBoxEmail.Text = "";
                    textBoxNome.Text = "";

                    DialogResult result = MessageBox.Show("Deseja cadastrar outro amigo?", "Aviso", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                        form2.atualizarLista(lista);
                    }
                    else
                    {
                        form2.atualizarLista(lista);
                        labelStatus.Text = "";
                        textBoxNome.Focus();
                    }
                }
            }
        }

        private void keyPressEnterNome(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;

            if (Util.EmailIsValid(email))
            {
                labelStatus.Text = "Email válido";
                labelStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelStatus.Text = "Email inválido";
                labelStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}