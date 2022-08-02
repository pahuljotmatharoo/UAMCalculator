namespace UAM_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label14.Visible = false;
            
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

    private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b) && double.TryParse(textBox3.Text, out double c))
            {
                int d = 0;
                switch (comboBox5.SelectedIndex)
                {
                    case 0:
                        d = 1;
                        break;
                    case 1:
                        d = 2;
                        break;
                    case 2:
                        d = 3;
                        break;
                    case 3:
                        d = 4;
                        break;
                    case 4:
                        d = 5;
                        break;
                    case 5:
                        d = 6;
                        break;
                    case 6:
                        d = 7;
                        break;
                }
                textBox4.Visible = true;
                textBox5.Visible = true;
                label14.Visible = true;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        label15.Text = "m";
                        label16.Text = "m/s^2";
                        break;
                    case 1:
                        label15.Text = "m";
                        label16.Text = "m/s";
                        break;
                    case 2:
                        label15.Text = "m";
                        label16.Text = "s";
                        break;
                    case 3:
                        label15.Text = "m";
                        label16.Text = "m/s";
                        break;
                    case 4:
                        label15.Text = "m/s";
                        label16.Text = "m/s^2";
                        break;
                    case 5:
                        label15.Text = "m/s";
                        label16.Text = "m/s";
                        break;
                    case 6:
                        label15.Text = "m/s";
                        label16.Text = "s";
                        break;
                    case 7:
                        label15.Text = "m/s";
                        label16.Text = "m/s^2";
                        break;
                    case 8:
                        label15.Text = "m/s";
                        label16.Text = "s";
                        break;
                    case 9:
                        label15.Text = "m/s^2";
                        label16.Text = "s";
                        break;
                }

                // For Units (first unit box)
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        switch (comboBox2.SelectedIndex)
                        {
                            case 1:
                                a = a * 1000;
                                break;
                            case 2:
                                a = a / 3.6;
                                break;
                        }
                        break;
                }

                // For Units (second unit box)
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                            case 2:
                                b = b / 3.6;
                                break;
                        }
                        break;
                    case 1:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                            case 2:
                                b = b / 3.6;
                                break;
                        }
                        break;
                    case 2:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                            case 2:
                                b = b / 3.6;
                                break;
                        }
                        break;
                    case 3:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                            case 2:
                                b = b / 3.6;
                                break;
                        }
                        break;
                    case 4:
                    case 5:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                        }
                        break;
                    case 6:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                            case 2:
                                b = b / 3.6;
                                break;
                        }
                        break;
                    case 7:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                        }
                        break;
                    case 8:
                    case 9:
                        switch (comboBox3.SelectedIndex)
                        {
                            case 1:
                                b = b * 1000;
                                break;
                            case 2:
                                b = b / 3.6;
                                break;
                        }
                        break;
                }

                // For Units (third unit box)
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                    case 1:
                        switch (comboBox4.SelectedIndex)
                        {
                            case 1:
                                c = c * 60;
                                break;
                            case 2:
                                c = c * 60 * 60;
                                break;
                        }
                        break;
                    case 2:
                        switch (comboBox4.SelectedIndex)
                        {
                            case 1:
                                c = c * 1000;
                                break;
                            case 2:
                                c = c / 3.6;
                                break;
                        }
                        break;
                    case 3:
                    case 4:
                    case 5:
                        switch (comboBox4.SelectedIndex)
                        {
                            case 1:
                                c = c * 60;
                                break;
                            case 2:
                                c = c * 60 * 60;
                                break;
                        }
                        break;
                    case 6:
                        switch (comboBox4.SelectedIndex)
                        {
                            case 1:
                                c = c * 1000;
                                break;
                        }
                        break;
                    case 7:
                        switch (comboBox4.SelectedIndex)
                        {
                            case 1:
                                c = c * 60;
                                break;
                            case 2:
                                c = c * 60 * 60;
                                break;
                        }
                        break;
                    case 8:
                    case 9:
                        switch (comboBox4.SelectedIndex)
                        {
                            case 1:
                                c = c * 1000;
                                break;
                        }
                        break;
                }

                // Main calculations based on formulas
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        label4.Text = "Displacement:";
                        label6.Text = "Acceleration:";
                        double displacement = ((b + a) / 2) * c;
                        double acceleration = (b - a) / c;
                        displacement = Math.Round(displacement, d);
                        textBox4.Text = displacement.ToString();
                        acceleration = Math.Round(acceleration, d);
                        textBox5.Text = acceleration.ToString();
                        break;
                    case 1:
                        label4.Text = "Displacement:";
                        label6.Text = "Final Velocity:";
                        double final = a + (b * c);
                        double displacement1 = 0.5 * (final + a) * c;
                        displacement1 = Math.Round(displacement1, d);
                        final = Math.Round(final, d);
                        textBox4.Text = displacement1.ToString();
                        textBox5.Text = final.ToString();
                        break;
                    case 2:
                        label4.Text = "Displacement:";
                        label6.Text = "Time:";
                        double displacement2 = ((b * b) - (a * a)) / (2 * c);
                        double time = (b - a) / c;
                        displacement2 = Math.Round(displacement2, d);
                        time = Math.Round(time, d);
                        textBox4.Text = displacement2.ToString();
                        textBox5.Text = time.ToString();
                        break;
                    case 3:
                        label4.Text = "Displacement:";
                        label6.Text = "Inital Velocity:";
                        double inital = a - (b * c);
                        double displacement3 = 0.5 * (inital + a) * c;
                        inital = Math.Round(inital, d);
                        displacement3 = Math.Round(displacement3, d);
                        textBox4.Text = displacement3.ToString();
                        textBox5.Text = inital.ToString();
                        break;
                    case 4:
                        label4.Text = "Inital Velocity:";
                        label6.Text = "Acceleration:";
                        double inital1 = (2 * b) / c - a;
                        double acceleration1 = (a - inital1) / c;
                        inital1 = Math.Round(inital1, d);
                        acceleration1 = Math.Round(acceleration1, d);
                        textBox4.Text = inital1.ToString();
                        textBox5.Text = acceleration1.ToString();
                        break;
                    case 5: 
                        label4.Text = "Inital Velocity:";
                        label6.Text = "Final Velocity:";
                        double inital2 = (b / c) - (0.5 * a * c);
                        double final1 = inital2 + (a * c);
                        inital2 = Math.Round(inital2, d);
                        final1 = Math.Round(final1, d);
                        textBox4.Text = inital2.ToString();
                        textBox5.Text = final1.ToString();
                        break;
                    case 6:
                        label4.Text = "Inital Velocity:";
                        label6.Text = "Time:";
                        double inital3 = (a * a) - (2 * b * c);
                        double inital4 = Math.Sqrt(inital3);
                        double time1 = (a - inital4) / b;
                        inital4 = Math.Round(inital4, d);
                        time1 = Math.Round(time1, d);
                        textBox4.Text = inital4.ToString();
                        textBox5.Text = time1.ToString();
                        break;
                    case 7:
                        label4.Text = "Final Velocity:";
                        label6.Text = "Acceleration:";
                        double final2 = (b * 2) / c - a;
                        double acceleration2 = (final2 - a) / c;
                        acceleration2 = Math.Round(acceleration2, d);
                        final2 = Math.Round(final2, d);
                        textBox4.Text = final2.ToString();
                        textBox5.Text = acceleration2.ToString();
                        break;
                    case 8:
                        label4.Text = "Final Velocity:";
                        label6.Text = "Time:";
                        double final3 = Math.Sqrt((a * a) + (2 * b * c));
                        double time2 = (final3 - a) / b;
                        time2 = Math.Round(time2, d);
                        final3 = Math.Round(final3, d);
                        textBox4.Text = final3.ToString();
                        textBox5.Text = time2.ToString();
                        break;
                    case 9:
                        label4.Text = "Acceleration:";
                        label6.Text = "Time:";
                        double time3 = (c * 2) / (a + b);
                        double acceleration3 = (b - a) / time3;
                        acceleration3 = Math.Round(acceleration3, d);
                        time3 = Math.Round(time3, d);
                        textBox4.Text = acceleration3.ToString();
                        textBox5.Text = time3.ToString();
                        break;
                }
            }
            // Error message
            else
            {
                MessageBox.Show("Please enter real numbers", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adding Units (first unit box)
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("m/s");
                    comboBox2.Items.Add("km/s");
                    comboBox2.Items.Add("km/h");
                    break;
                case 5:
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("m/s ^ 2");
                    comboBox2.Items.Add("km/s ^ 2");
                    comboBox2.Items.Add("km/h ^ 2");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("m/s");
                    comboBox2.Items.Add("km/s");
                    comboBox2.Items.Add("km/h");
                    break;
            }

            // Adding Units (second unit box)
            switch (comboBox1.SelectedIndex)
            { 
                case 0:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s");
                    comboBox3.Items.Add("km/s");
                    comboBox3.Items.Add("km/h");
                    break;
                case 1:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s ^ 2");
                    comboBox3.Items.Add("km/s ^ 2");
                    comboBox3.Items.Add("km/h ^ 2");
                    break;
                case 2:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s");
                    comboBox3.Items.Add("km/s");
                    comboBox3.Items.Add("km/h");
                    break;
                case 3:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s ^ 2");
                    comboBox3.Items.Add("km/s ^ 2");
                    comboBox3.Items.Add("km/h ^ 2");
                    break;
                case 4:
                case 5:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("meters");
                    comboBox3.Items.Add("kilometers");
                    break;
                case 6:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s ^ 2");
                    comboBox3.Items.Add("km/s ^ 2");
                    comboBox3.Items.Add("km/h ^ 2");
                    break;
                case 7:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("meters");
                    comboBox3.Items.Add("kilometers");
                    break;
                case 8:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s ^ 2");
                    comboBox3.Items.Add("km/s ^ 2");
                    comboBox3.Items.Add("km/h ^ 2");
                    break;
                case 9:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("m/s");
                    comboBox3.Items.Add("km/s");
                    comboBox3.Items.Add("km/h");
                    break;
              
            }

            // Adding Units (third unit box)
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                case 1:
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("seconds");
                    comboBox4.Items.Add("minutes");
                    comboBox4.Items.Add("hours");
                    break;
                case 2:
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("m/s ^ 2");
                    comboBox4.Items.Add("km/s ^ 2");
                    comboBox4.Items.Add("km/h ^ 2");
                    break;
                case 3:
                case 4:
                case 5:
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("seconds");
                    comboBox4.Items.Add("minutes");
                    comboBox4.Items.Add("hours");
                    break;
                case 6:
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("meters");
                    comboBox4.Items.Add("kilometers");
                    break;
                case 7:
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("seconds");
                    comboBox4.Items.Add("minutes");
                    comboBox4.Items.Add("hours");
                    break;
                case 8:
                case 9:
                    comboBox4.Items.Clear();
                    comboBox4.Items.Add("meters");
                    comboBox4.Items.Add("kilometers");
                    break;
            }

            // Labels
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Initial Velocity";
                    label2.Text = "Final Velocity";
                    label3.Text = "Time";
                    break;
                case 1:
                    label1.Text = "Initial Velocity";
                    label2.Text = "Acceleration";
                    label3.Text = "Time";
                    break;
                case 2:
                    label1.Text = "Initial Velocity";
                    label2.Text = "Final Velocity";
                    label3.Text = "Acceleration";
                    break;
                case 3:
                    label1.Text = "Final Velocity";
                    label2.Text = "Acceleration";
                    label3.Text = "Time";
                    break;
                case 4:
                    label1.Text = "Final Velocity";
                    label2.Text = "Displacement";
                    label3.Text = "Time";
                    break;
                case 5:
                    label1.Text = "Acceleration";
                    label2.Text = "Displacement";
                    label3.Text = "Time";
                    break;
                case 6:
                    label1.Text = "Final Velocity";
                    label2.Text = "Acceleration";
                    label3.Text = "Displacement";
                    break;
                case 7:
                    label1.Text = "Initial Velocity";
                    label2.Text = "Displacement";
                    label3.Text = "Time";
                    break;
                case 8:
                    label1.Text = "Inital Velocity";
                    label2.Text = "Acceleration";
                    label3.Text = "Displacement";
                    break;
                case 9:
                    label1.Text = "Inital Velocity";
                    label2.Text = "Final Velocity";
                    label3.Text = "Displacement";
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}