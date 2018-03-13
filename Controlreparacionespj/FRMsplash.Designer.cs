namespace Controlreparacionespj
{
    partial class FRMsplash
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PB1 = new System.Windows.Forms.ProgressBar();
            this.lblpor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.White;
            this.PB1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PB1.Location = new System.Drawing.Point(79, 245);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(208, 22);
            this.PB1.TabIndex = 0;
            // 
            // lblpor
            // 
            this.lblpor.AutoSize = true;
            this.lblpor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpor.Location = new System.Drawing.Point(156, 281);
            this.lblpor.Name = "lblpor";
            this.lblpor.Size = new System.Drawing.Size(51, 21);
            this.lblpor.TabIndex = 1;
            this.lblpor.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Controlreparacionespj.Properties.Resources.screwdriver__1_;
            this.panel1.Location = new System.Drawing.Point(113, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 129);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Control de servicio técnico";
            // 
            // FRMsplash
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(370, 354);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblpor);
            this.Controls.Add(this.PB1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMsplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FRMsplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar PB1;
        private System.Windows.Forms.Label lblpor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}