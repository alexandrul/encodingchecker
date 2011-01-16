using System.Diagnostics;
using System.Windows.Forms;

namespace EncodingChecker
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private static void OnHomepageClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo("http://encodingchecker.codeplex.com") {
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}