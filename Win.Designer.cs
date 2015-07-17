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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.MaskedTextBox();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlShape = new System.Windows.Forms.ComboBox();
            this.txtCellHeight = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCellWidth = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOrientationFlat = new System.Windows.Forms.RadioButton();
            this.rbOrientationPointy = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(210, 12);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(600, 600);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(55, 86);
            this.txtWidth.Mask = "0000";
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(32, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(16, 589);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(75, 23);
            this.btnRedraw.TabIndex = 6;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(146, 86);
            this.txtHeight.Mask = "0000";
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(32, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.Enter += new System.EventHandler(this.text_Focus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
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
            this.ddlShape.Location = new System.Drawing.Point(56, 12);
            this.ddlShape.Name = "ddlShape";
            this.ddlShape.Size = new System.Drawing.Size(121, 21);
            this.ddlShape.TabIndex = 8;
            // 
            // txtCellHeight
            // 
            this.txtCellHeight.Location = new System.Drawing.Point(137, 155);
            this.txtCellHeight.Mask = "000";
            this.txtCellHeight.Name = "txtCellHeight";
            this.txtCellHeight.Size = new System.Drawing.Size(25, 20);
            this.txtCellHeight.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Height";
            // 
            // txtCellWidth
            // 
            this.txtCellWidth.Location = new System.Drawing.Point(55, 155);
            this.txtCellWidth.Mask = "000";
            this.txtCellWidth.Name = "txtCellWidth";
            this.txtCellWidth.Size = new System.Drawing.Size(25, 20);
            this.txtCellWidth.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cell Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Orientation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOrientationFlat);
            this.panel1.Controls.Add(this.rbOrientationPointy);
            this.panel1.Location = new System.Drawing.Point(27, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 60);
            this.panel1.TabIndex = 16;
            // 
            // rbOrientationFlat
            // 
            this.rbOrientationFlat.AutoSize = true;
            this.rbOrientationFlat.Location = new System.Drawing.Point(13, 31);
            this.rbOrientationFlat.Name = "rbOrientationFlat";
            this.rbOrientationFlat.Size = new System.Drawing.Size(64, 17);
            this.rbOrientationFlat.TabIndex = 17;
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
            this.rbOrientationPointy.TabIndex = 16;
            this.rbOrientationPointy.TabStop = true;
            this.rbOrientationPointy.Text = "Pointy Top";
            this.rbOrientationPointy.UseVisualStyleBackColor = true;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCellHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCellWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlShape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Win";
            this.Text = "Hex 01";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Win_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtWidth;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlShape;
        private System.Windows.Forms.MaskedTextBox txtCellHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCellWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOrientationFlat;
        private System.Windows.Forms.RadioButton rbOrientationPointy;
    }
}

