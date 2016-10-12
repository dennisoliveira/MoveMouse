namespace MoveMouse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMouseMove = new System.Windows.Forms.Button();
            this.btnStopMouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMouseMove
            // 
            this.btnMouseMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMouseMove.Image")));
            this.btnMouseMove.Location = new System.Drawing.Point(12, 12);
            this.btnMouseMove.Name = "btnMouseMove";
            this.btnMouseMove.Size = new System.Drawing.Size(120, 80);
            this.btnMouseMove.TabIndex = 1;
            this.btnMouseMove.Text = "Iniciar movimentação do Mouse";
            this.btnMouseMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMouseMove.UseVisualStyleBackColor = true;
            this.btnMouseMove.Click += new System.EventHandler(this.btnMouseMove_Click);
            // 
            // btnStopMouse
            // 
            this.btnStopMouse.Image = ((System.Drawing.Image)(resources.GetObject("btnStopMouse.Image")));
            this.btnStopMouse.Location = new System.Drawing.Point(138, 12);
            this.btnStopMouse.Name = "btnStopMouse";
            this.btnStopMouse.Size = new System.Drawing.Size(120, 80);
            this.btnStopMouse.TabIndex = 2;
            this.btnStopMouse.Text = "Parar movimentação do Mouse";
            this.btnStopMouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStopMouse.UseVisualStyleBackColor = true;
            this.btnStopMouse.Click += new System.EventHandler(this.btnStopMouse_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 105);
            this.Controls.Add(this.btnStopMouse);
            this.Controls.Add(this.btnMouseMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move Mouse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnMouseMove;
        private System.Windows.Forms.Button btnStopMouse;
    }
}

