using System.Drawing;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class DagableBorder : UserControl
    {
        private Point lastPoint;
        public DagableBorder()
        {
            InitializeComponent();
            btClose.Click += (sender, args) => ((Form)this.Parent).Close();
        }
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Parent.Left += e.X - lastPoint.X;
                this.Parent.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = Point.Empty;
            }
        }
    }
}
