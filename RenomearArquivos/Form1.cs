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
            string[] arquivos = Directory.GetFiles(@"C:\Users\Gleison\Downloads\TESTE RENAME","*.ret");
            string dirsaida = @"C:\Users\Gleison\Downloads\TESTE RENAME";
            int cont = 0;
            foreach (var item in arquivos)
            {
                
                var ArquivoInfo = new FileInfo(item);
                if (ArquivoInfo.Name.Contains("QUERO"))
                {
                    ArquivoInfo.MoveTo(Path.Combine(dirsaida, ArquivoInfo.Name.Replace("QUERO", "").Trim()));
                }
                else
                {
                    cont++;
                }

            }

            if (cont == 0)
            {
                MessageBox.Show("Arquivos Renomeados");
            }
            else
            {
                MessageBox.Show("Não existem arquivos a serem renomeados");
            }
            
        }
    }
}
