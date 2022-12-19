using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MFont = MEh_Typewriter.Font;

namespace MEh_Typewriter
{
    public partial class Form1 : Form
    {
        private Settings settings;
        private bool IsAdditionalButtonsPanelVisible = false;


        public Form1()
        {
            InitializeComponent();

            settings = new Settings("");
            if (settings.AreLoaded)
            {
                string msg = String.Format(Msg.SettingsAreLoadedF, settings.SourceFile);
                WriteToConsole(msg);
            }
            else
            {
                WriteToConsole(Msg.SettingsReadingError);
            }

            UpdateAdditionalButtonsPanel();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            WriteToConsole(MessageGuiInitialized);

            if ((settings == null) || (!settings.AreLoaded))
            {
                return;
            }

            string msg;
            FontCheckResponse fontCheckResponse = MFont.Check(settings.Font);
            switch (fontCheckResponse.CheckResult)
            {
                case FontCheckResult.FontIsAlreadyInstalled:
                    WriteToConsole(Msg.FontIsAlreadyInstalled);
                    break;

                case FontCheckResult.FontInstallerIsMissing:
                    WriteToConsole(Msg.FontInstallerIsMissing);
                    return;

                case FontCheckResult.FontFileIsMissing:
                    WriteToConsole(Msg.FontFileIsMissing);
                    return;

                case FontCheckResult.FontInstallationError:
                    msg = String.Format(Msg.FontInstallationErrorF, fontCheckResponse.FontInstallerExitCode);
                    WriteToConsole(msg);
                    return;

                case FontCheckResult.FontInstallationSuccess:
                    WriteToConsole(Msg.FontInstallationSuccess);
                    break;

                case FontCheckResult.ApplicationRestartIsRequired:
                    WriteToConsole(Msg.ApplicationRestartIsRequired);
                    System.Threading.Thread.Sleep(settings.ApplicationRestartDelayMs);
                    Application.Restart();
                    return;
            }

            rtbConsole.Font = new System.Drawing.Font(settings.Font.Name, settings.Font.Size);
            rtbConsole.Text = "";
        }

        private void InsertTextAtCursor(string text)
        {
            // If some text is already selected, then delete it.
            if (rtbConsole.SelectedText.Length > 0)
            {
                rtbConsole.SelectedText = "";
            }

            rtbConsole.SelectedText = text;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("M");
            rtbConsole.Select();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("N");
            rtbConsole.Select();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("A");
            rtbConsole.Select();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("E");
            rtbConsole.Select();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("I");
            rtbConsole.Select();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("O");
            rtbConsole.Select();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("U");
            rtbConsole.Select();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("G");
            rtbConsole.Select();
        }

        private void btnAdditionalSymbols_Click(object sender, EventArgs e)
        {
            ToggleAdditionalButtonsPanel();
            UpdateAdditionalButtonsPanel();
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(" ");
            rtbConsole.Select();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("W");
            rtbConsole.Select();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("F");
            rtbConsole.Select();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("S");
            rtbConsole.Select();
        }

        private void btnSh_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("Š");
            rtbConsole.Select();
        }

