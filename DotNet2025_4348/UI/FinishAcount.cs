namespace UI
{
    public partial class FinishAcount : Form
    {
        Form father;
        private BIApi.IBI _bi = BIApi.Factory.Get();
        BO.Order order;
        //
        //private Button playButton;
        //private SoundPlayer player;
        //

        public FinishAcount(BO.Order order, Form form)
        {
            InitializeComponent();
            this.father = form;
            this.order = order;
            this.FormClosed += new FormClosedEventHandler(Finish_FormClosed);
            double sum = _bi.order.orderTermination(this.order);
            this.sum.Text = $"לתשלום: {sum} ש\"ח";
            _bi.order.BuyProduct(this.order);
            //תוספת
            //playButton = new Button();
            //playButton.Text = "נגן שיר";
            //playButton.Click += PlayButton_Click;
            //Controls.Add(playButton);

            //player = new SoundPlayer("C:\\Users\\user2\\Documents\\a.WAV");
        }
        //
        //private void PlayButton_Click(object sender, EventArgs e)
        //{
        //    player.Play();
        //}
        //
        private void Finish_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.father.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameProd nameProd = new NameProd(order.Products);
            nameProd.Show();
        }
    }
}
