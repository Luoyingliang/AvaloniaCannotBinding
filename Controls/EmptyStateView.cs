using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Templates;

namespace AvaloniaCannotBinding
{
    public sealed class EmptyStateView : ContentControl
    {
        public static readonly StyledProperty<DataTemplate>         EmptyStateTemplateProperty;
        public static readonly StyledProperty<object>               EmptyStateProperty;
        public static readonly StyledProperty<bool>                 IsEmptyProperty;
        public static readonly StyledProperty<bool>                 NotEmptyProperty;
        public static readonly DirectProperty<EmptyStateView, bool> IsEmptyStateVisibleProperty;

        static EmptyStateView()
        {
            IsEmptyStateVisibleProperty = AvaloniaProperty.RegisterDirect<EmptyStateView, bool>(nameof(IsEmptyStateVisible), x => x._isEmptyStateVisible);
            IsEmptyProperty             = AvaloniaProperty.Register<EmptyStateView, bool>(nameof(IsEmpty));
            NotEmptyProperty            = AvaloniaProperty.Register<EmptyStateView, bool>(nameof(NotEmpty));
            EmptyStateProperty          = AvaloniaProperty.Register<EmptyStateView, object>(nameof(EmptyState));
            EmptyStateTemplateProperty  = AvaloniaProperty.Register<EmptyStateView, DataTemplate>(nameof(EmptyStateTemplate));
        }

        #region EmptyState

        private bool _isEmptyStateVisible;

        public bool IsEmptyStateVisible
        {
            get => GetValue(IsEmptyStateVisibleProperty);
            private set => SetAndRaise(IsEmptyStateVisibleProperty, ref _isEmptyStateVisible, value);
        }

        public bool IsEmpty
        {
            get => GetValue(IsEmptyProperty);
            set
            {
                SetValue(IsEmptyProperty, value);
                IsEmptyStateVisible = value;
            }
        }

        public bool NotEmpty
        {
            get => GetValue(NotEmptyProperty);
            set
            {
                SetValue(NotEmptyProperty, value);
                IsEmptyStateVisible = !value;
            }
        }

        /// <summary>
        /// 获取或设置 <see cref="EmptyStateTemplate"/> 属性。
        /// </summary>
        public DataTemplate EmptyStateTemplate
        {
            get => GetValue(EmptyStateTemplateProperty);
            set => SetValue(EmptyStateTemplateProperty, value);
        }

        /// <summary>
        /// 获取或设置 <see cref="EmptyState"/> 属性。
        /// </summary>
        public object EmptyState
        {
            get => GetValue(EmptyStateProperty);
            set => SetValue(EmptyStateProperty, value);
        }

        #endregion
    }
}