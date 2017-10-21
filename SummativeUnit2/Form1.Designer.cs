namespace SummativeUnit2
{
    partial class cashRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberSundaeLabel = new System.Windows.Forms.Label();
            this.numberFlurrieLabel = new System.Windows.Forms.Label();
            this.numberMilkshakeLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.milkshakeTextBox = new System.Windows.Forms.TextBox();
            this.flurrieTextBox = new System.Windows.Forms.TextBox();
            this.sundaeTextBox = new System.Windows.Forms.TextBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.subTotalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.line1Label = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedTextBox = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeDueLabel = new System.Windows.Forms.Label();
            this.changeDueOutputLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.line2Label = new System.Windows.Forms.Label();
            this.receiptOutputLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.sundeaPriceFlavourLabel = new System.Windows.Forms.Label();
            this.flurriesPriceFlavourLabel = new System.Windows.Forms.Label();
            this.milkshakePriceFlavourLabel = new System.Windows.Forms.Label();
            this.conePriceFlavourLabel = new System.Windows.Forms.Label();
            this.line3Label = new System.Windows.Forms.Label();
            this.numberConeLabel = new System.Windows.Forms.Label();
            this.coneTextBox = new System.Windows.Forms.TextBox();
            this.flavoursLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.HotPink;
            this.titleLabel.Location = new System.Drawing.Point(1, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(669, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Soft Serve Parlour";
            // 
            // numberSundaeLabel
            // 
            this.numberSundaeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.numberSundaeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSundaeLabel.ForeColor = System.Drawing.Color.HotPink;
            this.numberSundaeLabel.Location = new System.Drawing.Point(0, 241);
            this.numberSundaeLabel.Name = "numberSundaeLabel";
            this.numberSundaeLabel.Size = new System.Drawing.Size(177, 28);
            this.numberSundaeLabel.TabIndex = 1;
            this.numberSundaeLabel.Text = "Number of Sundae(s)";
            // 
            // numberFlurrieLabel
            // 
            this.numberFlurrieLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFlurrieLabel.ForeColor = System.Drawing.Color.HotPink;
            this.numberFlurrieLabel.Location = new System.Drawing.Point(1, 288);
            this.numberFlurrieLabel.Name = "numberFlurrieLabel";
            this.numberFlurrieLabel.Size = new System.Drawing.Size(177, 27);
            this.numberFlurrieLabel.TabIndex = 2;
            this.numberFlurrieLabel.Text = "Number of Flurrie(s)";
            // 
            // numberMilkshakeLabel
            // 
            this.numberMilkshakeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMilkshakeLabel.ForeColor = System.Drawing.Color.HotPink;
            this.numberMilkshakeLabel.Location = new System.Drawing.Point(1, 331);
            this.numberMilkshakeLabel.Name = "numberMilkshakeLabel";
            this.numberMilkshakeLabel.Size = new System.Drawing.Size(212, 27);
            this.numberMilkshakeLabel.TabIndex = 3;
            this.numberMilkshakeLabel.Text = "Number of Milkshake(s) ";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.Color.HotPink;
            this.subTotalLabel.Location = new System.Drawing.Point(0, 459);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(85, 30);
            this.subTotalLabel.TabIndex = 4;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.HotPink;
            this.taxLabel.Location = new System.Drawing.Point(1, 499);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(36, 19);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.HotPink;
            this.totalLabel.Location = new System.Drawing.Point(1, 545);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(54, 20);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total ";
            // 
            // milkshakeTextBox
            // 
            this.milkshakeTextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkshakeTextBox.Location = new System.Drawing.Point(203, 328);
            this.milkshakeTextBox.Name = "milkshakeTextBox";
            this.milkshakeTextBox.Size = new System.Drawing.Size(75, 27);
            this.milkshakeTextBox.TabIndex = 3;
            // 
            // flurrieTextBox
            // 
            this.flurrieTextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flurrieTextBox.Location = new System.Drawing.Point(203, 285);
            this.flurrieTextBox.Name = "flurrieTextBox";
            this.flurrieTextBox.Size = new System.Drawing.Size(75, 27);
            this.flurrieTextBox.TabIndex = 2;
            // 
            // sundaeTextBox
            // 
            this.sundaeTextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundaeTextBox.Location = new System.Drawing.Point(203, 242);
            this.sundaeTextBox.Name = "sundaeTextBox";
            this.sundaeTextBox.Size = new System.Drawing.Size(75, 27);
            this.sundaeTextBox.TabIndex = 1;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.calculateTotalButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.ForeColor = System.Drawing.Color.HotPink;
            this.calculateTotalButton.Location = new System.Drawing.Point(4, 414);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(275, 32);
            this.calculateTotalButton.TabIndex = 5;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // subTotalOutputLabel
            // 
            this.subTotalOutputLabel.BackColor = System.Drawing.Color.White;
            this.subTotalOutputLabel.Location = new System.Drawing.Point(203, 462);
            this.subTotalOutputLabel.Name = "subTotalOutputLabel";
            this.subTotalOutputLabel.Size = new System.Drawing.Size(75, 27);
            this.subTotalOutputLabel.TabIndex = 11;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BackColor = System.Drawing.Color.White;
            this.taxOutputLabel.Location = new System.Drawing.Point(203, 503);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(75, 27);
            this.taxOutputLabel.TabIndex = 12;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BackColor = System.Drawing.Color.White;
            this.totalOutputLabel.Location = new System.Drawing.Point(203, 545);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(75, 27);
            this.totalOutputLabel.TabIndex = 13;
            // 
            // line1Label
            // 
            this.line1Label.BackColor = System.Drawing.Color.PaleTurquoise;
            this.line1Label.Location = new System.Drawing.Point(12, 590);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(275, 10);
            this.line1Label.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tenderedLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.HotPink;
            this.tenderedLabel.Location = new System.Drawing.Point(1, 614);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(96, 28);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedTextBox
            // 
            this.tenderedTextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedTextBox.Location = new System.Drawing.Point(203, 615);
            this.tenderedTextBox.Name = "tenderedTextBox";
            this.tenderedTextBox.Size = new System.Drawing.Size(75, 27);
            this.tenderedTextBox.TabIndex = 6;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.calculateChangeButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.Color.HotPink;
            this.calculateChangeButton.Location = new System.Drawing.Point(4, 657);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(275, 32);
            this.calculateChangeButton.TabIndex = 7;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeDueLabel
            // 
            this.changeDueLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDueLabel.ForeColor = System.Drawing.Color.HotPink;
            this.changeDueLabel.Location = new System.Drawing.Point(1, 707);
            this.changeDueLabel.Name = "changeDueLabel";
            this.changeDueLabel.Size = new System.Drawing.Size(109, 27);
            this.changeDueLabel.TabIndex = 18;
            this.changeDueLabel.Text = "Change Due";
            // 
            // changeDueOutputLabel
            // 
            this.changeDueOutputLabel.BackColor = System.Drawing.Color.White;
            this.changeDueOutputLabel.Location = new System.Drawing.Point(203, 707);
            this.changeDueOutputLabel.Name = "changeDueOutputLabel";
            this.changeDueOutputLabel.Size = new System.Drawing.Size(75, 27);
            this.changeDueOutputLabel.TabIndex = 19;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.printReceiptButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.ForeColor = System.Drawing.Color.HotPink;
            this.printReceiptButton.Location = new System.Drawing.Point(5, 754);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(275, 32);
            this.printReceiptButton.TabIndex = 8;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // line2Label
            // 
            this.line2Label.BackColor = System.Drawing.Color.PaleTurquoise;
            this.line2Label.Location = new System.Drawing.Point(306, 241);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(10, 545);
            this.line2Label.TabIndex = 22;
            // 
            // receiptOutputLabel
            // 
            this.receiptOutputLabel.BackColor = System.Drawing.Color.White;
            this.receiptOutputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutputLabel.Location = new System.Drawing.Point(336, 241);
            this.receiptOutputLabel.Name = "receiptOutputLabel";
            this.receiptOutputLabel.Size = new System.Drawing.Size(275, 493);
            this.receiptOutputLabel.TabIndex = 23;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.newOrderButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.HotPink;
            this.newOrderButton.Location = new System.Drawing.Point(339, 754);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(275, 32);
            this.newOrderButton.TabIndex = 9;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // pricesLabel
            // 
            this.pricesLabel.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesLabel.ForeColor = System.Drawing.Color.HotPink;
            this.pricesLabel.Location = new System.Drawing.Point(-2, 56);
            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(94, 29);
            this.pricesLabel.TabIndex = 25;
            this.pricesLabel.Text = "Prices";
            // 
            // sundeaPriceFlavourLabel
            // 
            this.sundeaPriceFlavourLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundeaPriceFlavourLabel.ForeColor = System.Drawing.Color.HotPink;
            this.sundeaPriceFlavourLabel.Location = new System.Drawing.Point(1, 97);
            this.sundeaPriceFlavourLabel.Name = "sundeaPriceFlavourLabel";
            this.sundeaPriceFlavourLabel.Size = new System.Drawing.Size(539, 25);
            this.sundeaPriceFlavourLabel.TabIndex = 26;
            this.sundeaPriceFlavourLabel.Text = "Sundaes                      $6.49        -   -   -        Blueberry,  Cherry,  H" +
    "ot Fudge";
            // 
            // flurriesPriceFlavourLabel
            // 
            this.flurriesPriceFlavourLabel.AutoSize = true;
            this.flurriesPriceFlavourLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flurriesPriceFlavourLabel.ForeColor = System.Drawing.Color.HotPink;
            this.flurriesPriceFlavourLabel.Location = new System.Drawing.Point(0, 122);
            this.flurriesPriceFlavourLabel.Name = "flurriesPriceFlavourLabel";
            this.flurriesPriceFlavourLabel.Size = new System.Drawing.Size(544, 19);
            this.flurriesPriceFlavourLabel.TabIndex = 27;
            this.flurriesPriceFlavourLabel.Text = "Flurries                       $4.99        -   -   -        Oreo,  Cookie Dough," +
    "  Brownie";
            // 
            // milkshakePriceFlavourLabel
            // 
            this.milkshakePriceFlavourLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkshakePriceFlavourLabel.ForeColor = System.Drawing.Color.HotPink;
            this.milkshakePriceFlavourLabel.Location = new System.Drawing.Point(0, 152);
            this.milkshakePriceFlavourLabel.Name = "milkshakePriceFlavourLabel";
            this.milkshakePriceFlavourLabel.Size = new System.Drawing.Size(544, 26);
            this.milkshakePriceFlavourLabel.TabIndex = 28;
            this.milkshakePriceFlavourLabel.Text = "Milkshakes                $2.99        -   -   -        Chocolate,  Vanilla,  Str" +
    "awberry";
            // 
            // conePriceFlavourLabel
            // 
            this.conePriceFlavourLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conePriceFlavourLabel.ForeColor = System.Drawing.Color.HotPink;
            this.conePriceFlavourLabel.Location = new System.Drawing.Point(1, 178);
            this.conePriceFlavourLabel.Name = "conePriceFlavourLabel";
            this.conePriceFlavourLabel.Size = new System.Drawing.Size(554, 26);
            this.conePriceFlavourLabel.TabIndex = 29;
            this.conePriceFlavourLabel.Text = "Cones                          $1.99        -   -   -        Chocolate,  Vanilla," +
    "  Twist";
            // 
            // line3Label
            // 
            this.line3Label.BackColor = System.Drawing.Color.PaleTurquoise;
            this.line3Label.Location = new System.Drawing.Point(12, 215);
            this.line3Label.Name = "line3Label";
            this.line3Label.Size = new System.Drawing.Size(590, 10);
            this.line3Label.TabIndex = 30;
            // 
            // numberConeLabel
            // 
            this.numberConeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberConeLabel.ForeColor = System.Drawing.Color.HotPink;
            this.numberConeLabel.Location = new System.Drawing.Point(1, 369);
            this.numberConeLabel.Name = "numberConeLabel";
            this.numberConeLabel.Size = new System.Drawing.Size(177, 20);
            this.numberConeLabel.TabIndex = 31;
            this.numberConeLabel.Text = "Number of Cone(s)";
            // 
            // coneTextBox
            // 
            this.coneTextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coneTextBox.Location = new System.Drawing.Point(203, 369);
            this.coneTextBox.Name = "coneTextBox";
            this.coneTextBox.Size = new System.Drawing.Size(75, 27);
            this.coneTextBox.TabIndex = 4;
            // 
            // flavoursLabel
            // 
            this.flavoursLabel.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flavoursLabel.ForeColor = System.Drawing.Color.HotPink;
            this.flavoursLabel.Location = new System.Drawing.Point(293, 56);
            this.flavoursLabel.Name = "flavoursLabel";
            this.flavoursLabel.Size = new System.Drawing.Size(131, 29);
            this.flavoursLabel.TabIndex = 33;
            this.flavoursLabel.Text = "Flavours";
            // 
            // cashRegister
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(622, 793);
            this.Controls.Add(this.flavoursLabel);
            this.Controls.Add(this.coneTextBox);
            this.Controls.Add(this.numberConeLabel);
            this.Controls.Add(this.line3Label);
            this.Controls.Add(this.conePriceFlavourLabel);
            this.Controls.Add(this.milkshakePriceFlavourLabel);
            this.Controls.Add(this.flurriesPriceFlavourLabel);
            this.Controls.Add(this.sundeaPriceFlavourLabel);
            this.Controls.Add(this.pricesLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptOutputLabel);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeDueOutputLabel);
            this.Controls.Add(this.changeDueLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedTextBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.subTotalOutputLabel);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.sundaeTextBox);
            this.Controls.Add(this.flurrieTextBox);
            this.Controls.Add(this.milkshakeTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.numberMilkshakeLabel);
            this.Controls.Add(this.numberFlurrieLabel);
            this.Controls.Add(this.numberSundaeLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numberSundaeLabel;
        private System.Windows.Forms.Label numberFlurrieLabel;
        private System.Windows.Forms.Label numberMilkshakeLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox milkshakeTextBox;
        private System.Windows.Forms.TextBox flurrieTextBox;
        private System.Windows.Forms.TextBox sundaeTextBox;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Label subTotalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedTextBox;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeDueLabel;
        private System.Windows.Forms.Label changeDueOutputLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.Label receiptOutputLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label pricesLabel;
        private System.Windows.Forms.Label sundeaPriceFlavourLabel;
        private System.Windows.Forms.Label flurriesPriceFlavourLabel;
        private System.Windows.Forms.Label milkshakePriceFlavourLabel;
        private System.Windows.Forms.Label conePriceFlavourLabel;
        private System.Windows.Forms.Label line3Label;
        private System.Windows.Forms.Label numberConeLabel;
        private System.Windows.Forms.TextBox coneTextBox;
        private System.Windows.Forms.Label flavoursLabel;
    }
}

