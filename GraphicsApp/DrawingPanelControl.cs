using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsApp
{
    public partial class DrawingPanelControl : UserControl
    {
        private readonly List<BasicShape> shapes = new List<BasicShape>();

        public DrawingPanelControl()
        {
            InitializeComponent();
        }

        public void AddShape(BasicShape shape)
        {
            shapes.Add(shape);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void DrawingPanelControl_Load(object sender, EventArgs e)
        {

        }

        public BasicShape GetShapeAtPoint(Point point)
        {
            foreach (var shape in shapes)
            {
                if (shape.ContainsPoint(point))
                {
                    return shape;
                }
            }
            return null;
        }
    }
}
