using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Ejer17Cash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Cliente
        {
            public string Name { get; set; }
            public decimal Cash { get; set; }

            public Cliente(string name, decimal cash)
            {
                Name = name;
                Cash = cash;
            }
        }
        Cliente joe = new Cliente("Joe", 100);
        Cliente bob = new Cliente("Bob", 50);
        Cliente bank = new Cliente("Bank", 100);
        public void ActualizaForm()
        {
            lblJoeCash.Text = joe.Name + " has " + joe.Cash + "$.";
            lblBobCash.Text = bob.Name + " has " + bob.Cash + "$.";
            lblBankCash.Text = bank.Name +" has " + bank.Cash + "$.";
        }
        private void BankruptBank()
        {
            MessageBox.Show("The bank is bankrupt");
            return;
        }

            private void button3_Click(object sender, EventArgs e)
        {
            if (bank.Cash >= 10)
            {
                bob.Cash += 10;
                bank.Cash -= 10;
                ActualizaForm();
            }
            else
            {
                BankruptBank();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bank.Cash >= 10)
            {
                joe.Cash += 10;
                bank.Cash -= 10;
                ActualizaForm();
            }
            else
            {
                BankruptBank();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                bob.Cash += 10;
                joe.Cash -= 10;
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("Not enough money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 10)
            {
                joe.Cash += 10;
                bob.Cash -= 10;
                ActualizaForm();
            }
            else
            {
                MessageBox.Show("Not enough money");
            }
        }
    }
}