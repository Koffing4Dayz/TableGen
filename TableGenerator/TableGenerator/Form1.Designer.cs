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
            this.ProbLabel = new System.Windows.Forms.Label();
            this.LegsLabel = new System.Windows.Forms.Label();
            this.BodiesLabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.autoConCheck = new System.Windows.Forms.CheckBox();
            this.roomAddBtn = new System.Windows.Forms.Button();
            this.popUpDown = new System.Windows.Forms.NumericUpDown();
            this.popBar = new System.Windows.Forms.TrackBar();
            this.popLabel = new System.Windows.Forms.Label();
            this.roomProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomProbBar = new System.Windows.Forms.TrackBar();
            this.probLabel2 = new System.Windows.Forms.Label();
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.roomsLabels = new System.Windows.Forms.Label();
            this.WIP = new System.Windows.Forms.TabPage();
            this.DropLabel = new System.Windows.Forms.Label();
            this.DropUpDown = new System.Windows.Forms.NumericUpDown();
            this.DropBar = new System.Windows.Forms.TrackBar();
            this.exportBtn = new System.Windows.Forms.Button();
            this.FilenameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.roomTree = new System.Windows.Forms.TreeView();
            this.ColUpDown = new System.Windows.Forms.NumericUpDown();
            this.RowUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomDelBtn = new System.Windows.Forms.Button();
            this.spawnLabel = new System.Windows.Forms.Label();
            this.SpawnTables = new System.Windows.Forms.ComboBox();
            this.startRoomBtn = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbUpDown)).BeginInit();
            this.Tabs.SuspendLayout();
            this.enemyTab.SuspendLayout();
            this.roomsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbBar)).BeginInit();
            this.WIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropBar)).BeginInit();
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
            this.ProbabilityBar.Location = new System.Drawing.Point(148, 51);
            this.ProbabilityBar.Maximum = 100;
            this.ProbabilityBar.Name = "ProbabilityBar";
            this.ProbabilityBar.Size = new System.Drawing.Size(100, 45);
            this.ProbabilityBar.TabIndex = 5;
            this.ProbabilityBar.Value = 100;
            this.ProbabilityBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // AddWaveBtn
            // 
            this.AddWaveBtn.Location = new System.Drawing.Point(87, 257);
            this.AddWaveBtn.Name = "AddWaveBtn";
            this.AddWaveBtn.Size = new System.Drawing.Size(75, 23);
            this.AddWaveBtn.TabIndex = 8;
            this.AddWaveBtn.Text = "Add Wave";
            this.AddWaveBtn.UseVisualStyleBackColor = true;
            this.AddWaveBtn.Click += new System.EventHandler(this.AddWaveBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(189, 257);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddEnemyBtn
            // 
            this.AddEnemyBtn.Location = new System.Drawing.Point(6, 257);
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
            this.enemyTree.Size = new System.Drawing.Size(377, 274);
            this.enemyTree.TabIndex = 12;
            this.enemyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(189, 228);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 13;
            this.DownBtn.Text = "Move Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Location = new System.Drawing.Point(189, 199);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 14;
            this.UpBtn.Text = "Move Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // ProbUpDown
            // 
            this.ProbUpDown.Location = new System.Drawing.Point(148, 25);
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
            // ProbLabel
            // 
            this.ProbLabel.AutoSize = true;
            this.ProbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbLabel.Location = new System.Drawing.Point(145, 9);
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
            // autoConCheck
            // 
            this.autoConCheck.AutoSize = true;
            this.autoConCheck.Checked = true;
            this.autoConCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoConCheck.Location = new System.Drawing.Point(245, 261);
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
            this.WIP.Controls.Add(this.ColUpDown);
            this.WIP.Controls.Add(this.RowUpDown);
            this.WIP.Controls.Add(this.DropLabel);
            this.WIP.Controls.Add(this.DropUpDown);
            this.WIP.Controls.Add(this.DropBar);
            this.WIP.Location = new System.Drawing.Point(4, 22);
            this.WIP.Name = "WIP";
            this.WIP.Padding = new System.Windows.Forms.Padding(3);
            this.WIP.Size = new System.Drawing.Size(653, 286);
            this.WIP.TabIndex = 2;
            this.WIP.Text = "WIP";
            this.WIP.UseVisualStyleBackColor = true;
            // 
            // DropLabel
            // 
            this.DropLabel.AutoSize = true;
            this.DropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropLabel.Location = new System.Drawing.Point(275, 97);
            this.DropLabel.Name = "DropLabel";
            this.DropLabel.Size = new System.Drawing.Size(70, 13);
            this.DropLabel.TabIndex = 32;
            this.DropLabel.Text = "Drop Chance";
            // 
            // DropUpDown
            // 
            this.DropUpDown.Location = new System.Drawing.Point(278, 118);
            this.DropUpDown.Name = "DropUpDown";
            this.DropUpDown.Size = new System.Drawing.Size(100, 20);
            this.DropUpDown.TabIndex = 31;
            this.DropUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // DropBar
            // 
            this.DropBar.Location = new System.Drawing.Point(278, 144);
            this.DropBar.Maximum = 100;
            this.DropBar.Name = "DropBar";
            this.DropBar.Size = new System.Drawing.Size(100, 45);
            this.DropBar.TabIndex = 30;
            this.DropBar.Value = 100;
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
            // roomTree
            // 
            this.roomTree.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.roomTree.HideSelection = false;
            this.roomTree.Location = new System.Drawing.Point(112, 6);
            this.roomTree.Name = "roomTree";
            this.roomTree.Size = new System.Drawing.Size(254, 219);
            this.roomTree.TabIndex = 35;
            // 
            // ColUpDown
            // 
            this.ColUpDown.Location = new System.Drawing.Point(254, 211);
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
            this.RowUpDown.Location = new System.Drawing.Point(298, 211);
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
            // SpawnTables
            // 
            this.SpawnTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpawnTables.FormattingEnabled = true;
            this.SpawnTables.Location = new System.Drawing.Point(6, 66);
            this.SpawnTables.Name = "SpawnTables";
            this.SpawnTables.Size = new System.Drawing.Size(100, 21);
            this.SpawnTables.TabIndex = 38;
            // 
            // startRoomBtn
            // 
            this.startRoomBtn.Location = new System.Drawing.Point(193, 231);
            this.startRoomBtn.Name = "startRoomBtn";
            this.startRoomBtn.Size = new System.Drawing.Size(106, 23);
            this.startRoomBtn.TabIndex = 39;
            this.startRoomBtn.Text = "Tag Starting Room";
            this.startRoomBtn.UseVisualStyleBackColor = true;
            this.startRoomBtn.Click += new System.EventHandler(this.startRoomBtn_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.ColumnCount = 1;
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.gridPanel.Location = new System.Drawing.Point(372, 5);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.RowCount = 1;
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.gridPanel.Size = new System.Drawing.Size(275, 275);
            this.gridPanel.TabIndex = 40;
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
            this.roomsTab.ResumeLayout(false);
            this.roomsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomProbBar)).EndInit();
            this.WIP.ResumeLayout(false);
            this.WIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DropUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropBar)).EndInit();
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
        private System.Windows.Forms.Label DropLabel;
        private System.Windows.Forms.NumericUpDown DropUpDown;
        private System.Windows.Forms.TrackBar DropBar;
        private System.Windows.Forms.CheckBox autoConCheck;
        private System.Windows.Forms.TreeView roomTree;
        private System.Windows.Forms.Button roomDelBtn;
        private System.Windows.Forms.NumericUpDown ColUpDown;
        private System.Windows.Forms.NumericUpDown RowUpDown;
        private System.Windows.Forms.ComboBox SpawnTables;
        private System.Windows.Forms.Label spawnLabel;
        private System.Windows.Forms.Button startRoomBtn;
        private System.Windows.Forms.TableLayoutPanel gridPanel;
    }
}

