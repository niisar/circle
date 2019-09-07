using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Interactivity;
namespace circle2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
            
			// Insert code required on object creation below this point.
		}
        Storyboard sb = new Storyboard();
        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
        
           
                if (e.Key.ToString() == "Up")
                {
                    if (Window.Opacity < 1)
                    Window.Opacity = Window.Opacity + 0.1;
                }


                if (e.Key.ToString() == "Down")
                {
                    if (Window.Opacity > 0.3)
                    Window.Opacity = Window.Opacity - 0.1;
                }

                if (e.Key.ToString() == "Left")
                {
                    sb.SpeedRatio = sb.SpeedRatio + 1;
                    
                }
                if (e.Key.ToString() == "Right")
                {
                    //sb.SpeedRatio = sb.SpeedRatio - 1;

                }
          
            //MessageBox.Show(e.Key.ToString());
        }
	}
}