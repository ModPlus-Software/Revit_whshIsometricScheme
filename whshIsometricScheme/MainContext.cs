namespace whshIsometricScheme
{
    using System;
    using System.Windows.Input;
    using ModPlusAPI.Mvvm;
    using ModPlusAPI.Windows;

    /// <summary>
    /// Главный контекст
    /// </summary>
    public class MainContext : ObservableObject
    {
        public ICommand TestCommand => new RelayCommandWithoutParameter(() =>
        {
            try
            {

            }
            catch (Exception exception)
            {
                exception.ShowInExceptionBox();
            }
        });
    }
}
