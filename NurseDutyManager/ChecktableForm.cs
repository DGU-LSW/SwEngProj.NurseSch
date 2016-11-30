using System.IO;
using System.Windows.Forms;

/*
 * 작성: 임제희
 * Module: DutyList 폼
 * LOC:
 */

namespace NurseDutyManager
{
    public partial class CheckTableForm : Form
    {
        ClientSocket clientsocket = null;

        public CheckTableForm()
        {
            InitializeComponent();
        }

        public CheckTableForm(ClientSocket _clientsocket) : this()
        {
            clientsocket = _clientsocket;
        }

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
			openFileDialog1.DefaultExt = "txt";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);

				tboxTable.Text = sr.ReadToEnd().ToString();

				sr.Close();
			}
		}
	}
}
