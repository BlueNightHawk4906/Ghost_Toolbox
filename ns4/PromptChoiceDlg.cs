using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns4
{
	internal sealed class PromptChoiceDlg : Form
	{
		public string string_0;

		public int int_0;

		private IContainer icontainer_0;

		public Label m_Message;

		private Label label1;

		private Button m_OK;

		public ListBox m_Choices;

		public PromptChoiceDlg()
		{
			InitializeComponent();
			int_0 = -1;
		}

		private void PromptChoiceDlg_Load(object sender, EventArgs e)
		{
			Text = string_0;
			Activate();
			BringToFront();
			Focus();
		}

		private void m_Choices_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int_0 = m_Choices.SelectedIndex;
			Close();
		}

		private void m_OK_Click(object sender, EventArgs e)
		{
			int_0 = m_Choices.SelectedIndex;
			Close();
		}

		private void m_Choices_SelectedIndexChanged(object sender, EventArgs e)
		{
			int_0 = m_Choices.SelectedIndex;
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
			label1 = new System.Windows.Forms.Label();
			m_OK = new System.Windows.Forms.Button();
			m_Choices = new System.Windows.Forms.ListBox();
			SuspendLayout();
			m_Message.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			m_Message.Location = new System.Drawing.Point(12, 9);
			m_Message.Name = "m_Message";
			m_Message.Size = new System.Drawing.Size(350, 46);
			m_Message.TabIndex = 0;
			m_Message.Text = "label1";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 61);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(40, 13);
			label1.TabIndex = 1;
			label1.Text = "Select:";
			m_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			m_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			m_OK.Location = new System.Drawing.Point(156, 185);
			m_OK.Name = "m_OK";
			m_OK.Size = new System.Drawing.Size(75, 23);
			m_OK.TabIndex = 3;
			m_OK.Text = "&Ok";
			m_OK.UseVisualStyleBackColor = true;
			m_OK.Click += new System.EventHandler(m_OK_Click);
			m_Choices.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			m_Choices.FormattingEnabled = true;
			m_Choices.Location = new System.Drawing.Point(58, 58);
			m_Choices.Name = "m_Choices";
			m_Choices.Size = new System.Drawing.Size(304, 108);
			m_Choices.TabIndex = 4;
			m_Choices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(m_Choices_MouseDoubleClick);
			m_Choices.SelectedIndexChanged += new System.EventHandler(m_Choices_SelectedIndexChanged);
			base.AcceptButton = m_OK;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(386, 218);
			base.Controls.Add(m_Choices);
			base.Controls.Add(m_OK);
			base.Controls.Add(label1);
			base.Controls.Add(m_Message);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PromptChoiceDlg";
			Text = "PromptChoiceDlg";
			base.Load += new System.EventHandler(PromptChoiceDlg_Load);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
