using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Hex1.core;

namespace Hex1
{
    public partial class Win : Form
    {
        // ++++++++++++++++++++++++++++++++++++++++++++
        public Map gameMap;
        public PointD cellSize;
        public PointD mapOrigin;
        public PointU16 mapSize;
        // ++++++++++++++++++++++++++++++++++++++++++++


        public Win()
        {
            InitializeComponent();

            // ++++++++++++++++++++++++++++++++++++++++++++

            this.txtWidth.GotFocus += new System.EventHandler(this.text_Focus);
            this.txtWidth.Click += new System.EventHandler(this.text_Focus);
            this.txtWidth.Leave += new System.EventHandler(this.text_Unfocus);
            // --------------------
            this.txtHeight.GotFocus += new System.EventHandler(this.text_Focus);
            this.txtHeight.Click += new System.EventHandler(this.text_Focus);
            this.txtHeight.Leave += new System.EventHandler(this.text_Unfocus);
            // --------------------
            this.txtCellHeight.GotFocus += new System.EventHandler(this.text_Focus);
            this.txtCellHeight.Click += new System.EventHandler(this.text_Focus);
            this.txtCellHeight.Leave += new System.EventHandler(this.text_Unfocus);
            // --------------------
            this.txtCellWidth.GotFocus += new System.EventHandler(this.text_Focus);
            this.txtCellWidth.Click += new System.EventHandler(this.text_Focus);
            this.txtCellWidth.Leave += new System.EventHandler(this.text_Unfocus);
            // --------------------

            // ++++++++++++++++++++++++++++++++++++++++++++
            this.ddlShape.SelectedIndex = 0;
            this.txtWidth.Text = "0";
            this.txtHeight.Text = "0";
            this.txtCellWidth.Text = "0";
            this.txtCellHeight.Text = "0";
            this.rbOrientationPointy.Select();
            // ++++++++++++++++++++++++++++++++++++++++++++

            cellSize.X = 20;
            cellSize.Y = 20;
            mapOrigin.X = 300;
            mapOrigin.Y = 300;

        }

        private void Win_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics formGraphics = pnlCanvas.CreateGraphics();

            //
            // Dot in the middle
            //
            SolidBrush myBrush = new SolidBrush(Color.Red);
            formGraphics.FillEllipse(myBrush, new Rectangle(299, 299, 3, 3));

            //+++++++++++++++++++++++++++++++++++++++++++++++++++
            if(gameMap != null)
                gameMap.DrawWin(formGraphics);
            //+++++++++++++++++++++++++++++++++++++++++++++++++++


            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private ushort GetValueU16(string txt)
        {
            ushort val;
            ushort.TryParse(txt, out val);
            return val;
        }

        private void text_Focus(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                (sender as MaskedTextBox).SelectAll();
            }
            else if (sender is TextBox)
            {
                (sender as TextBox).SelectAll();
            }
        }

        private void text_Unfocus(object sender, EventArgs e)
        {

            if (sender is MaskedTextBox)
            {
                (sender as MaskedTextBox).SelectAll();
                ushort unitVal=GetValueU16((sender as MaskedTextBox).Text);
                if (sender == txtHeight)
                {
                    txtHeight.Text = unitVal.ToString();
                    mapSize.Y = unitVal;
                }
                else if (sender == txtWidth)
                {
                    txtWidth.Text = unitVal.ToString();
                    mapSize.X = unitVal;
                }
                else if (sender == txtCellHeight)
                {
                    if (unitVal == 0) unitVal = 1;
                    txtCellHeight.Text = unitVal.ToString();
                    cellSize.Y = unitVal;
                }
                else if (sender == txtCellWidth)
                {
                    if (unitVal == 0) unitVal = 1;
                    txtCellWidth.Text = unitVal.ToString();
                    cellSize.X = unitVal;
                }
            }
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            gameMap = new Map(mapSize, GetOrientation(), cellSize, mapOrigin, GetShape());
            gameMap.Generate();
            pnlCanvas.Invalidate();
        }

        private MapShapes GetShape()
        {
            switch (ddlShape.SelectedIndex)
            {
                case 0:
                    return MapShapes.Rectangle;
                case 1:
                    return MapShapes.Parallelogram;
                case 2:
                    return MapShapes.Triangle;
                case 3:
                    return MapShapes.Hexagon;
                default:
                    return MapShapes.Rectangle;
            }
        }

        private Hex1.core.Orientation GetOrientation()
        {
            if (rbOrientationPointy.Checked)
            {
                return Utils.LayoutPointy();
            }
            else
            {
                return Utils.LayoutFlat();
            }
        }

    }
}
