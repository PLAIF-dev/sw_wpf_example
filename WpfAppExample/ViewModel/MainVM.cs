using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static WpfAppExample.Model.MainModel;

namespace WpfAppExample.ViewModel
{
    public class MainVM : ViewModelBase
    {
        public ObservableCollection<ItemModel> ItemModels { get; set; } = new();

        public ICommand AddClick { get; set; }

        public MainVM() 
        {
            AddClick = new RelayCommand(AddCommand);
        }

        public void AddCommand()
        {
            ItemModel im = new ItemModel();
            im.Name = "PLAIF";
            im.ImageSource = "../Image/plaif.png";

            ItemModels.Add(im);
        }
    }
}
