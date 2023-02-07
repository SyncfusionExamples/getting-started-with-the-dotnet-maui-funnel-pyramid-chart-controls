using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiExample
{
    public class DataViewModel
    {
        public ObservableCollection<DataModel> Foods { get; set; }
        public DataViewModel() { 
            Foods = new ObservableCollection<DataModel> { 
                new DataModel() {Name="Milk", Calories =435},
                new DataModel() { Name="Vegetable", Calories =470},
                new DataModel() { Name="Meat", Calories =475},
                new DataModel() { Name="Rice", Calories =930},
                new DataModel() { Name="Fruits", Calories =520}

            };   
        
        }
    }
}
