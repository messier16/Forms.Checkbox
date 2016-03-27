﻿// Code ported from Obj-C to C#
// Taken from https://github.com/Marxon13/M13Checkbox
using System;

namespace Messier16.Forms.iOS.Controls
{
    public static class Constants
    {
        public const float BoxSize = 0.875f;
        public const float CheckHorizontalExtention = 0.125f;
        public const float CheckVerticalExtension = 0.125f;
        public const float CheckIndent = 0.125f;
        public const float CheckRaise = 0.1875f;
        public const float CheckSize = 0.8125f;
        public const float CheckBoxSpacing = 0.3125f;
        public const float M13CheckboxMaxFontSize = 100.0f;

        public const float DefaultHeight = 24.0f;
        public const float BoxRadius = 0.1875f;
        public const float BoxStrokeWidth = 0.05f;
        public const float M13CheckboxHeightAutomatic = float.MaxValue;
    }

    public enum CheckAlignment
    {
        Right,
        Left,
        Center
    }

    public enum CheckState
    {
        Unchecked,
        Checked,
        //        Mixed
    }
}

