using Entities;
using LogicLayer;

namespace ZooBazzar_Group03.Forms
{
    public partial class ScheduleForm : Form
    {
        private int weekIndex = 0;
        public ScheduleForm()
        {
            InitializeComponent();         
            GetSchedule(0);
        }



        private void GetSchedule(int index)
        {
            pCalendar.Controls.Clear();
            pCalendar2.Controls.Clear();

            List<string> days = GUIHelper.GetWeek(DateTime.Now, index);


            for (int i = 0; i < days.Count; i++)
            {
                ucDate uc = new ucDate();
                uc.GetDate(days[i]);

                if (i < 4)
                {
                    pCalendar.Controls.Add(uc);
                }
                else
                {
                    pCalendar2.Controls.Add(uc);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            weekIndex -= 7;
            GetSchedule(weekIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            weekIndex += 7;
            GetSchedule(weekIndex);
        }

        private void LoadTheame()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ColorThemeHandler.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ColorThemeHandler.SecondaryColor;
                }
                else if(btns.GetType() == typeof(Label))
                {
                    btns.BackColor = ColorThemeHandler.PrimaryColor;
                    btns.ForeColor = Color.White;
                }
                
            }

        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            LoadTheame();
        }
    }
}
