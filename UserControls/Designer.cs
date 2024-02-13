namespace ChangeSettings {

    public static class Designer {

        #region Methods

        public static GroupBox CreateGroupBox(int width, int height, int left, int top){
            var container = new GroupBox();
            container.Width = width;
            container.Height = height;
            container.Top = top;
            container.Left = left;
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
            return new StatusStrip();
        }
    

        #endregion
        
    }

}