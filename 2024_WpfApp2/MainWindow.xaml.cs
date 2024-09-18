using System.Windows;

namespace _2024_WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello, World!");
            int number;
            List<int> primes = new List<int>();

            bool success = int.TryParse(MyTextBox.Text, out number);

            if (!success)
            {
                MessageBox.Show("請輸入整數", "輸入錯誤");
            }
            else if (number < 2)
            {
                MessageBox.Show($"輸入的數值為{number}，小於2，請重新輸入", "輸入錯誤");
            }
            else // number >= 2
            {
                //MessageBox.Show($"輸入的數值為{number}，可以進一步執行", "輸入正確");
                for (int i = 2; i <= number; i++)
                {
                    if (IsPrime(i))
                    {
                        primes.Add(i);
                    }
                }

                string primeList = $"小於{number}的質數為： ";

                foreach (int p in primes)
                {
                    primeList += $"{p}  ";
                }

                MyTextBlock.Text = primeList;
            }
        }

        private bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}