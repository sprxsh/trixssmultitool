using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Teen;

namespace IP_Multi_tool_V4
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private WebClient wb;
    private ThirteenForm BaseForm;
    private ThirteenTabControl thirteenTabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private ThirteenButton XButton;
    private Label label1;
    private ThirteenTextBox IPAddress;
    private ThirteenComboBox ToolsBox;
    private RichTextBox outputbox;
    private Label label2;
    private ThirteenButton colorbutton;
    private ThirteenButton Save;
    private ThirteenButton Clear;
    private ThirteenButton Tracker;
    private ThirteenRadioButton radioButton1;
    private ThirteenButton NordVPN;
    private TabPage tabPage4;
    private ThirteenButton Clear4;
    private ThirteenButton GenEmail;
    private ThirteenComboBox ToolsBox4;
    private RichTextBox outputbox2;
    private Label label3;
    private TabPage tabPage3;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private ThirteenTextBox AddressBox;
    private ThirteenTextBox EmailBox;
    private ThirteenTextBox PhoneBox;
    private ThirteenTextBox AgeBox;
    private RichTextBox ExtraDoxInfo;
    private ThirteenButton SaveDox;
    private Label label5;
    private ThirteenTextBox NameBox;
    private Label label11;
    private ThirteenTextBox FileSave;
    private RichTextBox outputbox4;
    private Label label12;
    private Label label13;
    private ThirteenButton thirteenButton1;

    public Form1()
    {
      this.wb = new WebClient();
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
            MessageBox.Show("Simple Source Code of this Dog Shit tool | Enjoy " +
                "\n" +
                "\nPlease dont use the Pass Gen for personal use smh" +
                "\nInstagram: @sprx.sh" +
                "\nCCM: sprx" +
                "\nCracked.to: sprx" +
                "\nDiscord: Cosmicツ#0999");
    }

    private void thirteenButton1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Tracker_Click(object sender, EventArgs e)
    {
      if (this.ToolsBox.Text == "Geo Lookup")
        this.outputbox.Text = this.wb.DownloadString(string.Format("http://ip-api.com/line/" + this.IPAddress.Text));
      if (this.ToolsBox.Text == "Port Scanner")
        this.outputbox.Text = this.wb.DownloadString(string.Format("https://api.hackertarget.com/nmap/?q=" + this.IPAddress.Text));
      if (this.ToolsBox.Text == "Ping IP")
        this.outputbox.Text = this.wb.DownloadString(string.Format("https://api.hackertarget.com/nping/?q=" + this.IPAddress.Text));
      if (this.ToolsBox.Text == "Cloudflare Resolver")
        this.outputbox.Text = this.wb.DownloadString(string.Format("https://webresolver.nl/api.php?key=9L0OM-92QGF-WUFML-CWJ1Y&html=0&action=cloudflare&string=" + this.IPAddress.Text));
      if (this.ToolsBox.Text == "DNS Resolver")
        this.outputbox.Text = this.wb.DownloadString(string.Format("https://webresolver.nl/api.php?key=9L0OM-92QGF-WUFML-CWJ1Y&html=0&action=dns&string=" + this.IPAddress.Text));
      if (!(this.ToolsBox.Text == "Credits"))
        return;
      this.outputbox.Text = this.wb.DownloadString(string.Format("https://pastebin.com/raw/RyUN7FCZ"));
    }

    private void Clear_Click(object sender, EventArgs e)
    {
      this.outputbox.Text = "";
    }

    private void Save_Click(object sender, EventArgs e)
    {
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
          this.outputbox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
        this.Text = saveFileDialog.FileName;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Something went wrong :/", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void Generate_Click(object sender, EventArgs e)
    {
    }

    private void thirteenButton2_Click(object sender, EventArgs e)
    {
      if (!this.radioButton1.Checked)
        return;
      string[] strArray = new WebClient().DownloadString("https://pastebin.com/raw/UswFtFQZ").Split('\n');
      this.outputbox2.Text = strArray[new Random().Next(0, strArray.Length)];
    }

    private void GenEmail_Click(object sender, EventArgs e)
    {
      if (this.ToolsBox4.Text == "Email Generator")
        this.outputbox4.Text = this.wb.DownloadString(string.Format("https://pastebin.com/raw/U4EXUubm"));
      if (this.ToolsBox4.Text == "Password Generator")
        this.outputbox4.Text = this.wb.DownloadString(string.Format("https://pastebin.com/raw/VRDffN7N"));
      if (this.ToolsBox4.Text == "Strong Password Generator")
        this.outputbox4.Text = this.wb.DownloadString(string.Format("https://pastebin.com/raw/Ybn4mh72"));
      if (this.ToolsBox4.Text == "MAX Password Generator")
        this.outputbox4.Text = this.wb.DownloadString(string.Format("https://pastebin.com/raw/6FkZ2mMW"));
      if (!(this.ToolsBox4.Text == "Generate Email and Password"))
        return;
      this.outputbox4.Text = this.wb.DownloadString(string.Format("https://pastebin.com/raw/8bVhDBL4"));
    }

    private void Clear4_Click(object sender, EventArgs e)
    {
      this.outputbox4.Text = "";
    }

    private void LyricSearch_Click(object sender, EventArgs e)
    {
    }

    private void thirteenButton3_Click(object sender, EventArgs e)
    {
      ColorDialog colorDialog = new ColorDialog();
      colorDialog.AllowFullOpen = true;
      colorDialog.ShowHelp = true;
      colorDialog.Color = this.BackColor;
      if (colorDialog.ShowDialog() == DialogResult.OK)
        this.BaseForm.AccentColor = colorDialog.Color;
      this.label1.ForeColor = colorDialog.Color;
      this.label2.ForeColor = colorDialog.Color;
      this.BaseForm.AccentColor = colorDialog.Color;
      this.ToolsBox.AccentColor = colorDialog.Color;
      this.colorbutton.AccentColor = colorDialog.Color;
      this.IPAddress.ForeColor = colorDialog.Color;
      this.outputbox.ForeColor = colorDialog.Color;
      this.outputbox2.ForeColor = colorDialog.Color;
      this.outputbox4.ForeColor = colorDialog.Color;
      this.Tracker.AccentColor = colorDialog.Color;
      this.Save.AccentColor = colorDialog.Color;
      this.Clear.AccentColor = colorDialog.Color;
      this.colorbutton.AccentColor = colorDialog.Color;
      this.ToolsBox.ForeColor = colorDialog.Color;
      this.ToolsBox4.ForeColor = colorDialog.Color;
      this.ToolsBox.AccentColor = colorDialog.Color;
      this.ToolsBox4.AccentColor = colorDialog.Color;
      this.XButton.AccentColor = colorDialog.Color;
      this.Clear4.AccentColor = colorDialog.Color;
      this.NordVPN.AccentColor = colorDialog.Color;
      this.radioButton1.ForeColor = colorDialog.Color;
      this.XButton.AccentColor = colorDialog.Color;
      this.GenEmail.AccentColor = colorDialog.Color;
      this.thirteenTabControl1.AccentColor = colorDialog.Color;
      this.label5.ForeColor = colorDialog.Color;
      this.label6.ForeColor = colorDialog.Color;
      this.label7.ForeColor = colorDialog.Color;
      this.label8.ForeColor = colorDialog.Color;
      this.label9.ForeColor = colorDialog.Color;
      this.label10.ForeColor = colorDialog.Color;
      this.label11.ForeColor = colorDialog.Color;
      this.label12.ForeColor = colorDialog.Color;
      this.NameBox.ForeColor = colorDialog.Color;
      this.AgeBox.ForeColor = colorDialog.Color;
      this.PhoneBox.ForeColor = colorDialog.Color;
      this.EmailBox.ForeColor = colorDialog.Color;
      this.AddressBox.ForeColor = colorDialog.Color;
      this.SaveDox.AccentColor = colorDialog.Color;
      this.FileSave.ForeColor = colorDialog.Color;
      this.ExtraDoxInfo.ForeColor = colorDialog.Color;
    }

    private void SaveDox_Click(object sender, EventArgs e)
    {
      using (StreamWriter text = System.IO.File.CreateText(AppDomain.CurrentDomain.BaseDirectory + this.FileSave.Text + ".txt"))
      {
        text.WriteLine("Name: " + this.NameBox.Text);
        text.WriteLine("Age: " + this.AgeBox.Text);
        text.WriteLine("Phone Number: " + this.PhoneBox.Text);
        text.WriteLine("Email: " + this.EmailBox.Text);
        text.WriteLine("Address: " + this.AddressBox.Text);
        text.WriteLine("=========");
        text.WriteLine("Extras");
        text.WriteLine("=========");
        text.WriteLine(this.ExtraDoxInfo.Text);
      }
      int num = (int) MessageBox.Show("Dox Text File will be saved in the folder with Multi Tool V4");
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    private void thirteenButton1_Click_1(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Simple Source Code of this Dog Shit tool | Enjoy " +
    "\n" +
    "\nInstagram: @sprx.sh" +
    "\nCCM: sprx" +
    "\nCracked.to: sprx" +
    "\nDiscord: Cosmicツ#0999");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.BaseForm = new Teen.ThirteenForm();
            this.XButton = new Teen.ThirteenButton();
            this.thirteenTabControl1 = new Teen.ThirteenTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.thirteenButton1 = new Teen.ThirteenButton();
            this.label13 = new System.Windows.Forms.Label();
            this.colorbutton = new Teen.ThirteenButton();
            this.Save = new Teen.ThirteenButton();
            this.Clear = new Teen.ThirteenButton();
            this.Tracker = new Teen.ThirteenButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddress = new Teen.ThirteenTextBox();
            this.ToolsBox = new Teen.ThirteenComboBox();
            this.outputbox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.outputbox2 = new System.Windows.Forms.RichTextBox();
            this.NordVPN = new Teen.ThirteenButton();
            this.radioButton1 = new Teen.ThirteenRadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.outputbox4 = new System.Windows.Forms.RichTextBox();
            this.Clear4 = new Teen.ThirteenButton();
            this.GenEmail = new Teen.ThirteenButton();
            this.ToolsBox4 = new Teen.ThirteenComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.FileSave = new Teen.ThirteenTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressBox = new Teen.ThirteenTextBox();
            this.EmailBox = new Teen.ThirteenTextBox();
            this.PhoneBox = new Teen.ThirteenTextBox();
            this.AgeBox = new Teen.ThirteenTextBox();
            this.ExtraDoxInfo = new System.Windows.Forms.RichTextBox();
            this.SaveDox = new Teen.ThirteenButton();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new Teen.ThirteenTextBox();
            this.BaseForm.SuspendLayout();
            this.thirteenTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.BaseForm.AccentColor = System.Drawing.Color.DodgerBlue;
            this.BaseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BaseForm.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.BaseForm.Controls.Add(this.XButton);
            this.BaseForm.Controls.Add(this.thirteenTabControl1);
            this.BaseForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseForm.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.BaseForm.ForeColor = System.Drawing.Color.White;
            this.BaseForm.Location = new System.Drawing.Point(0, 0);
            this.BaseForm.Name = "BaseForm";
            this.BaseForm.Size = new System.Drawing.Size(454, 353);
            this.BaseForm.TabIndex = 0;
            this.BaseForm.Text = "Multi Tool V4";
            // 
            // XButton
            // 
            this.XButton.AccentColor = System.Drawing.Color.DodgerBlue;
            this.XButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.XButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.XButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.XButton.ForeColor = System.Drawing.Color.White;
            this.XButton.Location = new System.Drawing.Point(424, 3);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(27, 23);
            this.XButton.TabIndex = 1;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.thirteenButton1_Click);
            // 
            // thirteenTabControl1
            // 
            this.thirteenTabControl1.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenTabControl1.ColorScheme = Teen.ThirteenTabControl.ColorSchemes.Dark;
            this.thirteenTabControl1.Controls.Add(this.tabPage1);
            this.thirteenTabControl1.Controls.Add(this.tabPage2);
            this.thirteenTabControl1.Controls.Add(this.tabPage4);
            this.thirteenTabControl1.Controls.Add(this.tabPage3);
            this.thirteenTabControl1.ForeColor = System.Drawing.Color.White;
            this.thirteenTabControl1.Location = new System.Drawing.Point(7, 35);
            this.thirteenTabControl1.Name = "thirteenTabControl1";
            this.thirteenTabControl1.SelectedIndex = 0;
            this.thirteenTabControl1.Size = new System.Drawing.Size(444, 312);
            this.thirteenTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.thirteenButton1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.colorbutton);
            this.tabPage1.Controls.Add(this.Save);
            this.tabPage1.Controls.Add(this.Clear);
            this.tabPage1.Controls.Add(this.Tracker);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.IPAddress);
            this.tabPage1.Controls.Add(this.ToolsBox);
            this.tabPage1.Controls.Add(this.outputbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IP Tools";
            // 
            // thirteenButton1
            // 
            this.thirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton1.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton1.ForeColor = System.Drawing.Color.White;
            this.thirteenButton1.Location = new System.Drawing.Point(3, 237);
            this.thirteenButton1.Name = "thirteenButton1";
            this.thirteenButton1.Size = new System.Drawing.Size(164, 23);
            this.thirteenButton1.TabIndex = 10;
            this.thirteenButton1.Text = "SKIDSTER LOG";
            this.thirteenButton1.UseVisualStyleBackColor = false;
            this.thirteenButton1.Click += new System.EventHandler(this.thirteenButton1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Multi Tool V4.1.0";
            // 
            // colorbutton
            // 
            this.colorbutton.AccentColor = System.Drawing.Color.DodgerBlue;
            this.colorbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.colorbutton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.colorbutton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.colorbutton.ForeColor = System.Drawing.Color.White;
            this.colorbutton.Location = new System.Drawing.Point(3, 193);
            this.colorbutton.Name = "colorbutton";
            this.colorbutton.Size = new System.Drawing.Size(164, 23);
            this.colorbutton.TabIndex = 8;
            this.colorbutton.Text = "Color Box";
            this.colorbutton.UseVisualStyleBackColor = false;
            this.colorbutton.Click += new System.EventHandler(this.thirteenButton3_Click);
            // 
            // Save
            // 
            this.Save.AccentColor = System.Drawing.Color.DodgerBlue;
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Save.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.Save.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(3, 164);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(164, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save Results";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.AccentColor = System.Drawing.Color.DodgerBlue;
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Clear.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.Clear.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(3, 135);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(164, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear output box";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Tracker
            // 
            this.Tracker.AccentColor = System.Drawing.Color.DodgerBlue;
            this.Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tracker.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.Tracker.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Tracker.ForeColor = System.Drawing.Color.White;
            this.Tracker.Location = new System.Drawing.Point(3, 106);
            this.Tracker.Name = "Tracker";
            this.Tracker.Size = new System.Drawing.Size(164, 23);
            this.Tracker.TabIndex = 5;
            this.Tracker.Text = "Search";
            this.Tracker.UseVisualStyleBackColor = false;
            this.Tracker.Click += new System.EventHandler(this.Tracker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Methods:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address:";
            // 
            // IPAddress
            // 
            this.IPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPAddress.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.IPAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.IPAddress.ForeColor = System.Drawing.Color.White;
            this.IPAddress.Location = new System.Drawing.Point(3, 26);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(164, 25);
            this.IPAddress.TabIndex = 2;
            // 
            // ToolsBox
            // 
            this.ToolsBox.AccentColor = System.Drawing.Color.DodgerBlue;
            this.ToolsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolsBox.ColorScheme = Teen.ThirteenComboBox.ColorSchemes.Dark;
            this.ToolsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ToolsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolsBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.ToolsBox.ForeColor = System.Drawing.Color.White;
            this.ToolsBox.FormattingEnabled = true;
            this.ToolsBox.Items.AddRange(new object[] {
            "Geo Lookup",
            "Port Scanner",
            "Ping IP",
            "Credits"});
            this.ToolsBox.Location = new System.Drawing.Point(3, 74);
            this.ToolsBox.Name = "ToolsBox";
            this.ToolsBox.Size = new System.Drawing.Size(164, 26);
            this.ToolsBox.TabIndex = 1;
            // 
            // outputbox
            // 
            this.outputbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.outputbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputbox.ForeColor = System.Drawing.Color.White;
            this.outputbox.Location = new System.Drawing.Point(183, 6);
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.Size = new System.Drawing.Size(247, 272);
            this.outputbox.TabIndex = 0;
            this.outputbox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.outputbox2);
            this.tabPage2.Controls.Add(this.NordVPN);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generators";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 22;
            // 
            // outputbox2
            // 
            this.outputbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.outputbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputbox2.ForeColor = System.Drawing.Color.White;
            this.outputbox2.Location = new System.Drawing.Point(184, 6);
            this.outputbox2.Name = "outputbox2";
            this.outputbox2.ReadOnly = true;
            this.outputbox2.Size = new System.Drawing.Size(247, 272);
            this.outputbox2.TabIndex = 21;
            this.outputbox2.Text = "";
            // 
            // NordVPN
            // 
            this.NordVPN.AccentColor = System.Drawing.Color.DodgerBlue;
            this.NordVPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NordVPN.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.NordVPN.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.NordVPN.ForeColor = System.Drawing.Color.White;
            this.NordVPN.Location = new System.Drawing.Point(3, 6);
            this.NordVPN.Name = "NordVPN";
            this.NordVPN.Size = new System.Drawing.Size(143, 23);
            this.NordVPN.TabIndex = 20;
            this.NordVPN.Text = "Nord VPN Account";
            this.NordVPN.UseVisualStyleBackColor = false;
            this.NordVPN.Click += new System.EventHandler(this.thirteenButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = false;
            this.radioButton1.ColorScheme = Teen.ThirteenRadioButton.ColorSchemes.Dark;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(3, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(185, 18);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.Text = "Tick To Generate NordVPN";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.outputbox4);
            this.tabPage4.Controls.Add(this.Clear4);
            this.tabPage4.Controls.Add(this.GenEmail);
            this.tabPage4.Controls.Add(this.ToolsBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(436, 283);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Email Generator";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Email and Pass:";
            // 
            // outputbox4
            // 
            this.outputbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.outputbox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputbox4.ForeColor = System.Drawing.Color.White;
            this.outputbox4.Location = new System.Drawing.Point(149, 6);
            this.outputbox4.Name = "outputbox4";
            this.outputbox4.Size = new System.Drawing.Size(281, 272);
            this.outputbox4.TabIndex = 27;
            this.outputbox4.Text = "";
            // 
            // Clear4
            // 
            this.Clear4.AccentColor = System.Drawing.Color.DodgerBlue;
            this.Clear4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Clear4.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.Clear4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Clear4.ForeColor = System.Drawing.Color.White;
            this.Clear4.Location = new System.Drawing.Point(3, 87);
            this.Clear4.Name = "Clear4";
            this.Clear4.Size = new System.Drawing.Size(137, 23);
            this.Clear4.TabIndex = 17;
            this.Clear4.Text = "Clear output box";
            this.Clear4.UseVisualStyleBackColor = false;
            this.Clear4.Click += new System.EventHandler(this.Clear4_Click);
            // 
            // GenEmail
            // 
            this.GenEmail.AccentColor = System.Drawing.Color.DodgerBlue;
            this.GenEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GenEmail.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.GenEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.GenEmail.ForeColor = System.Drawing.Color.White;
            this.GenEmail.Location = new System.Drawing.Point(3, 58);
            this.GenEmail.Name = "GenEmail";
            this.GenEmail.Size = new System.Drawing.Size(137, 23);
            this.GenEmail.TabIndex = 16;
            this.GenEmail.Text = "Generate";
            this.GenEmail.UseVisualStyleBackColor = false;
            this.GenEmail.Click += new System.EventHandler(this.GenEmail_Click);
            // 
            // ToolsBox4
            // 
            this.ToolsBox4.AccentColor = System.Drawing.Color.DodgerBlue;
            this.ToolsBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolsBox4.ColorScheme = Teen.ThirteenComboBox.ColorSchemes.Dark;
            this.ToolsBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ToolsBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolsBox4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.ToolsBox4.ForeColor = System.Drawing.Color.White;
            this.ToolsBox4.FormattingEnabled = true;
            this.ToolsBox4.Items.AddRange(new object[] {
            "Email Generator",
            "Password Generator",
            "Strong Password Generator",
            "MAX Password Generator",
            "Generate Email and Password"});
            this.ToolsBox4.Location = new System.Drawing.Point(3, 26);
            this.ToolsBox4.Name = "ToolsBox4";
            this.ToolsBox4.Size = new System.Drawing.Size(137, 26);
            this.ToolsBox4.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.FileSave);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.AddressBox);
            this.tabPage3.Controls.Add(this.EmailBox);
            this.tabPage3.Controls.Add(this.PhoneBox);
            this.tabPage3.Controls.Add(this.AgeBox);
            this.tabPage3.Controls.Add(this.ExtraDoxInfo);
            this.tabPage3.Controls.Add(this.SaveDox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.NameBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 283);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Dox Creater";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "File Save Name:";
            // 
            // FileSave
            // 
            this.FileSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FileSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSave.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.FileSave.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.FileSave.ForeColor = System.Drawing.Color.White;
            this.FileSave.Location = new System.Drawing.Point(186, 23);
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(246, 25);
            this.FileSave.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Extra Info:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Email Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Age:";
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.AddressBox.ForeColor = System.Drawing.Color.White;
            this.AddressBox.Location = new System.Drawing.Point(5, 215);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(174, 25);
            this.AddressBox.TabIndex = 30;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.EmailBox.ForeColor = System.Drawing.Color.White;
            this.EmailBox.Location = new System.Drawing.Point(6, 167);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(174, 25);
            this.EmailBox.TabIndex = 29;
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.PhoneBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.PhoneBox.ForeColor = System.Drawing.Color.White;
            this.PhoneBox.Location = new System.Drawing.Point(6, 119);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(174, 25);
            this.PhoneBox.TabIndex = 28;
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.AgeBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.AgeBox.ForeColor = System.Drawing.Color.White;
            this.AgeBox.Location = new System.Drawing.Point(4, 74);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(176, 25);
            this.AgeBox.TabIndex = 27;
            // 
            // ExtraDoxInfo
            // 
            this.ExtraDoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExtraDoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraDoxInfo.ForeColor = System.Drawing.Color.White;
            this.ExtraDoxInfo.Location = new System.Drawing.Point(185, 74);
            this.ExtraDoxInfo.Name = "ExtraDoxInfo";
            this.ExtraDoxInfo.Size = new System.Drawing.Size(247, 195);
            this.ExtraDoxInfo.TabIndex = 26;
            this.ExtraDoxInfo.Text = "";
            // 
            // SaveDox
            // 
            this.SaveDox.AccentColor = System.Drawing.Color.DodgerBlue;
            this.SaveDox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveDox.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.SaveDox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.SaveDox.ForeColor = System.Drawing.Color.White;
            this.SaveDox.Location = new System.Drawing.Point(4, 246);
            this.SaveDox.Name = "SaveDox";
            this.SaveDox.Size = new System.Drawing.Size(176, 23);
            this.SaveDox.TabIndex = 24;
            this.SaveDox.Text = "Save Dox Info";
            this.SaveDox.UseVisualStyleBackColor = false;
            this.SaveDox.Click += new System.EventHandler(this.SaveDox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Name:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(4, 23);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 25);
            this.NameBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(454, 353);
            this.Controls.Add(this.BaseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BaseForm.ResumeLayout(false);
            this.thirteenTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

    }
  }
}
