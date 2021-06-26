using System;
using System.Windows.Controls;
using WimeraSampleProject.MVVM.Core;
using WimeraSampleProject.Resources;
using System.Windows.Media;
using System.Windows;
using System.Collections.Generic;
using WimeraSampleProject.MVVM.TopicControl;

namespace WimeraSampleProject.MVVM.ViewModel
{
    public class SubjectsViewModel : ObservarObject
    {
        public RelayCommand MathsCommand { get { return new RelayCommand(MathsButtonClick); } }
        public RelayCommand PhysicsCommand { get { return new RelayCommand(PhysicsButtonClick); } }
        public RelayCommand ChemistryCommand { get { return new RelayCommand(ChemistryButtonClick); } }
        public RelayCommand BackButtonCommand { get { return new RelayCommand(BackButtonClick); } }

        private object _currentView;

        private TopicButtons topicButtons;


        private Button _currentButton;

        public Button CurrentButton
        {
            get { return _currentButton; }
            set { _currentButton = value; }
        }

        public SubjectsViewModel()
        {
            topicButtons = new TopicButtons();
        }
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        private string _topicContent;

        public string TopicContent
        {
            get { return _topicContent; }
            set { _topicContent = value; OnPropertyChanged(); }
        }


        private string _selectedSubject;

        public string SelectedSubject
        {
            get { return _selectedSubject; }
            set { _selectedSubject = value; OnPropertyChanged(); }
        }

        private void MathsButtonClick(object obj)
        {
            SelectedSubject = "Maths";
            CurrentView = topicButtons.SetTopicsButton(SelectedSubject);
        }

        private void PhysicsButtonClick(object obj)
        {
            SelectedSubject = "Physics";
            CurrentView = topicButtons.SetTopicsButton(SelectedSubject);
        }

        private void ChemistryButtonClick(object obj)
        {
            SelectedSubject = "Chemistry";
            CurrentView = topicButtons.SetTopicsButton(SelectedSubject);
        }

        private void BackButtonClick(object obj)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }

            

        }


    }
}
