using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProcessDemo
{
    public partial class Form1 : Form
    {
        Label currentLabel;
        
        Button ColorButton = new Button();
        Task[] tasks = new Task[3];
        CountDown[] countDowns = new CountDown[3];




        public Form1()
        {
            InitializeComponent();

            //btn_1.BackColor = Color.White;
                      
            
        }

        private void btnCounDown_Click(object sender, EventArgs e)
        {
            int _number = 0;
            if (currentLabel == null)
            {
                currentLabel = lbCountDown001;
                ColorButton = btn_1;
                
            }
            else
            {
                if (currentLabel == lbCountDown001)
                {
                    currentLabel = lbCountDown002;
                    ColorButton = btn_2;
                    _number = 1;
                }
                    else
                    {
                        if (currentLabel == lbCountDown002)
                        {
                            currentLabel = lbCountDown003;
                            ColorButton = btn_3;
                            _number = 2;
                        }
                        else
                        {
                            currentLabel = lbCountDown001;
                            ColorButton = btn_1;
                            _number = 0;
                        }
                    }
            }

            //tasks[_number] =  CountDown003(currentLabel);
            //tasks[_number].Start();
            if (countDowns[_number] != null)
            {
                
                countDowns[_number].Stop();
                
            }
            countDowns[_number] = CountDown004(currentLabel, ColorButton);
            countDowns[_number].GetTask().Start();
        }
        //private void CountDown001(Label _label)
        //{
        //    int _start = 10;
        //    System.Windows.Forms.Timer timer =
        //        new System.Windows.Forms.Timer();
        //    timer.Enabled = true;
        //    timer.Interval = 100;
        //    timer.Tick += (object _sender, EventArgs _e) =>
        //    {
        //        if (_start == 0)
        //        {
        //            timer.Enabled = false;
        //        }
        //        _label.Text = _start.ToString();
        //        Thread.Sleep(900);
        //        _start--;
        //    };
        //}
        //private void CountDown002(Label _label)
        //{
        //    int _start = 30;
        //    Task task = new Task(() => 
        //    {
        //        while (_start > 0) 
        //        {
        //           _label.Text = _start.ToString();
        //            Thread.Sleep(1000);
        //            _start--; 
        //        }
        //    });
        //    task.Start();
        //}
        //private Task CountDown003(Label _label)
        //{
        //    int _start = 30;
        //    Task task = new Task(() =>
        //    {
        //        while (_start > 0)
        //        {
        //            _label.Text = _start.ToString();
        //            Thread.Sleep(1000);
        //            _start--;
        //        }
        //    });
        //    return task;
        //}
        private CountDown CountDown004(Label _label, Button _colorButton)
        {
            return new CountDown(_label, _colorButton);
        }

        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            //if (tasks[0] != null) lbStatusTask001.Text = tasks[0].Status.ToString();
            //if (tasks[1] != null) lbStatusTask002.Text = tasks[1].Status.ToString();
            //if (tasks[2] != null) lbStatusTask003.Text = tasks[2].Status.ToString();
            if (countDowns[0] != null)
                lbStatusTask001.Text = countDowns[0].GetTask().Status.ToString();
            if (countDowns[1] != null)
                lbStatusTask002.Text = countDowns[1].GetTask().Status.ToString();
            if (countDowns[2] != null)
                lbStatusTask003.Text = countDowns[2].GetTask().Status.ToString();
        }

        
        
            //string color1 = "830202";
            //string color2 = "f41c1c";
            //string color3 = "18b014";
            
        
    }
}
