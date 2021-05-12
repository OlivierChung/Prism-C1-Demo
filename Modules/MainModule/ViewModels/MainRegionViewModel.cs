using Core;
using MainModule.Models;
using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MainModule.ViewModels
{
    public class MainRegionViewModel : BaseViewModel
    {
        public ICommand OpenWindowCommand { get; }
        public ObservableCollection<Car> Cars { get; set; }
        public DateTime SelectedDate { get; set; }
        public Car SelectedCar { get; set; }
        public string SearchKeyword { get; set; }
        public ObservableCollection<string> CarLabels { get; private set; }
        public ObservableCollection<PieChartDataItem> PieChartData { get; set; }
        public ObservableCollection<BarChartDataItem> BarChartData { get; set; }

        public MainRegionViewModel()
        {
            OpenWindowCommand = new DelegateCommand(OpenWindowCommandExecuted);

            Cars = new ObservableCollection<Car>();
            Cars.Add(new Car() { Make = "Toyota", Model = "Rav4", Horsepower = 167 });
            Cars.Add(new Car() { Make = "Honda", Model = "CRV", Horsepower = 190 });
            Cars.Add(new Car() { Make = "Nissan", Model = "March", Horsepower = 65 });
            Cars.Add(new Car() { Make = "Suzuki", Model = "Baleno", Horsepower = 233 });
            Cars.Add(new Car() { Make = "Subaru", Model = "WRX", Horsepower = 202 });
            Cars.Add(new Car() { Make = "Mazda", Model = "CX5", Horsepower = 183 });

            this.BarChartData = new ObservableCollection<BarChartDataItem>();
            foreach (var item in Cars)
            {
                this.BarChartData.Add(new BarChartDataItem() { SeriesName = item.Make, Values = new ObservableCollection<decimal>() { item.Horsepower } });
            }
        }

        private void OpenWindowCommandExecuted()
        {
            _dialogService.ShowWindowTest(CloseWindowEventHandler);
        }

        private void CloseWindowEventHandler(IDialogResult dialogResult)
        {
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
    }
}
