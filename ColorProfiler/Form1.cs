using ColorProfiler.Profiler;

namespace ColorProfiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            inProfileComboBox.Items.AddRange(ColorProfile.Profiles.Select(x => x.Name).ToArray());
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }
    }
}