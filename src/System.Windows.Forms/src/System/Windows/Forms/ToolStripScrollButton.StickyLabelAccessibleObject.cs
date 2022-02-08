// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using static Interop;

namespace System.Windows.Forms
{
    internal partial class ToolStripScrollButton
    {
        internal class StickyLabelAccessibleObject : Label.LabelAccessibleObject
        {
            private StickyLabel _owner;

            public StickyLabelAccessibleObject(StickyLabel owner) : base(owner)
            {
                _owner = owner;
            }

            // public override string Name { get => $"test - {Owner.Handle}"; set => base.Name = value; }

            internal override UiaCore.IRawElementProviderFragment? FragmentNavigate(UiaCore.NavigateDirection direction)
            {
                switch (direction)
                {
                    case UiaCore.NavigateDirection.Parent:
                    case UiaCore.NavigateDirection.PreviousSibling:
                    case UiaCore.NavigateDirection.NextSibling:
                        return _owner.OwnerScrollButton.AccessibilityObject.FragmentNavigate(direction);
                }

                return base.FragmentNavigate(direction);
            }

            //internal override UiaCore.IRawElementProviderFragmentRoot FragmentRoot
            //{
            //    get
            //    {
            //        return _owner.OwnerScrollButton.Owner.AccessibilityObject;
            //    }
            //}
        }
    }
}
