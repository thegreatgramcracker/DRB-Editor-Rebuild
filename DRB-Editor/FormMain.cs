﻿using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace DRB_Editor
{
    public partial class FormMain : Form
    {
        private static Properties.Settings Settings = Properties.Settings.Default;

        private DRB Drb;
        private string DrbPath;
        private DRB.DRBVersion Version;
        private List<Bitmap> TextureData;
        private List<Color> PaletteColors;
        private Dictionary<int, string> FmgStrings;

        private FormTextures TextureForm;
        private FormPreview PreviewForm;
        private FormTransform TransformForm;


        public short SelectedDLGTopEdge
        {
            get
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                return dlg.Shape.TopEdge;
            }
            set
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                dlg.Shape.TopEdge = value;
                dlg.TopEdge = value;
            }
        }
        public short SelectedDLGLeftEdge
        {
            get
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                return dlg.Shape.LeftEdge;
            }
            set
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                dlg.Shape.LeftEdge = value;
                dlg.LeftEdge = value;
            }
        }
        public short SelectedDLGRightEdge
        {
            get
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                return dlg.Shape.RightEdge;
            }
            set
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                dlg.Shape.RightEdge = value;
                dlg.RightEdge = value;
            }
        }
        public short SelectedDLGBottomEdge
        {
            get
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                return dlg.Shape.BottomEdge;
            }
            set
            {
                var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
                dlg.Shape.BottomEdge = value;
                dlg.BottomEdge = value;
            }
        }
        public short SelectedDLGOTopEdge
        {
            get
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                return dlgo.Shape.TopEdge;
            }
            set
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                dlgo.Shape.TopEdge = value;
            }
        }
        public short SelectedDLGOLeftEdge
        {
            get
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                return dlgo.Shape.LeftEdge;
            }
            set
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                dlgo.Shape.LeftEdge = value;
            }
        }
        public short SelectedDLGORightEdge
        {
            get
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                return dlgo.Shape.RightEdge;
            }
            set
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                dlgo.Shape.RightEdge = value;
            }
        }
        public short SelectedDLGOBottomEdge
        {
            get
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                return dlgo.Shape.BottomEdge;
            }
            set
            {
                var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
                dlgo.Shape.BottomEdge = value;
            }
        }

        public void RefreshDLGProperties()
        {
            pgdDlgShape.Refresh();
            pgdDlg.Refresh();
            pgdDlgo.Refresh();
            pgdDlgoShape.Refresh();
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Text = $"DRB Editor {Application.ProductVersion}";
            Location = Settings.WindowLocation;
            Size = Settings.WindowSize;
            if (Settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            DrbPath = Settings.DRBPath;
            Version = Settings.Remastered ? DRB.DRBVersion.DarkSoulsRemastered : DRB.DRBVersion.DarkSouls;
            OpenDRB(Settings.DRBPath, Version, true);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.WindowMaximized = WindowState == FormWindowState.Maximized;
            if (WindowState == FormWindowState.Normal)
            {
                Settings.WindowLocation = Location;
                Settings.WindowSize = Size;
            }
            else
            {
                Settings.WindowLocation = RestoreBounds.Location;
                Settings.WindowSize = RestoreBounds.Size;
            }

            Settings.DRBPath = DrbPath;
            Settings.Remastered = Version == DRB.DRBVersion.DarkSoulsRemastered;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdDrb.FileName = DrbPath;
            if (ofdDrb.ShowDialog() == DialogResult.OK)
            {
                var prompt = new FormGamePrompt();
                prompt.ShowDialog();
                OpenDRB(ofdDrb.FileName, prompt.Remastered ? DRB.DRBVersion.DarkSoulsRemastered : DRB.DRBVersion.DarkSouls);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SFUtil.Backup(DrbPath);
                Drb.Write(DrbPath);
                SystemSounds.Asterisk.Play();
            }
            catch (Exception ex)
            {
                ShowError($"Failed to save DRB:\n{DrbPath}\n\n{ex}");
            }
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bak = DrbPath + ".bak";
            if (!File.Exists(bak))
            {
                ShowError($"Backup not found:\n{bak}");
            }
            else
            {
                try
                {
                    File.Copy(bak, DrbPath, true);
                    SystemSounds.Asterisk.Play();
                    OpenDRB(DrbPath, Version);
                }
                catch (Exception ex)
                {
                    ShowError($"Failed to restore backup:\n{bak}\n\n{ex}");
                }
            }
        }

        private void TexturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (texturesToolStripMenuItem.Checked)
            {
                TextureForm = new FormTextures();
                TextureForm.SetTextures(Drb.Textures);
                TextureForm.FormClosed += TextureForm_FormClosed;
                TextureForm.Show();
            }
            else
            {
                TextureForm.Close();
                TextureForm = null;
            }
        }

        private void PreviewToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (previewToolStripMenuItem.Checked)
            {
                PreviewForm = new FormPreview();
                PreviewForm.DrawDialog((DRB.Dlg)lbxDlgs.SelectedItem, TextureData, PaletteColors, FmgStrings);
                PreviewForm.FormClosed += PreviewForm_FormClosed;
                PreviewForm.Show();
            }
            else
            {
                PreviewForm.Close();
                PreviewForm = null;
            }
        }

        private void transformToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (transformToolStripMenuItem.Checked)
            {
                TransformForm = new FormTransform(this);
                TransformForm.FormClosed += Transformorm_FormClosed;
                TransformForm.Show();
            }
            else
            {
                TransformForm.Close();
                TransformForm = null;
            }
        }

        private void PreviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            previewToolStripMenuItem.Checked = false;
        }

        private void TextureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            texturesToolStripMenuItem.Checked = false;
        }

        private void Transformorm_FormClosed(object sender, FormClosedEventArgs e)
        {
            transformToolStripMenuItem.Checked = false;
        }

        private void OpenDRB(string path, DRB.DRBVersion version, bool silent = false)
        {
            DRB drb;
            try
            {
                drb = DRB.Read(path, version);
            }
            catch (Exception ex)
            {
                ShowError($"Failed to open DRB:\n{path}\n\n{ex}", silent);
                return;
            }

            string dcx = version == DRB.DRBVersion.DarkSoulsRemastered ? ".dcx" : "";
            string dir = Path.GetDirectoryName(path);
            var textureData = new List<Bitmap>();
            Debug.WriteLine(drb.BigEndian);
            try
            {
                TPF menuTPF = TPF.Read($@"{dir}\menu.tpf{dcx}");
                var textureNames = menuTPF.Textures.Select(t => t.Name);

                var textureBytes = new Dictionary<string, byte[]>();
                if (!drb.BigEndian) 
                {
                    for (int i = 0; i < 10; i++)
                    {
                        string tpfPath = $@"{dir}\menu_{i}.tpf{dcx}";
                        if (!File.Exists(tpfPath))
                            break;

                        TPF tpf = TPF.Read(tpfPath);
                        foreach (TPF.Texture tex in tpf.Textures)
                            textureBytes[tex.Name] = tex.Bytes;
                    }
                }
                else //des loads actual textures from menu.tpf, ds1 grabs texture names from there
                {
                    foreach (TPF.Texture tex in menuTPF.Textures)
                        textureBytes[tex.Name] = tex.Headerize();
                }
                

                foreach (string name in textureNames)
                    textureData.Add(PfimUtil.LoadTexture(textureBytes[name]));
            }
            catch (Exception ex)
            {
                ShowError($"Failed to load textures in:\n{dir}\n\n{ex}", silent);
                return;
            }

            string paramPath = $@"{dir}\..\param\gameparam\gameparam.parambnd{dcx}";
            var paletteColors = new List<Color>();
            try
            {
                BND3 paramBnd = BND3.Read(paramPath);
                PARAM param = PARAM.Read(paramBnd.Files.Find(f => f.Name.Contains("MenuColorTableParam")).Bytes);
                var def = new PARAMDEF();
                def.Fields.Add(new PARAMDEF.Field(def, PARAMDEF.DefType.u8, "r"));
                def.Fields.Add(new PARAMDEF.Field(def, PARAMDEF.DefType.u8, "g"));
                def.Fields.Add(new PARAMDEF.Field(def, PARAMDEF.DefType.u8, "b"));
                def.Fields.Add(new PARAMDEF.Field(def, PARAMDEF.DefType.u8, "a"));
                param.ApplyParamdef(def);

                foreach (PARAM.Row row in param.Rows)
                {
                    byte r = (byte)row["r"].Value;
                    byte g = (byte)row["g"].Value;
                    byte b = (byte)row["b"].Value;
                    byte a = (byte)row["a"].Value;
                    paletteColors.Add(Color.FromArgb(a, r, g, b));
                }
            }
            catch (Exception ex)
            {
                ShowError($"Failed to load params:\n{paramPath}\n\n{ex}", silent);
                return;
            }
            string na = "";
            if (drb.BigEndian) na = "na_";
            string fmgPath = $@"{dir}\..\msg\{na}english\menu.msgbnd{dcx}";
            var fmgStrings = new Dictionary<int, string>();
            try
            {
                BND3 msgBnd = BND3.Read(fmgPath);
                foreach (BinderFile file in msgBnd.Files.Where(f => f.ID - (f.ID % 10) == 70))
                {
                    FMG fmg = FMG.Read(file.Bytes);
                    foreach (FMG.Entry entry in fmg.Entries)
                    {
                        fmgStrings[entry.ID] = entry.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError($"Failed to load fmgs:\n{fmgPath}\n\n{ex}", silent);
                return;
            }

            Drb = drb;
            DrbPath = path;
            Version = version;
            TextureData = textureData;
            PaletteColors = paletteColors;
            FmgStrings = fmgStrings;

            statusStripLblPath.Text = $"[{(version == DRB.DRBVersion.DarkSoulsRemastered ? "DSR" : "PTDE/DeS")}] {path}";
            lbxDlgs.Enabled = Drb.Dlgs.Count > 0;
            lbxDlgs.ClearSelected();
            lbxDlgs.DisplayMember = "Name";
            lbxDlgos.ClearSelected();
            lbxDlgos.DisplayMember = "Name";
            lbxDlgs.DataSource = Drb.Dlgs;
            saveToolStripMenuItem.Enabled = true;

            texturesToolStripMenuItem.Enabled = true;
            TextureForm?.SetTextures(Drb.Textures);

            previewToolStripMenuItem.Enabled = true;
            PreviewForm?.DrawDialog((DRB.Dlg)lbxDlgs.SelectedItem, TextureData, PaletteColors, FmgStrings);
        }

        private void LbxDlgs_SelectedValueChanged(object sender, EventArgs e)
        {
            var dlg = (DRB.Dlg)lbxDlgs.SelectedItem;
            if (dlg == null)
            {
                pgdDlg.Enabled = false;
                pgdDlg.SelectedObject = null;
                pgdDlgShape.Enabled = false;
                pgdDlgShape.SelectedObject = null;
                lblDlgShape.Text = "";

                lbxDlgos.Enabled = false;
                lbxDlgos.DataSource = null;
            }
            else
            {
                pgdDlg.Enabled = true;
                pgdDlg.SelectedObject = dlg;
                pgdDlg.ExpandAllGridItems();
                pgdDlgShape.Enabled = true;
                pgdDlgShape.SelectedObject = dlg.Shape;
                pgdDlgShape.ExpandAllGridItems();
                lblDlgShape.Text = "Shape: " + dlg.Shape.GetType().Name;

                lbxDlgos.Enabled = dlg.Dlgos.Count > 0;
                lbxDlgos.DataSource = dlg.Dlgos;

                PreviewForm?.DrawDialog(dlg, TextureData, PaletteColors, FmgStrings);
            }
        }

        private static GridItemCollection GetAllGridItems(PropertyGrid grid)
        {
            object view = grid.GetType().GetField("gridView", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(grid);
            return (GridItemCollection)view.GetType().InvokeMember("GetAllGridEntries", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance, null, view, null);
        }

        private void LbxDlgos_SelectedValueChanged(object sender, EventArgs e)
        {
            var dlgo = (DRB.Dlgo)lbxDlgos.SelectedItem;
            if (dlgo == null)
            {
                pgdDlgo.Enabled = false;
                pgdDlgo.SelectedObject = null;
                pgdDlgoShape.Enabled = false;
                pgdDlgoShape.SelectedObject = null;
                lblDlgoShape.Text = "";
            }
            else
            {
                pgdDlgo.Enabled = true;
                pgdDlgo.SelectedObject = dlgo;
                pgdDlgo.ExpandAllGridItems();
                pgdDlgoShape.Enabled = true;
                pgdDlgoShape.SelectedObject = dlgo.Shape;
                pgdDlgoShape.ExpandAllGridItems();
                lblDlgoShape.Text = "Shape: " + dlgo.Shape.GetType().Name;
            }
        }

        private static void ShowError(string message, bool silent = false)
        {
            if (!silent)
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Pgd_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            PreviewForm?.DrawDialog((DRB.Dlg)lbxDlgs.SelectedItem, TextureData, PaletteColors, FmgStrings);
        }

        private void TransformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(lbxDlgos.Text);
            Debug.WriteLine(lbxDlgs.Text);
            if (lbxDlgos.SelectedIndex != -1)
            {

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
