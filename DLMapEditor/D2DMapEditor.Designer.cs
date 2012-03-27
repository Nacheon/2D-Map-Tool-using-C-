namespace D2DMapEditor
{
    partial class D2DMapEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D2DMapEditor));
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.tctrlDesign = new System.Windows.Forms.TabControl();
            this.tpgDesign = new System.Windows.Forms.TabPage();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.tpgCode = new System.Windows.Forms.TabPage();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.gbLayerProperties = new System.Windows.Forms.GroupBox();
            this.lblLayerIdLabel = new System.Windows.Forms.Label();
            this.lblLayerId = new System.Windows.Forms.Label();
            this.cbLayerVisible = new System.Windows.Forms.CheckBox();
            this.lblLayerAlpha = new System.Windows.Forms.Label();
            this.tbarLayerAlpha = new System.Windows.Forms.TrackBar();
            this.tbLayerName = new System.Windows.Forms.TextBox();
            this.btnUpdateLayer = new System.Windows.Forms.Button();
            this.lblLayerName = new System.Windows.Forms.Label();
            this.lblLayerWidth = new System.Windows.Forms.Label();
            this.nudTileHeight = new System.Windows.Forms.NumericUpDown();
            this.lblLayerHeight = new System.Windows.Forms.Label();
            this.nudTileWidth = new System.Windows.Forms.NumericUpDown();
            this.nudLayerWidth = new System.Windows.Forms.NumericUpDown();
            this.lblLayerTileHeight = new System.Windows.Forms.Label();
            this.nudLayerHeight = new System.Windows.Forms.NumericUpDown();
            this.lblLayerTileWidth = new System.Windows.Forms.Label();
            this.gbTileProperties = new System.Windows.Forms.GroupBox();
            this.lblTileType = new System.Windows.Forms.Label();
            this.cbTileType = new System.Windows.Forms.ComboBox();
            this.btnUpdateTile = new System.Windows.Forms.Button();
            this.cbTileWalkable = new System.Windows.Forms.CheckBox();
            this.tbTileName = new System.Windows.Forms.TextBox();
            this.lblTileIDValue = new System.Windows.Forms.Label();
            this.lblTileName = new System.Windows.Forms.Label();
            this.lblTileID = new System.Windows.Forms.Label();
            this.pbSelectedTile = new System.Windows.Forms.PictureBox();
            this.gbCode = new System.Windows.Forms.GroupBox();
            this.rbXMLLite = new System.Windows.Forms.RadioButton();
            this.rbAS = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.rbCS = new System.Windows.Forms.RadioButton();
            this.rbCPP = new System.Windows.Forms.RadioButton();
            this.gbLayers = new System.Windows.Forms.GroupBox();
            this.btnLayerMoveDown = new System.Windows.Forms.Button();
            this.btnLayerMoveUp = new System.Windows.Forms.Button();
            this.btnDeleteLayer = new System.Windows.Forms.Button();
            this.btnAddLayer = new System.Windows.Forms.Button();
            this.lbLayers = new System.Windows.Forms.ListBox();
            this.pbMapSmall = new System.Windows.Forms.PictureBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.lblMapCoordinate = new System.Windows.Forms.Label();
            this.menuStripDLMapEditor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitDLMapEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWalkableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTileSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cArrayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialogLoadTiles = new System.Windows.Forms.FolderBrowserDialog();
            this.saveMapDialog = new System.Windows.Forms.SaveFileDialog();
            this.openMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbTiles = new System.Windows.Forms.GroupBox();
            this.lvTileLibrary = new System.Windows.Forms.ListView();
            this.pnlTiles = new System.Windows.Forms.Panel();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btnToolFill = new System.Windows.Forms.Button();
            this.btnToolSelection = new System.Windows.Forms.Button();
            this.btnToolEraser = new System.Windows.Forms.Button();
            this.btnToolSelectTile = new System.Windows.Forms.Button();
            this.btnToolBrush = new System.Windows.Forms.Button();
            this.gbMapSmall = new System.Windows.Forms.GroupBox();
            this.tbMapName = new System.Windows.Forms.TextBox();
            this.lblMapName = new System.Windows.Forms.Label();
            this.contextMenuStripTile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemWalkable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ilTileImages = new System.Windows.Forms.ImageList(this.components);
            this.pnlDesign.SuspendLayout();
            this.tctrlDesign.SuspendLayout();
            this.tpgDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.tpgCode.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            this.gbLayerProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLayerAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLayerWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLayerHeight)).BeginInit();
            this.gbTileProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTile)).BeginInit();
            this.gbCode.SuspendLayout();
            this.gbLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapSmall)).BeginInit();
            this.menuStripDLMapEditor.SuspendLayout();
            this.gbTiles.SuspendLayout();
            this.pnlTiles.SuspendLayout();
            this.gbTools.SuspendLayout();
            this.gbMapSmall.SuspendLayout();
            this.contextMenuStripTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesign
            // 
            this.pnlDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesign.AutoSize = true;
            this.pnlDesign.Controls.Add(this.tctrlDesign);
            this.pnlDesign.Location = new System.Drawing.Point(0, 22);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(971, 529);
            this.pnlDesign.TabIndex = 0;
            // 
            // tctrlDesign
            // 
            this.tctrlDesign.Controls.Add(this.tpgDesign);
            this.tctrlDesign.Controls.Add(this.tpgCode);
            this.tctrlDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlDesign.Location = new System.Drawing.Point(0, 0);
            this.tctrlDesign.Multiline = true;
            this.tctrlDesign.Name = "tctrlDesign";
            this.tctrlDesign.SelectedIndex = 0;
            this.tctrlDesign.Size = new System.Drawing.Size(971, 529);
            this.tctrlDesign.TabIndex = 1;
            this.tctrlDesign.SelectedIndexChanged += new System.EventHandler(this.tctrlDesign_SelectedIndexChanged);
            // 
            // tpgDesign
            // 
            this.tpgDesign.AutoScroll = true;
            this.tpgDesign.Controls.Add(this.pbMap);
            this.tpgDesign.Cursor = System.Windows.Forms.Cursors.No;
            this.tpgDesign.Location = new System.Drawing.Point(4, 22);
            this.tpgDesign.Name = "tpgDesign";
            this.tpgDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDesign.Size = new System.Drawing.Size(963, 503);
            this.tpgDesign.TabIndex = 0;
            this.tpgDesign.Text = "Design";
            this.tpgDesign.UseVisualStyleBackColor = true;
            // 
            // pbMap
            // 
            this.pbMap.BackColor = System.Drawing.Color.LightGray;
            this.pbMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbMap.Location = new System.Drawing.Point(5, 4);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(58, 46);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            // 
            // tpgCode
            // 
            this.tpgCode.Controls.Add(this.tbCode);
            this.tpgCode.Location = new System.Drawing.Point(4, 22);
            this.tpgCode.Name = "tpgCode";
            this.tpgCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCode.Size = new System.Drawing.Size(963, 503);
            this.tpgCode.TabIndex = 1;
            this.tpgCode.Text = "Code";
            this.tpgCode.UseVisualStyleBackColor = true;
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCode.CausesValidation = false;
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(3, 3);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCode.Size = new System.Drawing.Size(957, 497);
            this.tbCode.TabIndex = 0;
            // 
            // pnlProperties
            // 
            this.pnlProperties.AutoSize = true;
            this.pnlProperties.Controls.Add(this.gbLayerProperties);
            this.pnlProperties.Controls.Add(this.gbTileProperties);
            this.pnlProperties.Controls.Add(this.gbCode);
            this.pnlProperties.Controls.Add(this.gbLayers);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProperties.Location = new System.Drawing.Point(0, 557);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(1185, 121);
            this.pnlProperties.TabIndex = 1;
            // 
            // gbLayerProperties
            // 
            this.gbLayerProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLayerProperties.Controls.Add(this.lblLayerIdLabel);
            this.gbLayerProperties.Controls.Add(this.lblLayerId);
            this.gbLayerProperties.Controls.Add(this.cbLayerVisible);
            this.gbLayerProperties.Controls.Add(this.lblLayerAlpha);
            this.gbLayerProperties.Controls.Add(this.tbarLayerAlpha);
            this.gbLayerProperties.Controls.Add(this.tbLayerName);
            this.gbLayerProperties.Controls.Add(this.btnUpdateLayer);
            this.gbLayerProperties.Controls.Add(this.lblLayerName);
            this.gbLayerProperties.Controls.Add(this.lblLayerWidth);
            this.gbLayerProperties.Controls.Add(this.nudTileHeight);
            this.gbLayerProperties.Controls.Add(this.lblLayerHeight);
            this.gbLayerProperties.Controls.Add(this.nudTileWidth);
            this.gbLayerProperties.Controls.Add(this.nudLayerWidth);
            this.gbLayerProperties.Controls.Add(this.lblLayerTileHeight);
            this.gbLayerProperties.Controls.Add(this.nudLayerHeight);
            this.gbLayerProperties.Controls.Add(this.lblLayerTileWidth);
            this.gbLayerProperties.Enabled = false;
            this.gbLayerProperties.Location = new System.Drawing.Point(316, 0);
            this.gbLayerProperties.Name = "gbLayerProperties";
            this.gbLayerProperties.Size = new System.Drawing.Size(363, 118);
            this.gbLayerProperties.TabIndex = 6;
            this.gbLayerProperties.TabStop = false;
            this.gbLayerProperties.Text = "Layer Properties";
            // 
            // lblLayerIdLabel
            // 
            this.lblLayerIdLabel.AutoSize = true;
            this.lblLayerIdLabel.Location = new System.Drawing.Point(8, 18);
            this.lblLayerIdLabel.Name = "lblLayerIdLabel";
            this.lblLayerIdLabel.Size = new System.Drawing.Size(16, 12);
            this.lblLayerIdLabel.TabIndex = 13;
            this.lblLayerIdLabel.Text = "ID";
            // 
            // lblLayerId
            // 
            this.lblLayerId.AutoSize = true;
            this.lblLayerId.Location = new System.Drawing.Point(35, 18);
            this.lblLayerId.Name = "lblLayerId";
            this.lblLayerId.Size = new System.Drawing.Size(0, 12);
            this.lblLayerId.TabIndex = 12;
            // 
            // cbLayerVisible
            // 
            this.cbLayerVisible.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbLayerVisible.AutoSize = true;
            this.cbLayerVisible.Checked = true;
            this.cbLayerVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLayerVisible.Location = new System.Drawing.Point(293, 16);
            this.cbLayerVisible.Name = "cbLayerVisible";
            this.cbLayerVisible.Size = new System.Drawing.Size(62, 16);
            this.cbLayerVisible.TabIndex = 11;
            this.cbLayerVisible.Text = "Visible";
            this.cbLayerVisible.UseVisualStyleBackColor = true;
            // 
            // lblLayerAlpha
            // 
            this.lblLayerAlpha.AutoSize = true;
            this.lblLayerAlpha.Location = new System.Drawing.Point(8, 84);
            this.lblLayerAlpha.Name = "lblLayerAlpha";
            this.lblLayerAlpha.Size = new System.Drawing.Size(37, 12);
            this.lblLayerAlpha.TabIndex = 10;
            this.lblLayerAlpha.Text = "Alpha";
            // 
            // tbarLayerAlpha
            // 
            this.tbarLayerAlpha.AutoSize = false;
            this.tbarLayerAlpha.Location = new System.Drawing.Point(42, 84);
            this.tbarLayerAlpha.Maximum = 100;
            this.tbarLayerAlpha.Name = "tbarLayerAlpha";
            this.tbarLayerAlpha.Size = new System.Drawing.Size(192, 26);
            this.tbarLayerAlpha.TabIndex = 9;
            this.tbarLayerAlpha.Value = 100;
            this.tbarLayerAlpha.Scroll += new System.EventHandler(this.tbarLayerAlpha_Scroll);
            // 
            // tbLayerName
            // 
            this.tbLayerName.Location = new System.Drawing.Point(114, 13);
            this.tbLayerName.Name = "tbLayerName";
            this.tbLayerName.Size = new System.Drawing.Size(167, 21);
            this.tbLayerName.TabIndex = 1;
            // 
            // btnUpdateLayer
            // 
            this.btnUpdateLayer.Location = new System.Drawing.Point(241, 91);
            this.btnUpdateLayer.Name = "btnUpdateLayer";
            this.btnUpdateLayer.Size = new System.Drawing.Size(108, 21);
            this.btnUpdateLayer.TabIndex = 6;
            this.btnUpdateLayer.Text = "Update Layer";
            this.btnUpdateLayer.UseVisualStyleBackColor = true;
            this.btnUpdateLayer.Click += new System.EventHandler(this.btnUpdateLayer_Click);
            // 
            // lblLayerName
            // 
            this.lblLayerName.AutoSize = true;
            this.lblLayerName.Location = new System.Drawing.Point(70, 17);
            this.lblLayerName.Name = "lblLayerName";
            this.lblLayerName.Size = new System.Drawing.Size(39, 12);
            this.lblLayerName.TabIndex = 8;
            this.lblLayerName.Text = "Name";
            // 
            // lblLayerWidth
            // 
            this.lblLayerWidth.AutoSize = true;
            this.lblLayerWidth.Location = new System.Drawing.Point(7, 40);
            this.lblLayerWidth.Name = "lblLayerWidth";
            this.lblLayerWidth.Size = new System.Drawing.Size(35, 12);
            this.lblLayerWidth.TabIndex = 0;
            this.lblLayerWidth.Text = "Width";
            // 
            // nudTileHeight
            // 
            this.nudTileHeight.Location = new System.Drawing.Point(257, 61);
            this.nudTileHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileHeight.Name = "nudTileHeight";
            this.nudTileHeight.Size = new System.Drawing.Size(93, 21);
            this.nudTileHeight.TabIndex = 5;
            this.nudTileHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLayerHeight
            // 
            this.lblLayerHeight.AutoSize = true;
            this.lblLayerHeight.Location = new System.Drawing.Point(3, 63);
            this.lblLayerHeight.Name = "lblLayerHeight";
            this.lblLayerHeight.Size = new System.Drawing.Size(40, 12);
            this.lblLayerHeight.TabIndex = 1;
            this.lblLayerHeight.Text = "Height";
            // 
            // nudTileWidth
            // 
            this.nudTileWidth.Location = new System.Drawing.Point(257, 36);
            this.nudTileWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileWidth.Name = "nudTileWidth";
            this.nudTileWidth.Size = new System.Drawing.Size(93, 21);
            this.nudTileWidth.TabIndex = 4;
            this.nudTileWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLayerWidth
            // 
            this.nudLayerWidth.Location = new System.Drawing.Point(51, 36);
            this.nudLayerWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLayerWidth.Name = "nudLayerWidth";
            this.nudLayerWidth.Size = new System.Drawing.Size(93, 21);
            this.nudLayerWidth.TabIndex = 2;
            this.nudLayerWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLayerTileHeight
            // 
            this.lblLayerTileHeight.AutoSize = true;
            this.lblLayerTileHeight.Location = new System.Drawing.Point(185, 63);
            this.lblLayerTileHeight.Name = "lblLayerTileHeight";
            this.lblLayerTileHeight.Size = new System.Drawing.Size(65, 12);
            this.lblLayerTileHeight.TabIndex = 6;
            this.lblLayerTileHeight.Text = "Tile Height";
            // 
            // nudLayerHeight
            // 
            this.nudLayerHeight.Location = new System.Drawing.Point(51, 61);
            this.nudLayerHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLayerHeight.Name = "nudLayerHeight";
            this.nudLayerHeight.Size = new System.Drawing.Size(93, 21);
            this.nudLayerHeight.TabIndex = 3;
            this.nudLayerHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLayerTileWidth
            // 
            this.lblLayerTileWidth.AutoSize = true;
            this.lblLayerTileWidth.Location = new System.Drawing.Point(189, 40);
            this.lblLayerTileWidth.Name = "lblLayerTileWidth";
            this.lblLayerTileWidth.Size = new System.Drawing.Size(60, 12);
            this.lblLayerTileWidth.TabIndex = 5;
            this.lblLayerTileWidth.Text = "Tile Width";
            // 
            // gbTileProperties
            // 
            this.gbTileProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTileProperties.Controls.Add(this.lblTileType);
            this.gbTileProperties.Controls.Add(this.cbTileType);
            this.gbTileProperties.Controls.Add(this.btnUpdateTile);
            this.gbTileProperties.Controls.Add(this.cbTileWalkable);
            this.gbTileProperties.Controls.Add(this.tbTileName);
            this.gbTileProperties.Controls.Add(this.lblTileIDValue);
            this.gbTileProperties.Controls.Add(this.lblTileName);
            this.gbTileProperties.Controls.Add(this.lblTileID);
            this.gbTileProperties.Controls.Add(this.pbSelectedTile);
            this.gbTileProperties.Location = new System.Drawing.Point(686, 0);
            this.gbTileProperties.Name = "gbTileProperties";
            this.gbTileProperties.Size = new System.Drawing.Size(285, 118);
            this.gbTileProperties.TabIndex = 4;
            this.gbTileProperties.TabStop = false;
            this.gbTileProperties.Text = "Tile Properties";
            // 
            // lblTileType
            // 
            this.lblTileType.AutoSize = true;
            this.lblTileType.Location = new System.Drawing.Point(73, 66);
            this.lblTileType.Name = "lblTileType";
            this.lblTileType.Size = new System.Drawing.Size(59, 12);
            this.lblTileType.TabIndex = 11;
            this.lblTileType.Text = "Tile Type";
            // 
            // cbTileType
            // 
            this.cbTileType.FormattingEnabled = true;
            this.cbTileType.Location = new System.Drawing.Point(143, 61);
            this.cbTileType.Name = "cbTileType";
            this.cbTileType.Size = new System.Drawing.Size(116, 20);
            this.cbTileType.TabIndex = 10;
            // 
            // btnUpdateTile
            // 
            this.btnUpdateTile.Location = new System.Drawing.Point(172, 86);
            this.btnUpdateTile.Name = "btnUpdateTile";
            this.btnUpdateTile.Size = new System.Drawing.Size(87, 21);
            this.btnUpdateTile.TabIndex = 9;
            this.btnUpdateTile.Text = "Update Tile";
            this.btnUpdateTile.UseVisualStyleBackColor = true;
            this.btnUpdateTile.Click += new System.EventHandler(this.btnUpdateTile_Click);
            // 
            // cbTileWalkable
            // 
            this.cbTileWalkable.AutoSize = true;
            this.cbTileWalkable.Location = new System.Drawing.Point(75, 89);
            this.cbTileWalkable.Name = "cbTileWalkable";
            this.cbTileWalkable.Size = new System.Drawing.Size(74, 16);
            this.cbTileWalkable.TabIndex = 8;
            this.cbTileWalkable.Text = "Walkable";
            this.cbTileWalkable.UseVisualStyleBackColor = true;
            // 
            // tbTileName
            // 
            this.tbTileName.Location = new System.Drawing.Point(143, 37);
            this.tbTileName.Name = "tbTileName";
            this.tbTileName.Size = new System.Drawing.Size(116, 21);
            this.tbTileName.TabIndex = 7;
            // 
            // lblTileIDValue
            // 
            this.lblTileIDValue.AutoSize = true;
            this.lblTileIDValue.Location = new System.Drawing.Point(143, 18);
            this.lblTileIDValue.Name = "lblTileIDValue";
            this.lblTileIDValue.Size = new System.Drawing.Size(0, 12);
            this.lblTileIDValue.TabIndex = 7;
            // 
            // lblTileName
            // 
            this.lblTileName.AutoSize = true;
            this.lblTileName.Location = new System.Drawing.Point(72, 42);
            this.lblTileName.Name = "lblTileName";
            this.lblTileName.Size = new System.Drawing.Size(64, 12);
            this.lblTileName.TabIndex = 5;
            this.lblTileName.Text = "Tile Name";
            // 
            // lblTileID
            // 
            this.lblTileID.AutoSize = true;
            this.lblTileID.Location = new System.Drawing.Point(72, 18);
            this.lblTileID.Name = "lblTileID";
            this.lblTileID.Size = new System.Drawing.Size(41, 12);
            this.lblTileID.TabIndex = 4;
            this.lblTileID.Text = "Tile ID";
            // 
            // pbSelectedTile
            // 
            this.pbSelectedTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSelectedTile.Location = new System.Drawing.Point(14, 18);
            this.pbSelectedTile.Name = "pbSelectedTile";
            this.pbSelectedTile.Size = new System.Drawing.Size(48, 48);
            this.pbSelectedTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedTile.TabIndex = 3;
            this.pbSelectedTile.TabStop = false;
            // 
            // gbCode
            // 
            this.gbCode.Controls.Add(this.rbXMLLite);
            this.gbCode.Controls.Add(this.rbAS);
            this.gbCode.Controls.Add(this.rbXML);
            this.gbCode.Controls.Add(this.rbCS);
            this.gbCode.Controls.Add(this.rbCPP);
            this.gbCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCode.Location = new System.Drawing.Point(977, 0);
            this.gbCode.Name = "gbCode";
            this.gbCode.Size = new System.Drawing.Size(208, 121);
            this.gbCode.TabIndex = 5;
            this.gbCode.TabStop = false;
            this.gbCode.Text = "Code";
            // 
            // rbXMLLite
            // 
            this.rbXMLLite.AutoSize = true;
            this.rbXMLLite.Location = new System.Drawing.Point(14, 97);
            this.rbXMLLite.Name = "rbXMLLite";
            this.rbXMLLite.Size = new System.Drawing.Size(73, 16);
            this.rbXMLLite.TabIndex = 14;
            this.rbXMLLite.Text = "XML Lite";
            this.rbXMLLite.UseVisualStyleBackColor = true;
            this.rbXMLLite.CheckedChanged += new System.EventHandler(this.rbXMLLite_CheckedChanged);
            // 
            // rbAS
            // 
            this.rbAS.AutoSize = true;
            this.rbAS.Location = new System.Drawing.Point(14, 54);
            this.rbAS.Name = "rbAS";
            this.rbAS.Size = new System.Drawing.Size(90, 16);
            this.rbAS.TabIndex = 13;
            this.rbAS.Text = "ActionScript";
            this.rbAS.UseVisualStyleBackColor = true;
            this.rbAS.CheckedChanged += new System.EventHandler(this.rbAS_CheckedChanged);
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(14, 76);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(49, 16);
            this.rbXML.TabIndex = 12;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            this.rbXML.CheckedChanged += new System.EventHandler(this.rbXML_CheckedChanged);
            // 
            // rbCS
            // 
            this.rbCS.AutoSize = true;
            this.rbCS.Location = new System.Drawing.Point(14, 33);
            this.rbCS.Name = "rbCS";
            this.rbCS.Size = new System.Drawing.Size(38, 16);
            this.rbCS.TabIndex = 11;
            this.rbCS.Text = "C#";
            this.rbCS.UseVisualStyleBackColor = true;
            this.rbCS.CheckedChanged += new System.EventHandler(this.rbCS_CheckedChanged);
            // 
            // rbCPP
            // 
            this.rbCPP.AutoSize = true;
            this.rbCPP.Checked = true;
            this.rbCPP.Location = new System.Drawing.Point(14, 13);
            this.rbCPP.Name = "rbCPP";
            this.rbCPP.Size = new System.Drawing.Size(44, 16);
            this.rbCPP.TabIndex = 10;
            this.rbCPP.TabStop = true;
            this.rbCPP.Text = "C++";
            this.rbCPP.UseVisualStyleBackColor = true;
            this.rbCPP.CheckedChanged += new System.EventHandler(this.rbCPP_CheckedChanged);
            // 
            // gbLayers
            // 
            this.gbLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLayers.Controls.Add(this.btnLayerMoveDown);
            this.gbLayers.Controls.Add(this.btnLayerMoveUp);
            this.gbLayers.Controls.Add(this.btnDeleteLayer);
            this.gbLayers.Controls.Add(this.btnAddLayer);
            this.gbLayers.Controls.Add(this.lbLayers);
            this.gbLayers.Location = new System.Drawing.Point(0, 0);
            this.gbLayers.Name = "gbLayers";
            this.gbLayers.Size = new System.Drawing.Size(309, 118);
            this.gbLayers.TabIndex = 0;
            this.gbLayers.TabStop = false;
            this.gbLayers.Text = "Layers";
            // 
            // btnLayerMoveDown
            // 
            this.btnLayerMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLayerMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnLayerMoveDown.Image")));
            this.btnLayerMoveDown.Location = new System.Drawing.Point(275, 66);
            this.btnLayerMoveDown.Name = "btnLayerMoveDown";
            this.btnLayerMoveDown.Size = new System.Drawing.Size(27, 21);
            this.btnLayerMoveDown.TabIndex = 10;
            this.btnLayerMoveDown.UseVisualStyleBackColor = true;
            this.btnLayerMoveDown.Click += new System.EventHandler(this.btnLayerMoveDown_Click);
            // 
            // btnLayerMoveUp
            // 
            this.btnLayerMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLayerMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLayerMoveUp.Image")));
            this.btnLayerMoveUp.Location = new System.Drawing.Point(275, 42);
            this.btnLayerMoveUp.Name = "btnLayerMoveUp";
            this.btnLayerMoveUp.Size = new System.Drawing.Size(27, 21);
            this.btnLayerMoveUp.TabIndex = 10;
            this.btnLayerMoveUp.UseVisualStyleBackColor = true;
            this.btnLayerMoveUp.Click += new System.EventHandler(this.btnLayerMoveUp_Click);
            // 
            // btnDeleteLayer
            // 
            this.btnDeleteLayer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLayer.Image")));
            this.btnDeleteLayer.Location = new System.Drawing.Point(275, 93);
            this.btnDeleteLayer.Name = "btnDeleteLayer";
            this.btnDeleteLayer.Size = new System.Drawing.Size(27, 21);
            this.btnDeleteLayer.TabIndex = 9;
            this.btnDeleteLayer.UseVisualStyleBackColor = true;
            this.btnDeleteLayer.Click += new System.EventHandler(this.btnDeleteLayer_Click);
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLayer.Image")));
            this.btnAddLayer.Location = new System.Drawing.Point(275, 15);
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(27, 21);
            this.btnAddLayer.TabIndex = 8;
            this.btnAddLayer.UseVisualStyleBackColor = true;
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // lbLayers
            // 
            this.lbLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLayers.FormattingEnabled = true;
            this.lbLayers.ItemHeight = 12;
            this.lbLayers.Location = new System.Drawing.Point(7, 15);
            this.lbLayers.Name = "lbLayers";
            this.lbLayers.Size = new System.Drawing.Size(261, 100);
            this.lbLayers.TabIndex = 7;
            this.lbLayers.SelectedIndexChanged += new System.EventHandler(this.lbLayers_SelectedIndexChanged);
            // 
            // pbMapSmall
            // 
            this.pbMapSmall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMapSmall.Location = new System.Drawing.Point(10, 18);
            this.pbMapSmall.Name = "pbMapSmall";
            this.pbMapSmall.Size = new System.Drawing.Size(175, 139);
            this.pbMapSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapSmall.TabIndex = 10;
            this.pbMapSmall.TabStop = false;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouse.Location = new System.Drawing.Point(10, 172);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(82, 13);
            this.lblMouse.TabIndex = 9;
            this.lblMouse.Text = "Mouse Position:";
            // 
            // lblMapCoordinate
            // 
            this.lblMapCoordinate.AutoSize = true;
            this.lblMapCoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapCoordinate.Location = new System.Drawing.Point(10, 159);
            this.lblMapCoordinate.Name = "lblMapCoordinate";
            this.lblMapCoordinate.Size = new System.Drawing.Size(85, 13);
            this.lblMapCoordinate.TabIndex = 8;
            this.lblMapCoordinate.Text = "Map Coordinate:";
            // 
            // menuStripDLMapEditor
            // 
            this.menuStripDLMapEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.layerToolStripMenuItem,
            this.tilesToolStripMenuItem,
            this.codeToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStripDLMapEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripDLMapEditor.Name = "menuStripDLMapEditor";
            this.menuStripDLMapEditor.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripDLMapEditor.Size = new System.Drawing.Size(1185, 24);
            this.menuStripDLMapEditor.TabIndex = 3;
            this.menuStripDLMapEditor.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadMapToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveMapToolStripMenuItem,
            this.saveMapAsToolStripMenuItem,
            this.exportMapToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitDLMapEditorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.newMapToolStripMenuItem.Text = "&New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(228, 6);
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.loadMapToolStripMenuItem.Text = "&Open Map";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.saveMapToolStripMenuItem.Text = "&Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // saveMapAsToolStripMenuItem
            // 
            this.saveMapAsToolStripMenuItem.Name = "saveMapAsToolStripMenuItem";
            this.saveMapAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveMapAsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.saveMapAsToolStripMenuItem.Text = "Save Map &As ...";
            this.saveMapAsToolStripMenuItem.Click += new System.EventHandler(this.saveMapAsToolStripMenuItem_Click);
            // 
            // exportMapToolStripMenuItem
            // 
            this.exportMapToolStripMenuItem.Name = "exportMapToolStripMenuItem";
            this.exportMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportMapToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exportMapToolStripMenuItem.Text = "&Export Map";
            this.exportMapToolStripMenuItem.Click += new System.EventHandler(this.exportMapToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // exitDLMapEditorToolStripMenuItem
            // 
            this.exitDLMapEditorToolStripMenuItem.Name = "exitDLMapEditorToolStripMenuItem";
            this.exitDLMapEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitDLMapEditorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exitDLMapEditorToolStripMenuItem.Text = "E&xit D2D Map Editor";
            this.exitDLMapEditorToolStripMenuItem.Click += new System.EventHandler(this.exitDLMapEditorToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designViewToolStripMenuItem,
            this.codeViewToolStripMenuItem,
            this.toolStripSeparator4,
            this.gridToolStripMenuItem,
            this.showWalkableToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // designViewToolStripMenuItem
            // 
            this.designViewToolStripMenuItem.Checked = true;
            this.designViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.designViewToolStripMenuItem.Name = "designViewToolStripMenuItem";
            this.designViewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D)));
            this.designViewToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.designViewToolStripMenuItem.Text = "&Design View";
            this.designViewToolStripMenuItem.Click += new System.EventHandler(this.designViewToolStripMenuItem_Click_1);
            // 
            // codeViewToolStripMenuItem
            // 
            this.codeViewToolStripMenuItem.Name = "codeViewToolStripMenuItem";
            this.codeViewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.codeViewToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.codeViewToolStripMenuItem.Text = "&Code View";
            this.codeViewToolStripMenuItem.Click += new System.EventHandler(this.codeViewToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(231, 6);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Checked = true;
            this.gridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.G)));
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.gridToolStripMenuItem.Text = "Show &Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // showWalkableToolStripMenuItem
            // 
            this.showWalkableToolStripMenuItem.Name = "showWalkableToolStripMenuItem";
            this.showWalkableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.W)));
            this.showWalkableToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.showWalkableToolStripMenuItem.Text = "Show &Walkable";
            this.showWalkableToolStripMenuItem.Click += new System.EventHandler(this.showWalkableToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.selectToolStripMenuItem.Text = "&Select";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectToolStripMenuItem
            // 
            this.deselectToolStripMenuItem.Name = "deselectToolStripMenuItem";
            this.deselectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deselectToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deselectToolStripMenuItem.Text = "&Deselect";
            this.deselectToolStripMenuItem.Click += new System.EventHandler(this.deselectToolStripMenuItem_Click);
            // 
            // layerToolStripMenuItem
            // 
            this.layerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLayerToolStripMenuItem,
            this.deleteLayerToolStripMenuItem});
            this.layerToolStripMenuItem.Name = "layerToolStripMenuItem";
            this.layerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.layerToolStripMenuItem.Text = "&Layer";
            // 
            // addLayerToolStripMenuItem
            // 
            this.addLayerToolStripMenuItem.Name = "addLayerToolStripMenuItem";
            this.addLayerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.addLayerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addLayerToolStripMenuItem.Text = "&Add Layer";
            this.addLayerToolStripMenuItem.Click += new System.EventHandler(this.addLayerToolStripMenuItem_Click);
            // 
            // deleteLayerToolStripMenuItem
            // 
            this.deleteLayerToolStripMenuItem.Name = "deleteLayerToolStripMenuItem";
            this.deleteLayerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteLayerToolStripMenuItem.Text = "&Delete Layer";
            this.deleteLayerToolStripMenuItem.Click += new System.EventHandler(this.deleteLayerToolStripMenuItem_Click);
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTileSetToolStripMenuItem,
            this.tilesEditorToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteSelectedTileToolStripMenuItem,
            this.clearTilesToolStripMenuItem});
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tilesToolStripMenuItem.Text = "&Tiles";
            // 
            // AddTileSetToolStripMenuItem
            // 
            this.AddTileSetToolStripMenuItem.Name = "AddTileSetToolStripMenuItem";
            this.AddTileSetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.AddTileSetToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.AddTileSetToolStripMenuItem.Text = "&Add Tile Set";
            this.AddTileSetToolStripMenuItem.Click += new System.EventHandler(this.addTilesToolStripMenuItem_Click);
            // 
            // tilesEditorToolStripMenuItem
            // 
            this.tilesEditorToolStripMenuItem.Name = "tilesEditorToolStripMenuItem";
            this.tilesEditorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tilesEditorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tilesEditorToolStripMenuItem.Text = "Create &Tile Set";
            this.tilesEditorToolStripMenuItem.Click += new System.EventHandler(this.tilesEditorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(185, 6);
            // 
            // deleteSelectedTileToolStripMenuItem
            // 
            this.deleteSelectedTileToolStripMenuItem.Name = "deleteSelectedTileToolStripMenuItem";
            this.deleteSelectedTileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteSelectedTileToolStripMenuItem.Text = "&Delete Selected Tile";
            this.deleteSelectedTileToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedTileToolStripMenuItem_Click);
            // 
            // clearTilesToolStripMenuItem
            // 
            this.clearTilesToolStripMenuItem.Name = "clearTilesToolStripMenuItem";
            this.clearTilesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.clearTilesToolStripMenuItem.Text = "&Clear Tiles";
            this.clearTilesToolStripMenuItem.Click += new System.EventHandler(this.clearTilesToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedLanguageToolStripMenuItem,
            this.generateCodeToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.codeToolStripMenuItem.Text = "&Code";
            // 
            // selectedLanguageToolStripMenuItem
            // 
            this.selectedLanguageToolStripMenuItem.Name = "selectedLanguageToolStripMenuItem";
            this.selectedLanguageToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.selectedLanguageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.selectedLanguageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.selectedLanguageToolStripMenuItem.Text = "&Generate C++";
            this.selectedLanguageToolStripMenuItem.Click += new System.EventHandler(this.selectedLanguageToolStripMenuItem_Click);
            // 
            // generateCodeToolStripMenuItem
            // 
            this.generateCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cArrayToolStripMenuItem,
            this.cArrayToolStripMenuItem1,
            this.actionScriptToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.xMLLiteToolStripMenuItem});
            this.generateCodeToolStripMenuItem.Name = "generateCodeToolStripMenuItem";
            this.generateCodeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.generateCodeToolStripMenuItem.Text = "Generate &Code";
            // 
            // cArrayToolStripMenuItem
            // 
            this.cArrayToolStripMenuItem.Name = "cArrayToolStripMenuItem";
            this.cArrayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D1)));
            this.cArrayToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cArrayToolStripMenuItem.Text = "&C/C++ Array";
            this.cArrayToolStripMenuItem.Click += new System.EventHandler(this.cArrayToolStripMenuItem_Click);
            // 
            // cArrayToolStripMenuItem1
            // 
            this.cArrayToolStripMenuItem1.Name = "cArrayToolStripMenuItem1";
            this.cArrayToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D2)));
            this.cArrayToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.cArrayToolStripMenuItem1.Text = "C# A&rray";
            this.cArrayToolStripMenuItem1.Click += new System.EventHandler(this.cArrayToolStripMenuItem1_Click);
            // 
            // actionScriptToolStripMenuItem
            // 
            this.actionScriptToolStripMenuItem.Name = "actionScriptToolStripMenuItem";
            this.actionScriptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D3)));
            this.actionScriptToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.actionScriptToolStripMenuItem.Text = "&ActionScript";
            this.actionScriptToolStripMenuItem.Click += new System.EventHandler(this.actionScriptToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D4)));
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.xMLToolStripMenuItem.Text = "&XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // xMLLiteToolStripMenuItem
            // 
            this.xMLLiteToolStripMenuItem.Name = "xMLLiteToolStripMenuItem";
            this.xMLLiteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D5)));
            this.xMLLiteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.xMLLiteToolStripMenuItem.Text = "XML &Lite";
            this.xMLLiteToolStripMenuItem.Click += new System.EventHandler(this.xMLLiteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.userManualToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.aboutToolStripMenuItem.Text = "&About D2D Map Editor";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.userManualToolStripMenuItem.Text = "User &Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // saveMapDialog
            // 
            this.saveMapDialog.DefaultExt = "d2d";
            this.saveMapDialog.Filter = "D2D Documents (*.d2d) |*.d2d";
            this.saveMapDialog.Title = "Save Map As";
            // 
            // openMapDialog
            // 
            this.openMapDialog.DefaultExt = "d2d";
            this.openMapDialog.Filter = "D2D Documents (*.d2d) |*.d2d";
            // 
            // gbTiles
            // 
            this.gbTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTiles.Controls.Add(this.lvTileLibrary);
            this.gbTiles.Location = new System.Drawing.Point(0, 282);
            this.gbTiles.Name = "gbTiles";
            this.gbTiles.Size = new System.Drawing.Size(208, 245);
            this.gbTiles.TabIndex = 1;
            this.gbTiles.TabStop = false;
            this.gbTiles.Text = "Tile Library";
            // 
            // lvTileLibrary
            // 
            this.lvTileLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTileLibrary.Location = new System.Drawing.Point(3, 17);
            this.lvTileLibrary.Margin = new System.Windows.Forms.Padding(0);
            this.lvTileLibrary.MultiSelect = false;
            this.lvTileLibrary.Name = "lvTileLibrary";
            this.lvTileLibrary.Size = new System.Drawing.Size(202, 225);
            this.lvTileLibrary.TabIndex = 1;
            this.lvTileLibrary.TileSize = new System.Drawing.Size(32, 32);
            this.lvTileLibrary.UseCompatibleStateImageBehavior = false;
            // 
            // pnlTiles
            // 
            this.pnlTiles.Controls.Add(this.gbTools);
            this.pnlTiles.Controls.Add(this.gbMapSmall);
            this.pnlTiles.Controls.Add(this.gbTiles);
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTiles.Location = new System.Drawing.Point(977, 24);
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Size = new System.Drawing.Size(208, 533);
            this.pnlTiles.TabIndex = 2;
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.btnToolFill);
            this.gbTools.Controls.Add(this.btnToolSelection);
            this.gbTools.Controls.Add(this.btnToolEraser);
            this.gbTools.Controls.Add(this.btnToolSelectTile);
            this.gbTools.Controls.Add(this.btnToolBrush);
            this.gbTools.Location = new System.Drawing.Point(0, 216);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(208, 61);
            this.gbTools.TabIndex = 3;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // btnToolFill
            // 
            this.btnToolFill.Image = ((System.Drawing.Image)(resources.GetObject("btnToolFill.Image")));
            this.btnToolFill.Location = new System.Drawing.Point(89, 18);
            this.btnToolFill.Name = "btnToolFill";
            this.btnToolFill.Size = new System.Drawing.Size(33, 26);
            this.btnToolFill.TabIndex = 5;
            this.btnToolFill.UseVisualStyleBackColor = true;
            this.btnToolFill.Click += new System.EventHandler(this.btnToolFill_Click);
            // 
            // btnToolSelection
            // 
            this.btnToolSelection.Image = ((System.Drawing.Image)(resources.GetObject("btnToolSelection.Image")));
            this.btnToolSelection.Location = new System.Drawing.Point(9, 18);
            this.btnToolSelection.Name = "btnToolSelection";
            this.btnToolSelection.Size = new System.Drawing.Size(33, 26);
            this.btnToolSelection.TabIndex = 4;
            this.btnToolSelection.UseVisualStyleBackColor = true;
            this.btnToolSelection.Click += new System.EventHandler(this.btnToolSelection_Click);
            // 
            // btnToolEraser
            // 
            this.btnToolEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnToolEraser.Image")));
            this.btnToolEraser.Location = new System.Drawing.Point(168, 18);
            this.btnToolEraser.Name = "btnToolEraser";
            this.btnToolEraser.Size = new System.Drawing.Size(33, 26);
            this.btnToolEraser.TabIndex = 3;
            this.btnToolEraser.UseVisualStyleBackColor = true;
            this.btnToolEraser.Click += new System.EventHandler(this.btnToolEraser_Click);
            // 
            // btnToolSelectTile
            // 
            this.btnToolSelectTile.Image = ((System.Drawing.Image)(resources.GetObject("btnToolSelectTile.Image")));
            this.btnToolSelectTile.Location = new System.Drawing.Point(128, 18);
            this.btnToolSelectTile.Name = "btnToolSelectTile";
            this.btnToolSelectTile.Size = new System.Drawing.Size(33, 26);
            this.btnToolSelectTile.TabIndex = 2;
            this.btnToolSelectTile.UseVisualStyleBackColor = true;
            this.btnToolSelectTile.Click += new System.EventHandler(this.btnToolSelectColor_Click);
            // 
            // btnToolBrush
            // 
            this.btnToolBrush.AccessibleDescription = "";
            this.btnToolBrush.BackColor = System.Drawing.SystemColors.Control;
            this.btnToolBrush.Image = ((System.Drawing.Image)(resources.GetObject("btnToolBrush.Image")));
            this.btnToolBrush.Location = new System.Drawing.Point(49, 18);
            this.btnToolBrush.Name = "btnToolBrush";
            this.btnToolBrush.Size = new System.Drawing.Size(33, 26);
            this.btnToolBrush.TabIndex = 1;
            this.btnToolBrush.Tag = "";
            this.btnToolBrush.UseVisualStyleBackColor = false;
            this.btnToolBrush.Click += new System.EventHandler(this.btnToolBrush_Click);
            // 
            // gbMapSmall
            // 
            this.gbMapSmall.Controls.Add(this.tbMapName);
            this.gbMapSmall.Controls.Add(this.lblMouse);
            this.gbMapSmall.Controls.Add(this.pbMapSmall);
            this.gbMapSmall.Controls.Add(this.lblMapCoordinate);
            this.gbMapSmall.Controls.Add(this.lblMapName);
            this.gbMapSmall.Location = new System.Drawing.Point(0, 0);
            this.gbMapSmall.Name = "gbMapSmall";
            this.gbMapSmall.Size = new System.Drawing.Size(208, 210);
            this.gbMapSmall.TabIndex = 2;
            this.gbMapSmall.TabStop = false;
            this.gbMapSmall.Text = "Map";
            // 
            // tbMapName
            // 
            this.tbMapName.Location = new System.Drawing.Point(73, 187);
            this.tbMapName.Name = "tbMapName";
            this.tbMapName.Size = new System.Drawing.Size(126, 21);
            this.tbMapName.TabIndex = 11;
            this.tbMapName.TextChanged += new System.EventHandler(this.tbMapName_TextChanged);
            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.Location = new System.Drawing.Point(5, 190);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(68, 12);
            this.lblMapName.TabIndex = 8;
            this.lblMapName.Text = "Map Name";
            // 
            // contextMenuStripTile
            // 
            this.contextMenuStripTile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWalkable,
            this.toolStripMenuItemDelete});
            this.contextMenuStripTile.Name = "contextMenuStripTile";
            this.contextMenuStripTile.Size = new System.Drawing.Size(123, 48);
            // 
            // toolStripMenuItemWalkable
            // 
            this.toolStripMenuItemWalkable.Checked = true;
            this.toolStripMenuItemWalkable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemWalkable.Name = "toolStripMenuItemWalkable";
            this.toolStripMenuItemWalkable.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItemWalkable.Text = "Walkable";
            this.toolStripMenuItemWalkable.Click += new System.EventHandler(this.toolStripMenuItemWalkable_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItemDelete.Text = "Delete";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // ilTileImages
            // 
            this.ilTileImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ilTileImages.ImageSize = new System.Drawing.Size(32, 32);
            this.ilTileImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // D2DMapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 678);
            this.Controls.Add(this.pnlTiles);
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.menuStripDLMapEditor);
            this.Controls.Add(this.pnlDesign);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripDLMapEditor;
            this.MinimumSize = new System.Drawing.Size(1192, 712);
            this.Name = "D2DMapEditor";
            this.Text = "Map Editor";
            this.pnlDesign.ResumeLayout(false);
            this.tctrlDesign.ResumeLayout(false);
            this.tpgDesign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.tpgCode.ResumeLayout(false);
            this.tpgCode.PerformLayout();
            this.pnlProperties.ResumeLayout(false);
            this.gbLayerProperties.ResumeLayout(false);
            this.gbLayerProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLayerAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLayerWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLayerHeight)).EndInit();
            this.gbTileProperties.ResumeLayout(false);
            this.gbTileProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTile)).EndInit();
            this.gbCode.ResumeLayout(false);
            this.gbCode.PerformLayout();
            this.gbLayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMapSmall)).EndInit();
            this.menuStripDLMapEditor.ResumeLayout(false);
            this.menuStripDLMapEditor.PerformLayout();
            this.gbTiles.ResumeLayout(false);
            this.pnlTiles.ResumeLayout(false);
            this.gbTools.ResumeLayout(false);
            this.gbMapSmall.ResumeLayout(false);
            this.gbMapSmall.PerformLayout();
            this.contextMenuStripTile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.GroupBox gbLayers;
        private System.Windows.Forms.TabControl tctrlDesign;
        private System.Windows.Forms.TabPage tpgDesign;
        private System.Windows.Forms.Label lblLayerHeight;
        private System.Windows.Forms.Label lblLayerWidth;
        private System.Windows.Forms.Button btnUpdateLayer;
        public System.Windows.Forms.NumericUpDown nudLayerHeight;
        public System.Windows.Forms.NumericUpDown nudLayerWidth;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.MenuStrip menuStripDLMapEditor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitDLMapEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.NumericUpDown nudTileHeight;
        public System.Windows.Forms.NumericUpDown nudTileWidth;
        private System.Windows.Forms.Label lblLayerTileHeight;
        private System.Windows.Forms.Label lblLayerTileWidth;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTileSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTilesToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLoadTiles;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Label lblMapCoordinate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveMapAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveMapDialog;
        private System.Windows.Forms.OpenFileDialog openMapDialog;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cArrayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.TabPage tpgCode;
        private System.Windows.Forms.PictureBox pbMapSmall;
        private System.Windows.Forms.GroupBox gbTiles;
        private System.Windows.Forms.GroupBox gbTileProperties;
        private System.Windows.Forms.Button btnUpdateTile;
        private System.Windows.Forms.CheckBox cbTileWalkable;
        private System.Windows.Forms.TextBox tbTileName;
        private System.Windows.Forms.Label lblTileIDValue;
        private System.Windows.Forms.Label lblTileName;
        private System.Windows.Forms.Label lblTileID;
        private System.Windows.Forms.PictureBox pbSelectedTile;
        private System.Windows.Forms.Panel pnlTiles;
        private System.Windows.Forms.GroupBox gbMapSmall;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeViewToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbCode;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbCS;
        private System.Windows.Forms.RadioButton rbCPP;
        private System.Windows.Forms.ToolStripMenuItem selectedLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.Label lblLayerName;
        public System.Windows.Forms.TextBox tbLayerName;
        private System.Windows.Forms.ToolStripMenuItem showWalkableToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWalkable;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button btnToolBrush;
        private System.Windows.Forms.Button btnToolEraser;
        private System.Windows.Forms.Button btnToolSelectTile;
        private System.Windows.Forms.ToolStripMenuItem tilesEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button btnToolSelection;
        private System.Windows.Forms.Button btnToolFill;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbAS;
        private System.Windows.Forms.ToolStripMenuItem actionScriptToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbLayerProperties;
        private System.Windows.Forms.ListBox lbLayers;
        private System.Windows.Forms.Button btnAddLayer;
        private System.Windows.Forms.Button btnDeleteLayer;
        private System.Windows.Forms.Label lblLayerAlpha;
        private System.Windows.Forms.TrackBar tbarLayerAlpha;
        private System.Windows.Forms.Button btnLayerMoveUp;
        private System.Windows.Forms.Button btnLayerMoveDown;
        private System.Windows.Forms.CheckBox cbLayerVisible;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.ToolStripMenuItem layerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLayerToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMapName;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.Label lblLayerId;
        private System.Windows.Forms.Label lblLayerIdLabel;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMapToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbXMLLite;
        private System.Windows.Forms.ToolStripMenuItem xMLLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.ComboBox cbTileType;
        private System.Windows.Forms.ListView lvTileLibrary;
        private System.Windows.Forms.ImageList ilTileImages;
    }
}

