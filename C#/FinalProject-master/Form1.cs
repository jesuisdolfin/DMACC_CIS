using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";

            string[] back = new string[5];
            string[] chest = new string[5];
            string[] legs = new string[5];
            string[] arms = new string[5];

            if (radioButton3.Checked == true)
            {
                back[0] = "Barbell Row: 3 sets of 6-8 repetitions";
                back[1] = "Lat Pulldown: 3 sets of 8 repetitions";
                back[2] = "Dumbbell Row: 3 sets of 8 repetitions";
                back[3] = "Close-grip Lat Pulldown: 4 sets of 10-12 repetitions";

                if (radioButton5.Checked == true)
                {
                    back[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    back[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    back[4] = "60 Seconds of rest in between sets";
                }

                chest[0] = "Bench Press: 4 sets of 6 repetitions";
                chest[1] = "Shoulder Press: 3 sets of 8 repetitions";
                chest[2] = "Dips: 3 sets of 8 repetitions";
                chest[3] = "Cable Flys: 4 sets of 10-12 repetitions";

                if (radioButton5.Checked == true)
                {
                    chest[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    chest[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    chest[4] = "60 Seconds of rest in between sets";
                }

                legs[0] = "Barbell Squat: 4 sets of 6-8 repetitions";
                legs[1] = "Hamstring Curls: 3 sets of 8 repetitions";
                legs[2] = "Goblet Squat: 3 sets of 8 repetitions";
                legs[3] = "Calf Raises: 3 sets of 8-10 repetitions";

                if (radioButton5.Checked == true)
                {
                    legs[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    legs[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    legs[4] = "60 Seconds of rest in between sets";
                }

                arms[0] = "Dips: 3 sets of 8 repetitions";
                arms[1] = "Chin-Ups: 3 sets of 8 repetitions";
                arms[2] = "Dumbbell Tricep Extensions: 3 sets of 8 repetitions";
                arms[3] = "Dumbbell Curls: 3 sets of 8-10 repetitions";

                if (radioButton5.Checked == true)
                {
                    arms[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    arms[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    arms[4] = "60 Seconds of rest in between sets";
                }
            }
            else if (radioButton4.Checked == true)
            {
                back[0] = "Barbell Row: 3 sets of 10-12 repetitions";
                back[1] = "Lat Pulldown: 3 sets of 12 repetitions";
                back[2] = "Dumbbell Row: 4 sets of 8-10 repetitions";
                back[3] = "Close-grip Lat Pulldown: 4 sets of 10-12 repetitions";

                if (radioButton5.Checked == true)
                {
                    back[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    back[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    back[4] = "60 Seconds of rest in between sets";
                }

                chest[0] = "Bench Press: 3 sets of 8-12 repetitions";
                chest[1] = "Shoulder Press: 3 sets of 8-12 repetitions";
                chest[2] = "Dips: 3 sets of 10-12 repetitions";
                chest[3] = "Cable Flys: 4 sets of 10-12 repetitions";

                if (radioButton5.Checked == true)
                {
                    chest[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    chest[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    chest[4] = "60 Seconds of rest in between sets";
                }

                legs[0] = "Barbell Squat: 3 sets of 8-10 repetitions";
                legs[1] = "Hamstring Curls: 3 sets of 12 repetitions";
                legs[2] = "Goblet Squat: 3 sets of 10-12 repetitions";
                legs[3] = "Calf Raises: 3 sets of 12 repetitions";

                if (radioButton5.Checked == true)
                {
                    legs[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    legs[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    legs[4] = "60 Seconds of rest in between sets";
                }

                arms[0] = "Dips: 3 sets of 8 repetitions";
                arms[1] = "Chin-Ups: 3 sets of 8 repetitions";
                arms[2] = "Dumbbell Tricep Extensions: 3 sets of 12 repetitions";
                arms[3] = "Dumbbell Curls: 3 sets of 12 repetitions";

                if (radioButton5.Checked == true)
                {
                    arms[4] = "30 Seconds of rest in between sets";
                }
                else if (radioButton6.Checked == true)
                {
                    arms[4] = "45 Seconds of rest in between sets";
                }
                else if (radioButton7.Checked == true)
                {
                    arms[4] = "60 Seconds of rest in between sets";
                }
            }

            foreach (string element in back)
            {
                label19.Text += element + "\n";
            }
            foreach (string element in chest)
            {
                label20.Text += element + "\n";
            }
            foreach (string element in legs)
            {
                label21.Text += element + "\n";
            }
            foreach (string element in arms)
            {
                label22.Text += element + "\n";
            }
            label18.Text = calcCalorieChange().ToString();
        }

        private Double calcCalorieChange()
        {
            Double maintenance = Double.Parse(textBox2.Text) * 15;
            Double newCalories = maintenance;

            if (radioButton5.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    newCalories += 750;
                }
                else if (radioButton2.Checked == true)
                {
                    newCalories -= 750;
                }
            }
            else if (radioButton6.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    newCalories += 500;
                }
                else if (radioButton2.Checked == true)
                {
                    newCalories -= 500;
                }
            }
            else if (radioButton7.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    newCalories += 250;
                }
                else if (radioButton2.Checked == true)
                {
                    newCalories -= 250;
                }
            }
            return newCalories;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
