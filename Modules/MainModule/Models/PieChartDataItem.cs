using Core;

namespace MainModule.Models
{
    public class PieChartDataItem : BaseViewModel
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public string Percent { get; set; }
    }
}
