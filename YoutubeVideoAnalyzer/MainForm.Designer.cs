namespace YoutubeVideoAnalyser
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.useExternalGroupBox = new System.Windows.Forms.GroupBox();
			this.useExternalTlp = new System.Windows.Forms.TableLayoutPanel();
			this.useExternalExplanationLabel = new System.Windows.Forms.Label();
			this.signInButton = new System.Windows.Forms.Button();
			this.exportCsvTextbox = new System.Windows.Forms.TextBox();
			this.filterFromCheckbox = new System.Windows.Forms.Label();
			this.filterToCheckbox = new System.Windows.Forms.Label();
			this.exportCsvCheckbox = new System.Windows.Forms.CheckBox();
			this.analysePublicCheckbox = new System.Windows.Forms.CheckBox();
			this.exportCsvButton = new System.Windows.Forms.Button();
			this.afterDtp = new System.Windows.Forms.DateTimePicker();
			this.beforeDtp = new System.Windows.Forms.DateTimePicker();
			this.accountGroupbox = new System.Windows.Forms.GroupBox();
			this.accountTlp = new System.Windows.Forms.TableLayoutPanel();
			this.loggedOutTlp = new System.Windows.Forms.TableLayoutPanel();
			this.useExternalCodeLabel = new System.Windows.Forms.Label();
			this.useExternalCodeTextbox = new System.Windows.Forms.TextBox();
			this.useExternalDescLabel = new System.Windows.Forms.Label();
			this.useExternalLinkTextbox = new System.Windows.Forms.TextBox();
			this.useExternalLinkLabel = new System.Windows.Forms.LinkLabel();
			this.loggedInTlp = new System.Windows.Forms.TableLayoutPanel();
			this.loggedInLabel = new System.Windows.Forms.Label();
			this.logoutButton = new System.Windows.Forms.Button();
			this.resultTextbox = new System.Windows.Forms.TextBox();
			this.analyseUnlistedCheckbox = new System.Windows.Forms.CheckBox();
			this.analysePrivateCheckbox = new System.Windows.Forms.CheckBox();
			this.analyseVideosCheckbox = new System.Windows.Forms.CheckBox();
			this.analyseLivestreamsCheckbox = new System.Windows.Forms.CheckBox();
			this.exportCsvDialog = new System.Windows.Forms.SaveFileDialog();
			this.useExternalGroupBox.SuspendLayout();
			this.useExternalTlp.SuspendLayout();
			this.accountGroupbox.SuspendLayout();
			this.accountTlp.SuspendLayout();
			this.loggedOutTlp.SuspendLayout();
			this.loggedInTlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// useExternalGroupBox
			// 
			this.useExternalGroupBox.AutoSize = true;
			this.useExternalGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.useExternalGroupBox.Controls.Add(this.useExternalTlp);
			this.useExternalGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.useExternalGroupBox.Location = new System.Drawing.Point(0, 0);
			this.useExternalGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.useExternalGroupBox.Name = "useExternalGroupBox";
			this.useExternalGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.useExternalGroupBox.Size = new System.Drawing.Size(685, 649);
			this.useExternalGroupBox.TabIndex = 3;
			this.useExternalGroupBox.TabStop = false;
			// 
			// useExternalTlp
			// 
			this.useExternalTlp.AutoSize = true;
			this.useExternalTlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.useExternalTlp.ColumnCount = 7;
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.useExternalTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.Controls.Add(this.useExternalExplanationLabel, 1, 1);
			this.useExternalTlp.Controls.Add(this.signInButton, 3, 21);
			this.useExternalTlp.Controls.Add(this.exportCsvTextbox, 3, 9);
			this.useExternalTlp.Controls.Add(this.filterFromCheckbox, 1, 5);
			this.useExternalTlp.Controls.Add(this.filterToCheckbox, 1, 7);
			this.useExternalTlp.Controls.Add(this.exportCsvCheckbox, 1, 9);
			this.useExternalTlp.Controls.Add(this.analysePublicCheckbox, 1, 11);
			this.useExternalTlp.Controls.Add(this.exportCsvButton, 5, 9);
			this.useExternalTlp.Controls.Add(this.afterDtp, 3, 5);
			this.useExternalTlp.Controls.Add(this.beforeDtp, 3, 7);
			this.useExternalTlp.Controls.Add(this.accountGroupbox, 1, 3);
			this.useExternalTlp.Controls.Add(this.resultTextbox, 1, 23);
			this.useExternalTlp.Controls.Add(this.analyseUnlistedCheckbox, 1, 13);
			this.useExternalTlp.Controls.Add(this.analysePrivateCheckbox, 1, 15);
			this.useExternalTlp.Controls.Add(this.analyseVideosCheckbox, 1, 17);
			this.useExternalTlp.Controls.Add(this.analyseLivestreamsCheckbox, 1, 19);
			this.useExternalTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.useExternalTlp.Location = new System.Drawing.Point(2, 15);
			this.useExternalTlp.Margin = new System.Windows.Forms.Padding(2);
			this.useExternalTlp.Name = "useExternalTlp";
			this.useExternalTlp.RowCount = 25;
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.useExternalTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.useExternalTlp.Size = new System.Drawing.Size(681, 632);
			this.useExternalTlp.TabIndex = 0;
			// 
			// useExternalExplanationLabel
			// 
			this.useExternalExplanationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.useExternalExplanationLabel.AutoSize = true;
			this.useExternalTlp.SetColumnSpan(this.useExternalExplanationLabel, 5);
			this.useExternalExplanationLabel.Location = new System.Drawing.Point(12, 10);
			this.useExternalExplanationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.useExternalExplanationLabel.Name = "useExternalExplanationLabel";
			this.useExternalExplanationLabel.Size = new System.Drawing.Size(657, 39);
			this.useExternalExplanationLabel.TabIndex = 1;
			this.useExternalExplanationLabel.Text = resources.GetString("useExternalExplanationLabel.Text");
			// 
			// signInButton
			// 
			this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.signInButton.AutoSize = true;
			this.signInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.useExternalTlp.SetColumnSpan(this.signInButton, 3);
			this.signInButton.Location = new System.Drawing.Point(268, 444);
			this.signInButton.Margin = new System.Windows.Forms.Padding(0);
			this.signInButton.Name = "signInButton";
			this.signInButton.Padding = new System.Windows.Forms.Padding(11, 2, 11, 2);
			this.signInButton.Size = new System.Drawing.Size(403, 27);
			this.signInButton.TabIndex = 4;
			this.signInButton.Text = "Statistiken abrufen (kann etwas dauern, da die Youtube-API sehr langsam ist)";
			this.signInButton.UseVisualStyleBackColor = true;
			this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
			// 
			// exportCsvTextbox
			// 
			this.exportCsvTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.exportCsvTextbox.Enabled = false;
			this.exportCsvTextbox.Location = new System.Drawing.Point(137, 277);
			this.exportCsvTextbox.Margin = new System.Windows.Forms.Padding(0);
			this.exportCsvTextbox.Name = "exportCsvTextbox";
			this.exportCsvTextbox.Size = new System.Drawing.Size(486, 20);
			this.exportCsvTextbox.TabIndex = 3;
			// 
			// filterFromCheckbox
			// 
			this.filterFromCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.filterFromCheckbox.AutoSize = true;
			this.filterFromCheckbox.Location = new System.Drawing.Point(10, 219);
			this.filterFromCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.filterFromCheckbox.Name = "filterFromCheckbox";
			this.filterFromCheckbox.Size = new System.Drawing.Size(117, 13);
			this.filterFromCheckbox.TabIndex = 5;
			this.filterFromCheckbox.Text = "Hochladezeitpunkt ab:";
			// 
			// filterToCheckbox
			// 
			this.filterToCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.filterToCheckbox.AutoSize = true;
			this.filterToCheckbox.Location = new System.Drawing.Point(10, 249);
			this.filterToCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.filterToCheckbox.Name = "filterToCheckbox";
			this.filterToCheckbox.Size = new System.Drawing.Size(117, 13);
			this.filterToCheckbox.TabIndex = 6;
			this.filterToCheckbox.Text = "Hochladezeitpunkt bis:";
			// 
			// exportCsvCheckbox
			// 
			this.exportCsvCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.exportCsvCheckbox.AutoSize = true;
			this.exportCsvCheckbox.Location = new System.Drawing.Point(10, 279);
			this.exportCsvCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.exportCsvCheckbox.Name = "exportCsvCheckbox";
			this.exportCsvCheckbox.Size = new System.Drawing.Size(117, 17);
			this.exportCsvCheckbox.TabIndex = 7;
			this.exportCsvCheckbox.Text = "In CSV exportieren:";
			this.exportCsvCheckbox.UseVisualStyleBackColor = true;
			this.exportCsvCheckbox.CheckedChanged += new System.EventHandler(this.exportCsvCheckbox_CheckedChanged);
			// 
			// analysePublicCheckbox
			// 
			this.analysePublicCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.analysePublicCheckbox.AutoSize = true;
			this.analysePublicCheckbox.Checked = true;
			this.analysePublicCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useExternalTlp.SetColumnSpan(this.analysePublicCheckbox, 5);
			this.analysePublicCheckbox.Location = new System.Drawing.Point(10, 309);
			this.analysePublicCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.analysePublicCheckbox.Name = "analysePublicCheckbox";
			this.analysePublicCheckbox.Size = new System.Drawing.Size(661, 17);
			this.analysePublicCheckbox.TabIndex = 8;
			this.analysePublicCheckbox.Text = "Öffentliche Videos berücksichtigen";
			this.analysePublicCheckbox.UseVisualStyleBackColor = true;
			this.analysePublicCheckbox.CheckedChanged += new System.EventHandler(this.analysePublicCheckbox_CheckedChanged);
			// 
			// exportCsvButton
			// 
			this.exportCsvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.exportCsvButton.AutoSize = true;
			this.exportCsvButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.exportCsvButton.Enabled = false;
			this.exportCsvButton.Location = new System.Drawing.Point(633, 276);
			this.exportCsvButton.Margin = new System.Windows.Forms.Padding(0);
			this.exportCsvButton.Name = "exportCsvButton";
			this.exportCsvButton.Size = new System.Drawing.Size(38, 23);
			this.exportCsvButton.TabIndex = 9;
			this.exportCsvButton.Text = "[ ... ]";
			this.exportCsvButton.UseVisualStyleBackColor = true;
			this.exportCsvButton.Click += new System.EventHandler(this.exportCsvButton_Click);
			// 
			// afterDtp
			// 
			this.afterDtp.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.afterDtp.CustomFormat = "dd. MMMM yyyy HH:mm";
			this.afterDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.afterDtp.Location = new System.Drawing.Point(137, 216);
			this.afterDtp.Margin = new System.Windows.Forms.Padding(0);
			this.afterDtp.Name = "afterDtp";
			this.afterDtp.Size = new System.Drawing.Size(200, 20);
			this.afterDtp.TabIndex = 10;
			// 
			// beforeDtp
			// 
			this.beforeDtp.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.beforeDtp.CustomFormat = "dd. MMMM yyyy HH:mm";
			this.beforeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.beforeDtp.Location = new System.Drawing.Point(137, 246);
			this.beforeDtp.Margin = new System.Windows.Forms.Padding(0);
			this.beforeDtp.Name = "beforeDtp";
			this.beforeDtp.Size = new System.Drawing.Size(200, 20);
			this.beforeDtp.TabIndex = 11;
			// 
			// accountGroupbox
			// 
			this.accountGroupbox.AutoSize = true;
			this.accountGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.useExternalTlp.SetColumnSpan(this.accountGroupbox, 5);
			this.accountGroupbox.Controls.Add(this.accountTlp);
			this.accountGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountGroupbox.Location = new System.Drawing.Point(13, 62);
			this.accountGroupbox.Name = "accountGroupbox";
			this.accountGroupbox.Size = new System.Drawing.Size(655, 141);
			this.accountGroupbox.TabIndex = 12;
			this.accountGroupbox.TabStop = false;
			this.accountGroupbox.Text = "Youtube-Account";
			// 
			// accountTlp
			// 
			this.accountTlp.AutoSize = true;
			this.accountTlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.accountTlp.ColumnCount = 1;
			this.accountTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.accountTlp.Controls.Add(this.loggedOutTlp, 0, 0);
			this.accountTlp.Controls.Add(this.loggedInTlp, 0, 1);
			this.accountTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountTlp.Location = new System.Drawing.Point(3, 16);
			this.accountTlp.Margin = new System.Windows.Forms.Padding(0);
			this.accountTlp.Name = "accountTlp";
			this.accountTlp.RowCount = 2;
			this.accountTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.accountTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.accountTlp.Size = new System.Drawing.Size(649, 122);
			this.accountTlp.TabIndex = 0;
			// 
			// loggedOutTlp
			// 
			this.loggedOutTlp.AutoSize = true;
			this.loggedOutTlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loggedOutTlp.ColumnCount = 5;
			this.loggedOutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.loggedOutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.loggedOutTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.Controls.Add(this.useExternalCodeLabel, 1, 5);
			this.loggedOutTlp.Controls.Add(this.useExternalCodeTextbox, 3, 5);
			this.loggedOutTlp.Controls.Add(this.useExternalDescLabel, 1, 1);
			this.loggedOutTlp.Controls.Add(this.useExternalLinkTextbox, 3, 1);
			this.loggedOutTlp.Controls.Add(this.useExternalLinkLabel, 3, 3);
			this.loggedOutTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loggedOutTlp.Location = new System.Drawing.Point(0, 0);
			this.loggedOutTlp.Margin = new System.Windows.Forms.Padding(0);
			this.loggedOutTlp.Name = "loggedOutTlp";
			this.loggedOutTlp.RowCount = 7;
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.loggedOutTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedOutTlp.Size = new System.Drawing.Size(649, 93);
			this.loggedOutTlp.TabIndex = 0;
			// 
			// useExternalCodeLabel
			// 
			this.useExternalCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.useExternalCodeLabel.AutoSize = true;
			this.useExternalCodeLabel.Location = new System.Drawing.Point(10, 66);
			this.useExternalCodeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.useExternalCodeLabel.Name = "useExternalCodeLabel";
			this.useExternalCodeLabel.Size = new System.Drawing.Size(119, 13);
			this.useExternalCodeLabel.TabIndex = 0;
			this.useExternalCodeLabel.Text = "Code eintragen: ";
			// 
			// useExternalCodeTextbox
			// 
			this.useExternalCodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.useExternalCodeTextbox.Location = new System.Drawing.Point(139, 63);
			this.useExternalCodeTextbox.Margin = new System.Windows.Forms.Padding(0);
			this.useExternalCodeTextbox.Name = "useExternalCodeTextbox";
			this.useExternalCodeTextbox.Size = new System.Drawing.Size(500, 20);
			this.useExternalCodeTextbox.TabIndex = 3;
			this.useExternalCodeTextbox.TextChanged += new System.EventHandler(this.useExternalCodeTextbox_TextChanged);
			// 
			// useExternalDescLabel
			// 
			this.useExternalDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.useExternalDescLabel.AutoSize = true;
			this.useExternalDescLabel.Location = new System.Drawing.Point(10, 13);
			this.useExternalDescLabel.Margin = new System.Windows.Forms.Padding(0);
			this.useExternalDescLabel.Name = "useExternalDescLabel";
			this.useExternalDescLabel.Size = new System.Drawing.Size(119, 13);
			this.useExternalDescLabel.TabIndex = 0;
			this.useExternalDescLabel.Text = "Folgenden Link öffnen: ";
			// 
			// useExternalLinkTextbox
			// 
			this.useExternalLinkTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.useExternalLinkTextbox.BackColor = System.Drawing.SystemColors.Window;
			this.useExternalLinkTextbox.Location = new System.Drawing.Point(139, 10);
			this.useExternalLinkTextbox.Margin = new System.Windows.Forms.Padding(0);
			this.useExternalLinkTextbox.Name = "useExternalLinkTextbox";
			this.useExternalLinkTextbox.ReadOnly = true;
			this.useExternalLinkTextbox.Size = new System.Drawing.Size(500, 20);
			this.useExternalLinkTextbox.TabIndex = 3;
			// 
			// useExternalLinkLabel
			// 
			this.useExternalLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.useExternalLinkLabel.AutoSize = true;
			this.useExternalLinkLabel.Location = new System.Drawing.Point(139, 40);
			this.useExternalLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.useExternalLinkLabel.Name = "useExternalLinkLabel";
			this.useExternalLinkLabel.Size = new System.Drawing.Size(114, 13);
			this.useExternalLinkLabel.TabIndex = 2;
			this.useExternalLinkLabel.TabStop = true;
			this.useExternalLinkLabel.Text = "Link im Browser öffnen";
			this.useExternalLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.useExternalLinkLabel_LinkClicked);
			// 
			// loggedInTlp
			// 
			this.loggedInTlp.AutoSize = true;
			this.loggedInTlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loggedInTlp.ColumnCount = 5;
			this.loggedInTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedInTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.loggedInTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedInTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.loggedInTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.loggedInTlp.Controls.Add(this.loggedInLabel, 1, 0);
			this.loggedInTlp.Controls.Add(this.logoutButton, 3, 0);
			this.loggedInTlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loggedInTlp.Location = new System.Drawing.Point(0, 93);
			this.loggedInTlp.Margin = new System.Windows.Forms.Padding(0);
			this.loggedInTlp.Name = "loggedInTlp";
			this.loggedInTlp.RowCount = 1;
			this.loggedInTlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.loggedInTlp.Size = new System.Drawing.Size(649, 29);
			this.loggedInTlp.TabIndex = 1;
			this.loggedInTlp.Visible = false;
			// 
			// loggedInLabel
			// 
			this.loggedInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.loggedInLabel.AutoSize = true;
			this.loggedInLabel.Location = new System.Drawing.Point(10, 8);
			this.loggedInLabel.Margin = new System.Windows.Forms.Padding(0);
			this.loggedInLabel.Name = "loggedInLabel";
			this.loggedInLabel.Size = new System.Drawing.Size(449, 13);
			this.loggedInLabel.TabIndex = 0;
			this.loggedInLabel.Text = "Eingeloggt mit Youtube-Account xxxx";
			// 
			// logoutButton
			// 
			this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.logoutButton.AutoSize = true;
			this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.logoutButton.Location = new System.Drawing.Point(469, 0);
			this.logoutButton.Margin = new System.Windows.Forms.Padding(0);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.logoutButton.Size = new System.Drawing.Size(170, 29);
			this.logoutButton.TabIndex = 1;
			this.logoutButton.Text = "Anderer Youtube-Account";
			this.logoutButton.UseVisualStyleBackColor = true;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// resultTextbox
			// 
			this.resultTextbox.BackColor = System.Drawing.Color.White;
			this.useExternalTlp.SetColumnSpan(this.resultTextbox, 5);
			this.resultTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultTextbox.Location = new System.Drawing.Point(10, 481);
			this.resultTextbox.Margin = new System.Windows.Forms.Padding(0);
			this.resultTextbox.Multiline = true;
			this.resultTextbox.Name = "resultTextbox";
			this.resultTextbox.ReadOnly = true;
			this.resultTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultTextbox.Size = new System.Drawing.Size(661, 141);
			this.resultTextbox.TabIndex = 13;
			this.resultTextbox.Text = "Das Ergebnis wird dann hier angezeigt";
			// 
			// analyseUnlistedCheckbox
			// 
			this.analyseUnlistedCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.analyseUnlistedCheckbox.AutoSize = true;
			this.analyseUnlistedCheckbox.Checked = true;
			this.analyseUnlistedCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useExternalTlp.SetColumnSpan(this.analyseUnlistedCheckbox, 5);
			this.analyseUnlistedCheckbox.Location = new System.Drawing.Point(10, 336);
			this.analyseUnlistedCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.analyseUnlistedCheckbox.Name = "analyseUnlistedCheckbox";
			this.analyseUnlistedCheckbox.Size = new System.Drawing.Size(661, 17);
			this.analyseUnlistedCheckbox.TabIndex = 8;
			this.analyseUnlistedCheckbox.Text = "Nicht gelistete Videos berücksichtigen";
			this.analyseUnlistedCheckbox.UseVisualStyleBackColor = true;
			this.analyseUnlistedCheckbox.CheckedChanged += new System.EventHandler(this.analyseUnlistedCheckbox_CheckedChanged);
			// 
			// analysePrivateCheckbox
			// 
			this.analysePrivateCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.analysePrivateCheckbox.AutoSize = true;
			this.analysePrivateCheckbox.Checked = true;
			this.analysePrivateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useExternalTlp.SetColumnSpan(this.analysePrivateCheckbox, 5);
			this.analysePrivateCheckbox.Location = new System.Drawing.Point(10, 363);
			this.analysePrivateCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.analysePrivateCheckbox.Name = "analysePrivateCheckbox";
			this.analysePrivateCheckbox.Size = new System.Drawing.Size(661, 17);
			this.analysePrivateCheckbox.TabIndex = 8;
			this.analysePrivateCheckbox.Text = "Private Videos berücksichtigen";
			this.analysePrivateCheckbox.UseVisualStyleBackColor = true;
			this.analysePrivateCheckbox.CheckedChanged += new System.EventHandler(this.analysePrivateCheckbox_CheckedChanged);
			// 
			// analyseVideosCheckbox
			// 
			this.analyseVideosCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.analyseVideosCheckbox.AutoSize = true;
			this.analyseVideosCheckbox.Checked = true;
			this.analyseVideosCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useExternalTlp.SetColumnSpan(this.analyseVideosCheckbox, 5);
			this.analyseVideosCheckbox.Location = new System.Drawing.Point(10, 390);
			this.analyseVideosCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.analyseVideosCheckbox.Name = "analyseVideosCheckbox";
			this.analyseVideosCheckbox.Size = new System.Drawing.Size(661, 17);
			this.analyseVideosCheckbox.TabIndex = 8;
			this.analyseVideosCheckbox.Text = "Videos analysieren";
			this.analyseVideosCheckbox.UseVisualStyleBackColor = true;
			this.analyseVideosCheckbox.CheckedChanged += new System.EventHandler(this.analyseVideosCheckbox_CheckedChanged);
			// 
			// analyseLivestreamsCheckbox
			// 
			this.analyseLivestreamsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.analyseLivestreamsCheckbox.AutoSize = true;
			this.analyseLivestreamsCheckbox.Checked = true;
			this.analyseLivestreamsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useExternalTlp.SetColumnSpan(this.analyseLivestreamsCheckbox, 5);
			this.analyseLivestreamsCheckbox.Location = new System.Drawing.Point(10, 417);
			this.analyseLivestreamsCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.analyseLivestreamsCheckbox.Name = "analyseLivestreamsCheckbox";
			this.analyseLivestreamsCheckbox.Size = new System.Drawing.Size(661, 17);
			this.analyseLivestreamsCheckbox.TabIndex = 8;
			this.analyseLivestreamsCheckbox.Text = "Livestreams analysieren";
			this.analyseLivestreamsCheckbox.UseVisualStyleBackColor = true;
			this.analyseLivestreamsCheckbox.CheckedChanged += new System.EventHandler(this.analyseLivestreamsCheckbox_CheckedChanged);
			// 
			// exportCsvDialog
			// 
			this.exportCsvDialog.DefaultExt = "csv";
			this.exportCsvDialog.Filter = "CSV-Dateien|*.csv";
			this.exportCsvDialog.Title = "Speicherort für die Datei wählen";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(685, 649);
			this.Controls.Add(this.useExternalGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Statistiken abrufen";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.useExternalGroupBox.ResumeLayout(false);
			this.useExternalGroupBox.PerformLayout();
			this.useExternalTlp.ResumeLayout(false);
			this.useExternalTlp.PerformLayout();
			this.accountGroupbox.ResumeLayout(false);
			this.accountGroupbox.PerformLayout();
			this.accountTlp.ResumeLayout(false);
			this.accountTlp.PerformLayout();
			this.loggedOutTlp.ResumeLayout(false);
			this.loggedOutTlp.PerformLayout();
			this.loggedInTlp.ResumeLayout(false);
			this.loggedInTlp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox useExternalGroupBox;
		private System.Windows.Forms.TableLayoutPanel useExternalTlp;
		private System.Windows.Forms.Label useExternalDescLabel;
		private System.Windows.Forms.Label useExternalCodeLabel;
		private System.Windows.Forms.Label useExternalExplanationLabel;
		private System.Windows.Forms.LinkLabel useExternalLinkLabel;
		private System.Windows.Forms.TextBox useExternalLinkTextbox;
		private System.Windows.Forms.TextBox useExternalCodeTextbox;
		private System.Windows.Forms.Button signInButton;
		private System.Windows.Forms.TextBox exportCsvTextbox;
		private System.Windows.Forms.Label filterFromCheckbox;
		private System.Windows.Forms.Label filterToCheckbox;
		private System.Windows.Forms.CheckBox exportCsvCheckbox;
		private System.Windows.Forms.CheckBox analysePublicCheckbox;
		private System.Windows.Forms.Button exportCsvButton;
		private System.Windows.Forms.DateTimePicker afterDtp;
		private System.Windows.Forms.DateTimePicker beforeDtp;
		private System.Windows.Forms.GroupBox accountGroupbox;
		private System.Windows.Forms.TableLayoutPanel accountTlp;
		private System.Windows.Forms.TableLayoutPanel loggedOutTlp;
		private System.Windows.Forms.TableLayoutPanel loggedInTlp;
		private System.Windows.Forms.Label loggedInLabel;
		private System.Windows.Forms.Button logoutButton;
		private System.Windows.Forms.TextBox resultTextbox;
		private System.Windows.Forms.CheckBox analyseUnlistedCheckbox;
		private System.Windows.Forms.CheckBox analysePrivateCheckbox;
		private System.Windows.Forms.CheckBox analyseVideosCheckbox;
		private System.Windows.Forms.CheckBox analyseLivestreamsCheckbox;
		private System.Windows.Forms.SaveFileDialog exportCsvDialog;
	}
}

