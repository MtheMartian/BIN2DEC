using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyOwn
{
    
    public partial class Bin2Dec : Form
    {
        private bool mouseDown; //True or false for: Is MB1 is being pressed?
        private Point lastLocation; //Gets the coordinates on a (x,y) 2d plane
       

        public Bin2Dec()
        {
            
            InitializeComponent();
            Textusr.Visible = false; //Makes the Textusr text box invisible on startup.
            
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bin2Dec_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void usrInput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter up to 8 binary digits...");
            Textusr.Visible = true;
        }

        private void Bin2Dec_MouseDown (object sender, MouseEventArgs e)
            
        { 
            if (e.Clicks == 1) mouseDown = true;
           
            lastLocation = e.Location; //Get the location (x,y) of the cursor when MB1 is pressed.
        }

        private void Bin2Dec_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) 
            {
                this.Location = new Point( //.this is the Bin2Dec program (So, it's getting the programs location)
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //Get the new program window + cursor coordinates and updates.
                this.Update(); //Updates the programs location.
            }

        }

        private void Bin2Dec_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //When the user lets go of MB1 it becomes fl
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            
            string input = Textusr.Text;
            if (input == string.Empty)
            {
                MessageBox.Show("Please enter something by clicking on #");
            }
            else
            {
                // string nDecimal = string.Join("", input); Concatenates the characters together to create a single string
                MessageBox.Show("Converting to decimal... " + Convert.ToInt32(input, 2));
            }
           
        }

        private void Textusr_TextChanged_1(object sender, EventArgs e)
        {
            int maxLength = 8; 
            string input = Textusr.Text;
            
            if (input.Length > maxLength)
            {
                Textusr.Clear();
                MessageBox.Show("8 digits maximum");
            }

            //List<char> chars = new List<char>();
            //chars.AddRange(input); Adds the inputted string in input to the list as characters.
            
            foreach (char c in input) //For each character in input check if it's a '0' or a '1'.
            if (c != '0' && c != '1')
            {
                Textusr.ResetText(); //Resets the text box
                MessageBox.Show("Only 1s and 0s");
                
            }
            

                
        }
    }
}
