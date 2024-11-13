using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;


namespace ToDo.CustomControls
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
            
        }

        public SolidColorBrush PlaceHolderTextForeground
        {
            get => (SolidColorBrush)GetValue(PlaceHolderTextForegroundProperty);
            set => SetValue(PlaceHolderTextForegroundProperty, value);
        }

        public static readonly DependencyProperty PlaceHolderTextForegroundProperty = DependencyProperty.Register(nameof(PlaceHolderTextForeground),
                                                                       typeof(SolidColorBrush), typeof(CustomTextBox));


        public string TextBoxText
        {
            get => (string)GetValue(TextBoxTextProperty);
            set => SetValue(TextBoxTextProperty, value);
        }

        public static readonly DependencyProperty TextBoxTextProperty = DependencyProperty.Register(nameof(TextBoxText),
                                                                       typeof(string), typeof(CustomTextBox), new FrameworkPropertyMetadata()
                                                                       {
                                                                           BindsTwoWayByDefault = true
                                                                       });

        public SolidColorBrush TextBoxCaretColor
        {
            get => (SolidColorBrush)GetValue(TextBoxCaretColorProperty);
            set => SetValue(TextBoxCaretColorProperty, value);
        }

        public static readonly DependencyProperty TextBoxCaretColorProperty = DependencyProperty.Register(nameof(TextBoxCaretColor),
                                                                       typeof(SolidColorBrush), typeof(CustomTextBox));

        public SolidColorBrush TextBoxBackground
        {
            get => (SolidColorBrush)GetValue(TextBoxBackgroundProperty);
            set => SetValue(TextBoxBackgroundProperty, value);
        }

        public static readonly DependencyProperty TextBoxBackgroundProperty = DependencyProperty.Register(nameof(TextBoxBackground),
                                                                       typeof(SolidColorBrush), typeof(CustomTextBox));

        //public SolidColorBrush TextBoxForeground
        //{
        //    get => (SolidColorBrush)GetValue(TextBoxForegroundProperty);
        //    set => SetValue(TextBoxForegroundProperty, value);
        //}

        //public static readonly DependencyProperty TextBoxForegroundProperty = DependencyProperty.Register(nameof(TextBoxForeground),
        //                                                               typeof(SolidColorBrush), typeof(CustomTextBox));

        //public double TextBoxFontSize
        //{
        //    get => (double)GetValue(TextBoxFontSizeProperty);
        //    set => SetValue(TextBoxFontSizeProperty, value);

        //}

        //public static readonly DependencyProperty TextBoxFontSizeProperty = DependencyProperty.Register(nameof(TextBoxFontSize),
        //                                                               typeof(double), typeof(CustomTextBox));

        //public HorizontalAlignment PlaceHolderHorizontalAlignment
        //{
        //    get => (HorizontalAlignment)GetValue(PlaceHolderHorizontalAlignmentProperty);
        //    set => SetValue(PlaceHolderHorizontalAlignmentProperty, value);

        //}

        //public static readonly DependencyProperty PlaceHolderHorizontalAlignmentProperty = DependencyProperty.Register(nameof(PlaceHolderHorizontalAlignment),
        //                                                               typeof(HorizontalAlignment), typeof(CustomTextBox));

        //public VerticalAlignment PlaceHolderVerticalAlignment
        //{
        //    get => (VerticalAlignment)GetValue(PlaceHolderVerticalAlignmentProperty);
        //    set => SetValue(PlaceHolderVerticalAlignmentProperty, value);

        //}

        //public static readonly DependencyProperty PlaceHolderVerticalAlignmentProperty = DependencyProperty.Register(nameof(PlaceHolderVerticalAlignment),
        //                                                               typeof(VerticalAlignment), typeof(CustomTextBox));

        //public VerticalAlignment TextBoxVerticalAlignment
        //{
        //    get => (VerticalAlignment)GetValue(TextBoxVerticalAlignmentProperty);
        //    set => SetValue(TextBoxVerticalAlignmentProperty, value);

        //}

        //public static readonly DependencyProperty TextBoxVerticalAlignmentProperty = DependencyProperty.Register(nameof(TextBoxVerticalAlignment),
        //                                                               typeof(VerticalAlignment), typeof(CustomTextBox));

        //public HorizontalAlignment TextBoxHorizontalAlignment
        //{
        //    get => (HorizontalAlignment)GetValue(TextBoxHorizontalAlignmentProperty);
        //    set => SetValue(TextBoxHorizontalAlignmentProperty, value);

        //}

        //public static readonly DependencyProperty TextBoxHorizontalAlignmentProperty = DependencyProperty.Register(nameof(TextBoxHorizontalAlignment),
        //                                                               typeof(HorizontalAlignment), typeof(CustomTextBox));

        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);

        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius),
                                                                       typeof(double), typeof(CustomTextBox));


        //public double PlaceHolderFontSize
        //{
        //    get => (double)GetValue(PlaceHolderFontSizeProperty);
        //    set => SetValue(PlaceHolderFontSizeProperty, value);

        //}

        //public static readonly DependencyProperty PlaceHolderFontSizeProperty = DependencyProperty.Register(nameof(PlaceHolderFontSize),
        //                                                               typeof(double), typeof(CustomTextBox));

        public string PlaceHolderText
        {
            get => (string)GetValue(PlaceHolderTextProperty);
            set => SetValue(PlaceHolderTextProperty, value);

        }

        public static readonly DependencyProperty PlaceHolderTextProperty = DependencyProperty.Register(nameof(PlaceHolderText),
                                                                       typeof(string), typeof(CustomTextBox));


        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);

        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text),
                                                                       typeof(string), typeof(CustomTextBox));

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text)) PlaceHolder.Visibility = Visibility.Collapsed;
            else PlaceHolder.Visibility = Visibility.Visible;

            TextBoxText = textBox.Text;

        }

        //public double TextBoxWidth
        //{
        //    get => (double)GetValue(TextBoxWidthProperty);
        //    set => SetValue(TextBoxWidthProperty, value);

        //}

        //public static readonly DependencyProperty TextBoxWidthProperty = DependencyProperty.Register(nameof(TextBoxWidth),
        //                                                               typeof(double), typeof(CustomTextBox));

        //public double TextBoxHeight
        //{
        //    get => (double)GetValue(TextBoxHeightroperty);
        //    set => SetValue(TextBoxHeightroperty, value);

        //}

        //public static readonly DependencyProperty TextBoxHeightroperty = DependencyProperty.Register(nameof(TextBoxHeight),
        //                                                               typeof(double), typeof(CustomTextBox));
    }


}
