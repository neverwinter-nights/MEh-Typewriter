using System.Windows.Forms;

namespace MEh_Typewriter
{
    partial class Form1
    {
        const string NL = "\r\n";
        const string MessageGuiInitialized = "GUI has been initialized.";

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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tlpKeyboard = new System.Windows.Forms.TableLayoutPanel();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnIU = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnIO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnThHeavy = new System.Windows.Forms.Button();
            this.btnThLight = new System.Windows.Forms.Button();
            this.btnZh = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSh = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnAdditionalSymbols = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.tlpAdditionalButons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCursorRight = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnBracketLeft = new System.Windows.Forms.Button();
            this.btnBracketRight = new System.Windows.Forms.Button();
            this.btnMathPlus = new System.Windows.Forms.Button();
            this.btnMathDivision = new System.Windows.Forms.Button();
            this.btnMathOne = new System.Windows.Forms.Button();
            this.btnMathFour = new System.Windows.Forms.Button();
            this.btnMathEquality = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMathMultiplication = new System.Windows.Forms.Button();
            this.btnMathMinus = new System.Windows.Forms.Button();
            this.btnCursorLeft = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpKeyboard.SuspendLayout();
            this.tlpAdditionalButons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.rtbConsole, 0, 0);
            this.tlpMain.Controls.Add(this.tlpKeyboard, 0, 2);
            this.tlpMain.Controls.Add(this.tlpAdditionalButons, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(644, 527);
            this.tlpMain.TabIndex = 28;
            // 
            // rtbConsole
            // 
            this.rtbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsole.Location = new System.Drawing.Point(3, 3);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbConsole.Size = new System.Drawing.Size(638, 233);
            this.rtbConsole.TabIndex = 29;
            this.rtbConsole.Text = "";
            // 
            // tlpKeyboard
            // 
            this.tlpKeyboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpKeyboard.ColumnCount = 10;
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.Controls.Add(this.btnL, 8, 2);
            this.tlpKeyboard.Controls.Add(this.btnR, 8, 1);
            this.tlpKeyboard.Controls.Add(this.btnReturn, 9, 1);
            this.tlpKeyboard.Controls.Add(this.btnG, 7, 0);
            this.tlpKeyboard.Controls.Add(this.btnH, 7, 1);
            this.tlpKeyboard.Controls.Add(this.btnK, 7, 2);
            this.tlpKeyboard.Controls.Add(this.btnT, 6, 2);
            this.tlpKeyboard.Controls.Add(this.btnIU, 6, 1);
            this.tlpKeyboard.Controls.Add(this.btnU, 6, 0);
            this.tlpKeyboard.Controls.Add(this.btnO, 5, 0);
            this.tlpKeyboard.Controls.Add(this.btnIO, 5, 1);
            this.tlpKeyboard.Controls.Add(this.btnP, 5, 2);
            this.tlpKeyboard.Controls.Add(this.btnThHeavy, 4, 2);
            this.tlpKeyboard.Controls.Add(this.btnThLight, 4, 1);
            this.tlpKeyboard.Controls.Add(this.btnZh, 3, 2);
            this.tlpKeyboard.Controls.Add(this.btnI, 4, 0);
            this.tlpKeyboard.Controls.Add(this.btnE, 3, 0);
            this.tlpKeyboard.Controls.Add(this.btnSh, 3, 1);
            this.tlpKeyboard.Controls.Add(this.btnA, 2, 0);
            this.tlpKeyboard.Controls.Add(this.btnS, 2, 1);
            this.tlpKeyboard.Controls.Add(this.btnZ, 2, 2);
            this.tlpKeyboard.Controls.Add(this.btnV, 1, 2);
            this.tlpKeyboard.Controls.Add(this.btnF, 1, 1);
            this.tlpKeyboard.Controls.Add(this.btnN, 1, 0);
            this.tlpKeyboard.Controls.Add(this.btnM, 0, 0);
            this.tlpKeyboard.Controls.Add(this.btnW, 0, 1);
            this.tlpKeyboard.Controls.Add(this.btnY, 0, 2);
            this.tlpKeyboard.Controls.Add(this.btnSpace, 9, 0);
            this.tlpKeyboard.Controls.Add(this.btnAdditionalSymbols, 8, 0);
            this.tlpKeyboard.Controls.Add(this.btnPeriod, 9, 2);
            this.tlpKeyboard.Location = new System.Drawing.Point(2, 335);
            this.tlpKeyboard.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKeyboard.MaximumSize = new System.Drawing.Size(640, 192);
            this.tlpKeyboard.MinimumSize = new System.Drawing.Size(640, 192);
            this.tlpKeyboard.Name = "tlpKeyboard";
            this.tlpKeyboard.RowCount = 3;
            this.tlpKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpKeyboard.Size = new System.Drawing.Size(640, 192);
            this.tlpKeyboard.TabIndex = 28;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Peru;
            this.btnL.BackgroundImage = global::MEh_Typewriter.Properties.Resources.L;
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnL.Location = new System.Drawing.Point(512, 128);
            this.btnL.Margin = new System.Windows.Forms.Padding(0);
            this.btnL.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(64, 64);
            this.btnL.TabIndex = 19;
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Red;
            this.btnR.BackgroundImage = global::MEh_Typewriter.Properties.Resources.R;
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnR.Location = new System.Drawing.Point(512, 64);
            this.btnR.Margin = new System.Windows.Forms.Padding(0);
            this.btnR.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(64, 64);
            this.btnR.TabIndex = 13;
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundImage = global::MEh_Typewriter.Properties.Resources.Return;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Location = new System.Drawing.Point(576, 64);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(64, 64);
            this.btnReturn.TabIndex = 37;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.Red;
            this.btnG.BackgroundImage = global::MEh_Typewriter.Properties.Resources.G;
            this.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnG.Location = new System.Drawing.Point(448, 0);
            this.btnG.Margin = new System.Windows.Forms.Padding(0);
            this.btnG.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(64, 64);
            this.btnG.TabIndex = 4;
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.Red;
            this.btnH.BackgroundImage = global::MEh_Typewriter.Properties.Resources.H;
            this.btnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnH.Location = new System.Drawing.Point(448, 64);
            this.btnH.Margin = new System.Windows.Forms.Padding(0);
            this.btnH.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(64, 64);
            this.btnH.TabIndex = 5;
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.Peru;
            this.btnK.BackgroundImage = global::MEh_Typewriter.Properties.Resources.K;
            this.btnK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnK.Location = new System.Drawing.Point(448, 128);
            this.btnK.Margin = new System.Windows.Forms.Padding(0);
            this.btnK.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(64, 64);
            this.btnK.TabIndex = 9;
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.Peru;
            this.btnT.BackgroundImage = global::MEh_Typewriter.Properties.Resources.T;
            this.btnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnT.Location = new System.Drawing.Point(384, 128);
            this.btnT.Margin = new System.Windows.Forms.Padding(0);
            this.btnT.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(64, 64);
            this.btnT.TabIndex = 17;
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnIU
            // 
            this.btnIU.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIU.BackgroundImage = global::MEh_Typewriter.Properties.Resources.IU;
            this.btnIU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIU.Location = new System.Drawing.Point(384, 64);
            this.btnIU.Margin = new System.Windows.Forms.Padding(0);
            this.btnIU.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnIU.Name = "btnIU";
            this.btnIU.Size = new System.Drawing.Size(64, 64);
            this.btnIU.TabIndex = 8;
            this.btnIU.UseVisualStyleBackColor = false;
            this.btnIU.Click += new System.EventHandler(this.btnIU_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.SkyBlue;
            this.btnU.BackgroundImage = global::MEh_Typewriter.Properties.Resources.U;
            this.btnU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnU.Location = new System.Drawing.Point(384, 0);
            this.btnU.Margin = new System.Windows.Forms.Padding(0);
            this.btnU.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(64, 64);
            this.btnU.TabIndex = 21;
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.SkyBlue;
            this.btnO.BackgroundImage = global::MEh_Typewriter.Properties.Resources.O;
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnO.Location = new System.Drawing.Point(320, 0);
            this.btnO.Margin = new System.Windows.Forms.Padding(0);
            this.btnO.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(64, 64);
            this.btnO.TabIndex = 16;
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnIO
            // 
            this.btnIO.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIO.BackgroundImage = global::MEh_Typewriter.Properties.Resources.IO;
            this.btnIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIO.Location = new System.Drawing.Point(320, 64);
            this.btnIO.Margin = new System.Windows.Forms.Padding(0);
            this.btnIO.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnIO.Name = "btnIO";
            this.btnIO.Size = new System.Drawing.Size(64, 64);
            this.btnIO.TabIndex = 7;
            this.btnIO.UseVisualStyleBackColor = false;
            this.btnIO.Click += new System.EventHandler(this.btnIO_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Peru;
            this.btnP.BackgroundImage = global::MEh_Typewriter.Properties.Resources.P;
            this.btnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnP.Location = new System.Drawing.Point(320, 128);
            this.btnP.Margin = new System.Windows.Forms.Padding(0);
            this.btnP.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(64, 64);
            this.btnP.TabIndex = 12;
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnThHeavy
            // 
            this.btnThHeavy.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThHeavy.BackgroundImage = global::MEh_Typewriter.Properties.Resources.TH_H;
            this.btnThHeavy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThHeavy.Location = new System.Drawing.Point(256, 128);
            this.btnThHeavy.Margin = new System.Windows.Forms.Padding(0);
            this.btnThHeavy.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnThHeavy.Name = "btnThHeavy";
            this.btnThHeavy.Size = new System.Drawing.Size(64, 64);
            this.btnThHeavy.TabIndex = 18;
            this.btnThHeavy.UseVisualStyleBackColor = false;
            this.btnThHeavy.Click += new System.EventHandler(this.btnThHeavy_Click);
            // 
            // btnThLight
            // 
            this.btnThLight.BackColor = System.Drawing.Color.Gold;
            this.btnThLight.BackgroundImage = global::MEh_Typewriter.Properties.Resources.TH_L;
            this.btnThLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThLight.Location = new System.Drawing.Point(256, 64);
            this.btnThLight.Margin = new System.Windows.Forms.Padding(0);
            this.btnThLight.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnThLight.Name = "btnThLight";
            this.btnThLight.Size = new System.Drawing.Size(64, 64);
            this.btnThLight.TabIndex = 20;
            this.btnThLight.UseVisualStyleBackColor = false;
            this.btnThLight.Click += new System.EventHandler(this.btnThLight_Click);
            // 
            // btnZh
            // 
            this.btnZh.BackColor = System.Drawing.Color.YellowGreen;
            this.btnZh.BackgroundImage = global::MEh_Typewriter.Properties.Resources.ZH;
            this.btnZh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZh.Location = new System.Drawing.Point(192, 128);
            this.btnZh.Margin = new System.Windows.Forms.Padding(0);
            this.btnZh.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnZh.Name = "btnZh";
            this.btnZh.Size = new System.Drawing.Size(64, 64);
            this.btnZh.TabIndex = 26;
            this.btnZh.UseVisualStyleBackColor = false;
            this.btnZh.Click += new System.EventHandler(this.btnZh_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.SkyBlue;
            this.btnI.BackgroundImage = global::MEh_Typewriter.Properties.Resources.I;
            this.btnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnI.Location = new System.Drawing.Point(256, 0);
            this.btnI.Margin = new System.Windows.Forms.Padding(0);
            this.btnI.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(64, 64);
            this.btnI.TabIndex = 6;
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.SkyBlue;
            this.btnE.BackgroundImage = global::MEh_Typewriter.Properties.Resources.E;
            this.btnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnE.Location = new System.Drawing.Point(192, 0);
            this.btnE.Margin = new System.Windows.Forms.Padding(0);
            this.btnE.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(64, 64);
            this.btnE.TabIndex = 2;
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSh
            // 
            this.btnSh.BackColor = System.Drawing.Color.Gold;
            this.btnSh.BackgroundImage = global::MEh_Typewriter.Properties.Resources.SH;
            this.btnSh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSh.Location = new System.Drawing.Point(192, 64);
            this.btnSh.Margin = new System.Windows.Forms.Padding(0);
            this.btnSh.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnSh.Name = "btnSh";
            this.btnSh.Size = new System.Drawing.Size(64, 64);
            this.btnSh.TabIndex = 15;
            this.btnSh.UseVisualStyleBackColor = false;
            this.btnSh.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.SkyBlue;
            this.btnA.BackgroundImage = global::MEh_Typewriter.Properties.Resources.A;
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnA.Location = new System.Drawing.Point(128, 0);
            this.btnA.Margin = new System.Windows.Forms.Padding(0);
            this.btnA.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(64, 64);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.Gold;
            this.btnS.BackgroundImage = global::MEh_Typewriter.Properties.Resources.S;
            this.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnS.Location = new System.Drawing.Point(128, 64);
            this.btnS.Margin = new System.Windows.Forms.Padding(0);
            this.btnS.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(64, 64);
            this.btnS.TabIndex = 14;
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.YellowGreen;
            this.btnZ.BackgroundImage = global::MEh_Typewriter.Properties.Resources.Z;
            this.btnZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZ.Location = new System.Drawing.Point(128, 128);
            this.btnZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnZ.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(64, 64);
            this.btnZ.TabIndex = 25;
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.YellowGreen;
            this.btnV.BackgroundImage = global::MEh_Typewriter.Properties.Resources.V;
            this.btnV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnV.Location = new System.Drawing.Point(64, 128);
            this.btnV.Margin = new System.Windows.Forms.Padding(0);
            this.btnV.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(64, 64);
            this.btnV.TabIndex = 22;
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.Gold;
            this.btnF.BackgroundImage = global::MEh_Typewriter.Properties.Resources.F;
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnF.Location = new System.Drawing.Point(64, 64);
            this.btnF.Margin = new System.Windows.Forms.Padding(0);
            this.btnF.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(64, 64);
            this.btnF.TabIndex = 3;
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.White;
            this.btnN.BackgroundImage = global::MEh_Typewriter.Properties.Resources.N;
            this.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnN.Location = new System.Drawing.Point(64, 0);
            this.btnN.Margin = new System.Windows.Forms.Padding(0);
            this.btnN.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(64, 64);
            this.btnN.TabIndex = 11;
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.White;
            this.btnM.BackgroundImage = global::MEh_Typewriter.Properties.Resources.M;
            this.btnM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnM.Location = new System.Drawing.Point(0, 0);
            this.btnM.Margin = new System.Windows.Forms.Padding(0);
            this.btnM.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(64, 64);
            this.btnM.TabIndex = 10;
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.MediumPurple;
            this.btnW.BackgroundImage = global::MEh_Typewriter.Properties.Resources.W;
            this.btnW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnW.Location = new System.Drawing.Point(0, 64);
            this.btnW.Margin = new System.Windows.Forms.Padding(0);
            this.btnW.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(64, 64);
            this.btnW.TabIndex = 23;
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.MediumPurple;
            this.btnY.BackgroundImage = global::MEh_Typewriter.Properties.Resources.Y;
            this.btnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnY.Location = new System.Drawing.Point(0, 128);
            this.btnY.Margin = new System.Windows.Forms.Padding(0);
            this.btnY.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(64, 64);
            this.btnY.TabIndex = 24;
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.Color.White;
            this.btnSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpace.Location = new System.Drawing.Point(576, 0);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpace.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(64, 64);
            this.btnSpace.TabIndex = 28;
            this.btnSpace.UseVisualStyleBackColor = false;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnAdditionalSymbols
            // 
            this.btnAdditionalSymbols.BackColor = System.Drawing.Color.Gray;
            this.btnAdditionalSymbols.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdditionalSymbols.Location = new System.Drawing.Point(512, 0);
            this.btnAdditionalSymbols.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdditionalSymbols.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnAdditionalSymbols.Name = "btnAdditionalSymbols";
            this.btnAdditionalSymbols.Size = new System.Drawing.Size(64, 64);
            this.btnAdditionalSymbols.TabIndex = 29;
            this.btnAdditionalSymbols.UseVisualStyleBackColor = false;
            this.btnAdditionalSymbols.Click += new System.EventHandler(this.btnAdditionalSymbols_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.Color.White;
            this.btnPeriod.BackgroundImage = global::MEh_Typewriter.Properties.Resources.DOT;
            this.btnPeriod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPeriod.Location = new System.Drawing.Point(576, 128);
            this.btnPeriod.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeriod.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(64, 64);
            this.btnPeriod.TabIndex = 31;
            this.btnPeriod.UseVisualStyleBackColor = false;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // tlpAdditionalButons
            // 
            this.tlpAdditionalButons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpAdditionalButons.ColumnCount = 10;
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.Controls.Add(this.btnLoad, 7, 0);
            this.tlpAdditionalButons.Controls.Add(this.btnCursorRight, 9, 0);
            this.tlpAdditionalButons.Controls.Add(this.btnSave, 6, 0);
            this.tlpAdditionalButons.Controls.Add(this.btnPaste, 4, 0);
            this.tlpAdditionalButons.Controls.Add(this.btnSelectAll, 0, 0);
            this.tlpAdditionalButons.Controls.Add(this.btnBracketLeft, 0, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnBracketRight, 1, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnMathPlus, 2, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnMathDivision, 5, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnMathOne, 6, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnMathFour, 7, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnMathEquality, 8, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnComma, 9, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnCopy, 2, 0);
            this.tlpAdditionalButons.Controls.Add(this.btnMathMultiplication, 4, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnMathMinus, 3, 1);
            this.tlpAdditionalButons.Controls.Add(this.btnCursorLeft, 8, 0);
            this.tlpAdditionalButons.Location = new System.Drawing.Point(2, 239);
            this.tlpAdditionalButons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAdditionalButons.MaximumSize = new System.Drawing.Size(640, 96);
            this.tlpAdditionalButons.MinimumSize = new System.Drawing.Size(640, 96);
            this.tlpAdditionalButons.Name = "tlpAdditionalButons";
            this.tlpAdditionalButons.RowCount = 2;
            this.tlpAdditionalButons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpAdditionalButons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpAdditionalButons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAdditionalButons.Size = new System.Drawing.Size(640, 96);
            this.tlpAdditionalButons.TabIndex = 29;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightGray;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoad.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(448, 0);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(64, 32);
            this.btnLoad.TabIndex = 50;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCursorRight
            // 
            this.btnCursorRight.BackColor = System.Drawing.Color.LightGray;
            this.btnCursorRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCursorRight.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursorRight.Location = new System.Drawing.Point(576, 0);
            this.btnCursorRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnCursorRight.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnCursorRight.Name = "btnCursorRight";
            this.btnCursorRight.Size = new System.Drawing.Size(64, 32);
            this.btnCursorRight.TabIndex = 49;
            this.btnCursorRight.Text = "→";
            this.btnCursorRight.UseVisualStyleBackColor = false;
            this.btnCursorRight.Click += new System.EventHandler(this.btnCursorRight_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(384, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 32);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.LightGray;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlpAdditionalButons.SetColumnSpan(this.btnPaste, 2);
            this.btnPaste.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Location = new System.Drawing.Point(256, 0);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaste.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(128, 32);
            this.btnPaste.TabIndex = 46;
            this.btnPaste.Text = "PASTE";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.LightGray;
            this.btnSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlpAdditionalButons.SetColumnSpan(this.btnSelectAll, 2);
            this.btnSelectAll.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(0, 0);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAll.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(128, 32);
            this.btnSelectAll.TabIndex = 30;
            this.btnSelectAll.Text = "SELECT ALL";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnBracketLeft
            // 
            this.btnBracketLeft.BackColor = System.Drawing.Color.White;
            this.btnBracketLeft.BackgroundImage = global::MEh_Typewriter.Properties.Resources.BRACKET_LEFT;
            this.btnBracketLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBracketLeft.Location = new System.Drawing.Point(0, 32);
            this.btnBracketLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnBracketLeft.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnBracketLeft.Name = "btnBracketLeft";
            this.btnBracketLeft.Size = new System.Drawing.Size(64, 64);
            this.btnBracketLeft.TabIndex = 29;
            this.btnBracketLeft.UseVisualStyleBackColor = false;
            this.btnBracketLeft.Click += new System.EventHandler(this.btnBracketLeft_Click);
            // 
            // btnBracketRight
            // 
            this.btnBracketRight.BackColor = System.Drawing.Color.White;
            this.btnBracketRight.BackgroundImage = global::MEh_Typewriter.Properties.Resources.BRACKET_RIGHT;
            this.btnBracketRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBracketRight.Location = new System.Drawing.Point(64, 32);
            this.btnBracketRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnBracketRight.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnBracketRight.Name = "btnBracketRight";
            this.btnBracketRight.Size = new System.Drawing.Size(64, 64);
            this.btnBracketRight.TabIndex = 30;
            this.btnBracketRight.UseVisualStyleBackColor = false;
            this.btnBracketRight.Click += new System.EventHandler(this.btnBracketRight_Click);
            // 
            // btnMathPlus
            // 
            this.btnMathPlus.BackColor = System.Drawing.Color.White;
            this.btnMathPlus.BackgroundImage = global::MEh_Typewriter.Properties.Resources.ADDITION;
            this.btnMathPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathPlus.Location = new System.Drawing.Point(128, 32);
            this.btnMathPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathPlus.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathPlus.Name = "btnMathPlus";
            this.btnMathPlus.Size = new System.Drawing.Size(64, 64);
            this.btnMathPlus.TabIndex = 31;
            this.btnMathPlus.UseVisualStyleBackColor = false;
            this.btnMathPlus.Click += new System.EventHandler(this.btnMathPlus_Click);
            // 
            // btnMathDivision
            // 
            this.btnMathDivision.BackColor = System.Drawing.Color.White;
            this.btnMathDivision.BackgroundImage = global::MEh_Typewriter.Properties.Resources.DIVISION;
            this.btnMathDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathDivision.Location = new System.Drawing.Point(320, 32);
            this.btnMathDivision.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathDivision.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathDivision.Name = "btnMathDivision";
            this.btnMathDivision.Size = new System.Drawing.Size(64, 64);
            this.btnMathDivision.TabIndex = 34;
            this.btnMathDivision.UseVisualStyleBackColor = false;
            this.btnMathDivision.Click += new System.EventHandler(this.btnMathDivision_Click);
            // 
            // btnMathOne
            // 
            this.btnMathOne.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMathOne.BackgroundImage = global::MEh_Typewriter.Properties.Resources._1;
            this.btnMathOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathOne.Location = new System.Drawing.Point(384, 32);
            this.btnMathOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathOne.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathOne.Name = "btnMathOne";
            this.btnMathOne.Size = new System.Drawing.Size(64, 64);
            this.btnMathOne.TabIndex = 35;
            this.btnMathOne.UseVisualStyleBackColor = false;
            this.btnMathOne.Click += new System.EventHandler(this.btnMathOne_Click);
            // 
            // btnMathFour
            // 
            this.btnMathFour.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMathFour.BackgroundImage = global::MEh_Typewriter.Properties.Resources._4;
            this.btnMathFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathFour.Location = new System.Drawing.Point(448, 32);
            this.btnMathFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathFour.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathFour.Name = "btnMathFour";
            this.btnMathFour.Size = new System.Drawing.Size(64, 64);
            this.btnMathFour.TabIndex = 36;
            this.btnMathFour.UseVisualStyleBackColor = false;
            this.btnMathFour.Click += new System.EventHandler(this.btnMathFour_Click);
            // 
            // btnMathEquality
            // 
            this.btnMathEquality.BackColor = System.Drawing.Color.White;
            this.btnMathEquality.BackgroundImage = global::MEh_Typewriter.Properties.Resources.EQUALITY;
            this.btnMathEquality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathEquality.Location = new System.Drawing.Point(512, 32);
            this.btnMathEquality.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathEquality.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathEquality.Name = "btnMathEquality";
            this.btnMathEquality.Size = new System.Drawing.Size(64, 64);
            this.btnMathEquality.TabIndex = 38;
            this.btnMathEquality.UseVisualStyleBackColor = false;
            this.btnMathEquality.Click += new System.EventHandler(this.btnMathEquality_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.White;
            this.btnComma.BackgroundImage = global::MEh_Typewriter.Properties.Resources.COMMA;
            this.btnComma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComma.Location = new System.Drawing.Point(576, 32);
            this.btnComma.Margin = new System.Windows.Forms.Padding(0);
            this.btnComma.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(64, 64);
            this.btnComma.TabIndex = 41;
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.LightGray;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlpAdditionalButons.SetColumnSpan(this.btnCopy, 2);
            this.btnCopy.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(128, 0);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(128, 32);
            this.btnCopy.TabIndex = 45;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMathMultiplication
            // 
            this.btnMathMultiplication.BackColor = System.Drawing.Color.White;
            this.btnMathMultiplication.BackgroundImage = global::MEh_Typewriter.Properties.Resources.MULTIPLICATION;
            this.btnMathMultiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathMultiplication.Location = new System.Drawing.Point(256, 32);
            this.btnMathMultiplication.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathMultiplication.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathMultiplication.Name = "btnMathMultiplication";
            this.btnMathMultiplication.Size = new System.Drawing.Size(64, 64);
            this.btnMathMultiplication.TabIndex = 33;
            this.btnMathMultiplication.UseVisualStyleBackColor = false;
            this.btnMathMultiplication.Click += new System.EventHandler(this.btnMathMultiplication_Click);
            // 
            // btnMathMinus
            // 
            this.btnMathMinus.BackColor = System.Drawing.Color.White;
            this.btnMathMinus.BackgroundImage = global::MEh_Typewriter.Properties.Resources.SUBTRACTION;
            this.btnMathMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMathMinus.Location = new System.Drawing.Point(192, 32);
            this.btnMathMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMathMinus.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMathMinus.Name = "btnMathMinus";
            this.btnMathMinus.Size = new System.Drawing.Size(64, 64);
            this.btnMathMinus.TabIndex = 32;
            this.btnMathMinus.UseVisualStyleBackColor = false;
            this.btnMathMinus.Click += new System.EventHandler(this.btnMathMinus_Click);
            // 
            // btnCursorLeft
            // 
            this.btnCursorLeft.BackColor = System.Drawing.Color.LightGray;
            this.btnCursorLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCursorLeft.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursorLeft.Location = new System.Drawing.Point(512, 0);
            this.btnCursorLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnCursorLeft.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnCursorLeft.Name = "btnCursorLeft";
            this.btnCursorLeft.Size = new System.Drawing.Size(64, 32);
            this.btnCursorLeft.TabIndex = 48;
            this.btnCursorLeft.Text = "←";
            this.btnCursorLeft.UseVisualStyleBackColor = false;
            this.btnCursorLeft.Click += new System.EventHandler(this.btnCursorLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(644, 527);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(660, 400);
            this.Name = "Form1";
            this.Text = "MЄ Typewriter";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpKeyboard.ResumeLayout(false);
            this.tlpAdditionalButons.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        public void WriteToConsole(string Message)
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new MethodInvoker(delegate
                {
                    rtbConsole.AppendText(Message.Trim() + NL);
                }));

            }
            else
            {
                rtbConsole.AppendText(Message.Trim() + NL);
            }
        }

        #endregion
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpKeyboard;
        private Button btnL;
        private Button btnR;
        private Button btnSpace;
        private Button btnG;
        private Button btnH;
        private Button btnK;
        private Button btnT;
        private Button btnIU;
        private Button btnU;
        private Button btnO;
        private Button btnIO;
        private Button btnP;
        private Button btnThHeavy;
        private Button btnThLight;
        private Button btnZh;
        private Button btnI;
        private Button btnE;
        private Button btnSh;
        private Button btnA;
        private Button btnS;
        private Button btnZ;
        private Button btnV;
        private Button btnF;
        private Button btnN;
        private Button btnM;
        private Button btnW;
        private Button btnY;
        private Button btnAdditionalSymbols;
        private Button btnPeriod;
        private TableLayoutPanel tlpAdditionalButons;
        private Button btnBracketLeft;
        private Button btnBracketRight;
        private Button btnMathMinus;
        private Button btnMathPlus;
        private Button btnMathMultiplication;
        private Button btnMathDivision;
        private Button btnMathOne;
        private Button btnMathFour;
        private Button btnReturn;
        private Button btnMathEquality;
        private Button btnComma;
        private Button btnSelectAll;
        private Button btnCopy;
        private Button btnSave;
        private Button btnPaste;
        private Button btnCursorLeft;
        private Button btnCursorRight;
        private Button btnLoad;
        private RichTextBox rtbConsole;
    }
}
