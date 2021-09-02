using System;
using System.Collections;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns4;

namespace SAPIENPowerShellWindowsHost
{
	internal sealed class SAPIENHost
	{
		public RichTextBox m_View;

		public MenuStrip m_MenuStrip;

		public ContextMenuStrip m_ContextMenuStrip;

		public Form m_Form;

		private Hashtable Handlers = new Hashtable();

		public EngineIntrinsics _engine_;

		public Runspace m_ScriptRunSpace;

		public string OpenExistingFile(string Title, string InitialDirectory, string Filter, int FilterIndex)
		{
			if (Thread.CurrentThread.GetApartmentState() != 0)
			{
				return "Error: Enable STA mode to use this function";
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = Title;
			openFileDialog.CheckFileExists = true;
			openFileDialog.InitialDirectory = InitialDirectory;
			openFileDialog.Filter = Filter;
			openFileDialog.ShowReadOnly = false;
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Multiselect = false;
			openFileDialog.FilterIndex = FilterIndex;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				return openFileDialog.FileName;
			}
			return null;
		}

		public string[] OpenFiles(string Title, string InitialDirectory, string Filter, int FilterIndex)
		{
			if (Thread.CurrentThread.GetApartmentState() != 0)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = Title;
			openFileDialog.CheckFileExists = true;
			openFileDialog.InitialDirectory = InitialDirectory;
			openFileDialog.Filter = Filter;
			openFileDialog.ShowReadOnly = false;
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Multiselect = true;
			openFileDialog.FilterIndex = FilterIndex;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				return openFileDialog.FileNames;
			}
			return null;
		}

		public string SaveFile(string Title, string InitialDirectory, string DefaultExtension, string Filter, int FilterIndex)
		{
			if (Thread.CurrentThread.GetApartmentState() != 0)
			{
				return "Error: Enable STA mode to use this function";
			}
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = Title;
				saveFileDialog.InitialDirectory = InitialDirectory;
				saveFileDialog.Filter = Filter;
				saveFileDialog.RestoreDirectory = true;
				saveFileDialog.FilterIndex = FilterIndex;
				saveFileDialog.DefaultExt = DefaultExtension;
				saveFileDialog.CheckFileExists = false;
				saveFileDialog.CheckPathExists = false;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					return saveFileDialog.FileName;
				}
				return null;
			}
		}

		public string SelectFolder(string InitialFolder)
		{
			if (Thread.CurrentThread.GetApartmentState() != 0)
			{
				return "Error: Enable STA mode to use this function";
			}
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			if (InitialFolder.Length != 0)
			{
				folderBrowserDialog.SelectedPath = InitialFolder;
			}
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				return folderBrowserDialog.SelectedPath;
			}
			return null;
		}

		public string Prompt(string Title, string Text)
		{
			CPrompt cPrompt = new CPrompt();
			cPrompt.string_0 = Title;
			cPrompt.m_Message.Text = Text;
			if (cPrompt.ShowDialog() == DialogResult.OK)
			{
				return cPrompt.m_Text.Text;
			}
			return null;
		}

		public int SelectFromList(string Caption, string Label, string[] Items)
		{
			int result = -1;
			SelectItem selectItem = new SelectItem();
			selectItem.string_1 = Caption;
			selectItem.string_2 = Label;
			selectItem.string_0 = Items;
			if (selectItem.ShowDialog() == DialogResult.OK)
			{
				result = selectItem.int_0;
			}
			return result;
		}

		public RichTextBox GetTextView()
		{
			return m_View;
		}

		public MenuStrip GetMenuStrip()
		{
			return m_MenuStrip;
		}

		public ContextMenuStrip GetContextMenuStrip()
		{
			return m_ContextMenuStrip;
		}

		public Form GetMainForm()
		{
			return m_Form;
		}

		public void SetMenuHandler(ToolStripMenuItem Item, ScriptBlock PowerShellCode)
		{
			string text = Item.Name;
			if (text.Length == 0)
			{
				text = "m_" + Item.Text;
				text = text.Replace(' ', '_');
				text = text.Replace("&", "");
			}
			Item.Click += ItemClick;
			Handlers.Add(text, PowerShellCode);
		}

		public void SetMenuHandler(ToolStripMenuItem Item, string PowerShellFunction)
		{
			string text = Item.Name;
			if (text.Length == 0)
			{
				text = "m_" + Item.Text;
				text = text.Replace(' ', '_');
				text = text.Replace("&", "");
			}
			Item.Click += ItemClick;
			Handlers.Add(text, PowerShellFunction);
		}

		public void ItemClick(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			if (Handlers[toolStripMenuItem.Name] is ScriptBlock)
			{
				ScriptBlock scriptBlock = (ScriptBlock)Handlers[toolStripMenuItem.Name];
				if (_engine_ != null && scriptBlock != null)
				{
					try
					{
						Runspace.DefaultRunspace = m_ScriptRunSpace;
						scriptBlock.Invoke();
					}
					catch (Exception)
					{
					}
				}
				return;
			}
			string text = (string)Handlers[toolStripMenuItem.Name];
			if (_engine_ != null && text.Length > 0)
			{
				try
				{
					Runspace.DefaultRunspace = m_ScriptRunSpace;
					_engine_.InvokeCommand.NewScriptBlock(text).Invoke();
				}
				catch (Exception)
				{
				}
			}
		}
	}
}
