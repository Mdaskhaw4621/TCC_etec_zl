namespace WindowsFormsApplication1
{
    partial class frm_Aguarde
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
            this.metroProgressSpinner_Loading = new MetroFramework.Controls.MetroProgressSpinner();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroProgressSpinner_Loading
            // 
            this.metroProgressSpinner_Loading.Location = new System.Drawing.Point(92, 23);
            this.metroProgressSpinner_Loading.Maximum = 100;
            this.metroProgressSpinner_Loading.Name = "metroProgressSpinner_Loading";
            this.metroProgressSpinner_Loading.Size = new System.Drawing.Size(188, 188);
            this.metroProgressSpinner_Loading.Style = MetroFramework.MetroColorStyle.White;
            this.metroProgressSpinner_Loading.TabIndex = 0;
            this.metroProgressSpinner_Loading.UseCustomBackColor = true;
            this.metroProgressSpinner_Loading.UseSelectable = true;
            this.metroProgressSpinner_Loading.UseStyleColors = true;
            this.metroProgressSpinner_Loading.UseWaitCursor = true;
            this.metroProgressSpinner_Loading.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(142, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por Favor";
            this.label1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
           
            // 
            // frm_Aguarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(372, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroProgressSpinner_Loading);
            this.Name = "frm_Aguarde";
            this.Text = "Aguarde...";
            this.UseWaitCursor = true;
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner_Loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;

    }
}