namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ListViewItem listViewItem1 = new ListViewItem("Total:");
			ListViewItem listViewItem2 = new ListViewItem("000000");
			btnCompute = new Button();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			txtup = new TextBox();
			txtdown = new TextBox();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// btnCompute
			// 
			btnCompute.Location = new Point(131, 409);
			btnCompute.Name = "btnCompute";
			btnCompute.Size = new Size(141, 42);
			btnCompute.TabIndex = 0;
			btnCompute.Text = "Compute";
			btnCompute.UseVisualStyleBackColor = true;
			btnCompute.Click += btnCompute_Click;
			// 
			// listView1
			// 
			listView1.BackColor = SystemColors.MenuText;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
			listView1.ForeColor = Color.Lime;
			listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
			listView1.Location = new Point(12, 282);
			listView1.Name = "listView1";
			listView1.Size = new Size(387, 121);
			listView1.TabIndex = 1;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.List;
			// 
			// txtup
			// 
			txtup.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtup.Location = new Point(82, 77);
			txtup.Name = "txtup";
			txtup.Size = new Size(250, 43);
			txtup.TabIndex = 2;
			// 
			// txtdown
			// 
			txtdown.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtdown.Location = new Point(82, 208);
			txtdown.Name = "txtdown";
			txtdown.Size = new Size(250, 43);
			txtdown.TabIndex = 2;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
			comboBox1.Location = new Point(159, 154);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(90, 28);
			comboBox1.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(411, 463);
			Controls.Add(comboBox1);
			Controls.Add(txtdown);
			Controls.Add(txtup);
			Controls.Add(listView1);
			Controls.Add(btnCompute);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCompute;
		private ListView listView1;
		private TextBox txtup;
		private TextBox txtdown;
		private ComboBox comboBox1;
		private ColumnHeader columnHeader1;
	}
}
