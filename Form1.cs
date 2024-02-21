namespace ChangeSettings;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // textbox.Name = "Searcher";
        // textbox.PlaceholderText = "Searcher";
        // textbox.Top = 0;
        // textbox.Left = 0;
        // textbox.Width = 200;
        this.WindowState = FormWindowState.Maximized;
        var toolBar = Designer.CreateToolbar();
        var menuStrip = Designer.CreateMenuStrip();
        var statusStrip = Designer.CreateStatusStrip(); 
        var groupBoxMain = Designer.CreateGroupBox(DockStyle.Fill,"Main");
        var groupBoxList = Designer.CreateGroupBox(DockStyle.Left, "List"); 
        var groupBoxFolder = Designer.CreateGroupBox(DockStyle.Top, "Folder");
        var treeview = Designer.CreateTreeView(DockStyle.Fill);
        var textbox = Designer.CreateTextBox("FolderTextBox", DockStyle.Fill, "Select folder");
        var buttonSelectFolder = Designer.CreateButton(DockStyle.Right, "Folder");
        var buttonSelectLoad = Designer.CreateButton(DockStyle.Right, "Load");

        buttonSelectFolder.Click += new EventHandler(button1_Click);


        groupBoxFolder.Controls.Add(buttonSelectFolder);
        groupBoxFolder.Controls.Add(buttonSelectLoad);
        groupBoxFolder.Controls.Add(textbox);
        groupBoxList.Controls.Add(treeview);
        groupBoxMain.Controls.Add(groupBoxList);
        // var splitter = Designer.CreateSplitter();
        // groupBoxMain.Controls.Add(splitter);
        var groupBoxContent = Designer.CreateGroupBox(DockStyle.Fill, "Content"); 
        groupBoxMain.Controls.Add(groupBoxFolder);
        groupBoxMain.Controls.Add(groupBoxContent);
        
        this.Controls.Add(groupBoxMain);
        this.Controls.Add(toolBar);
        this.Controls.Add(menuStrip);
        this.Controls.Add(statusStrip);


    }

    private void button1_Click(object sender, System.EventArgs e)  
    {  
        var folderDialog = Designer.CreateFolderDialog();
        if (folderDialog.ShowDialog() == DialogResult.OK){
            TextBox textbox = (TextBox)this.Controls.Find("FolderTextBox", true).First();
            textbox.Text = folderDialog.SelectedPath;
        }

    } 

}
