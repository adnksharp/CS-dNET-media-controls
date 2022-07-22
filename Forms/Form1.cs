using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Forms
{
	public partial class Form1 : Form
	{
		int[] media = { 0xC0000, 0xE0000, 0xB0000 },
				vol = { 0x80000, 0x90000, 0xA0000 };

		[DllImport("user32.dll")]
		public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button7.Text = "";
		}

		private void B1C(object sender, EventArgs e)
		{
			Media(0);
		}

		private void B2C(object sender, EventArgs e)
		{
			Media(1);
		}

		private void B3C(object sender, EventArgs e)
		{
			Media(2);
		}

		private void B4C(object sender, EventArgs e)
		{
			Volume(0);
		}

		private void B5C(object sender, EventArgs e)
		{
			Volume(1);
		}

		private void B7C(object sender, EventArgs e)
		{
			Volume(2);
		}

		private void Media(byte k)
		{
			SendMessageW(Handle, 0x319, Handle, (IntPtr)media[k]);
		}

		private void Volume(byte k)
		{
			SendMessageW(Handle, 0x319, Handle, (IntPtr)vol[k]);
		}
	}
}
