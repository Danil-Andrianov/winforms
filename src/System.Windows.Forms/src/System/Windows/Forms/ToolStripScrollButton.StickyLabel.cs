// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using static Interop;

namespace System.Windows.Forms
{
    internal partial class ToolStripScrollButton
    {
        internal class StickyLabel : Label
        {
            private ToolStripScrollButton ownerScrollButton;

            internal ToolStripScrollButton OwnerScrollButton
            {
                get { return ownerScrollButton; }
                set { ownerScrollButton = value; }
            }

            public bool FreezeLocationChange
            {
                get => false;
            }

            protected override AccessibleObject CreateAccessibilityInstance()
            {
                return new StickyLabelAccessibleObject(this);
            }

            protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
            {
                if (((specified & BoundsSpecified.Location) != 0) && FreezeLocationChange)
                {
                    return;
                }

                base.SetBoundsCore(x, y, width, height, specified);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg >= (int)User32.WM.KEYFIRST && m.Msg <= (int)User32.WM.KEYLAST)
                {
                    DefWndProc(ref m);
                    return;
                }

                base.WndProc(ref m);
            }
        }
    }
}
