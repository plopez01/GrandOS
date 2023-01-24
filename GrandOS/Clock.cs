using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Threading;

namespace GrandOS
{
    class Clock
    {
        DispatcherTimer timer = new DispatcherTimer();
        Label label;
        string format;
        public Clock(Label label, string format)
        {
            this.label = label;
            this.format = format;

            label.Content = DateTime.Now.ToString(format);

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tick;
            timer.Start();
        }

        void tick(object sender, EventArgs e)
        {
            label.Content = DateTime.Now.ToString(format);
        }

    }
}
