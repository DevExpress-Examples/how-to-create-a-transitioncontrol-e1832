using System.Windows;
using System.Windows.Controls;

namespace Using_TransitionControl {
    public partial class MainPage : UserControl {
        int index;
        public MainPage() {
            InitializeComponent();
            index = 0;
            trControl.Content = GetElement("r" + index.ToString());
        }

        private void trControl_MouseLeftButtonUp(object sender,
            System.Windows.Input.MouseButtonEventArgs e) {
            if (index == 2)
                index = 0;
            else
                index++;
            trControl.Content = GetElement("r" + index.ToString());
        }
        private FrameworkElement GetElement(string id) {
            return (FrameworkElement)((DataTemplate)LayoutRoot.Resources[id]).LoadContent();
        }
    }
}
