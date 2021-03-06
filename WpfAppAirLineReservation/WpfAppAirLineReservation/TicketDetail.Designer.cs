﻿namespace WpfAppAirLineReservation
{
    partial class TicketDetail
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EconomyClassButton = new System.Windows.Forms.Button();
            this.BusinessClassButton = new System.Windows.Forms.Button();
            this.FirstClassButton = new System.Windows.Forms.Button();
            this.ArrivalPlaceLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeLabel = new System.Windows.Forms.Label();
            this.FlyTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeparturePlaceLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "出發";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(149, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "飛行時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(293, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "抵達";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(492, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭等艙";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(597, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "商務艙";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(707, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "經濟艙";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.EconomyClassButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BusinessClassButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FirstClassButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ArrivalPlaceLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ArrivalTimeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FlyTimeLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DeparturePlaceLabel);
            this.groupBox1.Controls.Add(this.DepartureTimeLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "航空公司";
            // 
            // EconomyClassButton
            // 
            this.EconomyClassButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EconomyClassButton.Location = new System.Drawing.Point(699, 59);
            this.EconomyClassButton.Name = "EconomyClassButton";
            this.EconomyClassButton.Size = new System.Drawing.Size(97, 52);
            this.EconomyClassButton.TabIndex = 8;
            this.EconomyClassButton.UseVisualStyleBackColor = false;
            // 
            // BusinessClassButton
            // 
            this.BusinessClassButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BusinessClassButton.Location = new System.Drawing.Point(591, 59);
            this.BusinessClassButton.Name = "BusinessClassButton";
            this.BusinessClassButton.Size = new System.Drawing.Size(92, 52);
            this.BusinessClassButton.TabIndex = 7;
            this.BusinessClassButton.UseVisualStyleBackColor = false;
            // 
            // FirstClassButton
            // 
            this.FirstClassButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstClassButton.Location = new System.Drawing.Point(483, 59);
            this.FirstClassButton.Name = "FirstClassButton";
            this.FirstClassButton.Size = new System.Drawing.Size(89, 52);
            this.FirstClassButton.TabIndex = 6;
            this.FirstClassButton.UseVisualStyleBackColor = false;
            // 
            // ArrivalPlaceLabel
            // 
            this.ArrivalPlaceLabel.AutoSize = true;
            this.ArrivalPlaceLabel.Location = new System.Drawing.Point(280, 92);
            this.ArrivalPlaceLabel.Name = "ArrivalPlaceLabel";
            this.ArrivalPlaceLabel.Size = new System.Drawing.Size(88, 12);
            this.ArrivalPlaceLabel.TabIndex = 5;
            this.ArrivalPlaceLabel.Text = "ArrivalPlaceLabel";
            // 
            // ArrivalTimeLabel
            // 
            this.ArrivalTimeLabel.AutoSize = true;
            this.ArrivalTimeLabel.Location = new System.Drawing.Point(280, 69);
            this.ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            this.ArrivalTimeLabel.Size = new System.Drawing.Size(88, 12);
            this.ArrivalTimeLabel.TabIndex = 4;
            this.ArrivalTimeLabel.Text = "ArrivalTimeLabel";
            // 
            // FlyTimeLabel
            // 
            this.FlyTimeLabel.AutoSize = true;
            this.FlyTimeLabel.Location = new System.Drawing.Point(169, 68);
            this.FlyTimeLabel.Name = "FlyTimeLabel";
            this.FlyTimeLabel.Size = new System.Drawing.Size(70, 12);
            this.FlyTimeLabel.TabIndex = 3;
            this.FlyTimeLabel.Text = "FlyTimeLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "依官方最終核准為主";
            // 
            // DeparturePlaceLabel
            // 
            this.DeparturePlaceLabel.AutoSize = true;
            this.DeparturePlaceLabel.Location = new System.Drawing.Point(30, 86);
            this.DeparturePlaceLabel.Name = "DeparturePlaceLabel";
            this.DeparturePlaceLabel.Size = new System.Drawing.Size(101, 12);
            this.DeparturePlaceLabel.TabIndex = 1;
            this.DeparturePlaceLabel.Text = "DeparturePlaceLabel";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(30, 63);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(101, 12);
            this.DepartureTimeLabel.TabIndex = 0;
            this.DepartureTimeLabel.Text = "DepartureTimeLabel";
            // 
            // TicketDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketDetail";
            this.Size = new System.Drawing.Size(896, 192);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DeparturePlaceLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ArrivalTimeLabel;
        private System.Windows.Forms.Label FlyTimeLabel;
        private System.Windows.Forms.Label ArrivalPlaceLabel;
        private System.Windows.Forms.Button EconomyClassButton;
        private System.Windows.Forms.Button BusinessClassButton;
        private System.Windows.Forms.Button FirstClassButton;
    }
}
