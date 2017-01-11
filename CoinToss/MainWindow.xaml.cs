using System;
using CoinToss;
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
        public class StoreNumbers
        {
            // this class will store results 
            // only 10 results in the left list after that the RTB should reset 
            // add a number in front of le list item

            List<string> itemList = new List<string>();

            public List<string> ItemList
            {
                get
                {
                    return itemList;
                }

                set
                {
                    itemList = value;
                }
            }

            public string members(List<string> itemList)
            {
                foreach (String s in itemList)
                {
                    return s.ToString();
                }
                return null;
            }

        }

        int bullet = 0;
        int tails = 0;
        int head = 0;
        int totalspins = 0;

        public void spin_Click(object sender, RoutedEventArgs e)
        {
            Clearscreen();
            totalspins++;

            Random rnd = new Random();
            int number = rnd.Next(1, 10);

            incrementBullet(ref bullet);

           // lable1.TextInput += bullet.ToString();

            displayToText(number);
            storeToRichTextBox(bullet);
            spins();

        }

        private void spins()
        {
            totalSpins_.Text = totalspins.ToString();
        }

        public int incrementBullet( ref int bullet)
        {
            bullet++;

            if (bullet <= 11)
            {
                return bullet;
            }
            else
            {
                bullet = 1;
            }

            return bullet;
            
        }

        public void storeToRichTextBox(int bullet)
        {
            
            if ( bullet<11 )
            {
                displayMembers.AppendText(Environment.NewLine + bullet + ". " + displayText.Text );
               headstext.Text = head.ToString();
                tailstext.Text= tails.ToString();

             
                //return;
            }
            else
            {
                ClearDisplay();
                //return;
            }
        }

        private void Clearscreen()
        {
            displayText.Clear(); //clears the displayText textbox      
        }

        private void ClearDisplay()
        {
            displayMembers.Document.Blocks.Clear(); //clears the displayMembers
        }

        public void displayToText(int number)
        {
            if (isOdd(number))
            {
                displayText.Text += "Heads";
                head++;
                //itemList.Add(number.ToString());
            }
            else
            {
                displayText.Text += "Tails";
                tails++;
                //  itemList.Add(number.ToString());
            }

            // displayText.Text += string.Format("    {0}", number);
        }
  
        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }
        
        public void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        public void displayMembers_Load(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            // reset button action
            headstext.Clear();
            tailstext.Clear();
            totalSpins_.Clear();
            Clearscreen();
            ClearDisplay();
            bullet = 0;
            head = 0;
            tails = 0;
            totalspins = 0;
        }

        
    }
    
}
