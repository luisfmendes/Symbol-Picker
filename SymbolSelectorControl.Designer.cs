namespace Sistema_Integrado.SeekClass
{
    partial class SymbolSelectorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbolBox = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // symbolBox
            // 
            this.symbolBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.symbolBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox.Location = new System.Drawing.Point(3, 3);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(36, 31);
            this.symbolBox.TabIndex = 0;
            this.symbolBox.Text = "symbolBox1";
            this.symbolBox.Click += new System.EventHandler(this.symbolBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 111);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // SymbolSelectorControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.symbolBox);
            this.Name = "SymbolSelectorControl";
            this.Size = new System.Drawing.Size(42, 37);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.Controls.SymbolBox symbolBox;
    }
}
