using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public partial class Unit : INotifyPropertyChanged
    {
        public Unit(int currentStrength, int maxStrength, int currentDexterity, int maxDexterity, int currentInteligence, int maxInteligence, int currentVitality, int maxVitality)
        {
            CurrentStrength = currentStrength;
            MaxStrength = maxStrength;
            CurrentDexterity = currentDexterity;
            MaxDexterity = maxDexterity;
            CurrentInteligence = currentInteligence;
            MaxInteligence = maxInteligence;
            CurrentVitality = currentVitality;
            MaxVitality = maxVitality;
        }

        private int _currentStrength;

        public int CurrentStrength
        {
            get { return _currentStrength; }
            set
            {
                if (_currentStrength != value)
                {
                    _currentStrength = value;
                    OnPropertyChanged(nameof(CurrentStrength));
                }
            }
        }
        public int MaxStrength { get; set; }
        private int _currentDexterity;

        public int CurrentDexterity
        {
            get { return _currentDexterity; }
            set
            {
                if (_currentDexterity != value)
                {
                    _currentDexterity = value;
                    OnPropertyChanged(nameof(CurrentDexterity));
                }
            }
        }
        public int MaxDexterity { get; set; }
        private int _currentInteligence;

        public int CurrentInteligence
        {
            get { return _currentInteligence; }
            set
            {
                if (_currentInteligence != value)
                {
                    _currentInteligence = value;
                    OnPropertyChanged(nameof(CurrentInteligence));
                }
            }
        }
        public int MaxInteligence { get; set; }
        private int _currentVitality;

        public int CurrentVitality
        {
            get { return _currentVitality; }
            set
            {
                if (_currentVitality != value)
                {
                    _currentVitality = value;
                    OnPropertyChanged(nameof(CurrentVitality));
                }
            }
        }
        public int MaxVitality { get; set; }

        public double Health { get; set; }
        public double Mana { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MediumDamage { get; set; }
        public double MediumDefense { get; set; }
        public double CriticalChanse { get; set; }
        public double CriticalDamage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
