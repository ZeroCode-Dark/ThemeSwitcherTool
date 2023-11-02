﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeSwitcher.CONTROL;
using ThemeSwitcher.STATICS;

namespace ThemeSwitcher
{
    public partial class ThemeSwitcherV2 : Form
    {
        public ThemeSwitcherV2()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(STATIC.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            STATIC.InitializeContextMenu(notifyIcon, this, Properties.Resources.notify);

            SwitchButton btnLight = new SwitchButton(Properties.Resources.Sun, "Light", "light");
            SwitchButton btnDark = new SwitchButton(Properties.Resources.Moon, "Dark", "dark");

            STATIC.switchBtns.Clear();
            STATIC.switchBtns.Add(btnLight);
            STATIC.switchBtns.Add(btnDark);

            btnLight.Width = Convert.ToInt16(tablelayout.Width * 0.50);
            btnDark.Width = Convert.ToInt16(tablelayout.Width * 0.50);
            btnLight.Height = tablelayout.Height;
            btnDark.Height = tablelayout.Height;

            tablelayout.Controls.Add(btnLight);
            tablelayout.Controls.Add(btnDark);


        }

    }
}
