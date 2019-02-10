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
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;
using sharpPDF;
using sharpPDF.Enumerators;
using System.Xml;

namespace Dairy
{
    [Serializable]
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Data> dataList = new ObservableCollection<Data>();
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("calendar.xml"))
            {
                var formatter = new XmlSerializer(dataList.GetType());
                using (var fs = new FileStream("calendar.xml", FileMode.OpenOrCreate))
                {
                    dataList = (ObservableCollection<Data>)formatter.Deserialize(fs);
                    dgMain.ItemsSource = dataList;
                }
            }
        }

        ObservableCollection<Data> collection = null;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (collection == null)
            {
                collection = new ObservableCollection<Data>();
                dgMain.ItemsSource = collection;
            }
            collection.Add(new Data() { First = "", Check = false , Date = "" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //dataList.Add(new Data());
            dgMain.ItemsSource = dataList;

            XmlSerializer formatter = new XmlSerializer(dataList.GetType());
            using (FileStream fs = new FileStream("calendar.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dataList);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string date1 = Date1.Text;
            string date2 = Date2.Text;
            string[] dateSeparator = { "/" };
            string[] wordDate1 = date1.Split(dateSeparator, StringSplitOptions.RemoveEmptyEntries);
            string[] wordDate2 = date2.Split(dateSeparator, StringSplitOptions.RemoveEmptyEntries);

            string text = "";
            XmlTextReader reader = new XmlTextReader("calendar.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // Узел является элементом.
                        text = text + "<" + reader.Name + ">";
                        break;
                    case XmlNodeType.Text: // Вывести текст в каждом элементе.
                        text = text + reader.Value;
                        break;
                    case XmlNodeType.EndElement: // Вывести конец элемента.
                        text = text + "</" + reader.Name + ">";
                        break;
                }
            }

            string[] separator = { "<", ">", " " };
            string[] word = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);// Разделение текста на слова



            int i = 0;
            pdfDocument myDoc = new pdfDocument("TUTORIAL", "ME");
            string newText = "";
            while (i < word.Length)
            {
                
                int j = i + 1;

                if (word[i] == "First")
                {
                    while (word[j] != "/First")
                    {
                        newText = newText + word[j] + " ";
                        j = j + 1;
                    }
                    newText = newText + ";   ";
                }

                if (word[i] == "Check")
                {
                    while (word[j] != "/Check")
                    {
                        newText = newText + word[j] + " ";
                        j = j + 1;
                    }
                    newText = newText + ";   ";
                }

                if (word[i] == "Date")
                {
                    string[] currentDate = word[i+1].Split(dateSeparator, StringSplitOptions.RemoveEmptyEntries);
                    if (Convert.ToInt32(currentDate[2]) >= Convert.ToInt32(wordDate1[2]) && Convert.ToInt32(currentDate[2]) <= Convert.ToInt32(wordDate2[2]))
                    {
                        if (Convert.ToInt32(currentDate[0]) >= Convert.ToInt32(wordDate1[0]) && Convert.ToInt32(currentDate[0]) <= Convert.ToInt32(wordDate2[0]))
                        {
                            if (Convert.ToInt32(currentDate[1]) >= Convert.ToInt32(wordDate1[1]) && Convert.ToInt32(currentDate[1]) <= Convert.ToInt32(wordDate2[1]))
                            {
                                while (word[j] != "/Date")
                                {
                                    newText = newText + word[j] + " ";
                                    j = j + 1;
                                }
                                newText = newText + ".";
                                pdfPage myPage = myDoc.addPage();
                                myPage.addText(newText, 20, 700, myDoc.getFontReference(predefinedFont.csCourier), 14);
                                myDoc.createPDF(@"Dairy.pdf");
                                myPage = null;
                                newText = "";
                            }
                            else { newText = ""; }
                        }
                        else { newText = ""; }
                    }
                    else { newText = ""; }

                }
                i++;
            }
            myDoc = null;
        }
    }
}
