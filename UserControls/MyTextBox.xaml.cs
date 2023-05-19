using System.Windows;
using System.Windows.Controls;

namespace CC.UserControls
{
    public partial class MyTextBox : UserControl
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = 
            DependencyProperty.Register("Hint", typeof(string), typeof(MyTextBox));

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty = 
            DependencyProperty.Register("Caption", typeof(string), typeof(MyTextBox));

        public string Text
        {
            get { return textBox.Text; } 
            set { textBox.Text = value; }
        }
    }
}
