namespace whshIsometricScheme
{
    using System;
    using Autodesk.Revit.DB;
    using Autodesk.Revit.UI;
    using ModPlusAPI.Windows;

    /// <summary>
    /// Главная команда
    /// </summary>
    public class Command : IExternalCommand
    {
        /// <inheritdoc/>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
#if !DEBUG
                ModPlusAPI.Statistic.SendCommandStarting(ModPlusConnector.Instance);
#endif
                var context = new MainContext();
                var win = new MainWindow { DataContext = context };
                ModPlus_Revit.ModPlus.ShowModal(win);

                return Result.Succeeded;
            }
            catch (Exception exception)
            {
                exception.ShowInExceptionBox();
                return Result.Failed;
            }
        }
    }
}
