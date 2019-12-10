using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ToggleDesktop
{
    public class ToogleDesktop
    {
        [Flags]
        private enum SSF : uint
        {
            SSF_SHOWALLOBJECTS = 0x00000001,
            SSF_SHOWEXTENSIONS = 0x00000002,
            SSF_HIDDENFILEEXTS = 0x00000004,
            SSF_SERVERADMINUI = 0x00000004,
            SSF_SHOWCOMPCOLOR = 0x00000008,
            SSF_SORTCOLUMNS = 0x00000010,
            SSF_SHOWSYSFILES = 0x00000020,
            SSF_DOUBLECLICKINWEBVIEW = 0x00000080,
            SSF_SHOWATTRIBCOL = 0x00000100,
            SSF_DESKTOPHTML = 0x00000200,
            SSF_WIN95CLASSIC = 0x00000400,
            SSF_DONTPRETTYPATH = 0x00000800,
            SSF_MAPNETDRVBUTTON = 0x00001000,
            SSF_SHOWINFOTIP = 0x00002000,
            SSF_HIDEICONS = 0x00004000,
            SSF_NOCONFIRMRECYCLE = 0x00008000,
            SSF_FILTER = 0x00010000,
            SSF_WEBVIEW = 0x00020000,
            SSF_SHOWSUPERHIDDEN = 0x00040000,
            SSF_SEPPROCESS = 0x00080000,
            SSF_NONETCRAWLING = 0x00100000,
            SSF_STARTPANELON = 0x00200000,
            SSF_SHOWSTARTPAGE = 0x00400000,
            SSF_AUTOCHECKSELECT = 0x00800000,
            SSF_ICONSONLY = 0x01000000,
            SSF_SHOWTYPEOVERLAY = 0x02000000,
            SSF_SHOWSTATUSBAR = 0x04000000
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SHELLSTATE
        {
            uint bitvector1;
            uint dwWin95Unused;
            uint uWin95Unused;
            uint lParamSort;
            uint iSortDirection;
            uint version;
            uint uNotUsed;
            uint bitvector2;

            ///<summary>TRUE to show all objects, including hidden files and folders. FALSE to hide hidden files and folders.</summary>

            public bool fShowAllObjects
            {
                get { return (bitvector1 & 0x00000001u) == 0x00000001u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000001u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000001u;
                    }
                }
            }

            public bool fShowExtensions
            {
                get { return (bitvector1 & 0x00000002u) == 0x00000002u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000002u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000002u;
                    }
                }
            }

            public bool fNoConfirmRecycle
            {
                get { return (bitvector1 & 0x00000004u) == 0x00000004u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000004u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000004u;
                    }
                }
            }

            public bool fShowSysFiles
            {
                get { return (bitvector1 & 0x00000008u) == 0x00000008u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000008u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000008u;
                    }
                }
            }

            public bool fShowCompColor
            {
                get { return (bitvector1 & 0x00000010u) == 0x00000010u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000010u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000010u;
                    }
                }
            }

            public bool fDoubleClickInWebView
            {
                get { return (bitvector1 & 0x00000020u) == 0x00000020u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000020u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000020u;
                    }
                }
            }

            public bool fDesktopHTML
            {
                get { return (bitvector1 & 0x00000040u) == 0x00000040u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000040u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000040u;
                    }
                }
            }

            public bool fWin95Classic
            {
                get { return (bitvector1 & 0x00000080u) == 0x00000080u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000080u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000080u;
                    }
                }
            }

            public bool fDontPrettyPath
            {
                get { return (bitvector1 & 0x00000100u) == 0x00000100u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000100u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000100u;
                    }
                }
            }

            public bool fShowAttribCol
            {
                get { return (bitvector1 & 0x00000200u) == 0x00000200u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000200u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000200u;
                    }
                }
            }

            public bool fMapNetDrvBtn
            {
                get { return (bitvector1 & 0x00000400u) == 0x00000400u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000400u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000400u;
                    }
                }
            }

            public bool fShowInfoTip
            {
                get { return (bitvector1 & 0x00000800u) == 0x00000800u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00000800u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00000800u;
                    }
                }
            }

            public bool fHideIcons
            {
                get { return (bitvector1 & 0x00001000u) == 0x00001000u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00001000u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00001000u;
                    }
                }
            }

            public bool fWebView
            {
                get { return (bitvector1 & 0x00002000u) == 0x00002000u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00002000u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00002000u;
                    }
                }
            }

            public bool fFilter
            {
                get { return (bitvector1 & 0x00004000u) == 0x00004000u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00004000u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00004000u;
                    }
                }
            }

            public bool fShowSuperHidden
            {
                get { return (bitvector1 & 0x00008000u) == 0x00008000u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00008000u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00008000u;
                    }
                }
            }

            public bool fNoNetCrawling
            {
                get { return (bitvector1 & 0x00010000u) == 0x00010000u; }
                set
                {
                    if (value)
                    {
                        bitvector1 |= 0x00010000u;
                    }
                    else
                    {
                        bitvector1 &= ~0x00010000u;
                    }
                }
            }

            public bool fSepProcess
            {
                get { return (bitvector2 & 0x00000001u) == 0x00000001u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000001u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000001u;
                    }
                }
            }

            public bool fStartPanelOn
            {
                get { return (bitvector2 & 0x00000002u) == 0x00000002u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000002u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000002u;
                    }
                }
            }

            public bool fShowStartPage
            {
                get { return (bitvector2 & 0x00000004u) == 0x00000004u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000004u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000004u;
                    }
                }
            }

            public bool fAutoCheckSelect
            {
                get { return (bitvector2 & 0x00000008u) == 0x00000008u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000008u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000008u;
                    }
                }
            }

            public bool fIconsOnly
            {
                get { return (bitvector2 & 0x00000010u) == 0x00000010u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000010u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000010u;
                    }
                }
            }

            public bool fShowTypeOverlay
            {
                get { return (bitvector2 & 0x00000020u) == 0x00000020u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000020u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000020u;
                    }
                }
            }

            public bool fShowStatusBar
            {
                get { return (bitvector2 & 0x00000040u) == 0x00000040u; }
                set
                {
                    if (value)
                    {
                        bitvector2 |= 0x00000040u;
                    }
                    else
                    {
                        bitvector2 &= ~0x00000040u;
                    }
                }
            }
        }

        private enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        private const int WM_COMMAND = 0x111;

        private static SHELLSTATE state = new SHELLSTATE();

        #region WinApi import

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent,
            IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", SetLastError = false)]
        private static extern IntPtr GetShellWindow();

        [DllImport("Shell32.dll")]
        private static extern void SHGetSetSettings(ref SHELLSTATE lpss, SSF dwMask, bool bSet);


        #endregion

        private static string GetWindowText(IntPtr hWnd)
        {
            int size = GetWindowTextLength(hWnd);
            if (size++ > 0)
            {
                var builder = new StringBuilder(size);
                GetWindowText(hWnd, builder, builder.Capacity);
                return builder.ToString();
            }

            return String.Empty;
        }

        private static IEnumerable<IntPtr> FindWindowsWithClass(string className)
        {
            IntPtr found = IntPtr.Zero;
            List<IntPtr> windows = new List<IntPtr>();

            EnumWindows(delegate(IntPtr wnd, IntPtr param)
                {
                    StringBuilder cl = new StringBuilder(256);
                    GetClassName(wnd, cl, cl.Capacity);
                    if (cl.ToString() == className && (GetWindowText(wnd) == "" || GetWindowText(wnd) == null))
                    {
                        windows.Add(wnd);
                    }

                    return true;
                },
                IntPtr.Zero);

            return windows;
        }

        public static void
            ToggleDesktopIcons() //Thanks to https://stackoverflow.com/questions/17503289/how-to-refresh-reload-desktop
        {
            state = new SHELLSTATE();
            var toggleDesktopCommand = new IntPtr(0x7402);
            IntPtr hWnd = IntPtr.Zero;
            if (Environment.OSVersion.Version.Major < 6 || Environment.OSVersion.Version.Minor < 2) //7 and -
                hWnd = GetWindow(FindWindow("Progman", "Program Manager"), GetWindow_Cmd.GW_CHILD);
            else
            {
                IEnumerable<IntPtr> ptrs = FindWindowsWithClass("WorkerW");
                int i = 0;
                while (hWnd == IntPtr.Zero && i < ptrs.Count())
                {
                    hWnd = FindWindowEx(ptrs.ElementAt(i), IntPtr.Zero, "SHELLDLL_DefView", null);
                    i++;
                }
            }

            SHGetSetSettings(ref state, SSF.SSF_HIDEICONS, false);
            state.fHideIcons = !state.fHideIcons;
            SHGetSetSettings(ref state, SSF.SSF_HIDEICONS, true);

            if (hWnd == IntPtr.Zero)
            {
                //"SHELLDLL_DefView" was not found as a child within WorkerW - Lets check the current ShellWindow
                IntPtr desktop = GetShellWindow();
                hWnd = FindWindowEx(desktop, IntPtr.Zero, "SHELLDLL_DefView", null);
            }

            if (hWnd != IntPtr.Zero)
            {
                SendMessage(hWnd, WM_COMMAND, toggleDesktopCommand, IntPtr.Zero);
            }
        }
    }
}
