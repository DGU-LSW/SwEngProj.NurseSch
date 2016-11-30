using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * 작성: 정창훈, 임제희
 * Module: CheckTableForm
 * LOC: 43
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

				tboxTable.Text = sr.ReadToEnd();

				sr.Close();
			}
		}
	}
}
