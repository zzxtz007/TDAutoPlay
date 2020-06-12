# _*_ coding:UTF-8 _*_
import win32api
import win32con
import win32gui
from ctypes import *
import time

VK_CODE = {
    'backspace': 0x08,
    'tab': 0x09,
    'clear': 0x0C,
    'enter': 0x0D,
    'shift': 0x10,
    'ctrl': 0x11,
    'alt': 0x12,
    'pause': 0x13,
    'caps_lock': 0x14,
    'esc': 0x1B,
    'spacebar': 0x20,
    'page_up': 0x21,
    'page_down': 0x22,
    'end': 0x23,
    'home': 0x24,
    'left_arrow': 0x25,
    'up_arrow': 0x26,
    'right_arrow': 0x27,
    'down_arrow': 0x28,
    'select': 0x29,
    'print': 0x2A,
    'execute': 0x2B,
    'print_screen': 0x2C,
    'ins': 0x2D,
    'del': 0x2E,
    'help': 0x2F,
    '0': 0x30,
    '1': 0x31,
    '2': 0x32,
    '3': 0x33,
    '4': 0x34,
    '5': 0x35,
    '6': 0x36,
    '7': 0x37,
    '8': 0x38,
    '9': 0x39,
    'a': 0x41,
    'b': 0x42,
    'c': 0x43,
    'd': 0x44,
    'e': 0x45,
    'f': 0x46,
    'g': 0x47,
    'h': 0x48,
    'i': 0x49,
    'j': 0x4A,
    'k': 0x4B,
    'l': 0x4C,
    'm': 0x4D,
    'n': 0x4E,
    'o': 0x4F,
    'p': 0x50,
    'q': 0x51,
    'r': 0x52,
    's': 0x53,
    't': 0x54,
    'u': 0x55,
    'v': 0x56,
    'w': 0x57,
    'x': 0x58,
    'y': 0x59,
    'z': 0x5A,
    'numpad_0': 0x60,
    'numpad_1': 0x61,
    'numpad_2': 0x62,
    'numpad_3': 0x63,
    'numpad_4': 0x64,
    'numpad_5': 0x65,
    'numpad_6': 0x66,
    'numpad_7': 0x67,
    'numpad_8': 0x68,
    'numpad_9': 0x69,
    'multiply_key': 0x6A,
    'add_key': 0x6B,
    'separator_key': 0x6C,
    'subtract_key': 0x6D,
    'decimal_key': 0x6E,
    'divide_key': 0x6F,
    'F1': 0x70,
    'F2': 0x71,
    'F3': 0x72,
    'F4': 0x73,
    'F5': 0x74,
    'F6': 0x75,
    'F7': 0x76,
    'F8': 0x77,
    'F9': 0x78,
    'F10': 0x79,
    'F11': 0x7A,
    'F12': 0x7B,
    'F13': 0x7C,
    'F14': 0x7D,
    'F15': 0x7E,
    'F16': 0x7F,
    'F17': 0x80,
    'F18': 0x81,
    'F19': 0x82,
    'F20': 0x83,
    'F21': 0x84,
    'F22': 0x85,
    'F23': 0x86,
    'F24': 0x87,
    'num_lock': 0x90,
    'scroll_lock': 0x91,
    'left_shift': 0xA0,
    'right_shift ': 0xA1,
    'left_control': 0xA2,
    'right_control': 0xA3,
    'left_menu': 0xA4,
    'right_menu': 0xA5,
    'browser_back': 0xA6,
    'browser_forward': 0xA7,
    'browser_refresh': 0xA8,
    'browser_stop': 0xA9,
    'browser_search': 0xAA,
    'browser_favorites': 0xAB,
    'browser_start_and_home': 0xAC,
    'volume_mute': 0xAD,
    'volume_Down': 0xAE,
    'volume_up': 0xAF,
    'next_track': 0xB0,
    'previous_track': 0xB1,
    'stop_media': 0xB2,
    'play/pause_media': 0xB3,
    'start_mail': 0xB4,
    'select_media': 0xB5,
    'start_application_1': 0xB6,
    'start_application_2': 0xB7,
    'attn_key': 0xF6,
    'crsel_key': 0xF7,
    'exsel_key': 0xF8,
    'play_key': 0xFA,
    'zoom_key': 0xFB,
    'clear_key': 0xFE,
    '+': 0xBB,
    ',': 0xBC,
    '-': 0xBD,
    '.': 0xBE,
    '/': 0xBF,
    ';': 0xBA,
    '[': 0xDB,
    '\\': 0xDC,
    ']': 0xDD,
    "'": 0xDE,
    '`': 0xC0,
    'z1': 'q',
    'z2': 'w',
    'z3': 'e',
    'z4': 'r',
    'z5': 't',
    'z6': 'y',
    'z7': 'u',
    'x1': 'a',
    'x2': 's',
    'x3': 'd',
    'x4': 'f',
    'x5': 'g',
    'x6': 'h',
    'x7': 'j',
}


