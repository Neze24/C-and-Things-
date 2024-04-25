using System;
using System.Windows.Forms;

namespace MyWindowApp
{
    public class MyForm : Form
    {
        public MyForm()
        {
            // Set properties of the form
            Text = "My Window";
            Width = 400;
            Height = 300;

            // Create controls
            Button button = new Button();
            button.Text = "Click me!";
            button.Click += Button_Click;

            // Add controls to the form
            Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        // Entry point of the application
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }
}