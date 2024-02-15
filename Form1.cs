using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            btnIr.Left = this.ClientSize.Width - btnIr.Width;
            comboBox1.Width = btnIr.Left - comboBox1.Left;
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            string url = comboBox1.Text.ToString();
            if (webView != null && webView.CoreWebView2 != null)
            {
                if (!(url.Contains(".")))
                {
                    url = "https://www.google.com/search?q=" + url;

                }
                else if (!(url.Contains("http://")))
                {
                    url = "http://" + url;

                }
                webView.CoreWebView2.Navigate(url);
                Guardar("Historial.txt", comboBox1.Text);
                comboBox1.Items.Add(url);
                //MessageBox.Show("Historial?", "¿Quieres guardar el historial?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }

        private void Guardar(string NombreArchivo, string texto)
        {
            FileStream flujo = new FileStream(NombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(flujo);
            writer.WriteLine(texto);
            writer.Close();
        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            //webBrowser1.GoHome();
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
             webView.GoBack();
            ///webBrowser1.GoBack();
        }

        private void haciaDelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.GoForward();
            //webBrowser1.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            string fileName = @"C:\Users\kenri\OneDrive\Escritorio\WindowsFormsApp1\bin\Debug\Historial.txt";

            FileStream flujo = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(flujo);

            while (lector.Peek() > -1)

            {
                string textoleido = lector.ReadLine();
                comboBox1.Items.Add(textoleido);
            }
            lector.Close();
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
