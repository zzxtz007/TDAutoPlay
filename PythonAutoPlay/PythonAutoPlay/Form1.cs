using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythonAutoPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iniForm();
        }

       
        private void iniForm()
        {
            initHandleList();
        }
        private void initHandleList()
        {
            handleList.View = View.Details;
            ColumnHeader ch = new ColumnHeader();

            ch.Text = "标题窗口";   //设置列标题


            ch.TextAlign = HorizontalAlignment.Center;

            ColumnHeader ch1 = new ColumnHeader();
            ch1.Text = "标题句柄";   //设置列标题

            ch1.TextAlign = HorizontalAlignment.Center;   //设置列的对齐方式

            handleList.Columns.Add(ch1);

            handleList.Columns.Add(ch);

 

            this.handleList.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

//            bindGrid();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void bindGrid()
        {
            handleList.Items.Clear();
            var windowslist = EasyWinApi.GetWindowInfosByKey(searchTxt.Text);
            foreach (var info in windowslist)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = info.hWnd.ToString();

                lvi.SubItems.Add(info.szWindowName);

                this.handleList.Items.Add(lvi);
            }



            this.handleList.EndUpdate();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var focused = handleList.FocusedItem;
            if (focused!=null)
            {
                handleLock.Text = focused.SubItems[0].Text;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(handleLock.Text))
            {
                return;
            }
            var handle = EasyWinApi.GetWindowIntPtrByKey(handleLock.Text);
            EasyWinApi.SetWindowPos(handle);
            var text = mainText.Text;
            var metres = makeString(text);
//            string temp = "";
//            foreach (var metre in metres)
//            {
//                temp += metre.data;
//            }
            doPlay(metres);

//            MessageBox.Show(temp);

        }

        private void doPlay(List<Metre> metres)
        {
            foreach (var metre in metres)
            {
                foreach (var c in metre.data)
                {
                    try
                    {
                        string bytestr = VcCode.vc_code[c.ToString()].ToString();
                        byte key = Convert.ToByte(bytestr,16);
                        EasyWinApi.sendKey(key);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        break;
                    }
                }
                Thread.Sleep(Convert.ToInt32(1000* metre.time));
            }
        }

        private List<Metre> makeString(string text)
        {
            //默认为4
            double speed =4;
            try
            {
                speed = Double.Parse(playSpeed.Text);
            }
            catch (Exception e)
            {
            }
            double make_speed = 0;
            double speed_multiple = 1;

//            # 偷懒写法
//            # z + 1234567 = qwertyu
//            # x + 1234567 = asdfghj
            bool is_z_flg = false;
            bool is_x_flg = false;
//#  判断是否连按
            bool is_flg = false;
         string tempStr = "";

            List<Metre> data = new List<Metre>();
            var metre = new Metre();

            text = text.ToLower();
            foreach (var c in text)
            {
                string s = c.ToString();
                if (s == '('.ToString())
                {
                    is_flg = true;
                    continue;
                }
                if (s == ')'.ToString())
                {
                    is_flg = false;
                    metre.data = tempStr;
                    tempStr = "";
                    metre.time = 1 / (speed_multiple * speed) + make_speed;
                    make_speed = 0;
                    speed_multiple = 1;
                    is_x_flg = false;
                    is_z_flg = false;
                    data.Add(metre);
                    metre = new Metre();
                    continue;
                }

                if (s == 'x'.ToString())
                {
                    is_x_flg = true;
                    continue;
                }
                if (s == 'z'.ToString())
                {
                    is_z_flg = true;
                    continue;
                }

                try
                {if (is_z_flg)
                    {
                        s = (VcCode.vc_code["z" + s]);
                    }
                    if (is_x_flg)
                    {
                        s = (VcCode.vc_code["x" + s]);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return new List<Metre>();
                }
               

                if (is_flg)
                {
                    tempStr += s;
                    continue;
                }

                //计算速度
                if (s == "/")
                {
                    speed_multiple = 2 * speed_multiple;
                    continue;
                }

                if (s == ".")
                {
                    make_speed = (1 / (speed * speed_multiple * 2));
                    continue;
                }

                if (s == " " || s == "\n")
                {
                    continue;
                }

                metre.data = s;
                metre.time = (1 / (speed * speed_multiple) + make_speed);
                data.Add(metre);
                metre = new Metre();

                make_speed = 0;
                speed_multiple = 1;
                is_x_flg = false;
                is_z_flg = false;
                

            }

            return data;
        }

        class Metre
        {
            public double time { get; set; }

            public string data { get; set; }
        }

        private void handleList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void handleList_DoubleClick(object sender, EventArgs e)
        {
            var focused = handleList.FocusedItem;
            if (focused != null)
            {
                handleLock.Text = focused.SubItems[0].Text;
            }
        }
    }
}
