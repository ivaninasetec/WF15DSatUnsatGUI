namespace GraphControls
{
    partial class ScatterXYControl
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.formsPlot_scatterXYControl = new ScottPlot.FormsPlot();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.button_Zoom_Dec_Y = new System.Windows.Forms.Button();
            this.button_Zoom_Inc_Y = new System.Windows.Forms.Button();
            this.button_ResetY = new System.Windows.Forms.Button();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Zoom_Dec_X = new System.Windows.Forms.Button();
            this.button_Zoom_Inc_X = new System.Windows.Forms.Button();
            this.button_ResetX = new System.Windows.Forms.Button();
            this.button_Extent = new System.Windows.Forms.Button();
            this.panel_Main.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.formsPlot_scatterXYControl);
            this.panel_Main.Controls.Add(this.panel_Left);
            this.panel_Main.Controls.Add(this.panel_Bottom);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(800, 450);
            this.panel_Main.TabIndex = 0;
            // 
            // formsPlot_scatterXYControl
            // 
            this.formsPlot_scatterXYControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot_scatterXYControl.Location = new System.Drawing.Point(20, 0);
            this.formsPlot_scatterXYControl.Name = "formsPlot_scatterXYControl";
            this.formsPlot_scatterXYControl.Size = new System.Drawing.Size(780, 430);
            this.formsPlot_scatterXYControl.TabIndex = 0;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Gray;
            this.panel_Left.Controls.Add(this.button_Zoom_Dec_Y);
            this.panel_Left.Controls.Add(this.button_Zoom_Inc_Y);
            this.panel_Left.Controls.Add(this.button_ResetY);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(20, 430);
            this.panel_Left.TabIndex = 0;
            // 
            // button_Zoom_Dec_Y
            // 
            this.button_Zoom_Dec_Y.BackColor = System.Drawing.Color.Black;
            this.button_Zoom_Dec_Y.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Zoom_Dec_Y.ForeColor = System.Drawing.Color.White;
            this.button_Zoom_Dec_Y.Location = new System.Drawing.Point(0, 65);
            this.button_Zoom_Dec_Y.Name = "button_Zoom_Dec_Y";
            this.button_Zoom_Dec_Y.Size = new System.Drawing.Size(20, 20);
            this.button_Zoom_Dec_Y.TabIndex = 2;
            this.button_Zoom_Dec_Y.Text = "-";
            this.button_Zoom_Dec_Y.UseVisualStyleBackColor = false;
            this.button_Zoom_Dec_Y.Click += new System.EventHandler(this.button_Zoom_Dec_Y_Click);
            // 
            // button_Zoom_Inc_Y
            // 
            this.button_Zoom_Inc_Y.BackColor = System.Drawing.Color.Black;
            this.button_Zoom_Inc_Y.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Zoom_Inc_Y.ForeColor = System.Drawing.Color.White;
            this.button_Zoom_Inc_Y.Location = new System.Drawing.Point(0, 40);
            this.button_Zoom_Inc_Y.Name = "button_Zoom_Inc_Y";
            this.button_Zoom_Inc_Y.Size = new System.Drawing.Size(20, 20);
            this.button_Zoom_Inc_Y.TabIndex = 1;
            this.button_Zoom_Inc_Y.Text = "+";
            this.button_Zoom_Inc_Y.UseVisualStyleBackColor = false;
            this.button_Zoom_Inc_Y.Click += new System.EventHandler(this.button_Zoom_Inc_Y_Click);
            // 
            // button_ResetY
            // 
            this.button_ResetY.BackColor = System.Drawing.Color.Black;
            this.button_ResetY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ResetY.ForeColor = System.Drawing.Color.White;
            this.button_ResetY.Location = new System.Drawing.Point(0, 0);
            this.button_ResetY.Name = "button_ResetY";
            this.button_ResetY.Size = new System.Drawing.Size(20, 20);
            this.button_ResetY.TabIndex = 0;
            this.button_ResetY.Text = "o";
            this.button_ResetY.UseVisualStyleBackColor = false;
            this.button_ResetY.Click += new System.EventHandler(this.button_ResetY_Click);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.Gray;
            this.panel_Bottom.Controls.Add(this.button_Extent);
            this.panel_Bottom.Controls.Add(this.button_Zoom_Dec_X);
            this.panel_Bottom.Controls.Add(this.button_Zoom_Inc_X);
            this.panel_Bottom.Controls.Add(this.button_ResetX);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 430);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(800, 20);
            this.panel_Bottom.TabIndex = 1;
            // 
            // button_Zoom_Dec_X
            // 
            this.button_Zoom_Dec_X.BackColor = System.Drawing.Color.Black;
            this.button_Zoom_Dec_X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Zoom_Dec_X.ForeColor = System.Drawing.Color.White;
            this.button_Zoom_Dec_X.Location = new System.Drawing.Point(85, 0);
            this.button_Zoom_Dec_X.Name = "button_Zoom_Dec_X";
            this.button_Zoom_Dec_X.Size = new System.Drawing.Size(20, 20);
            this.button_Zoom_Dec_X.TabIndex = 3;
            this.button_Zoom_Dec_X.Text = "-";
            this.button_Zoom_Dec_X.UseVisualStyleBackColor = false;
            this.button_Zoom_Dec_X.Click += new System.EventHandler(this.button_Zoom_Dec_X_Click);
            // 
            // button_Zoom_Inc_X
            // 
            this.button_Zoom_Inc_X.BackColor = System.Drawing.Color.Black;
            this.button_Zoom_Inc_X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Zoom_Inc_X.ForeColor = System.Drawing.Color.White;
            this.button_Zoom_Inc_X.Location = new System.Drawing.Point(60, 0);
            this.button_Zoom_Inc_X.Name = "button_Zoom_Inc_X";
            this.button_Zoom_Inc_X.Size = new System.Drawing.Size(20, 20);
            this.button_Zoom_Inc_X.TabIndex = 2;
            this.button_Zoom_Inc_X.Text = "+";
            this.button_Zoom_Inc_X.UseVisualStyleBackColor = false;
            this.button_Zoom_Inc_X.Click += new System.EventHandler(this.button_Zoom_Inc_X_Click);
            // 
            // button_ResetX
            // 
            this.button_ResetX.BackColor = System.Drawing.Color.Black;
            this.button_ResetX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ResetX.ForeColor = System.Drawing.Color.White;
            this.button_ResetX.Location = new System.Drawing.Point(20, 0);
            this.button_ResetX.Name = "button_ResetX";
            this.button_ResetX.Size = new System.Drawing.Size(20, 20);
            this.button_ResetX.TabIndex = 1;
            this.button_ResetX.Text = "o";
            this.button_ResetX.UseVisualStyleBackColor = false;
            this.button_ResetX.Click += new System.EventHandler(this.button_ResetX_Click);
            // 
            // button_Extent
            // 
            this.button_Extent.BackColor = System.Drawing.Color.Black;
            this.button_Extent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Extent.ForeColor = System.Drawing.Color.White;
            this.button_Extent.Location = new System.Drawing.Point(120, 0);
            this.button_Extent.Name = "button_Extent";
            this.button_Extent.Size = new System.Drawing.Size(60, 20);
            this.button_Extent.TabIndex = 4;
            this.button_Extent.Text = "Extent";
            this.button_Extent.UseVisualStyleBackColor = false;
            this.button_Extent.Click += new System.EventHandler(this.button_Extent_Click);
            // 
            // ScatterXYControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Main);
            this.Name = "ScatterXYControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.panel_Main.ResumeLayout(false);
            this.panel_Left.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private ScottPlot.FormsPlot formsPlot_scatterXYControl;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Zoom_Dec_Y;
        private System.Windows.Forms.Button button_Zoom_Inc_Y;
        private System.Windows.Forms.Button button_ResetY;
        private System.Windows.Forms.Button button_Zoom_Dec_X;
        private System.Windows.Forms.Button button_Zoom_Inc_X;
        private System.Windows.Forms.Button button_ResetX;
        private System.Windows.Forms.Button button_Extent;
    }
}
