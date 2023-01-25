using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Threading;

namespace GrandOS.UI.Elements
{
    class Clock
    {
        DispatcherTimer timer = new DispatcherTimer();
        Label timeLabel, dateLabel;
        string timeFormat, dateFormat;

        internal Clock(Label timeLabel, string timeFormat, Label dateLabel, string dateFormat)
        {
            this.timeLabel = timeLabel;
            this.timeFormat = timeFormat;

            this.dateLabel = dateLabel;
            this.dateFormat = dateFormat;

            timeLabel.Content = DateTime.Now.ToString(timeFormat);
            dateLabel.Content = DateTime.Today.ToString(dateFormat);

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tick;
            timer.Start();
        }

        void tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString(timeFormat);
            dateLabel.Content = DateTime.Today.ToString(dateFormat);
        }

    }
}