class POINT(Structure):
    _fields_ = [("x", c_ulong), ("y", c_ulong)]


def get_mouse_point():
    po = POINT()
    windll.user32.GetCursorPos(byref(po))
    return int(po.x), int(po.y)


def mouse_click(x=None, y=None):
    if not x is None and not y is None:
        mouse_move(x, y)
        time.sleep(0.05)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)


def mouse_dclick(x=None, y=None):
    if not x is None and not y is None:
        mouse_move(x, y)
        time.sleep(0.05)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)


def mouse_move(x, y):
    windll.user32.SetCursorPos(x, y)


def key_input(data):
    for d in data:
        for c in d['metre_data']:
            print(c)
            win32api.keybd_event(VK_CODE[c], VK_CODE[c], 0, 0)
            win32api.keybd_event(VK_CODE[c], VK_CODE[c], win32con.KEYEVENTF_KEYUP, 0)
        time.sleep(d['metre_time'])


def make_str(orc_str):
    make_speed = 0
    speed_multiple = 1

    # 偷懒写法
    # z + 1234567 = qwertyu
    # x + 1234567 = asdfghj
    is_z_flg = False
    is_x_flg = False
    #  判断是否连按
    is_flg = False
    templist = []

    data = []
    metre = {}
    for c in orc_str:
        # 处理括号 括号内的字符要同时播放
        if c is '(':
            is_flg = True
            templist = []
            continue
        if c is ')':
            is_flg = False
            # 同时
            metre['metre_data'] = templist
            metre['metre_time'] = 1 / (speed * speed_multiple) + make_speed
            # 节拍速度重置
            make_speed = 0
            speed_multiple = 1
            is_z_flg = False
            is_x_flg = False
            data.append(metre)
            metre = {}
            continue

        if c is 'x':
            is_x_flg = True
            continue

        if c is 'z':
            is_z_flg = True
            continue

        if is_z_flg:
            c = (VK_CODE['z' + c])

        if is_x_flg:
            c = (VK_CODE['x' + c])

        if is_flg:
            templist.append(c)
            continue

        if c is '/':
            speed_multiple = 2 * speed_multiple
            continue
        if c is '.':
            make_speed = (1 / (speed * speed_multiple * 2))
            continue
        if c is ' ' or c is '\n':
            continue
        temp = c
        if c is '-':
            c = temp

        c = c.lower()
        metre['metre_time'] = (1 / (speed * speed_multiple) + make_speed)
        metre['metre_data'] = c
        data.append(metre)
        metre = {}
        # 节拍速度重置
        make_speed = 0
        speed_multiple = 1
        is_z_flg = False
        is_x_flg = False

    return data


speed = 4

