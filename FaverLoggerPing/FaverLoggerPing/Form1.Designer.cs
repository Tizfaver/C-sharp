
namespace FaverLoggerPing
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_dir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_host = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_start_ping = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkbox_view_failure = new System.Windows.Forms.CheckBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_stop_pinging = new System.Windows.Forms.Button();
            this.numeric_time = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.checkbox_write = new System.Windows.Forms.CheckBox();
            this.checkbox_write_failure = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_time)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(12, 48);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(251, 20);
            this.txt_dir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Here the directory (only dir, no file name):";
            // 
            // btn_save_dir
            // 
            this.btn_save_dir.Location = new System.Drawing.Point(269, 47);
            this.btn_save_dir.Name = "btn_save_dir";
            this.btn_save_dir.Size = new System.Drawing.Size(52, 22);
            this.btn_save_dir.TabIndex = 2;
            this.btn_save_dir.Text = "save";
            this.btn_save_dir.UseVisualStyleBackColor = true;
            this.btn_save_dir.Click += new System.EventHandler(this.btn_save_dir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FAVER PING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_save_host
            // 
            this.btn_save_host.Location = new System.Drawing.Point(269, 86);
            this.btn_save_host.Name = "btn_save_host";
            this.btn_save_host.Size = new System.Drawing.Size(52, 22);
            this.btn_save_host.TabIndex = 6;
            this.btn_save_host.Text = "save";
            this.btn_save_host.UseVisualStyleBackColor = true;
            this.btn_save_host.Click += new System.EventHandler(this.btn_save_host_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert Here the Host to ping:";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(12, 87);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(251, 20);
            this.txt_host.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(267, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "save in the config file";
            // 
            // btn_start_ping
            // 
            this.btn_start_ping.Location = new System.Drawing.Point(12, 160);
            this.btn_start_ping.Name = "btn_start_ping";
            this.btn_start_ping.Size = new System.Drawing.Size(300, 46);
            this.btn_start_ping.TabIndex = 8;
            this.btn_start_ping.Text = "START PINGING";
            this.btn_start_ping.UseVisualStyleBackColor = true;
            this.btn_start_ping.Click += new System.EventHandler(this.btn_start_ping_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log:";
            // 
            // checkbox_view_failure
            // 
            this.checkbox_view_failure.AutoSize = true;
            this.checkbox_view_failure.Checked = true;
            this.checkbox_view_failure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_view_failure.Location = new System.Drawing.Point(44, 246);
            this.checkbox_view_failure.Name = "checkbox_view_failure";
            this.checkbox_view_failure.Size = new System.Drawing.Size(98, 17);
            this.checkbox_view_failure.TabIndex = 10;
            this.checkbox_view_failure.Text = "Only Failure log";
            this.checkbox_view_failure.UseVisualStyleBackColor = true;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(15, 263);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_log.Size = new System.Drawing.Size(294, 246);
            this.txt_log.TabIndex = 11;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 6);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(77, 23);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset config";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(39, 212);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(113, 20);
            this.lbl_status.TabIndex = 13;
            this.lbl_status.Text = "NOT PINGING";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_stop_pinging
            // 
            this.btn_stop_pinging.Location = new System.Drawing.Point(214, 212);
            this.btn_stop_pinging.Name = "btn_stop_pinging";
            this.btn_stop_pinging.Size = new System.Drawing.Size(94, 23);
            this.btn_stop_pinging.TabIndex = 14;
            this.btn_stop_pinging.Text = "Stop and Save";
            this.btn_stop_pinging.UseVisualStyleBackColor = true;
            this.btn_stop_pinging.Click += new System.EventHandler(this.btn_stop_pinging_Click);
            // 
            // numeric_time
            // 
            this.numeric_time.Location = new System.Drawing.Point(154, 113);
            this.numeric_time.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_time.Name = "numeric_time";
            this.numeric_time.Size = new System.Drawing.Size(109, 20);
            this.numeric_time.TabIndex = 15;
            this.numeric_time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Delay Ping Time (seconds):";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(214, 237);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 23);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear View Log";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // checkbox_write
            // 
            this.checkbox_write.AutoSize = true;
            this.checkbox_write.Checked = true;
            this.checkbox_write.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_write.Location = new System.Drawing.Point(15, 137);
            this.checkbox_write.Name = "checkbox_write";
            this.checkbox_write.Size = new System.Drawing.Size(113, 17);
            this.checkbox_write.TabIndex = 18;
            this.checkbox_write.Text = "Write in the file log";
            this.checkbox_write.UseVisualStyleBackColor = true;
            this.checkbox_write.CheckedChanged += new System.EventHandler(this.checkbox_write_CheckedChanged);
            // 
            // checkbox_write_failure
            // 
            this.checkbox_write_failure.AutoSize = true;
            this.checkbox_write_failure.Checked = true;
            this.checkbox_write_failure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_write_failure.Location = new System.Drawing.Point(134, 137);
            this.checkbox_write_failure.Name = "checkbox_write_failure";
            this.checkbox_write_failure.Size = new System.Drawing.Size(124, 17);
            this.checkbox_write_failure.TabIndex = 19;
            this.checkbox_write_failure.Text = "Save only Failure log";
            this.checkbox_write_failure.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 514);
            this.Controls.Add(this.checkbox_write_failure);
            this.Controls.Add(this.checkbox_write);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_time);
            this.Controls.Add(this.btn_stop_pinging);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.checkbox_view_failure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_start_ping);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save_host);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save_dir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 553);
            this.MinimumSize = new System.Drawing.Size(340, 553);
            this.Name = "Form1";
            this.Text = "Faver Ping 1.3";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save_dir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save_host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_start_ping;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkbox_view_failure;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_stop_pinging;
        private System.Windows.Forms.NumericUpDown numeric_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox checkbox_write;
        private System.Windows.Forms.CheckBox checkbox_write_failure;
    }
}

