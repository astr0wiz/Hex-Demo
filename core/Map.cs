using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Hex1.core
{
    public enum MapShapes
    {
        Parallelogram,
        Triangle,
        Hexagon,
        Rectangle
    }
    public class Map
    {
        private PointU16 _mapSize;

        public UInt16 width
        {
            get { return _mapSize.X; }
        }
        public UInt16 height
        {
            get { return _mapSize.Y; }
        }
        public UInt16 radius
        {
            get { return (UInt16)(Math.Max(_mapSize.X, _mapSize.Y) >> 1); }
        }
        public UInt16 maxsize
        {
            get { return (UInt16)(Math.Max(Math.Abs(_mapSize.X), Math.Abs(_mapSize.Y))); }
        }

        public Layout mapLayout;
        public List<Hex> hexes;
        private MapShapes _shape = MapShapes.Rectangle;

        public Map(PointU16 mapSize, Orientation orientation, PointD cellSize, PointD origin, MapShapes mapShape = MapShapes.Rectangle)
        {
            _mapSize = mapSize;
            _shape = mapShape;
            mapLayout = new Layout(orientation, cellSize, origin);
            hexes = new List<Hex>();
        }

        public void Generate()
        {
            short q_, r_, s_;

            switch (_shape)
            {
                case MapShapes.Rectangle:
                    for (short X = 0; X < height; X++)
                    {
                        short X_offset = (short)(X >> 1);
                        for (short Y = (short)(-X_offset); Y < width - X_offset; Y++)
                        {

                            q_ = mapLayout._Orientation.type == OrientationType.PointyTop ? Y : X;
                            r_ = mapLayout._Orientation.type == OrientationType.PointyTop ? X : Y;
                            InsertCell(q_, r_);
                        }
                    }
                    break;
                case MapShapes.Hexagon:
                    for (short q = (short)(-radius); q <= radius; q++)
                    {
                        short r1 = (short)(Math.Max(-radius, -q - radius));
                        short r2 = (short)(Math.Min(radius, -q + radius));
                        for (short r = r1; r <= r2; r++)
                        {
                            InsertCell(q, r);
                        }
                    }
                    break;
                case MapShapes.Triangle:
                    switch (mapLayout._Orientation.type)
                    {
                        case OrientationType.PointyTop:
                            for (short q = 0; q <= maxsize; q++)
                            {
                                for (short r = 0; r <= maxsize - q; r++)
                                {
                                    InsertCell(q, r);
                                }
                            }
                            break;
                        case OrientationType.FlatTop:
                            for (short q = 0; q <= maxsize; q++)
                            {
                                //for (short r = (short)(maxsize - q); r <= maxsize; r++)
                                for (short r = 0; r <= maxsize - q; r++)
                                {
                                    q_ = q;
                                    r_ = r;
                                    s_ = (short)(-q - (-q - r));
                                    InsertCell(q_, r_);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case MapShapes.Parallelogram:
                    switch (mapLayout._Orientation.type)
                    {
                        case OrientationType.FlatTop:
                            for (short r = 0; r < maxsize; r++)
                            {
                                for (short s = 0; s < maxsize; s++)
                                {
                                    q_ = (short)(-s - r);
                                    r_ = r;
                                    s_ = s;
                                    InsertCell(q_, r_);
                                }
                            }
                            break;
                        case OrientationType.PointyTop:
                            for (short s = 0; s < maxsize; s++)
                            {
                                for (short q = 0; q < maxsize; q++)
                                {
                                    InsertCell(q, (short)(-s - q));
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public void InsertCell(short q, short r)
        {
            hexes.Add(new Hex(q, r));
        }

        public bool ContainsHex(Hex hex)
        {
            foreach (Hex maphex in hexes)
            {
                if (maphex == hex)
                {
                    return true;
                }
            }
            return false;
        }

        public void DrawWin(Graphics graphics)
        {
            Pen pen = new Pen(Color.Green);
            Pen labelPen = new Pen(Color.Blue);
            foreach (Hex hex in hexes)
            {
                List<Point> shapeDrawn = mapLayout.PolygonCorners(hex);
                graphics.DrawPolygon(pen, shapeDrawn.ToArray());
                //
                Point rect_origin = shapeDrawn[0];
                //
                if (mapLayout._Orientation.type == OrientationType.FlatTop)
                {
                    rect_origin.X -= (int)(mapLayout.CellSize.X * 1.8);
                    rect_origin.Y -= (int)(mapLayout.CellSize.Y * 0.3);
                }
                else
                {
                    rect_origin.X -= (int)(mapLayout.CellSize.X * 1.75);
                    rect_origin.Y -= (int)(mapLayout.CellSize.Y * 0.82);
                }
                //
                int fontSize = (int)(mapLayout.CellSize.X * 0.30);
                if (fontSize > 0)
                {
                    Font labelFont = new Font("Arial", fontSize); //new Font(FontFamily.GenericSansSerif, fontSize);
                    SolidBrush labelBrush = new SolidBrush(Color.Black);
                    Rectangle rect = new Rectangle(rect_origin.X, rect_origin.Y, (int)(mapLayout.CellSize.X * 1.75), (int)(mapLayout.CellSize.Y * 0.60));
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    graphics.DrawString(string.Format("{0},{1},{2}", hex.q, hex.r, hex.s), labelFont, labelBrush, rect, format);
                }
            }
            pen.Dispose();
        }
    }
}
