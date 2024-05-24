using ArenaGameEngine;

namespace ArenaGameWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddItemToListBoxKnight(string s)
        {
            ListBoxKnight.Items.Add(s);
        }

        public void AddItemToListBoxRogue(string s)
        {
            ListBoxRogue.Items.Add(s);
        }
        public void AddItemToListBoxAlchemist(string s)
        {
            listBox1.Items.Add(s);
        }
        public void AddItemToListBoxInquisitor(string s)
        {
            listBox2.Items.Add(s);
        }


        private void bNewGame_Click(object sender, EventArgs e)
        {
            Knight knight = new Knight("Sir John");
            Alchemist alchemist = new Alchemist("Ivan");
            Inquisitor inquisitor = new Inquisitor("Petar");
            Rogue rogue = new Rogue("Slim Shady");
            Arena arena = new Arena(knight, rogue, alchemist, inquisitor);
            arena.EventListener = new WinFormsGameEventListener(this);
            Hero winner = arena.Battle();

            MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
        }

        private void ListBoxRogue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxKnight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
