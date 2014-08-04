namespace CheckPDFTitle
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.buttonCheckPdf = new System.Windows.Forms.Button();
      this.textBoxPDFPath = new System.Windows.Forms.TextBox();
      this.labelPdfPath = new System.Windows.Forms.Label();
      this.listBoxPDFOK = new System.Windows.Forms.ListBox();
      this.labelPDFOk = new System.Windows.Forms.Label();
      this.labelPDFNOK = new System.Windows.Forms.Label();
      this.listBoxPDFNOK = new System.Windows.Forms.ListBox();
      this.labelFiles = new System.Windows.Forms.Label();
      this.listBoxListOfFiles = new System.Windows.Forms.ListBox();
      this.buttonGetDirectory = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.labelNumberListOfFiles = new System.Windows.Forms.Label();
      this.labelNumberListOK = new System.Windows.Forms.Label();
      this.labelNumberListNOK = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.labelNumberListFailed = new System.Windows.Forms.Label();
      this.labelFailedFiles = new System.Windows.Forms.Label();
      this.listBoxPDFFailed = new System.Windows.Forms.ListBox();
      this.labelCurrentFile1 = new System.Windows.Forms.Label();
      this.labelCurrentFile2 = new System.Windows.Forms.Label();
      this.labeltimeSpent = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.labelSelectedFile = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelSeparatedCaracter = new System.Windows.Forms.Label();
      this.textBoxSeparatedCaracter = new System.Windows.Forms.TextBox();
      this.checkBoxIncludeSubDirectories = new System.Windows.Forms.CheckBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonCheckPdf
      // 
      this.buttonCheckPdf.Location = new System.Drawing.Point(86, 113);
      this.buttonCheckPdf.Name = "buttonCheckPdf";
      this.buttonCheckPdf.Size = new System.Drawing.Size(75, 23);
      this.buttonCheckPdf.TabIndex = 0;
      this.buttonCheckPdf.Text = "Check";
      this.buttonCheckPdf.UseVisualStyleBackColor = true;
      this.buttonCheckPdf.Click += new System.EventHandler(this.buttonCheckPdf_Click);
      // 
      // textBoxPDFPath
      // 
      this.textBoxPDFPath.Location = new System.Drawing.Point(90, 47);
      this.textBoxPDFPath.Name = "textBoxPDFPath";
      this.textBoxPDFPath.Size = new System.Drawing.Size(1311, 22);
      this.textBoxPDFPath.TabIndex = 1;
      // 
      // labelPdfPath
      // 
      this.labelPdfPath.AutoSize = true;
      this.labelPdfPath.Location = new System.Drawing.Point(12, 47);
      this.labelPdfPath.Name = "labelPdfPath";
      this.labelPdfPath.Size = new System.Drawing.Size(72, 17);
      this.labelPdfPath.TabIndex = 2;
      this.labelPdfPath.Text = "PDF Path:";
      // 
      // listBoxPDFOK
      // 
      this.listBoxPDFOK.FormattingEnabled = true;
      this.listBoxPDFOK.ItemHeight = 16;
      this.listBoxPDFOK.Location = new System.Drawing.Point(422, 173);
      this.listBoxPDFOK.Name = "listBoxPDFOK";
      this.listBoxPDFOK.Size = new System.Drawing.Size(296, 324);
      this.listBoxPDFOK.TabIndex = 3;
      this.listBoxPDFOK.SelectedIndexChanged += new System.EventHandler(this.listBoxPDFOK_SelectedIndexChanged);
      // 
      // labelPDFOk
      // 
      this.labelPDFOk.AutoSize = true;
      this.labelPDFOk.Location = new System.Drawing.Point(388, 173);
      this.labelPDFOk.Name = "labelPDFOk";
      this.labelPDFOk.Size = new System.Drawing.Size(32, 17);
      this.labelPDFOk.TabIndex = 4;
      this.labelPDFOk.Text = "OK:";
      // 
      // labelPDFNOK
      // 
      this.labelPDFNOK.AutoSize = true;
      this.labelPDFNOK.Location = new System.Drawing.Point(726, 173);
      this.labelPDFNOK.Name = "labelPDFNOK";
      this.labelPDFNOK.Size = new System.Drawing.Size(58, 17);
      this.labelPDFNOK.TabIndex = 6;
      this.labelPDFNOK.Text = "Not OK:";
      // 
      // listBoxPDFNOK
      // 
      this.listBoxPDFNOK.FormattingEnabled = true;
      this.listBoxPDFNOK.ItemHeight = 16;
      this.listBoxPDFNOK.Location = new System.Drawing.Point(790, 173);
      this.listBoxPDFNOK.Name = "listBoxPDFNOK";
      this.listBoxPDFNOK.Size = new System.Drawing.Size(296, 324);
      this.listBoxPDFNOK.TabIndex = 5;
      this.listBoxPDFNOK.SelectedIndexChanged += new System.EventHandler(this.listBoxPDFNOK_SelectedIndexChanged);
      // 
      // labelFiles
      // 
      this.labelFiles.AutoSize = true;
      this.labelFiles.Location = new System.Drawing.Point(45, 173);
      this.labelFiles.Name = "labelFiles";
      this.labelFiles.Size = new System.Drawing.Size(41, 17);
      this.labelFiles.TabIndex = 8;
      this.labelFiles.Text = "Files:";
      // 
      // listBoxListOfFiles
      // 
      this.listBoxListOfFiles.FormattingEnabled = true;
      this.listBoxListOfFiles.ItemHeight = 16;
      this.listBoxListOfFiles.Location = new System.Drawing.Point(86, 173);
      this.listBoxListOfFiles.Name = "listBoxListOfFiles";
      this.listBoxListOfFiles.Size = new System.Drawing.Size(296, 324);
      this.listBoxListOfFiles.TabIndex = 7;
      this.listBoxListOfFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxListOfFiles_SelectedIndexChanged);
      // 
      // buttonGetDirectory
      // 
      this.buttonGetDirectory.Location = new System.Drawing.Point(1407, 47);
      this.buttonGetDirectory.Name = "buttonGetDirectory";
      this.buttonGetDirectory.Size = new System.Drawing.Size(35, 23);
      this.buttonGetDirectory.TabIndex = 9;
      this.buttonGetDirectory.Text = "...";
      this.buttonGetDirectory.UseVisualStyleBackColor = true;
      this.buttonGetDirectory.Click += new System.EventHandler(this.buttonGetDirectory_Click);
      // 
      // labelNumberListOfFiles
      // 
      this.labelNumberListOfFiles.AutoSize = true;
      this.labelNumberListOfFiles.Location = new System.Drawing.Point(83, 509);
      this.labelNumberListOfFiles.Name = "labelNumberListOfFiles";
      this.labelNumberListOfFiles.Size = new System.Drawing.Size(62, 17);
      this.labelNumberListOfFiles.TabIndex = 10;
      this.labelNumberListOfFiles.Text = "Number:";
      // 
      // labelNumberListOK
      // 
      this.labelNumberListOK.AutoSize = true;
      this.labelNumberListOK.Location = new System.Drawing.Point(419, 509);
      this.labelNumberListOK.Name = "labelNumberListOK";
      this.labelNumberListOK.Size = new System.Drawing.Size(62, 17);
      this.labelNumberListOK.TabIndex = 11;
      this.labelNumberListOK.Text = "Number:";
      // 
      // labelNumberListNOK
      // 
      this.labelNumberListNOK.AutoSize = true;
      this.labelNumberListNOK.Location = new System.Drawing.Point(787, 509);
      this.labelNumberListNOK.Name = "labelNumberListNOK";
      this.labelNumberListNOK.Size = new System.Drawing.Size(62, 17);
      this.labelNumberListNOK.TabIndex = 12;
      this.labelNumberListNOK.Text = "Number:";
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBar1.Location = new System.Drawing.Point(0, 577);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(1502, 23);
      this.progressBar1.TabIndex = 13;
      // 
      // labelNumberListFailed
      // 
      this.labelNumberListFailed.AutoSize = true;
      this.labelNumberListFailed.Location = new System.Drawing.Point(1143, 509);
      this.labelNumberListFailed.Name = "labelNumberListFailed";
      this.labelNumberListFailed.Size = new System.Drawing.Size(62, 17);
      this.labelNumberListFailed.TabIndex = 16;
      this.labelNumberListFailed.Text = "Number:";
      // 
      // labelFailedFiles
      // 
      this.labelFailedFiles.AutoSize = true;
      this.labelFailedFiles.Location = new System.Drawing.Point(1093, 173);
      this.labelFailedFiles.Name = "labelFailedFiles";
      this.labelFailedFiles.Size = new System.Drawing.Size(50, 17);
      this.labelFailedFiles.TabIndex = 15;
      this.labelFailedFiles.Text = "Failed:";
      // 
      // listBoxPDFFailed
      // 
      this.listBoxPDFFailed.FormattingEnabled = true;
      this.listBoxPDFFailed.ItemHeight = 16;
      this.listBoxPDFFailed.Location = new System.Drawing.Point(1146, 173);
      this.listBoxPDFFailed.Name = "listBoxPDFFailed";
      this.listBoxPDFFailed.ScrollAlwaysVisible = true;
      this.listBoxPDFFailed.Size = new System.Drawing.Size(296, 324);
      this.listBoxPDFFailed.TabIndex = 14;
      this.listBoxPDFFailed.SelectedIndexChanged += new System.EventHandler(this.listBoxPDFFailed_SelectedIndexChanged);
      // 
      // labelCurrentFile1
      // 
      this.labelCurrentFile1.AutoSize = true;
      this.labelCurrentFile1.Location = new System.Drawing.Point(3, 147);
      this.labelCurrentFile1.Name = "labelCurrentFile1";
      this.labelCurrentFile1.Size = new System.Drawing.Size(85, 17);
      this.labelCurrentFile1.TabIndex = 17;
      this.labelCurrentFile1.Text = "Current File:";
      // 
      // labelCurrentFile2
      // 
      this.labelCurrentFile2.AutoSize = true;
      this.labelCurrentFile2.Location = new System.Drawing.Point(90, 147);
      this.labelCurrentFile2.Name = "labelCurrentFile2";
      this.labelCurrentFile2.Size = new System.Drawing.Size(140, 17);
      this.labelCurrentFile2.TabIndex = 18;
      this.labelCurrentFile2.Text = "                                 ";
      // 
      // labeltimeSpent
      // 
      this.labeltimeSpent.AutoSize = true;
      this.labeltimeSpent.Location = new System.Drawing.Point(193, 118);
      this.labeltimeSpent.Name = "labeltimeSpent";
      this.labeltimeSpent.Size = new System.Drawing.Size(146, 17);
      this.labeltimeSpent.TabIndex = 19;
      this.labeltimeSpent.Text = "Time spent : 00:00:00";
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // labelSelectedFile
      // 
      this.labelSelectedFile.AutoSize = true;
      this.labelSelectedFile.Location = new System.Drawing.Point(83, 537);
      this.labelSelectedFile.Name = "labelSelectedFile";
      this.labelSelectedFile.Size = new System.Drawing.Size(93, 17);
      this.labelSelectedFile.TabIndex = 21;
      this.labelSelectedFile.Text = "Selected File:";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1502, 28);
      this.menuStrip1.TabIndex = 22;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.aproposdeToolStripMenuItem_Click);
      // 
      // labelSeparatedCaracter
      // 
      this.labelSeparatedCaracter.AutoSize = true;
      this.labelSeparatedCaracter.Location = new System.Drawing.Point(12, 80);
      this.labelSeparatedCaracter.Name = "labelSeparatedCaracter";
      this.labelSeparatedCaracter.Size = new System.Drawing.Size(134, 17);
      this.labelSeparatedCaracter.TabIndex = 24;
      this.labelSeparatedCaracter.Text = "Separated caracter:";
      // 
      // textBoxSeparatedCaracter
      // 
      this.textBoxSeparatedCaracter.Location = new System.Drawing.Point(153, 80);
      this.textBoxSeparatedCaracter.Name = "textBoxSeparatedCaracter";
      this.textBoxSeparatedCaracter.Size = new System.Drawing.Size(48, 22);
      this.textBoxSeparatedCaracter.TabIndex = 23;
      this.textBoxSeparatedCaracter.Text = "_";
      // 
      // checkBoxIncludeSubDirectories
      // 
      this.checkBoxIncludeSubDirectories.AutoSize = true;
      this.checkBoxIncludeSubDirectories.Location = new System.Drawing.Point(225, 82);
      this.checkBoxIncludeSubDirectories.Name = "checkBoxIncludeSubDirectories";
      this.checkBoxIncludeSubDirectories.Size = new System.Drawing.Size(177, 21);
      this.checkBoxIncludeSubDirectories.TabIndex = 27;
      this.checkBoxIncludeSubDirectories.Text = "Include sub-directories:";
      this.checkBoxIncludeSubDirectories.UseVisualStyleBackColor = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1502, 600);
      this.Controls.Add(this.checkBoxIncludeSubDirectories);
      this.Controls.Add(this.labelSeparatedCaracter);
      this.Controls.Add(this.textBoxSeparatedCaracter);
      this.Controls.Add(this.labelSelectedFile);
      this.Controls.Add(this.labeltimeSpent);
      this.Controls.Add(this.labelCurrentFile2);
      this.Controls.Add(this.labelCurrentFile1);
      this.Controls.Add(this.labelNumberListFailed);
      this.Controls.Add(this.labelFailedFiles);
      this.Controls.Add(this.listBoxPDFFailed);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.labelNumberListNOK);
      this.Controls.Add(this.labelNumberListOK);
      this.Controls.Add(this.labelNumberListOfFiles);
      this.Controls.Add(this.buttonGetDirectory);
      this.Controls.Add(this.labelFiles);
      this.Controls.Add(this.listBoxListOfFiles);
      this.Controls.Add(this.labelPDFNOK);
      this.Controls.Add(this.listBoxPDFNOK);
      this.Controls.Add(this.labelPDFOk);
      this.Controls.Add(this.listBoxPDFOK);
      this.Controls.Add(this.labelPdfPath);
      this.Controls.Add(this.textBoxPDFPath);
      this.Controls.Add(this.buttonCheckPdf);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "Check first word in PDF file name inside PDF itself";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCheckPdf;
    private System.Windows.Forms.TextBox textBoxPDFPath;
    private System.Windows.Forms.Label labelPdfPath;
    private System.Windows.Forms.ListBox listBoxPDFOK;
    private System.Windows.Forms.Label labelPDFOk;
    private System.Windows.Forms.Label labelPDFNOK;
    private System.Windows.Forms.ListBox listBoxPDFNOK;
    private System.Windows.Forms.Label labelFiles;
    private System.Windows.Forms.ListBox listBoxListOfFiles;
    private System.Windows.Forms.Button buttonGetDirectory;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Label labelNumberListOfFiles;
    private System.Windows.Forms.Label labelNumberListOK;
    private System.Windows.Forms.Label labelNumberListNOK;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label labelNumberListFailed;
    private System.Windows.Forms.Label labelFailedFiles;
    private System.Windows.Forms.ListBox listBoxPDFFailed;
    private System.Windows.Forms.Label labelCurrentFile1;
    private System.Windows.Forms.Label labelCurrentFile2;
    private System.Windows.Forms.Label labeltimeSpent;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label labelSelectedFile;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    private System.Windows.Forms.Label labelSeparatedCaracter;
    private System.Windows.Forms.TextBox textBoxSeparatedCaracter;
    private System.Windows.Forms.CheckBox checkBoxIncludeSubDirectories;
  }
}

