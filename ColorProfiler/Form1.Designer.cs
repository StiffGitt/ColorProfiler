namespace ColorProfiler
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            outPictureBox = new PictureBox();
            inPictureBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            loadButton = new Button();
            convertButton = new Button();
            saveButton = new Button();
            grayoutButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            inGammaTextBox = new TextBox();
            label6 = new Label();
            inRedXTextBox = new TextBox();
            inRedYTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            inWhiteXTextBox = new TextBox();
            inWhiteYTextBox = new TextBox();
            label5 = new Label();
            inProfileComboBox = new ComboBox();
            label3 = new Label();
            inGreenXTextBox = new TextBox();
            inGreenYTextBox = new TextBox();
            label9 = new Label();
            inBlueXTextBox = new TextBox();
            inBlueYTextBox = new TextBox();
            label10 = new Label();
            outGammaTextBox = new TextBox();
            label11 = new Label();
            outRedXTextBox = new TextBox();
            outRedYTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            outWhiteXTextBox = new TextBox();
            outWhiteYTextBox = new TextBox();
            label16 = new Label();
            outProfileComboBox = new ComboBox();
            label17 = new Label();
            outGreenXTextBox = new TextBox();
            outGreenYTextBox = new TextBox();
            label18 = new Label();
            outBlueXTextBox = new TextBox();
            outBlueYTextBox = new TextBox();
            label19 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inPictureBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(984, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(outPictureBox, 1, 0);
            tableLayoutPanel2.Controls.Add(inPictureBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 171);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(978, 387);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // outPictureBox
            // 
            outPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            outPictureBox.Location = new Point(525, 9);
            outPictureBox.Name = "outPictureBox";
            outPictureBox.Size = new Size(450, 375);
            outPictureBox.TabIndex = 1;
            outPictureBox.TabStop = false;
            // 
            // inPictureBox
            // 
            inPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inPictureBox.Location = new Point(3, 9);
            inPictureBox.Name = "inPictureBox";
            inPictureBox.Size = new Size(450, 375);
            inPictureBox.TabIndex = 0;
            inPictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(loadButton);
            flowLayoutPanel1.Controls.Add(convertButton);
            flowLayoutPanel1.Controls.Add(saveButton);
            flowLayoutPanel1.Controls.Add(grayoutButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(978, 36);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // loadButton
            // 
            loadButton.AllowDrop = true;
            loadButton.Anchor = AnchorStyles.Left;
            loadButton.Location = new Point(3, 3);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(100, 22);
            loadButton.TabIndex = 2;
            loadButton.Text = "Load image";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(109, 3);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(100, 23);
            convertButton.TabIndex = 3;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(215, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save profiled";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // grayoutButton
            // 
            grayoutButton.Location = new Point(321, 3);
            grayoutButton.Name = "grayoutButton";
            grayoutButton.Size = new Size(100, 23);
            grayoutButton.TabIndex = 5;
            grayoutButton.Text = "Gray out";
            grayoutButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(inGammaTextBox);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(inRedXTextBox);
            flowLayoutPanel2.Controls.Add(inRedYTextBox);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(inWhiteXTextBox);
            flowLayoutPanel2.Controls.Add(inWhiteYTextBox);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(inProfileComboBox);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(inGreenXTextBox);
            flowLayoutPanel2.Controls.Add(inGreenYTextBox);
            flowLayoutPanel2.Controls.Add(label9);
            flowLayoutPanel2.Controls.Add(inBlueXTextBox);
            flowLayoutPanel2.Controls.Add(inBlueYTextBox);
            flowLayoutPanel2.Controls.Add(label10);
            flowLayoutPanel2.Controls.Add(outGammaTextBox);
            flowLayoutPanel2.Controls.Add(label11);
            flowLayoutPanel2.Controls.Add(outRedXTextBox);
            flowLayoutPanel2.Controls.Add(outRedYTextBox);
            flowLayoutPanel2.Controls.Add(label12);
            flowLayoutPanel2.Controls.Add(label13);
            flowLayoutPanel2.Controls.Add(label14);
            flowLayoutPanel2.Controls.Add(label15);
            flowLayoutPanel2.Controls.Add(outWhiteXTextBox);
            flowLayoutPanel2.Controls.Add(outWhiteYTextBox);
            flowLayoutPanel2.Controls.Add(label16);
            flowLayoutPanel2.Controls.Add(outProfileComboBox);
            flowLayoutPanel2.Controls.Add(label17);
            flowLayoutPanel2.Controls.Add(outGreenXTextBox);
            flowLayoutPanel2.Controls.Add(outGreenYTextBox);
            flowLayoutPanel2.Controls.Add(label18);
            flowLayoutPanel2.Controls.Add(outBlueXTextBox);
            flowLayoutPanel2.Controls.Add(outBlueYTextBox);
            flowLayoutPanel2.Controls.Add(label19);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 45);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(978, 120);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // inGammaTextBox
            // 
            inGammaTextBox.Location = new Point(3, 3);
            inGammaTextBox.Name = "inGammaTextBox";
            inGammaTextBox.Size = new Size(100, 23);
            inGammaTextBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 0);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 12;
            label6.Text = "x";
            // 
            // inRedXTextBox
            // 
            inRedXTextBox.Location = new Point(128, 3);
            inRedXTextBox.Name = "inRedXTextBox";
            inRedXTextBox.Size = new Size(44, 23);
            inRedXTextBox.TabIndex = 10;
            // 
            // inRedYTextBox
            // 
            inRedYTextBox.Location = new Point(178, 3);
            inRedYTextBox.Name = "inRedYTextBox";
            inRedYTextBox.Size = new Size(44, 23);
            inRedYTextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 0);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 13;
            label7.Text = "y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(247, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 9;
            label8.Text = "Red:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Gamma:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 0);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 7;
            label4.Text = "x";
            // 
            // inWhiteXTextBox
            // 
            inWhiteXTextBox.Location = new Point(366, 3);
            inWhiteXTextBox.Name = "inWhiteXTextBox";
            inWhiteXTextBox.Size = new Size(44, 23);
            inWhiteXTextBox.TabIndex = 5;
            // 
            // inWhiteYTextBox
            // 
            inWhiteYTextBox.Location = new Point(416, 3);
            inWhiteYTextBox.Name = "inWhiteYTextBox";
            inWhiteYTextBox.Size = new Size(44, 23);
            inWhiteYTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 0);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 8;
            label5.Text = "y";
            // 
            // inProfileComboBox
            // 
            inProfileComboBox.FormattingEnabled = true;
            inProfileComboBox.Location = new Point(485, 3);
            inProfileComboBox.Name = "inProfileComboBox";
            inProfileComboBox.Size = new Size(180, 23);
            inProfileComboBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(671, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "White:";
            // 
            // inGreenXTextBox
            // 
            inGreenXTextBox.Location = new Point(718, 3);
            inGreenXTextBox.Name = "inGreenXTextBox";
            inGreenXTextBox.Size = new Size(44, 23);
            inGreenXTextBox.TabIndex = 15;
            // 
            // inGreenYTextBox
            // 
            inGreenYTextBox.Location = new Point(768, 3);
            inGreenYTextBox.Name = "inGreenYTextBox";
            inGreenYTextBox.Size = new Size(44, 23);
            inGreenYTextBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(818, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 14;
            label9.Text = "Green:";
            // 
            // inBlueXTextBox
            // 
            inBlueXTextBox.Location = new Point(865, 3);
            inBlueXTextBox.Name = "inBlueXTextBox";
            inBlueXTextBox.Size = new Size(44, 23);
            inBlueXTextBox.TabIndex = 18;
            // 
            // inBlueYTextBox
            // 
            inBlueYTextBox.Location = new Point(915, 3);
            inBlueYTextBox.Name = "inBlueYTextBox";
            inBlueYTextBox.Size = new Size(44, 23);
            inBlueYTextBox.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 29);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 17;
            label10.Text = "Blue:";
            // 
            // outGammaTextBox
            // 
            outGammaTextBox.Location = new Point(42, 32);
            outGammaTextBox.Name = "outGammaTextBox";
            outGammaTextBox.Size = new Size(100, 23);
            outGammaTextBox.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 29);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 31;
            label11.Text = "x";
            // 
            // outRedXTextBox
            // 
            outRedXTextBox.Location = new Point(167, 32);
            outRedXTextBox.Name = "outRedXTextBox";
            outRedXTextBox.Size = new Size(44, 23);
            outRedXTextBox.TabIndex = 29;
            // 
            // outRedYTextBox
            // 
            outRedYTextBox.Location = new Point(217, 32);
            outRedYTextBox.Name = "outRedYTextBox";
            outRedYTextBox.Size = new Size(44, 23);
            outRedYTextBox.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(267, 29);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 32;
            label12.Text = "y";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(286, 29);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 28;
            label13.Text = "Red:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(322, 29);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 22;
            label14.Text = "Gamma:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(380, 29);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 26;
            label15.Text = "x";
            // 
            // outWhiteXTextBox
            // 
            outWhiteXTextBox.Location = new Point(399, 32);
            outWhiteXTextBox.Name = "outWhiteXTextBox";
            outWhiteXTextBox.Size = new Size(44, 23);
            outWhiteXTextBox.TabIndex = 24;
            // 
            // outWhiteYTextBox
            // 
            outWhiteYTextBox.Location = new Point(449, 32);
            outWhiteYTextBox.Name = "outWhiteYTextBox";
            outWhiteYTextBox.Size = new Size(44, 23);
            outWhiteYTextBox.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(499, 29);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 27;
            label16.Text = "y";
            // 
            // outProfileComboBox
            // 
            outProfileComboBox.FormattingEnabled = true;
            outProfileComboBox.Location = new Point(518, 32);
            outProfileComboBox.Name = "outProfileComboBox";
            outProfileComboBox.Size = new Size(180, 23);
            outProfileComboBox.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(704, 29);
            label17.Name = "label17";
            label17.Size = new Size(41, 15);
            label17.TabIndex = 23;
            label17.Text = "White:";
            // 
            // outGreenXTextBox
            // 
            outGreenXTextBox.Location = new Point(751, 32);
            outGreenXTextBox.Name = "outGreenXTextBox";
            outGreenXTextBox.Size = new Size(44, 23);
            outGreenXTextBox.TabIndex = 34;
            // 
            // outGreenYTextBox
            // 
            outGreenYTextBox.Location = new Point(801, 32);
            outGreenYTextBox.Name = "outGreenYTextBox";
            outGreenYTextBox.Size = new Size(44, 23);
            outGreenYTextBox.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(851, 29);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 33;
            label18.Text = "Green:";
            // 
            // outBlueXTextBox
            // 
            outBlueXTextBox.Location = new Point(898, 32);
            outBlueXTextBox.Name = "outBlueXTextBox";
            outBlueXTextBox.Size = new Size(44, 23);
            outBlueXTextBox.TabIndex = 37;
            // 
            // outBlueYTextBox
            // 
            outBlueYTextBox.Location = new Point(3, 61);
            outBlueYTextBox.Name = "outBlueYTextBox";
            outBlueYTextBox.Size = new Size(44, 23);
            outBlueYTextBox.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(53, 58);
            label19.Name = "label19";
            label19.Size = new Size(33, 15);
            label19.TabIndex = 36;
            label19.Text = "Blue:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Color profiler";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)outPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)inPictureBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox inPictureBox;
        private PictureBox outPictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button loadButton;
        private Button convertButton;
        private Button saveButton;
        private Button grayoutButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private ComboBox inProfileComboBox;
        private TextBox inGammaTextBox;
        private Label label2;
        private Label label1;
        private TextBox inWhiteXTextBox;
        private Label label3;
        private TextBox inWhiteYTextBox;
        private Label label4;
        private Label label6;
        private TextBox inRedXTextBox;
        private TextBox inRedYTextBox;
        private Label label7;
        private Label label8;
        private Label label5;
        private TextBox inGreenXTextBox;
        private TextBox inGreenYTextBox;
        private Label label9;
        private TextBox inBlueXTextBox;
        private TextBox inBlueYTextBox;
        private Label label10;
        private TextBox outGammaTextBox;
        private Label label11;
        private TextBox outRedXTextBox;
        private TextBox outRedYTextBox;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox outWhiteXTextBox;
        private TextBox outWhiteYTextBox;
        private Label label16;
        private ComboBox outProfileComboBox;
        private Label label17;
        private TextBox outGreenXTextBox;
        private TextBox outGreenYTextBox;
        private Label label18;
        private TextBox outBlueXTextBox;
        private TextBox outBlueYTextBox;
        private Label label19;
    }
}