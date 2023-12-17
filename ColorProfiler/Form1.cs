using ColorProfiler.Profiler;
using System.Configuration;
using System.Windows.Forms;

namespace ColorProfiler
{
    public partial class Form1 : Form
    {
        private ColorProfiler.Profiler.Profiler profiler;
        public Form1()
        {
            profiler = new ColorProfiler.Profiler.Profiler();
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            inProfileComboBox.Items.AddRange(ColorProfile.Profiles.Select(x => x.Name).ToArray());
            outProfileComboBox.Items.AddRange(ColorProfile.Profiles.Select(x => x.Name).ToArray());
            inProfileComboBox.SelectedIndex = 0;
            outProfileComboBox.SelectedIndex = 4;
            string resourcesPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Resources\\";
            string fileName = "gk1.png";
            SetImg(resourcesPath + fileName);
        }
        private void SetImg(string imgPath)
        {
            Bitmap bt = new Bitmap(imgPath);
            Bitmap scaledBitmap = new Bitmap(inPictureBox.Width, inPictureBox.Height);
            using (Graphics g = Graphics.FromImage(scaledBitmap))
            {
                g.DrawImage(bt, 0, 0, inPictureBox.Width, inPictureBox.Height);
            }
            inPictureBox.Image = scaledBitmap;
            profiler.Image = scaledBitmap;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Wybierz obraz";
            openFileDialog.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Wszystkie pliki|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                SetImg(imagePath);
            }
            inPictureBox.Refresh();
        }

        private void inProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profile = ColorProfile.Profiles[((ComboBox)sender).SelectedIndex];
            inGammaTextBox.Text = profile.Gamma.ToString();
            inWhiteXTextBox.Text = profile.W.x.ToString();
            inWhiteYTextBox.Text = profile.W.y.ToString();
            inRedXTextBox.Text = profile.R.x.ToString();
            inRedYTextBox.Text = profile.R.y.ToString();
            inGreenXTextBox.Text = profile.G.x.ToString();
            inGreenYTextBox.Text = profile.G.y.ToString();
            inBlueXTextBox.Text = profile.B.x.ToString();
            inBlueYTextBox.Text = profile.B.y.ToString();
            profiler.InProfile = profile;
        }

        private void outProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profile = ColorProfile.Profiles[((ComboBox)sender).SelectedIndex];
            outGammaTextBox.Text = profile.Gamma.ToString();
            outWhiteXTextBox.Text = profile.W.x.ToString();
            outWhiteYTextBox.Text = profile.W.y.ToString();
            outRedXTextBox.Text = profile.R.x.ToString();
            outRedYTextBox.Text = profile.R.y.ToString();
            outGreenXTextBox.Text = profile.G.x.ToString();
            outGreenYTextBox.Text = profile.G.y.ToString();
            outBlueXTextBox.Text = profile.B.x.ToString();
            outBlueYTextBox.Text = profile.B.y.ToString();
            profiler.OutProfile = profile;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            outPictureBox.Image = profiler.Generate();
        }
    }
}