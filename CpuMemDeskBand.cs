﻿using System.ComponentModel;
using System.Runtime.InteropServices;
using DeskBandUI_NS;
using SharpShell.SharpDeskBand;

[ComVisible(true)]
[DisplayName("CPU Mem")]
public class CpuMemDeskBand : SharpDeskBand {

    protected override System.Windows.Forms.UserControl CreateDeskBand() => new DeskBandUI();

    protected override BandOptions GetBandOptions() {

        return new BandOptions {
            HasVariableHeight = false,
            IsSunken = false,
            ShowTitle = true,
            Title = "CPU Mem",
            UseBackgroundColour = false,
            AlwaysShowGripper = true
        };
    }
}