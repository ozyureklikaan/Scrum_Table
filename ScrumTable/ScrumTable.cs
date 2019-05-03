using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class ScrumTable : ITaskOperations
	{
		private List<MyPanel> Panels = new List<MyPanel>();
		private int storyCount = 1;

		public MyPanel CreateAStory()
		{
			MyPanel myPanel = new MyPanel();
			if (storyCount == 1)
			{
				FormScrum.loc.Y = 76;
				myPanel.panel.Name = "Story" + storyCount;
				myPanel.panel.Location = FormScrum.loc;
				myPanel.panel.Size = new Size(205, 115);
				myPanel.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				Panels.Add(myPanel);
			}
			else
			{
				FormScrum.loc.Y = 76 + (140 * (storyCount - 1));
				myPanel.panel.Name = "Story" + storyCount;
				myPanel.panel.Location = FormScrum.loc;
				myPanel.panel.Size = new Size(205, 115);
				myPanel.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				Panels.Add(myPanel);
			}
			return myPanel;
		}

		public MyPanel createTaskPanelsOfStory(int taskCount, Point loc)
		{
			MyPanel myPanel = new MyPanel();
			myPanel.panel.Name = "task" + taskCount + "ofstory" + storyCount; //taskCount = 1 NotStarted, taskCount = 2 In Progress, taskCount = 3 Done.
			myPanel.panel.Location = loc;
			myPanel.panel.AutoSize = false;
			myPanel.panel.Size = new Size(235, 115);
			myPanel.panel.AutoScroll = true;
			myPanel.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			Panels.Add(myPanel);
			return myPanel;
		}

		public TextBox createAStoryTextBox()
		{
			TextBox txtBox = new TextBox();
			txtBox.Name = "story" + storyCount++;
			txtBox.Multiline = true;
			txtBox.Size = new Size(205, 115);
			return txtBox;
		}

		public MyPanel SearchPanelInList(string btnName)
		{
			MyPanel myPanel = new MyPanel();
			foreach (MyPanel item in Panels)
			{
				if (item.panel.Name == btnName)
				{
					myPanel = item;
					break;
				}
			}
			return myPanel;
		}
	}
}
