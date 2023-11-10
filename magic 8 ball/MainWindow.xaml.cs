using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;


namespace magic_8_ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();

        // Affirmative Answers
        public List<string> answers = new List<string> { "It is certain", "It is decidedly so", "Without a doubt", "Yes definitely", "You may rely on it", "As I see it, yes", "Most likely", "Outlook good", "Yes", "Signs point to yes" };




        public MainWindow()
        {
            //Non – Committal Answers
            answers.Add("Reply hazy, try again");
            answers.Add("Ask again later");
            answers.Add("Better not tell you now");
            answers.Add("Cannot predict now");
            answers.Add("Concentrate and ask again");

            // Negative Answers
            answers.Add("Don’t count on it");
            answers.Add("My reply is no");
            answers.Add("My sources say no");
            answers.Add("Outlook not so good");
            answers.Add("Very doubtful");

            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textblok.Text = answers[rand.Next(1, answers.Count)];
        }
    }
}
