namespace FotoFilter
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenIMG = new System.Windows.Forms.OpenFileDialog();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaBildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändraFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGGBBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effekterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.undoAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallåToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(285, 41);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(963, 362);
            this.PicBox.TabIndex = 1;
            this.PicBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.ändraFärgToolStripMenuItem,
            this.effekterToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sparaToolStripMenuItem,
            this.öppnaBildToolStripMenuItem,
            this.avslutaToolStripMenuItem,
            this.undoAllToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.sparaToolStripMenuItem.Text = "Spara Som";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // öppnaBildToolStripMenuItem
            // 
            this.öppnaBildToolStripMenuItem.Name = "öppnaBildToolStripMenuItem";
            this.öppnaBildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öppnaBildToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.öppnaBildToolStripMenuItem.Text = "Öppna Bild";
            this.öppnaBildToolStripMenuItem.Click += new System.EventHandler(this.öppnaBildToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // ändraFärgToolStripMenuItem
            // 
            this.ändraFärgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGGBBRToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.invertToolStripMenuItem});
            this.ändraFärgToolStripMenuItem.Name = "ändraFärgToolStripMenuItem";
            this.ändraFärgToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ändraFärgToolStripMenuItem.Text = "Ändra Färg";
            // 
            // rGGBBRToolStripMenuItem
            // 
            this.rGGBBRToolStripMenuItem.Name = "rGGBBRToolStripMenuItem";
            this.rGGBBRToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.rGGBBRToolStripMenuItem.Text = "R -> G, G -> B, B -> R";
            this.rGGBBRToolStripMenuItem.Click += new System.EventHandler(this.rGGBBRToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click_1);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // effekterToolStripMenuItem
            // 
            this.effekterToolStripMenuItem.Name = "effekterToolStripMenuItem";
            this.effekterToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.effekterToolStripMenuItem.Text = "Effekter";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hEJToolStripMenuItem,
            this.hallåToolStripMenuItem,
            this.fotoFilterToolStripMenuItem,
            this.toolStripMenuItem2});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // undoAllToolStripMenuItem
            // 
            this.undoAllToolStripMenuItem.Name = "undoAllToolStripMenuItem";
            this.undoAllToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.undoAllToolStripMenuItem.Text = "UndoAll";
            this.undoAllToolStripMenuItem.Click += new System.EventHandler(this.undoAllToolStripMenuItem_Click);
            // 
            // hEJToolStripMenuItem
            // 
            this.hEJToolStripMenuItem.Name = "hEJToolStripMenuItem";
            this.hEJToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hEJToolStripMenuItem.Text = "HEJ";
            // 
            // hallåToolStripMenuItem
            // 
            this.hallåToolStripMenuItem.Name = "hallåToolStripMenuItem";
            this.hallåToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hallåToolStripMenuItem.Text = "Hallå";
            // 
            // fotoFilterToolStripMenuItem
            // 
            this.fotoFilterToolStripMenuItem.Name = "fotoFilterToolStripMenuItem";
            this.fotoFilterToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fotoFilterToolStripMenuItem.Text = "FotoFilter ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem2.Text = "-_-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 464);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PicBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenIMG;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändraFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGGBBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaBildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effekterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallåToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

