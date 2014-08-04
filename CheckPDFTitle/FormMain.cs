using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using CheckPDFTitle.Properties;

namespace CheckPDFTitle
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    TimeSpan _tempsPasse;
    private string _separatedCaracter = "-";

    private void FormMain_Load(object sender, EventArgs e)
    {
#if DEBUG
      textBoxPDFPath.Text = @"D:\MesDoc\dev\doc\code project articles";
#else
      textBoxPDFPath.Text = Directory.GetCurrentDirectory();
#endif
      DisplayTitle();
      progressBar1.Visible = false;
      GetWindowValue();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      textBoxSeparatedCaracter.Text = Settings.Default.SeparatedCaracter.ToString(CultureInfo.InvariantCulture);
      checkBoxIncludeSubDirectories.Checked = Settings.Default.IncludeSubDirectories;
      textBoxPDFPath.Text = Settings.Default.PdfPath;
    }

    private void buttonCheckPdf_Click(object sender, EventArgs e)
    {
      if (textBoxSeparatedCaracter.Text.Length != 1)
      {
        MessageBox.Show("Separated caracter must be only one caracter long.");
        return;
      }

      if (!IsAccessOkOn(textBoxPDFPath.Text))
      {
        MessageBox.Show("You don't have enough rights to access to directory\n{0}", textBoxPDFPath.Text);
        return;
      }

      _separatedCaracter = textBoxSeparatedCaracter.Text;
      progressBar1.Visible = true;
      timer1.Enabled = true;
      DateTime start = DateTime.Now;
      listBoxListOfFiles.Items.Clear();
      listBoxPDFOK.Items.Clear();
      listBoxPDFNOK.Items.Clear();
      listBoxPDFFailed.Items.Clear();
      const string searchPattern = "*.pdf";
      DirectoryInfo di = new DirectoryInfo(textBoxPDFPath.Text);
      SearchOption searchOption = checkBoxIncludeSubDirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
      // check rights to reach directory
      FileInfo[] files = di.GetFiles(searchPattern, searchOption);
      
      foreach (FileInfo file in files)
      {
        listBoxListOfFiles.Items.Add(file.Name);
      }

      progressBar1.Value = progressBar1.Minimum;
      progressBar1.Minimum = 1;
      progressBar1.Maximum = listBoxListOfFiles.Items.Count;
      int compteur = 1;
      progressBar1.Value = progressBar1.Minimum;
      foreach (string fichier in listBoxListOfFiles.Items)
      {
        string[] tableauMots = fichier.Split(_separatedCaracter[0]);
        string numeroRecherche = tableauMots[0];

        // searching the first word inside the PDF file itself
        string chaine = ExtractTextFromPdf(Path.Combine(di.ToString(), fichier));
        if (ParseUsingPdfBox(Path.Combine(di.ToString(), fichier)).Contains(numeroRecherche))
        {
          listBoxPDFOK.Items.Add(fichier);
        }
        else
        {
          listBoxPDFNOK.Items.Add(fichier);
        }

        progressBar1.Value = compteur;
        compteur++;
        Displaytotals();
        labelCurrentFile2.Text = fichier;
        Application.DoEvents();
      }

      timer1.Enabled = false;
      DateTime endProcess = DateTime.Now;
      TimeSpan ellapseTime = endProcess - start;
      progressBar1.Value = progressBar1.Minimum;
      Displaytotals();
      labeltimeSpent.Text = " Time spent is " + ellapseTime;
      MessageBox.Show("Done in " + ellapseTime);
      progressBar1.Visible = false;
      labelCurrentFile2.Text = string.Empty;
    }

    private static bool IsAccessOkOn(string path)
    {
      // TODO to be implemented
      return true;
    }

    private void Displaytotals()
    {
      DisplayTotalNumber(labelNumberListOfFiles, listBoxListOfFiles);
      DisplayTotalNumber(labelNumberListOK, listBoxPDFOK);
      DisplayTotalNumber(labelNumberListNOK, listBoxPDFNOK);
      DisplayTotalNumber(labelNumberListFailed, listBoxPDFFailed);
    }

    private string ParseUsingPdfBox(string input)
    {
      PDDocument doc = PDDocument.load(input);
      PDFTextStripper stripper = new PDFTextStripper();
      string result = string.Empty;
      try
      {
        result = stripper.getText(doc);
      }
      catch (Exception)
      {
        listBoxPDFFailed.Items.Add(input);
      }

      return result;
    }

    private static void DisplayTotalNumber(Control myLabel, ListBox myListBox)
    {
      myLabel.Text = string.Format("Number: {0}", myListBox.Items.Count);
    }

    private string ExtractTextFromPdf(string path)
    {
      return FilterWrapper.DefaultParser.Extract(path);
    }

    private void buttonGetDirectory_Click(object sender, EventArgs e)
    {
      folderBrowserDialog1.Description = @"Choose a folder";
      folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        textBoxPDFPath.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      _tempsPasse += TimeSpan.FromSeconds(1);
      labeltimeSpent.Text = "Time spent: " + _tempsPasse;
    }

    private void listBoxPDFFailed_SelectedIndexChanged(object sender, EventArgs e)
    {
      labelSelectedFile.Text = "Selected file : " + listBoxPDFFailed.SelectedItem;
    }

    private void listBoxListOfFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      labelSelectedFile.Text = "Selected file Name : " + listBoxListOfFiles.SelectedItem;
    }

    private void listBoxPDFOK_SelectedIndexChanged(object sender, EventArgs e)
    {
      labelSelectedFile.Text = "Selected file  Name : " + listBoxPDFOK.SelectedItem;
    }

    private void listBoxPDFNOK_SelectedIndexChanged(object sender, EventArgs e)
    {
      labelSelectedFile.Text = "Selected file Name : " + listBoxPDFNOK.SelectedItem;
    }

    private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveListBox("List of files.txt", listBoxListOfFiles);
      SaveListBox("List of PDF OK files.txt", listBoxPDFOK);
      SaveListBox("List of PDF NOK files.txt", listBoxPDFNOK);
      SaveListBox("List of PDF failed files.txt", listBoxPDFFailed);
      MessageBox.Show("Files have been saved to my documents directory");
      // open explorer to my documents
    }

    private void SaveListBox(string name, ListBox myListBox)
    {
      string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
      using (StreamWriter sw = new StreamWriter(myDocuments + name))
      {
        foreach (string file in myListBox.Items)
        {
          sw.WriteLine(file);
        }
      }
    }

    private void aproposdeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox1 ab = new AboutBox1();
      ab.Show();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.SeparatedCaracter = textBoxSeparatedCaracter.Text[0];
      Settings.Default.IncludeSubDirectories = checkBoxIncludeSubDirectories.Checked;
      Settings.Default.PdfPath = textBoxPDFPath.Text;
      Settings.Default.Save();
    }
  }
}