
namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Change_btn;
            this.OpenButton = new System.Windows.Forms.Button();
            this.original_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.O_R_Band = new System.Windows.Forms.PictureBox();
            this.O_G_Band = new System.Windows.Forms.PictureBox();
            this.O_B_Band = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.O_PhotoWH = new System.Windows.Forms.Label();
            this.H_R_img = new System.Windows.Forms.PictureBox();
            this.H_G_img = new System.Windows.Forms.PictureBox();
            this.H_B_img = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.result_text = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Result_H_B = new System.Windows.Forms.PictureBox();
            this.Result_B = new System.Windows.Forms.PictureBox();
            this.Result_H_G = new System.Windows.Forms.PictureBox();
            this.Result_G = new System.Windows.Forms.PictureBox();
            this.Result_H_R = new System.Windows.Forms.PictureBox();
            this.Result_R = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ResultImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_maxium = new System.Windows.Forms.Button();
            this.Btn_mean_value = new System.Windows.Forms.Button();
            this.Btn_mean_weig = new System.Windows.Forms.Button();
            this.Btn_undo = new System.Windows.Forms.Button();
            this.btn_org = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Histogram_equ = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_Negative = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Mean = new System.Windows.Forms.Button();
            this.btn_Median = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_value = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.Thresholding_Apply = new System.Windows.Forms.Button();
            this.Thresholding_Change = new System.Windows.Forms.Button();
            this.btn_Otsu = new System.Windows.Forms.Button();
            this.btn_Rotate = new System.Windows.Forms.Button();
            this.btn_Wrapping = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.resize_time = new System.Windows.Forms.TextBox();
            this.small = new System.Windows.Forms.RadioButton();
            this.big = new System.Windows.Forms.RadioButton();
            this.resize = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_error_diffusion = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CV_erosin = new System.Windows.Forms.Button();
            this.CV_dilation = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.Kernal_size = new System.Windows.Forms.TextBox();
            this.Morph_close_btn = new System.Windows.Forms.Button();
            this.Morph_open_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Eroion_btn = new System.Windows.Forms.Button();
            this.Dilation_btn = new System.Windows.Forms.Button();
            this.btn_backward = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.Hough_Circles_btn = new System.Windows.Forms.Button();
            this.FindContours_btn = new System.Windows.Forms.Button();
            this.Canny_btn = new System.Windows.Forms.Button();
            this.btn_openvideo = new System.Windows.Forms.Button();
            this.btn_Stop_video = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.Process_btn = new System.Windows.Forms.Button();
            this.openfolder_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            Change_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.original_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_H_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_H_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_H_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Change_btn
            // 
            Change_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            Change_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Change_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            Change_btn.Location = new System.Drawing.Point(519, 264);
            Change_btn.Margin = new System.Windows.Forms.Padding(4);
            Change_btn.Name = "Change_btn";
            Change_btn.Size = new System.Drawing.Size(68, 105);
            Change_btn.TabIndex = 35;
            Change_btn.Text = "Result  _To_ Orignal ";
            Change_btn.UseVisualStyleBackColor = true;
            Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.White;
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OpenButton.Location = new System.Drawing.Point(15, 15);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(113, 38);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            this.OpenButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.OpenButton.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.OpenButton.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // original_img
            // 
            this.original_img.BackColor = System.Drawing.SystemColors.ControlDark;
            this.original_img.Location = new System.Drawing.Point(16, 86);
            this.original_img.Margin = new System.Windows.Forms.Padding(4);
            this.original_img.Name = "original_img";
            this.original_img.Size = new System.Drawing.Size(496, 446);
            this.original_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.original_img.TabIndex = 2;
            this.original_img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // O_R_Band
            // 
            this.O_R_Band.BackColor = System.Drawing.Color.White;
            this.O_R_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_R_Band.Location = new System.Drawing.Point(16, 594);
            this.O_R_Band.Margin = new System.Windows.Forms.Padding(4);
            this.O_R_Band.Name = "O_R_Band";
            this.O_R_Band.Size = new System.Drawing.Size(159, 143);
            this.O_R_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_R_Band.TabIndex = 4;
            this.O_R_Band.TabStop = false;
            // 
            // O_G_Band
            // 
            this.O_G_Band.BackColor = System.Drawing.Color.White;
            this.O_G_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_G_Band.Location = new System.Drawing.Point(184, 594);
            this.O_G_Band.Margin = new System.Windows.Forms.Padding(4);
            this.O_G_Band.Name = "O_G_Band";
            this.O_G_Band.Size = new System.Drawing.Size(159, 143);
            this.O_G_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_G_Band.TabIndex = 4;
            this.O_G_Band.TabStop = false;
            // 
            // O_B_Band
            // 
            this.O_B_Band.BackColor = System.Drawing.Color.White;
            this.O_B_Band.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O_B_Band.Location = new System.Drawing.Point(352, 594);
            this.O_B_Band.Margin = new System.Windows.Forms.Padding(4);
            this.O_B_Band.Name = "O_B_Band";
            this.O_B_Band.Size = new System.Drawing.Size(159, 143);
            this.O_B_Band.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.O_B_Band.TabIndex = 4;
            this.O_B_Band.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(80, 560);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(248, 560);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(416, 560);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // O_PhotoWH
            // 
            this.O_PhotoWH.AutoSize = true;
            this.O_PhotoWH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.O_PhotoWH.Location = new System.Drawing.Point(399, 59);
            this.O_PhotoWH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.O_PhotoWH.Name = "O_PhotoWH";
            this.O_PhotoWH.Size = new System.Drawing.Size(46, 24);
            this.O_PhotoWH.TabIndex = 6;
            this.O_PhotoWH.Text = "0x0";
            // 
            // H_R_img
            // 
            this.H_R_img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_R_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_R_img.Location = new System.Drawing.Point(15, 810);
            this.H_R_img.Margin = new System.Windows.Forms.Padding(4);
            this.H_R_img.Name = "H_R_img";
            this.H_R_img.Size = new System.Drawing.Size(159, 143);
            this.H_R_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_R_img.TabIndex = 4;
            this.H_R_img.TabStop = false;
            // 
            // H_G_img
            // 
            this.H_G_img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_G_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_G_img.Location = new System.Drawing.Point(184, 810);
            this.H_G_img.Margin = new System.Windows.Forms.Padding(4);
            this.H_G_img.Name = "H_G_img";
            this.H_G_img.Size = new System.Drawing.Size(159, 143);
            this.H_G_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_G_img.TabIndex = 4;
            this.H_G_img.TabStop = false;
            // 
            // H_B_img
            // 
            this.H_B_img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.H_B_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_B_img.Location = new System.Drawing.Point(352, 810);
            this.H_B_img.Margin = new System.Windows.Forms.Padding(4);
            this.H_B_img.Name = "H_B_img";
            this.H_B_img.Size = new System.Drawing.Size(159, 143);
            this.H_B_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H_B_img.TabIndex = 4;
            this.H_B_img.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(15, 782);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "直方圖";
            // 
            // Btn_save
            // 
            this.Btn_save.Font = new System.Drawing.Font("新細明體", 12F);
            this.Btn_save.Location = new System.Drawing.Point(136, 16);
            this.Btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(113, 38);
            this.Btn_save.TabIndex = 8;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            this.Btn_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Btn_save.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Btn_save.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(588, 785);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "直方圖";
            // 
            // result_text
            // 
            this.result_text.AutoSize = true;
            this.result_text.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result_text.Location = new System.Drawing.Point(972, 61);
            this.result_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(46, 24);
            this.result_text.TabIndex = 20;
            this.result_text.Text = "0x0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(989, 562);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(821, 562);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "G";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(653, 562);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "R";
            // 
            // Result_H_B
            // 
            this.Result_H_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Result_H_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_H_B.Location = new System.Drawing.Point(925, 812);
            this.Result_H_B.Margin = new System.Windows.Forms.Padding(4);
            this.Result_H_B.Name = "Result_H_B";
            this.Result_H_B.Size = new System.Drawing.Size(159, 143);
            this.Result_H_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_H_B.TabIndex = 11;
            this.Result_H_B.TabStop = false;
            // 
            // Result_B
            // 
            this.Result_B.BackColor = System.Drawing.Color.White;
            this.Result_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_B.Location = new System.Drawing.Point(925, 596);
            this.Result_B.Margin = new System.Windows.Forms.Padding(4);
            this.Result_B.Name = "Result_B";
            this.Result_B.Size = new System.Drawing.Size(159, 143);
            this.Result_B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_B.TabIndex = 12;
            this.Result_B.TabStop = false;
            // 
            // Result_H_G
            // 
            this.Result_H_G.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Result_H_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_H_G.Location = new System.Drawing.Point(757, 812);
            this.Result_H_G.Margin = new System.Windows.Forms.Padding(4);
            this.Result_H_G.Name = "Result_H_G";
            this.Result_H_G.Size = new System.Drawing.Size(159, 143);
            this.Result_H_G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_H_G.TabIndex = 13;
            this.Result_H_G.TabStop = false;
            // 
            // Result_G
            // 
            this.Result_G.BackColor = System.Drawing.Color.White;
            this.Result_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_G.Location = new System.Drawing.Point(757, 596);
            this.Result_G.Margin = new System.Windows.Forms.Padding(4);
            this.Result_G.Name = "Result_G";
            this.Result_G.Size = new System.Drawing.Size(159, 143);
            this.Result_G.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_G.TabIndex = 14;
            this.Result_G.TabStop = false;
            // 
            // Result_H_R
            // 
            this.Result_H_R.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Result_H_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_H_R.Location = new System.Drawing.Point(588, 812);
            this.Result_H_R.Margin = new System.Windows.Forms.Padding(4);
            this.Result_H_R.Name = "Result_H_R";
            this.Result_H_R.Size = new System.Drawing.Size(159, 143);
            this.Result_H_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_H_R.TabIndex = 15;
            this.Result_H_R.TabStop = false;
            // 
            // Result_R
            // 
            this.Result_R.BackColor = System.Drawing.Color.White;
            this.Result_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_R.Location = new System.Drawing.Point(589, 596);
            this.Result_R.Margin = new System.Windows.Forms.Padding(4);
            this.Result_R.Name = "Result_R";
            this.Result_R.Size = new System.Drawing.Size(159, 143);
            this.Result_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Result_R.TabIndex = 16;
            this.Result_R.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(589, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Result Image";
            // 
            // ResultImg
            // 
            this.ResultImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResultImg.Location = new System.Drawing.Point(595, 86);
            this.ResultImg.Margin = new System.Windows.Forms.Padding(4);
            this.ResultImg.Name = "ResultImg";
            this.ResultImg.Size = new System.Drawing.Size(496, 446);
            this.ResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultImg.TabIndex = 9;
            this.ResultImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Btn_maxium);
            this.panel1.Controls.Add(this.Btn_mean_value);
            this.panel1.Controls.Add(this.Btn_mean_weig);
            this.panel1.Location = new System.Drawing.Point(1155, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 94);
            this.panel1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(4, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Grayscale";
            // 
            // Btn_maxium
            // 
            this.Btn_maxium.Location = new System.Drawing.Point(275, 36);
            this.Btn_maxium.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_maxium.Name = "Btn_maxium";
            this.Btn_maxium.Size = new System.Drawing.Size(107, 44);
            this.Btn_maxium.TabIndex = 2;
            this.Btn_maxium.Text = "Maxium";
            this.Btn_maxium.UseVisualStyleBackColor = true;
            this.Btn_maxium.Click += new System.EventHandler(this.Btn_maxium_Click);
            this.Btn_maxium.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Btn_maxium.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Btn_maxium.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Btn_mean_value
            // 
            this.Btn_mean_value.Location = new System.Drawing.Point(141, 36);
            this.Btn_mean_value.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_mean_value.Name = "Btn_mean_value";
            this.Btn_mean_value.Size = new System.Drawing.Size(107, 44);
            this.Btn_mean_value.TabIndex = 1;
            this.Btn_mean_value.Text = "Mean-Value";
            this.Btn_mean_value.UseVisualStyleBackColor = true;
            this.Btn_mean_value.Click += new System.EventHandler(this.Btn_mean_value_Click);
            this.Btn_mean_value.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Btn_mean_value.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Btn_mean_value.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Btn_mean_weig
            // 
            this.Btn_mean_weig.Font = new System.Drawing.Font("新細明體", 9F);
            this.Btn_mean_weig.Location = new System.Drawing.Point(4, 36);
            this.Btn_mean_weig.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_mean_weig.Name = "Btn_mean_weig";
            this.Btn_mean_weig.Size = new System.Drawing.Size(107, 44);
            this.Btn_mean_weig.TabIndex = 0;
            this.Btn_mean_weig.Text = "Mean-Weight";
            this.Btn_mean_weig.UseVisualStyleBackColor = true;
            this.Btn_mean_weig.Click += new System.EventHandler(this.Btn_mean_weig_Click);
            this.Btn_mean_weig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Btn_mean_weig.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Btn_mean_weig.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Btn_undo
            // 
            this.Btn_undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_undo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_undo.Location = new System.Drawing.Point(1376, 24);
            this.Btn_undo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_undo.Name = "Btn_undo";
            this.Btn_undo.Size = new System.Drawing.Size(113, 38);
            this.Btn_undo.TabIndex = 3;
            this.Btn_undo.Text = "Undo";
            this.Btn_undo.UseVisualStyleBackColor = false;
            this.Btn_undo.Click += new System.EventHandler(this.Btn_undo_Click);
            // 
            // btn_org
            // 
            this.btn_org.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_org.Location = new System.Drawing.Point(1498, 24);
            this.btn_org.Margin = new System.Windows.Forms.Padding(4);
            this.btn_org.Name = "btn_org";
            this.btn_org.Size = new System.Drawing.Size(113, 38);
            this.btn_org.TabIndex = 23;
            this.btn_org.Text = "Original";
            this.btn_org.UseVisualStyleBackColor = true;
            this.btn_org.Click += new System.EventHandler(this.btn_org_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btn_Histogram_equ);
            this.panel3.Controls.Add(this.btn_Log);
            this.panel3.Controls.Add(this.btn_Negative);
            this.panel3.Location = new System.Drawing.Point(1155, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 85);
            this.panel3.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(4, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Contrast";
            // 
            // btn_Histogram_equ
            // 
            this.btn_Histogram_equ.Location = new System.Drawing.Point(275, 34);
            this.btn_Histogram_equ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Histogram_equ.Name = "btn_Histogram_equ";
            this.btn_Histogram_equ.Size = new System.Drawing.Size(107, 44);
            this.btn_Histogram_equ.TabIndex = 2;
            this.btn_Histogram_equ.Text = "Histogram equalization";
            this.btn_Histogram_equ.UseVisualStyleBackColor = true;
            this.btn_Histogram_equ.Click += new System.EventHandler(this.btn_Histogram_equ_Click);
            this.btn_Histogram_equ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Histogram_equ.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Histogram_equ.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Log
            // 
            this.btn_Log.Location = new System.Drawing.Point(141, 34);
            this.btn_Log.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(107, 44);
            this.btn_Log.TabIndex = 1;
            this.btn_Log.Text = "Log";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            this.btn_Log.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Log.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Log.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Negative
            // 
            this.btn_Negative.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Negative.Location = new System.Drawing.Point(8, 34);
            this.btn_Negative.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Negative.Name = "btn_Negative";
            this.btn_Negative.Size = new System.Drawing.Size(101, 44);
            this.btn_Negative.TabIndex = 0;
            this.btn_Negative.Text = "Negative";
            this.btn_Negative.UseVisualStyleBackColor = true;
            this.btn_Negative.Click += new System.EventHandler(this.btn_Negative_Click);
            this.btn_Negative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Negative.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Negative.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Min);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_Max);
            this.panel2.Controls.Add(this.btn_Mean);
            this.panel2.Controls.Add(this.btn_Median);
            this.panel2.Location = new System.Drawing.Point(1155, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 85);
            this.panel2.TabIndex = 25;
            // 
            // btn_Min
            // 
            this.btn_Min.Location = new System.Drawing.Point(361, 36);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(73, 41);
            this.btn_Min.TabIndex = 4;
            this.btn_Min.Text = "Min";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            this.btn_Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Min.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Min.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Space Filter";
            // 
            // btn_Max
            // 
            this.btn_Max.Location = new System.Drawing.Point(235, 34);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(73, 44);
            this.btn_Max.TabIndex = 2;
            this.btn_Max.Text = "Max";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            this.btn_Max.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Max.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Max.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Mean
            // 
            this.btn_Mean.Location = new System.Drawing.Point(119, 34);
            this.btn_Mean.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Mean.Name = "btn_Mean";
            this.btn_Mean.Size = new System.Drawing.Size(73, 44);
            this.btn_Mean.TabIndex = 1;
            this.btn_Mean.Text = "Mean";
            this.btn_Mean.UseVisualStyleBackColor = true;
            this.btn_Mean.Click += new System.EventHandler(this.btn_Mean_Click);
            this.btn_Mean.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Mean.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Mean.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Median
            // 
            this.btn_Median.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Median.Location = new System.Drawing.Point(8, 36);
            this.btn_Median.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Median.Name = "btn_Median";
            this.btn_Median.Size = new System.Drawing.Size(87, 41);
            this.btn_Median.TabIndex = 0;
            this.btn_Median.Text = "Median";
            this.btn_Median.UseVisualStyleBackColor = true;
            this.btn_Median.Click += new System.EventHandler(this.btn_Median_Click);
            this.btn_Median.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Median.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Median.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label_value);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.Thresholding_Apply);
            this.panel4.Controls.Add(this.Thresholding_Change);
            this.panel4.Controls.Add(this.btn_Otsu);
            this.panel4.Location = new System.Drawing.Point(1155, 376);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 85);
            this.panel4.TabIndex = 26;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.Location = new System.Drawing.Point(408, 12);
            this.label_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(26, 29);
            this.label_value.TabIndex = 28;
            this.label_value.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(185, 9);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 35);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(4, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Thresholding";
            // 
            // Thresholding_Apply
            // 
            this.Thresholding_Apply.Location = new System.Drawing.Point(328, 51);
            this.Thresholding_Apply.Margin = new System.Windows.Forms.Padding(4);
            this.Thresholding_Apply.Name = "Thresholding_Apply";
            this.Thresholding_Apply.Size = new System.Drawing.Size(107, 26);
            this.Thresholding_Apply.TabIndex = 2;
            this.Thresholding_Apply.Text = "Apply";
            this.Thresholding_Apply.UseVisualStyleBackColor = true;
            this.Thresholding_Apply.Click += new System.EventHandler(this.Thresholding_Apply_Click);
            this.Thresholding_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Thresholding_Apply.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Thresholding_Apply.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Thresholding_Change
            // 
            this.Thresholding_Change.Location = new System.Drawing.Point(185, 51);
            this.Thresholding_Change.Margin = new System.Windows.Forms.Padding(4);
            this.Thresholding_Change.Name = "Thresholding_Change";
            this.Thresholding_Change.Size = new System.Drawing.Size(107, 26);
            this.Thresholding_Change.TabIndex = 1;
            this.Thresholding_Change.Text = "Change";
            this.Thresholding_Change.UseVisualStyleBackColor = true;
            this.Thresholding_Change.Click += new System.EventHandler(this.Thresholding_Change_Click);
            this.Thresholding_Change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Thresholding_Change.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Thresholding_Change.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Otsu
            // 
            this.btn_Otsu.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Otsu.Location = new System.Drawing.Point(8, 51);
            this.btn_Otsu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Otsu.Name = "btn_Otsu";
            this.btn_Otsu.Size = new System.Drawing.Size(101, 26);
            this.btn_Otsu.TabIndex = 0;
            this.btn_Otsu.Text = "Otsu";
            this.btn_Otsu.UseVisualStyleBackColor = true;
            this.btn_Otsu.Click += new System.EventHandler(this.btn_Otsu_Click);
            this.btn_Otsu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Otsu.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Otsu.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Rotate
            // 
            this.btn_Rotate.Location = new System.Drawing.Point(119, 36);
            this.btn_Rotate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(101, 26);
            this.btn_Rotate.TabIndex = 28;
            this.btn_Rotate.Text = "Rotate";
            this.btn_Rotate.UseVisualStyleBackColor = true;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Rotate_Click);
            this.btn_Rotate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Rotate.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Rotate.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_Wrapping
            // 
            this.btn_Wrapping.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Wrapping.Location = new System.Drawing.Point(9, 36);
            this.btn_Wrapping.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Wrapping.Name = "btn_Wrapping";
            this.btn_Wrapping.Size = new System.Drawing.Size(101, 26);
            this.btn_Wrapping.TabIndex = 27;
            this.btn_Wrapping.Text = "Wrapping";
            this.btn_Wrapping.UseVisualStyleBackColor = true;
            this.btn_Wrapping.Click += new System.EventHandler(this.btn_Wrapping_Click);
            this.btn_Wrapping.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_Wrapping.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_Wrapping.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270"});
            this.comboBox1.Location = new System.Drawing.Point(119, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 23);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.resize_time);
            this.panel5.Controls.Add(this.small);
            this.panel5.Controls.Add(this.big);
            this.panel5.Controls.Add(this.resize);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.btn_Wrapping);
            this.panel5.Controls.Add(this.btn_Rotate);
            this.panel5.Location = new System.Drawing.Point(1155, 484);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 105);
            this.panel5.TabIndex = 31;
            // 
            // resize_time
            // 
            this.resize_time.Location = new System.Drawing.Point(235, 70);
            this.resize_time.Margin = new System.Windows.Forms.Padding(4);
            this.resize_time.Name = "resize_time";
            this.resize_time.Size = new System.Drawing.Size(97, 25);
            this.resize_time.TabIndex = 33;
            this.resize_time.Text = "1";
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Location = new System.Drawing.Point(341, 72);
            this.small.Margin = new System.Windows.Forms.Padding(4);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(58, 19);
            this.small.TabIndex = 32;
            this.small.TabStop = true;
            this.small.Text = "縮小";
            this.small.UseVisualStyleBackColor = true;
            // 
            // big
            // 
            this.big.AutoSize = true;
            this.big.Location = new System.Drawing.Point(341, 39);
            this.big.Margin = new System.Windows.Forms.Padding(4);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(58, 19);
            this.big.TabIndex = 31;
            this.big.TabStop = true;
            this.big.Text = "放大";
            this.big.UseVisualStyleBackColor = true;
            // 
            // resize
            // 
            this.resize.Location = new System.Drawing.Point(232, 36);
            this.resize.Margin = new System.Windows.Forms.Padding(4);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(101, 26);
            this.resize.TabIndex = 30;
            this.resize.Text = "resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            this.resize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.resize.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.resize.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(4, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Deformation";
            // 
            // btn_error_diffusion
            // 
            this.btn_error_diffusion.Location = new System.Drawing.Point(1153, 758);
            this.btn_error_diffusion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_error_diffusion.Name = "btn_error_diffusion";
            this.btn_error_diffusion.Size = new System.Drawing.Size(113, 34);
            this.btn_error_diffusion.TabIndex = 32;
            this.btn_error_diffusion.Text = "error diffusion";
            this.btn_error_diffusion.UseVisualStyleBackColor = true;
            this.btn_error_diffusion.Click += new System.EventHandler(this.btn_error_diffusion_Click);
            this.btn_error_diffusion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_error_diffusion.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_error_diffusion.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.CV_erosin);
            this.panel6.Controls.Add(this.CV_dilation);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.Kernal_size);
            this.panel6.Controls.Add(this.Morph_close_btn);
            this.panel6.Controls.Add(this.Morph_open_btn);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.Eroion_btn);
            this.panel6.Controls.Add(this.Dilation_btn);
            this.panel6.Location = new System.Drawing.Point(1155, 598);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(456, 153);
            this.panel6.TabIndex = 34;
            // 
            // CV_erosin
            // 
            this.CV_erosin.Font = new System.Drawing.Font("新細明體", 9F);
            this.CV_erosin.Location = new System.Drawing.Point(9, 99);
            this.CV_erosin.Margin = new System.Windows.Forms.Padding(4);
            this.CV_erosin.Name = "CV_erosin";
            this.CV_erosin.Size = new System.Drawing.Size(101, 46);
            this.CV_erosin.TabIndex = 34;
            this.CV_erosin.Text = "CV_Erosion";
            this.CV_erosin.UseVisualStyleBackColor = true;
            this.CV_erosin.Click += new System.EventHandler(this.CV_erosin_Click);
            this.CV_erosin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.CV_erosin.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.CV_erosin.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // CV_dilation
            // 
            this.CV_dilation.Location = new System.Drawing.Point(119, 99);
            this.CV_dilation.Margin = new System.Windows.Forms.Padding(4);
            this.CV_dilation.Name = "CV_dilation";
            this.CV_dilation.Size = new System.Drawing.Size(101, 46);
            this.CV_dilation.TabIndex = 35;
            this.CV_dilation.Text = "CV_Dilation";
            this.CV_dilation.UseVisualStyleBackColor = true;
            this.CV_dilation.Click += new System.EventHandler(this.CV_dilation_Click);
            this.CV_dilation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.CV_dilation.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.CV_dilation.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(371, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "kernal";
            // 
            // Kernal_size
            // 
            this.Kernal_size.Location = new System.Drawing.Point(263, 4);
            this.Kernal_size.Margin = new System.Windows.Forms.Padding(4);
            this.Kernal_size.Name = "Kernal_size";
            this.Kernal_size.Size = new System.Drawing.Size(99, 25);
            this.Kernal_size.TabIndex = 32;
            // 
            // Morph_close_btn
            // 
            this.Morph_close_btn.Location = new System.Drawing.Point(341, 46);
            this.Morph_close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Morph_close_btn.Name = "Morph_close_btn";
            this.Morph_close_btn.Size = new System.Drawing.Size(101, 46);
            this.Morph_close_btn.TabIndex = 31;
            this.Morph_close_btn.Text = "Close";
            this.Morph_close_btn.UseVisualStyleBackColor = true;
            this.Morph_close_btn.Click += new System.EventHandler(this.Morph_close_btn_Click);
            this.Morph_close_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Morph_close_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Morph_close_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Morph_open_btn
            // 
            this.Morph_open_btn.Location = new System.Drawing.Point(232, 46);
            this.Morph_open_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Morph_open_btn.Name = "Morph_open_btn";
            this.Morph_open_btn.Size = new System.Drawing.Size(101, 46);
            this.Morph_open_btn.TabIndex = 30;
            this.Morph_open_btn.Text = "Open";
            this.Morph_open_btn.UseVisualStyleBackColor = true;
            this.Morph_open_btn.Click += new System.EventHandler(this.Morph_open_btn_Click);
            this.Morph_open_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Morph_open_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Morph_open_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(4, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Morphology";
            // 
            // Eroion_btn
            // 
            this.Eroion_btn.Font = new System.Drawing.Font("新細明體", 9F);
            this.Eroion_btn.Location = new System.Drawing.Point(9, 46);
            this.Eroion_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Eroion_btn.Name = "Eroion_btn";
            this.Eroion_btn.Size = new System.Drawing.Size(101, 46);
            this.Eroion_btn.TabIndex = 27;
            this.Eroion_btn.Text = "Erosion";
            this.Eroion_btn.UseVisualStyleBackColor = true;
            this.Eroion_btn.Click += new System.EventHandler(this.Eroion_btn_Click);
            this.Eroion_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Eroion_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Eroion_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Dilation_btn
            // 
            this.Dilation_btn.Location = new System.Drawing.Point(119, 46);
            this.Dilation_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Dilation_btn.Name = "Dilation_btn";
            this.Dilation_btn.Size = new System.Drawing.Size(101, 46);
            this.Dilation_btn.TabIndex = 28;
            this.Dilation_btn.Text = "Dilation";
            this.Dilation_btn.UseVisualStyleBackColor = true;
            this.Dilation_btn.Click += new System.EventHandler(this.Dilation_btn_Click);
            this.Dilation_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Dilation_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Dilation_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_backward
            // 
            this.btn_backward.Location = new System.Drawing.Point(1337, 812);
            this.btn_backward.Margin = new System.Windows.Forms.Padding(4);
            this.btn_backward.Name = "btn_backward";
            this.btn_backward.Size = new System.Drawing.Size(52, 34);
            this.btn_backward.TabIndex = 36;
            this.btn_backward.Text = "後";
            this.btn_backward.UseVisualStyleBackColor = true;
            this.btn_backward.Click += new System.EventHandler(this.btn_backward_Click);
            this.btn_backward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_backward.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_backward.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(1276, 810);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(4);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(52, 34);
            this.btn_forward.TabIndex = 37;
            this.btn_forward.Text = "前";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            this.btn_forward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.btn_forward.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.btn_forward.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Hough_Circles_btn
            // 
            this.Hough_Circles_btn.Location = new System.Drawing.Point(1153, 812);
            this.Hough_Circles_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Hough_Circles_btn.Name = "Hough_Circles_btn";
            this.Hough_Circles_btn.Size = new System.Drawing.Size(113, 34);
            this.Hough_Circles_btn.TabIndex = 38;
            this.Hough_Circles_btn.Text = "Hough Circles";
            this.Hough_Circles_btn.UseVisualStyleBackColor = true;
            this.Hough_Circles_btn.Click += new System.EventHandler(this.Hough_Circles_btn_Click);
            this.Hough_Circles_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Hough_Circles_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Hough_Circles_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // FindContours_btn
            // 
            this.FindContours_btn.Location = new System.Drawing.Point(1397, 759);
            this.FindContours_btn.Margin = new System.Windows.Forms.Padding(4);
            this.FindContours_btn.Name = "FindContours_btn";
            this.FindContours_btn.Size = new System.Drawing.Size(113, 34);
            this.FindContours_btn.TabIndex = 39;
            this.FindContours_btn.Text = "Find Contours";
            this.FindContours_btn.UseVisualStyleBackColor = true;
            this.FindContours_btn.Click += new System.EventHandler(this.FindContours_btn_Click);
            this.FindContours_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.FindContours_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.FindContours_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // Canny_btn
            // 
            this.Canny_btn.Location = new System.Drawing.Point(1276, 759);
            this.Canny_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Canny_btn.Name = "Canny_btn";
            this.Canny_btn.Size = new System.Drawing.Size(113, 34);
            this.Canny_btn.TabIndex = 40;
            this.Canny_btn.Text = "Canny";
            this.Canny_btn.UseVisualStyleBackColor = true;
            this.Canny_btn.Click += new System.EventHandler(this.Canny_btn_Click);
            this.Canny_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_down);
            this.Canny_btn.MouseEnter += new System.EventHandler(this.Mouse_enter);
            this.Canny_btn.MouseLeave += new System.EventHandler(this.Mouse_leave);
            // 
            // btn_openvideo
            // 
            this.btn_openvideo.Location = new System.Drawing.Point(266, 15);
            this.btn_openvideo.Name = "btn_openvideo";
            this.btn_openvideo.Size = new System.Drawing.Size(97, 38);
            this.btn_openvideo.TabIndex = 41;
            this.btn_openvideo.Text = "Open_video";
            this.btn_openvideo.UseVisualStyleBackColor = true;
            this.btn_openvideo.Click += new System.EventHandler(this.btn_openvideo_Click);
            // 
            // btn_Stop_video
            // 
            this.btn_Stop_video.Location = new System.Drawing.Point(476, 15);
            this.btn_Stop_video.Name = "btn_Stop_video";
            this.btn_Stop_video.Size = new System.Drawing.Size(97, 38);
            this.btn_Stop_video.TabIndex = 42;
            this.btn_Stop_video.Text = "Stop";
            this.btn_Stop_video.UseVisualStyleBackColor = true;
            this.btn_Stop_video.Click += new System.EventHandler(this.btn_Stop_video_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "normal",
            "otsu",
            "negative",
            "equalization"});
            this.comboBox2.Location = new System.Drawing.Point(369, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 23);
            this.comboBox2.TabIndex = 43;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(1186, 12);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(28, 15);
            this.lbl_time.TabIndex = 44;
            this.lbl_time.Text = "***";
            // 
            // Process_btn
            // 
            this.Process_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_btn.Location = new System.Drawing.Point(994, 12);
            this.Process_btn.Name = "Process_btn";
            this.Process_btn.Size = new System.Drawing.Size(97, 38);
            this.Process_btn.TabIndex = 46;
            this.Process_btn.Text = "Process";
            this.Process_btn.UseVisualStyleBackColor = true;
            this.Process_btn.Click += new System.EventHandler(this.Process_btn_Click);
            // 
            // openfolder_btn
            // 
            this.openfolder_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openfolder_btn.Location = new System.Drawing.Point(658, 14);
            this.openfolder_btn.Margin = new System.Windows.Forms.Padding(4);
            this.openfolder_btn.Name = "openfolder_btn";
            this.openfolder_btn.Size = new System.Drawing.Size(146, 38);
            this.openfolder_btn.TabIndex = 45;
            this.openfolder_btn.Text = "Open_Folder";
            this.openfolder_btn.UseVisualStyleBackColor = true;
            this.openfolder_btn.Click += new System.EventHandler(this.openfolder_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(825, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 34);
            this.progressBar1.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1672, 1001);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Process_btn);
            this.Controls.Add(this.openfolder_btn);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_Stop_video);
            this.Controls.Add(this.btn_openvideo);
            this.Controls.Add(this.Canny_btn);
            this.Controls.Add(this.FindContours_btn);
            this.Controls.Add(this.Hough_Circles_btn);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_backward);
            this.Controls.Add(Change_btn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_error_diffusion);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_org);
            this.Controls.Add(this.Btn_undo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Result_H_B);
            this.Controls.Add(this.Result_B);
            this.Controls.Add(this.Result_H_G);
            this.Controls.Add(this.Result_G);
            this.Controls.Add(this.Result_H_R);
            this.Controls.Add(this.Result_R);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ResultImg);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.O_PhotoWH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.H_B_img);
            this.Controls.Add(this.O_B_Band);
            this.Controls.Add(this.H_G_img);
            this.Controls.Add(this.O_G_Band);
            this.Controls.Add(this.H_R_img);
            this.Controls.Add(this.O_R_Band);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.original_img);
            this.Controls.Add(this.OpenButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_R_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_G_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_B_Band)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_R_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_G_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_B_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_H_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_H_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_H_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox original_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox O_R_Band;
        private System.Windows.Forms.PictureBox O_G_Band;
        private System.Windows.Forms.PictureBox O_B_Band;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label O_PhotoWH;
        private System.Windows.Forms.PictureBox H_R_img;
        private System.Windows.Forms.PictureBox H_G_img;
        private System.Windows.Forms.PictureBox H_B_img;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label result_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Result_H_B;
        private System.Windows.Forms.PictureBox Result_B;
        private System.Windows.Forms.PictureBox Result_H_G;
        private System.Windows.Forms.PictureBox Result_G;
        private System.Windows.Forms.PictureBox Result_H_R;
        private System.Windows.Forms.PictureBox Result_R;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox ResultImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_maxium;
        private System.Windows.Forms.Button Btn_mean_value;
        private System.Windows.Forms.Button Btn_mean_weig;
        private System.Windows.Forms.Button Btn_undo;
        private System.Windows.Forms.Button btn_org;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Histogram_equ;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_Negative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Mean;
        private System.Windows.Forms.Button btn_Median;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Thresholding_Apply;
        private System.Windows.Forms.Button Thresholding_Change;
        private System.Windows.Forms.Button btn_Otsu;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Button btn_Rotate;
        private System.Windows.Forms.Button btn_Wrapping;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton small;
        private System.Windows.Forms.RadioButton big;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.TextBox resize_time;
        private System.Windows.Forms.Button btn_error_diffusion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Kernal_size;
        private System.Windows.Forms.Button Morph_close_btn;
        private System.Windows.Forms.Button Morph_open_btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Eroion_btn;
        private System.Windows.Forms.Button Dilation_btn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button CV_erosin;
        private System.Windows.Forms.Button CV_dilation;
        private System.Windows.Forms.Button btn_backward;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button Hough_Circles_btn;
        private System.Windows.Forms.Button FindContours_btn;
        private System.Windows.Forms.Button Canny_btn;
        private System.Windows.Forms.Button btn_openvideo;
        private System.Windows.Forms.Button btn_Stop_video;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button Process_btn;
        private System.Windows.Forms.Button openfolder_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

