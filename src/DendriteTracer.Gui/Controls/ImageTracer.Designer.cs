﻿namespace DendriteTracer.Gui
{
    partial class ImageTracer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            hScrollBar1 = new HScrollBar();
            nudBrightness = new NumericUpDown();
            label2 = new Label();
            cbRois = new CheckBox();
            cbSpines = new CheckBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            richTextBox2 = new RichTextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            btnSelectFile = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            lblAreaPx = new Label();
            lblRadiusPx = new Label();
            cbRoiCirular = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            nudRoiRadius = new NumericUpDown();
            nudRoiSpacing = new NumericUpDown();
            groupBox4 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            nudImageSubtractionFloor = new NumericUpDown();
            cbImageSubtractionEnabled = new CheckBox();
            gbFrameBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBrightness).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRoiRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoiSpacing).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudImageSubtractionFloor).BeginInit();
            gbFrameBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Dock = DockStyle.Fill;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(0, 0);
            hScrollBar1.Maximum = 10;
            hScrollBar1.Minimum = 1;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(492, 47);
            hScrollBar1.TabIndex = 1;
            hScrollBar1.Value = 1;
            // 
            // nudBrightness
            // 
            nudBrightness.DecimalPlaces = 1;
            nudBrightness.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudBrightness.Location = new Point(120, 68);
            nudBrightness.Margin = new Padding(4, 5, 4, 5);
            nudBrightness.Name = "nudBrightness";
            nudBrightness.Size = new Size(90, 31);
            nudBrightness.TabIndex = 3;
            nudBrightness.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Brightness";
            // 
            // cbRois
            // 
            cbRois.AutoSize = true;
            cbRois.Checked = true;
            cbRois.CheckState = CheckState.Checked;
            cbRois.Location = new Point(363, 67);
            cbRois.Margin = new Padding(4, 5, 4, 5);
            cbRois.Name = "cbRois";
            cbRois.Size = new Size(76, 29);
            cbRois.TabIndex = 5;
            cbRois.Text = "ROIs";
            cbRois.UseVisualStyleBackColor = true;
            // 
            // cbSpines
            // 
            cbSpines.AutoSize = true;
            cbSpines.Checked = true;
            cbSpines.CheckState = CheckState.Checked;
            cbSpines.Location = new Point(242, 67);
            cbSpines.Margin = new Padding(4, 5, 4, 5);
            cbSpines.Name = "cbSpines";
            cbSpines.Size = new Size(90, 29);
            cbSpines.TabIndex = 6;
            cbSpines.Text = "Spines";
            cbSpines.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(hScrollBar1);
            panel1.Location = new Point(10, 32);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 49);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudBrightness);
            groupBox1.Controls.Add(cbSpines);
            groupBox1.Controls.Add(cbRois);
            groupBox1.Location = new Point(4, 951);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(511, 116);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Display";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox2.BackColor = SystemColors.Control;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.ControlDark;
            richTextBox2.Location = new Point(7, 29);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(499, 31);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "These settings only affects the preview image (not analysis)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnSelectFile);
            groupBox2.Location = new Point(3, 631);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(511, 103);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Load Data (TIF or JSON)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(183, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 11;
            label3.Text = "or drag/drop a file here";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(17, 47);
            btnSelectFile.Margin = new Padding(4, 5, 4, 5);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(107, 38);
            btnSelectFile.TabIndex = 10;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(lblAreaPx);
            groupBox3.Controls.Add(lblRadiusPx);
            groupBox3.Controls.Add(cbRoiCirular);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(nudRoiRadius);
            groupBox3.Controls.Add(nudRoiSpacing);
            groupBox3.Location = new Point(4, 1085);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(511, 136);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "ROI Dimensions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 13;
            label1.Text = "Mask";
            // 
            // lblAreaPx
            // 
            lblAreaPx.AutoSize = true;
            lblAreaPx.ForeColor = SystemColors.ControlDark;
            lblAreaPx.Location = new Point(302, 99);
            lblAreaPx.Name = "lblAreaPx";
            lblAreaPx.Size = new Size(46, 25);
            lblAreaPx.TabIndex = 12;
            lblAreaPx.Text = "0 px";
            // 
            // lblRadiusPx
            // 
            lblRadiusPx.AutoSize = true;
            lblRadiusPx.ForeColor = SystemColors.ControlDark;
            lblRadiusPx.Location = new Point(163, 99);
            lblRadiusPx.Name = "lblRadiusPx";
            lblRadiusPx.Size = new Size(64, 25);
            lblRadiusPx.TabIndex = 11;
            lblRadiusPx.Text = "0x0 px";
            // 
            // cbRoiCirular
            // 
            cbRoiCirular.AutoSize = true;
            cbRoiCirular.Checked = true;
            cbRoiCirular.CheckState = CheckState.Checked;
            cbRoiCirular.Location = new Point(306, 67);
            cbRoiCirular.Name = "cbRoiCirular";
            cbRoiCirular.Size = new Size(96, 29);
            cbRoiCirular.TabIndex = 9;
            cbRoiCirular.Text = "Circular";
            cbRoiCirular.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 35);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 4;
            label4.Text = "Radius (µm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 35);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 3;
            label5.Text = "Spacing (µm)";
            // 
            // nudRoiRadius
            // 
            nudRoiRadius.Location = new Point(166, 65);
            nudRoiRadius.Name = "nudRoiRadius";
            nudRoiRadius.Size = new Size(106, 31);
            nudRoiRadius.TabIndex = 1;
            nudRoiRadius.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nudRoiSpacing
            // 
            nudRoiSpacing.Location = new Point(26, 65);
            nudRoiSpacing.Name = "nudRoiSpacing";
            nudRoiSpacing.Size = new Size(106, 31);
            nudRoiSpacing.TabIndex = 0;
            nudRoiSpacing.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox1);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(nudImageSubtractionFloor);
            groupBox4.Controls.Add(cbImageSubtractionEnabled);
            groupBox4.Location = new Point(3, 752);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(511, 181);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Noise Floor Subtraction";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.ControlDark;
            richTextBox1.Location = new Point(6, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(499, 80);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "This filter subtracts the noise floor so ROI background mean is zero. Note that the green floor is typically higher than the red floor. Doing this makes G/R ratio insensitive to ROI size.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(7, 27);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 127);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 12;
            label6.Text = "Floor (%)";
            // 
            // nudImageSubtractionFloor
            // 
            nudImageSubtractionFloor.Location = new Point(121, 125);
            nudImageSubtractionFloor.Name = "nudImageSubtractionFloor";
            nudImageSubtractionFloor.Size = new Size(82, 31);
            nudImageSubtractionFloor.TabIndex = 11;
            nudImageSubtractionFloor.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // cbImageSubtractionEnabled
            // 
            cbImageSubtractionEnabled.AutoSize = true;
            cbImageSubtractionEnabled.Checked = true;
            cbImageSubtractionEnabled.CheckState = CheckState.Checked;
            cbImageSubtractionEnabled.Location = new Point(243, 126);
            cbImageSubtractionEnabled.Name = "cbImageSubtractionEnabled";
            cbImageSubtractionEnabled.Size = new Size(90, 29);
            cbImageSubtractionEnabled.TabIndex = 10;
            cbImageSubtractionEnabled.Text = "Enable";
            cbImageSubtractionEnabled.UseVisualStyleBackColor = true;
            // 
            // gbFrameBox
            // 
            gbFrameBox.Controls.Add(panel1);
            gbFrameBox.Location = new Point(3, 521);
            gbFrameBox.Name = "gbFrameBox";
            gbFrameBox.Size = new Size(511, 92);
            gbFrameBox.TabIndex = 13;
            gbFrameBox.TabStop = false;
            gbFrameBox.Text = "Frame (12 of 34)";
            // 
            // ImageTracer
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFrameBox);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "ImageTracer";
            Size = new Size(517, 1251);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBrightness).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRoiRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoiSpacing).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudImageSubtractionFloor).EndInit();
            gbFrameBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private HScrollBar hScrollBar1;
        private NumericUpDown nudBrightness;
        private Label label2;
        private CheckBox cbRois;
        private CheckBox cbSpines;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSelectFile;
        private Label label3;
        private GroupBox groupBox3;
        private CheckBox cbRoiCirular;
        private Label label4;
        private Label label5;
        private NumericUpDown nudRoiRadius;
        private NumericUpDown nudRoiSpacing;
        private GroupBox groupBox4;
        private Label label6;
        private NumericUpDown nudImageSubtractionFloor;
        private CheckBox cbImageSubtractionEnabled;
        private Label lblAreaPx;
        private Label lblRadiusPx;
        private GroupBox gbFrameBox;
        private Label label1;
        private Label label7;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
    }
}
