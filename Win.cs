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
        public LineData lineData;
        // ++++++++++++++++++++++++++++++++++++++++++++


        public Win()
        {
            InitializeComponent();

            // ++++++++++++++++++++++++++++++++++++++++++++
            this.ddlShape.SelectedIndex = 0;
            this.rbOrientationPointy.Select();
            // ++++++++++++++++++++++++++++++++++++++++++++

        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics formGraphics = pnlCanvas.CreateGraphics();

            //
            // Dot in the middle
            //
            SolidBrush myBrush = new SolidBrush(Color.Red);
            formGraphics.FillEllipse(myBrush, new Rectangle((int)nOriginX.Value-1, (int)nOriginY.Value-1, 3, 3));

            //+++++++++++++++++++++++++++++++++++++++++++++++++++
            if (gameMap != null)
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

        private void data_Changed(object sender, EventArgs e)
        {
            if (button1.ImageIndex == 1)
            {
                nMapHeight.Value = nMapWidth.Value;
            }
            if (button2.ImageIndex == 1)
            {
                nCellHeight.Value = nCellWidth.Value;
            }
            if (button3.ImageIndex == 1)
            {
                nOriginY.Value = nOriginX.Value;
            }

            Redraw();
        }

        private void Redraw()
        {
            mapSize.Y = Convert.ToUInt16(nMapHeight.Value);
            mapSize.X = Convert.ToUInt16(nMapWidth.Value);
            cellSize.Y = Convert.ToDouble(nCellHeight.Value);
            cellSize.X = Convert.ToDouble(nCellWidth.Value);
            mapOrigin.X = Convert.ToDouble(nOriginX.Value);
            mapOrigin.Y = Convert.ToDouble(nOriginY.Value);


            gameMap = null;
            gameMap = new Map(mapSize, GetOrientation(), cellSize, mapOrigin, GetShape());
            gameMap.Generate();
            pnlCanvas.Invalidate();
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            Redraw();
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

        private void ddlShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            Redraw();
        }

        private void rbOrientationPointy_CheckedChanged(object sender, EventArgs e)
        {
            Redraw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ImageIndex ^= 1;
            nMapHeight.Enabled = !nMapHeight.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ImageIndex ^= 1;
            nCellHeight.Enabled = !nCellHeight.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.ImageIndex ^= 1;
            nOriginY.Enabled = !nOriginY.Enabled;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Hex hex = Hex.Round(gameMap.mapLayout.PixelToHex(e.Location));
            if (gameMap.ContainsHex(hex))
            {
                lblMouseLoc.Text = string.Format("QRS: {0},{1},{2}", hex.q, hex.r, hex.s);
                lineData.isOverMap = true;
            }
            else
            {
                lblMouseLoc.Text = "";
                lineData.isOverMap = false;
            }
        }

        private void CellMenu_Opening(object sender, CancelEventArgs e)
        {
            CellMenuSetStart.Enabled = lineData.isOverMap && !lineData.haveStart;
            CellMenuSetEnd.Enabled = lineData.isOverMap && lineData.haveStart;
        }

    }

    public struct LineData
    {
        public bool isOverMap;
        public bool haveStart;
        public bool haveEnd;
        public Hex hexStart;
        public Hex hexEnd;
    }


}
