using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using all = DoAnWinformBanDienThoai.All;

namespace DoAnWinformBanDienThoai
{
    internal class All
    {
        public static void CheckDuplicateValues(DataGridView DGV)
        {
            List<object> checkedValues = new List<object>();

            foreach (DataGridViewRow row in DGV.Rows)
            {
                object cellValue = row.Cells["NameProducts"].Value;

                if (cellValue != null && checkedValues.Contains(cellValue))
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

                checkedValues.Add(cellValue);
            }
        }
        public static bool messageBox(string msg , MessageBoxButtons btn )
        {
            DialogResult result = MessageBox.Show(msg, "Thông báo", btn, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static void SetTimeout(Action action, int timeout)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = timeout;
            timer.Tick += (s, e) =>
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }
        public static void SetInterval(Action action, int timeout )
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = timeout;
            timer.Tick += (s, e) =>
            {
                action();
                timer.Start();
            };
            timer.Start();
            
        }
        public static void Graphicslable(string mgs, Panel pal,Color BackColor , Color color , int LocationX , int LocationY , int SizeX= 80 , int SizeY = 30)
        {
            
            Label myLabel = new Label();
            // Thiết lập thuộc tính của label
            myLabel.Text = mgs;
            /* myLabel.Location = new Point(10, 10);*/
            myLabel.AutoSize = false;
            myLabel.Location = new Point(LocationX,LocationY);
            myLabel.Anchor = AnchorStyles.None;
            myLabel.Size = new Size(SizeX , SizeY);
            myLabel.BackColor = BackColor;
            myLabel.ForeColor = color;
            myLabel.TextAlign = ContentAlignment.MiddleCenter;
            myLabel.BorderStyle = BorderStyle.FixedSingle;
            myLabel.Anchor = AnchorStyles.Bottom;
            myLabel.Cursor = Cursors.Hand;
            myLabel.Font = new Font(pal.Font, FontStyle.Bold);
            // Thêm label vào form
            pal.Controls.Add(myLabel);
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(myLabel, mgs);
        }
        public static void messageNoticationShow(string mgs, Panel pal , Color color)
        {
            Label myLabel = new Label();
            // Thiết lập thuộc tính của label
            myLabel.Text = mgs;
           /* myLabel.Location = new Point(10, 10);*/
            myLabel.AutoSize = false;

            myLabel.Location = new Point(pal.Width - 250 , 44);
            myLabel.Size = new Size(230, 50);
            myLabel.BackColor = Color.White;
            myLabel.ForeColor = color;
            myLabel.TextAlign = ContentAlignment.MiddleCenter;
            myLabel.BorderStyle = BorderStyle.Fixed3D;
            myLabel.Font = new Font(pal.Font, FontStyle.Bold );
            
            // Thêm label vào form
            pal.Controls.Add(myLabel);
            myLabel.BringToFront();
            var action = new Action(() =>
            {
                pal.Controls.Remove(myLabel);
            });
            SetTimeout(action, 3000);
        }
        public static void enterTextBox(KeyEventArgs e , dynamic next = null , dynamic behind = null , bool checkEnter = false )
        {
            
            if ((e.KeyValue == 40 || (checkEnter == false && e.KeyValue == 13)) && next != null)
            {
                if(next is Button && e.KeyValue == 13)
                {
                    next.PerformClick(); 
                }
                next.Focus();
            }
            else if (e.KeyValue == 38 && behind != null)
            {
                behind.Focus();
            }

        }
        public static void VNĐ(dynamic txt)
        {
            if (double.TryParse(txt.Text, out double s))
            {
                txt.Text = s.ToString("#,##0");
                txt.SelectionStart = txt.Text.Length;
            }
        }
        public static bool checkError(dynamic txt, ErrorProvider err , Panel pal, bool number = false)
        {
            if(txt is TextBox)
            {
                err.Clear();
                if (txt.Text == "" || (number == true && !(double.TryParse(txt.Text, out double s))))
                {
                    pal.BackColor = Color.Red;
                    err.SetError(txt, "không được để trống");
                    return false;
                }
            }
            if(txt is ComboBox)
            {
                if(txt.SelectedItem == null)
                {
                    pal.BackColor = Color.Red;
                    err.SetError(txt, "không được để trống");
                    return false;
                }
            }
            pal.BackColor = Color.Black;
            return true;
        }
        public static void TurnOnButton(params dynamic[] btns)
        {
            foreach(dynamic btn in btns)
            {
                btn.Enabled = true;
            }
        }
        public static void HidenTextPassword(TextBox txt)
        {
            if (txt.PasswordChar == '*') txt.PasswordChar = char.MinValue;
            else txt.PasswordChar = '*';
        }
        public static void TurnOffButton(params dynamic[]  btns)
        {
            foreach(dynamic btn in btns)
            {
                btn.Enabled = false; 
            }
        }
        public static bool clearTextBox(params TextBox[] txts) 
        {
            foreach(TextBox Txt in txts)
            {
                Txt.Clear() ;
            }
            return true;
        }
        public static bool errorPanel(params Panel[] pals)
        {
            foreach(Panel pal in pals)
            {
                if(pal.BackColor == Color.Red)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool errorDGV(DataGridView DGV)
        {
            foreach(DataGridViewRow row in DGV.Rows)
            {
                if(row.DefaultCellStyle.BackColor == Color.Salmon)
                {
                    messageBox("Kiểm tra (trùng lặp/nhập số) sản phẩm", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        public static void ForeColorGray(params dynamic[] txts)
        {
            foreach (dynamic txt in txts)
            {
                txt.ForeColor = Color.Gray;
            }
        }
        public static void ForeColorBlack(params dynamic[] txts)
        {
            foreach (dynamic txt in txts)
            {
                txt.ForeColor = Color.Black;
            }
        }
        public static void handleRender(dynamic handle , DataGridView DGV ,  string table)
        {
            DGV.DataSource = handle.render(table);
        }
        public static bool handleDelete(dynamic handle ,DataGridView DGV , string table )
        {
            
            int select = DGV.SelectedRows.Count;
            if (select > 0 &&
                messageBox("Bạn có muốn xóa không!", MessageBoxButtons.YesNo))
            {
                foreach (DataGridViewRow row in DGV.SelectedRows)
                {
                    handle.Id = row.Cells[0].Value.ToString();
                    handle.delete(table);
                }
                handleRender(handle , DGV , table);
                return true;
            }
            return false;
        }
        public static void ReadonlyCheck(params TextBox[] txts)
        {
            foreach(TextBox txt in txts)
            {
                if (txt.ReadOnly == true)
                {
                    txt.ReadOnly = false;
                    txt.ForeColor = Color.Black;
                    txt.Clear();
                }
                else if (txt.ReadOnly == false)
                {
                    txt.ReadOnly = true;
                    txt.ForeColor = Color.Silver;
                }
            }
        }
    }
}
