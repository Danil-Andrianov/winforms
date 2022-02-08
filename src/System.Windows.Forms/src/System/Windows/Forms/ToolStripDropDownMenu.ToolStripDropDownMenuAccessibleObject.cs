// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using static Interop;

namespace System.Windows.Forms
{
    public partial class ToolStripDropDownMenu
    {
        public class ToolStripDropDownMenuAccessibleObject : ToolStripDropDownAccessibleObject
        {
            private readonly ToolStripDropDownMenu _owner;

            public ToolStripDropDownMenuAccessibleObject(ToolStripDropDownMenu owner) : base(owner)
            {
                _owner = owner;
            }

            //public override AccessibleObject HitTest(int x, int y)
            //{
            //    return _owner.DownScrollButton.AccessibilityObject;
            //}

            //internal override UiaCore.IRawElementProviderFragment? FragmentNavigate(UiaCore.NavigateDirection direction)
            //{
            //    switch (direction)
            //    {
            //        case UiaCore.NavigateDirection.Parent:
            //            return _owner.OwnerToolStrip.AccessibilityObject;
            //        case UiaCore.NavigateDirection.FirstChild:
            //        case UiaCore.NavigateDirection.LastChild:
            //            return _owner.UpScrollButton.Control.AccessibilityObject;
            //    }

            //    return base.FragmentNavigate(direction);
            //}
        }
    }
}
