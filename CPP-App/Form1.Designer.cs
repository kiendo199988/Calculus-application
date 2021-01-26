namespace CPP_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnParse = new System.Windows.Forms.Button();
            this.tbParse = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPlot = new System.Windows.Forms.PictureBox();
            this.pbOriginalFunction = new System.Windows.Forms.PictureBox();
            this.pbDerivative = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarForGraph = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbPurple = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbAnalyticalDerivativeFormula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIntegral = new System.Windows.Forms.TextBox();
            this.btnIntegral = new System.Windows.Forms.Button();
            this.btnSelectIntegral = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMcLaurinNewton = new System.Windows.Forms.Button();
            this.btnMcLaurinAnalytically = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewtonDerivative = new System.Windows.Forms.Button();
            this.btnAnalyticalDerivative = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbPink = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPlotNPoly2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbAddCoordinates = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbNPoly = new System.Windows.Forms.TextBox();
            this.btnGetPoly = new System.Windows.Forms.Button();
            this.btnPolySelect = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbInfixOriginalFunc = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDerivative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForGraph)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(1838, 3);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(59, 41);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbParse
            // 
            this.tbParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParse.Location = new System.Drawing.Point(0, 3);
            this.tbParse.Multiline = true;
            this.tbParse.Name = "tbParse";
            this.tbParse.Size = new System.Drawing.Size(1820, 41);
            this.tbParse.TabIndex = 1;
            this.tbParse.TextChanged += new System.EventHandler(this.tbParse_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbParse);
            this.panel1.Controls.Add(this.btnParse);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1900, 57);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parser";
            // 
            // pbPlot
            // 
            this.pbPlot.Location = new System.Drawing.Point(15, 230);
            this.pbPlot.Name = "pbPlot";
            this.pbPlot.Size = new System.Drawing.Size(1908, 423);
            this.pbPlot.TabIndex = 4;
            this.pbPlot.TabStop = false;
            this.pbPlot.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbPlot.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlot_Paint);
            // 
            // pbOriginalFunction
            // 
            this.pbOriginalFunction.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbOriginalFunction.Location = new System.Drawing.Point(15, 676);
            this.pbOriginalFunction.Name = "pbOriginalFunction";
            this.pbOriginalFunction.Size = new System.Drawing.Size(521, 306);
            this.pbOriginalFunction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalFunction.TabIndex = 5;
            this.pbOriginalFunction.TabStop = false;
            // 
            // pbDerivative
            // 
            this.pbDerivative.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbDerivative.InitialImage = null;
            this.pbDerivative.Location = new System.Drawing.Point(542, 676);
            this.pbDerivative.Name = "pbDerivative";
            this.pbDerivative.Size = new System.Drawing.Size(548, 306);
            this.pbDerivative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDerivative.TabIndex = 6;
            this.pbDerivative.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tree for functions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tree for derivatives";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Graph";
            // 
            // trackBarForGraph
            // 
            this.trackBarForGraph.Location = new System.Drawing.Point(75, 198);
            this.trackBarForGraph.Minimum = 1;
            this.trackBarForGraph.Name = "trackBarForGraph";
            this.trackBarForGraph.Size = new System.Drawing.Size(207, 56);
            this.trackBarForGraph.TabIndex = 2;
            this.trackBarForGraph.Value = 1;
            this.trackBarForGraph.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1639, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Analytical derivative";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1585, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Newton\'s difference quotient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1657, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Original Function";
            // 
            // tbRed
            // 
            this.tbRed.Enabled = false;
            this.tbRed.Location = new System.Drawing.Point(1778, 138);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(131, 22);
            this.tbRed.TabIndex = 13;
            // 
            // tbPurple
            // 
            this.tbPurple.Enabled = false;
            this.tbPurple.Location = new System.Drawing.Point(1778, 168);
            this.tbPurple.Name = "tbPurple";
            this.tbPurple.Size = new System.Drawing.Size(131, 22);
            this.tbPurple.TabIndex = 14;
            // 
            // tbGreen
            // 
            this.tbGreen.Enabled = false;
            this.tbGreen.Location = new System.Drawing.Point(1778, 200);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(131, 22);
            this.tbGreen.TabIndex = 15;
            // 
            // tbAnalyticalDerivativeFormula
            // 
            this.tbAnalyticalDerivativeFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnalyticalDerivativeFormula.Location = new System.Drawing.Point(12, 163);
            this.tbAnalyticalDerivativeFormula.Multiline = true;
            this.tbAnalyticalDerivativeFormula.Name = "tbAnalyticalDerivativeFormula";
            this.tbAnalyticalDerivativeFormula.Size = new System.Drawing.Size(1000, 36);
            this.tbAnalyticalDerivativeFormula.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Analytical Derivative Formula";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblLower);
            this.panel2.Controls.Add(this.lblUpper);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbIntegral);
            this.panel2.Controls.Add(this.btnIntegral);
            this.panel2.Controls.Add(this.btnSelectIntegral);
            this.panel2.Location = new System.Drawing.Point(1217, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 259);
            this.panel2.TabIndex = 20;
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(104, 163);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(16, 17);
            this.lblLower.TabIndex = 24;
            this.lblLower.Text = "?";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(105, 135);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(16, 17);
            this.lblUpper.TabIndex = 23;
            this.lblUpper.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Lower Bound:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Upper Bound:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Result";
            // 
            // tbIntegral
            // 
            this.tbIntegral.Location = new System.Drawing.Point(6, 214);
            this.tbIntegral.Name = "tbIntegral";
            this.tbIntegral.Size = new System.Drawing.Size(120, 22);
            this.tbIntegral.TabIndex = 3;
            // 
            // btnIntegral
            // 
            this.btnIntegral.Location = new System.Drawing.Point(32, 66);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Size = new System.Drawing.Size(81, 50);
            this.btnIntegral.TabIndex = 2;
            this.btnIntegral.Text = "Riemann Integral";
            this.btnIntegral.UseVisualStyleBackColor = true;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // btnSelectIntegral
            // 
            this.btnSelectIntegral.Location = new System.Drawing.Point(32, 16);
            this.btnSelectIntegral.Name = "btnSelectIntegral";
            this.btnSelectIntegral.Size = new System.Drawing.Size(81, 44);
            this.btnSelectIntegral.TabIndex = 1;
            this.btnSelectIntegral.Text = "Select";
            this.btnSelectIntegral.UseVisualStyleBackColor = true;
            this.btnSelectIntegral.Click += new System.EventHandler(this.btnSelectIntegral_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1211, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Integrals";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnMcLaurinNewton);
            this.panel3.Controls.Add(this.btnMcLaurinAnalytically);
            this.panel3.Location = new System.Drawing.Point(1096, 851);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 131);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnMcLaurinNewton
            // 
            this.btnMcLaurinNewton.Location = new System.Drawing.Point(10, 65);
            this.btnMcLaurinNewton.Name = "btnMcLaurinNewton";
            this.btnMcLaurinNewton.Size = new System.Drawing.Size(95, 50);
            this.btnMcLaurinNewton.TabIndex = 1;
            this.btnMcLaurinNewton.Text = "Using Newton\'s";
            this.btnMcLaurinNewton.UseVisualStyleBackColor = true;
            this.btnMcLaurinNewton.Click += new System.EventHandler(this.btnMcLaurinNewton_Click);
            // 
            // btnMcLaurinAnalytically
            // 
            this.btnMcLaurinAnalytically.Location = new System.Drawing.Point(10, 15);
            this.btnMcLaurinAnalytically.Name = "btnMcLaurinAnalytically";
            this.btnMcLaurinAnalytically.Size = new System.Drawing.Size(95, 44);
            this.btnMcLaurinAnalytically.TabIndex = 0;
            this.btnMcLaurinAnalytically.Text = "Analytically";
            this.btnMcLaurinAnalytically.UseVisualStyleBackColor = true;
            this.btnMcLaurinAnalytically.Click += new System.EventHandler(this.btnMcLaurinAnalytically_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1093, 831);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "MacLaurin Series";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnNewtonDerivative);
            this.panel4.Controls.Add(this.btnAnalyticalDerivative);
            this.panel4.Location = new System.Drawing.Point(1096, 676);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 131);
            this.panel4.TabIndex = 24;
            // 
            // btnNewtonDerivative
            // 
            this.btnNewtonDerivative.Location = new System.Drawing.Point(10, 69);
            this.btnNewtonDerivative.Name = "btnNewtonDerivative";
            this.btnNewtonDerivative.Size = new System.Drawing.Size(93, 44);
            this.btnNewtonDerivative.TabIndex = 1;
            this.btnNewtonDerivative.Text = "Newton\'s ";
            this.btnNewtonDerivative.UseVisualStyleBackColor = true;
            this.btnNewtonDerivative.Click += new System.EventHandler(this.btnNewtonDerivative_Click);
            // 
            // btnAnalyticalDerivative
            // 
            this.btnAnalyticalDerivative.Location = new System.Drawing.Point(10, 16);
            this.btnAnalyticalDerivative.Name = "btnAnalyticalDerivative";
            this.btnAnalyticalDerivative.Size = new System.Drawing.Size(93, 44);
            this.btnAnalyticalDerivative.TabIndex = 0;
            this.btnAnalyticalDerivative.Text = "Analytical";
            this.btnAnalyticalDerivative.UseVisualStyleBackColor = true;
            this.btnAnalyticalDerivative.Click += new System.EventHandler(this.btnAnalyticalDerivative_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1093, 656);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Derivative";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1241, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "MacLaurin Series (Analytical)";
            // 
            // tbPink
            // 
            this.tbPink.Enabled = false;
            this.tbPink.Location = new System.Drawing.Point(1439, 166);
            this.tbPink.Name = "tbPink";
            this.tbPink.Size = new System.Drawing.Size(131, 22);
            this.tbPink.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btnPlotNPoly2);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.tbAddCoordinates);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.tbNPoly);
            this.panel5.Controls.Add(this.btnGetPoly);
            this.panel5.Controls.Add(this.btnPolySelect);
            this.panel5.Location = new System.Drawing.Point(1372, 676);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 259);
            this.panel5.TabIndex = 28;
            // 
            // btnPlotNPoly2
            // 
            this.btnPlotNPoly2.Location = new System.Drawing.Point(129, 207);
            this.btnPlotNPoly2.Name = "btnPlotNPoly2";
            this.btnPlotNPoly2.Size = new System.Drawing.Size(118, 36);
            this.btnPlotNPoly2.TabIndex = 41;
            this.btnPlotNPoly2.Text = "n-polynomial";
            this.btnPlotNPoly2.UseVisualStyleBackColor = true;
            this.btnPlotNPoly2.Click += new System.EventHandler(this.btnPlotNPoly2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(374, 17);
            this.label21.TabIndex = 39;
            this.label21.Text = "Enter coordinates (-3,-1;-2,0;-1,-1;0,2 (i.e. 3 coordinates))";
            // 
            // tbAddCoordinates
            // 
            this.tbAddCoordinates.Location = new System.Drawing.Point(17, 175);
            this.tbAddCoordinates.Name = "tbAddCoordinates";
            this.tbAddCoordinates.Size = new System.Drawing.Size(499, 22);
            this.tbAddCoordinates.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(158, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "ASCII Notation";
            // 
            // tbNPoly
            // 
            this.tbNPoly.Location = new System.Drawing.Point(161, 38);
            this.tbNPoly.Multiline = true;
            this.tbNPoly.Name = "tbNPoly";
            this.tbNPoly.Size = new System.Drawing.Size(355, 93);
            this.tbNPoly.TabIndex = 35;
            // 
            // btnGetPoly
            // 
            this.btnGetPoly.Location = new System.Drawing.Point(17, 95);
            this.btnGetPoly.Name = "btnGetPoly";
            this.btnGetPoly.Size = new System.Drawing.Size(125, 36);
            this.btnGetPoly.TabIndex = 31;
            this.btnGetPoly.Text = "n-polynomial";
            this.btnGetPoly.UseVisualStyleBackColor = true;
            this.btnGetPoly.Click += new System.EventHandler(this.btnGetPoly_Click);
            // 
            // btnPolySelect
            // 
            this.btnPolySelect.Location = new System.Drawing.Point(17, 38);
            this.btnPolySelect.Name = "btnPolySelect";
            this.btnPolySelect.Size = new System.Drawing.Size(125, 31);
            this.btnPolySelect.TabIndex = 30;
            this.btnPolySelect.Text = "Select";
            this.btnPolySelect.UseVisualStyleBackColor = true;
            this.btnPolySelect.Click += new System.EventHandler(this.btnPolySelect_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1372, 656);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "N-Polynomial";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1439, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 22);
            this.textBox2.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1244, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "MacLaurin Series (Newton\'s)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Infix Notation";
            // 
            // tbInfixOriginalFunc
            // 
            this.tbInfixOriginalFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfixOriginalFunc.Location = new System.Drawing.Point(12, 107);
            this.tbInfixOriginalFunc.Multiline = true;
            this.tbInfixOriginalFunc.Name = "tbInfixOriginalFunc";
            this.tbInfixOriginalFunc.Size = new System.Drawing.Size(1000, 36);
            this.tbInfixOriginalFunc.TabIndex = 33;
            // 
            // tbBlue
            // 
            this.tbBlue.Enabled = false;
            this.tbBlue.Location = new System.Drawing.Point(1439, 133);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(131, 22);
            this.tbBlue.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1342, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 17);
            this.label20.TabIndex = 35;
            this.label20.Text = "N-Polynomial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbInfixOriginalFunc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tbPink);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAnalyticalDerivativeFormula);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbPurple);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarForGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDerivative);
            this.Controls.Add(this.pbOriginalFunction);
            this.Controls.Add(this.pbPlot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kien\'s CPP App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDerivative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForGraph)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbParse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlot;
        private System.Windows.Forms.PictureBox pbOriginalFunction;
        private System.Windows.Forms.PictureBox pbDerivative;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarForGraph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbPurple;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbAnalyticalDerivativeFormula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIntegral;
        private System.Windows.Forms.Button btnIntegral;
        private System.Windows.Forms.Button btnSelectIntegral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMcLaurinNewton;
        private System.Windows.Forms.Button btnMcLaurinAnalytically;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewtonDerivative;
        private System.Windows.Forms.Button btnAnalyticalDerivative;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbPink;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGetPoly;
        private System.Windows.Forms.Button btnPolySelect;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbInfixOriginalFunc;
        private System.Windows.Forms.TextBox tbNPoly;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbAddCoordinates;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlotNPoly2;
    }
}

