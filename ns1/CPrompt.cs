using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1
{
	internal sealed class CPrompt : Form
	{
		public string string_0;

		public bool bool_0;

		private IContainer icontainer_0;

		public Label m_Message;

		public TextBox m_Text;

		private Button m_OK;

		public Label m_Field;

		public CPrompt()
		{
			InitializeComponent();
		}

		private void m_Text_TextChanged(object sender, EventArgs e)
		{
		}

		private void CPrompt_Load(object sender, EventArgs e)
		{
			Text = string_0;
			if (bool_0)
			{
				m_Text.UseSystemPasswordChar = true;
			}
			Activate();
			BringToFront();
			Focus();
		}

		private void m_OK_Click(object sender, EventArgs e)
		{
			Close();
		}

		void Form.Dispose(bool disposing)
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
			Dispose(disposing);
		}

		private void InitializeComponent()
		{
			m_Message = new System.Windows.Forms.Label();
			m_Text = new System.Windows.Forms.TextBox();
			m_OK = new System.Windows.Forms.Button();
			m_Field = new System.Windows.Forms.Label();
			SuspendLayout();
			m_Message.Location = new System.Drawing.Point(12, 9);
			m_Message.Name = "m_Message";
			m_Message.Size = new System.Drawing.Size(473, 23);
			m_Message.TabIndex = 0;
			m_Message.Text = "label1";
			m_Text.Location = new System.Drawing.Point(15, 53);
			m_Text.Name = "m_Text";
			m_Text.Size = new System.Drawing.Size(470, 20);
			m_Text.TabIndex = 1;
			m_Text.TextChanged += new System.EventHandler(m_Text_TextChanged);
			m_OK.Location = new System.Drawing.Point(211, 87);
			m_OK.Name = "m_OK";
			m_OK.Size = new System.Drawing.Size(75, 23);
			m_OK.TabIndex = 2;
			m_OK.Text = "&Ok";
			m_OK.UseVisualStyleBackColor = true;
			m_OK.Click += new System.EventHandler(m_OK_Click);
			m_Field.Location = new System.Drawing.Point(12, 33);
			m_Field.Name = "m_Field";
			m_Field.Size = new System.Drawing.Size(473, 17);
			m_Field.TabIndex = 3;
			m_Field.Text = "label1";
			base.AcceptButton = m_OK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(497, 123);
			base.Controls.Add(m_Field);
			base.Controls.Add(m_OK);
			base.Controls.Add(m_Text);
			base.Controls.Add(m_Message);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CPrompt";
			Text = "Prompt";
			base.Load += new System.EventHandler(CPrompt_Load);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
