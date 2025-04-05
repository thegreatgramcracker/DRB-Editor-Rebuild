using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRB_Editor
{
    public partial class FormTransform : Form
    {
        public FormMain formMain;
        private Color fadeTextColor = Color.Fuchsia;
        private Color windowColor;
        private int fadeTime = 5000;
        private int currentFadeTime = 0;
        private int clickCombo = 0;
        private int lastButton = -1;

        public FormTransform(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            windowColor = BackColor;
        }

        private void button_OffsetDLG_Click(object sender, EventArgs e)
        {
            formMain.SelectedDLGTopEdge += (short)upDown_TopEdge.Value;
            formMain.SelectedDLGLeftEdge += (short)upDown_LeftEdge.Value;
            formMain.SelectedDLGRightEdge += (short)upDown_RightEdge.Value;
            formMain.SelectedDLGBottomEdge += (short)upDown_BottomEdge.Value;
            formMain.RefreshDLGProperties();
            currentFadeTime = fadeTime;
            fadeTimer.Enabled = true;
            fadeTimer.Start();
            if (lastButton != 1)
            {
                clickCombo = 0;
                lastButton = 1;
            }
            clickCombo++;
            string comboText = "";
            if (clickCombo > 1)
            {
                comboText = "(" + clickCombo + "x) ";
            }
            label_fadeText.Text = comboText + "DLG Offset Position Applied";
            label_fadeText.ForeColor = Color.Fuchsia;
        }

        private void button_SetDLG_Click(object sender, EventArgs e)
        {
            formMain.SelectedDLGTopEdge = (short)upDown_TopEdge.Value;
            formMain.SelectedDLGLeftEdge = (short)upDown_LeftEdge.Value;
            formMain.SelectedDLGRightEdge = (short)upDown_RightEdge.Value;
            formMain.SelectedDLGBottomEdge = (short)upDown_BottomEdge.Value;
            formMain.RefreshDLGProperties();
            currentFadeTime = fadeTime;
            fadeTimer.Enabled = true;
            fadeTimer.Start();
            if (lastButton != 2)
            {
                clickCombo = 0;
                lastButton = 2;
            }
            clickCombo++;
            string comboText = "";
            if (clickCombo > 1)
            {
                comboText = "(" + clickCombo + "x) ";
            }
            label_fadeText.Text = comboText + "DLG Set Position Applied";
            label_fadeText.ForeColor = Color.Fuchsia;
        }

        private void button_OffsetDLGO_Click(object sender, EventArgs e)
        {
            formMain.SelectedDLGOTopEdge += (short)upDown_TopEdge.Value;
            formMain.SelectedDLGOLeftEdge += (short)upDown_LeftEdge.Value;
            formMain.SelectedDLGORightEdge += (short)upDown_RightEdge.Value;
            formMain.SelectedDLGOBottomEdge += (short)upDown_BottomEdge.Value;
            formMain.RefreshDLGProperties();
            currentFadeTime = fadeTime;
            fadeTimer.Enabled = true;
            fadeTimer.Start();
            if (lastButton != 3)
            {
                clickCombo = 0;
                lastButton = 3;
            }
            clickCombo++;
            string comboText = "";
            if (clickCombo > 1)
            {
                comboText = "(" + clickCombo + "x) ";
            }
            label_fadeText.Text = comboText + "DLGO Offset Position Applied";
            label_fadeText.ForeColor = Color.Fuchsia;
        }

        private void button_SetDLGO_Click(object sender, EventArgs e)
        {
            formMain.SelectedDLGOTopEdge = (short)upDown_TopEdge.Value;
            formMain.SelectedDLGOLeftEdge = (short)upDown_LeftEdge.Value;
            formMain.SelectedDLGORightEdge = (short)upDown_RightEdge.Value;
            formMain.SelectedDLGOBottomEdge = (short)upDown_BottomEdge.Value;
            formMain.RefreshDLGProperties();
            currentFadeTime = fadeTime;
            fadeTimer.Enabled = true;
            fadeTimer.Start();
            if (lastButton != 4)
            {
                clickCombo = 0;
                lastButton = 4;
            }
            clickCombo++;
            string comboText = "";
            if (clickCombo > 1)
            {
                comboText = "(" + clickCombo + "x) ";
            }
            label_fadeText.Text = comboText + "DLGO Set Position Applied";
            label_fadeText.ForeColor = Color.Fuchsia;
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            currentFadeTime -= 10;

            int fadeThresh = 3000;
            Debug.WriteLine((float)currentFadeTime / fadeThresh);
            if (currentFadeTime < fadeThresh)
            {
                label_fadeText.ForeColor = LerpColor(windowColor, fadeTextColor, (float)currentFadeTime /  fadeThresh);
            }
            if (currentFadeTime < 0)
            {
                lastButton = -1;
                currentFadeTime = 0;
                fadeTimer.Stop();
            }
            
        }


        Color LerpColor(Color color1, Color color2, float fac)
        {

            byte r = (byte)Lerp((float)color1.R, (float)color2.R, fac);
            Debug.WriteLine(r);
            byte g = (byte)Lerp((float)color1.G, (float)color2.G, fac);
            byte b = (byte)Lerp((float)color1.B, (float)color2.B, fac);
            return Color.FromArgb(r, g, b);
        }
        float Lerp(float x, float y, float fac)
        {
            return x * (1 - fac) + y * fac;
        }


    }
}
