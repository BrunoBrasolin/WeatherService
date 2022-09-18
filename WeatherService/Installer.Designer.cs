namespace WeatherService
{
    partial class Installer
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
        private void InitializeComponent()
        {
            this.serviceProcessWeather = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceWeather = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessWeather
            // 
            this.serviceProcessWeather.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessWeather.Password = null;
            this.serviceProcessWeather.Username = null;
            // 
            // serviceWeather
            // 
            this.serviceWeather.Description = "Disparo de e-mail informando a temperatura atual.";
            this.serviceWeather.DisplayName = "Weather Forecast Service";
            this.serviceWeather.ServiceName = "WeatherForecastService";
            this.serviceWeather.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessWeather,
            this.serviceWeather});
        }

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessWeather;
        private System.ServiceProcess.ServiceInstaller serviceWeather;

        #endregion
    }
}