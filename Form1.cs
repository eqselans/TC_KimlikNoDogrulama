using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcKimlik
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			TcKimlik.KPSPublic kPS = new TcKimlik.KPSPublic();
			
			bool kontrol = kPS.TCKimlikNoDogrula(long.Parse(textBox1.Text),textBox2.Text.ToUpper(),textBox3.Text.ToUpper(),int.Parse(textBox4.Text)); 

			if (kontrol == true) 
			{

				MessageBox.Show("Kullanıcı Doğrulandı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Kullanıcı Doğrulanmadı", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
