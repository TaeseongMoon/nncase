﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace NnCase
{
    [StructLayout(LayoutKind.Sequential)]
    [DebuggerDisplay("{DebuggerDisplay}")]
    public struct ValueRange<T>
    {
        public T Min { get; set; }

        public T Max { get; set; }

        private string DebuggerDisplay => $"{{Min = {Min}, Max = {Max}}}";
    }
}
