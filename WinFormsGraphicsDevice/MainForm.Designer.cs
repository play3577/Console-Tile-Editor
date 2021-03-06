namespace WinFormsGraphicsDevice
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHRAsTileSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMapSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.paletteControl1 = new WinFormsGraphicsDevice.PaletteControl();
            this.chrViewControl1 = new WinFormsGraphicsDevice.CHRViewControl();
            this.filteredPictureBox1 = new WinFormsGraphicsDevice.FilteredPictureBox();
            this.colorControl1 = new WinFormsGraphicsDevice.ColorControl();
            this.mapEditControl2 = new WinFormsGraphicsDevice.MapEditControl();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHRAsTileSetToolStripMenuItem,
            this.paletteToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // cHRAsTileSetToolStripMenuItem
            // 
            this.cHRAsTileSetToolStripMenuItem.Name = "cHRAsTileSetToolStripMenuItem";
            this.cHRAsTileSetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cHRAsTileSetToolStripMenuItem.Text = "CHR as tile set";
            this.cHRAsTileSetToolStripMenuItem.Click += new System.EventHandler(this.cHRAsTileSetToolStripMenuItem_Click);
            // 
            // paletteToolStripMenuItem
            // 
            this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
            this.paletteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.paletteToolStripMenuItem.Text = "Palette";
            this.paletteToolStripMenuItem.Click += new System.EventHandler(this.paletteToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMapSizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setMapSizeToolStripMenuItem
            // 
            this.setMapSizeToolStripMenuItem.Name = "setMapSizeToolStripMenuItem";
            this.setMapSizeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.setMapSizeToolStripMenuItem.Text = "Set Map Size";
            this.setMapSizeToolStripMenuItem.Click += new System.EventHandler(this.setMapSizeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chrViewControl1);
            this.groupBox1.Location = new System.Drawing.Point(548, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 292);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHR Tile Set";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mapEditControl2);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 512);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map Editor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filteredPictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(674, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 156);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Metatiles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(548, 344);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(107, 166);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meta Tile Group";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Del.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Color Table";
            // 
            // paletteControl1
            // 
            this.paletteControl1.Location = new System.Drawing.Point(548, 633);
            this.paletteControl1.Name = "paletteControl1";
            this.paletteControl1.SetCHRView = this.chrViewControl1;
            this.paletteControl1.Size = new System.Drawing.Size(256, 96);
            this.paletteControl1.TabIndex = 14;
            this.paletteControl1.Text = "paletteControl1";
            // 
            // chrViewControl1
            // 
            this.chrViewControl1.Location = new System.Drawing.Point(6, 20);
            this.chrViewControl1.Name = "chrViewControl1";
            this.chrViewControl1.SetPictureBox = this.filteredPictureBox1;
            this.chrViewControl1.Size = new System.Drawing.Size(256, 256);
            this.chrViewControl1.TabIndex = 0;
            this.chrViewControl1.Text = "chrViewControl1";
            // 
            // filteredPictureBox1
            // 
            this.filteredPictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.filteredPictureBox1.Location = new System.Drawing.Point(6, 19);
            this.filteredPictureBox1.Name = "filteredPictureBox1";
            this.filteredPictureBox1.Size = new System.Drawing.Size(128, 128);
            this.filteredPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filteredPictureBox1.TabIndex = 15;
            this.filteredPictureBox1.TabStop = false;
            this.filteredPictureBox1.Click += new System.EventHandler(this.filteredPictureBox1_Click);
            // 
            // colorControl1
            // 
            this.colorControl1.Location = new System.Drawing.Point(548, 531);
            this.colorControl1.Name = "colorControl1";
            this.colorControl1.SetPaletteView = this.paletteControl1;
            this.colorControl1.Size = new System.Drawing.Size(256, 96);
            this.colorControl1.TabIndex = 12;
            this.colorControl1.Text = "paletteControl1";
            // 
            // mapEditControl2
            // 
            this.mapEditControl2.Location = new System.Drawing.Point(12, 20);
            this.mapEditControl2.Name = "mapEditControl2";
            this.mapEditControl2.SetCHRView = this.chrViewControl1;
            this.mapEditControl2.Size = new System.Drawing.Size(512, 480);
            this.mapEditControl2.TabIndex = 0;
            this.mapEditControl2.Text = "mapEditControl2";
            this.mapEditControl2.Click += new System.EventHandler(this.mapEditControl2_Click);
            this.mapEditControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapEditControl2_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 748);
            this.Controls.Add(this.paletteControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Multiple Console Map Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHRAsTileSetToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private ColorControl colorControl1;
        private CHRViewControl spinningTriangleControl1;
        private System.Windows.Forms.Label label2;
        private PaletteControl paletteControl1;
        private System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
        private MapEditControl mapEditControl2;
        private CHRViewControl chrViewControl1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMapSizeToolStripMenuItem;
        private FilteredPictureBox filteredPictureBox1;

    }
}

