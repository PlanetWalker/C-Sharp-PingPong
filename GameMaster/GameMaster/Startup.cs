using GameMaster.games;

namespace GameMaster
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Game1_1().Show();
        }
    }
}