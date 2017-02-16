using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RealmDecoder
{
    public static class Extentions
    {
        private static System.Windows.Forms.Timer timer;
        public static void BeginBlinking(this System.Windows.Forms.Label label, int interval)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, args) => BlinkTimer(sender, args, label);
            timer.Interval = interval;
            timer.Start();
        }
        public static void StopBlinking(this System.Windows.Forms.Label label)
        {
            timer.Tick -= (sender, args) => BlinkTimer(sender, args, label);
            timer.Enabled = false;
            timer.Stop();
            if (!label.Visible) { label.Visible = true; }
        }
        public static bool IsBlinking(this System.Windows.Forms.Label label)
        {
            return timer.Enabled;
        }
        private static void BlinkTimer(object sender, EventArgs e, System.Windows.Forms.Label label)
        {
            // In a thread
            Task blinkTask = Task.Factory.StartNew(() =>
                {
                    if (label.InvokeRequired)
                    {
                        label.Invoke((MethodInvoker)
                            delegate
                            {
                                bool visible = label.Visible;
                                if (visible) label.Visible = false;
                                else label.Visible = true;
                            });
                    }
                    else
                    {
                        bool visible = label.Visible;
                        if (visible) label.Visible = false;
                        else label.Visible = true;
                    }
                });
        }
    }
}
