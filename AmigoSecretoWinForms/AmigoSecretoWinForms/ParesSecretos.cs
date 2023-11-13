using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoSecretoWinForms
{
    public partial class ParesSecretos : Form
    {
        public ParesSecretos()
        {
            InitializeComponent();
            Persistencia.mostrarPares("secreto.csv", listViewSecreto);
        }


    }
}
