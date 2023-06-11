using commuterLiners.AppCode;
using commuterLinersDAL;
using commutersLinersDAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commuterLiners.Forms
{
    public partial class frmSeatsSelection : Form
    {
        public int clickCount { get; set; }
        public int regularCount { get; set; }
        public int discountCount { get; set; }
        public static string concatenatedValues { get; private set; }
        private List<int> clickedButtonValues = new List<int>();
        private List<Button> buttons;
        public frmSeatsSelection()
        {
            InitializeComponent();
            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25, btn26, btn27, btn28, btn29, btn30, btn31, btn32, btn33, btn34, btn35, btn36, btn37, btn38, btn39, btn40, btn41, btn42, btn43, btn44, btn45, btn46, btn47, btn48, btn49, btn50, btn51, btn52, btn53, btn54, btn55 };
        }
        
        private void frmSeatsSelection_Load(object sender, EventArgs e)
        {
            string busNumber = DBHelper.GetLastCellValue();
            DataTable selectedStatus = DBHelper.GetSelectedStatus(busNumber);

            if (selectedStatus != null && selectedStatus.Rows.Count > 0)
            {
                DataRow row = selectedStatus.Rows[0];

                for (int i = 0; i < buttons.Count; i++)
                {
                    string columnName = "s" + (i + 1);
                    int cellValue = Convert.ToInt32(row[columnName]);

                    if (cellValue == 1)
                    {
                        buttons[i].BackColor = Color.Red;
                    }
                    else
                    {
                        buttons[i].BackColor = Color.FromArgb(112,173,71);
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to get selected status for bus number " + busNumber);
            }
        }

        private string InsertLineBreaks(string input, int charactersPerLine)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i += charactersPerLine)
            {
                int length = Math.Min(charactersPerLine, input.Length - i);
                sb.Append(input.Substring(i, length));

                if (i + charactersPerLine < input.Length)
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();

            if (btn1.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn1.Tag == null)
                {
                    clickCount++;
                    btn1.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn1UpdateSeats(is_selected, bus_number);
                    btn1.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }

            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn1UpdateSeats(is_selected,bus_number);
                btn1.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn2.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn2.Tag == null)
                {
                    clickCount++;
                    btn2.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn2UpdateSeats(is_selected, bus_number);
                    btn2.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn2UpdateSeats(is_selected, bus_number);
                btn2.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn3.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn3.Tag == null)
                {
                    clickCount++;
                    btn3.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn3UpdateSeats(is_selected, bus_number);
                    btn3.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn3UpdateSeats(is_selected, bus_number);
                btn3.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn4.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn4.Tag == null)
                {
                    clickCount++;
                    btn4.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn4UpdateSeats(is_selected, bus_number);
                    btn4.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn4UpdateSeats(is_selected, bus_number);
                btn4.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn5.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn5.Tag == null)
                {
                    clickCount++;
                    btn5.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn5UpdateSeats(is_selected, bus_number);
                    btn5.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn5UpdateSeats(is_selected, bus_number);
                btn5.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn6.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn6.Tag == null)
                {
                    clickCount++;
                    btn6.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn6UpdateSeats(is_selected, bus_number);
                    btn6.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn6UpdateSeats(is_selected, bus_number);
                btn6.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn7.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn7.Tag == null)
                {
                    clickCount++;
                    btn7.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn7UpdateSeats(is_selected, bus_number);
                    btn7.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn7UpdateSeats(is_selected, bus_number);
                btn7.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn8.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn8.Tag == null)
                {
                    clickCount++;
                    btn8.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn8UpdateSeats(is_selected, bus_number);
                    btn8.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn8UpdateSeats(is_selected, bus_number);
                btn8.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn9.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn9.Tag == null)
                {
                    clickCount++;
                    btn9.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn9UpdateSeats(is_selected, bus_number);
                    btn9.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn9UpdateSeats(is_selected, bus_number);
                btn9.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn10.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn10.Tag == null)
                {
                    clickCount++;
                    btn10.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn10UpdateSeats(is_selected, bus_number);
                    btn10.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn10UpdateSeats(is_selected, bus_number);
                btn10.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn11.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn11.Tag == null)
                {
                    clickCount++;
                    btn11.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn11UpdateSeats(is_selected, bus_number);
                    btn11.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn11UpdateSeats(is_selected, bus_number);
                btn11.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn12.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn12.Tag == null)
                {
                    clickCount++;
                    btn12.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn12UpdateSeats(is_selected, bus_number);
                    btn12.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn12UpdateSeats(is_selected, bus_number);
                btn12.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn13.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn13.Tag == null)
                {
                    clickCount++;
                    btn13.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn13UpdateSeats(is_selected, bus_number);
                    btn13.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn13UpdateSeats(is_selected, bus_number);
                btn13.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn14.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn14.Tag == null)
                {
                    clickCount++;
                    btn14.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn14UpdateSeats(is_selected, bus_number);
                    btn14.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn14UpdateSeats(is_selected, bus_number);
                btn14.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn15.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn15.Tag == null)
                {
                    clickCount++;
                    btn15.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn15UpdateSeats(is_selected, bus_number);
                    btn15.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn15UpdateSeats(is_selected, bus_number);
                btn15.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn16.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn16.Tag == null)
                {
                    clickCount++;
                    btn16.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn16UpdateSeats(is_selected, bus_number);
                    btn16.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn16UpdateSeats(is_selected, bus_number);
                btn16.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn17.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn17.Tag == null)
                {
                    clickCount++;
                    btn17.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn17UpdateSeats(is_selected, bus_number);
                    btn17.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn17UpdateSeats(is_selected, bus_number);
                btn17.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn18.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn18.Tag == null)
                {
                    clickCount++;
                    btn18.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn18UpdateSeats(is_selected, bus_number);
                    btn18.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn18UpdateSeats(is_selected, bus_number);
                btn18.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn19.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn19.Tag == null)
                {
                    clickCount++;
                    btn19.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn19UpdateSeats(is_selected, bus_number);
                    btn19.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn19UpdateSeats(is_selected, bus_number);
                btn19.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn20.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn20.Tag == null)
                {
                    clickCount++;
                    btn20.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn20UpdateSeats(is_selected, bus_number);
                    btn20.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn20UpdateSeats(is_selected, bus_number);
                btn20.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn21.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn21.Tag == null)
                {
                    clickCount++;
                    btn21.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn21UpdateSeats(is_selected, bus_number);
                    btn21.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn21UpdateSeats(is_selected, bus_number);
                btn21.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn22.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn22.Tag == null)
                {
                    clickCount++;
                    btn22.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn22UpdateSeats(is_selected, bus_number);
                    btn22.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn22UpdateSeats(is_selected, bus_number);
                btn22.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn23.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn23.Tag == null)
                {
                    clickCount++;
                    btn23.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn23UpdateSeats(is_selected, bus_number);
                    btn23.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn23UpdateSeats(is_selected, bus_number);
                btn23.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn24.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn24.Tag == null)
                {
                    clickCount++;
                    btn24.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn24UpdateSeats(is_selected, bus_number);
                    btn24.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn24UpdateSeats(is_selected, bus_number);
                btn24.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn25.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn25.Tag == null)
                {
                    clickCount++;
                    btn25.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn25UpdateSeats(is_selected, bus_number);
                    btn25.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn25UpdateSeats(is_selected, bus_number);
                btn25.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn26.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn26.Tag == null)
                {
                    clickCount++;
                    btn26.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn26UpdateSeats(is_selected, bus_number);
                    btn26.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn26UpdateSeats(is_selected, bus_number);
                btn26.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn27.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn27.Tag == null)
                {
                    clickCount++;
                    btn27.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn27UpdateSeats(is_selected, bus_number);
                    btn27.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn27UpdateSeats(is_selected, bus_number);
                btn27.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn28.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn28.Tag == null)
                {
                    clickCount++;
                    btn28.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn28UpdateSeats(is_selected, bus_number);
                    btn28.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn28UpdateSeats(is_selected, bus_number);
                btn28.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn29.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn29.Tag == null)
                {
                    clickCount++;
                    btn29.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn29UpdateSeats(is_selected, bus_number);
                    btn29.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn29UpdateSeats(is_selected, bus_number);
                btn29.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn30.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn30.Tag == null)
                {
                    clickCount++;
                    btn30.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn30UpdateSeats(is_selected, bus_number);
                    btn30.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn30UpdateSeats(is_selected, bus_number);
                btn30.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn31.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn31.Tag == null)
                {
                    clickCount++;
                    btn31.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn31UpdateSeats(is_selected, bus_number);
                    btn31.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn31UpdateSeats(is_selected, bus_number);
                btn31.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn32.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn32.Tag == null)
                {
                    clickCount++;
                    btn32.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn32UpdateSeats(is_selected, bus_number);
                    btn32.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn32UpdateSeats(is_selected, bus_number);
                btn32.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn33.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn33.Tag == null)
                {
                    clickCount++;
                    btn33.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn33UpdateSeats(is_selected, bus_number);
                    btn33.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn33UpdateSeats(is_selected, bus_number);
                btn33.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn34.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn34.Tag == null)
                {
                    clickCount++;
                    btn34.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn34UpdateSeats(is_selected, bus_number);
                    btn34.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn34UpdateSeats(is_selected, bus_number);
                btn34.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn35.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn35.Tag == null)
                {
                    clickCount++;
                    btn35.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn35UpdateSeats(is_selected, bus_number);
                    btn35.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn35UpdateSeats(is_selected, bus_number);
                btn35.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn36.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn36.Tag == null)
                {
                    clickCount++;
                    btn36.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn36UpdateSeats(is_selected, bus_number);
                    btn36.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn36UpdateSeats(is_selected, bus_number);
                btn36.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn37.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn37.Tag == null)
                {
                    clickCount++;
                    btn37.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn37UpdateSeats(is_selected, bus_number);
                    btn37.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn37UpdateSeats(is_selected, bus_number);
                btn37.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn38.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn38.Tag == null)
                {
                    clickCount++;
                    btn38.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn38UpdateSeats(is_selected, bus_number);
                    btn38.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn38UpdateSeats(is_selected, bus_number);
                btn38.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn39.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn39.Tag == null)
                {
                    clickCount++;
                    btn39.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn39UpdateSeats(is_selected, bus_number);
                    btn39.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn39UpdateSeats(is_selected, bus_number);
                btn39.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn40.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn40.Tag == null)
                {
                    clickCount++;
                    btn4.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn40UpdateSeats(is_selected, bus_number);
                    btn40.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn40UpdateSeats(is_selected, bus_number);
                btn40.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn41.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn41.Tag == null)
                {
                    clickCount++;
                    btn41.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn41UpdateSeats(is_selected, bus_number);
                    btn41.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn41UpdateSeats(is_selected, bus_number);
                btn41.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn42.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn42.Tag == null)
                {
                    clickCount++;
                    btn42.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn42UpdateSeats(is_selected, bus_number);
                    btn42.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn42UpdateSeats(is_selected, bus_number);
                btn42.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn43.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn43.Tag == null)
                {
                    clickCount++;
                    btn43.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn43UpdateSeats(is_selected, bus_number);
                    btn43.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn43UpdateSeats(is_selected, bus_number);
                btn43.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn44.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn44.Tag == null)
                {
                    clickCount++;
                    btn44.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn44UpdateSeats(is_selected, bus_number);
                    btn44.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn44UpdateSeats(is_selected, bus_number);
                btn44.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn45.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn45.Tag == null)
                {
                    clickCount++;
                    btn45.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn45UpdateSeats(is_selected, bus_number);
                    btn45.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn45UpdateSeats(is_selected, bus_number);
                btn45.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn46.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn46.Tag == null)
                {
                    clickCount++;
                    btn46.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn46UpdateSeats(is_selected, bus_number);
                    btn46.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn46UpdateSeats(is_selected, bus_number);
                btn46.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn47.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn47.Tag == null)
                {
                    clickCount++;
                    btn47.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn47UpdateSeats(is_selected, bus_number);
                    btn47.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn47UpdateSeats(is_selected, bus_number);
                btn47.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn48.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn48.Tag == null)
                {
                    clickCount++;
                    btn48.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn48UpdateSeats(is_selected, bus_number);
                    btn48.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn48UpdateSeats(is_selected, bus_number);
                btn48.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn49.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn49.Tag == null)
                {
                    clickCount++;
                    btn49.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn49UpdateSeats(is_selected, bus_number);
                    btn49.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn49UpdateSeats(is_selected, bus_number);
                btn49.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn50.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn50.Tag == null)
                {
                    clickCount++;
                    btn50.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn50UpdateSeats(is_selected, bus_number);
                    btn50.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn50UpdateSeats(is_selected, bus_number);
                btn50.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn51.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn51.Tag == null)
                {
                    clickCount++;
                    btn51.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn51UpdateSeats(is_selected, bus_number);
                    btn51.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn51UpdateSeats(is_selected, bus_number);
                btn51.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn52.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn52.Tag == null)
                {
                    clickCount++;
                    btn52.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn52UpdateSeats(is_selected, bus_number);
                    btn52.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn52UpdateSeats(is_selected, bus_number);
                btn52.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn53.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn53.Tag == null)
                {
                    clickCount++;
                    btn53.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn53UpdateSeats(is_selected, bus_number);
                    btn53.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn53UpdateSeats(is_selected, bus_number);
                btn53.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn54.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn54.Tag == null)
                {
                    clickCount++;
                    btn54.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn54UpdateSeats(is_selected, bus_number);
                    btn54.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn54UpdateSeats(is_selected, bus_number);
                btn54.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            string bus_number = DBHelper.GetLastCellValue();


            if (btn55.BackColor == Color.FromArgb(112, 173, 71))
            {
                int is_selected = 1;
                if (btn55.Tag == null)
                {
                    clickCount++;
                    btn55.Tag = "Clicked";
                }

                if (clickCount <= 1)
                {
                    DBUpdateSeats.btn55UpdateSeats(is_selected, bus_number);
                    btn55.BackColor = Color.Red;

                    Button clickedButton = (Button)sender;
                    int buttonValue = int.Parse(clickedButton.Text);

                    if (!clickedButtonValues.Contains(buttonValue))
                    {
                        clickedButtonValues.Add(buttonValue);
                    }

                    concatenatedValues = string.Join(", ", clickedButtonValues);
                    concatenatedValues = InsertLineBreaks(concatenatedValues, 18);
                }
            }
            else
            {
                int is_selected = 0;
                DBUpdateSeats.btn55UpdateSeats(is_selected, bus_number);
                btn55.BackColor = Color.FromArgb(112, 173, 71);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string busNumber = frmSelection.busNumber;
            string travelDate = frmSelection.travelDate;
            string destination = frmSelection.destination;
            int availableSeats = frmSelection.availableSeats;
            string ticketNumber = frmSelection.ticketNumber;
            string personCountRegular = frmBooking.personCountRegular;
            string personCountDiscount = frmBooking.personCountDiscount;
            string departure = "Olongapo";
            double labelRegular = frmBooking.labelRegular;
            double labelDiscount = frmBooking.labelDiscount;
            double price = labelRegular + labelDiscount;
            double total = frmBooking.total;
            regularCount = string.IsNullOrEmpty(personCountRegular) ? 0 : int.Parse(personCountRegular);
            discountCount = string.IsNullOrEmpty(personCountDiscount) ? 0 : int.Parse(personCountDiscount);

            DBHelper.InsertReceiptDetails(ticketNumber, busNumber, travelDate, departure, destination, concatenatedValues, availableSeats, personCountDiscount, personCountRegular, price, total);
            if (clickCount == regularCount || clickCount == discountCount)
            {
                frmReceipt frmReceipt = new frmReceipt();
                frmReceipt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The number of selected seats doesn't match the person count.", "Seat Selection Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.isDragging = true;
                Common.lastCursorPos = e.Location;
            }
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Common.isDragging)
            {
                int deltaX = e.Location.X - Common.lastCursorPos.X;
                int deltaY = e.Location.Y - Common.lastCursorPos.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.isDragging = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
