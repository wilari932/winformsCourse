using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Databiding.Annotations;

namespace WinFormsApp1.Databiding
{
    public  class ViewModel:INotifyPropertyChanged
    {
        private string _userText;
        private Color _labelColor;
        public Color LabelColor
        {
            get => _labelColor;
            set
            {
                if (_labelColor == value)
                    return;
                _labelColor = value;
                OnPropertyChanged(nameof(LabelColor));
            }
        }
        public string UserText
        {
            get => _userText;
            set
            {
                LabelColor = (value == "Hola") ? Color.Red : (string.IsNullOrEmpty(value) )? Color.Aquamarine :  Color.Blue;
                if (_userText == value )
                    return;
                _userText = value;
              



                OnPropertyChanged(nameof(UserText));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPost(object? sender, EventArgs args)
        {
            MessageBox.Show("Mensage posteado");
        }
    }
}
