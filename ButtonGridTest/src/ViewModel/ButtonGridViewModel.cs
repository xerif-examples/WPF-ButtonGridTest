using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ButtonGridTest.src.ViewModel
{
    class ButtonGridViewModel : ObservableObject
    {
        public ObservableCollection<GridButton> GridButtonList { get; set; } = new ObservableCollection<GridButton>();

        public ButtonGridViewModel()
        {
            GridColumns = 9;

            var itemCount = Math.Pow(GridColumns, 2);
            for (var i = 0; i < itemCount; ++i)
            {
                var btn = new GridButton()
                {
                    Text = string.Format("{0}x{1}", i % GridColumns + 1, i / GridColumns + 1),
                    OnClick = new RelayCommand<GridButton>((b) =>
                    {
                        b.Background = Brushes.Green;
                    }),
                    OnRightClick = new RelayCommand<GridButton>((b) =>
                    {
                        b.Background = Brushes.Red;
                    })
                };
                GridButtonList.Add(btn);
            }
        }

        private int _gridColumns;

        public int GridColumns
        {
            get { return _gridColumns; }
            set {
                _gridColumns = value;
                RaisePropertyChangedEvent("GridColumns");
            }
        }

    }
}
