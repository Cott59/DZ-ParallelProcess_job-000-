namespace ParallelProcessDemo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCounDown = new System.Windows.Forms.Button();
            this.lbCountDown001 = new System.Windows.Forms.Label();
            this.tbIput = new System.Windows.Forms.TextBox();
            this.lbCountDown002 = new System.Windows.Forms.Label();
            this.lbCountDown003 = new System.Windows.Forms.Label();
            this.lbStatusTask001 = new System.Windows.Forms.Label();
            this.lbStatusTask002 = new System.Windows.Forms.Label();
            this.lbStatusTask003 = new System.Windows.Forms.Label();
            this.btnShowStatus = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCounDown
            // 
            this.btnCounDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCounDown.Location = new System.Drawing.Point(13, 27);
            this.btnCounDown.Name = "btnCounDown";
            this.btnCounDown.Size = new System.Drawing.Size(189, 88);
            this.btnCounDown.TabIndex = 0;
            this.btnCounDown.Text = "StartCountDown";
            this.btnCounDown.UseVisualStyleBackColor = true;
            this.btnCounDown.Click += new System.EventHandler(this.btnCounDown_Click);
            // 
            // lbCountDown001
            // 
            this.lbCountDown001.AutoSize = true;
            this.lbCountDown001.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountDown001.Location = new System.Drawing.Point(249, 27);
            this.lbCountDown001.Name = "lbCountDown001";
            this.lbCountDown001.Size = new System.Drawing.Size(83, 91);
            this.lbCountDown001.TabIndex = 1;
            this.lbCountDown001.Text = "_";
            // 
            // tbIput
            // 
            this.tbIput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIput.Location = new System.Drawing.Point(12, 343);
            this.tbIput.Multiline = true;
            this.tbIput.Name = "tbIput";
            this.tbIput.Size = new System.Drawing.Size(289, 85);
            this.tbIput.TabIndex = 2;
            // 
            // lbCountDown002
            // 
            this.lbCountDown002.AutoSize = true;
            this.lbCountDown002.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountDown002.Location = new System.Drawing.Point(458, 27);
            this.lbCountDown002.Name = "lbCountDown002";
            this.lbCountDown002.Size = new System.Drawing.Size(83, 91);
            this.lbCountDown002.TabIndex = 1;
            this.lbCountDown002.Text = "_";
            // 
            // lbCountDown003
            // 
            this.lbCountDown003.AutoSize = true;
            this.lbCountDown003.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountDown003.Location = new System.Drawing.Point(690, 27);
            this.lbCountDown003.Name = "lbCountDown003";
            this.lbCountDown003.Size = new System.Drawing.Size(83, 91);
            this.lbCountDown003.TabIndex = 1;
            this.lbCountDown003.Text = "_";
            // 
            // lbStatusTask001
            // 
            this.lbStatusTask001.AutoSize = true;
            this.lbStatusTask001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatusTask001.Location = new System.Drawing.Point(275, 144);
            this.lbStatusTask001.Name = "lbStatusTask001";
            this.lbStatusTask001.Size = new System.Drawing.Size(57, 24);
            this.lbStatusTask001.TabIndex = 3;
            this.lbStatusTask001.Text = "status";
            // 
            // lbStatusTask002
            // 
            this.lbStatusTask002.AutoSize = true;
            this.lbStatusTask002.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatusTask002.Location = new System.Drawing.Point(470, 148);
            this.lbStatusTask002.Name = "lbStatusTask002";
            this.lbStatusTask002.Size = new System.Drawing.Size(57, 24);
            this.lbStatusTask002.TabIndex = 3;
            this.lbStatusTask002.Text = "status";
            // 
            // lbStatusTask003
            // 
            this.lbStatusTask003.AutoSize = true;
            this.lbStatusTask003.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatusTask003.Location = new System.Drawing.Point(702, 148);
            this.lbStatusTask003.Name = "lbStatusTask003";
            this.lbStatusTask003.Size = new System.Drawing.Size(57, 24);
            this.lbStatusTask003.TabIndex = 3;
            this.lbStatusTask003.Text = "status";
            // 
            // btnShowStatus
            // 
            this.btnShowStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStatus.Location = new System.Drawing.Point(13, 144);
            this.btnShowStatus.Name = "btnShowStatus";
            this.btnShowStatus.Size = new System.Drawing.Size(205, 88);
            this.btnShowStatus.TabIndex = 0;
            this.btnShowStatus.Text = "ShowStatuses";
            this.btnShowStatus.UseVisualStyleBackColor = true;
            this.btnShowStatus.Click += new System.EventHandler(this.btnShowStatus_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_1.Enabled = false;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_1.Location = new System.Drawing.Point(265, 183);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 7;
            this.btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_2.Enabled = false;
            this.btn_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_2.Location = new System.Drawing.Point(466, 183);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 8;
            this.btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_3.Enabled = false;
            this.btn_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_3.Location = new System.Drawing.Point(698, 183);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 9;
            this.btn_3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbStatusTask003);
            this.Controls.Add(this.lbStatusTask002);
            this.Controls.Add(this.lbStatusTask001);
            this.Controls.Add(this.tbIput);
            this.Controls.Add(this.lbCountDown003);
            this.Controls.Add(this.lbCountDown002);
            this.Controls.Add(this.lbCountDown001);
            this.Controls.Add(this.btnShowStatus);
            this.Controls.Add(this.btnCounDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCounDown;
        private System.Windows.Forms.Label lbCountDown001;
        private System.Windows.Forms.TextBox tbIput;
        private System.Windows.Forms.Label lbCountDown002;
        private System.Windows.Forms.Label lbCountDown003;
        private System.Windows.Forms.Label lbStatusTask001;
        private System.Windows.Forms.Label lbStatusTask002;
        private System.Windows.Forms.Label lbStatusTask003;
        private System.Windows.Forms.Button btnShowStatus;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
    }
}

