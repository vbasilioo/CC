using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CC.UserControls
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = 
            DependencyProperty.Register("Title", typeof(string), typeof(Card));

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public static readonly DependencyProperty TimeProperty = 
            DependencyProperty.Register("Time", typeof(string), typeof(Card));

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty = 
            DependencyProperty.Register("Number", typeof(string), typeof(Card));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty = 
            DependencyProperty.Register("IsActive", typeof(bool), typeof(Card));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty = 
            DependencyProperty.Register("Image", typeof(Image), typeof(Card));
    }
}
