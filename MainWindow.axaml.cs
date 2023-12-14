using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Media.Imaging;


namespace EmailRegistr;

public partial class MainWindow : Window
{
    public List<ImagePath> ImagePaths { get; set; }
    
    public MainWindow()
    {
        
        InitializeComponent();

         Bitmap bi1 = new Bitmap(@"D:\EmailRegistr\Assets\Abkhazia.png");
         Bitmap bi2 = new Bitmap(@"D:\EmailRegistr\Assets\Austria.png");
         Bitmap bi3 = new Bitmap(@"D:\EmailRegistr\Assets\flag_belarusi.png");
         Bitmap bi4 = new Bitmap(@"D:\EmailRegistr\Assets\italy.png");
         Bitmap bi5 = new Bitmap(@"D:\EmailRegistr\Assets\rumynia.png");
         ImagePaths = new List<ImagePath>
         {
             new ImagePath()
             {
                 pathImg = bi1,
                  country = "Абхазия"
             },
             new ImagePath()
             {
                 pathImg = bi2,
                 country = "Австрия"
             },
             new ImagePath()
             {
                 pathImg = bi3,
                  country = "Беларусь"
            
             },
             new ImagePath()
             {
                
                 pathImg = bi4,
                  country = "Италия"
                
                
             },
             new ImagePath()
             {
                
                  pathImg = bi5,
                  country = "Румыния"
                
                
             }


         };
        ;

        countries.Items = ImagePaths;
        countries.SelectedIndex = 0;
     



    }
}