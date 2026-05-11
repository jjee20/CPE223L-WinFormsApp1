using WinFormsApp1.Presenter;
using WinFormsApp1.Views.IViews;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            IBlogView logView = new BlogView();
            var presenter = new BlogPresenter(logView);

            Application.Run((Form)logView);
        }
    }
}