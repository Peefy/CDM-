using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ZedGraph;

namespace 流量计检定上位机.CDM
{
    public class ZedGraghUtils
    {
        int tickStart;
        ZedGraphControl zedgraphControl;
        Form_MainShow formMain;

        public double DataUp { get; set; } = 10;
        public double DataDown { get; set; } = 1;

        double DataUpDragInit;
        double DataDownDragInit;
        public double DataUpDragRenew { get; set; } = 10;
        public double DataDownDragRenew { get; set; } = 1;

        public double YMax
        {
            get
            {
                return zedgraphControl.GraphPane.YAxis.Scale.Max;
            }
            set
            {
                zedgraphControl.GraphPane.YAxis.Scale.Max = value;
            }
        }

        public double YMin
        {
            get
            {
                return zedgraphControl.GraphPane.YAxis.Scale.Min;
            }
            set
            {
                zedgraphControl.GraphPane.YAxis.Scale.Min = value;
            }
        }

        public ZedGraghUtils(ZedGraphControl control,Form_MainShow form)
        {
            formMain = form;
            zedgraphControl = control;
            zedgraphControl.MouseDownEvent += ZedgraphControl_MouseDownEvent;
            zedgraphControl.MouseMoveEvent += ZedgraphControl_MouseMoveEvent;
            zedgraphControl.MouseUpEvent += ZedgraphControl_MouseUpEvent;
        }

        bool JudgeIsUp(Point point)
        {
            var ymax = zedgraphControl.GraphPane.YAxis.Scale.Max;
            var ymin = zedgraphControl.GraphPane.YAxis.Scale.Min;
            if (DataUp < ymin || DataUp > ymax)
                return false;
            double rate = (DataUp - ymin) / (ymax - ymin);
            double ydelta = (1 - rate) * 300 + 66;
            if (Math.Abs(ydelta - point.Y) <= 10)
                return true;
            return false;
        }

        bool JudgeIsDown(Point point)
        {
            var ymax = zedgraphControl.GraphPane.YAxis.Scale.Max;
            var ymin = zedgraphControl.GraphPane.YAxis.Scale.Min;
            if (DataDown < ymin || DataDown > ymax)
                return false;
            double rate = (DataDown - ymin) / (ymax - ymin);
            double ydelta = (1 - rate) * 300 + 66;
            if (Math.Abs(ydelta - point.Y) <= 6)
                return true;
            return false;
        }

        private bool ZedgraphControl_MouseUpEvent(ZedGraphControl sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(isDragLine == true)
            {
                DataUp = DataUpDragRenew;
                DataDown = DataDownDragRenew;
                RenewDataUpDown();
                isDragLine = false;
            }
            return false;
        }

        int isUpDown;
        private bool ZedgraphControl_MouseMoveEvent(ZedGraphControl sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReNewFormUpDown();
            if(isDragLine == false)
            {
                if (JudgeIsUp(e.Location) == true)
                    zedgraphControl.GraphPane.CurveList[1].Color = Color.Purple;
                else
                    zedgraphControl.GraphPane.CurveList[1].Color = Color.Red;
                if (JudgeIsDown(e.Location) == true)
                    zedgraphControl.GraphPane.CurveList[2].Color = Color.DarkRed;
                else
                    zedgraphControl.GraphPane.CurveList[2].Color = Color.Blue;
            }

            if(isDragLine == true)
            {
                var ymax = zedgraphControl.GraphPane.YAxis.Scale.Max;
                var ymin = zedgraphControl.GraphPane.YAxis.Scale.Min;
                int nowy = e.Location.Y;
                int move = DragStartY - nowy;
                double moveRate = Math.Abs(move) / 300.0;
                var deltaData = moveRate * (ymax - ymin);
                if (isUpDown == 1)
                {
                    if (move >= 0)
                    {
                        DataUpDragRenew = DataUpDragInit + deltaData;
                        RenewDataUpDownDragRenew();
                    }
                    if (move < 0)
                    {
                        DataUpDragRenew = DataUpDragInit - deltaData;
                        RenewDataUpDownDragRenew();
                    }
                    ReNewFormUpDownDrag();

                }
                if(isUpDown == 2)
                {
                    if (move >= 0)
                    {
                        DataDownDragRenew= DataDownDragInit + deltaData;
                        RenewDataUpDownDragRenew();
                    }
                    if (move < 0)
                    {
                        DataDownDragRenew = DataDownDragInit - deltaData;
                        RenewDataUpDownDragRenew(); 
                    }
                    ReNewFormUpDownDrag();
                }

            }

            return false;
        }

        public void ReNewFormUpDown()
        {
            formMain.LabelYMax.Text = Math.Round(YMax,2).ToString();
            formMain.LabelYMin.Text = Math.Round(YMin, 2).ToString();

            if(formMain.TabControl.SelectedIndex == 0)
            {
                formMain.DesDown.Text = Math.Round(DataDown, 2).ToString();
                formMain.DesUp.Text = Math.Round(DataUp, 2).ToString();
            }
            else if(formMain.TabControl.SelectedIndex == 1)
            {
                formMain.TemDown.Text = Math.Round(DataDown, 2).ToString();
                formMain.TemUp.Text = Math.Round(DataUp, 2).ToString();
            }

        }

