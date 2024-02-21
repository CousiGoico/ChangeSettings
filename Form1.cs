namespace ChangeSettings;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        var textbox = new TextBox();
        // textbox.Name = "Searcher";
        // textbox.PlaceholderText = "Searcher";
        // textbox.Top = 0;
        // textbox.Left = 0;
        // textbox.Width = 200;
        this.Controls.Add(Designer.CreateToolbar());
        this.Controls.Add(Designer.CreateMenuStrip());
        
        this.Controls.Add(Designer.CreateStatusStrip());
        this.Controls.Add(Designer.CreateGroupBox(300, this.Height, 0, 0));
        this.Controls.Add(Designer.CreateGroupBox(this.Width - 300, this.Height, 300, 0));
    }

}
