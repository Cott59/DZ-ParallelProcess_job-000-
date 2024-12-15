using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ParallelProcessDemo
{
    internal class CountDown
    {
        private Task task;
        public Task GetTask()
        {
            return task;
        }
        private CancellationTokenSource cancellationTokenSource;
        // Если нужно передать вызывающему коду
        // ссылку на визуальный элемент
        private Label label;
        public Button colorbutton;
        public CountDown(Label label, Button _colorbutton) 
        {
            this.colorbutton = _colorbutton;
            
            
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            int _start = 30;
            //Task task002 = new Task(() => { }, token);
            Task task = new Task(() =>
            {
                
                while (_start > 0)
                {
                    if(colorbutton.BackColor == Color.Red)
                    {
                        colorbutton.BackColor = Color.Maroon;
                    }
                    else
                    {
                        colorbutton.BackColor = Color.Red;
                    }
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    if (_start == 1) colorbutton.BackColor = Color.LimeGreen;
                    label.Text = _start.ToString();
                    Thread.Sleep(1000);
                    _start--;
                }
            }, token);
            this.task = task;
            this.colorbutton.BackColor = Color.LimeGreen;
        }
        public void Stop()
        {
            
            this.cancellationTokenSource.Cancel();
            
        }
    }


    
  


}
