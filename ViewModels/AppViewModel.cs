using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia;

namespace AvaloniaCannotBinding
{
    
    public class AppViewModel : NotifyPropertyChanged
    {
        
        private bool _isEmpty;
        private bool _notEmpty;

        /// <summary>
        /// 获取或设置 <see cref="NotEmpty"/> 属性。
        /// </summary>
        public bool NotEmpty
        {
            get => _notEmpty;
            set => SetValue(ref _notEmpty, value);
        }
        /// <summary>
        /// 获取或设置 <see cref="IsEmpty"/> 属性。
        /// </summary>
        public bool IsEmpty
        {
            get => _isEmpty;
            set => SetValue(ref _isEmpty, value);
        }
    }
}