using DSDecmp.Formats.Nitro;
using System.Diagnostics;
using System.Text;

namespace LZ77_wii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_compress_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFilePath = openFileDialog.FileName;

                using (FileStream instream = File.OpenRead(inputFilePath))
                using (MemoryStream outstream = new MemoryStream())
                {
                    LZ11 lz11 = new LZ11();
                    int compressedSize = lz11.Compress(instream, instream.Length, outstream);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = Path.GetFileName(inputFilePath) + ".lz";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, outstream.ToArray());
                        MessageBox.Show("The file: " + Path.GetFileName(inputFilePath) + "\nHas been compressed to .lz");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("https://github.com/DanielSvoboda/LZ11_wii_compress");
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }
    }
}