using System;
using System.ServiceProcess;
using System.Timers;

namespace WeatherService
{
    public partial class Weather : ServiceBase
    {
        private BLL.SendForecast objEmail;

        public Weather()
        {
            objEmail = new BLL.SendForecast();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.timer.Start();
        }

        protected override void OnStop()
        {
            this.timer.Stop();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                DateTime time = DateTime.Now;

                if (time.Hour == 18)
                {
                    this.timer.Enabled = false;
                    objEmail.Send();
                    this.timer.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }


        public void OnDebug()
        {
            try
            {
                this.timer.Enabled = false;
                objEmail.Send();
                this.timer.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
