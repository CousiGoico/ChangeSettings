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
        this.Controls.Add(CreateToolbar());
        this.Controls.Add(CreateMenuStrip());
        
        this.Controls.Add(CreateStatusStrip());
        this.Controls.Add(CreateGroupBox(300, this.Height, 0, 0));
        this.Controls.Add(CreateGroupBox(this.Width - 300, this.Height, 300, 0));
    }

}
