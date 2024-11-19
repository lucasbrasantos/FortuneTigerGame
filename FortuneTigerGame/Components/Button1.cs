using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FortuneTigerGame.Components
{
    public partial class Button1 : UserControl
    {
        public EventHandler ButtonClicked;

        private int _fontSize = 36;
        private int _borderRadius = 42;
        private Color _borderColor = Color.Gold;

        private string _text = "";

        private Color _defaultColor = Color.FromArgb(253, 187, 8);
        private Color _hoverColor = Color.FromArgb(253, 210, 90);
        private Color _clickColor = Color.FromArgb(195, 150, 30);


        public Button1()
        {
            InitializeComponent();

            this.Size = new Size(450, 90);
            this.BackColor = Color.FromArgb(253, 187, 8);
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;

            buttonText.MouseEnter += (s, e) => OnMouseEnter(e);
            buttonText.MouseLeave += (s, e) => OnMouseLeave(e);
            buttonText.MouseDown += (s, e) => OnMouseDown(e);
            buttonText.MouseUp += (s, e) => OnMouseUp(e);
            buttonText.MouseClick += (s, e) => OnMouseClick(e);

        }

        [Browsable(true)]
        [Category("Colors")]
        public Color DefaultColor
        {
            get { return _defaultColor; }
            set
            {
                _defaultColor = value;
                this.BackColor = value; // Ensure the control updates the background
                this.Invalidate();
            }
        }
        [Browsable(true)]
        [Category("Colors")]
        public Color HoverColor
        {
            get { return _hoverColor; }
            set
            {
                _hoverColor = value;
                this.Invalidate();
            }
        }
        [Browsable(true)]
        [Category("Colors")]
        public Color ClickColor
        {
            get { return _clickColor; }
            set
            {
                _clickColor = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }
        public string ButtonText
        {
            get { return _text; }
            set
            {
                _text = value;
                buttonText.Text = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }

        }

        public int FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                buttonText.Font = new Font(buttonText.Font.FontFamily, value);
                this.Invalidate();
            }

        }

        private GraphicsPath GetRoundRectanglePath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle bounds = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath path = GetRoundRectanglePath(bounds, _borderRadius);
            this.Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // color
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            //border
            using (Pen pen = new Pen(_borderColor, 4))
            {
                e.Graphics.DrawPath(pen, path);
            }

        }


         //-- START BUTTON CLICK
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }


        // Hover COlor
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = _hoverColor;
        }

        // Default Color
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = _defaultColor;
        }

        // Click Color
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.BackColor = _clickColor;
        }

        // Hover color
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.BackColor = _hoverColor;
        }
    }
}
