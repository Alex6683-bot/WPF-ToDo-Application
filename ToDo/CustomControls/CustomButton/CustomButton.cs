using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ToDo.CustomControls
{
    
    class CustomButton : Button
    {
        
        public SolidColorBrush HoverColor
        {
            get { return (SolidColorBrush)GetValue(HoverColorProperty); }
            set {  SetValue(HoverColorProperty, value); }
        }
        public static readonly DependencyProperty HoverColorProperty = DependencyProperty.Register(nameof(HoverColor), typeof(SolidColorBrush),
                                                                        typeof(CustomButton));

        public SolidColorBrush ActiveColor
        {
            get { return (SolidColorBrush)GetValue(ActiveColorProperty); }
            set { SetValue(ActiveColorProperty, value); }
        }
        public static readonly DependencyProperty ActiveColorProperty = DependencyProperty.Register(nameof(ActiveColor), typeof(SolidColorBrush),
                                                                        typeof(CustomButton));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius),
                                                                         typeof(CustomButton));

        public SolidColorBrush DefaultBackground
        {
            get { return (SolidColorBrush)GetValue(DefaultBackgroundProperty); }
            set { SetValue(DefaultBackgroundProperty, value); }
        }

        public static readonly DependencyProperty DefaultBackgroundProperty = DependencyProperty.Register(nameof(DefaultBackground), typeof(SolidColorBrush),
                                                                 typeof(CustomButton));
        static CustomButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton),
                new FrameworkPropertyMetadata(typeof(CustomButton)));
        }

    }
}
