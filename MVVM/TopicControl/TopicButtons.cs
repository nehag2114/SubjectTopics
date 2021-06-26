using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WimeraSampleProject.Resources;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;
using WimeraSampleProject.MVVM.ViewModel;
using WimeraSampleProject.MVVM.View;
using System.Windows.Media;

namespace WimeraSampleProject.MVVM.TopicControl
{
    public class TopicButtons
    {
        private string _subject;
        private SubjectsViewModel subjectsViewModel = null;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        WrapPanel stackPanel = null;
        public  object SetTopicsButton(string subject)
        {
            List<string> mathsCollection = SubjectsCollection.subjectCollection[subject];
            stackPanel = new WrapPanel();
            stackPanel.Orientation = Orientation.Horizontal;

            foreach (var item in mathsCollection)
            {
                Button newBtn = new Button();
                newBtn.Style = Application.Current.FindResource("ButtonTemplate") as Style; ;
                newBtn.Content = item;
                newBtn.Click += new RoutedEventHandler(TopicButtonClick);
                stackPanel.Children.Add(newBtn);
            }

            return stackPanel;
        }

        private  void TopicButtonClick(object sender, EventArgs e)
        {
            if(subjectsViewModel != null)
                subjectsViewModel.CurrentButton.Background = Brushes.LightGray;
            subjectsViewModel = new SubjectsViewModel();
            subjectsViewModel.TopicContent = $"This is {(sender as Button).Content.ToString()} View";
            (sender as Button).Background = Brushes.LightBlue;
            subjectsViewModel.CurrentButton = sender as Button;
            TopicView topicView = new TopicView();
            UserControlWindow userControlWindow = new UserControlWindow();
            userControlWindow.Title = (sender as Button).Content.ToString();
            userControlWindow.DataContext = subjectsViewModel;
            userControlWindow.Content = topicView;
            userControlWindow.ShowDialog();
        }
    }
}
