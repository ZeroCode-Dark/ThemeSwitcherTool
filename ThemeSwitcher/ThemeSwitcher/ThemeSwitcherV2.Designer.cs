﻿namespace ThemeSwitcher
{
    partial class ThemeSwitcherV2
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
            components = new System.ComponentModel.Container();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            tablelayout = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            // 
            // tablelayout
            // 
            tablelayout.BackColor = System.Drawing.Color.Silver;
            tablelayout.ColumnCount = 2;
            tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.Location = new System.Drawing.Point(20, 59);
            tablelayout.Name = "tablelayout";
            tablelayout.Padding = new System.Windows.Forms.Padding(5);
            tablelayout.RowCount = 1;
            tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.Size = new System.Drawing.Size(226, 54);
            tablelayout.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(20, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 28);
            label1.TabIndex = 4;
            label1.Text = "Theme";
            // 
            // ThemeSwitcherV2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(267, 385);
            Controls.Add(label1);
            Controls.Add(tablelayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ThemeSwitcherV2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ThemeSwitcherV2";
            TransparencyKey = System.Drawing.Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TableLayoutPanel tablelayout;
        private System.Windows.Forms.Label label1;

        #endregion

        //private ReaLTaiizor.Forms.AirForm airForm1;
    }
}