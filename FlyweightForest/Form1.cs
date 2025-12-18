namespace FlyweightForest
{
    public partial class Form1 : Form
    {
        private readonly Forest forest = new();
        private readonly TreeFactory factory = new();
        private readonly Random random = new();
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private ITreeDecorator currentDecorator;

        private bool running;
        public Form1()
        {
            InitializeComponent();
            cbTypes.Items.AddRange(new[] { "Дуб", "Береза", "Клен", "Сосна", "Ялина" });
            cbTypes.SelectedIndex = 0;

            nudCount.Minimum = 1;
            nudCount.Maximum = 1000;
            nudCount.Value = 50;

            cbDecor.Items.AddRange(new[]
{
                "Без декоратора",
                "Сніг",
                "Плоди",
                "Гірлянда"
            });
            cbDecor.SelectedIndex = 0;

            timer.Interval = 120;
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            running = !running;
            timer.Enabled = running;
            btnStart.Text = running ? "Стоп" : "Старт";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = cbTypes.SelectedItem.ToString();

            Color crown = name switch
            {
                "Дуб" => Color.Green,
                "Береза" => Color.LightGreen,
                "Клен" => Color.ForestGreen,
                "Сосна" => Color.DarkGreen,
                "Ялина" => Color.SeaGreen,
                _ => Color.Green
            };

            Color trunk = name == "Береза"
                ? Color.WhiteSmoke
                : Color.SaddleBrown;

            TreeType type = factory.Get(name, crown, trunk);

            for (int i = 0; i < nudCount.Value; i++)
            {
                int x = random.Next(20, panelForest.Width - 20);
                int y = random.Next(panelForest.Height / 2, panelForest.Height - 20);

                forest.Add(new Tree(x, y, type));
            }

            string decor = cbDecor.SelectedItem.ToString();

            currentDecorator = null;

            if (decor == "Плоди")
                currentDecorator = new FruitDecorator();
            else if (decor == "Сніг")
                currentDecorator = new SnowDecorator();
            else if (decor == "Гірлянда")
                currentDecorator = new GarlandDecorator();

            panelForest.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            forest.Clear();
            panelForest.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            forest.Grow();
            panelForest.Invalidate();
        }

        private void panelForest_Paint(object sender, PaintEventArgs e)
        {
            forest.Draw(e.Graphics);

            if (currentDecorator != null)
            {
                foreach (var tree in forest.Trees)
                    currentDecorator.Draw(e.Graphics, tree);
            }
        }
    }
}
