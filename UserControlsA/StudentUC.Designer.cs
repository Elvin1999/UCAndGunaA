namespace UserControlsA
{
    partial class StudentUC
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
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.specialityLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(96, 43);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(79, 29);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "label1";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(181, 43);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(79, 29);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "label1";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(291, 43);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(79, 29);
            this.ageLbl.TabIndex = 0;
            this.ageLbl.Text = "label1";
            // 
            // specialityLbl
            // 
            this.specialityLbl.AutoSize = true;
            this.specialityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialityLbl.Location = new System.Drawing.Point(418, 43);
            this.specialityLbl.Name = "specialityLbl";
            this.specialityLbl.Size = new System.Drawing.Size(79, 29);
            this.specialityLbl.TabIndex = 0;
            this.specialityLbl.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.specialityLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(648, 109);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label specialityLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
