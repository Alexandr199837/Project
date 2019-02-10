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
using sharpPDF;
using sharpPDF.Enumerators;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pdfDocument myDoc = new pdfDocument("TUTORIAL", "ME");
            pdfPage myPage = myDoc.addPage();
            myPage.addText("Hello,World!", 200, 450,myDoc.getFontReference(predefinedFont.csHelvetica), 20);          
            myDoc.addTrueTypeFont(@"verdana.ttf", "verdana");
            myPage.addText("Привет, мир!", 200, 250, myDoc.getFontReference("verdana"), 20);
            myDoc.createPDF(@"test.pdf");
            myPage = null;
            myDoc = null; 
        }
    }
}
