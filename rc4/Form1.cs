using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rc4
{
    public partial class Form1 : Form
    {
        byte[] fileBytes;
        string filename;
        string keyFile;
        string keyData;

        public Form1()
        {
            InitializeComponent();
        }

        private void selFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files|*";
            openFileDialog1.Title = "Select a File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               filename = openFileDialog1.FileName;
                fileBytes = System.IO.File.ReadAllBytes(@filename);
            }
        }

        private void importKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|* txt";
            openFileDialog1.Title = "Select a Text File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                keyFile = openFileDialog1.FileName;
                keyData = System.IO.File.ReadAllText(@keyFile);
                byte[] keyBytes = Encoding.Unicode.GetBytes(keyData);
                if(keyBytes.Length < 1)
                {
                    faultyKeyText.Text = "The key is too short, it should be between 1 and 256 bytes";
                    faultyKeyText.Visible = true;
                } else if (keyBytes.Length > 256)
                {
                    faultyKeyText.Text = "The key is too long, it should be between 1 and 256 bytes";
                    faultyKeyText.Visible = true;
                } else
                {
                    faultyKeyText.Visible = false;
                    encKey.Text = keyData;
                }
            }
        }
        private void saveKey_Click(object sender, EventArgs e)
        {
            string keyText = encKey.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, keyText);
                }
            }

        }


        private void genKey_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(numForKey.Text, out int n);
            if (isNumeric) { 
                encKey.Text = getUniqueKey(Int32.Parse(numForKey.Text));
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();

            byte[] keyBytes = Encoding.Unicode.GetBytes(encKey.Text);
            if (keyBytes.Length < 1)
            {
                faultyKeyText.Text = "The key is too short, it should be between 1 and 256 bytes";
                faultyKeyText.Visible = true;
            }
            else if (keyBytes.Length > 256)
            {
                faultyKeyText.Text = "The key is too long, it should be between 1 and 256 bytes";
                faultyKeyText.Visible = true;
            }
            else
            {
                sw.Start();

                faultyKeyText.Visible = false;
                byte[] encryptedData = encrypt(keyBytes, fileBytes);
                System.IO.File.WriteAllBytes(filename + ".enc", encryptedData);

                sw.Stop();
                
                long seconds = sw.ElapsedMilliseconds * 1000;
                long speed = fileBytes.Length / seconds;

                encSpeed.Text = speed + " B/s";
                encSpeed.Visible = true;

            }
            
        }



        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            byte[] key = Encoding.Unicode.GetBytes(encKey.Text);
            if (key.Length < 1)
            {
                faultyKeyText.Text = "The key is too short, it should be between 1 and 256 bytes";
                faultyKeyText.Visible = true;
            }
            else if (key.Length > 256)
            {
                faultyKeyText.Text = "The key is too long, it should be between 1 and 256 bytes";
                faultyKeyText.Visible = true;
            }
            else
            {
                sw.Start();

                faultyKeyText.Visible = false;
                byte[] decryptedData = decrypt(key, fileBytes);
                int index = filename.LastIndexOf(".");
                if (index > 0)
                {
                    filename = filename.Substring(0, index);
                }
                string tempFilename;
                int index2 = filename.LastIndexOf(".");
                if (index2 > 0)
                {
                    tempFilename = filename.Substring(0, index2);
                    tempFilename = tempFilename + "Decrypted" + filename.Substring(index2);
                    filename = tempFilename;
                }
                System.IO.File.WriteAllBytes(filename, decryptedData);
                sw.Stop();

                long seconds = sw.ElapsedMilliseconds * 1000;
                long speed = fileBytes.Length / seconds;

                decSpeed.Text = speed + " B/s";
                decSpeed.Visible = true;
            }
           
        }

        private byte[] encrypt(byte[] key, byte[] encryptionData)
        {
            byte[] encrypted = new byte[encryptionData.Length];
            byte[] initKey = initializePermutation(key);

            int i = 0;
            int j = 0;

            for(int b = 0; b < encryptionData.Length; b++)
            {
                i = (i + 1) % 255;
                j = (j + initKey[i]) % 255;

                byte c = initKey[i];
                initKey[i] = initKey[j];
                initKey[j] = c;

                encrypted[b] = (byte)(encryptionData[b] ^ initKey[(initKey[i] + initKey[j]) % 255]);
            }
            return encrypted;
        }

        private byte[] decrypt(byte[] key, byte[] decrpyptionData)
        {

            byte[] decrypted = new byte[decrpyptionData.Length];
            byte[] initKey = initializePermutation(key);

            int i = 0;
            int j = 0;

            for (int b = 0; b < decrpyptionData.Length; b++)
            {
                i = (i + 1) % 255;
                j = (j + initKey[i]) % 255;

                byte c = initKey[i];
                initKey[i] = initKey[j];
                initKey[j] = c;

                decrypted[b] = (byte)(decrpyptionData[b] ^ initKey[(initKey[i] + initKey[j]) % 255]);
            }
            return decrypted;
        }

        private byte[] initializePermutation(byte[] key)
        {
            byte[] s = new byte[256];
            for(int i = 0; i < 256; i++)
            {
                s[i] = (byte)i;
            }
            for (int i = 0, j = 0; i < 256; i++)
            {
                
                j = (j + s[i] + key[i % key.Length]) % 255;

                byte c = s[i];
                s[i] = s[j];
                s[j] = c;
            }

            return s;
        }

        public string getUniqueKey(int size)
        {
            char[] chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

    }
}
