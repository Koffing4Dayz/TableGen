using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace TableGenerator
{
    public partial class TableGen : Form
    {
        public int waveCount = 0;
        public string basePath = "";
        public bool conected = false;
        private int cellSize = 11;

        public TableGen()
        {
            InitializeComponent();
            Heads.SelectedIndex = 0;
            Bodys.SelectedIndex = 0;
            Legs.SelectedIndex = 0;
            FillTable(25, 25);
        }

        public TableGen(string arg)
        {
            InitializeComponent();
            Heads.SelectedIndex = 0;
            Bodys.SelectedIndex = 0;
            Legs.SelectedIndex = 0;
            basePath = arg;
            FillTable(25, 25);
            FillBoxes();
        }

        public TableGen(string arg1, string arg2)
        {
            InitializeComponent();
            Heads.SelectedIndex = 0;
            Bodys.SelectedIndex = 0;
            Legs.SelectedIndex = 0;
            basePath = arg1;
            FillBoxes();
            FillTable(25, 25);
            LoadFile(arg1 + "\\Project\\Assets\\Resources\\XML\\SpawnTables\\" + arg2);
            FilenameText.Text = arg2.Remove(arg2.Length - 4, 4);
        }

        private void FillTable(int columns, int rows)
        {
            Button button;

            gridPanel.ColumnCount = columns;
            gridPanel.RowCount = rows;

            gridPanel.Width = columns * cellSize;
            gridPanel.Height = rows * cellSize;

            gridPanel.ColumnStyles[0].SizeType = SizeType.Absolute;
            gridPanel.ColumnStyles[0].Width = cellSize;
            gridPanel.RowStyles[0].SizeType = SizeType.Absolute;
            gridPanel.RowStyles[0].Height = cellSize;

            for (int i = 1; i < columns; i++)
            {
                gridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellSize));
            }
            for (int i = 1; i < rows; i++)
            {
                gridPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, cellSize));
            }
            
            int width = gridPanel.Width;
            int height = gridPanel.Height;
            width = width / columns;
            height = height / rows;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (j % 2 == 1 && i % 2 == 1)
                        continue;

                    button = new Button();
                    button.Visible = true;
                    button.Dock = DockStyle.Fill;
                    button.Margin = new Padding(0);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;

                    if (j % 2 == 0 && i % 2 == 0)
                    {
                        button.ForeColor = Color.Black;
                        button.MouseDown += new MouseEventHandler(OnClickRoom);
                    }
                    else
                    {
                        button.Click += new EventHandler(OnClickHall);
                        button.ForeColor = BackColor;
                    }

                    gridPanel.Controls.Add(button, i, j);
                }
            }

            ColUpDown.Value = columns;
            RowUpDown.Value = rows;

            roomTree.Nodes.Add("Purple");
            roomTree.Nodes.Add("Blue");
            roomTree.Nodes.Add("Cyan");
            roomTree.Nodes.Add("Green");
            roomTree.Nodes.Add("Yellow");
            roomTree.Nodes.Add("Orange");
            roomTree.Nodes.Add("Red");
            roomTree.Nodes.Add("Magenta");
        }

        private void OnClickRoom(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            if (e.Button == MouseButtons.Right)
                button.BackColor = Color.Transparent;
            else if (button.BackColor == Color.Transparent)
                button.BackColor = Color.Purple;
            else if (button.BackColor == Color.Purple)
                button.BackColor = Color.Blue;
            else if (button.BackColor == Color.Blue)
                button.BackColor = Color.Cyan;
            else if (button.BackColor == Color.Cyan)
                button.BackColor = Color.Green;
            else if (button.BackColor == Color.Green)
                button.BackColor = Color.Yellow;
            else if (button.BackColor == Color.Yellow)
                button.BackColor = Color.Orange;
            else if (button.BackColor == Color.Orange)
                button.BackColor = Color.Red;
            else if (button.BackColor == Color.Red)
                button.BackColor = Color.Magenta;
            else if (button.BackColor == Color.Magenta)
                button.BackColor = Color.Transparent;

            if (autoConCheck.Checked)
            {
                int column = gridPanel.GetColumn(button);
                int row = gridPanel.GetRow(button);
                int columnCount = gridPanel.ColumnCount - 1;
                int rowCount = gridPanel.RowCount - 1;
                Button hall;
                Button neighbor;

                if (button.BackColor == Color.Purple)
                {
                    if (column > 0)
                    {
                        neighbor = gridPanel.GetControlFromPosition(column - 2, row) as Button;
                        if(neighbor.BackColor != Color.Transparent)
                        {
                            hall = gridPanel.GetControlFromPosition(column - 1, row) as Button;
                            hall.BackColor = Color.Gray;
                            hall.FlatAppearance.MouseDownBackColor = Color.Gray;
                            hall.FlatAppearance.MouseOverBackColor = Color.Gray;
                        }
                    }
                    if (column < columnCount)
                    {
                        neighbor = gridPanel.GetControlFromPosition(column + 2, row) as Button;
                        if (neighbor.BackColor != Color.Transparent)
                        {
                            hall = gridPanel.GetControlFromPosition(column + 1, row) as Button;
                            hall.BackColor = Color.Gray;
                            hall.FlatAppearance.MouseDownBackColor = Color.Gray;
                            hall.FlatAppearance.MouseOverBackColor = Color.Gray;
                        }
                    }
                    if (row > 0)
                    {
                        neighbor = gridPanel.GetControlFromPosition(column, row - 2) as Button;
                        if (neighbor.BackColor != Color.Transparent)
                        {
                            hall = gridPanel.GetControlFromPosition(column, row - 1) as Button;
                            hall.BackColor = Color.Gray;
                            hall.FlatAppearance.MouseDownBackColor = Color.Gray;
                            hall.FlatAppearance.MouseOverBackColor = Color.Gray;
                        }
                    }
                    if (row < rowCount)
                    {
                        neighbor = gridPanel.GetControlFromPosition(column, row + 2) as Button;
                        if (neighbor.BackColor != Color.Transparent)
                        {
                            hall = gridPanel.GetControlFromPosition(column, row + 1) as Button;
                            hall.BackColor = Color.Gray;
                            hall.FlatAppearance.MouseDownBackColor = Color.Gray;
                            hall.FlatAppearance.MouseOverBackColor = Color.Gray;
                        }
                    }
                }
                else if(button.BackColor == Color.Transparent)
                {
                    if (column > 0)
                    {
                        hall = gridPanel.GetControlFromPosition(column - 1, row) as Button;
                        hall.BackColor = Color.Transparent;
                        hall.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        hall.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    if (column < columnCount)
                    {
                        hall = gridPanel.GetControlFromPosition(column + 1, row) as Button;
                        hall.BackColor = Color.Transparent;
                        hall.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        hall.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    if (row > 0)
                    {
                        hall = gridPanel.GetControlFromPosition(column, row - 1) as Button;
                        hall.BackColor = Color.Transparent;
                        hall.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        hall.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    if (row < rowCount)
                    {
                        hall = gridPanel.GetControlFromPosition(column, row + 1) as Button;
                        hall.BackColor = Color.Transparent;
                        hall.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        hall.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                }
            }

            button.FlatAppearance.MouseDownBackColor = button.BackColor;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            popLabel.Focus();
        }

        private void OnClickHall(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.BackColor == Color.Gray)
                button.BackColor = Color.Transparent;
            else
                button.BackColor = Color.Gray;

            button.FlatAppearance.MouseDownBackColor = button.BackColor;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            popLabel.Focus();
        }

        private void FillBoxes()
        {
            string reasourcePath = basePath + "\\Project\\Assets\\Resources";
            string scenePath = basePath + "\\Project\\Assets\\Scenes";

            if (Directory.Exists(reasourcePath))
            {
                conected = true;
                
                string[] heads = Directory.GetFiles(reasourcePath + "\\Head");
                string[] bodys = Directory.GetFiles(reasourcePath + "\\Body");
                string[] legs = Directory.GetFiles(reasourcePath + "\\Legs");

                Heads.Items.Clear();
                Bodys.Items.Clear();
                Legs.Items.Clear();

                Heads.Items.Add("?");
                Bodys.Items.Add("?");
                Legs.Items.Add("?");

                foreach (string thing in heads)
                {
                    if (!thing.Contains(".meta"))
                    {
                        string temp = thing.Remove(thing.Length - 7, 7);
                        Heads.Items.Add(temp.Remove(0, reasourcePath.Length + 6));
                    }
                }

                foreach (string thing in bodys)
                {
                    if (!thing.Contains(".meta"))
                    {
                        string temp = thing.Remove(thing.Length - 7, 7);
                        Bodys.Items.Add(temp.Remove(0, reasourcePath.Length + 6));
                    }
                }

                foreach (string thing in legs)
                {
                    if (!thing.Contains(".meta"))
                    {
                        string temp = thing.Remove(thing.Length - 7, 7);
                        Legs.Items.Add(temp.Remove(0, reasourcePath.Length + 6));
                    }
                }

                Heads.SelectedIndex = 0;
                Bodys.SelectedIndex = 0;
                Legs.SelectedIndex = 0;

                Rooms.Items.Clear();

                List<string> rooms = new List<string>(Directory.EnumerateFiles(scenePath));
                List<string> dirs = new List<string>(Directory.EnumerateDirectories(scenePath));

                for (int i = 0; i < dirs.Count; i++)
                {
                    rooms.AddRange(Directory.EnumerateFiles(dirs[i]));
                    dirs.AddRange(Directory.EnumerateDirectories(dirs[i]));
                }

                for (int i = 0; i < rooms.Count; i++)
                {
                    if (!rooms[i].Contains(".meta"))
                    {
                        Rooms.Items.Add(Path.GetFileNameWithoutExtension(rooms[i]));
                    }
                }

                SpawnTables.Items.Clear();

                string[] spawns = Directory.GetFiles(reasourcePath + "\\XML\\SpawnTables");

                foreach (string thing in spawns)
                {
                    if (!thing.Contains(".meta"))
                    {
                        SpawnTables.Items.Add(Path.GetFileNameWithoutExtension(thing));
                    }
                }
            }
            else
            {
                //no
                MessageBox.Show( reasourcePath, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                conected = true;
                basePath = folderBrowserDialog1.SelectedPath;
                FillBoxes();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ProbUpDown.Value = ProbabilityBar.Value;
        }

        private void AddWaveBtn_Click(object sender, EventArgs e)
        {
            waveCount++;
            enemyTree.BeginUpdate();
            enemyTree.Nodes.Add("Wave" + waveCount + " <Channel:0> <Count:0>");
            enemyTree.EndUpdate();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (enemyTree.SelectedNode == null)
            {
                MessageBox.Show("Select a item to remove", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (enemyTree.SelectedNode.Parent == null)
            {
                enemyTree.BeginUpdate();
                enemyTree.SelectedNode.Remove();
                int count = enemyTree.Nodes.Count;
                for (int i = 0; i < count; i++)
                {
                    enemyTree.Nodes[i].Text = "Wave" + (i + 1).ToString();
                }
                enemyTree.EndUpdate();

                waveCount--;
            }
            else if (enemyTree.SelectedNode.Parent != null)
            {
                enemyTree.BeginUpdate();
                enemyTree.SelectedNode.Remove();
                enemyTree.EndUpdate();
            }
        }

        private void AddEnemyBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;
            int prob = Convert.ToInt32(ProbUpDown.Value);
            string message = "Please enter the following:";

            if (enemyTree.SelectedNode == null || enemyTree.SelectedNode.Parent != null)
            {
                valid = false;
                message += "\n - Select a Wave";
            }
            if (Heads.SelectedIndex < 0)
            {
                valid = false;
                message += "\n - Select a Head";
            }
            if (Bodys.SelectedIndex < 0)
            {
                valid = false;
                message += "\n - Select a Body";
            }
            if (Legs.SelectedIndex < 0)
            {
                valid = false;
                message += "\n - Select a Legs";
            }
            if (prob > 100 || prob <= 0)
            {
                valid = false;
                message += "\n - Select a probability between 0 - 100";
            }

            if (valid)
            {
                string input = Heads.Text + "/" + Bodys.Text + "/" + Legs.Text + "/" + ProbUpDown.Value.ToString();
                enemyTree.BeginUpdate();
                enemyTree.Nodes[enemyTree.SelectedNode.Index].Nodes.Add(input);
                enemyTree.Nodes[enemyTree.SelectedNode.Index].Expand();
                enemyTree.EndUpdate();
            }
            else
            {
                MessageBox.Show(message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (enemyTree.SelectedNode == null)
            {
                MessageBox.Show("Select a item to move", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (enemyTree.SelectedNode.Index == 0)
            {
                //MessageBox.Show("Cannot move up", "Error",
                //    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (enemyTree.SelectedNode.Parent == null)
            {
                TreeNode temp = enemyTree.SelectedNode;
                enemyTree.SelectedNode.Remove();
                enemyTree.Nodes.Insert(temp.Index - 1, temp);
                enemyTree.SelectedNode = temp;

                int count = enemyTree.Nodes.Count;
                for (int i = 0; i < count; i++)
                {
                    enemyTree.Nodes[i].Text = "Wave" + (i + 1).ToString();
                }
            }
            else if (enemyTree.SelectedNode.Parent != null)
            {
                TreeNode temp = enemyTree.SelectedNode;
                enemyTree.SelectedNode.Remove();
                enemyTree.SelectedNode.Parent.Nodes.Insert(temp.Index - 1, temp);
                enemyTree.SelectedNode = temp;
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (enemyTree.SelectedNode == null)
            {
                MessageBox.Show("Select a item to move", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (enemyTree.SelectedNode.Parent == null && enemyTree.SelectedNode.Index < enemyTree.Nodes.Count)
            {
                TreeNode temp = enemyTree.SelectedNode;
                enemyTree.SelectedNode.Remove();
                enemyTree.Nodes.Insert(temp.Index + 1, temp);
                enemyTree.SelectedNode = temp;

                int count = enemyTree.Nodes.Count;
                for (int i = 0; i < count; i++)
                {
                    enemyTree.Nodes[i].Text = "Wave" + (i + 1).ToString();
                }
            }
            else if (enemyTree.SelectedNode.Parent != null && enemyTree.SelectedNode.Index < enemyTree.SelectedNode.Parent.Nodes.Count - 1)
            {
                TreeNode temp = enemyTree.SelectedNode;
                enemyTree.SelectedNode.Remove();
                enemyTree.SelectedNode.Parent.Nodes.Insert(temp.Index + 1, temp);
                enemyTree.SelectedNode = temp;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void roomProbUpDown_ValueChanged(object sender, EventArgs e)
        {
            roomProbBar.Value = (int)roomProbUpDown.Value;
        }

        private void roomProbBar_Scroll(object sender, EventArgs e)
        {
            roomProbUpDown.Value = roomProbBar.Value;
        }

        private void ProbUpDown_ValueChanged(object sender, EventArgs e)
        {
            ProbabilityBar.Value = (int)ProbUpDown.Value;
        }

        private void popUpDown_ValueChanged(object sender, EventArgs e)
        {
            popBar.Value = (int)popUpDown.Value;
        }

        private void popBar_Scroll(object sender, EventArgs e)
        {
            popUpDown.Value = popBar.Value;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            bool control = true;
            string filename = FilenameText.Text;

            if (!conected)
            {
                MessageBox.Show("Must conect to the project", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                control = false;
            }
            else if (filename == "")
            {
                MessageBox.Show("Please enter a filename", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                control = false;
            }
            else if (filename.Contains(" ") || filename.Contains("."))
            {
                MessageBox.Show("Filename can not contain spaces or periods", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                control = false;
            }
            else
            {
                string thisPath = "";
                if (Tabs.SelectedTab.Text == "Enemy")
                    thisPath = basePath + "\\Project\\Assets\\Resources\\XML\\SpawnTables";
                else if(Tabs.SelectedTab.Text == "Rooms")
                    thisPath = basePath + "\\Project\\Assets\\Resources\\XML\\ArenaTables";

                string[] files = System.IO.Directory.GetFiles(thisPath);
                filename = thisPath + "\\" + filename + ".xml";

                foreach (string thing in files)
                {
                    if (thing == filename)
                    {
                        DialogResult dialogResult = MessageBox.Show("File already exists. Do you want to replace?", "Question", MessageBoxButtons.YesNo);
                        control = (dialogResult == DialogResult.Yes);
                    }
                }
            }

            if(control)
            {
                if (Tabs.SelectedTab.Text == "Enemy")
                {
                    using (XmlWriter writer = XmlWriter.Create(filename))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("SpawnTable");             //SpawnTable

                        foreach (TreeNode parent in enemyTree.Nodes)
                        {
                            writer.WriteStartElement("Wave");          //Waves
                            string[] sep = new string[] { " ", "<", ":", ">" };
                            string[] result = parent.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                            writer.WriteAttributeString("Num", result[0].Remove(0, 4));
                            writer.WriteAttributeString(result[1], result[2]);
                            writer.WriteAttributeString(result[3], result[4]);

                            int eCount = 1;
                            foreach (TreeNode child in parent.Nodes)
                            {
                                string[] temp = new string[4];
                                int index = 0;
                                writer.WriteStartElement("Enemy");  //Enemy
                                writer.WriteAttributeString("Num", eCount.ToString());

                                foreach (char letter in child.Text)
                                {
                                    if (letter == '/')
                                        index++;
                                    else
                                        temp[index] += letter;
                                }

                                writer.WriteElementString("Head", temp[0]); //Head
                                writer.WriteElementString("Body", temp[1]); //Body
                                writer.WriteElementString("Legs", temp[2]); //Legs
                                writer.WriteElementString("Prob", temp[3]); //Prob

                                writer.WriteEndElement();                   //Enemy
                                eCount++;
                            }

                            writer.WriteEndElement();                       //Waves
                        }

                        writer.WriteEndElement();                           //SpawnTable
                        writer.WriteEndDocument();

                        MessageBox.Show("Table exported to Xml file", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else if (Tabs.SelectedTab.Text == "Rooms")
                {
                    using (XmlWriter writer = XmlWriter.Create(filename))
                    {
                        int top = gridPanel.RowCount, bot = -1, left = gridPanel.RowCount, right = -1;

                        foreach (Button item in gridPanel.Controls)
                        {
                            int x = gridPanel.GetRow(item);
                            int y = gridPanel.GetColumn(item);

                            if (item.BackColor != Color.Transparent && item.BackColor != Color.Gray)
                            {
                                if (top > x) top = x;
                                if (bot < x) bot = x;
                                if (left > y) left = y;
                                if (right < y) right = y;
                            }
                        }

                        if (top > bot || left > right)
                        {
                            MessageBox.Show("You done fucked up", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }

                        string start = "";
                        foreach (TreeNode item in roomTree.Nodes)
                            if (item.Text.Contains("*S"))
                                start = item.Text.Remove(item.Text.Length - 16, 16);

                        if (start == "")
                        {
                            MessageBox.Show("Plese set a starting room", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }

                        int startIndex = -2;

                        foreach (Button item in gridPanel.Controls)
                        {
                            if (item.BackColor != Color.Transparent && item.BackColor != Color.Gray)
                            {
                                string color = item.BackColor.ToString();
                                color = color.Remove(0, 7);
                                color = color.Remove(color.Length - 1, 1);
                                if (color == start)
                                    startIndex = -1;
                            }
                        }

                        if (startIndex == -2)
                        {
                            MessageBox.Show("Plese add a starting room", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }

                        int[,] indexLookup = new int[((bot - top) / 2)+1, ((right - left) / 2)+1];
                        int count = 0;
                        for (int i = 0, x = 0; i <= bot - top; i = i + 2, x++)
                        {
                            for (int j = 0, y = 0; j <= right-left; j = j + 2, y++)
                            {
                                indexLookup[x, y] = -1;
                                Button temp = gridPanel.GetControlFromPosition(j + left, i + top) as Button;
                                if (temp.BackColor != Color.Transparent)
                                {
                                    indexLookup[x, y] = count;
                                    count++;
                                }
                            }
                        }

                        int length = gridPanel.ColumnCount - 1;
                        int height = gridPanel.RowCount - 1;

                        writer.WriteStartDocument();
                        writer.WriteStartElement("Arena");       //Arena
                        writer.WriteStartElement("Rooms");       //Rooms
                        writer.WriteAttributeString("count", count.ToString());
                        count = 0;

                        for (int x = 0; x <= bot - top; x = x + 2)
                        {
                            for (int y = 0; y <= right - left; y = y + 2)
                            {
                                int xReal = x + top;
                                int yReal = y + left;

                                Button temp = gridPanel.GetControlFromPosition(yReal, xReal) as Button;
                                if(temp.BackColor != Color.Transparent)
                                {
                                    writer.WriteStartElement("Room");   //Room
                                    writer.WriteAttributeString("index", count.ToString());

                                    bool north = false, south = false, east = false, west = false;
                                    Button neighbor;

                                    int tempColumn = gridPanel.GetColumn(temp);
                                    int tempRow = gridPanel.GetRow(temp);

                                    if (tempColumn > 0)
                                    {
                                        neighbor = gridPanel.GetControlFromPosition(tempColumn - 1, tempRow) as Button;
                                        west = (neighbor.BackColor == Color.Gray &&
                                                (x / 2) >= 0 && (x / 2) < indexLookup.GetLength(0) &&
                                                (y / 2) - 1 >= 0 && (y / 2) - 1 < indexLookup.GetLength(1));
                                    }
                                    if (tempColumn < height)
                                    {
                                        neighbor = gridPanel.GetControlFromPosition(tempColumn + 1, tempRow) as Button;
                                        east = (neighbor.BackColor == Color.Gray &&
                                                (x / 2) >= 0 && (x / 2) < indexLookup.GetLength(0) &&
                                                (y / 2) + 1 >= 0 && (y / 2) + 1 < indexLookup.GetLength(1));
                                    }
                                    if (tempRow > 0)
                                    {
                                        neighbor = gridPanel.GetControlFromPosition(tempColumn, tempRow - 1) as Button;
                                        north = (neighbor.BackColor == Color.Gray &&
                                                (x / 2) - 1 >= 0 && (x / 2) - 1 < indexLookup.GetLength(0) &&
                                                (y / 2) >= 0 && (y / 2) < indexLookup.GetLength(1));
                                    }
                                    if (tempRow < length)
                                    {
                                        neighbor = gridPanel.GetControlFromPosition(tempColumn, tempRow + 1) as Button;
                                        south = (neighbor.BackColor == Color.Gray &&
                                                (x / 2) + 1 >= 0 && (x / 2) + 1 < indexLookup.GetLength(0) &&
                                                (y / 2) >= 0 && (y / 2) < indexLookup.GetLength(1));
                                    }

                                    string color = temp.BackColor.ToString();
                                    color = color.Remove(0, 7);
                                    color = color.Remove(color.Length - 1, 1);

                                    if (startIndex == -1)
                                        if (color == start)
                                            startIndex = count;

                                    writer.WriteElementString("Y", (x * .5).ToString());
                                    writer.WriteElementString("X", (y * .5).ToString());
                                    writer.WriteElementString("Table", color);
                                    if(north)
                                        writer.WriteElementString("North", indexLookup[(x / 2) - 1, (y / 2)].ToString());
                                    else
                                        writer.WriteElementString("North", "-1");

                                    if (south)
                                        writer.WriteElementString("South", indexLookup[(x / 2) + 1, (y / 2)].ToString());
                                    else
                                        writer.WriteElementString("South", "-1");

                                    if (east)
                                        writer.WriteElementString("East", indexLookup[(x / 2), (y / 2) + 1].ToString());
                                    else
                                        writer.WriteElementString("East", "-1");

                                    if (west)
                                        writer.WriteElementString("West", indexLookup[(x / 2), (y / 2) - 1].ToString());
                                    else
                                        writer.WriteElementString("West", "-1");

                                    writer.WriteEndElement();           //Room
                                    count++;
                                }
                            }
                        }
                        writer.WriteEndElement();                //Rooms

                        writer.WriteStartElement("Start");      //Start
                        writer.WriteElementString("Index", startIndex.ToString());
                        writer.WriteEndElement();               //Start

                        writer.WriteStartElement("Tables");      //Tables

                        foreach (TreeNode item in roomTree.Nodes)
                        {
                            string tableColor = item.Text;
                            if (tableColor.Contains("*S"))
                                tableColor = tableColor.Remove(item.Text.Length - 16, 16);

                            writer.WriteStartElement(tableColor);   //Color

                            foreach (TreeNode child in item.Nodes)
                            {
                                string[] temp = new string[4];
                                int index = 0;
                                writer.WriteStartElement("Layout");  //Layout

                                foreach (char letter in child.Text)
                                {
                                    if (letter == '/')
                                        index++;
                                    else
                                        temp[index] += letter;
                                }

                                writer.WriteElementString("Scene", temp[0]);
                                writer.WriteElementString("Spawn", temp[1]);
                                writer.WriteElementString("Pop"  , temp[2]);
                                writer.WriteElementString("Prob" , temp[3]);

                                writer.WriteEndElement();             //Layout
                            }

                            writer.WriteEndElement();               //Color
                        }

                        writer.WriteEndElement();               //Tables

                        writer.WriteEndElement();           //Arena
                        writer.WriteEndDocument();

                        MessageBox.Show("Table exported to Xml file", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void DropUpDown_ValueChanged(object sender, EventArgs e)
        {
            ChanBar.Value = (int)ChanUpDown.Value;
        }

        private void DropBar_Scroll(object sender, EventArgs e)
        {
            ChanUpDown.Value = ChanBar.Value;
        }

        private void LoadFile(string filename)
        {
            if (!filename.Contains(".meta") && filename.Contains(".xml"))
            {
                XmlDocument loader = new XmlDocument();
                loader.Load(filename);

                if (loader.ChildNodes[1].Name == "SpawnTable")
                {
                    waveCount = 0;
                    enemyTree.Nodes.Clear();

                    XmlNode table = loader.ChildNodes[1];

                    foreach (XmlNode parent in table)
                    {
                        string chan = " <" + parent.Attributes[1].Name + ":" + parent.Attributes[1].Value + ">";
                        string count = " <" + parent.Attributes[2].Name + ":" + parent.Attributes[2].Value + ">";
                        waveCount++;
                        enemyTree.BeginUpdate();
                        enemyTree.Nodes.Add("Wave" + waveCount + chan + count);
                        enemyTree.EndUpdate();

                        foreach (XmlNode child in parent)
                        {
                            string temp = "";

                            temp += child.SelectSingleNode("Head").InnerText + "/";
                            temp += child.SelectSingleNode("Body").InnerText + "/";
                            temp += child.SelectSingleNode("Legs").InnerText + "/";
                            temp += child.SelectSingleNode("Prob").InnerText;

                            enemyTree.BeginUpdate();
                            enemyTree.Nodes[waveCount - 1].Nodes.Add(temp);
                            enemyTree.EndUpdate();
                        }

                        enemyTree.Nodes[waveCount - 1].Expand();
                    }

                    Tabs.SelectTab(0);
                }
                else if (loader.ChildNodes[1].Name == "Arena")
                {
                    XmlNode rooms = loader.ChildNodes[1].ChildNodes[0];
                    XmlNode start = loader.ChildNodes[1].ChildNodes[1];
                    XmlNode table = loader.ChildNodes[1].ChildNodes[2];

                    foreach (TreeNode item in roomTree.Nodes)
                    {
                        if (item.Text.Contains("*S"))
                            item.Text = item.Text.Remove(item.Text.Length - 16, 16);
                        item.Nodes.Clear();
                    }

                    foreach (Button item in gridPanel.Controls)
                    {
                        item.BackColor = Color.Transparent;
                        item.FlatAppearance.MouseDownBackColor = item.BackColor;
                        item.FlatAppearance.MouseOverBackColor = item.BackColor;
                        popLabel.Focus();
                    }

                    string startIndex = start.ChildNodes[0].InnerText;

                    foreach (XmlNode room in rooms.ChildNodes)
                    {
                        string index = room.Attributes["index"].Value;
                        int y = Convert.ToInt32(room.ChildNodes[0].InnerText);
                        int x = Convert.ToInt32(room.ChildNodes[1].InnerText);
                        string color = room.ChildNodes[2].InnerText;
                        int north = Convert.ToInt32(room.ChildNodes[3].InnerText);
                        int south = Convert.ToInt32(room.ChildNodes[4].InnerText);
                        int east = Convert.ToInt32(room.ChildNodes[5].InnerText);
                        int west = Convert.ToInt32(room.ChildNodes[6].InnerText);

                        Button btn = gridPanel.GetControlFromPosition((x * 2), (y * 2)) as Button;
                        btn.BackColor = Color.FromName(color);
                        btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                        btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                        popLabel.Focus();

                        if(north != -1)
                        {
                            btn = gridPanel.GetControlFromPosition((x * 2), (y * 2) - 1) as Button;
                            btn.BackColor = Color.Gray;
                            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                            popLabel.Focus();
                        }
                        if (south != -1)
                        {
                            btn = gridPanel.GetControlFromPosition((x * 2), (y * 2) + 1) as Button;
                            btn.BackColor = Color.Gray;
                            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                            popLabel.Focus();
                        }
                        if (east != -1)
                        {
                            btn = gridPanel.GetControlFromPosition((x * 2) + 1, (y * 2)) as Button;
                            btn.BackColor = Color.Gray;
                            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                            popLabel.Focus();
                        }
                        if (west != -1)
                        {
                            btn = gridPanel.GetControlFromPosition((x * 2) - 1, (y * 2)) as Button;
                            btn.BackColor = Color.Gray;
                            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                            popLabel.Focus();
                        }

                        if (index == startIndex)
                            foreach (TreeNode item in roomTree.Nodes)
                                if (item.Text == color)
                                    item.Text += " *Starting Room*";
                    }

                    foreach (XmlNode item in table)
                    {
                        foreach (TreeNode node in roomTree.Nodes)
                            if (node.Text.Contains(item.Name))
                            {
                                foreach (XmlNode setup in item)
                                {
                                    string scene = setup.ChildNodes[0].InnerText;
                                    string spawn = setup.ChildNodes[1].InnerText;
                                    string pop = setup.ChildNodes[2].InnerText;
                                    string prob = setup.ChildNodes[3].InnerText;
                                    node.Nodes.Add(scene + "/" + spawn + "/" + pop + "/" + prob);
                                }
                                node.Expand();
                            }
                    }

                    Tabs.SelectTab(1);
                }
            }
            else
            {
                MessageBox.Show("Invalid file", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conected)
            {
                openFileDialog1.InitialDirectory = basePath + "\\Project\\Assets\\Resources\\XML";
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                LoadFile(filename);
                filename = Path.GetFileName(openFileDialog1.FileName);
                filename = filename.Remove(filename.Length - 4, 4);
                FilenameText.Text = filename;
            }
        }

        private void roomDelBtn_Click(object sender, EventArgs e)
        {
            if (roomTree.SelectedNode == null)
            {
                MessageBox.Show("Select a item to remove", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (roomTree.SelectedNode.Parent == null)
            {
                MessageBox.Show("Invalid Selection", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (roomTree.SelectedNode.Parent != null)
            {
                roomTree.BeginUpdate();
                roomTree.SelectedNode.Remove();
                roomTree.EndUpdate();
            }
        }

        private void roomAddBtn_Click(object sender, EventArgs e)
        {
            if (roomTree.SelectedNode == null)
            {
                MessageBox.Show("Invalid Selection", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (roomTree.SelectedNode.Parent != null)
            {
                roomTree.SelectedNode = roomTree.SelectedNode.Parent;
            }

            string input = Rooms.Text + "/" + SpawnTables.Text + "/" + popUpDown.Value.ToString() + "/" + roomProbUpDown.Value.ToString();
            roomTree.SelectedNode.Nodes.Add(input);
            roomTree.SelectedNode.Expand();
        }

        private void startRoomBtn_Click(object sender, EventArgs e)
        {
            if (roomTree.SelectedNode == null)
            {
                MessageBox.Show("Invalid Selection", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (roomTree.SelectedNode.Parent != null)
            {
                roomTree.SelectedNode = roomTree.SelectedNode.Parent;
            }

            foreach (TreeNode item in roomTree.Nodes)
            {
                if (item.Text.Contains(" *Starting Room*"))
                {
                    item.Text = item.Text.Remove(item.Text.Length - 16, 16);
                }
            }

            roomTree.SelectedNode.Text += " *Starting Room*";
        }

        private void roomDownBtn_Click(object sender, EventArgs e)
        {
            ShiftRooms(-1, 0);
        }

        private void roomUpBtn_Click(object sender, EventArgs e)
        {
            ShiftRooms(1, 0);
        }

        private void roomLeftBtn_Click(object sender, EventArgs e)
        {
            ShiftRooms(0, 1);
        }

        private void roomRightBtn_Click(object sender, EventArgs e)
        {
            ShiftRooms(0, -1);
        }

        private void ShiftRooms(int vert, int horz)
        {
            Color[,] colors = new Color[25, 25];

            foreach (Button item in gridPanel.Controls)
            {
                int col = gridPanel.GetPositionFromControl(item).Column;
                int row = gridPanel.GetPositionFromControl(item).Row;
                colors[row, col] = item.BackColor;
            }

            foreach (Button item in gridPanel.Controls)
            {
                int col = gridPanel.GetPositionFromControl(item).Column + (horz * 2);
                int row = gridPanel.GetPositionFromControl(item).Row + (vert * 2);
                if (col > 24 || col < 0 || row > 24 || row < 0)
                    item.BackColor = Color.Transparent;
                else
                    item.BackColor = colors[row, col];
            }
        }

        private void ChanBtn_Click(object sender, EventArgs e)
        {
            if (enemyTree.SelectedNode == null)
            {
                MessageBox.Show("Plese select a wave", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (enemyTree.SelectedNode.Parent == null)
            {
                string text = enemyTree.SelectedNode.Text;
                string temp = "";
                int count = 0;
                foreach (char letter in text)
                {
                    if (letter == ':')
                    {
                        int spot = count+1;
                        bool control = true;
                        int gap = -1;
                        while (control)
                            if (text[count] == '>')
                            {
                                control = false;
                            }
                            else
                            {
                                gap++;
                                count++;
                            }
                        text = text.Remove(spot, gap);
                        text = text.Insert(spot, ChanUpDown.Value.ToString());
                        enemyTree.SelectedNode.Text = text;
                        return;
                    }
                    temp += letter;
                    count++;
                }
            }
            else
            {
                MessageBox.Show("Plese select a wave", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            if (enemyTree.SelectedNode == null)
            {
                MessageBox.Show("Plese select a wave", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (enemyTree.SelectedNode.Parent == null)
            {
                bool skip = true;
                string text = enemyTree.SelectedNode.Text;
                string temp = "";
                int count = 0;
                foreach (char letter in text)
                {
                    if (letter == ':')
                    {
                        if (skip)
                        {
                            skip = false;
                            count++;
                            continue;
                        }

                        int spot = count + 1;
                        bool control = true;
                        int gap = -1;
                        while (control)
                            if (text[count] == '>')
                            {
                                control = false;
                            }
                            else
                            {
                                gap++;
                                count++;
                            }
                        text = text.Remove(spot, gap);
                        text = text.Insert(spot, CountUpDown.Value.ToString());
                        enemyTree.SelectedNode.Text = text;
                        return;
                    }
                    temp += letter;
                    count++;
                }
            }
            else
            {
                MessageBox.Show("Plese select a wave", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
