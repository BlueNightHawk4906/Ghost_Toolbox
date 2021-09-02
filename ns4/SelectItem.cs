using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns4
{
	[ComVisible(false)]
	internal sealed class SelectItem : Form
	{
		public string[] string_0;

		public string string_1;

		public string string_2;

		public int int_0 = -1;

		private IContainer icontainer_0;

		private Label Label;

		private ListBox m_Items;

		private Button OKButton;

		private new Button CancelButton;

		public SelectItem()
		{
			InitializeComponent();
		}

		private void m_Items_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (m_Items.SelectedIndex == -1)
			{
				OKButton.Enabled = false;
			}
			else
			{
				OKButton.Enabled = true;
			}
		}

		private void SelectItem_Load(object sender, EventArgs e)
		{
			OKButton.Enabled = false;
			ListBox.ObjectCollection items = m_Items.Items;
			object[] items2 = string_0;
			items.AddRange(items2);
			Text = string_1;
			Label.Text = string_2;
			Activate();
			BringToFront();
			Focus();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			int_0 = m_Items.SelectedIndex;
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
			Label = new System.Windows.Forms.Label();
			m_Items = new System.Windows.Forms.ListBox();
			OKButton = new System.Windows.Forms.Button();
			CancelButton = new System.Windows.Forms.Button();
			SuspendLayout();
			Label.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			Label.Location = new System.Drawing.Point(13, 13);
			Label.Name = "Label";
			Label.Size = new System.Drawing.Size(668, 23);
			Label.TabIndex = 0;
			Label.Text = "Label";
			m_Items.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			m_Items.FormattingEnabled = true;
			m_Items.ItemHeight = 24;
			m_Items.Location = new System.Drawing.Point(12, 51);
			m_Items.Name = "m_Items";
			m_Items.Size = new System.Drawing.Size(669, 244);
			m_Items.TabIndex = 1;
			m_Items.SelectedIndexChanged += new System.EventHandler(m_Items_SelectedIndexChanged);
			OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			OKButton.Location = new System.Drawing.Point(177, 320);
			OKButton.Name = "OKButton";
			OKButton.Size = new System.Drawing.Size(139, 39);
			OKButton.TabIndex = 2;
			OKButton.Text = "Ok";
			OKButton.UseVisualStyleBackColor = true;
			OKButton.Click += new System.EventHandler(OKButton_Click);
			CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			CancelButton.Location = new System.Drawing.Point(377, 320);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new System.Drawing.Size(139, 39);
			CancelButton.TabIndex = 3;
			CancelButton.Text = "Cancel";
			CancelButton.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(11f, 24f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(693, 371);
			base.Controls.Add(CancelButton);
			base.Controls.Add(OKButton);
			base.Controls.Add(m_Items);
			base.Controls.Add(Label);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "SelectItem";
			Text = "SelectItem";
			base.Load += new System.EventHandler(SelectItem_Load);
			ResumeLayout(false);
		}
	}
}
