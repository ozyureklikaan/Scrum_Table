using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormScrum : Form
	{
		public FormScrum()
		{
			InitializeComponent();
		}
		
		ScrumTable scrumTable = new ScrumTable();
		public static Point loc = new Point();
		private TextBox transformingTextBox = new TextBox();
		private int createdStoryCount = 0;
		//MyTextBox transformMyTextBoxForContextMenu = new MyTextBox();
		//int addingPersonCount = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void createAStoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			createdStoryCount++;
			loc.X = 10;
			
			MyPanel myPanel = new MyPanel();
			myPanel = scrumTable.CreateAStory();
			panelMain.Controls.Add(myPanel.panel);
			createTaskPanelsOfStory(loc);
			myPanel.panel.Controls.Add(scrumTable.createAStoryTextBox());

			if ((createdStoryCount % 4) == 1)
			{
				Point locForRemove = new Point();
				TableLayoutPanel removeTableLayoutPanel = new TableLayoutPanel();
				removeTableLayoutPanel.Name = "removePanel";
				removeTableLayoutPanel.Size = new Size(115, 115);
				removeTableLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
				locForRemove.X = 1110;
				locForRemove.Y = 76 + (140 * (createdStoryCount - 1));
				removeTableLayoutPanel.Location = locForRemove;
				removeTableLayoutPanel.DragEnter += panel_DragEnter;
				removeTableLayoutPanel.DragDrop += panel_DragDrop;
				removeTableLayoutPanel.AllowDrop = true;
				removeTableLayoutPanel.BackgroundImage = Image.FromFile(@Application.StartupPath + "/trash.png");
				panelMain.Controls.Add(removeTableLayoutPanel);
			}
		}

		public void createTaskPanelsOfStory(Point loc)
		{
			int taskCount = 1;
			for (int i = 0; i < 3; i++)
			{
				MyPanel myPanel = new MyPanel();
				if (i == 0)
				{
					loc.X += 230;
				}
				else
				{
					loc.X += 290;
				}
				myPanel = scrumTable.createTaskPanelsOfStory(taskCount, loc);
				taskCount++;

				myPanel.tableLayoutPanel.Parent = myPanel.panel;
				myPanel.tableLayoutPanel.Name = myPanel.panel.Name;
				myPanel.tableLayoutPanel.AutoSize = true;
				myPanel.tableLayoutPanel.Size = new Size(210, 110);
				myPanel.tableLayoutPanel.ColumnCount = 2;
				myPanel.panel.Controls.Add(myPanel.tableLayoutPanel);

				myPanel.tableLayoutPanel.DragEnter += panel_DragEnter;
				myPanel.tableLayoutPanel.DragDrop += panel_DragDrop;
				myPanel.tableLayoutPanel.AllowDrop = true;

				Button btnAdd = new Button();
				btnAdd.Name = myPanel.panel.Name;
				loc.X += 250;
				btnAdd.Location = loc;
				loc.X -= 250;
				btnAdd.Size = new Size(20, 20);
				btnAdd.Text = "+";
				btnAdd.Click += btnAdd_Click;

				panelMain.Controls.Add(myPanel.panel);
				panelMain.Controls.Add(btnAdd);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			MyPanel myPanel = new MyPanel();
			Button btn = (Button)sender;

			MyTextBox myTextBox = new MyTextBox();
			myTextBox.txtBox.Multiline = true;
			myTextBox.txtBox.Size = new Size(100, 50);
			myTextBox.txtBox.MouseDown += txtBox_MouseDown;
			
			myPanel = scrumTable.SearchPanelInList(btn.Name);

			myPanel.tableLayoutPanel.Controls.Add(myTextBox.txtBox);
		}

		private void panel_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.AllowedEffect;
		}

		private void panel_DragDrop(object sender, DragEventArgs e)
		{
			MyPanel myPanel = new MyPanel();
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
			tableLayoutPanel = (TableLayoutPanel)sender;
			myPanel = scrumTable.SearchPanelInList(tableLayoutPanel.Name);

			myPanel.tableLayoutPanel.Controls.Add(transformingTextBox);
		}

		private void txtBox_MouseDown(object sender, MouseEventArgs e)
		{
			MyTextBox myTextBox = new MyTextBox();
			myTextBox.txtBox = (TextBox)sender;
			if (e.Button == MouseButtons.Left)
			{
				MyPanel myPanel = new MyPanel();
				myPanel.tableLayoutPanel = (TableLayoutPanel)myTextBox.txtBox.Parent;
				myPanel = scrumTable.SearchPanelInList(myPanel.panel.Name);
				transformingTextBox = myTextBox.txtBox;
				myTextBox.txtBox.DoDragDrop(transformingTextBox, DragDropEffects.Move);
			}
			else if (e.Button == MouseButtons.Right)
			{
				myTextBox.txtBox.ContextMenuStrip = createResponsible;
			}
			
		}

		private void addAResponsiblePersonToTaskToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//AddPersontoTask();
		}

		/*public void AddPersontoTask()
		{
			transformMyTextBoxForContextMenu.person.name = "Kaan";
			transformMyTextBoxForContextMenu.txtBox.MouseHover += new System.EventHandler(AddPersontoTask_MouseHover);
		}

		private void AddPersontoTask_MouseHover(object sender, EventArgs e)
		{
			label1.Text = sender.GetType().ToString() + ": MouseHover";
		}*/
	}
}
