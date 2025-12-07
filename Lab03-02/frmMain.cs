using System.Drawing;
using System.Drawing.Text;

namespace Lab03_02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (FontFamily f in new InstalledFontCollection().Families) cmbFont.Items.Add(f.Name);
            int[] sizes = { 8, 10, 12, 14, 16, 20, 24, 36, 48, 72 };
            foreach (int s in sizes) cmbSizes.Items.Add(s);
            cmbFont.SelectedItem = "Tahoma";
            cmbSizes.SelectedItem = 16;
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {
                Font crt = rtbText.SelectionFont;
                FontStyle newStyle = crt.Style ^ FontStyle.Bold;
                rtbText.SelectionFont = new Font(crt.FontFamily, crt.Size, newStyle);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {
                Font crt = rtbText.SelectionFont;
                FontStyle newStyle = crt.Style ^ FontStyle.Italic;
                rtbText.SelectionFont = new Font(crt.FontFamily, crt.Size, newStyle);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {
                Font crt = rtbText.SelectionFont;
                FontStyle newStyle = crt.Style ^ FontStyle.Underline;
                rtbText.SelectionFont = new Font(crt.FontFamily, crt.Size, newStyle);
            }
        }

        private void systemOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Rich Text Format|*.rtf|Text Files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbText.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    rtbText.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);

                }
            }
        }

        private void systemSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Rich Text Format|*.rtf";
            save.DefaultExt = "rtf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                rtbText.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void systemNewPage_Click(object sender, EventArgs e)
        {
            if (rtbText.Modified) // nếu page có thay đổi thì hỏi cái đã
            {
                DialogResult check = MessageBox.Show("Bạn cóa mún lưu lại trước khi xóa hem?", "XÁC NHẬN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (check == DialogResult.Yes) // nếu có thì lưu cái =))
                {
                    systemSaveFile_Click(sender, e);
                }
                else if (check == DialogResult.Cancel)
                { // nếu sợ thì tha
                    MessageBox.Show("Tôi tha cho bạn đấy, làm tiếp đi!", "Hứ hứ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            rtbText.Clear(); // xóa
            rtbText.Modified = false;
            rtbText.Font = new Font("Tahoma", 16); // reset thằng rich text box về font và size default

            cmbFont.SelectedItem = "Tahoma"; // reset luôn thằng font
            cmbSizes.SelectedItem = 16; // thằng này cũng z

        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (rtbText.SelectionColor != Color.Empty)
            {
                colorDlg.Color = rtbText.SelectionColor;
            }

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                rtbText.SelectionColor = colorDlg.Color;
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {
                string newFontName = cmbFont.SelectedItem.ToString();
                float crtSizes = rtbText.SelectionFont.Size;
                FontStyle crtStyle = rtbText.SelectionFont.Style;
                rtbText.SelectionFont = new Font(newFontName, crtSizes, crtStyle);
            }
        }

        private void cmbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {

                float newSizes = float.Parse(cmbSizes.SelectedItem.ToString());
                FontFamily crtFont = rtbText.SelectionFont.FontFamily;
                FontStyle crtStyle = rtbText.SelectionFont.Style;
                rtbText.SelectionFont = new Font(crtFont, newSizes, crtStyle);

            }
        }

        private void btnNewPage_Click(object sender, EventArgs e)
        {
            if (rtbText.Modified) // nếu page có thay đổi thì hỏi cái đã
            {
                DialogResult check = MessageBox.Show("Bạn cóa mún lưu lại trước khi xóa hem?", "XÁC NHẬN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (check == DialogResult.Yes) // nếu có thì lưu cái =))
                {
                    systemSaveFile_Click(sender, e);
                }
                else if (check == DialogResult.Cancel)
                { // nếu sợ thì tha
                    MessageBox.Show("Tôi tha cho bạn đấy, làm tiếp đi!", "Hứ hứ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            rtbText.Clear(); // xóa
            rtbText.Modified = false;
            rtbText.Font = new Font("Tahoma", 16); // reset thằng rich text box về font và size default

            cmbFont.SelectedItem = "Tahoma"; // reset luôn thằng font
            cmbSizes.SelectedItem = 16; // thằng này cũng z
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Rich Text Format|*.rtf";
            save.DefaultExt = "rtf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                rtbText.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Rich Text Format|*.rtf|Text Files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rtbText.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    rtbText.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);

                }
            }
        }

        private void systemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
