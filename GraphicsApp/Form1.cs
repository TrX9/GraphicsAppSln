using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            RectangleShape rectangle = new RectangleShape(50, 50, 100, 70)
            {
                FillColor = Color.Green,
                BorderColor = Color.Black,
                BorderWidth = 2
            };
            drawingPanelControl1.AddShape(rectangle);

            CircleShape circle = new CircleShape(220, 60, 50)
            {
                FillColor = Color.Magenta,
                BorderColor = Color.Black,
                BorderWidth = 2
            };
            drawingPanelControl1.AddShape(circle);

            TriangleShape triangle = new TriangleShape(new PointF(300, 150), new PointF(350, 50), new PointF(400, 150))
            {
                FillColor = Color.Cyan,
                BorderColor = Color.Black,
                BorderWidth = 2
            };
            drawingPanelControl1.AddShape(triangle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void drawingPanelControl1_Load(object sender, EventArgs e)
        {
          
        }

        private void drawingPanelControl1_Paint(object sender, PaintEventArgs e)
        {
            

           
        }

        private void drawingPanelControl1_MouseClick(object sender, MouseEventArgs e)
        {
            
            var shape = drawingPanelControl1.GetShapeAtPoint(e.Location);
            if (shape != null)
            {
                MessageBox.Show("Shape clicked: " + shape.GetType().Name);
            }
            else
            {
                MessageBox.Show("No shape at this location.");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
