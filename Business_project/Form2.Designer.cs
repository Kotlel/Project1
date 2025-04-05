namespace Business_project
{
    partial class Form2
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
            this.AddEvent_btn = new System.Windows.Forms.Button();
            this.Participants_txt = new System.Windows.Forms.TextBox();
            this.EventDate_txt = new System.Windows.Forms.TextBox();
            this.EventName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEvent_btn
            // 
            this.AddEvent_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddEvent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.AddEvent_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AddEvent_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddEvent_btn.Location = new System.Drawing.Point(117, 249);
            this.AddEvent_btn.Name = "AddEvent_btn";
            this.AddEvent_btn.Size = new System.Drawing.Size(220, 30);
            this.AddEvent_btn.TabIndex = 0;
            this.AddEvent_btn.Text = "Add Event";
            this.AddEvent_btn.UseVisualStyleBackColor = false;
            this.AddEvent_btn.Click += new System.EventHandler(this.AddEvent_btn_Click);
            // 
            // Participants_txt
            // 
            this.Participants_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Participants_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Participants_txt.Location = new System.Drawing.Point(117, 205);
            this.Participants_txt.Multiline = true;
            this.Participants_txt.Name = "Participants_txt";
            this.Participants_txt.Size = new System.Drawing.Size(220, 38);
            this.Participants_txt.TabIndex = 1;
            // 
            // EventDate_txt
            // 
            this.EventDate_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EventDate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EventDate_txt.Location = new System.Drawing.Point(117, 145);
            this.EventDate_txt.Multiline = true;
            this.EventDate_txt.Name = "EventDate_txt";
            this.EventDate_txt.Size = new System.Drawing.Size(220, 38);
            this.EventDate_txt.TabIndex = 2;
            // 
            // EventName_txt
            // 
            this.EventName_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EventName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EventName_txt.Location = new System.Drawing.Point(117, 85);
            this.EventName_txt.Multiline = true;
            this.EventName_txt.Name = "EventName_txt";
            this.EventName_txt.Size = new System.Drawing.Size(220, 38);
            this.EventName_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(161, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "VirtualMeet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Title";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Participants";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Business_project.Properties.Resources.Screenshot_2025_04_04_235622;
            this.pictureBox1.Location = new System.Drawing.Point(117, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(443, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EventName_txt);
            this.Controls.Add(this.EventDate_txt);
            this.Controls.Add(this.Participants_txt);
            this.Controls.Add(this.AddEvent_btn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEvent_btn;
        private System.Windows.Forms.TextBox Participants_txt;
        private System.Windows.Forms.TextBox EventDate_txt;
        private System.Windows.Forms.TextBox EventName_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}