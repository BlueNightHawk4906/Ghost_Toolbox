using System;
using System.Management.Automation.Host;

namespace ns5
{
	internal sealed class Class23 : PSHostRawUserInterface
	{
		private ConsoleColor consoleColor_0;

		private ConsoleColor consoleColor_1 = ConsoleColor.White;

		private int int_0 = 400;

		private int int_1 = 25;

		ConsoleColor PSHostRawUserInterface.BackgroundColor
		{
			get
			{
				return consoleColor_0;
			}
			set
			{
				consoleColor_0 = value;
			}
		}

		Size PSHostRawUserInterface.BufferSize
		{
			get
			{
				return new Size(int_0, int_1);
			}
			set
			{
				int_0 = value.Width;
				int_1 = value.Height;
			}
		}

		Coordinates PSHostRawUserInterface.CursorPosition
		{
			get
			{
				Coordinates result = default(Coordinates);
				result.X = 0;
				result.Y = 0;
				return result;
			}
			set
			{
			}
		}

		int PSHostRawUserInterface.CursorSize
		{
			get
			{
				return 5;
			}
			set
			{
			}
		}

		ConsoleColor PSHostRawUserInterface.ForegroundColor
		{
			get
			{
				return consoleColor_1;
			}
			set
			{
				consoleColor_1 = value;
			}
		}

		bool PSHostRawUserInterface.KeyAvailable => Console.KeyAvailable;

		Size PSHostRawUserInterface.MaxPhysicalWindowSize => new Size(128, 80);

		Size PSHostRawUserInterface.MaxWindowSize => new Size(128, 80);

		Coordinates PSHostRawUserInterface.WindowPosition
		{
			get
			{
				return new Coordinates(0, 0);
			}
			set
			{
			}
		}

		Size PSHostRawUserInterface.WindowSize
		{
			get
			{
				return new Size(128, 80);
			}
			set
			{
			}
		}

		string PSHostRawUserInterface.WindowTitle
		{
			get
			{
				return "ActiveXPoSH Output";
			}
			set
			{
			}
		}

		void PSHostRawUserInterface.FlushInputBuffer()
		{
		}

		BufferCell[,] PSHostRawUserInterface.GetBufferContents(Rectangle rectangle)
		{
			throw new NotImplementedException("The method or operation is not implemented.");
		}

		KeyInfo PSHostRawUserInterface.ReadKey(ReadKeyOptions options)
		{
			KeyInfo result = default(KeyInfo);
			result.Character = ((options == ReadKeyOptions.NoEcho) ? Console.ReadKey(intercept: false) : Console.ReadKey(intercept: true)).KeyChar;
			return result;
		}

		void PSHostRawUserInterface.ScrollBufferContents(Rectangle source, Coordinates destination, Rectangle clip, BufferCell fill)
		{
		}

		void PSHostRawUserInterface.SetBufferContents(Coordinates origin, BufferCell[,] contents)
		{
		}

		void PSHostRawUserInterface.SetBufferContents(Rectangle rectangle, BufferCell fill)
		{
		}
	}
}
