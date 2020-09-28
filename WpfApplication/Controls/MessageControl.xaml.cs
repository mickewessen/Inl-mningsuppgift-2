using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication.Controls
{
    /// <summary>
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public string FromName
        {
            get { return fromName.Text; }
            set { fromName.Text = value; }
        }

        public string FromEmail
        {
            get { return fromEmail.Text; }
            set { fromEmail.Text = value; }
        }

        public string SubjectOfMessage
        {
            get { return subjectOfMessage.Text; }
            set { subjectOfMessage.Text = value; }
        }

        public string DateOfMessage
        {
            get { return dateOfMessage.Text; }
            set { dateOfMessage.Text = value; }
        }

        public string TimeOfMessage
        {
            get { return timeOfMessage.Text; }
            set { timeOfMessage.Text = value; }
        }
    }
}
