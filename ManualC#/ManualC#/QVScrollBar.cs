using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace ManualC_
{
    public partial class QVScrollBar : UserControl
    {
        public class QVScrollBarElement
        {
            public Control ControlInstance { get; private set; } = null;
            public int StartYPosition = 0;

            public QVScrollBarElement(Control controlInstance, Control Parent, int startYPosition)
            {
                StartYPosition = startYPosition;
                ControlInstance = controlInstance;
                ControlInstance.Location = new Point(ControlInstance.Location.X, StartYPosition);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Control ContentContainer
        {
            get { return contentContainer; }
            set { contentContainer = value; }
        }
        private Control contentContainer;

        public List<QVScrollBarElement> Elements { get; private set; } = new List<QVScrollBarElement>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float Sensitive = 1;


        public int PaddingUp { get; private set; } = 3;
        public int PaddingDown { get; private set; } = 3;

        private Point lastMousePos;
        private Point currentMousePos;

        private float contentSuperiority = 1;

        private bool isScrollable = false;

        public QVScrollBar()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);
        }

        private void QVScrollBar_ParentChanged(object sender, EventArgs e)
        {
            SetScrollbarParameters();
        }

        public void SetScrollbarParameters()
        {
            DrawButtons();

            int last = Elements.Count - 1;
            int different = 0;

            if (Elements.Count == 1)
            {
                //Calculate occupies area size by elements
                different =
                    (Elements[0].ControlInstance.Height + PaddingDown)
                    -
                    (Elements[0].StartYPosition);

                if (different > Panel.Height)
                {
                    contentSuperiority = (float)different / (float)Panel.Height;
                    Toggle.Height = (int)((float)Panel.Height / contentSuperiority);
                    isScrollable = true;
                }
                else
                {
                    //Toggle occupies the entire area
                    Toggle.Size = new Size(Panel.Width, Panel.Height);
                    isScrollable = false;
                }
            }
            else if (Elements.Count >= 2)
            {
                //Calculate occupies area size by elements
                different =
                    (Elements[last].StartYPosition + Elements[last].ControlInstance.Height + PaddingDown)
                    -
                    (Elements[0].StartYPosition - (PaddingUp * 2));

                if (different > Panel.Height)
                {
                    contentSuperiority = (float)different / (float)Panel.Height;
                    Toggle.Height = (int)((float)Panel.Height / contentSuperiority);
                    isScrollable = true;
                }
                else
                {
                    //Toggle occupies the entire area
                    Toggle.Size = new Size(Panel.Width, Panel.Height);
                    isScrollable = false;
                }
            }
            else
            {
                //Toggle occupies the entire area
                Toggle.Size = new Size(Panel.Width, Panel.Height);
                isScrollable = false;
            }

            Toggle.Location = new Point(Toggle.Location.X, 0);
            ContentSet(true);
        }

        public void AddControl(Control controlInstance)
        {
            if (contentContainer == null) { return; }

            int shiftY = PaddingUp;
            if (Elements.Count != 0) { 
                shiftY = PaddingDown +
                    Elements[Elements.Count - 1].StartYPosition +
                    Elements[Elements.Count - 1].ControlInstance.Height; }

            Elements.Add(new QVScrollBarElement(controlInstance, ContentContainer, shiftY));
        }

        public void RemoveAt(int controlIndex)
        {
            if (controlIndex < Elements.Count)
            {
                contentContainer.Controls.Remove(Elements[controlIndex].ControlInstance);
                Elements[controlIndex].ControlInstance.Dispose();
                Elements.RemoveAt(controlIndex);
            }
        }

        public void ClearContent()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                contentContainer.Controls.Remove(Elements[i].ControlInstance);
                Elements[i].ControlInstance.Dispose();
                Elements.RemoveAt(i);
                i--;
            }
        }

        public Control GetControl(int index)
        {
            if (index < Elements.Count)
            {
                return Elements[index].ControlInstance;
            }

            return null;
        }

        public void ReInitContent()
        {
            if (Elements.Count >= 1)
            {
                int shiftY = PaddingUp;
                Elements[0].StartYPosition = shiftY;

                for (int i = 1; i < Elements.Count; i++)
                {
                    if (Elements.Count != 0)
                    {
                        shiftY = PaddingUp +
                            Elements[i - 1].StartYPosition +
                            Elements[i - 1].ControlInstance.Height;
                    }
                    Elements[i].StartYPosition = shiftY;
                }
            }

            for (int i = 0; i < Elements.Count; i++)
            {
                contentContainer.Controls.Remove(Elements[i].ControlInstance);
                contentContainer.Controls.Add(Elements[i].ControlInstance);
                Elements[i].ControlInstance.Location = new Point(
                    Elements[i].ControlInstance.Location.X,
                    Elements[i].StartYPosition);
            }

            if (contentContainer != null)
            {
                contentContainer.Refresh();
                Invalidate(contentContainer.DisplayRectangle);
            }
        }

        private void DrawButtons()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                contentContainer.Controls.Remove(Elements[i].ControlInstance);
                contentContainer.Controls.Add(Elements[i].ControlInstance);
                Elements[i].ControlInstance.Location = new Point(
                    Elements[i].ControlInstance.Location.X,
                    Elements[i].ControlInstance.Location.Y);
            }

            if (contentContainer != null)
            {
                contentContainer.Refresh();
                Invalidate(contentContainer.DisplayRectangle);
            }
        }

        private void ContentMove(int moveParameter)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                Elements[i].ControlInstance.Location = 
                    new Point(
                        Elements[i].ControlInstance.Location.X,
                        Elements[i].ControlInstance.Location.Y + (int)(moveParameter * contentSuperiority));
            }
        }

        private void ContentSet(bool isStart)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (isStart)
                {
                    Elements[i].ControlInstance.Location =
                    new Point(
                        Elements[i].ControlInstance.Location.X,
                        Elements[i].StartYPosition);
                }
                else
                {
                    Elements[i].ControlInstance.Location =
                    new Point(
                        Elements[i].ControlInstance.Location.X,
                        Elements[i].StartYPosition + (PaddingUp + PaddingDown * 3) + contentContainer.Height - (int)(contentContainer.Height * contentSuperiority));
                }
            }
        }

        public void Panel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
               
            }
            else if (e.Delta < 0)
            {
                
            }
            ContentMove((int)(e.Delta * Sensitive));

            Toggle.Invalidate();
            Toggle.Refresh();
        }

        private void Toggle_MouseDown(object sender, MouseEventArgs e)
        {
            currentMousePos = System.Windows.Forms.Control.MousePosition;
            lastMousePos = System.Windows.Forms.Control.MousePosition;
        }

        private void Toggle_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0 && isScrollable)
            {
                currentMousePos = System.Windows.Forms.Control.MousePosition;
                int delta = currentMousePos.Y - lastMousePos.Y;

                if (delta <= 0)
                {
                    if (Toggle.Location.Y + delta <= 0)
                    {
                        //To start location
                        ContentSet(true);
                        Toggle.Location = new Point(Toggle.Location.X, 0);
                    }
                    else
                    {
                        Toggle.Location = new Point(Toggle.Location.X, Toggle.Location.Y + delta);
                        ContentMove(-delta);
                    }
                }
                else
                {
                    if (Toggle.Location.Y + Toggle.Size.Height + delta >= Panel.Size.Height)
                    {
                        //To end location
                        ContentSet(false);
                        Toggle.Location = new Point(Toggle.Location.X, Panel.Size.Height - Toggle.Size.Height);
                    }
                    else
                    {
                        Toggle.Location = new Point(Toggle.Location.X, Toggle.Location.Y + delta);
                        ContentMove(-delta);
                    }
                }

                lastMousePos = System.Windows.Forms.Control.MousePosition;

                //Redraw
                contentContainer.Refresh();
                Invalidate(contentContainer.DisplayRectangle);
            }
        }
    }
}
