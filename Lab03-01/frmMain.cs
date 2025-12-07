namespace Lab03_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Media|*.mp4;*mp3;*avi;*wav;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                axWindowsMediaPlayer.URL = open.FileName;

            }
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
        }
    }
}
