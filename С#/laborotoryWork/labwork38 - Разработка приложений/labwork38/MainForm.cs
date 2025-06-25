namespace labwork38
{
    public partial class MainForm : Form
    {
        private float _score = 0;
        private int _clickValue = 1;
        private float _passiveValue = 0;
        private int _energyValue = 100;
        private int _energyTimeValue = 5;

        private int _clickCost = 10;
        private float _energyCost = 50;
        private float _energyTimeCost = 10;

        private int _kIMCount = 0;
        private int _rarePizzaCount = 0;
        private int _bathCount = 0;

        private int _counter = 0;
        private int _counterTIME = 0;
        private bool _activeCrit = false;
        private bool _activeInfin = false;
        private bool _activeSkin = false;
        private bool _activeCapibara = false;
        private bool _activeRangeKIM = false;
        private bool _win = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            _score = 0;
            _clickValue = 1;
            _passiveValue = 0;
            _energyValue = 100;
            _energyTimeValue = 5;

            _clickCost = 10;
            _energyCost = 50;
            _energyTimeCost = 10;

            _kIMCount = 0;
            _rarePizzaCount = 0;
            _bathCount = 0;

            _counter = 0;
            _counterTIME = 0;
            _activeCrit = false;
            _activeInfin = false;
            _activeSkin = false;
            _activeCapibara = false;
            _activeRangeKIM = false;
            _win = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _score = Properties.Settings.Default.score;
            _clickValue = Properties.Settings.Default.clickValue;
            _passiveValue = Properties.Settings.Default.passiveValue;
            _energyValue = Properties.Settings.Default.energyValue;
            _energyTimeValue = Properties.Settings.Default.energyTimeValue;

            _clickCost = Properties.Settings.Default.clickCost;
            _energyCost = Properties.Settings.Default.energyCost;
            _energyTimeCost = Properties.Settings.Default.energyTimeCost;

            _kIMCount = Properties.Settings.Default.kIMCount;
            _rarePizzaCount = Properties.Settings.Default.rarePizzaCount;
            _bathCount = Properties.Settings.Default.bathCount;

            _activeCrit = Properties.Settings.Default.activeCrit;
            _activeInfin = Properties.Settings.Default.activeInfin;
            _activeSkin = Properties.Settings.Default.activeSkin;
            _activeCapibara = Properties.Settings.Default.activeCapibara;
            _activeRangeKIM = Properties.Settings.Default.activeRangeKIM;

            TimingUPStatusLabel.Text = "";
            KIMCountLabel.Text = "";
            RarePizzaCountLabel.Text = "";
            BathCountLabel.Text = "";

            PassiveTimer.Start();
        }

        private void ClickPictureBox_Click(object sender, EventArgs e)
        {
            if (Random.Shared.Next(0, 10) == 5 && _activeCrit)
            {
                _score += _clickValue * 5;
            }
            else
            {
                _score += _clickValue;
            }

            if (_activeRangeKIM)
            {
                _score += _clickValue * 10;
            }
            else if (_activeCapibara)
            {
                _score += _clickValue * 2;
                EnergyCostProgressBar.Value -= _clickValue;
            }
            else
            {
                EnergyCostProgressBar.Value -= _clickValue;
            }
        }

        private void UpToolsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (UpToolsComboBox.SelectedIndex)
            {
                case 0:
                    BuyButton.Enabled = true;
                    CostUpradeValueLabel.Text = $"Стоимость: {_clickCost}";
                    break;
                case 1:
                    BuyButton.Enabled = true;
                    CostUpradeValueLabel.Text = $"Стоимость: {_energyCost}";
                    break;
                case 2:
                    BuyButton.Enabled = true;
                    CostUpradeValueLabel.Text = $"Стоимость: {_energyTimeCost}";
                    break;
                case 3:
                    BuyButton.Enabled = true;
                    CostUpradeValueLabel.Text = "Стоимость: 5";
                    break;
                case 4:
                    BuyButton.Enabled = true;
                    CostUpradeValueLabel.Text = $"Стоимость: 50";
                    break;
                case 5:
                    BuyButton.Enabled = true;
                    CostUpradeValueLabel.Text = $"Стоимость: 500";
                    break;
                case 6:
                    if (!_activeCrit)
                    {
                        BuyButton.Enabled = true;
                        CostUpradeValueLabel.Text = $"Стоимость: 500";
                    }
                    else
                    {
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
                case 7:
                    if (!_activeInfin)
                    {
                        BuyButton.Enabled = true;
                        CostUpradeValueLabel.Text = $"Стоимость: 1000";
                    }
                    else
                    {
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
                case 8:
                    if (!_activeCapibara)
                    {
                        BuyButton.Enabled = true;
                        CostUpradeValueLabel.Text = $"Стоимость: 120";
                    }
                    else
                    {
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
                case 9:
                    if (!_activeRangeKIM)
                    {
                        BuyButton.Enabled = true;
                        CostUpradeValueLabel.Text = $"Стоимость: 322";
                    }
                    else
                    {
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
                case 10:
                    if (!_activeSkin)
                    {
                        BuyButton.Enabled = true;
                        CostUpradeValueLabel.Text = $"Стоимость: 2500";
                    }
                    else
                    {
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
            }
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            switch (UpToolsComboBox.SelectedIndex)
            {
                case 0:
                    if (_score >= _clickCost)
                    {
                        _clickValue += 1;
                        _score -= _clickCost;
                        _clickCost += 5;
                    }
                    CostUpradeValueLabel.Text = $"Стоимость: {_clickCost}";
                    break;
                case 1:
                    if (_score >= _energyCost)
                    {
                        _energyValue += 50;
                        EnergyCostProgressBar.Maximum = _energyValue;
                        EnergyCostProgressBar.Value = _energyValue;
                        _score -= _energyCost;
                        _energyCost += 50;
                    }
                    CostUpradeValueLabel.Text = $"Стоимость: {_energyCost}";
                    break;
                case 2:
                    if (_score >= _energyTimeCost)
                    {
                        _energyTimeValue += 10;
                        _score -= _energyTimeCost;
                        _energyTimeCost += 10;
                    }
                    CostUpradeValueLabel.Text = $"Стоимость: {_energyTimeCost}";
                    break;
                case 3:
                    if (_score >= 5)
                    {
                        _score -= 5;
                        _passiveValue += 1;
                        _kIMCount += 1;
                    }
                    break;
                case 4:
                    if (_score >= 50)
                    {
                        _score -= 50;
                        _passiveValue += 10;
                        _rarePizzaCount += 1;
                    }
                    break;
                case 5:
                    if (_score >= 500)
                    {
                        _score -= 500;
                        _passiveValue += 100;
                        _bathCount += 1;
                    }
                    break;
                case 6:
                    if (_score >= 500 && !_activeCrit)
                    {
                        _score -= 500;
                        _activeCrit = true;
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
                case 7:
                    if (_score >= 1000 && !_activeInfin)
                    {
                        _score -= 1000;
                        _activeInfin = true;
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                    }
                    break;
                case 8:
                    if (_score >= 120)
                    {
                        _score -= 120;
                        _activeCapibara = true;
                        ActivCapibaraPictureBox.Visible = true;
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                        TimingUPTimer.Start();
                    }
                    break;
                case 9:
                    if (_score >= 322)
                    {
                        _score -= 322;
                        _activeRangeKIM = true;
                        ActivRangeKIMPictureBox.Visible = true;
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                        TimingUPTimer.Start();
                    }
                    break;
                case 10:
                    if (_score >= 2500 && !_activeSkin)
                    {
                        _score -= 2500;
                        _activeSkin = true;
                        BuyButton.Enabled = false;
                        CostUpradeValueLabel.Text = "Куплено";
                        this.BackColor = Color.Goldenrod;
                        MainStatusStrip.BackColor = Color.Gold;
                    }
                    break;
            }
        }

        private void PassiveTimer_Tick(object sender, EventArgs e)
        {
            _counter++;
            ScoreLabel.Text = $"{_score}";
            ClickValueStatusLabel.Text = $"КЛИК: {_clickValue}";
            PasesiveStatusLabel.Text = $"ПАССИВ: {_passiveValue}";

            if (_score >= 5000 && !_win)
            {
                _win = true;
                ActivSkinPictureBox.Visible = true;
                MessageBox.Show("ПРЕМИЯ КИМ ГОДА 2024");
            }

            if (_counter % 100 == 0)
            {
                _score += _passiveValue;
                _counter = 0;
            }
            if (_kIMCount > 0)
            {
                KIMCountLabel.Text = $"{_kIMCount}";
            }
            if (_rarePizzaCount > 0)
            {
                RarePizzaCountLabel.Text = $"{_rarePizzaCount}";
            }
            if (_bathCount > 0)
            {
                BathCountLabel.Text = $"{_bathCount}";
            }

            #region pictures
            if (_activeCrit)
            {
                ActivCritPictureBox.Visible = true;
            }
            else
            {
                ActivCritPictureBox.Visible = false;
            }

            if (_activeInfin)
            {
                ActivInfinPictureBox.Visible = true;
            }
            else
            {
                ActivInfinPictureBox.Visible = false;
            }

            #endregion

            #region lvl
            if (_score > 0 && _score < 50)
            {
                ClickPictureBox.Image = KIMImageList.Images[0];
            }
            if (_score >= 50 && _score < 200)
            {
                ClickPictureBox.Image = KIMImageList.Images[1];
            }
            if (_score >= 200 && _score < 500)
            {
                ClickPictureBox.Image = KIMImageList.Images[2];
            }
            if (_score >= 500 && _score < 1000)
            {
                ClickPictureBox.Image = KIMImageList.Images[3];
            }
            if (_score >= 1000 && _score < 5000)
            {
                ClickPictureBox.Image = KIMImageList.Images[4];
            }
            if (_score >= 5000)
            {
                ClickPictureBox.Image = KIMImageList.Images[5];
            }
            #endregion

            #region energy
            if (EnergyCostProgressBar.Value < _clickValue)
                ClickPictureBox.Enabled = false;
            if (EnergyCostProgressBar.Value >= _clickValue)
                ClickPictureBox.Enabled = true;


            if (_activeInfin)
            {
                EnergyLabel.Text = "неограниченно";
                EnergyCostProgressBar.Value = EnergyCostProgressBar.Maximum;
            }
            else
            {
                EnergyLabel.Text = $"{EnergyCostProgressBar.Value}/{_energyValue}";
            }

            if (EnergyCostProgressBar.Value < EnergyCostProgressBar.Maximum && (EnergyCostProgressBar.Value + _energyTimeValue) <= EnergyCostProgressBar.Maximum && _counter % 50 == 0)
            {
                EnergyCostProgressBar.Value += _energyTimeValue;
                _counter = 0;
            }
            #endregion
        }
        private void TimingUPTimer_Tick(object sender, EventArgs e)
        {
            _counterTIME++;

            if (_activeCapibara)
                TimingUPStatusLabel.Text = $"ВРЕМЯ: {30 - _counterTIME}";
            if (_activeCapibara && _counterTIME % 30 == 0)
            {
                BuyButton.Enabled = true;
                CostUpradeValueLabel.Text = $"Стоимость: 120";
                _activeCapibara = false;
                ActivCapibaraPictureBox.Visible = false;
                TimingUPTimer.Stop();
                TimingUPStatusLabel.Text = "";
                _counterTIME = 0;
            }

            if (_activeRangeKIM)
                TimingUPStatusLabel.Text = $"ВРЕМЯ: {10 - _counterTIME}";
            if (_activeRangeKIM && _counterTIME % 10 == 0)
            {
                BuyButton.Enabled = true;
                CostUpradeValueLabel.Text = $"Стоимость: 322";
                _activeRangeKIM = false;
                ActivRangeKIMPictureBox.Visible = false;
                TimingUPTimer.Stop();
                TimingUPStatusLabel.Text = "";
                _counterTIME = 0;
            }
        }

        private void QuestionPictureBox_Click(object sender, EventArgs e)
        {
            InfForm form = new InfForm();
            form.ShowDialog();
        }

        private void ResetStatusLabel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены?", "Стереть прогресс", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Reset();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.score = _score;
            Properties.Settings.Default.clickValue = _clickValue;
            Properties.Settings.Default.passiveValue = _passiveValue;
            Properties.Settings.Default.energyValue = _energyValue;
            Properties.Settings.Default.energyTimeValue = _energyTimeValue;

            Properties.Settings.Default.clickCost = _clickCost;
            Properties.Settings.Default.energyCost = _energyCost;
            Properties.Settings.Default.energyTimeCost = _energyTimeCost;

            Properties.Settings.Default.kIMCount = _kIMCount;
            Properties.Settings.Default.rarePizzaCount = _rarePizzaCount;
            Properties.Settings.Default.bathCount = _bathCount;

            Properties.Settings.Default.activeCrit = _activeCrit;
            Properties.Settings.Default.activeInfin = _activeInfin;
            Properties.Settings.Default.activeSkin = _activeSkin;
            Properties.Settings.Default.activeCapibara = _activeCapibara;
            Properties.Settings.Default.activeRangeKIM = _activeRangeKIM;

            Properties.Settings.Default.Save();
            PassiveTimer.Stop();
        }
    }
}
