namespace TableGenerator
{
    partial class TableGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heads = new System.Windows.Forms.ComboBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Bodys = new System.Windows.Forms.ComboBox();
            this.Legs = new System.Windows.Forms.ComboBox();
            this.ProbabilityBar = new System.Windows.Forms.TrackBar();
            this.AddWaveBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddEnemyBtn = new System.Windows.Forms.Button();
            this.enemyTree = new System.Windows.Forms.TreeView();
            this.DownBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.ProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.enemyTab = new System.Windows.Forms.TabPage();
            this.LegsDrop = new System.Windows.Forms.NumericUpDown();
            this.BodyDrop = new System.Windows.Forms.NumericUpDown();
            this.HeadDrop = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamBtn = new System.Windows.Forms.Button();
            this.TeamLbl = new System.Windows.Forms.Label();
            this.TeamUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaptianBtn = new System.Windows.Forms.Button();
            this.SizeBtn = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChanBtn = new System.Windows.Forms.Button();
            this.ChanLabel = new System.Windows.Forms.Label();
            this.ChanUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProbLabel = new System.Windows.Forms.Label();
            this.LegsLabel = new System.Windows.Forms.Label();
            this.BodiesLabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.roomDownBtn = new System.Windows.Forms.Button();
            this.roomRightBtn = new System.Windows.Forms.Button();
            this.roomLeftBtn = new System.Windows.Forms.Button();
            this.roomUpBtn = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.popUpDown = new System.Windows.Forms.NumericUpDown();
            this.popBar = new System.Windows.Forms.TrackBar();
            this.popLabel = new System.Windows.Forms.Label();
            this.roomProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomProbBar = new System.Windows.Forms.TrackBar();
            this.probLabel2 = new System.Windows.Forms.Label();
            this.startRoomBtn = new System.Windows.Forms.Button();
            this.SpawnTables = new System.Windows.Forms.ComboBox();
            this.spawnLabel = new System.Windows.Forms.Label();
            this.roomDelBtn = new System.Windows.Forms.Button();
            this.roomTree = new System.Windows.Forms.TreeView();
            this.autoConCheck = new System.Windows.Forms.CheckBox();
            this.roomAddBtn = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.roomsLabels = new System.Windows.Forms.Label();
            this.WIP = new System.Windows.Forms.TabPage();
            this.DickButtBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColUpDown = new System.Windows.Forms.NumericUpDown();
            this.RowUpDown = new System.Windows.Forms.NumericUpDown();
            this.exportBtn = new System.Windows.Forms.Button();
            this.FilenameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bossRoomBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbUpDown)).BeginInit();
            this.Tabs.SuspendLayout();
            this.enemyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegsDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChanUpDown)).BeginInit();
            this.roomsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbBar)).BeginInit();
            this.WIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DickButtBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Heads
            // 
            this.Heads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Heads.FormattingEnabled = true;
            this.Heads.Items.AddRange(new object[] {
            "?"});
            this.Heads.Location = new System.Drawing.Point(6, 19);
            this.Heads.Name = "Heads";
            this.Heads.Size = new System.Drawing.Size(121, 21);
            this.Heads.TabIndex = 0;
            this.Heads.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(15, 323);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 23);
            this.readBtn.TabIndex = 1;
            this.readBtn.Text = "Link";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // Bodys
            // 
            this.Bodys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bodys.FormattingEnabled = true;
            this.Bodys.Items.AddRange(new object[] {
            "?"});
            this.Bodys.Location = new System.Drawing.Point(6, 59);
            this.Bodys.Name = "Bodys";
            this.Bodys.Size = new System.Drawing.Size(121, 21);
            this.Bodys.TabIndex = 3;
            // 
            // Legs
            // 
            this.Legs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Legs.FormattingEnabled = true;
            this.Legs.Items.AddRange(new object[] {
            "?"});
            this.Legs.Location = new System.Drawing.Point(6, 99);
            this.Legs.Name = "Legs";
            this.Legs.Size = new System.Drawing.Size(121, 21);
            this.Legs.TabIndex = 4;
            // 
            // ProbabilityBar
            // 
            this.ProbabilityBar.Location = new System.Drawing.Point(152, 166);
            this.ProbabilityBar.Maximum = 100;
            this.ProbabilityBar.Name = "ProbabilityBar";
            this.ProbabilityBar.Size = new System.Drawing.Size(100, 45);
            this.ProbabilityBar.TabIndex = 5;
            this.ProbabilityBar.Value = 100;
            this.ProbabilityBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // AddWaveBtn
            // 
            this.AddWaveBtn.Location = new System.Drawing.Point(351, 257);
            this.AddWaveBtn.Name = "AddWaveBtn";
            this.AddWaveBtn.Size = new System.Drawing.Size(75, 23);
            this.AddWaveBtn.TabIndex = 8;
            this.AddWaveBtn.Text = "Add Wave";
            this.AddWaveBtn.UseVisualStyleBackColor = true;
            this.AddWaveBtn.Click += new System.EventHandler(this.AddWaveBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(432, 257);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddEnemyBtn
            // 
            this.AddEnemyBtn.Location = new System.Drawing.Point(270, 257);
            this.AddEnemyBtn.Name = "AddEnemyBtn";
            this.AddEnemyBtn.Size = new System.Drawing.Size(75, 23);
            this.AddEnemyBtn.TabIndex = 10;
            this.AddEnemyBtn.Text = "Add Enemy";
            this.AddEnemyBtn.UseVisualStyleBackColor = true;
            this.AddEnemyBtn.Click += new System.EventHandler(this.AddEnemyBtn_Click);
            // 
            // enemyTree
            // 
            this.enemyTree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.enemyTree.HideSelection = false;
            this.enemyTree.Location = new System.Drawing.Point(270, 6);
            this.enemyTree.Name = "enemyTree";
            this.enemyTree.Size = new System.Drawing.Size(377, 245);
            this.enemyTree.TabIndex = 12;
            this.enemyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(189, 257);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 13;
            this.DownBtn.Text = "Move Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(189, 228);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 14;
            this.UpBtn.Text = "Move Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // ProbUpDown
            // 
            this.ProbUpDown.Location = new System.Drawing.Point(152, 140);
            this.ProbUpDown.Name = "ProbUpDown";
            this.ProbUpDown.Size = new System.Drawing.Size(100, 20);
            this.ProbUpDown.TabIndex = 15;
            this.ProbUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ProbUpDown.ValueChanged += new System.EventHandler(this.ProbUpDown_ValueChanged);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.enemyTab);
            this.Tabs.Controls.Add(this.roomsTab);
            this.Tabs.Controls.Add(this.WIP);
            this.Tabs.Location = new System.Drawing.Point(5, 5);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(661, 312);
            this.Tabs.TabIndex = 17;
            // 
            // enemyTab
            // 
            this.enemyTab.Controls.Add(this.LegsDrop);
            this.enemyTab.Controls.Add(this.BodyDrop);
            this.enemyTab.Controls.Add(this.HeadDrop);
            this.enemyTab.Controls.Add(this.label4);
            this.enemyTab.Controls.Add(this.label3);
            this.enemyTab.Controls.Add(this.label2);
            this.enemyTab.Controls.Add(this.label1);
            this.enemyTab.Controls.Add(this.TeamBtn);
            this.enemyTab.Controls.Add(this.TeamLbl);
            this.enemyTab.Controls.Add(this.TeamUpDown);
            this.enemyTab.Controls.Add(this.CaptianBtn);
            this.enemyTab.Controls.Add(this.SizeBtn);
            this.enemyTab.Controls.Add(this.SizeLabel);
            this.enemyTab.Controls.Add(this.SizeUpDown);
            this.enemyTab.Controls.Add(this.ChanBtn);
            this.enemyTab.Controls.Add(this.ChanLabel);
            this.enemyTab.Controls.Add(this.ChanUpDown);
            this.enemyTab.Controls.Add(this.ProbLabel);
            this.enemyTab.Controls.Add(this.LegsLabel);
            this.enemyTab.Controls.Add(this.BodiesLabel);
            this.enemyTab.Controls.Add(this.headLabel);
            this.enemyTab.Controls.Add(this.enemyTree);
            this.enemyTab.Controls.Add(this.DownBtn);
            this.enemyTab.Controls.Add(this.RemoveBtn);
            this.enemyTab.Controls.Add(this.UpBtn);
            this.enemyTab.Controls.Add(this.ProbUpDown);
            this.enemyTab.Controls.Add(this.AddEnemyBtn);
            this.enemyTab.Controls.Add(this.Heads);
            this.enemyTab.Controls.Add(this.Bodys);
            this.enemyTab.Controls.Add(this.AddWaveBtn);
            this.enemyTab.Controls.Add(this.Legs);
            this.enemyTab.Controls.Add(this.ProbabilityBar);
            this.enemyTab.Location = new System.Drawing.Point(4, 22);
            this.enemyTab.Name = "enemyTab";
            this.enemyTab.Padding = new System.Windows.Forms.Padding(3);
            this.enemyTab.Size = new System.Drawing.Size(653, 286);
            this.enemyTab.TabIndex = 0;
            this.enemyTab.Text = "Enemy";
            this.enemyTab.UseVisualStyleBackColor = true;
            // 
            // LegsDrop
            // 
            this.LegsDrop.Location = new System.Drawing.Point(162, 100);
            this.LegsDrop.Name = "LegsDrop";
            this.LegsDrop.Size = new System.Drawing.Size(47, 20);
            this.LegsDrop.TabIndex = 49;
            this.LegsDrop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // BodyDrop
            // 
            this.BodyDrop.Location = new System.Drawing.Point(162, 60);
            this.BodyDrop.Name = "BodyDrop";
            this.BodyDrop.Size = new System.Drawing.Size(47, 20);
            this.BodyDrop.TabIndex = 48;
            this.BodyDrop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // HeadDrop
            // 
            this.HeadDrop.Location = new System.Drawing.Point(162, 20);
            this.HeadDrop.Name = "HeadDrop";
            this.HeadDrop.Size = new System.Drawing.Size(47, 20);
            this.HeadDrop.TabIndex = 47;
            this.HeadDrop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Drop Rates";
            // 
            // TeamBtn
            // 
            this.TeamBtn.Location = new System.Drawing.Point(61, 220);
            this.TeamBtn.Name = "TeamBtn";
            this.TeamBtn.Size = new System.Drawing.Size(75, 23);
            this.TeamBtn.TabIndex = 42;
            this.TeamBtn.Text = "Set Team";
            this.TeamBtn.UseVisualStyleBackColor = true;
            this.TeamBtn.Click += new System.EventHandler(this.TeamBtn_Click);
            // 
            // TeamLbl
            // 
            this.TeamLbl.AutoSize = true;
            this.TeamLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLbl.Location = new System.Drawing.Point(6, 206);
            this.TeamLbl.Name = "TeamLbl";
            this.TeamLbl.Size = new System.Drawing.Size(47, 13);
            this.TeamLbl.TabIndex = 41;
            this.TeamLbl.Text = "AI Team";
            // 
            // TeamUpDown
            // 
            this.TeamUpDown.Location = new System.Drawing.Point(9, 222);
            this.TeamUpDown.Name = "TeamUpDown";
            this.TeamUpDown.Size = new System.Drawing.Size(47, 20);
            this.TeamUpDown.TabIndex = 40;
            // 
            // CaptianBtn
            // 
            this.CaptianBtn.Location = new System.Drawing.Point(9, 248);
            this.CaptianBtn.Name = "CaptianBtn";
            this.CaptianBtn.Size = new System.Drawing.Size(100, 23);
            this.CaptianBtn.TabIndex = 39;
            this.CaptianBtn.Text = "Toggle Captian";
            this.CaptianBtn.UseVisualStyleBackColor = true;
            this.CaptianBtn.Click += new System.EventHandler(this.CaptianBtn_Click);
            // 
            // SizeBtn
            // 
            this.SizeBtn.Location = new System.Drawing.Point(61, 180);
            this.SizeBtn.Name = "SizeBtn";
            this.SizeBtn.Size = new System.Drawing.Size(75, 23);
            this.SizeBtn.TabIndex = 38;
            this.SizeBtn.Text = "Set Size";
            this.SizeBtn.UseVisualStyleBackColor = true;
            this.SizeBtn.Click += new System.EventHandler(this.SizeBtn_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(6, 166);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(71, 13);
            this.SizeLabel.TabIndex = 37;
            this.SizeLabel.Text = "Size of Wave";
            // 
            // SizeUpDown
            // 
            this.SizeUpDown.Location = new System.Drawing.Point(9, 182);
            this.SizeUpDown.Name = "SizeUpDown";
            this.SizeUpDown.Size = new System.Drawing.Size(47, 20);
            this.SizeUpDown.TabIndex = 36;
            // 
            // ChanBtn
            // 
            this.ChanBtn.Location = new System.Drawing.Point(61, 140);
            this.ChanBtn.Name = "ChanBtn";
            this.ChanBtn.Size = new System.Drawing.Size(75, 23);
            this.ChanBtn.TabIndex = 35;
            this.ChanBtn.Text = "Set Channel";
            this.ChanBtn.UseVisualStyleBackColor = true;
            this.ChanBtn.Click += new System.EventHandler(this.ChanBtn_Click);
            // 
            // ChanLabel
            // 
            this.ChanLabel.AutoSize = true;
            this.ChanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanLabel.Location = new System.Drawing.Point(6, 126);
            this.ChanLabel.Name = "ChanLabel";
            this.ChanLabel.Size = new System.Drawing.Size(91, 13);
            this.ChanLabel.TabIndex = 34;
            this.ChanLabel.Text = "Spawner Channel";
            // 
            // ChanUpDown
            // 
            this.ChanUpDown.Location = new System.Drawing.Point(9, 142);
            this.ChanUpDown.Name = "ChanUpDown";
            this.ChanUpDown.Size = new System.Drawing.Size(47, 20);
            this.ChanUpDown.TabIndex = 33;
            // 
            // ProbLabel
            // 
            this.ProbLabel.AutoSize = true;
            this.ProbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbLabel.Location = new System.Drawing.Point(149, 124);
            this.ProbLabel.Name = "ProbLabel";
            this.ProbLabel.Size = new System.Drawing.Size(43, 13);
            this.ProbLabel.TabIndex = 19;
            this.ProbLabel.Text = "Probility";
            // 
            // LegsLabel
            // 
            this.LegsLabel.AutoSize = true;
            this.LegsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegsLabel.Location = new System.Drawing.Point(6, 83);
            this.LegsLabel.Name = "LegsLabel";
            this.LegsLabel.Size = new System.Drawing.Size(30, 13);
            this.LegsLabel.TabIndex = 18;
            this.LegsLabel.Text = "Legs";
            // 
            // BodiesLabel
            // 
            this.BodiesLabel.AutoSize = true;
            this.BodiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodiesLabel.Location = new System.Drawing.Point(6, 43);
            this.BodiesLabel.Name = "BodiesLabel";
            this.BodiesLabel.Size = new System.Drawing.Size(39, 13);
            this.BodiesLabel.TabIndex = 17;
            this.BodiesLabel.Text = "Bodies";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.Location = new System.Drawing.Point(6, 3);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(38, 13);
            this.headLabel.TabIndex = 16;
            this.headLabel.Text = "Heads";
            // 
            // roomsTab
            // 
            this.roomsTab.Controls.Add(this.bossRoomBtn);
            this.roomsTab.Controls.Add(this.roomDownBtn);
            this.roomsTab.Controls.Add(this.roomRightBtn);
            this.roomsTab.Controls.Add(this.roomLeftBtn);
            this.roomsTab.Controls.Add(this.roomUpBtn);
            this.roomsTab.Controls.Add(this.gridPanel);
            this.roomsTab.Controls.Add(this.popUpDown);
            this.roomsTab.Controls.Add(this.popBar);
            this.roomsTab.Controls.Add(this.popLabel);
            this.roomsTab.Controls.Add(this.roomProbUpDown);
            this.roomsTab.Controls.Add(this.roomProbBar);
            this.roomsTab.Controls.Add(this.probLabel2);
            this.roomsTab.Controls.Add(this.startRoomBtn);
            this.roomsTab.Controls.Add(this.SpawnTables);
            this.roomsTab.Controls.Add(this.spawnLabel);
            this.roomsTab.Controls.Add(this.roomDelBtn);
            this.roomsTab.Controls.Add(this.roomTree);
            this.roomsTab.Controls.Add(this.autoConCheck);
            this.roomsTab.Controls.Add(this.roomAddBtn);
            this.roomsTab.Controls.Add(this.Rooms);
            this.roomsTab.Controls.Add(this.roomsLabels);
            this.roomsTab.Location = new System.Drawing.Point(4, 22);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(653, 286);
            this.roomsTab.TabIndex = 1;
            this.roomsTab.Text = "Rooms";
            this.roomsTab.UseVisualStyleBackColor = true;
            // 
            // roomDownBtn
            // 
            this.roomDownBtn.Location = new System.Drawing.Point(326, 250);
            this.roomDownBtn.Name = "roomDownBtn";
            this.roomDownBtn.Size = new System.Drawing.Size(20, 20);
            this.roomDownBtn.TabIndex = 44;
            this.roomDownBtn.Text = "v";
            this.roomDownBtn.UseVisualStyleBackColor = true;
            this.roomDownBtn.Click += new System.EventHandler(this.roomDownBtn_Click);
            // 
            // roomRightBtn
            // 
            this.roomRightBtn.Location = new System.Drawing.Point(347, 237);
            this.roomRightBtn.Name = "roomRightBtn";
            this.roomRightBtn.Size = new System.Drawing.Size(20, 20);
            this.roomRightBtn.TabIndex = 43;
            this.roomRightBtn.Text = ">";
            this.roomRightBtn.UseVisualStyleBackColor = true;
            this.roomRightBtn.Click += new System.EventHandler(this.roomRightBtn_Click);
            // 
            // roomLeftBtn
            // 
            this.roomLeftBtn.Location = new System.Drawing.Point(305, 237);
            this.roomLeftBtn.Name = "roomLeftBtn";
            this.roomLeftBtn.Size = new System.Drawing.Size(20, 20);
            this.roomLeftBtn.TabIndex = 42;
            this.roomLeftBtn.Text = "<";
            this.roomLeftBtn.UseVisualStyleBackColor = true;
            this.roomLeftBtn.Click += new System.EventHandler(this.roomLeftBtn_Click);
            // 
            // roomUpBtn
            // 
            this.roomUpBtn.Location = new System.Drawing.Point(326, 230);
            this.roomUpBtn.Name = "roomUpBtn";
            this.roomUpBtn.Size = new System.Drawing.Size(20, 20);
            this.roomUpBtn.TabIndex = 41;
            this.roomUpBtn.Text = "^";
            this.roomUpBtn.UseVisualStyleBackColor = true;
            this.roomUpBtn.Click += new System.EventHandler(this.roomUpBtn_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.ColumnCount = 1;
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.gridPanel.Location = new System.Drawing.Point(372, 5);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.RowCount = 1;
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.gridPanel.Size = new System.Drawing.Size(275, 275);
            this.gridPanel.TabIndex = 40;
            // 
            // popUpDown
            // 
            this.popUpDown.Location = new System.Drawing.Point(6, 113);
            this.popUpDown.Name = "popUpDown";
            this.popUpDown.Size = new System.Drawing.Size(100, 20);
            this.popUpDown.TabIndex = 25;
            this.popUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.popUpDown.ValueChanged += new System.EventHandler(this.popUpDown_ValueChanged);
            // 
            // popBar
            // 
            this.popBar.Location = new System.Drawing.Point(6, 139);
            this.popBar.Maximum = 100;
            this.popBar.Name = "popBar";
            this.popBar.Size = new System.Drawing.Size(100, 45);
            this.popBar.TabIndex = 24;
            this.popBar.Value = 100;
            this.popBar.Scroll += new System.EventHandler(this.popBar_Scroll);
            // 
            // popLabel
            // 
            this.popLabel.AutoSize = true;
            this.popLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popLabel.Location = new System.Drawing.Point(3, 97);
            this.popLabel.Name = "popLabel";
            this.popLabel.Size = new System.Drawing.Size(57, 13);
            this.popLabel.TabIndex = 23;
            this.popLabel.Text = "Population";
            // 
            // roomProbUpDown
            // 
            this.roomProbUpDown.Location = new System.Drawing.Point(6, 207);
            this.roomProbUpDown.Name = "roomProbUpDown";
            this.roomProbUpDown.Size = new System.Drawing.Size(100, 20);
            this.roomProbUpDown.TabIndex = 22;
            this.roomProbUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.roomProbUpDown.ValueChanged += new System.EventHandler(this.roomProbUpDown_ValueChanged);
            // 
            // roomProbBar
            // 
            this.roomProbBar.Location = new System.Drawing.Point(6, 233);
            this.roomProbBar.Maximum = 100;
            this.roomProbBar.Name = "roomProbBar";
            this.roomProbBar.Size = new System.Drawing.Size(100, 45);
            this.roomProbBar.TabIndex = 21;
            this.roomProbBar.Value = 100;
            this.roomProbBar.Scroll += new System.EventHandler(this.roomProbBar_Scroll);
            // 
            // probLabel2
            // 
            this.probLabel2.AutoSize = true;
            this.probLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probLabel2.Location = new System.Drawing.Point(3, 191);
            this.probLabel2.Name = "probLabel2";
            this.probLabel2.Size = new System.Drawing.Size(43, 13);
            this.probLabel2.TabIndex = 20;
            this.probLabel2.Text = "Probility";
            // 
            // startRoomBtn
            // 
            this.startRoomBtn.Location = new System.Drawing.Point(193, 210);
            this.startRoomBtn.Name = "startRoomBtn";
            this.startRoomBtn.Size = new System.Drawing.Size(106, 23);
            this.startRoomBtn.TabIndex = 39;
            this.startRoomBtn.Text = "Tag Starting Room";
            this.startRoomBtn.UseVisualStyleBackColor = true;
            this.startRoomBtn.Click += new System.EventHandler(this.startRoomBtn_Click);
            // 
            // SpawnTables
            // 
            this.SpawnTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpawnTables.FormattingEnabled = true;
            this.SpawnTables.Location = new System.Drawing.Point(6, 66);
            this.SpawnTables.Name = "SpawnTables";
            this.SpawnTables.Size = new System.Drawing.Size(100, 21);
            this.SpawnTables.TabIndex = 38;
            // 
            // spawnLabel
            // 
            this.spawnLabel.AutoSize = true;
            this.spawnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spawnLabel.Location = new System.Drawing.Point(3, 49);
            this.spawnLabel.Name = "spawnLabel";
            this.spawnLabel.Size = new System.Drawing.Size(72, 13);
            this.spawnLabel.TabIndex = 37;
            this.spawnLabel.Text = "SpawnTables";
            // 
            // roomDelBtn
            // 
            this.roomDelBtn.Location = new System.Drawing.Point(112, 258);
            this.roomDelBtn.Name = "roomDelBtn";
            this.roomDelBtn.Size = new System.Drawing.Size(75, 23);
            this.roomDelBtn.TabIndex = 36;
            this.roomDelBtn.Text = "Remove";
            this.roomDelBtn.UseVisualStyleBackColor = true;
            this.roomDelBtn.Click += new System.EventHandler(this.roomDelBtn_Click);
            // 
            // roomTree
            // 
            this.roomTree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.roomTree.HideSelection = false;
            this.roomTree.Location = new System.Drawing.Point(112, 6);
            this.roomTree.Name = "roomTree";
            this.roomTree.Size = new System.Drawing.Size(254, 198);
            this.roomTree.TabIndex = 35;
            // 
            // autoConCheck
            // 
            this.autoConCheck.AutoSize = true;
            this.autoConCheck.Checked = true;
            this.autoConCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoConCheck.Location = new System.Drawing.Point(191, 263);
            this.autoConCheck.Name = "autoConCheck";
            this.autoConCheck.Size = new System.Drawing.Size(121, 17);
            this.autoConCheck.TabIndex = 34;
            this.autoConCheck.Text = "Auto Conect Rooms";
            this.autoConCheck.UseVisualStyleBackColor = true;
            // 
            // roomAddBtn
            // 
            this.roomAddBtn.Location = new System.Drawing.Point(112, 231);
            this.roomAddBtn.Name = "roomAddBtn";
            this.roomAddBtn.Size = new System.Drawing.Size(75, 23);
            this.roomAddBtn.TabIndex = 26;
            this.roomAddBtn.Text = "Add Room";
            this.roomAddBtn.UseVisualStyleBackColor = true;
            this.roomAddBtn.Click += new System.EventHandler(this.roomAddBtn_Click);
            // 
            // Rooms
            // 
            this.Rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(6, 19);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(100, 21);
            this.Rooms.TabIndex = 1;
            // 
            // roomsLabels
            // 
            this.roomsLabels.AutoSize = true;
            this.roomsLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsLabels.Location = new System.Drawing.Point(3, 3);
            this.roomsLabels.Name = "roomsLabels";
            this.roomsLabels.Size = new System.Drawing.Size(40, 13);
            this.roomsLabels.TabIndex = 0;
            this.roomsLabels.Text = "Rooms";
            // 
            // WIP
            // 
            this.WIP.Controls.Add(this.DickButtBar);
            this.WIP.Controls.Add(this.pictureBox1);
            this.WIP.Controls.Add(this.ColUpDown);
            this.WIP.Controls.Add(this.RowUpDown);
            this.WIP.Location = new System.Drawing.Point(4, 22);
            this.WIP.Name = "WIP";
            this.WIP.Padding = new System.Windows.Forms.Padding(3);
            this.WIP.Size = new System.Drawing.Size(653, 286);
            this.WIP.TabIndex = 2;
            this.WIP.Text = "WIP";
            this.WIP.UseVisualStyleBackColor = true;
            // 
            // DickButtBar
            // 
            this.DickButtBar.Location = new System.Drawing.Point(33, 223);
            this.DickButtBar.Maximum = 5;
            this.DickButtBar.Name = "DickButtBar";
            this.DickButtBar.Size = new System.Drawing.Size(100, 45);
            this.DickButtBar.TabIndex = 30;
            this.DickButtBar.Value = 1;
            this.DickButtBar.Scroll += new System.EventHandler(this.DickButtBar_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TableGenerator.Properties.Resources.Dickbut;
            this.pictureBox1.Location = new System.Drawing.Point(33, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ColUpDown
            // 
            this.ColUpDown.Location = new System.Drawing.Point(443, 185);
            this.ColUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ColUpDown.Name = "ColUpDown";
            this.ColUpDown.ReadOnly = true;
            this.ColUpDown.Size = new System.Drawing.Size(38, 20);
            this.ColUpDown.TabIndex = 34;
            this.ColUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RowUpDown
            // 
            this.RowUpDown.Location = new System.Drawing.Point(487, 185);
            this.RowUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RowUpDown.Name = "RowUpDown";
            this.RowUpDown.ReadOnly = true;
            this.RowUpDown.Size = new System.Drawing.Size(38, 20);
            this.RowUpDown.TabIndex = 33;
            this.RowUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(96, 323);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 18;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // FilenameText
            // 
            this.FilenameText.Location = new System.Drawing.Point(177, 325);
            this.FilenameText.Name = "FilenameText";
            this.FilenameText.Size = new System.Drawing.Size(146, 20);
            this.FilenameText.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bossRoomBtn
            // 
            this.bossRoomBtn.Location = new System.Drawing.Point(193, 234);
            this.bossRoomBtn.Name = "bossRoomBtn";
            this.bossRoomBtn.Size = new System.Drawing.Size(106, 23);
            this.bossRoomBtn.TabIndex = 45;
            this.bossRoomBtn.Text = "Tag Boss Room";
            this.bossRoomBtn.UseVisualStyleBackColor = true;
            this.bossRoomBtn.Click += new System.EventHandler(this.bossRoomBtn_Click);
            // 
            // TableGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilenameText);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.Tabs);
            this.Name = "TableGen";
            this.Text = "Wonder and Amazement";
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbUpDown)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.enemyTab.ResumeLayout(false);
            this.enemyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegsDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChanUpDown)).EndInit();
            this.roomsTab.ResumeLayout(false);
            this.roomsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbBar)).EndInit();
            this.WIP.ResumeLayout(false);
            this.WIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DickButtBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Heads;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox Bodys;
        private System.Windows.Forms.ComboBox Legs;
        private System.Windows.Forms.TrackBar ProbabilityBar;
        private System.Windows.Forms.Button AddWaveBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddEnemyBtn;
        private System.Windows.Forms.TreeView enemyTree;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.NumericUpDown ProbUpDown;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage enemyTab;
        private System.Windows.Forms.TabPage roomsTab;
        private System.Windows.Forms.Label LegsLabel;
        private System.Windows.Forms.Label BodiesLabel;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.Label roomsLabels;
        private System.Windows.Forms.Label ProbLabel;
        private System.Windows.Forms.Label probLabel2;
        private System.Windows.Forms.NumericUpDown roomProbUpDown;
        private System.Windows.Forms.TrackBar roomProbBar;
        private System.Windows.Forms.NumericUpDown popUpDown;
        private System.Windows.Forms.TrackBar popBar;
        private System.Windows.Forms.Label popLabel;
        private System.Windows.Forms.Button roomAddBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.TextBox FilenameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage WIP;
        private System.Windows.Forms.TrackBar DickButtBar;
        private System.Windows.Forms.CheckBox autoConCheck;
        private System.Windows.Forms.TreeView roomTree;
        private System.Windows.Forms.Button roomDelBtn;
        private System.Windows.Forms.NumericUpDown ColUpDown;
        private System.Windows.Forms.NumericUpDown RowUpDown;
        private System.Windows.Forms.ComboBox SpawnTables;
        private System.Windows.Forms.Label spawnLabel;
        private System.Windows.Forms.Button startRoomBtn;
        private System.Windows.Forms.TableLayoutPanel gridPanel;
        private System.Windows.Forms.Button roomDownBtn;
        private System.Windows.Forms.Button roomRightBtn;
        private System.Windows.Forms.Button roomLeftBtn;
        private System.Windows.Forms.Button roomUpBtn;
        private System.Windows.Forms.Button SizeBtn;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.NumericUpDown SizeUpDown;
        private System.Windows.Forms.Button ChanBtn;
        private System.Windows.Forms.Label ChanLabel;
        private System.Windows.Forms.NumericUpDown ChanUpDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CaptianBtn;
        private System.Windows.Forms.Button TeamBtn;
        private System.Windows.Forms.Label TeamLbl;
        private System.Windows.Forms.NumericUpDown TeamUpDown;
        private System.Windows.Forms.NumericUpDown LegsDrop;
        private System.Windows.Forms.NumericUpDown BodyDrop;
        private System.Windows.Forms.NumericUpDown HeadDrop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bossRoomBtn;
    }
}

