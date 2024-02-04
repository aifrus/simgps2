using System.Windows.Forms;

namespace Aifrus.SimGPS2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Label_Hamburger_Click(object sender, System.EventArgs e)
        {
            ContextMenu.Show(Label_Hamburger, 0, Label_Hamburger.Height);
        }

        private void MenuItem_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
