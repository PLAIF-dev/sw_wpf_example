using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
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
