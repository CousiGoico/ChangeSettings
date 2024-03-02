namespace ChangeSettings {

    public static class Designer {

        #region Controls

        public static GroupBox CreateGroupBox( DockStyle dockStyle, string text){
            var container = new GroupBox();
            container.Dock =dockStyle;
            container.Text = text;
            return container;
        }

        public static MenuStrip CreateMenuStrip(){
            var mainMenu = new MenuStrip();
            mainMenu.Items.Add("Archivo");
            return mainMenu;
        }

        public static ToolStrip CreateToolbar(){
            var toolbar = new ToolStrip();
            ToolStripButton button = new ToolStripButton();
            button.Text = "Cerrar";
            //button.Click += new EventHandler();
            toolbar.Items.Add(button);
            return toolbar;
        }

        public static StatusStrip CreateStatusStrip(){
            var statusBar = new StatusStrip();
            statusBar.Name = "StatusBar";
            var toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel.Name = "Status";
            toolStripStatusLabel.Text = "Ready";
            statusBar.Items.Add(toolStripStatusLabel);
            var toolStripStatusElementsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusElementsLabel.Name = "Elements";
            statusBar.Items.Add(toolStripStatusElementsLabel);
            return statusBar;
        }

        public static Splitter CreateSplitter(DockStyle dockStyle){
            var splitter = new Splitter();
            splitter.Dock = dockStyle;
            splitter.BorderStyle = BorderStyle.Fixed3D;
            return splitter;
        }
    
        public static TreeView CreateTreeView(DockStyle dockStyle, string name) {
            var treeview = new TreeView();
            treeview.Dock =dockStyle;
            treeview.FullRowSelect = true;
            treeview.Name = name;
            return treeview;
        }

        public static TextBox CreateTextBox(string name, DockStyle dockStyle, string placeholderText) {
            var textbox = new TextBox();
            textbox.Name = name;
            textbox.Dock = dockStyle;
            textbox.PlaceholderText = placeholderText;
            return textbox;
        }

        public static Button CreateButton(DockStyle dockStyle, string text){
            var button = new Button();
            button.Text = text;
            button.Dock = dockStyle;
            button.FlatStyle = FlatStyle.Standard;
            return button;
        }

        public static FolderBrowserDialog CreateFolderDialog(){
            var folderDialog = new FolderBrowserDialog();
            folderDialog.InitialDirectory = @"C:\";
            return folderDialog;
        }

        #endregion

        #region Methods

 

        #endregion

        
    }

}