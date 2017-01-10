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

namespace CoinToss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }


        public void spin_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            

            displayText.Clear();
            

            var number = rnd.Next(1, 10);
             
            
            if (isOdd(number))
                {
                    displayText.Text += "Cap";
               //itemList.Add(number.ToString());
                }
            else
                {
                    displayText.Text += "Pajura";
               //itemList.Add(number.ToString());
            }

            // displayText.Text += string.Format("    {0}", number);

            int i = 1;

          
                displayMembers.AppendText(Environment.NewLine + " - " + displayText.Text);
            
           
            
        }
             
        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }
        
        //List<string> itemList = new List<string>();


        public void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        public void displayMembers_Load(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            displayText.Clear();
            displayMembers.Document.Blocks.Clear();

        }

        //public string members(List<string> itemList)
        //{
        //    foreach (String s in itemList)
        //    {
        //        return s.ToString();
        //    }
        //    return null;
        //}
    }
    
}
