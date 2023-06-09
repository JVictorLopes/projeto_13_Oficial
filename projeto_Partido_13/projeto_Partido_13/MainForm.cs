/*
 * Criado por SharpDevelop.
 * Usuário: josem
 * Data: 25/10/2022
 * Hora: 21:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projeto_Partido_13
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		Random rnd = new Random();
		int n6, n7;
		
		void Button1Click(object sender, EventArgs e)
		{
			int n1 = rnd.Next(1, 7);
			pictureBox1.Load("dado" + n1 + ".jpg");
			
			int n2 = rnd.Next(1, 7);
			pictureBox2.Load("dado" + n2 + ".jpg");
			
			int soma = n1 + n2;
			label4.Text = soma.ToString();
			
			n6 = rnd.Next(1, 7);
			n7 = rnd.Next(1, 7);
			
			button2.Enabled = true;
			button1.Enabled = false;
			pictureBox3.Visible = true;
			pictureBox3.Enabled = true;
			pictureBox3.Load("dado" + ".jpg");
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
			pictureBox3.Load("dado" + ".jpg");
			
			int n3 = rnd.Next(1, 7);
			pictureBox3.Load("dado" + n3 + ".jpg");
			
			
			int soma = int.Parse(label4.Text) + n3;
			label4.Text = soma.ToString();
			
			pictureBox4.Load("dado" + ".jpg");
			pictureBox3.Enabled = false;
			
			if (soma > 13)
			{
				MessageBox.Show("VOCÊ PERDEU BOBÃO! HAHAHAHAHAHA");
				int pontosM = int.Parse(label6.Text);
				pontosM = pontosM + 1;
				label6.Text = pontosM.ToString();
				
				int pontosJ3 = int.Parse(label2.Text);
				label2.Text = pontosJ3.ToString();
				label2.Text = "0";
					
				int pontosM3 = int.Parse(label4.Text);
				label4.Text = pontosM3.ToString();
				label4.Text = "0";
				
				pictureBox3.Enabled = false;
				pictureBox4.Visible = false;
				pictureBox5.Visible = false;
				pictureBox1.Load("dado" + ".jpg");
				pictureBox2.Load("dado" + ".jpg");
				button1.Enabled = true;
				pictureBox3.Visible = false;
				
				if (pontosM == 3) 
				{
					MessageBox.Show("TENTE DE NOVO, LOSER!");
					int pontosM4 = int.Parse(label8.Text);
					label8.Text = pontosM4.ToString();
					label8.Text = "0";
					
					int pontosJ4 = int.Parse(label6.Text);
					label6.Text = pontosJ4.ToString();
					label6.Text = "0";
				}
			}
			else
			{
				pictureBox4.Visible = true;
				pictureBox4.Enabled = true;
			}
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
			int n4 = rnd.Next(1, 7);
			pictureBox4.Load("dado" + n4 + ".jpg");
			
			int soma = int.Parse(label4.Text) + n4;
			label4.Text = soma.ToString();
			
			pictureBox4.Enabled = false;
			pictureBox5.Visible = true;
			pictureBox5.Enabled = true;
			pictureBox5.Load("dado" + ".jpg");
			
			if (soma > 13)
			{
				MessageBox.Show("SILASCOU OTARO KKKKK!");
				int pontosM = int.Parse(label6.Text);
				pontosM = pontosM + 1;
				label6.Text = pontosM.ToString();
				
				int pontosJ3 = int.Parse(label2.Text);
				label2.Text = pontosJ3.ToString();
				label2.Text = "0";
					
				int pontosM3 = int.Parse(label4.Text);
				label4.Text = pontosM3.ToString();
				label4.Text = "0";
				
				button1.Enabled = true;
				button2.Enabled = false;
				pictureBox3.Enabled = false;
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
				pictureBox5.Visible = false;
				pictureBox1.Load("dado" + ".jpg");
				pictureBox2.Load("dado" + ".jpg");
				
				if (pontosM == 3) 
				{
					MessageBox.Show("VOCÊ REALMENTE NÃO TÊM SORTE!");
					int pontosM4 = int.Parse(label8.Text);
					label8.Text = pontosM4.ToString();
					label8.Text = "0";
					
					int pontosJ4 = int.Parse(label6.Text);
					label6.Text = pontosJ4.ToString();
					label6.Text = "0";
				}
				
				
			}
			else
			{
				pictureBox5.Visible = true;
			}
		}
		void PictureBox5Click(object sender, EventArgs e)
		{
			int n5 = rnd.Next(1, 7);
			pictureBox5.Load("dado" + n5 + ".jpg");
			
			int soma = int.Parse(label4.Text) + n5;
			label4.Text = soma.ToString();
			
			if (soma > 13)
			{
				MessageBox.Show("PERDEU PLAYBOY KKKKKKK!");
				int pontosM = int.Parse(label6.Text);
				pontosM = pontosM + 1;
				label6.Text = pontosM.ToString();
				
				int pontosJ3 = int.Parse(label2.Text);
				label2.Text = pontosJ3.ToString();
				label2.Text = "0";
					
				int pontosM3 = int.Parse(label4.Text);
				label4.Text = pontosM3.ToString();
				label4.Text = "0";
				
				pictureBox1.Load("dado" + ".jpg");
				pictureBox2.Load("dado" + ".jpg");
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
				pictureBox5.Visible = false;
				button1.Enabled = true;
				button2.Enabled = false;
				
				if (pontosM == 3) 
				{
					MessageBox.Show("HAHAHAHA LOSER!");
					int pontosM4 = int.Parse(label8.Text);
					label8.Text = pontosM4.ToString();
					label8.Text = "0";
					
					int pontosJ4 = int.Parse(label6.Text);
					label6.Text = pontosJ4.ToString();
					label6.Text = "0";
				}
			}
			else 
			{
				MessageBox.Show("Clique no botão Finalizar.");
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			pictureBox1.Load("dado" + ".jpg");
			pictureBox2.Load("dado" + ".jpg");
			
			int soma = int.Parse(label4.Text);
			label4.Text = soma.ToString();
			
			int n6 = rnd.Next(1, 7);
			pictureBox6.Load("dado" + n6 + ".jpg");
			
			int n7 = rnd.Next(1, 7);
			pictureBox7.Load("dado" + n7 + ".jpg");
			
			int somaM = n6 + n7;
			label2.Text = somaM.ToString();
			
			button1.Enabled = true;
			button2.Enabled = false;
			
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			
			if (soma > 13 || soma < somaM)
			{
				MessageBox.Show("AI QUE BURRO, DÁ ZERO PRA ELE HIHI!");
				int pontosM = int.Parse(label6.Text);
				pontosM = pontosM + 1;
				label6.Text = pontosM.ToString();
				button1.Enabled = true;
				
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
				
				pictureBox6.Load("dado" + ".jpg");
				pictureBox7.Load("dado" + ".jpg");
				
				int pontosJ2 = int.Parse(label2.Text);
				label2.Text = pontosJ2.ToString();
				label2.Text = "0";
					
				int pontosM2 = int.Parse(label4.Text);
				label4.Text = pontosM2.ToString();
				label4.Text = "0";
				
				if (pontosM == 3) 
				{
					MessageBox.Show("MUITO RUIM! QUER TENTAR MAIS UMA, CAMPEÃO?");
					
					int pontosM4 = int.Parse(label8.Text);
					label8.Text = pontosM4.ToString();
					label8.Text = "0";
					
					int pontosJ4 = int.Parse(label6.Text);
					label6.Text = pontosJ4.ToString();
					label6.Text = "0";
					
					button1.Enabled = true;
				}
			}
			else
			{
				MessageBox.Show("Hmmmm...não vai ter tanta sorte na próxima!");
				
					int pontosJ = int.Parse(label8.Text);
					pontosJ = pontosJ + 1;
					label8.Text = pontosJ.ToString();
					
					pictureBox6.Load("dado" + ".jpg");
					pictureBox7.Load("dado" + ".jpg");
					
					button2.Enabled = false;
					button1.Enabled = true;
					pictureBox3.Visible = false;
					pictureBox4.Visible = false;
					pictureBox5.Visible = false;
					
					int pontosJ2 = int.Parse(label2.Text);
					label2.Text = pontosJ2.ToString();
					label2.Text = "0";
					
					int pontosM2 = int.Parse(label4.Text);
					label4.Text = pontosM2.ToString();
					label4.Text = "0";
				
				if (pontosJ == 3) 
				{
					MessageBox.Show("Você é muito perspicaz... Mas a próxima é minha!");
					
					int pontosJ3 = int.Parse(label2.Text);
					label2.Text = pontosJ2.ToString();
					label2.Text = "0";
					
					int pontosM3 = int.Parse(label4.Text);
					label4.Text = pontosM2.ToString();
					label4.Text = "0";
					
					int pontosM4 = int.Parse(label8.Text);
					label8.Text = pontosM4.ToString();
					label8.Text = "0";
					
					int pontosJ4 = int.Parse(label6.Text);
					label6.Text = pontosJ4.ToString();
					label6.Text = "0";
					
					button2.Enabled = false;
				}
			}
		}
	}
}
