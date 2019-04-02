namespace Particle {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxDraw = new System.Windows.Forms.PictureBox();
            this.tmr17 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.numBirthSize = new System.Windows.Forms.NumericUpDown();
            this.lable0 = new System.Windows.Forms.Label();
            this.numMaxDxRatio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numDecreaseRatio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDraw)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDxRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecreaseRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDraw
            // 
            this.pbxDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDraw.Location = new System.Drawing.Point(0, 0);
            this.pbxDraw.Name = "pbxDraw";
            this.pbxDraw.Size = new System.Drawing.Size(819, 661);
            this.pbxDraw.TabIndex = 0;
            this.pbxDraw.TabStop = false;
            this.pbxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxDraw_Paint);
            this.pbxDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxDraw_MouseMove);
            // 
            // tmr17
            // 
            this.tmr17.Enabled = true;
            this.tmr17.Interval = 10;
            this.tmr17.Tick += new System.EventHandler(this.tmr17_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lable0);
            this.panel1.Controls.Add(this.numDownSpeed);
            this.panel1.Controls.Add(this.numDecreaseRatio);
            this.panel1.Controls.Add(this.numMaxDxRatio);
            this.panel1.Controls.Add(this.numBirthSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(819, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 661);
            this.panel1.TabIndex = 1;
            // 
            // numBirthSize
            // 
            this.numBirthSize.DecimalPlaces = 1;
            this.numBirthSize.Location = new System.Drawing.Point(125, 12);
            this.numBirthSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBirthSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBirthSize.Name = "numBirthSize";
            this.numBirthSize.Size = new System.Drawing.Size(61, 21);
            this.numBirthSize.TabIndex = 0;
            this.numBirthSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lable0
            // 
            this.lable0.AutoSize = true;
            this.lable0.Location = new System.Drawing.Point(6, 14);
            this.lable0.Name = "lable0";
            this.lable0.Size = new System.Drawing.Size(59, 12);
            this.lable0.TabIndex = 1;
            this.lable0.Text = "Birth Size";
            // 
            // numMaxDxRatio
            // 
            this.numMaxDxRatio.DecimalPlaces = 1;
            this.numMaxDxRatio.Location = new System.Drawing.Point(125, 39);
            this.numMaxDxRatio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxDxRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxDxRatio.Name = "numMaxDxRatio";
            this.numMaxDxRatio.Size = new System.Drawing.Size(61, 21);
            this.numMaxDxRatio.TabIndex = 0;
            this.numMaxDxRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max dx Ratio";
            // 
            // numDecreaseRatio
            // 
            this.numDecreaseRatio.DecimalPlaces = 1;
            this.numDecreaseRatio.Location = new System.Drawing.Point(125, 66);
            this.numDecreaseRatio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDecreaseRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDecreaseRatio.Name = "numDecreaseRatio";
            this.numDecreaseRatio.Size = new System.Drawing.Size(61, 21);
            this.numDecreaseRatio.TabIndex = 0;
            this.numDecreaseRatio.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decrease Ratio";
            // 
            // numDownSpeed
            // 
            this.numDownSpeed.DecimalPlaces = 1;
            this.numDownSpeed.Location = new System.Drawing.Point(125, 93);
            this.numDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDownSpeed.Name = "numDownSpeed";
            this.numDownSpeed.Size = new System.Drawing.Size(61, 21);
            this.numDownSpeed.TabIndex = 0;
            this.numDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Down Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 661);
            this.Controls.Add(this.pbxDraw);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDraw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDxRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDecreaseRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDraw;
        private System.Windows.Forms.Timer tmr17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lable0;
        private System.Windows.Forms.NumericUpDown numBirthSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDownSpeed;
        private System.Windows.Forms.NumericUpDown numDecreaseRatio;
        private System.Windows.Forms.NumericUpDown numMaxDxRatio;
    }
}

