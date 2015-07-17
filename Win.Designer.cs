namespace Hex1
{
    partial class Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlShape = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOrientationFlat = new System.Windows.Forms.RadioButton();
            this.rbOrientationPointy = new System.Windows.Forms.RadioButton();
            this.nMapHeight = new System.Windows.Forms.NumericUpDown();
            this.nMapWidth = new System.Windows.Forms.NumericUpDown();
            this.nCellWidth = new System.Windows.Forms.NumericUpDown();
            this.nCellHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chains = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMouseLoc = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.nOriginX = new System.Windows.Forms.NumericUpDown();
            this.nOriginY = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CellMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CellMenuSetStart = new System.Windows.Forms.ToolStripMenuItem();
            this.CellMenuSetEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCellWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCellHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOriginX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOriginY)).BeginInit();
            this.CellMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.ContextMenuStrip = this.CellMenu;
            this.pnlCanvas.Location = new System.Drawing.Point(210, 12);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(600, 600);
            this.pnlCanvas.TabIndex = 25;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Map Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Q";
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(16, 589);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(75, 23);
            this.btnRedraw.TabIndex = 24;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Visible = false;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Shape";
            // 
            // ddlShape
            // 
            this.ddlShape.FormattingEnabled = true;
            this.ddlShape.Items.AddRange(new object[] {
            "Rectangle",
            "Parallelogram",
            "Triangle",
            "Hexagon"});
            this.ddlShape.Location = new System.Drawing.Point(28, 96);
            this.ddlShape.Name = "ddlShape";
            this.ddlShape.Size = new System.Drawing.Size(121, 21);
            this.ddlShape.TabIndex = 3;
            this.ddlShape.SelectedIndexChanged += new System.EventHandler(this.ddlShape_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cell Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Orientation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOrientationFlat);
            this.panel1.Controls.Add(this.rbOrientationPointy);
            this.panel1.Location = new System.Drawing.Point(27, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 60);
            this.panel1.TabIndex = 23;
            // 
            // rbOrientationFlat
            // 
            this.rbOrientationFlat.AutoSize = true;
            this.rbOrientationFlat.Location = new System.Drawing.Point(13, 31);
            this.rbOrientationFlat.Name = "rbOrientationFlat";
            this.rbOrientationFlat.Size = new System.Drawing.Size(64, 17);
            this.rbOrientationFlat.TabIndex = 1;
            this.rbOrientationFlat.TabStop = true;
            this.rbOrientationFlat.Text = "Flat Top";
            this.rbOrientationFlat.UseVisualStyleBackColor = true;
            // 
            // rbOrientationPointy
            // 
            this.rbOrientationPointy.AutoSize = true;
            this.rbOrientationPointy.Location = new System.Drawing.Point(13, 8);
            this.rbOrientationPointy.Name = "rbOrientationPointy";
            this.rbOrientationPointy.Size = new System.Drawing.Size(76, 17);
            this.rbOrientationPointy.TabIndex = 0;
            this.rbOrientationPointy.TabStop = true;
            this.rbOrientationPointy.Text = "Pointy Top";
            this.rbOrientationPointy.UseVisualStyleBackColor = true;
            this.rbOrientationPointy.CheckedChanged += new System.EventHandler(this.rbOrientationPointy_CheckedChanged);
            // 
            // nMapHeight
            // 
            this.nMapHeight.Location = new System.Drawing.Point(64, 261);
            this.nMapHeight.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nMapHeight.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.nMapHeight.Name = "nMapHeight";
            this.nMapHeight.Size = new System.Drawing.Size(55, 20);
            this.nMapHeight.TabIndex = 15;
            this.nMapHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMapHeight.ValueChanged += new System.EventHandler(this.data_Changed);
            // 
            // nMapWidth
            // 
            this.nMapWidth.Location = new System.Drawing.Point(64, 238);
            this.nMapWidth.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nMapWidth.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.nMapWidth.Name = "nMapWidth";
            this.nMapWidth.Size = new System.Drawing.Size(55, 20);
            this.nMapWidth.TabIndex = 12;
            this.nMapWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMapWidth.ValueChanged += new System.EventHandler(this.data_Changed);
            // 
            // nCellWidth
            // 
            this.nCellWidth.Location = new System.Drawing.Point(78, 321);
            this.nCellWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nCellWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCellWidth.Name = "nCellWidth";
            this.nCellWidth.Size = new System.Drawing.Size(41, 20);
            this.nCellWidth.TabIndex = 18;
            this.nCellWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCellWidth.ValueChanged += new System.EventHandler(this.data_Changed);
            // 
            // nCellHeight
            // 
            this.nCellHeight.Location = new System.Drawing.Point(78, 344);
            this.nCellHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nCellHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCellHeight.Name = "nCellHeight";
            this.nCellHeight.Size = new System.Drawing.Size(41, 20);
            this.nCellHeight.TabIndex = 21;
            this.nCellHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCellHeight.ValueChanged += new System.EventHandler(this.data_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Width";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.chains;
            this.button1.Location = new System.Drawing.Point(126, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 38);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chains
            // 
            this.chains.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chains.ImageStream")));
            this.chains.TransparentColor = System.Drawing.Color.Transparent;
            this.chains.Images.SetKeyName(0, "chain_open.png");
            this.chains.Images.SetKeyName(1, "chain_closed.png");
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.chains;
            this.button2.Location = new System.Drawing.Point(127, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 38);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mouse Location";
            // 
            // lblMouseLoc
            // 
            this.lblMouseLoc.Location = new System.Drawing.Point(25, 38);
            this.lblMouseLoc.Name = "lblMouseLoc";
            this.lblMouseLoc.Size = new System.Drawing.Size(128, 17);
            this.lblMouseLoc.TabIndex = 1;
            this.lblMouseLoc.Text = "Q: R: S:";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.chains;
            this.button3.Location = new System.Drawing.Point(126, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 38);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nOriginX
            // 
            this.nOriginX.Location = new System.Drawing.Point(64, 162);
            this.nOriginX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nOriginX.Name = "nOriginX";
            this.nOriginX.Size = new System.Drawing.Size(55, 20);
            this.nOriginX.TabIndex = 6;
            this.nOriginX.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nOriginX.ValueChanged += new System.EventHandler(this.data_Changed);
            // 
            // nOriginY
            // 
            this.nOriginY.Location = new System.Drawing.Point(64, 185);
            this.nOriginY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nOriginY.Name = "nOriginY";
            this.nOriginY.Size = new System.Drawing.Size(55, 20);
            this.nOriginY.TabIndex = 9;
            this.nOriginY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nOriginY.ValueChanged += new System.EventHandler(this.data_Changed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Origin";
            // 
            // CellMenu
            // 
            this.CellMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.CellMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CellMenuSetStart,
            this.CellMenuSetEnd});
            this.CellMenu.Name = "CellMenu";
            this.CellMenu.ShowImageMargin = false;
            this.CellMenu.Size = new System.Drawing.Size(128, 70);
            this.CellMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CellMenu_Opening);
            // 
            // CellMenuSetStart
            // 
            this.CellMenuSetStart.Name = "CellMenuSetStart";
            this.CellMenuSetStart.Size = new System.Drawing.Size(127, 22);
            this.CellMenuSetStart.Text = "Set Start";
            // 
            // CellMenuSetEnd
            // 
            this.CellMenuSetEnd.Name = "CellMenuSetEnd";
            this.CellMenuSetEnd.Size = new System.Drawing.Size(117, 22);
            this.CellMenuSetEnd.Text = "Set End";
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 623);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nOriginX);
            this.Controls.Add(this.nOriginY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMouseLoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nCellWidth);
            this.Controls.Add(this.nCellHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nMapWidth);
            this.Controls.Add(this.nMapHeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlShape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Win";
            this.Text = "Hex Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCellWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCellHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOriginX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOriginY)).EndInit();
            this.CellMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlShape;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOrientationFlat;
        private System.Windows.Forms.RadioButton rbOrientationPointy;
        private System.Windows.Forms.NumericUpDown nMapHeight;
        private System.Windows.Forms.NumericUpDown nMapWidth;
        private System.Windows.Forms.NumericUpDown nCellWidth;
        private System.Windows.Forms.NumericUpDown nCellHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList chains;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMouseLoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nOriginX;
        private System.Windows.Forms.NumericUpDown nOriginY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip CellMenu;
        private System.Windows.Forms.ToolStripMenuItem CellMenuSetStart;
        private System.Windows.Forms.ToolStripMenuItem CellMenuSetEnd;
    }
}

