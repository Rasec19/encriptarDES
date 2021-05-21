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
using System.Security.Cryptography;

namespace Encriptar
{
    public partial class Form1 : Form
    {
        public static string key = "abc123ky";
        public string Encriptar(string dato, string key) {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] encriptar = Encoding.UTF8.GetBytes(dato);

            var DES = new DESCryptoServiceProvider();
            DES.Key = keyArray;
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = DES.CreateEncryptor();
            byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            DES.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length);

        }

        public string DesEncriptar(string dato, string key)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] desEncriptar = Convert.FromBase64String(dato);

            var DES = new DESCryptoServiceProvider();
            DES.Key = keyArray;
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = DES.CreateDecryptor();
            byte[] resultado = cTransform.TransformFinalBlock(desEncriptar, 0, desEncriptar.Length);
            DES.Clear();

            return Encoding.UTF8.GetString(resultado);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtImprimir.Text = Encriptar(txtDato.Text, key);
            }
            catch (Exception) {
                MessageBox.Show("Escriba codigo valido para cifrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnDesEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtImprimir.Text = DesEncriptar(txtDato.Text, key);
            }
            catch (Exception) {
                MessageBox.Show("Escriba codigo valido para decifrar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void BtnArchivos_Images_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ventanaEmergente = new OpenFileDialog();
                ventanaEmergente.Filter = "Archivos de texto|*.txt";

                if (ventanaEmergente.ShowDialog() == DialogResult.OK)
                {

                    using (StreamReader leer = new StreamReader(ventanaEmergente.FileName))
                    {

                        txtDato.Text = leer.ReadToEnd();
                    }

                }
            }
            catch (Exception) { }


        }

        private void TxtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog ventanaEmergente = new SaveFileDialog();
                ventanaEmergente.Filter = "Archivos de texto|*.txt";

                if (ventanaEmergente.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter escribir = new StreamWriter(ventanaEmergente.FileName))
                    {

                        escribir.Write(txtImprimir.Text);
                    }

                }
            }
            catch (Exception) { }
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            try{
                OpenFileDialog ventanaEmergente = new OpenFileDialog();
                ventanaEmergente.Filter = "Archivos de imagen|*.jpg";

                if (ventanaEmergente.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(ventanaEmergente.FileName);

                    pbImagen.Image = img;
                }
            }
            catch (Exception) { }
        }
    }
}
