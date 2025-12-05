
namespace Project_Draft
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StandardBtn = new System.Windows.Forms.Button();
            this.DeluxeBtn = new System.Windows.Forms.Button();
            this.SuiteBtn = new System.Windows.Forms.Button();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1871, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imperial Hotel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 987);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Room Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.StandardBtn);
            this.flowLayoutPanel1.Controls.Add(this.DeluxeBtn);
            this.flowLayoutPanel1.Controls.Add(this.SuiteBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 309);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // StandardBtn
            // 
            this.StandardBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StandardBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StandardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StandardBtn.Location = new System.Drawing.Point(3, 3);
            this.StandardBtn.Name = "StandardBtn";
            this.StandardBtn.Size = new System.Drawing.Size(247, 82);
            this.StandardBtn.TabIndex = 0;
            this.StandardBtn.Text = "Standard Room";
            this.StandardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StandardBtn.UseVisualStyleBackColor = false;
            this.StandardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeluxeBtn
            // 
            this.DeluxeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeluxeBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeluxeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeluxeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeluxeBtn.Location = new System.Drawing.Point(3, 91);
            this.DeluxeBtn.Name = "DeluxeBtn";
            this.DeluxeBtn.Size = new System.Drawing.Size(247, 82);
            this.DeluxeBtn.TabIndex = 1;
            this.DeluxeBtn.Text = "Deluxe Room";
            this.DeluxeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeluxeBtn.UseVisualStyleBackColor = false;
            this.DeluxeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SuiteBtn
            // 
            this.SuiteBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SuiteBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuiteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SuiteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuiteBtn.Location = new System.Drawing.Point(3, 179);
            this.SuiteBtn.Name = "SuiteBtn";
            this.SuiteBtn.Size = new System.Drawing.Size(247, 82);
            this.SuiteBtn.TabIndex = 2;
            this.SuiteBtn.Text = "Suite Room";
            this.SuiteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuiteBtn.UseVisualStyleBackColor = false;
            this.SuiteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // RoomPanel
            // 
            this.RoomPanel.Location = new System.Drawing.Point(260, 75);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(1901, 968);
            this.RoomPanel.TabIndex = 2;
            this.RoomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RoomPanel_Paint);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome.Location = new System.Drawing.Point(603, 13);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(0, 25);
            this.Welcome.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1871, 1055);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home Pgae";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button StandardBtn;
        private System.Windows.Forms.Button DeluxeBtn;
        private System.Windows.Forms.Button SuiteBtn;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label Welcome;
    }
}