using System.Windows.Input;
using System.Windows.Media;

namespace ButtonGridTest.src.ViewModel
{
    class GridButton : ObservableObject
    {
        private Brush _background;

        public Brush Background
        {
            get { return _background; }
            set {
                _background = value;
                RaisePropertyChangedEvent("Background");
            }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set {
                _text = value;
                RaisePropertyChangedEvent("Text");
            }
        }

        private ICommand _onClick;

        public ICommand OnClick
        {
            get { return _onClick; }
            set
            {
                _onClick = value;
                RaisePropertyChangedEvent("OnClick");
            }
        }

        private ICommand _onRightClick;

        public ICommand OnRightClick
        {
            get { return _onRightClick; }
            set
            {
                _onRightClick = value;
                RaisePropertyChangedEvent("OnRightClick");
            }
        }

    }
}