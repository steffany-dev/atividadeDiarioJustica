using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeDiarioJustica
{
    using System.Diagnostics;
    using System.Net;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            String caderno = cbCaderno.SelectedIndex.ToString();
            int numCaderno = 0;

            switch (caderno)
            {
                case "0":
                    numCaderno = 10;
                    break;
                case "1":
                    numCaderno = 11;
                    break;
                case "2":
                    numCaderno = 12;
                    break;
                case "3":
                    numCaderno = 18;
                    break;
                case "4":
                    numCaderno = 13;
                    break;
                case "5":
                    numCaderno = 15;
                    break;
                case "6":
                    numCaderno = 14;
                    break;
                default:
                    break;
            }

            string link = "https://dje.tjsp.jus.br/cdje/downloadCaderno.do?dtDiario=" + dtpDataDiario.Value + "&cdCaderno=" + numCaderno + "&tpDownload=D";
            string nomeArquivo = cbCaderno.Text;

            var baixar = new WebClient();

            baixar.DownloadFile(link, "C:\\Users\\administrator\\Desktop\\UNIFAFIBE\\Visual Studio\\atividadeDiarioJustica\\Caderno\\" + "" + nomeArquivo + ".pdf");

            MessageBox.Show("Baixado com sucesso: " + nomeArquivo, "Download Completo");
        }
    }
}