        public void ReNewFormUpDownDrag()
        {
            formMain.LabelYMax.Text = Math.Round(YMax, 2).ToString();
            formMain.LabelYMin.Text = Math.Round(YMin, 2).ToString();

            if (formMain.TabControl.SelectedIndex == 0)
            {
                formMain.DesDown.Text = Math.Round(DataDownDragRenew, 2).ToString();
                formMain.DesUp.Text = Math.Round(DataUpDragRenew, 2).ToString();
            }
            else if (formMain.TabControl.SelectedIndex == 1)
            {
                formMain.TemDown.Text = Math.Round(DataDownDragRenew, 2).ToString();
                formMain.TemUp.Text = Math.Round(DataUpDragRenew, 2).ToString();
            }

        }

        bool isDragLine;
        int DragStartY;
        private bool ZedgraphControl_MouseDownEvent(ZedGraphControl sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (JudgeIsUp(e.Location) == true)
                {
                    zedgraphControl.GraphPane.CurveList[1].Color = Color.Purple;
                    DragStartY = e.Location.Y;
                    DataUpDragInit = DataUp;
                    isDragLine = true;
                    isUpDown = 1;
                }
                else
                    zedgraphControl.GraphPane.CurveList[1].Color = Color.Red;
                if (JudgeIsDown(e.Location) == true)
                {
                    zedgraphControl.GraphPane.CurveList[2].Color = Color.DarkRed;
                    DragStartY = e.Location.Y;
                    DataDownDragInit = DataDown;
                    isDragLine = true;
                    isUpDown = 2;
                }                 
                else
                    zedgraphControl.GraphPane.CurveList[2].Color = Color.Blue;
            }
            return false;
        }

        public void Init(ChartParameters paras)
        {

            GraphPane myPane = zedgraphControl.GraphPane;
            myPane.Title.Text = paras.TotalTitle;
            myPane.XAxis.Title.Text = paras.XTitle;
            myPane.YAxis.Title.Text = paras.YTitle;
            RollingPointPairList list = new RollingPointPairList(200000);
            LineItem curve = myPane.AddCurve(paras.CurveName, list, Color.Black, SymbolType.None);

            myPane.AddCurve("上限", new RollingPointPairList(40000), Color.Red, SymbolType.None);
            myPane.AddCurve("下限", new RollingPointPairList(40000), Color.Blue, SymbolType.None);

            RenewDataUpDown();

            myPane.YAxis.Scale.Max = paras.YMax;
            myPane.YAxis.Scale.Min = paras.YMin;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 1;
            tickStart = Environment.TickCount;
            myPane.XAxis.Scale.Max = 300;
            myPane.XAxis.Scale.Min = 0;
            zedgraphControl.AxisChange();
        }

        public void Start()
        {
            //tickStart = Environment.TickCount;
        }

        public void Clear()
        {
            if (zedgraphControl.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = zedgraphControl.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            list.Clear();

        }

        public void RenewYScale(ChartParameters paras)
        {
            GraphPane myPane = zedgraphControl.GraphPane;
            myPane.YAxis.Scale.Max = paras.YMax;
            myPane.YAxis.Scale.Min = paras.YMin;
            zedgraphControl.Invalidate();
        }

        public void TimeDraw(double addData)
        {
            if (zedgraphControl.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = zedgraphControl.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            double time = (Environment.TickCount - tickStart) / 1000.0;
            list.Add(time,new Random().Next(7));
            //list.Add(time, addData);

            Scale xScale = zedgraphControl.GraphPane.XAxis.Scale;
            if(time > xScale.Max - xScale.MajorStep)
            {
                xScale.Min = time + xScale.MajorStep;
                xScale.Max = xScale.Min + 300;
            }
            zedgraphControl.AxisChange();
            zedgraphControl.Invalidate();
        }

        public void RenewDataUpDownDragRenew()
        {
            double downValue = DataDownDragRenew;
            double upValue = DataUpDragRenew;
            LineItem curve2 = zedgraphControl.GraphPane.CurveList[1] as LineItem;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            list2.Clear();
            for (int i = -2000; i < 30000; ++i)
            {
                list2.Add(i, upValue);
            }


            LineItem curve3 = zedgraphControl.GraphPane.CurveList[2] as LineItem;
            IPointListEdit list3 = curve3.Points as IPointListEdit;
            list3.Clear();
            for (int i = -2000; i < 30000; ++i)
            {
                list3.Add(i, downValue);
            }
        }

        public void RenewDataUpDown()
        {
            double downValue = DataDown;
            double upValue = DataUp;
            LineItem curve2 = zedgraphControl.GraphPane.CurveList[1] as LineItem;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            list2.Clear();
            for(int i = -2000;i  <30000 ;++i)
            {
                list2.Add(i, upValue);
            }


            LineItem curve3 = zedgraphControl.GraphPane.CurveList[2] as LineItem;
            IPointListEdit list3 = curve3.Points as IPointListEdit;
            list3.Clear();
            for (int i = -2000; i < 30000; ++i)
            {
                list3.Add(i, downValue);
            }
        }

        public void RenewDataUpDown(double up ,double down)
        {
            DataUp = up;
            DataDown = down;
            double downValue = DataDown;
            double upValue = DataUp;
            LineItem curve2 = zedgraphControl.GraphPane.CurveList[1] as LineItem;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            list2.Clear();
            for (int i = -2000; i < 30000; ++i)
            {
                list2.Add(i, upValue);
            }

            LineItem curve3 = zedgraphControl.GraphPane.CurveList[2] as LineItem;
            IPointListEdit list3 = curve3.Points as IPointListEdit;
            list3.Clear();
            for (int i = -2000; i < 30000; ++i)
            {
                list3.Add(i, downValue);
            }
        }


    }
}
