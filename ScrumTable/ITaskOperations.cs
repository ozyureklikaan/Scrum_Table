using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public interface ITaskOperations
	{
		MyPanel CreateAStory();
		MyPanel createTaskPanelsOfStory(int taskCount, Point loc);
		TextBox createAStoryTextBox();
		MyPanel SearchPanelInList(string btnName);
		
	}
}
