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
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
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
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
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
            tableLayoutPanel2.Location = new Point(3, 212);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(978, 346);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // outPictureBox
            // 
            outPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            outPictureBox.Location = new Point(525, 3);
            outPictureBox.Name = "outPictureBox";
            outPictureBox.Size = new Size(450, 340);
            outPictureBox.TabIndex = 1;
            outPictureBox.TabStop = false;
            // 
            // inPictureBox
            // 
            inPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inPictureBox.Location = new Point(3, 3);
            inPictureBox.Name = "inPictureBox";
            inPictureBox.Size = new Size(450, 340);
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
            flowLayoutPanel1.Size = new Size(978, 46);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 55);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(978, 151);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inGammaTextBox);
            groupBox1.Controls.Add(inProfileComboBox);
            groupBox1.Controls.Add(inRedXTextBox);
            groupBox1.Controls.Add(inRedYTextBox);
            groupBox1.Controls.Add(inWhiteYTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(inGreenXTextBox);
            groupBox1.Controls.Add(inGreenYTextBox);
            groupBox1.Controls.Add(inBlueXTextBox);
            groupBox1.Controls.Add(inBlueYTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(inWhiteXTextBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(outBlueYTextBox);
            groupBox2.Controls.Add(outBlueXTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(outGreenYTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(outGreenXTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(outProfileComboBox);
            groupBox2.Controls.Add(outWhiteYTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(outWhiteXTextBox);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(outRedYTextBox);
            groupBox2.Controls.Add(outRedXTextBox);
            groupBox2.Controls.Add(outGammaTextBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(492, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // inGammaTextBox
            // 
            inGammaTextBox.Location = new Point(64, 52);
            inGammaTextBox.Name = "inGammaTextBox";
            inGammaTextBox.Size = new Size(100, 23);
            inGammaTextBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 81);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 51;
            label6.Text = "x";
            // 
            // inRedXTextBox
            // 
            inRedXTextBox.Location = new Point(259, 32);
            inRedXTextBox.Name = "inRedXTextBox";
            inRedXTextBox.Size = new Size(44, 23);
            inRedXTextBox.TabIndex = 49;
            // 
            // inRedYTextBox
            // 
            inRedYTextBox.Location = new Point(309, 32);
            inRedYTextBox.Name = "inRedYTextBox";
            inRedYTextBox.Size = new Size(44, 23);
            inRedYTextBox.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 81);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 52;
            label7.Text = "y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(223, 35);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 48;
            label8.Text = "Red:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 42;
            label2.Text = "Gamma:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 14);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 46;
            label4.Text = "x";
            // 
            // inWhiteXTextBox
            // 
            inWhiteXTextBox.Location = new Point(64, 92);
            inWhiteXTextBox.Name = "inWhiteXTextBox";
            inWhiteXTextBox.Size = new Size(44, 23);
            inWhiteXTextBox.TabIndex = 44;
            // 
            // inWhiteYTextBox
            // 
            inWhiteYTextBox.Location = new Point(120, 92);
            inWhiteYTextBox.Name = "inWhiteYTextBox";
            inWhiteYTextBox.Size = new Size(44, 23);
            inWhiteYTextBox.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 14);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 47;
            label5.Text = "y";
            // 
            // inProfileComboBox
            // 
            inProfileComboBox.FormattingEnabled = true;
            inProfileComboBox.Location = new Point(6, 22);
            inProfileComboBox.Name = "inProfileComboBox";
            inProfileComboBox.Size = new Size(180, 23);
            inProfileComboBox.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 43;
            label3.Text = "White:";
            // 
            // inGreenXTextBox
            // 
            inGreenXTextBox.Location = new Point(259, 61);
            inGreenXTextBox.Name = "inGreenXTextBox";
            inGreenXTextBox.Size = new Size(44, 23);
            inGreenXTextBox.TabIndex = 54;
            inGreenXTextBox.TextChanged += inGreenXTextBox_TextChanged;
            // 
            // inGreenYTextBox
            // 
            inGreenYTextBox.Location = new Point(309, 63);
            inGreenYTextBox.Name = "inGreenYTextBox";
            inGreenYTextBox.Size = new Size(44, 23);
            inGreenYTextBox.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 69);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 53;
            label9.Text = "Green:";
            // 
            // inBlueXTextBox
            // 
            inBlueXTextBox.Location = new Point(259, 92);
            inBlueXTextBox.Name = "inBlueXTextBox";
            inBlueXTextBox.Size = new Size(44, 23);
            inBlueXTextBox.TabIndex = 57;
            // 
            // inBlueYTextBox
            // 
            inBlueYTextBox.Location = new Point(309, 92);
            inBlueYTextBox.Name = "inBlueYTextBox";
            inBlueYTextBox.Size = new Size(44, 23);
            inBlueYTextBox.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(220, 95);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 56;
            label10.Text = "Blue:";
            // 
            // outGammaTextBox
            // 
            outGammaTextBox.Location = new Point(62, 55);
            outGammaTextBox.Name = "outGammaTextBox";
            outGammaTextBox.Size = new Size(100, 23);
            outGammaTextBox.TabIndex = 60;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 77);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 70;
            label11.Text = "x";
            // 
            // outRedXTextBox
            // 
            outRedXTextBox.Location = new Point(300, 32);
            outRedXTextBox.Name = "outRedXTextBox";
            outRedXTextBox.Size = new Size(44, 23);
            outRedXTextBox.TabIndex = 68;
            // 
            // outRedYTextBox
            // 
            outRedYTextBox.Location = new Point(350, 32);
            outRedYTextBox.Name = "outRedYTextBox";
            outRedYTextBox.Size = new Size(44, 23);
            outRedYTextBox.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(139, 77);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 71;
            label12.Text = "y";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(255, 35);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 67;
            label13.Text = "Red:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 55);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 61;
            label14.Text = "Gamma:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(316, 14);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 65;
            label15.Text = "x";
            // 
            // outWhiteXTextBox
            // 
            outWhiteXTextBox.Location = new Point(63, 99);
            outWhiteXTextBox.Name = "outWhiteXTextBox";
            outWhiteXTextBox.Size = new Size(44, 23);
            outWhiteXTextBox.TabIndex = 63;
            // 
            // outWhiteYTextBox
            // 
            outWhiteYTextBox.Location = new Point(113, 99);
            outWhiteYTextBox.Name = "outWhiteYTextBox";
            outWhiteYTextBox.Size = new Size(44, 23);
            outWhiteYTextBox.TabIndex = 64;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(327, 14);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 66;
            label16.Text = "y";
            // 
            // outProfileComboBox
            // 
            outProfileComboBox.FormattingEnabled = true;
            outProfileComboBox.Location = new Point(6, 22);
            outProfileComboBox.Name = "outProfileComboBox";
            outProfileComboBox.Size = new Size(180, 23);
            outProfileComboBox.TabIndex = 59;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 102);
            label17.Name = "label17";
            label17.Size = new Size(41, 15);
            label17.TabIndex = 62;
            label17.Text = "White:";
            // 
            // outGreenXTextBox
            // 
            outGreenXTextBox.Location = new Point(300, 61);
            outGreenXTextBox.Name = "outGreenXTextBox";
            outGreenXTextBox.Size = new Size(44, 23);
            outGreenXTextBox.TabIndex = 73;
            // 
            // outGreenYTextBox
            // 
            outGreenYTextBox.Location = new Point(350, 61);
            outGreenYTextBox.Name = "outGreenYTextBox";
            outGreenYTextBox.Size = new Size(44, 23);
            outGreenYTextBox.TabIndex = 74;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(255, 66);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 72;
            label18.Text = "Green:";
            // 
            // outBlueXTextBox
            // 
            outBlueXTextBox.Location = new Point(300, 90);
            outBlueXTextBox.Name = "outBlueXTextBox";
            outBlueXTextBox.Size = new Size(44, 23);
            outBlueXTextBox.TabIndex = 76;
            // 
            // outBlueYTextBox
            // 
            outBlueYTextBox.Location = new Point(350, 90);
            outBlueYTextBox.Name = "outBlueYTextBox";
            outBlueYTextBox.Size = new Size(44, 23);
            outBlueYTextBox.TabIndex = 77;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(255, 95);
            label19.Name = "label19";
            label19.Size = new Size(33, 15);
            label19.TabIndex = 75;
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
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private ComboBox inProfileComboBox;
        private TextBox inWhiteYTextBox;
        private Label label3;
        private TextBox inGreenXTextBox;
        private GroupBox groupBox2;
        private TextBox inGammaTextBox;
        private Label label6;
        private Label label19;
        private TextBox inRedXTextBox;
        private TextBox outBlueYTextBox;
        private TextBox inRedYTextBox;
        private TextBox outBlueXTextBox;
        private Label label7;
        private Label label18;
        private Label label8;
        private TextBox outGreenYTextBox;
        private Label label2;
        private TextBox outGreenXTextBox;
        private Label label1;
        private Label label17;
        private Label label4;
        private ComboBox outProfileComboBox;
        private TextBox inWhiteXTextBox;
        private Label label16;
        private TextBox outWhiteYTextBox;
        private Label label5;
        private TextBox outWhiteXTextBox;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox inGreenYTextBox;
        private Label label12;
        private Label label9;
        private TextBox outRedYTextBox;
        private TextBox inBlueXTextBox;
        private TextBox outRedXTextBox;
        private TextBox inBlueYTextBox;
        private Label label11;
        private Label label10;
        private TextBox outGammaTextBox;
    }
}