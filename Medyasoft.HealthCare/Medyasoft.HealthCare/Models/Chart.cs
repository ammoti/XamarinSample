using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Medyasoft.HealthCare.Models
{
    public class Chart
    {
        public Chart()
        {
            this.Data = GetCategoricalData();
        }

        public ObservableCollection<CategoricalData> Data { get; set; }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>  {
            new CategoricalData { Category = "A", Value = 0.63 },
            new CategoricalData { Category = "B", Value = 0.85 },
            new CategoricalData { Category = "C", Value = 1.05 },
            new CategoricalData { Category = "D", Value = 0.96 },
            new CategoricalData { Category = "E", Value = 0.78 },
        };

            return data;
        }
    }

    public class CategoricalData
    {
        public object Category { get; set; }

        public double Value { get; set; }
    }
}