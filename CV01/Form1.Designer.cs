namespace CV01
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.BtnFill = new System.Windows.Forms.Button();
            this.BtnModus = new System.Windows.Forms.Button();
            this.LblArray = new System.Windows.Forms.Label();
            this.LblModus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFill
            // 
            this.BtnFill.Location = new System.Drawing.Point(12, 12);
            this.BtnFill.Name = "BtnFill";
            this.BtnFill.Size = new System.Drawing.Size(75, 23);
            this.BtnFill.TabIndex = 0;
            this.BtnFill.Text = "Refill array";
            this.BtnFill.UseVisualStyleBackColor = true;
            this.BtnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // BtnModus
            // 
            this.BtnModus.Location = new System.Drawing.Point(113, 12);
            this.BtnModus.Name = "BtnModus";
            this.BtnModus.Size = new System.Drawing.Size(75, 23);
            this.BtnModus.TabIndex = 1;
            this.BtnModus.Text = "Modus";
            this.BtnModus.UseVisualStyleBackColor = true;
            this.BtnModus.Click += new System.EventHandler(this.BtnModus_Click);
            // 
            // LblArray
            // 
            this.LblArray.AutoSize = true;
            this.LblArray.Location = new System.Drawing.Point(223, 22);
            this.LblArray.Name = "LblArray";
            this.LblArray.Size = new System.Drawing.Size(36, 13);
            this.LblArray.TabIndex = 2;
            this.LblArray.Text = "Empty";
            // 
            // LblModus
            // 
            this.LblModus.AutoSize = true;
            this.LblModus.Location = new System.Drawing.Point(226, 55);
            this.LblModus.Name = "LblModus";
            this.LblModus.Size = new System.Drawing.Size(0, 13);
            this.LblModus.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblModus);
            this.Controls.Add(this.LblArray);
            this.Controls.Add(this.BtnModus);
            this.Controls.Add(this.BtnFill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Button BtnModus;
        private System.Windows.Forms.Label LblArray;
        private System.Windows.Forms.Label LblModus;
    }
}

