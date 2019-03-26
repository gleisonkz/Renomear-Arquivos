using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RenomearArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"C:\Users\Gleison\Downloads\TESTE RENAME");
            string dirsaida = @"C:\Users\Gleison\Downloads\TESTE RENAME";

            for (int i = 0; i < arquivos.Length; i++)
            {
                var files = new FileInfo(arquivos[i]);
                if (files.Name.Contains("QUERO"))
                {
                    files.CopyTo(Path.Combine(dirsaida, files.Name.Replace("QUERO", "").Trim()), true);
                }
            }
            MessageBox.Show("Movimentação e rename concluído");
        }
    }
}
