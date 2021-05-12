using Core;
using System.Collections.ObjectModel;

namespace MainModule.Models
{
    public class BarChartDataItem : BaseViewModel
    {
        private string name;
        private ObservableCollection<decimal> values;

        public BarChartDataItem()
        {
            this.values = new ObservableCollection<decimal>();
        }

        public string SeriesName
        {
            get { return this.name; }
            set { this.SetProperty(ref this.name, value); }
        }

        public ObservableCollection<decimal> Values
        {
            get { return this.values; }
            set { this.SetProperty(ref this.values, value); }
        }
    }
}
