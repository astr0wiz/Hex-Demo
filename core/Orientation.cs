using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Hex1.core
{
    public enum OrientationType
    {
        PointyTop,
        FlatTop
    }

    public class Orientation
    {
        private OrientationType _type;
        public OrientationType type { get { return _type; } }

        private double[] _matForward;
        public double[] MatForward { get { return _matForward; } set { _matForward = value; } }

        private double[] _matBackward;
        public double[] MatBackward { get { return _matBackward; } set { _matBackward = value; } }

        private double _startAngleFactor;
        public double StartAngleFactor { get { return _startAngleFactor; } set { _startAngleFactor = value; } }

        //
        // Two ways to access the data: via a matrix and via named elements.
        // Using named elements elsewhere in the code affords type checking and makes debugging a bit simpler.
        //
        public double f0 { get { return _matForward[0]; } set { _matForward[0] = value; } }
        public double f1 { get { return _matForward[1]; } set { _matForward[1] = value; } }
        public double f2 { get { return _matForward[2]; } set { _matForward[2] = value; } }
        public double f3 { get { return _matForward[3]; } set { _matForward[3] = value; } }

        public double b0 { get { return _matBackward[0]; } set { _matBackward[0] = value; } }
        public double b1 { get { return _matBackward[1]; } set { _matBackward[1] = value; } }
        public double b2 { get { return _matBackward[2]; } set { _matBackward[2] = value; } }
        public double b3 { get { return _matBackward[3]; } set { _matBackward[3] = value; } }

        public Orientation()
        {
            _matForward = new double[4];
            _matBackward = new double[4];
            _startAngleFactor = 0;
            _type = OrientationType.PointyTop;
        }

        public Orientation(double f0_, double f1_, double f2_, double f3_, double b0_, double b1_, double b2_, double b3_, double startAngleFactor_,OrientationType type_)
        {
            _matForward = new double[4] { f0_, f1_, f2_, f3_ };
            _matBackward = new double[4] { b0_, b1_, b2_, b3_ };
            _startAngleFactor = startAngleFactor_;
            _type = type_;
        }

    }

}
