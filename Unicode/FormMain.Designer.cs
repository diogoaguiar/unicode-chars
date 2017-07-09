namespace Unicode
{
    partial class FormMain
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
            this.btn_copy = new System.Windows.Forms.Button();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_preview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(97, 31);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(39, 6);
            this.tb_code.MaxLength = 4;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(133, 20);
            this.tb_code.TabIndex = 1;
            this.tb_code.TextChanged += new System.EventHandler(this.tb_code_TextChanged);
            this.tb_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_code_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "U+";
            // 
            // lb_status
            // 
            this.lb_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(51, 36);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(40, 13);
            this.lb_status.TabIndex = 3;
            this.lb_status.Text = "Copied";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_status.Visible = false;
            // 
            // lb_preview
            // 
            this.lb_preview.AutoSize = true;
            this.lb_preview.Location = new System.Drawing.Point(12, 36);
            this.lb_preview.Name = "lb_preview";
            this.lb_preview.Size = new System.Drawing.Size(0, 13);
            this.lb_preview.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btn_copy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(184, 66);
            this.Controls.Add(this.lb_preview);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Unicode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_preview;
    }
}

