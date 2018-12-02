namespace WindowsFormsApplication1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sistema_info = new System.Windows.Forms.Button();
            this.btn_status = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_sistema_info);
            this.panel1.Controls.Add(this.btn_status);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 346);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bem-Vindo ao Volta Battery";
            // 
            // btn_sistema_info
            // 
            this.btn_sistema_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.btn_sistema_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sistema_info.ForeColor = System.Drawing.Color.White;
            this.btn_sistema_info.Image = global::WindowsFormsApplication1.Properties.Resources.info;
            this.btn_sistema_info.Location = new System.Drawing.Point(377, 107);
            this.btn_sistema_info.Name = "btn_sistema_info";
            this.btn_sistema_info.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_sistema_info.Size = new System.Drawing.Size(358, 216);
            this.btn_sistema_info.TabIndex = 4;
            this.btn_sistema_info.Text = "  Informações \r\ndo \r\nSistema";
            this.btn_sistema_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sistema_info.UseVisualStyleBackColor = false;
            this.btn_sistema_info.Click += new System.EventHandler(this.btn_sistema_info_Click);
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.btn_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_status.ForeColor = System.Drawing.Color.White;
            this.btn_status.Image = global::WindowsFormsApplication1.Properties.Resources.chart;
            this.btn_status.Location = new System.Drawing.Point(12, 107);
            this.btn_status.Name = "btn_status";
            this.btn_status.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btn_status.Size = new System.Drawing.Size(358, 216);
            this.btn_status.TabIndex = 2;
            this.btn_status.Text = "Status";
            this.btn_status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_status.UseVisualStyleBackColor = false;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(747, 349);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Volta Battery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_sistema_info;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

