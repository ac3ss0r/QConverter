using CodeConverter.Net;
using dnlib.DotNet;
using dnlib.PE;
using Keystone;
using MetroFramework.Forms;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QConverter {
    public partial class MainForm : MetroForm {

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            foreach (EncodingInfo enc in Encoding.GetEncodings())
                stringEncoding_ComboBox.Items.Add(enc.Name);
            foreach (Arch arch in Enum.GetValues(typeof(Arch)))
                asmArch_ComboBox.Items.Add(arch.ToString());
        }

        #region DATA_CONVERTER_TAB

        public static byte[] Hex2Bytes(string hex) {
            string trimmed = hex.Replace(" ", "").Trim();
            int length = trimmed.Length;
            byte[] bytes = new byte[length / 2];
            int j = 0;
            for (int i = 0; i < length; i += 2) {
                bytes[j] = Convert.ToByte(trimmed.Substring(i, 2), 16);
                j++;
            }
            return bytes;
        }

        // All input changes are handles by a single method 
        private void decimalTextBox_TextChanged(object sender, EventArgs e) {
            var senderBox = sender as TextBox;
            // We check if the selected view is focused in order to avoid recursive events
            if (!String.IsNullOrEmpty(senderBox.Text) && senderBox.Focused) {
                try {
                    Encoding encoding = Encoding.GetEncoding(stringEncoding_ComboBox.Text);
                    string senderTag = senderBox.Tag as String;
                    string[] numericTags = { "Decimal", "Octal", "Hexademical", "Binary" };
                    byte[] rawData;
                    int number;
                    // For numerics
                    if (numericTags.Any(x => x == senderTag)) {
                        // Get basis
                        int basis = senderTag == "Decimal" ? 10 :
                                    senderTag == "Octal" ? 8 :
                                    senderTag == "Hexademical" ? 16 :
                                    senderTag == "Binary" ? 2 : 10;
                        number = Convert.ToInt32(senderBox.Text, basis);
                        rawData = BitConverter.GetBytes(number);
                    } else {

                        // Convert raw binary data
                        rawData = senderTag == "String" ? encoding.GetBytes(senderBox.Text) :
                                  senderTag == "Bytes" ? Hex2Bytes(senderBox.Text.Replace(" ", "")) :
                                  senderTag == "Base64" ? Convert.FromBase64String(senderBox.Text) :
                                  senderTag == "Float" ? BitConverter.GetBytes(float.Parse(senderBox.Text.Replace(".", ","))) :
                                  new byte[0];
                        // At least the size of int32 to convert
                        number = (rawData.Length == 1) ? (int)rawData[0] :
                                 rawData.Length >= sizeof(Int32) ? BitConverter.ToInt32(rawData, 0) :
                                 0;
                    }

                    // Decimals
                    if (sender != hex_TextBox)
                        hex_TextBox.Text = Convert.ToString(number, 16).ToUpper();
                    if (sender != decimal_TextBox)
                        decimal_TextBox.Text = Convert.ToString(number, 10);
                    if (sender != octal_TextBox)
                        octal_TextBox.Text = Convert.ToString(number, 8);
                    if (sender != binary_TextBox)
                        binary_TextBox.Text = Convert.ToString(number, 2);
                    if (sender != float_TextBox)
                        float_TextBox.Text = Convert.ToString(number);

                    // Arrays & strings
                    if (sender != stringTextBox)
                        stringTextBox.Text = encoding.GetString(rawData);
                    if (sender != base64_TextBox)
                        base64_TextBox.Text = Convert.ToBase64String(rawData);
                    if (sender != bytesTextBox)
                        bytesTextBox.Text = BitConverter.ToString(rawData).Replace("-", "");
                    // Update status
                    dataConvertStatus_Label.Text = "Status: Ok";
                } catch (FormatException ex) {
                    dataConvertStatus_Label.Text = "Status: The provided data has wrong format.";
                } catch (OverflowException ex) {
                    dataConvertStatus_Label.Text = "Status: The provided data caused an overflow (value too big).";
                } catch (Exception ex) {
                    // Just ignore if the exception is unknown
                }
            }
        }

        // Handle encoding change
        private void encodingComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            stringTextBox.Focus(); // A bit of trickery
            decimalTextBox_TextChanged(stringTextBox, e);
        }

        #endregion

        #region ASM_DISASM_TAB

        private void asmCodeBox_TextChanged(object sender, EventArgs e) {
            var senderBox = sender as RichTextBox;
            if (asmAction_ComboBox.Text == "Disassemble")
                UpdateDisasm();
            else if (asmAction_ComboBox.Text == "Assemble")
                UpdateAsm();
        }

        private void archComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateAsm();
        }

        private void hexArchBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateDisasm();
        }

        private void UpdateDisasm() {
            try {
                byte[] rawData = Hex2Bytes(asmInput_ComboBox.Text); // Raw data
                // Disasm architectures
                var arch = asmArch_ComboBox.Text == "ARM64" ? Arch.ARM64 :
                           asmArch_ComboBox.Text == "ARM" ? Arch.ARM :
                           asmArch_ComboBox.Text == "X86" ? Arch.X86 : Arch.X86_64;
                  
                using (var disasm = new Disassembler(arch)) {
                    var result = disasm.DisassembleToStr(rawData);
                    if (result.Length > 0) {
                        asmResult_ComboBox.Text = result;
                        asmStatusLabel.Text = "Status: OK.";
                    }
                }
            } catch { // Invalid HEX data (rare occasion)
                asmStatusLabel.Text = "Status: Failed to disasm.";
            }
        }

        private void UpdateAsm() {
            try {
                // Assembly architecture
                var arch = asmArch_ComboBox.Text == "ARM64" ? Architecture.ARM64 :
                           asmArch_ComboBox.Text == "ARM" ? Architecture.ARM : Architecture.X86;
                // Assembly mode
                var mode = asmArch_ComboBox.Text == "ARM64" || asmArch_ComboBox.Text == "ARM" ? Mode.LITTLE_ENDIAN :
                           asmArch_ComboBox.Text == "X86" ? Mode.X32 : Mode.X64;
                using (Engine keystone = new Engine(arch, mode)) {
                    byte[] result = keystone.Assemble(asmInput_ComboBox.Text, (ulong)0).Buffer;
                    asmResult_ComboBox.Text = BitConverter.ToString(result).Replace("-", " ");
                }
                asmStatusLabel.Text = "Status: OK.";
            } catch { // Invalid ASM input
                asmStatusLabel.Text = "Status: Failed to asm.";
            }
        }

        #endregion

        #region PATTERN_SCAN_TAB

        private void scanInput1Button_Click(object sender, EventArgs e) {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                scanInput1Box.Text = fileDialog.FileName;
            }
        }

        private void scanInput2Button_Click(object sender, EventArgs e) {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                //scanInput2Box.Text = fileDialog.FileName;
            }
        }

        private void createPatternButton_Click(object sender, EventArgs e) {
            var arch = scanArchBox.Text == "ARM64" ? Arch.ARM64 :
                          scanArchBox.Text == "ARM" ? Arch.ARM :
                          scanArchBox.Text == "X86" ? Arch.X86 : Arch.X86_64;
            long offset = Convert.ToInt64(scanOffsetBox.Text, 16);
            int length = Convert.ToInt32(scanSizeBox.Text);

            byte[] buffer = new byte[length];

            using (var fstream = File.OpenRead(scanInput1Box.Text)) {
                fstream.Seek(offset, SeekOrigin.Begin);
                fstream.Read(buffer, 0, length);
            }

            using (var disasm = new Disassembler(arch)) {
                string pattern = string.Empty;
                foreach (var inst in disasm.Disassemble(buffer)) {
                    ulong hexValue = 0;
                    Console.WriteLine(inst.Operand);
                    Match match = Regex.Match(inst.Operand, @".*(0x[0-9a-fA-F]+).*", RegexOptions.IgnoreCase);
                    if (match.Success) {
                        string key = match.Groups[1].Value;
                        hexValue = (ulong)new System.ComponentModel.UInt64Converter().ConvertFromString(key);
                    }
                    if (hexValue <= 256) {
                        pattern += (BitConverter.ToString(inst.Bytes).Replace("-", " ")) + " ";
                    } else {
                        for (int i = 0; i < inst.Bytes.Length; i++) {
                            pattern += "?? ";
                        }
                    }
                }
                scanPatternBox.Text = pattern;
            }
        }

        private void findPatternButton_Click(object sender, EventArgs e) {
            string[] pattern = scanPatternBox.Text.Split(' ');
            byte[] rawFileData = File.ReadAllBytes(scanInput1Box.Text);
            long targetOffset = Convert.ToInt64(scanOffsetBox.Text, 16),
                scanRange = Convert.ToInt64(scanRangeBox.Text);
            try {
                for (long currentOffset = targetOffset; currentOffset < scanRange; currentOffset++) {
                    int matches = 0;
                    // Scan forward from the provided offset
                    for (int patternOffset = 0; patternOffset < pattern.Length; patternOffset++) {
                        // Reached file end
                        if (currentOffset + patternOffset >= rawFileData.Length)
                            break;
                        if (pattern[patternOffset] == "?" || // any byte
                            Convert.ToByte(pattern[patternOffset], 16) == rawFileData[currentOffset + patternOffset]) { // pattern byte
                            matches++;
                            if (matches == pattern.Length) {
                                MessageBox.Show("Found at offset: " + currentOffset.ToString("X4"));
                                return;
                            }
                        } else // pattern doesn't match
                            break;
                    }

                }
                MessageBox.Show("Unfortunately the pattern was not found.", "Pattern not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Skill issue");
            }
        }

        #endregion

        #region IL_EXPLORER_TAB

        // CodeDOM providers for IL tab
        private static CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" } });
        private static VBCodeProvider basicCodeProvider = new VBCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" } });

        private static string RawModule2Overview(byte[] rawModuleData, bool indentStack = false) {
            StringBuilder result = new StringBuilder();
            try {
                using (var module = ModuleDefMD.Load(rawModuleData)) {
                    var peImage = new PEImage(rawModuleData);
                    string generic_tab = new string(' ', 4);
                    result.Append("// Generic IL Overview generated using github.com/ac3ss0r/QConverter\n\n");
                    foreach (var type in module.GetTypes()) {
                        // Display fields
                        result.Append(type.ToString() + " {\n");
                        foreach (var fld in type.Fields) {
                            result.Append(generic_tab + fld.ToString() + "\n");
                        }
                        result.Append("\n");
                        // Display methods
                        foreach (var mtd in type.Methods) {
                            result.Append(generic_tab + mtd.ToString() + " {\n");
                            if (mtd.HasBody) {
                                int stack_usage = 1;
                                foreach (var inst in mtd.Body.Instructions) {
                                    // Calculate the instruction offset in the binary and extract the instruction data
                                    int instSize = inst.GetSize();
                                    byte[] rawInstruction = new byte[instSize];
                                    long file_offset = (long)peImage.ToFileOffset(mtd.RVA);
                                    long instruction_offset = file_offset + inst.Offset + mtd.Body.HeaderSize;
                                    Array.Copy(rawModuleData, instruction_offset, rawInstruction, 0, instSize);


                                    // Somehow the stack is NEGATIVE sometimes (this seems to work well tho)
                                    string tab_spaces = stack_usage > 1 && indentStack ? new string(' ', stack_usage * 2) : // TODO fix here
                                                                                          new string(' ', 1);

                                    string unformatted_inst = inst.ToString();
                                    result.Append(generic_tab + generic_tab); // initial tab
                                    result.Append(unformatted_inst.Insert(unformatted_inst.IndexOf(':') + 1, tab_spaces)); // formatted instr
                                    result.Append(" // RAW: " + BitConverter.ToString(rawInstruction).Replace("-", " ") + "\n"); // raw bytes

                                    inst.UpdateStack(ref stack_usage);
                                }
                            }
                            result.Append(generic_tab + "}\n\n");
                        }
                        result.Append("}\n\n");
                    }
                }
            } catch (Exception e) {
                result.Clear();
                result.Append("Failed to dump module: " + e.Message);
            }
            return result.ToString();
        }

        private void UpdateILExplorer() {
            CompilerParameters compilerParameters = new CompilerParameters(new string[] { "System.dll" }) {
                GenerateExecutable = true, GenerateInMemory = false,
                OutputAssembly = "result.exe", CompilerOptions = "/target:winexe /platform:anycpu /optimize+",
                TreatWarningsAsErrors = false, IncludeDebugInformation = false
            };

            // CodeDom compilation depending on the selected language
            CompilerResults results = langBox.Text == "C#" ? csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[] { sourceCodeBox.Text }) :
                                      langBox.Text == "Visual Basic" ? basicCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[] { sourceCodeBox.Text }) :
                                      csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[] { sourceCodeBox.Text });

            // TODO: complication fully in memory, without the need to use this
            if (results.Errors.Count == 0 && File.Exists("result.exe")) {
                byte[] rawModuleData = File.ReadAllBytes("result.exe");
                ilCodeBox.Text = RawModule2Overview(rawModuleData, stackTabs_CheckBox.Checked);
            } else {
                ilCodeBox.Clear();
                ilCodeBox.Text += "Compilation failed: ";
                foreach (CompilerError error in results.Errors)
                    ilCodeBox.Text += error.ErrorText + "\n";
            }
        }

        private void loadBinaryButton_Click(object sender, EventArgs e) {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                FileInfo info = new FileInfo(fileDialog.FileName);
                /* Avoid loading large files
                if (info.Length > 1024 * 1024 * 5) {
                    var confirmResult = MessageBox.Show("The selected file is large. Are you sure you want to load it?", "Warning",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirmResult != DialogResult.OK)
                        return;
                }*/
                byte[] rawBinaryData = File.ReadAllBytes(fileDialog.FileName);
                ilCodeBox.Text = RawModule2Overview(rawBinaryData, stackTabs_CheckBox.Checked);
            }
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e) {
            sourceCodeBox.Language = (langBox.Text == "C#") ? FastColoredTextBoxNS.Language.CSharp :
                                    (langBox.Text == "VB.NET") ? FastColoredTextBoxNS.Language.VB :
                                    FastColoredTextBoxNS.Language.CSharp; // default
        }

        private void ilDasmButton_Click(object sender, EventArgs e) {
            UpdateILExplorer();
        }

        #endregion

        #region CSHARP_VB_TAB

        private void UpdateSourceConversion() {
            if (convertMode_ComboBox.Text == "C# -> VB.NET") {
                codeResult_TextBox.Text = Converter.ConvertCS2VBNET(codeInput_TextBox.Text);
            } else if (convertMode_ComboBox.Text == "VB.NET -> C#") {
                codeResult_TextBox.Text = Converter.ConvertVBNET2CS(codeInput_TextBox.Text);
            }
        }

        private void convertModeBox_SelectedValueChanged(object sender, EventArgs e) {
            if (convertMode_ComboBox.Text == "C# -> VB.NET") {
                codeInput_TextBox.Language = FastColoredTextBoxNS.Language.CSharp;
                codeResult_TextBox.Language = FastColoredTextBoxNS.Language.VB;
            } else if (convertMode_ComboBox.Text == "VB.NET -> C#") {
                codeInput_TextBox.Language = FastColoredTextBoxNS.Language.VB;
                codeResult_TextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            }
        }

        private void convertCodeButton_Click(object sender, EventArgs e) {
            UpdateSourceConversion();
        }

        private void loadCodeButton_Click(object sender, EventArgs e) {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                FileInfo info = new FileInfo(fileDialog.FileName);
                /* Avoid loading large files
                if (info.Length > 1024 * 1024 * 5) {
                    var confirmResult = MessageBox.Show("The selected file is large. Are you sure you want to load it?", "Warning",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirmResult != DialogResult.OK)
                        return;
                }*/
                sourceCodeBox.Text = File.ReadAllText(fileDialog.FileName);
                UpdateSourceConversion();
            }
        }

        #endregion

        #region ABOUT_TAB

        private static void OpenBrowserSafe(string url) {
            try {
                Process.Start(url);
            } catch (Exception e) {
                Clipboard.Clear();
                Clipboard.SetText(url);
                MessageBox.Show("Your computer doesn't have a default browser selected. " +
                                "The URL was copied to your clipboard instead.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void telegramLink_Click(object sender, EventArgs e) {
            OpenBrowserSafe("https://t.me/acessor_group");
        }

        private void metroLink1_Click(object sender, EventArgs e) {
            OpenBrowserSafe("https://github.com/ac3ss0r");
        }

        private void marketBtn_Click(object sender, EventArgs e) {
            OpenBrowserSafe("https://acessor.sellix.io");
        }

        #endregion

        #region ESSENTIALS

        // Opacity bar
        private void metroTrackBar1_ValueChanged(object sender, EventArgs e) {
            this.Opacity = (double)opacity_TrackBar.Value * 0.01D;
        }

        // Real-time convertions handler (delayed for optimization)

        private static void ResetTimer(Timer t) {
            t.Stop();
            t.Start();
        }

        // Switch the timer when real-time is enabled/disabled
        private void onRealTimeEnabled_Checked(object sender, EventArgs e) {
            typingTimer.Enabled = (sender as CheckBox).Checked;
        }

        // When the timer reaches it's end the fields will be updated
        private void typingTimer_Tick(object sender, EventArgs e) {
            if (ilRealTime_CheckBox.Checked)
                UpdateILExplorer();
            if (codeRealTime_CheckBox.Checked)
                UpdateSourceConversion();
            typingTimer.Stop(); // It changes only once
        }

        private void sourceCodeBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e) {
            ResetTimer(typingTimer);
        }

        private void sourceCodeInputBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e) {
            ResetTimer(typingTimer);
        }

        // Pinning / Unpinning the window

        private void pinWindowBtn_Click(object sender, EventArgs e) {
            pinWindow_Button.BackColor = TopMost ? Color.FromArgb(0, 0, 0, 0) :
                                               Color.FromArgb(64, 64, 64);
            TopMost = !TopMost;
        }

        // Tray icon handling

        private void toTrayBtn_Click(object sender, EventArgs e) {
            if (Visible) {
                Visible = false;
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000, "QConverter", "Application minimized to tray. Click the icon to restore.", ToolTipIcon.Info);
            }
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e) {
            if (trayIcon.Visible) {
                Visible = true;
                trayIcon.Visible = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            trayIcon.Visible = false;
        }

        // Drag-n-dropping files to files

        private void dataConverter_Panel_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1) {
                MessageBox.Show("You should one file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {
                byte[] rawData = File.ReadAllBytes(files[0]);
                bytesTextBox.Text = BitConverter.ToString(rawData).Replace("-", "");

                bytesTextBox.Focus();
                decimalTextBox_TextChanged(bytesTextBox, new EventArgs());
            }
        }

        private void dataConverter_Panel_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        #endregion

    }
}