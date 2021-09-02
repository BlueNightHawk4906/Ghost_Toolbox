using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1
{
	internal sealed class Progress : Form
	{
		public string string_0;

		public long long_0;

		private IContainer icontainer_0;

		public Label m_Operation;

		private ProgressBar m_ProgressCtl;

		public Label m_Status;

		public Label m_Remaining;

		public Progress()
		{
			InitializeComponent();
		}

		private void Progress_Load(object sender, EventArgs e)
		{
			Text = string_0;
			m_ProgressCtl.Minimum = 0;
			m_ProgressCtl.Maximum = 100;
		}

		public void method_0(int int_0)
		{
			m_ProgressCtl.Value = int_0;
			m_ProgressCtl.Refresh();
			Application.DoEvents();
			using (Graphics graphics = m_ProgressCtl.CreateGraphics())
			{
				graphics.DrawString(int_0 + "%", SystemFonts.DefaultFont, Brushes.Black, new PointF((float)(m_ProgressCtl.Width / 2) - graphics.MeasureString(int_0 + "%", SystemFonts.DefaultFont).Width / 2f, (float)(m_ProgressCtl.Height / 2) - graphics.MeasureString(int_0 + "%", SystemFonts.DefaultFont).Height / 2f));
			}
			Application.DoEvents();
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
			m_Operation = new System.Windows.Forms.Label();
			m_ProgressCtl = new System.Windows.Forms.ProgressBar();
			m_Status = new System.Windows.Forms.Label();
			m_Remaining = new System.Windows.Forms.Label();
			SuspendLayout();
			m_Operation.Location = new System.Drawing.Point(12, 9);
			m_Operation.Name = "m_Operation";
			m_Operation.Size = new System.Drawing.Size(478, 23);
			m_Operation.TabIndex = 0;
			m_Operation.Text = "label1";
			m_ProgressCtl.Location = new System.Drawing.Point(15, 35);
			m_ProgressCtl.Name = "m_ProgressCtl";
			m_ProgressCtl.Size = new System.Drawing.Size(475, 23);
			m_ProgressCtl.TabIndex = 1;
			m_Status.Location = new System.Drawing.Point(12, 71);
			m_Status.Name = "m_Status";
			m_Status.Size = new System.Drawing.Size(337, 50);
			m_Status.TabIndex = 2;
			m_Status.Text = "label1";
			m_Remaining.Location = new System.Drawing.Point(393, 71);
			m_Remaining.Name = "m_Remaining";
			m_Remaining.Size = new System.Drawing.Size(97, 23);
			m_Remaining.TabIndex = 3;
			m_Remaining.Text = "label1";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(502, 130);
			base.Controls.Add(m_Remaining);
			base.Controls.Add(m_Status);
			base.Controls.Add(m_ProgressCtl);
			base.Controls.Add(m_Operation);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Progress";
			Text = "Progress";
			base.Load += new System.EventHandler(Progress_Load);
			ResumeLayout(false);
		}
	}
}
