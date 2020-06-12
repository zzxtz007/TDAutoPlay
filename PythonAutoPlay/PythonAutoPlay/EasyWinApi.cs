using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PythonAutoPlay
{
    public class EasyWinApi
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,    //虚拟键值
            byte bScan,// 一般为0
            int dwFlags,  //这里是整数类型  0 为按下，2为释放
            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );


        private delegate bool WNDENUMPROC(IntPtr hWnd, int lParam); //IntPtr hWnd用int也可以

        //用来遍历所有窗口 
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);

        //获取窗口Text 
        [DllImport("user32.dll")]
        private static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        //获取窗口类名 
        [DllImport("user32.dll")]
        private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        public class WindowInfo
        {
            public IntPtr hWnd;
            public string szWindowName;
            public string szClassName;
        }

        public static WindowInfo[] GetAllDesktopWindows()
        {
            //用来保存窗口对象 列表
            List<WindowInfo> wndList = new List<WindowInfo>();

            //enum all desktop windows 
            EnumWindows(delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);

                //get hwnd 
                wnd.hWnd = hWnd;
                //get window name  
                GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.szWindowName = sb.ToString();

                //get window class 
                GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.szClassName = sb.ToString();

                //add it into list 
                wndList.Add(wnd);
                return true;
            }, 0);

            wndList = wndList.Where(c => string.IsNullOrWhiteSpace(c.szWindowName) == false).ToList();

            return wndList.ToArray();
        }

        public static WindowInfo[] GetWindowInfosByKey(string key)
        {
            //添加搜索
            var wndList = GetAllDesktopWindows();
            wndList = wndList.Where(c => c.szWindowName.Contains(key)).ToArray();
            return wndList;
        }

        public static IntPtr GetWindowIntPtrByKey(string key)
        {
            //添加搜索
            var wndList = GetAllDesktopWindows();
            var wnd  = wndList.FirstOrDefault(c => c.szWindowName.Contains(key)||c.hWnd.ToString()==key);
            return wnd.hWnd;
        }

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd,
            int hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            int uFlags
        );

        public static void SetWindowPos(IntPtr hWnd)
        {
            SetWindowPos(hWnd, -1, 0, 0, 0, 0, 3);
//            Thread.Sleep(500);
//            SetWindowPos(hWnd, -2, 0, 0, 0, 0, 3);
        }


        public static void sendKey(byte keys)
        {
            keybd_event(keys, keys, 0,0);
            keybd_event(keys, keys, 2,0);
        }
    }

    public static class VcCode
    {
        public static Dictionary<string, string> vc_code = new Dictionary<string, string>();

        static VcCode()
        {
            vc_code.Add("backspace", "0x08");
            vc_code.Add("tab", "0x09");
            vc_code.Add("clear", "0x0C");
            vc_code.Add("enter", "0x0D");
            vc_code.Add("shift", "0x10");
            vc_code.Add("ctrl", "0x11");
            vc_code.Add("alt", "0x12");
            vc_code.Add("pause", "0x13");
            vc_code.Add("caps_lock", "0x14");
            vc_code.Add("esc", "0x1B");
            vc_code.Add("spacebar", "0x20");
            vc_code.Add("page_up", "0x21");
            vc_code.Add("page_down", "0x22");
            vc_code.Add("end", "0x23");
            vc_code.Add("home", "0x24");
            vc_code.Add("left_arrow", "0x25");
            vc_code.Add("up_arrow", "0x26");
            vc_code.Add("right_arrow", "0x27");
            vc_code.Add("down_arrow", "0x28");
            vc_code.Add("select", "0x29");
            vc_code.Add("print", "0x2A");
            vc_code.Add("execute", "0x2B");
            vc_code.Add("print_screen", "0x2C");
            vc_code.Add("ins", "0x2D");
            vc_code.Add("del", "0x2E");
            vc_code.Add("help", "0x2F");
            vc_code.Add("0", "0x30");
            vc_code.Add("1", "0x31");
            vc_code.Add("2", "0x32");
            vc_code.Add("3", "0x33");
            vc_code.Add("4", "0x34");
            vc_code.Add("5", "0x35");
            vc_code.Add("6", "0x36");
            vc_code.Add("7", "0x37");
            vc_code.Add("8", "0x38");
            vc_code.Add("9", "0x39");
            vc_code.Add("a", "0x41");
            vc_code.Add("b", "0x42");
            vc_code.Add("c", "0x43");
            vc_code.Add("d", "0x44");
            vc_code.Add("e", "0x45");
            vc_code.Add("f", "0x46");
            vc_code.Add("g", "0x47");
            vc_code.Add("h", "0x48");
            vc_code.Add("i", "0x49");
            vc_code.Add("j", "0x4A");
            vc_code.Add("k", "0x4B");
            vc_code.Add("l", "0x4C");
            vc_code.Add("m", "0x4D");
            vc_code.Add("n", "0x4E");
            vc_code.Add("o", "0x4F");
            vc_code.Add("p", "0x50");
            vc_code.Add("q", "0x51");
            vc_code.Add("r", "0x52");
            vc_code.Add("s", "0x53");
            vc_code.Add("t", "0x54");
            vc_code.Add("u", "0x55");
            vc_code.Add("v", "0x56");
            vc_code.Add("w", "0x57");
            vc_code.Add("x", "0x58");
            vc_code.Add("y", "0x59");
            vc_code.Add("z", "0x5A");
            vc_code.Add("numpad_0", "0x60");
            vc_code.Add("numpad_1", "0x61");
            vc_code.Add("numpad_2", "0x62");
            vc_code.Add("numpad_3", "0x63");
            vc_code.Add("numpad_4", "0x64");
            vc_code.Add("numpad_5", "0x65");
            vc_code.Add("numpad_6", "0x66");
            vc_code.Add("numpad_7", "0x67");
            vc_code.Add("numpad_8", "0x68");
            vc_code.Add("numpad_9", "0x69");
            vc_code.Add("multiply_key", "0x6A");
            vc_code.Add("add_key", "0x6B");
            vc_code.Add("separator_key", "0x6C");
            vc_code.Add("subtract_key", "0x6D");
            vc_code.Add("decimal_key", "0x6E");
            vc_code.Add("divide_key", "0x6F");
            vc_code.Add("F1", "0x70");
            vc_code.Add("F2", "0x71");
            vc_code.Add("F3", "0x72");
            vc_code.Add("F4", "0x73");
            vc_code.Add("F5", "0x74");
            vc_code.Add("F6", "0x75");
            vc_code.Add("F7", "0x76");
            vc_code.Add("F8", "0x77");
            vc_code.Add("F9", "0x78");
            vc_code.Add("F10", "0x79");
            vc_code.Add("F11", "0x7A");
            vc_code.Add("F12", "0x7B");
            vc_code.Add("F13", "0x7C");
            vc_code.Add("F14", "0x7D");
            vc_code.Add("F15", "0x7E");
            vc_code.Add("F16", "0x7F");
            vc_code.Add("F17", "0x80");
            vc_code.Add("F18", "0x81");
            vc_code.Add("F19", "0x82");
            vc_code.Add("F20", "0x83");
            vc_code.Add("F21", "0x84");
            vc_code.Add("F22", "0x85");
            vc_code.Add("F23", "0x86");
            vc_code.Add("F24", "0x87");
            vc_code.Add("num_lock", "0x90");
            vc_code.Add("scroll_lock", "0x91");
            vc_code.Add("left_shift", "0xA0");
            vc_code.Add("right_shift ", "0xA1");
            vc_code.Add("left_control", "0xA2");
            vc_code.Add("right_control", "0xA3");
            vc_code.Add("left_menu", "0xA4");
            vc_code.Add("right_menu", "0xA5");
            vc_code.Add("browser_back", "0xA6");
            vc_code.Add("browser_forward", "0xA7");
            vc_code.Add("browser_refresh", "0xA8");
            vc_code.Add("browser_stop", "0xA9");
            vc_code.Add("browser_search", "0xAA");
            vc_code.Add("browser_favorites", "0xAB");
            vc_code.Add("browser_start_and_home", "0xAC");
            vc_code.Add("volume_mute", "0xAD");
            vc_code.Add("volume_Down", "0xAE");
            vc_code.Add("volume_up", "0xAF");
            vc_code.Add("next_track", "0xB0");
            vc_code.Add("previous_track", "0xB1");
            vc_code.Add("stop_media", "0xB2");
            vc_code.Add("play/pause_media", "0xB3");
            vc_code.Add("start_mail", "0xB4");
            vc_code.Add("select_media", "0xB5");
            vc_code.Add("start_application_1", "0xB6");
            vc_code.Add("start_application_2", "0xB7");
            vc_code.Add("attn_key", "0xF6");
            vc_code.Add("crsel_key", "0xF7");
            vc_code.Add("exsel_key", "0xF8");
            vc_code.Add("play_key", "0xFA");
            vc_code.Add("zoom_key", "0xFB");
            vc_code.Add("clear_key", "0xFE");
            vc_code.Add("+", "0xBB");
            vc_code.Add(",", "0xBC");
            vc_code.Add("-", "0xBD");
            vc_code.Add(".", "0xBE");
            vc_code.Add("/", "0xBF");
            vc_code.Add(";", "0xBA");
            vc_code.Add("[", "0xDB");
            vc_code.Add("\\", "0xDC");
            vc_code.Add("]", "0xDD");
            vc_code.Add("'", "0xDE");
            vc_code.Add("`", "0xC0");
            vc_code.Add("z1", "q");
            vc_code.Add("z2", "w");
            vc_code.Add("z3", "e");
            vc_code.Add("z4", "r");
            vc_code.Add("z5", "t");
            vc_code.Add("z6", "y");
            vc_code.Add("z7", "u");
            vc_code.Add("x1", "a");
            vc_code.Add("x2", "s");
            vc_code.Add("x3", "d");
            vc_code.Add("x4", "f");
            vc_code.Add("x5", "g");
            vc_code.Add("x6", "h");
            vc_code.Add("x7", "j");
        }

    }
}
