from time import sleep

import win32gui

hwnd_title = dict()

from pymouse import PyMouse
from pykeyboard import PyKeyboard

# win32gui.SetForegroundWindow(9701852)


# 实例化
# m = PyMouse()
k = PyKeyboard()

# x_dim, y_dim = m.screen_size()qwer
# 鼠标点击 参数:x,y,button=1(左键)、2(右键)、3(中间),次数
# m.click(x_dim, y_dim, button=1, n=1)
# 键盘输入 参数:str,间隔
# k.type_string('1234567', interval=1)
# for i in 'qwer':
#     sleep(1)
#     k.press_key(i)
#     k.release_key(i)
#
# # 相当于===>按住并松开，tap一个键
# k.tap_key('e')
# # tap支持重复的间歇点击键,参数:str,次数,间隔
# k.tap_key('l', n=2, interval=5)
#
# # 创建组合键===>press_key和release_key结合使用
# k.press_key(k.alt_key)
# k.tap_key(k.tab_key)
# k.release_key(k.alt_key)
#
# # 特殊功能键
# k.tap_key(k.function_keys[5])  # Tap F5
# k.tap_key(k.numpad_keys['Home'])  # Tap 'Home' on the numpad
# k.tap_key(k.numpad_keys[5], n=3)  # Tap 5 on the numpad, thrice
#
# # Mac系统按键
# k.press_keys(['Command', 'shift', '3'])
# # Windows系统按键
# k.press_keys([k.windows_l_key, 'd'])


#
# 其中pymouse的PyMouseEvent和pykeyboard的PyKeyboardEvent还可用于监听鼠标和键盘事件的输入
# class Clickonacci(PyMouseEvent):
#     def __init__(self):
#         PyMouseEvent.__init__(self)
#         self.fibo = fibo()
#
#     def click(self, x, y, button, press):
#         '''Print Fibonacci numbers when the left click is pressed.'''
#         if button == 1:
#             if press:
#                 print('Press times:%d'.format(press))
#         else: # Exit if any other mouse button used
#             self.stop()
#
# C = Clickonacci()
# C.run()
#
# class TapRecord(PyKeyboardEvent):
#     def __init__(self):
#         PyKeyboardEvent.__init__(self)
#
#     def tap(self, keycode, character, press):
#         print(time.time(), keycode, character, press)
#
# t = TapRecord()
# t.run()
# #这些对象是一个架构用于监听鼠标和键盘的输入；他们除了监听之外不会做任何事，需要继承重构他们#PyKeyboardEvent为编写完成，所以这里是一个继承PyMouseEvent的例子：

def get_all_hwnd(hwnd, mouse):
    if win32gui.IsWindow(hwnd) and win32gui.IsWindowEnabled(hwnd) and win32gui.IsWindowVisible(hwnd):
        hwnd_title.update({hwnd: win32gui.GetWindowText(hwnd)})


def press(key):
    key = key[0]


if __name__ in "__main__":
    win32gui.EnumWindows(get_all_hwnd, 0)
    for h, t in hwnd_title.items():
        if t is not "":
            print(h, t)
# 9701852

