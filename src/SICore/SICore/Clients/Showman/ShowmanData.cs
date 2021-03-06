﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SICore
{
    /// <summary>
    /// Данные ведущего
    /// </summary>
    public sealed class ShowmanData : INotifyPropertyChanged
    {
        private ICommand _changeSums;

        /// <summary>
        /// Изменить суммы участников
        /// </summary>
        public ICommand ChangeSums
        {
            get { return _changeSums; }
            set
            {
                if (_changeSums != value)
                {
                    _changeSums = value;
                    OnPropertyChanged();
                }
            }
        }
        /// <summary>
        /// Послать сообщение об изменении суммы
        /// </summary>
        public ICommand ChangeSums2 { get; set; }

        private ICommand _manage;

        /// <summary>
        /// Управление игрой
        /// </summary>
        public ICommand Manage
        {
            get { return _manage; }
            set
            {
                if (_manage != value)
                {
                    _manage = value;
                    OnPropertyChanged();
                }
            }
        }

        private Pair _selectedPlayer = null;

        /// <summary>
        /// Выбранный игрок
        /// </summary>
        public Pair SelectedPlayer
        {
            get { return _selectedPlayer; }
            set
            {
                if (_selectedPlayer != value)
                {
                    _selectedPlayer = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
