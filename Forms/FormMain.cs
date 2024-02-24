using System.Text.RegularExpressions;

namespace ChangeSettings;

public partial class FormMain : Form
{
    private const string projectExtension = ".csproj";
    private const string patternSettingsExtension = "setting*.json";
    private const string settingsExtension = ".json";
    private List<TreeNode> treeNodes {get;set;} = new List<TreeNode>();

    public FormMain()
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
        var treeview = Designer.CreateTreeView(DockStyle.Fill, "ListProjects");
        var textbox = Designer.CreateTextBox("FolderTextBox", DockStyle.Fill, "Select folder");
        var buttonSelectFolder = Designer.CreateButton(DockStyle.Right, "Folder");
        var buttonSelectLoad = Designer.CreateButton(DockStyle.Right, "Load");

        buttonSelectFolder.Click += new EventHandler(buttonSelectFolder_Click);
        buttonSelectLoad.Click += new EventHandler(buttonSelectLoad_Click);


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

    private void buttonSelectFolder_Click(object sender, System.EventArgs e)  
    {  
        var folderDialog = Designer.CreateFolderDialog();
        if (folderDialog.ShowDialog() == DialogResult.OK){
            TextBox textbox = (TextBox)this.Controls.Find("FolderTextBox", true).First();
            textbox.Text = folderDialog.SelectedPath;
        }

    } 

    private void buttonSelectLoad_Click(object sender, EventArgs e){
        TextBox textbox = (TextBox)this.Controls.Find("FolderTextBox", true).First();
        string path = textbox.Text;
        SearchRecursively(path);
        TreeView treeView = (TreeView)this.Controls.Find("ListProjects", true).First();
        treeView.Nodes.AddRange(treeNodes.ToArray());
    }

    private void SearchRecursively (string path){
        var currentDirectory = new System.IO.DirectoryInfo(path);
        

        currentDirectory.GetFiles().Where(archive => archive.Extension == projectExtension).ToList().ForEach(archiveProject => {
            var treeNode = new TreeNode { Text = archiveProject.Name.Replace(projectExtension, string.Empty) };
            Regex regex = new Regex(patternSettingsExtension);
            currentDirectory.GetFiles().Where(archive => regex.Match(archive.Name).Success).ToList().ForEach(archiveSetting => {
                treeNode.Nodes.Add(new TreeNode { Text = archiveSetting.Name.Replace(settingsExtension, string.Empty)});
            });
            treeNodes.Add(treeNode);
        });

        // Search recursively for each folder.
        currentDirectory.GetDirectories().ToList().ForEach(directory => {
            SearchRecursively(directory.FullName);
        });

    }

}