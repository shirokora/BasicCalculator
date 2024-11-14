using System.Numerics;
using CalculatorPrivateAssembly_;

namespace BasicCalculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void btnCompute_Click(object sender, EventArgs e)
		{
			float first = float.Parse(txtup.Text);
			float second = float.Parse(txtdown.Text);
			float result =0;

			
			if (comboBox1.SelectedItem.ToString() == "+")
			{
				result = CalculatorPrivateAssembly.Addition(first, second);
				listView1.Items.Add("Total:");
				listView1.Items.Add(result.ToString("000000"));
			}
			else if (comboBox1.SelectedItem.ToString() == "-")
			{
				result = CalculatorPrivateAssembly.Subtraction(first, second);
				listView1.Items.Add("Total:");
				listView1.Items.Add(result.ToString("000000"));
			}
			else if (comboBox1.SelectedItem.ToString() == "*")
			{

				result = CalculatorPrivateAssembly.Multiplication(first, second);
				listView1.Items.Add("Total:");
				listView1.Items.Add(result.ToString("000000"));
			}

			else if (comboBox1.SelectedItem.ToString() == "/")
			{
				result = CalculatorPrivateAssembly.Divide(first, second);
				listView1.Items.Add("Total:");
				listView1.Items.Add(result.ToString());
			}


			
			
			
			

		}

		
		
	}
}
