using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChessUniverse_WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// 
    /// </summary>
    private bool _t;
    private int _ImgDownX;
    private int _ImgDownY;
    private int _ImgUpX;
    private int _ImgUpY;

    private System.Windows.Point _ptLast = new System.Windows.Point();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void MouseDown(object sender, MouseEventArgs e)
    {
        _t = true;
        var img = (System.Windows.Controls.Image)sender;

        _ptLast = e.GetPosition(img);

        Mouse.Capture(img); // WPF-i Mouse-i hamar gorciq e
        StackPanel.SetZIndex(img, 1);

        label1.Content = "X: " + img.Margin.Left.ToString();
        label2.Content = "Y: " + img.Margin.Top.ToString();

        _ImgDownX = (int)(img.Margin.Left);
        _ImgDownY = (int)(img.Margin.Top);
    }

    private void MouseMove(object sender, MouseEventArgs e)
    {
        if (_t)
        {
            var img = (System.Windows.Controls.Image)sender;
            var ptNew = new System.Windows.Point();
            ptNew.X = img.Margin.Left;
            ptNew.Y = img.Margin.Top;

            img.Margin = new Thickness(ptNew.X + (e.GetPosition(img).X - _ptLast.X),
                ptNew.Y + (e.GetPosition(img).Y - _ptLast.Y), 0, 0);
        }
    }

    private void MouseUp(object sender, MouseEventArgs e)
    {
        _t = false;
        var img = (System.Windows.Controls.Image)sender;

        int x = (int)(img.Margin.Left + 28.5) / 57;
        int y = (int)(img.Margin.Top + 28.5) / 57;
        Mouse.Capture(null); // Capture-ic hanum enq
        StackPanel.SetZIndex(img, 0);

        switch (img.Tag.ToString())
        {
            case "wpawn":
                img.Margin = new Thickness(57 * x + 10, 57 * y + 2, 0, 0);
                break;
            case "bpawn":
                img.Margin = new Thickness(57 * x + 10, 57 * y + 2, 0, 0);
                break;
            case "ship":
                img.Margin = new Thickness(57 * x + 6, 57 * y + 4, 0, 0);
                break;
            case "knight":
                img.Margin = new Thickness(57 * x + 3, 57 * y + 3, 0, 0);
                break;
            case "bishop":
                img.Margin = new Thickness(57 * x + 7, 57 * y + 3, 0, 0);
                break;
            case "queen":
                img.Margin = new Thickness(57 * x + 4, 57 * y + 10, 0, 0);
                break;
            case "king":
                img.Margin = new Thickness(57 * x + 4, 57 * y + 7, 0, 0);
                break;
        }

        _ImgUpX = (int)(img.Margin.Left);
        _ImgUpY = (int)(img.Margin.Top);

        label3.Content = "M: " + img.Margin.Left.ToString() + " " + img.Margin.Top.ToString();

        RookStep(img, _ImgDownX, _ImgDownY, _ImgUpX, _ImgUpY);
    }

    private void RookStep(System.Windows.Controls.Image img, int imgDownX, int imgDownY, int imgUpX, int imgUpY)
    {
        Console.WriteLine(img.Tag.ToString());
        if (img.Tag.ToString() == "ship" && (imgDownX == imgUpX || imgDownY == imgUpY))
        {
            img.Margin = new Thickness(imgDownX, imgDownY, 0, 0);
        }
    }
}