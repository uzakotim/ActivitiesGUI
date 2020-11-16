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
using System.IO;

namespace ActivityGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // public HandleCheckedReset(object sender,RoutedEventArgs e){
        //     string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
        //     string fileName = "data/user.csv";
        //     string pathString = System.IO.Path.Combine(folderName, fileName);
        //     string[] save = File.ReadAllLines(pathString);
        //     // File.WriteAllLines(pathString,save);
        // }
        public MainWindow()
        {
            InitializeComponent();
            //Reading data
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString);
            
            if(save[0] == "1"){
                Button01.IsChecked = true;
            } else Button01.IsChecked = false;

            if(save[1] == "1"){
                Button02.IsChecked = true;
            } else Button02.IsChecked = false;

            if(save[2] == "1"){
                Button03.IsChecked = true;
            } else Button03.IsChecked = false;

            if(save[3] == "1"){
                Button04.IsChecked = true;
            } else Button04.IsChecked = false;

            if(save[4] == "1"){
                Button05.IsChecked = true;
            } else Button05.IsChecked = false;

            if(save[5] == "1"){
                Button06.IsChecked = true;
            } else Button06.IsChecked = false;

            if(save[6] == "1"){
                Button07.IsChecked = true;
            } else Button07.IsChecked = false;


            //second row

            if(save[7] == "1"){
                Button11.IsChecked = true;
            } else Button11.IsChecked = false;

            if(save[8] == "1"){
                Button12.IsChecked = true;
            } else Button12.IsChecked = false;

            if(save[9] == "1"){
                Button13.IsChecked = true;
            } else Button13.IsChecked = false;

            if(save[10] == "1"){
                Button14.IsChecked = true;
            } else Button14.IsChecked = false;

            if(save[11] == "1"){
                Button15.IsChecked = true;
            } else Button15.IsChecked = false;

            if(save[12] == "1"){
                Button16.IsChecked = true;
            } else Button16.IsChecked = false;

            if(save[13] == "1"){
                Button17.IsChecked = true;
            } else Button17.IsChecked = false;
        


        //third row

            if(save[14] == "1"){
                Button21.IsChecked = true;
            } else Button21.IsChecked = false;

            if(save[15] == "1"){
                Button22.IsChecked = true;
            } else Button22.IsChecked = false;

            if(save[16] == "1"){
                Button23.IsChecked = true;
            } else Button23.IsChecked = false;

            if(save[17] == "1"){
                Button24.IsChecked = true;
            } else Button24.IsChecked = false;

            if(save[18] == "1"){
                Button25.IsChecked = true;
            } else Button25.IsChecked = false;

            if(save[19] == "1"){
                Button26.IsChecked = true;
            } else Button26.IsChecked = false;

            if(save[20] == "1"){
                Button27.IsChecked = true;
            } else Button27.IsChecked = false;
        }






        public void HandleChecked01(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[0] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked01(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[0] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked02(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[1] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked02(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[1] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked03(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[2] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked03(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[2] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked04(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[3] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked04(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[3] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked05(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[4] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked05(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[4] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked06(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[5] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked06(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[5] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked07(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[6] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked07(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[6] = "0";
            File.WriteAllLines(pathString,save);

        }


        // second row



        
        public void HandleChecked11(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[7] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked11(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[7] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked12(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[8] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked12(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[8] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked13(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[9] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked13(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[9] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked14(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[10] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked14(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[10] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked15(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[11] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked15(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[11] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked16(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[12] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked16(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[12] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked17(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[13] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked17(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[13] = "0";
            File.WriteAllLines(pathString,save);

        }


        // third row



        
        public void HandleChecked21(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[14] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked21(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[14] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked22(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[15] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked22(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[15] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked23(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[16] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked23(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[16] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked24(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[17] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked24(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[17] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked25(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[18] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked25(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[18] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked26(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[19] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked26(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[19] = "0";
            File.WriteAllLines(pathString,save);

        }

        public void HandleChecked27(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[20] = "1";
            File.WriteAllLines(pathString,save);

        }
        public void HandleUnchecked27(object sender, RoutedEventArgs e){
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            save[20] = "0";
            File.WriteAllLines(pathString,save);

        }



        public void Button_Reset_Click(object sender, RoutedEventArgs e)
        {   
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);;
            string fileName = "data/user.csv";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = File.ReadAllLines(pathString); 
            for(int i =0 ; i<21;i++)
            {
                save[i] = "0";
            }
            File.WriteAllLines(pathString,save);

            Button01.IsChecked = false;
            Button02.IsChecked = false;
            Button03.IsChecked = false;
            Button04.IsChecked = false;
            Button05.IsChecked = false;
            Button06.IsChecked = false;
            Button07.IsChecked = false;
            Button11.IsChecked = false;
            Button12.IsChecked = false;
            Button13.IsChecked = false;
            Button14.IsChecked = false;
            Button15.IsChecked = false;
            Button16.IsChecked = false;
            Button17.IsChecked = false;
            Button21.IsChecked = false;
            Button22.IsChecked = false;
            Button23.IsChecked = false;
            Button24.IsChecked = false;
            Button25.IsChecked = false;
            Button26.IsChecked = false;
            Button27.IsChecked = false;
            

        }
    }
}