if __name__ == "__main__":
    # str = '/.1//(23)456'

    # # win32gui.SetForegroundWindow(395640)
    # # mouse_click(1024, 470)qghqewqghqewqwqghghqewqghgghqewqwqghqewqwqghqtwqewgseweweyeweweueweweteweqqwqhggghqewqghqtwqewhgqgqq-gewqqqqgewqqqqgewqqqwwwqweeeeqyyyyyyyetttyttgerrerewqqwwwwgerrerewqqtt---qqweet
    # # 逍遥叹
    # # str = '''gewqqq gwqqq gewqqqwwwqweee qyyyyyy yetttyt qerrerewqqwww gewqqq gwqqq gewqqqwwwqweee qyyyyyy yetttyt qerrerewqt qqweetyuyte qqwewqettyw eertteyuy1y yyttewqwewqwewq qqweetyuyte qqwewqettyw eertteuyu1uy yyttewq wewewewq '''
    # # str = '''dgh-e-w--qj--qjh-g-h-hjq-qwe--- qwe-e-w--qj--h-g-h---jhg---- h-hjq-jhg--d--h-hjq-qwe--- qwe-t-w--qj--h-g-h----q--w--e--- t-w---ety--uy--te---dty--1u--y---- ut--y-1-2-3-2-y-1--2-3-5--3-1-2-3-5-- 6------------'''
    # # 克罗地亚狂想曲
    # # str = 'u1yu1y erwerw rtee jqhjqh u1yu13y erweryw rtee jqhjqh jqh ehjqh ehjqhhghhjqh jqh ehjqh ehjqhhghhjqh jqh ehdfs fgdd'
    # # 天空之城
    # # str = 'yu1-u1 3 u--eey-ty 1 t-- eer-er 1 e-111u-rr u u-- yu1-u1 3 u--eey-ty 1 t-- er 1u-1 2231-1 uyyut y-- 123-23 5 2--tt1u1 3 3--- yu1 u 221-t--4 3 2 1 3------ 3 6-5 5 321-12 12 5 3-- 3 6-5-321-12 12 uy--yuy---'
    # # babaqunali
    # str = 'qqttyytrreewwq yyy1yttet yrrrrtqwee 1121ttet 112321u1 qyqqyyttet rrrttqwete hqhjjgtte qqwewqjq qtqteeewte hhhjqjhgee qtqteeeeuy 1yrewjq 1yrtyu1 qtqteeewte hhhjqjhgee qtqt eeeeuy 1yrtyu1'
    # # hui
    # str = 'y 123- 35312-y 132 1 y-tt- y 123-565312-y 132 1 y- 321yt y--ty12y1 323 3y2 1uyuyte et1 etu uyu-32 323 3y2 1uyuyte et1 et232ty-u--tey---- y 123- 35312-y 132 1 y-tt- y 123-565312-y 132 1 y- 321yt y--ty12y1 323 3y2 1uyuyte et1 etu uyu-32 323 3y2 1uyuyte et1 et232ty-- 323 3y2 1uyuyte et1 etu uyu-32 323 3y2 1uyuyte et1 et232ty-u----tey----'
    # # 欢沁
    # # str = 'h qhe--jwqjh--hhjqj g h-- h qhe--qwete--hjqwjqjhgh-- qqqqtt yeeeeee--qqqqtt yueeeeee-- rrrrqj eeeejh dhjwe1uyu e e-- h qhe--jwqjh--hhjqj g h-- h qhe--qwete--hjqwjqjhgh-- qqqqtt-yeeeeee-- qqqqtt yueeeeee-- rrrrqj--eeeejh-- ehjddqjhghjhd-- ewqjqqqqtt-yeeeeee-- qqqqtt yueeeeee-- rrrrqj--eeeejh--hqjwhqjrhqjdewqjh-- e e jwqjh--hhqwj g h-- h qhe-- qwete--hhqwj g h-- h-gh--e--jwqjh--hhjqj g h-- h qhe--qwete--hjqwjqjhgh-- qqqqtt-yeeeeee--qqqqtt yueeeeee-- rrrrqj--eeeejh--dhjwe1uyu e e--'
    # # 菊次郎的夏天
    # # str = 't123211--t12321233-- t123211---t12321253--- 34u55-55311- u55-5531--333-3-3-6--- yyy2u-- t123211--t12321233-- t123211---t12321253-- 34555-5531--34u55-5531- 12333-33-6-1-1--e----'
    # # str = '3--2--1--u--y--t--y--u-- 1--u--y--t--r--e--r--w-- 1u1qjtweq1uyu3564324431uytrewrew qwertwtreytrtrewqhyu1uytrewytytre- 3-2--1--2--1-3-2-4----- 5-345-345tyu12343-123-ertytrtertr-ytr- ewewqwertyr-yty-u1tyu123453-123- 212u12321u1-yu1-qwerewe1u1y-1uy-trtrertyuqy- 1u1-uyu121u1yu- 3erew2321eqytgfghyuyugfghytyuuyu q121ujqjhytyujewq1243et314342trte- 1u1-et-tyute-12313-321uy-ytyu1-32134-quyytwtte-- 334321--1121uy--1--1uyut--tt--ttytre--eerew1uyut-- tr-1-u--u5--t--r3--3--21---q-1--u--1-q-j-u-y-h-g-t- r-4-3-e-w-y-w-2-3-e-w-2-1-q-j-u-y-6-5-t-r--2t-2-3----'
    #
    # # 青花瓷
    str = '21y(1a)g(1q)y1 1y1(yg)(tq)we 21y(1h)e(1h)y1 1321(1h)jq ty3(3f)q(3r)23 3q)235(3g)h 3(3q)3(3g)(2w)(2r)(2t)(2q) 13g(2w)tyu 21y(1a)g(1q)y1 1y1(yg)(tq)we ty3(5d)j(5w)35 (5j)321(1h)jq 21232(2f)12 1y321(yg)(1w)(1r)1 agqwewqg(2g) 55323(yf)g 2353f(2w)ru2 55323(ts)d (2g)352h(1d)yu1 1235(6h)6(5d)53(3h)2(2g) (tg)3(2w)2a(1g)qwe'
    # # jianp1
    # str = '21Y(1a)g1y1 1y1y(tq)we 21y(1h)e1y1 1321(1h)jq ty3(3f)q(3r)23 3235(3g)h 333(3g)222(2q) 13g(2w)tyu 21y(1a)g1y1 1y1y(tq)we ty3(5d)j535 5321(1h)jq 21232(2f)12 1y321y(1w)(1r)1 agqwewqg(2g) 55323(yf)g 2353f(2w)ru2 55323(ts)d (2g)352h(1d)yu1 1235(6h)6(5d)53(3h)2(2g) (tg)3(2w)2a(1g)qwe'
    # #
    # str = 'eetyty1uytye eetyty1uyyew y2y2 y2yue wewtwtyu1uyu eetyty1uytye eetyty1uyyt3 y2y2 3uyu1u y2uey2ueyty 532 223123 532 22t343 33732 1u1236 y132y1uty y132y1uty'
    # 它y
    # # str = '12315/325/2/1y3/1ueu/y-u-12t/1/234 43212g12315/325/ 2/1yy/u1td/ty/u/ 12t/1/234/4321(1a)-g-r-a-g-345-5-5/5/56543-3-3-3/34321-1-1uyu-u12/23232g345-5-5-5/56543-3-3/34321uy/yu12t/1/232/221(1a)'
    #
    # str = 'y3u-uty-1uuyt-tye-yu1-y-32y-1ut-euy--123--y3t--yu1-uy-twe--1232323663-2--1uytteeuy---6-365-2121yt563---6-36-563221--yty3-3--6-365-2121yt563---6-88767--1yty1121---123--335tytt--1uytteeuyy---'
    # str = '1231 1231 345- 345- 5/6/5/431 5//6//5//431 3t1- 3t1- '
    # # 逍遥叹34
    # str = 'qg/h/q/e/w/q/g/h/q/e/w/q/ w/q/g/h/g/h/q/e/w/q/g/hg '
    # str = str + '/g/h/q/e/w/q/w/q/g/h/q/e/w/q/w/q /g/h/q/t/w/q/e/wgs'
    # str = str + '/e/w/e/w/e/y/e/w/e/w/e/u/e/w /e/w/e/t/e/w/(eq)/q/w/q/h/gg'
    # str = str + '/g/h/q/e/w/q/g/h/q/t/w/q/e/w/h/g q/g/qq-ge'
    # str = str + 'wqqqqge wqqqqge wqqqwwwq weeeeqy yyyyyye'
    # str = str + 'ttt/y/ttge rrerewq qwwwwge rrerewq qtt--'
    # str = str + '-qqweet .y/uyte- -qqw.e/wwq ett/t/yw- -ee45te'
    # str = str + 'uyu1(yuy)- /-yyt.t/ewq w/w/ewqw/w/ewq w/w/ewq-w(h)(wq) '
    # str = str + ''
    # str = '(qa)we1(ta)2(3q)1(4q)3(1q) (qa)we1(ta)2(3q)1(4q)3(1q) (qa)we1(ta)2(3q)1(4q)3(1q)'
    # str += '''(3a)4632(1a)2t(1q)tq(51tq)(51tq)(51tq)(51tq)(51tq)
    # (qa)we1(tq)2t(3s)t4t(3q)(tg)(5q)(tg)(1q)(tg)
    # (qa)we1(tq)2t(3s)t4t(3q)(tg)(2q)(tg)(3q)(tg)
    # (qa)we1(tq)2t(3s)t4t(3q)(tg)(5q)(tg)(1q)(tg)
    # (3a)4632(1a)2t(1q)t(52u)gg(tg)
    # (1a)g2(1w)gegt(4w)3g2 (1f)ahfq(1f)2
    # (3h)2(3d)4(3q)1(1d)2(3g)3(3d)4(33)2(1d)
    # fah(yf)1(4q)3(1f)y(rh)w(qf)g
    # (1a)gt(tq)g(1w)(4q)3g2 (1f)ay1432(1a)(1f)2
    # (3h)2(3d)4(3q)1(1d)2(3g)3(3d)4(33)2(1d)
    # f(4ya)(1h)(yf)(ra)(1a)2
    # (3a)2(3d)2(3q)2(1d)2(3g)3(3d)4(3j)2d1
    # fah(yf)1(4q)3(1f)y(rh)w(qf)g
    # (1h)2(3d)1(2q)3(1d)2(3f)1(2a)3(1h)2(3a)34
    # (5a)ge(2g)2gs(tj)(ys)u'''
    # 小毛驴
    # str = '/q/q/q/e /t/t/t/t /y/y/y/1 t- ' \
    #       '/r/r/r/y /e/e/e/e/w/w/w/w .tt /q/q/q/q /t/t/t/t ' \
    #       '/y/y/y/1 t- /r/r/r/y //e//e//e//e/e/e /w/w/w/e q-'
    # 两只老虎
    # str = 'qweq qweq ert ert /t/y/t/r eq /t/y/t/r eq wg q- wg q-'
    # 数鸭子
    # str = '/1/1/t/t/e/y/t/e /w/q/w/eq- eq/e/eq /e/e/t/yt-'
    # str += '/y/y/y/t/r/rr /w/e/w/qw- e/q/-e/q/- /e/e/t/yy-'
    # str += '1/t/tye /w/q/w/et- 1/t/tye /w/q/w/eq-'
    # 天空之城
    # str = '''
    # /h/j .q/jqe j--d .h/ghq g--d
    # .f/d/f.a d--q .j/ffj j--/h/j .qjq3
    # j--/d/d .h/ghq g--d f/q.hqjq
    # '''
    # 突然好想你/
    # str = '/y/u 132/1/2 t21/y/u 1321 3-/y/u 132/5/2 /4//3//2//-/3//2//2/.1 /y/u 1321 1--'
    # str = '/g/q/q/e/y/et /t/y/t/e/r/ew /h/w/w/r/u/u/y/t /r/r/r/e/h/j/-/j/q'

    # (3R)4(31)4(5U) 34 (3E)4(5U)
    # (5Y)434 (3W)1Y (3T)1 (2G) (1Q) (1T)Y(3H)(3R)4(31)4(5U) 34 (3E)4 (5U)
    # (5Y)434 (3W)1Y (3T)1(2G) (1Q) (1T)3(1Q)
    # (5Q) (ЗT)(2T)3 (2H)1(2E)3 YE
    # 3 (6F) (3Q)(2R) 11(1G)2 (3W)2 TW
    # (5Q) (3T) (2T)3 (2H)1(2E)3 YE3 (6F) (3Q) (1H) (3T) (1Q)GA
    # 1T (YF) (YR)T (1G)1
    # 1T (YD) (YE)T (1H)3
    # 1T (YS) (YR)T (1G)12 (1Q) (1G)Y (3Н)1T (YF) (YR)T (1G)1
    # 1T (YD) (YE)T (1H)3
    # 1T (YS) (YR)T (1G)12 (1Q) (1G)3(1A)
    # str = '/z6/z7 132/1/2 z521/z6/z7 1321 3--/z6/z7'
    # 下山
    # str = '/-/z6/z6//z5//z3//z5//z5//z5//z6//0//z5//z5//z3'
    # str += '/z5/z5/z5//z5//z3//z5/z5//z6/z5//z5//z3'
    # str += '/z6/z6/z6//z5//z3//z5//z5//z5//z6/-//z5//z3'
    # str += '/z5/z5//z5/z5//z6/.z5//-//-/.-'
    # str += '/-/z6/z6//z5//z3//z5//z5//z5//z6//0//z5//z5//z3'
    # str += '/z5/z5/z5//z5//z3//z5/z5//z6/z5//z5//z5'
    # str += '/z6/3//2//z6/z6/z6/3//2//z6/z6'
    # str += '/z6/3/2//1//z6z6/.0//z3'
    # str += '/.z3//z5//z6//z5/z5//z6//z5//z5//z3z3'
    # str += '/.z2//z3//z5//z3/z3/z5//z5//z6/z5/z3'
    # str += '/.z3//z5//z6//z5/z5//z6//z5//z5//z3z3'
    # str += '/z2/z3/z5//z5//z6(z3z5)/.0//z3'
    # str += '/.z3//z5//z6//z5/z5//z6//z5//z5//z3z3'
    # str += '/.z2//z3//z5//z3/z3/z5//z5//z6/z5/z3'
    # str += '/.z3//z5//z6//z5/z5//z6//z5//z5//z3z3'
    # str += '/z2//z2//z3/z2//z1//x6x6-'
    # 莫失莫忘
    # str = '.z6/z3/z6/3/2/1 2--- .1/z6/21/z6 z5---'
    # str += '.1/z6//3//5/-3 2--- .1/z6/21/z6 z5---'
    # str += '.z5/z61- 1/z6/12- .1/z6/2/1/1/z6 z5---'
    # str += '.1/z6//3//5/-3 2--- .1/z6/21/z6 z5---'
    # str += 'z5/z5/z61- 1/z6/12- .1/z6/21/z6 1---'
    # str += '.1/z6//3//5.3 2--- .1/z6/2/1/1/z6 1---'
    # str += '.z5/z61- 1/z6/12- /1/1/1/z6/21z6 z5---'

    # 千本樱
    # str = '/z6z6/z5/z6z6/z5 /z6z6/z5z61 /z6z6/z5/z6z6/z5 z6123'
    #
    # str += '/z2/z3//x6//x5//x6//x5/z2/z3//x6//x5//x6//x5 /z2/z3//x6//x5//x6//x5/z1/x7/x6/x5'
    # str += '/z2/z3//x6//x5//x6//x5/z2/z3//x6//x5//x6//x5 /z2/z3/z5/1//z7//1//z7//z6/z5/z3'
    #
    # str += '/z2/z3//x6//x5//x6//x5/z2/z3//x6//x5//x6//x5 /z2/z3//x6//x5//x6//x5/z1/x7/x6/x5'
    # str += '/z1//x6//z1/z2//z1//z2/z3//z2//z3//z5//1//z3//z5 /1/z7/z6/z5z6/z6/1'
    #
    # str += '/2/3//z6//z5//z6//z5/2/3//z6//z5//z6//z5 /2/3//z6//z5//z6//z5/1/z7/z6/z5'
    # str += '/2/3//z6//z5//z6//z5/2/3//z6//z5//z6//z5 /2/3/5/1//7//1//7//6/5/3'
    #
    # str += '/2/3//z6//z5//z6//z5/2/3//z6//z5//z6//z5 /2/3//z6//z5//z6//z5/1/z7/z6/z5'
    # str += '//3//2//3//5//6//5//3//2/z6/1/3/5 /66/56-'
    #
    # str += 'z6/.z6//z5/z6/1/2/3 z6/.z6//z5/z6/z5/z3/z5'
    # str += 'z6/.z6//z5/z6/1/2/3 321z6'
    #
    # str += 'z6/.z6//z5/z6/1/2/3 z6/.z6//z5/z6/z5/z5/z3'
    # str += 'z6/.z6//z5/z5/z6/1/2 321z6'
    #
    # str += '1z7z6z5 /z5//z5//z6/z3/z2z3-'
    # str += '/z3/z5z62z7 1/z7/z5z6-'
    #
    # str += '1z7z6z5 /z5//z5//z6/z3/z2z3/z3/z5'
    # str += '/z6z6/z612 z7--/z6/1'
    #
    # str += '/22/3.3/3 /5/6/2/13/z6/1'
    # str += '/22/33/3/3 /4/3/2/11/z6/1'
    #
    # str += '/22/3.3/3 /5/6/2/13/z6/1'
    # str += '4321 /1/2/z7/z5z6/z6/1'
    #
    # str += '/22/3.3/3 /5/6/2/13/z6/1'
    # str += '/22/33/3/3 /4/3/2/11/z6/1'
    #
    # str += '/22/3.3/3 /5/6/2/13/z6/1'
    # str += '4321 /2/1/3/56-'

    # 麻雀 85/60
    # str = '/z1/x6/z1//x6//z1/-/z3/0/z3 /x7/x5/x5/x5--'
    # str += '/z2/z2/z2//z1//z2/-/x5/0/x7 /x7/x6/x7/z1--'
    # str += '/z6/z6/z6//z6//z6/-/z3/0/z6 /z5/z3/z3.z3/0/z1'
    # str += '/z2/z2/z2//z1//z2/-/z5/0z1 /z1/x6x6-0'
    # str += '/z1/x6/z1//x6//z1/-/z3/0/z3 /x7/x5/x5/x5--'
    # str += '/z2/z2/z2//z1//z2/-/z5/0/x7 /x7/x6/x7/z1--'
    # str += '/z6/z6/z6//z6//z6/-/z3/0/z6 /z5/z3/z3.z3/0/z1'
    # str += '/z2/z2/z2//z1//z2/-/z5/0/z3 /z7/z6/z6.z6/1/z7'
    # str += 'z6/.z6//z5//z6//z5/z3/.z3//z1'
    # str += 'z2/.z2//z1//z2//z1/x6/.x6//z1'
    # str += 'z2/.z2//z1/z2/z3/z5/z2 /z2/z3/0/z5z3/1/z7'
    # str += 'z6/.z6//z5//z6//z5/z3/.z3//z1'
    # str += 'z2/.z2//z1//z2//z1/x6/.x6//z1'
    # str += 'z2/.z2//z1/z2/z5/0/z1 /-x6/x5x6/0/z3'
    # str += '1/0/z3z7/0/z2 /z1/x6x6-0'
    # 御剑江湖 65/60
    # str = '000/z3/z5 z63.2/1 .z7//1//z7z6z5 z6/z6/z71/1/2 3--/1/2'
    # str += '33.2/1 z7-z6z5 z6-.-//z7//z6 z5--- z6/z6/z71/z7/z6'
    # str += 'z5-z3- z6/z6/z71/1/2 3--/1/2 35.2/1 z7-z6z5'
    # str += 'z6--- 1-2- 3--5 2--/3/5 .6/7.6/5'
    # str += '3--/z3/5 .6/1.7/6 5--/6/7 1-.-/3 2---'
    # str += '3--5 2--/3/5 6 -.-/7 5-61 2326'
    # str += '1-23 5-31 235- 6--- 6---'
    # 先编译一遍
    # 回梦游仙
    # str = '/3/2 3/3/z6 2/1/z7 /.z6//z7/z6/z5 z3/z3/z5 1/z3/z5 2/1/z7 z6- z6/3/2 /3/2'
    # str += '3/3/z6 2/1/z7 /.z6//z7/z6/z5 z3/z3/z5 1/z3/z5 2/(31)/z7 z6- z6'
    # str += 'z6/1/2 3- /3/5/3/1 2- z6/1/3 21 z6- z6'
    # str += 'z6/1/2 3- /(56)/5/3/1 2- z6/1/3 21 z6- z6'
    # str += '/3/2 3/3/z6 2/1/z7 /.z6//z7/z6/z5 z3/z3/z5 1/z3/z5 2/(31)/z7 z6- z6/3/2 /3/2'
    # str += '3/3/z6 2/1/z7 /.z6//z7/z6/z5 z3/z3/z5 1/z3/z5 2/(13)/z7 z6- z7- z7/z6/z5 6-'
    music_data = make_str(str)
    for i in music_data:
        print(i)
    win32gui.SetForegroundWindow(264904)
    key_input(music_data)
