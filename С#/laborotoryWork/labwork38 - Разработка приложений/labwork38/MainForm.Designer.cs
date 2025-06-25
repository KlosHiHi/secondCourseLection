namespace labwork38
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ScoreLabel = new Label();
            CostUpradeValueLabel = new Label();
            UpToolsComboBox = new ComboBox();
            MainStatusStrip = new StatusStrip();
            ClickValueStatusLabel = new ToolStripStatusLabel();
            PasesiveStatusLabel = new ToolStripStatusLabel();
            TimingUPStatusLabel = new ToolStripStatusLabel();
            ResetStatusLabel = new ToolStripStatusLabel();
            BuyButton = new Button();
            EnergyCostProgressBar = new ProgressBar();
            PassiveTimer = new System.Windows.Forms.Timer(components);
            TimingUPTimer = new System.Windows.Forms.Timer(components);
            EnergyLabel = new Label();
            KIMImageList = new ImageList(components);
            ClickPictureBox = new PictureBox();
            QuestionPictureBox = new PictureBox();
            ActivCritPictureBox = new PictureBox();
            ActivInfinPictureBox = new PictureBox();
            ActivCapibaraPictureBox = new PictureBox();
            ActivRangeKIMPictureBox = new PictureBox();
            ActivSkinPictureBox = new PictureBox();
            PizzaPictureBox = new PictureBox();
            KIMPictureBox = new PictureBox();
            RarePizzaPictureBox = new PictureBox();
            BathPictureBox = new PictureBox();
            KIMCountLabel = new Label();
            RarePizzaCountLabel = new Label();
            BathCountLabel = new Label();
            MainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClickPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuestionPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActivCritPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActivInfinPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActivCapibaraPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActivRangeKIMPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActivSkinPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PizzaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KIMPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RarePizzaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BathPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScoreLabel.ForeColor = SystemColors.ButtonFace;
            ScoreLabel.Location = new Point(91, 6);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(34, 41);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.Text = "0";
            // 
            // CostUpradeValueLabel
            // 
            CostUpradeValueLabel.AutoSize = true;
            CostUpradeValueLabel.ForeColor = SystemColors.ButtonFace;
            CostUpradeValueLabel.Location = new Point(399, 47);
            CostUpradeValueLabel.Name = "CostUpradeValueLabel";
            CostUpradeValueLabel.Size = new Size(103, 23);
            CostUpradeValueLabel.TabIndex = 4;
            CostUpradeValueLabel.Text = "Стоимость: ";
            // 
            // UpToolsComboBox
            // 
            UpToolsComboBox.FormattingEnabled = true;
            UpToolsComboBox.Items.AddRange(new object[] { "Количество очков за клик", "Энергия", "Восстановление энергии", "Ким Горбунов", "Столовская пицца", "Баня в Кушово", "Критический клик", "Бесконечная энергия", "Помощь Геры (30 сек)", "Ярость Кима (10 сек)", "Модный стиль интерфейса" });
            UpToolsComboBox.Location = new Point(399, 15);
            UpToolsComboBox.Name = "UpToolsComboBox";
            UpToolsComboBox.Size = new Size(293, 29);
            UpToolsComboBox.TabIndex = 5;
            UpToolsComboBox.SelectedIndexChanged += UpToolsComboBox_SelectedIndexChanged;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.BackColor = Color.SlateBlue;
            MainStatusStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { ClickValueStatusLabel, PasesiveStatusLabel, TimingUPStatusLabel, ResetStatusLabel });
            MainStatusStrip.Location = new Point(0, 469);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(782, 34);
            MainStatusStrip.TabIndex = 6;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // ClickValueStatusLabel
            // 
            ClickValueStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClickValueStatusLabel.ForeColor = Color.White;
            ClickValueStatusLabel.Name = "ClickValueStatusLabel";
            ClickValueStatusLabel.Size = new Size(68, 28);
            ClickValueStatusLabel.Text = "КЛИК:";
            // 
            // PasesiveStatusLabel
            // 
            PasesiveStatusLabel.ForeColor = Color.White;
            PasesiveStatusLabel.Name = "PasesiveStatusLabel";
            PasesiveStatusLabel.Size = new Size(98, 28);
            PasesiveStatusLabel.Text = "ПАССИВ: ";
            // 
            // TimingUPStatusLabel
            // 
            TimingUPStatusLabel.ForeColor = Color.White;
            TimingUPStatusLabel.Name = "TimingUPStatusLabel";
            TimingUPStatusLabel.Size = new Size(78, 28);
            TimingUPStatusLabel.Text = "ВРЕМЯ:";
            // 
            // ResetStatusLabel
            // 
            ResetStatusLabel.ForeColor = Color.Red;
            ResetStatusLabel.Name = "ResetStatusLabel";
            ResetStatusLabel.Size = new Size(39, 28);
            ResetStatusLabel.Text = "✖️";
            ResetStatusLabel.Click += ResetStatusLabel_Click;
            // 
            // BuyButton
            // 
            BuyButton.BackColor = Color.Azure;
            BuyButton.FlatStyle = FlatStyle.Flat;
            BuyButton.Location = new Point(698, 7);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(75, 43);
            BuyButton.TabIndex = 7;
            BuyButton.Text = "Купить";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Click += BuyButton_Click;
            // 
            // EnergyCostProgressBar
            // 
            EnergyCostProgressBar.BackColor = Color.LightSteelBlue;
            EnergyCostProgressBar.ForeColor = SystemColors.Desktop;
            EnergyCostProgressBar.Location = new Point(24, 420);
            EnergyCostProgressBar.Name = "EnergyCostProgressBar";
            EnergyCostProgressBar.Size = new Size(350, 23);
            EnergyCostProgressBar.Step = 1;
            EnergyCostProgressBar.TabIndex = 8;
            EnergyCostProgressBar.Value = 100;
            // 
            // PassiveTimer
            // 
            PassiveTimer.Interval = 10;
            PassiveTimer.Tick += PassiveTimer_Tick;
            // 
            // TimingUPTimer
            // 
            TimingUPTimer.Interval = 1000;
            TimingUPTimer.Tick += TimingUPTimer_Tick;
            // 
            // EnergyLabel
            // 
            EnergyLabel.AutoSize = true;
            EnergyLabel.BackColor = Color.WhiteSmoke;
            EnergyLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EnergyLabel.Location = new Point(24, 394);
            EnergyLabel.Name = "EnergyLabel";
            EnergyLabel.Size = new Size(71, 23);
            EnergyLabel.TabIndex = 9;
            EnergyLabel.Text = "100/100";
            // 
            // KIMImageList
            // 
            KIMImageList.ColorDepth = ColorDepth.Depth32Bit;
            KIMImageList.ImageStream = (ImageListStreamer)resources.GetObject("KIMImageList.ImageStream");
            KIMImageList.TransparentColor = Color.Transparent;
            KIMImageList.Images.SetKeyName(0, "lvl1.png");
            KIMImageList.Images.SetKeyName(1, "lvl2.png");
            KIMImageList.Images.SetKeyName(2, "lvl3.png");
            KIMImageList.Images.SetKeyName(3, "lvl4.png");
            KIMImageList.Images.SetKeyName(4, "lvl5.png");
            KIMImageList.Images.SetKeyName(5, "lvl6.png");
            // 
            // ClickPictureBox
            // 
            ClickPictureBox.Image = (Image)resources.GetObject("ClickPictureBox.Image");
            ClickPictureBox.Location = new Point(24, 41);
            ClickPictureBox.MaximumSize = new Size(350, 350);
            ClickPictureBox.MinimumSize = new Size(350, 350);
            ClickPictureBox.Name = "ClickPictureBox";
            ClickPictureBox.Size = new Size(350, 350);
            ClickPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ClickPictureBox.TabIndex = 10;
            ClickPictureBox.TabStop = false;
            ClickPictureBox.Click += ClickPictureBox_Click;
            // 
            // QuestionPictureBox
            // 
            QuestionPictureBox.BackColor = Color.Transparent;
            QuestionPictureBox.Image = (Image)resources.GetObject("QuestionPictureBox.Image");
            QuestionPictureBox.Location = new Point(368, 15);
            QuestionPictureBox.Name = "QuestionPictureBox";
            QuestionPictureBox.Size = new Size(25, 29);
            QuestionPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            QuestionPictureBox.TabIndex = 11;
            QuestionPictureBox.TabStop = false;
            QuestionPictureBox.Click += QuestionPictureBox_Click;
            // 
            // ActivCritPictureBox
            // 
            ActivCritPictureBox.Enabled = false;
            ActivCritPictureBox.Image = (Image)resources.GetObject("ActivCritPictureBox.Image");
            ActivCritPictureBox.Location = new Point(406, 85);
            ActivCritPictureBox.Name = "ActivCritPictureBox";
            ActivCritPictureBox.Size = new Size(96, 96);
            ActivCritPictureBox.TabIndex = 12;
            ActivCritPictureBox.TabStop = false;
            ActivCritPictureBox.Visible = false;
            // 
            // ActivInfinPictureBox
            // 
            ActivInfinPictureBox.Enabled = false;
            ActivInfinPictureBox.Image = (Image)resources.GetObject("ActivInfinPictureBox.Image");
            ActivInfinPictureBox.Location = new Point(541, 85);
            ActivInfinPictureBox.Name = "ActivInfinPictureBox";
            ActivInfinPictureBox.Size = new Size(96, 96);
            ActivInfinPictureBox.TabIndex = 13;
            ActivInfinPictureBox.TabStop = false;
            ActivInfinPictureBox.Visible = false;
            // 
            // ActivCapibaraPictureBox
            // 
            ActivCapibaraPictureBox.Enabled = false;
            ActivCapibaraPictureBox.Image = (Image)resources.GetObject("ActivCapibaraPictureBox.Image");
            ActivCapibaraPictureBox.Location = new Point(474, 187);
            ActivCapibaraPictureBox.Name = "ActivCapibaraPictureBox";
            ActivCapibaraPictureBox.Size = new Size(96, 96);
            ActivCapibaraPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ActivCapibaraPictureBox.TabIndex = 14;
            ActivCapibaraPictureBox.TabStop = false;
            ActivCapibaraPictureBox.Visible = false;
            // 
            // ActivRangeKIMPictureBox
            // 
            ActivRangeKIMPictureBox.Enabled = false;
            ActivRangeKIMPictureBox.Image = (Image)resources.GetObject("ActivRangeKIMPictureBox.Image");
            ActivRangeKIMPictureBox.Location = new Point(609, 187);
            ActivRangeKIMPictureBox.Name = "ActivRangeKIMPictureBox";
            ActivRangeKIMPictureBox.Size = new Size(96, 96);
            ActivRangeKIMPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ActivRangeKIMPictureBox.TabIndex = 15;
            ActivRangeKIMPictureBox.TabStop = false;
            ActivRangeKIMPictureBox.Visible = false;
            // 
            // ActivSkinPictureBox
            // 
            ActivSkinPictureBox.Enabled = false;
            ActivSkinPictureBox.Image = (Image)resources.GetObject("ActivSkinPictureBox.Image");
            ActivSkinPictureBox.Location = new Point(674, 85);
            ActivSkinPictureBox.Name = "ActivSkinPictureBox";
            ActivSkinPictureBox.Size = new Size(96, 96);
            ActivSkinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ActivSkinPictureBox.TabIndex = 16;
            ActivSkinPictureBox.TabStop = false;
            ActivSkinPictureBox.Visible = false;
            // 
            // PizzaPictureBox
            // 
            PizzaPictureBox.Image = (Image)resources.GetObject("PizzaPictureBox.Image");
            PizzaPictureBox.Location = new Point(24, 10);
            PizzaPictureBox.Name = "PizzaPictureBox";
            PizzaPictureBox.Size = new Size(71, 34);
            PizzaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PizzaPictureBox.TabIndex = 17;
            PizzaPictureBox.TabStop = false;
            // 
            // KIMPictureBox
            // 
            KIMPictureBox.Image = (Image)resources.GetObject("KIMPictureBox.Image");
            KIMPictureBox.Location = new Point(380, 361);
            KIMPictureBox.Name = "KIMPictureBox";
            KIMPictureBox.Size = new Size(30, 30);
            KIMPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            KIMPictureBox.TabIndex = 18;
            KIMPictureBox.TabStop = false;
            // 
            // RarePizzaPictureBox
            // 
            RarePizzaPictureBox.Image = (Image)resources.GetObject("RarePizzaPictureBox.Image");
            RarePizzaPictureBox.Location = new Point(380, 325);
            RarePizzaPictureBox.Name = "RarePizzaPictureBox";
            RarePizzaPictureBox.Size = new Size(30, 30);
            RarePizzaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            RarePizzaPictureBox.TabIndex = 19;
            RarePizzaPictureBox.TabStop = false;
            // 
            // BathPictureBox
            // 
            BathPictureBox.Image = (Image)resources.GetObject("BathPictureBox.Image");
            BathPictureBox.Location = new Point(380, 289);
            BathPictureBox.Name = "BathPictureBox";
            BathPictureBox.Size = new Size(30, 30);
            BathPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BathPictureBox.TabIndex = 20;
            BathPictureBox.TabStop = false;
            // 
            // KIMCountLabel
            // 
            KIMCountLabel.AutoSize = true;
            KIMCountLabel.Font = new Font("Segoe UI", 10.8F);
            KIMCountLabel.ForeColor = Color.White;
            KIMCountLabel.Location = new Point(416, 364);
            KIMCountLabel.Name = "KIMCountLabel";
            KIMCountLabel.Size = new Size(22, 25);
            KIMCountLabel.TabIndex = 21;
            KIMCountLabel.Text = "0";
            KIMCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RarePizzaCountLabel
            // 
            RarePizzaCountLabel.AutoSize = true;
            RarePizzaCountLabel.Font = new Font("Segoe UI", 10.8F);
            RarePizzaCountLabel.ForeColor = Color.White;
            RarePizzaCountLabel.Location = new Point(416, 328);
            RarePizzaCountLabel.Name = "RarePizzaCountLabel";
            RarePizzaCountLabel.Size = new Size(22, 25);
            RarePizzaCountLabel.TabIndex = 22;
            RarePizzaCountLabel.Text = "0";
            RarePizzaCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BathCountLabel
            // 
            BathCountLabel.AutoSize = true;
            BathCountLabel.Font = new Font("Segoe UI", 10.8F);
            BathCountLabel.ForeColor = Color.White;
            BathCountLabel.Location = new Point(416, 292);
            BathCountLabel.Name = "BathCountLabel";
            BathCountLabel.Size = new Size(22, 25);
            BathCountLabel.TabIndex = 23;
            BathCountLabel.Text = "0";
            BathCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(782, 503);
            Controls.Add(BathCountLabel);
            Controls.Add(RarePizzaCountLabel);
            Controls.Add(KIMCountLabel);
            Controls.Add(BathPictureBox);
            Controls.Add(RarePizzaPictureBox);
            Controls.Add(KIMPictureBox);
            Controls.Add(PizzaPictureBox);
            Controls.Add(ActivSkinPictureBox);
            Controls.Add(ActivRangeKIMPictureBox);
            Controls.Add(ActivCapibaraPictureBox);
            Controls.Add(ActivInfinPictureBox);
            Controls.Add(ActivCritPictureBox);
            Controls.Add(QuestionPictureBox);
            Controls.Add(ClickPictureBox);
            Controls.Add(EnergyLabel);
            Controls.Add(EnergyCostProgressBar);
            Controls.Add(BuyButton);
            Controls.Add(MainStatusStrip);
            Controls.Add(UpToolsComboBox);
            Controls.Add(CostUpradeValueLabel);
            Controls.Add(ScoreLabel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 550);
            MinimumSize = new Size(800, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kim Combat";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClickPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuestionPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActivCritPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActivInfinPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActivCapibaraPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActivRangeKIMPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActivSkinPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PizzaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)KIMPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RarePizzaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BathPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ScoreLabel;
        private Label CostUpradeValueLabel;
        private ComboBox UpToolsComboBox;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel ClickValueStatusLabel;
        private Button BuyButton;
        private ToolStripStatusLabel TimingUPStatusLabel;
        private ProgressBar EnergyCostProgressBar;
        private System.Windows.Forms.Timer PassiveTimer;
        private System.Windows.Forms.Timer TimingUPTimer;
        private Label EnergyLabel;
        private ImageList KIMImageList;
        private PictureBox ClickPictureBox;
        private ToolStripStatusLabel PasesiveStatusLabel;
        private PictureBox QuestionPictureBox;
        private PictureBox ActivCritPictureBox;
        private PictureBox ActivInfinPictureBox;
        private PictureBox ActivCapibaraPictureBox;
        private PictureBox ActivRangeKIMPictureBox;
        private PictureBox ActivSkinPictureBox;
        private PictureBox PizzaPictureBox;
        private PictureBox KIMPictureBox;
        private PictureBox RarePizzaPictureBox;
        private PictureBox BathPictureBox;
        private Label KIMCountLabel;
        private Label RarePizzaCountLabel;
        private Label BathCountLabel;
        private ToolStripStatusLabel ResetStatusLabel;
    }
}
