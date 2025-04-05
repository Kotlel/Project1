namespace Business_project
{
    partial class Form4
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilterId = new System.Windows.Forms.Button();
            this.buttonFilterName = new System.Windows.Forms.Button();
            this.buttonFilterDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(331, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "VirtualMeet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Business_project.Properties.Resources.Screenshot_2025_04_04_235622;
            this.pictureBox1.Location = new System.Drawing.Point(287, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(281, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filters";
            // 
            // buttonFilterId
            // 
            this.buttonFilterId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(106)))), ((int)(((byte)(229)))));
            this.buttonFilterId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilterId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFilterId.Location = new System.Drawing.Point(287, 175);
            this.buttonFilterId.Name = "buttonFilterId";
            this.buttonFilterId.Size = new System.Drawing.Size(211, 35);
            this.buttonFilterId.TabIndex = 15;
            this.buttonFilterId.Text = "Filter by ID";
            this.buttonFilterId.UseVisualStyleBackColor = false;
            // 
            // buttonFilterName
            // 
            this.buttonFilterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(106)))), ((int)(((byte)(229)))));
            this.buttonFilterName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFilterName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFilterName.Location = new System.Drawing.Point(287, 216);
            this.buttonFilterName.Name = "buttonFilterName";
            this.buttonFilterName.Size = new System.Drawing.Size(211, 35);
            this.buttonFilterName.TabIndex = 16;
            this.buttonFilterName.Text = "Filter by Name";
            this.buttonFilterName.UseVisualStyleBackColor = false;
            // 
            // buttonFilterDate
            // 
            this.buttonFilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(106)))), ((int)(((byte)(229)))));
            this.buttonFilterDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFilterDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFilterDate.Location = new System.Drawing.Point(287, 257);
            this.buttonFilterDate.Name = "buttonFilterDate";
            this.buttonFilterDate.Size = new System.Drawing.Size(211, 35);
            this.buttonFilterDate.TabIndex = 17;
            this.buttonFilterDate.Text = "Filter by Date";
            this.buttonFilterDate.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFilterDate);
            this.Controls.Add(this.buttonFilterName);
            this.Controls.Add(this.buttonFilterId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilterId;
        private System.Windows.Forms.Button buttonFilterName;
        private System.Windows.Forms.Button buttonFilterDate;
    }
}