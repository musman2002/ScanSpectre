using System;
using System.Runtime.InteropServices;

namespace ScanSpectre
{
    public static class AcrylicBlur
    {
        private const int ACCENT_ENABLE_ACRYLICBLURBEHIND = 4;
        private const int WINDOWCOMPOSITIONATTRIB = 19;

        [StructLayout(LayoutKind.Sequential)]
        private struct AccentPolicy
        {
            public int AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WindowCompositionAttributeData
        {
            public int Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public static void ApplyAcrylic(IntPtr hwnd)
        {
            AccentPolicy accent = new()
            {
                AccentState = ACCENT_ENABLE_ACRYLICBLURBEHIND,
                AccentFlags = 2,
                GradientColor = unchecked((int)0xCC1A1A1A)
            };

            IntPtr accentPtr = Marshal.AllocHGlobal(Marshal.SizeOf(accent));
            Marshal.StructureToPtr(accent, accentPtr, false);

            WindowCompositionAttributeData data = new()
            {
                Attribute = WINDOWCOMPOSITIONATTRIB,
                Data = accentPtr,
                SizeOfData = Marshal.SizeOf(accent)
            };

            _ = SetWindowCompositionAttribute(hwnd, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }
    }
}
