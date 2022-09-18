using System.Timers;

namespace WeatherService
{
    partial class Weather
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private Timer timer;
        private void InitializeComponent()
        {
            this.timer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();

            this.timer.Enabled = true;
            this.timer.Interval = 3600000D;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);

            this.ServiceName = "Weather";

            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
        }

        #endregion
    }
}