        private void btnThLight_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("θ");
            rtbConsole.Select();
        }

        private void btnIO_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("Ö");
            rtbConsole.Select();
        }

        private void btnIU_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("Ü");
            rtbConsole.Select();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("H");
            rtbConsole.Select();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("R");
            rtbConsole.Select();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("Y");
            rtbConsole.Select();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("V");
            rtbConsole.Select();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("Z");
            rtbConsole.Select();
        }

        private void btnZh_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("Ž");
            rtbConsole.Select();
        }

        private void btnThHeavy_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("ð");
            rtbConsole.Select();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("P");
            rtbConsole.Select();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("T");
            rtbConsole.Select();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("K");
            rtbConsole.Select();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("L");
            rtbConsole.Select();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(".");
            rtbConsole.Select();
        }

        private void ToggleAdditionalButtonsPanel()
        {
            if (IsAdditionalButtonsPanelVisible)
            { IsAdditionalButtonsPanelVisible = false; }
            else
            { IsAdditionalButtonsPanelVisible = true; }
        }

        private void UpdateAdditionalButtonsPanel()
        {
            if (IsAdditionalButtonsPanelVisible)
            {
                //tlpAdditionalButons.RowStyles[0].SizeType = SizeType.Percent;
                //tlpAdditionalButons.RowStyles[0].Height = 100;
                tlpMain.RowStyles[1].SizeType = SizeType.Absolute;
                tlpMain.RowStyles[1].Height = 96;
            }
            else
            {
                //tlpAdditionalButons.RowStyles[0].SizeType = SizeType.Absolute;
                //tlpAdditionalButons.RowStyles[0].Height = 0;
                tlpMain.RowStyles[1].SizeType = SizeType.Absolute;
                tlpMain.RowStyles[1].Height = 0;
            }
        }

        private void btnBracketLeft_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("(");
            rtbConsole.Select();
        }

        private void btnBracketRight_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(")");
            rtbConsole.Select();
        }

        private void btnMathPlus_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("+");
            rtbConsole.Select();
        }

        private void btnMathMinus_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("-");
            rtbConsole.Select();
        }

        private void btnMathMultiplication_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("*");
            rtbConsole.Select();
        }

        private void btnMathDivision_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("/");
            rtbConsole.Select();
        }

        private void btnMathOne_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("1");
            rtbConsole.Select();
        }

        private void btnMathFour_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("4");
            rtbConsole.Select();
        }

        private void btnMathEquality_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("=");
            rtbConsole.Select();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor("\r\n");
            rtbConsole.Select();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(",");
            rtbConsole.Select();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            rtbConsole.SelectAll();
            rtbConsole.Focus();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbConsole.SelectedText);
            rtbConsole.Select();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            InsertTextAtCursor(Clipboard.GetText());
            rtbConsole.Select();
        }

        private void btnCursorLeft_Click(object sender, EventArgs e)
        {
            if (rtbConsole.SelectionStart > 0)
            {
                rtbConsole.SelectionStart -= 1;
                rtbConsole.Select();
            }
        }

        private void btnCursorRight_Click(object sender, EventArgs e)
        {
            rtbConsole.SelectionStart += 1;
            rtbConsole.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save the File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName == "") return;
            switch (saveFileDialog.FilterIndex)
            {
                case 1: //*.txt.
                    SaveTextAsTextFile(saveFileDialog);
                    break;

                case 2: //*.bmp.
                    SaveTextAsBitmapFile(saveFileDialog);
                    break;
            }

        }

        private void SaveTextAsTextFile(SaveFileDialog dialog)
        {
            using (System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile())
            {
                Byte[] data = new UTF8Encoding(true).GetBytes(rtbConsole.Text);
                fs.Write(data, 0, data.Length);
            }
        }

        private void SaveTextAsBitmapFile(SaveFileDialog dialog)
        {
            SizeF contentSize = Helper.GetRtbAllContentSize(rtbConsole, settings, rtbConsole.Width);
            Bitmap bmp = new Bitmap((int)contentSize.Width + 8, (int)contentSize.Height + 8);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255)))
                {
                    gfx.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }

            Helper.RenderRtbToBitmap(rtbConsole, bmp, settings);
            bmp.Save(dialog.FileName, ImageFormat.Bmp);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.Title = "Open the File";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName == "") return;
            switch (openFileDialog.FilterIndex)
            {
                case 1: //*.txt.
                    LoadTextFile(openFileDialog);
                    break;
            }
        }

        private void LoadTextFile(OpenFileDialog dialog)
        {
            // Check the Size of the File.
            long fileSize = Helper.GetFileSize(dialog.FileName);

            bool ok = false;
            if (fileSize < settings.LoadFileSizeWarning)
            {
                ok = true;
            }
            else
            {
                DialogResult dr = MessageBox.Show("File is big. Are you sure you want to open it ?",
                      "File is big", MessageBoxButtons.YesNo);

                switch (dr)
                {
                    case DialogResult.Yes:
                        ok = true;
                        break;
                    case DialogResult.No:
                        ok = false;
                        break;
                }
            }

            if (!ok) return;

            // Read the Contents.
            using (System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile())
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    rtbConsole.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
