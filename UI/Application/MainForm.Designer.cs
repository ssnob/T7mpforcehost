
namespace ExternalTestingUtility
{
    partial class MainForm
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
            this.ControlContents = new System.Windows.Forms.Panel();
            this.InnerForm = new Refract.UI.Core.Controls.CBorderedForm();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.InnerForm.ControlContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlContents
            // 
            this.ControlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlContents.Location = new System.Drawing.Point(0, 32);
            this.ControlContents.Name = "ControlContents";
            this.ControlContents.Size = new System.Drawing.Size(796, 414);
            this.ControlContents.TabIndex = 1;
            this.ControlContents.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerForm_ControlContents_Paint);
            // 
            // InnerForm
            // 
            this.InnerForm.BackColor = System.Drawing.Color.Crimson;
            // 
            // InnerForm.ControlContents
            // 
            this.InnerForm.ControlContents.Controls.Add(this.button2);
            this.InnerForm.ControlContents.Controls.Add(this.button1);
            this.InnerForm.ControlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerForm.ControlContents.Enabled = true;
            this.InnerForm.ControlContents.Location = new System.Drawing.Point(0, 32);
            this.InnerForm.ControlContents.Name = "ControlContents";
            this.InnerForm.ControlContents.Size = new System.Drawing.Size(241, 54);
            this.InnerForm.ControlContents.TabIndex = 1;
            this.InnerForm.ControlContents.Visible = true;
            this.InnerForm.ControlContents.Paint += new System.Windows.Forms.PaintEventHandler(this.InnerForm_ControlContents_Paint);
            this.InnerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerForm.Location = new System.Drawing.Point(0, 0);
            this.InnerForm.Name = "InnerForm";
            this.InnerForm.Size = new System.Drawing.Size(245, 90);
            this.InnerForm.TabIndex = 0;
            this.InnerForm.TitleBarTitle = "Force Host";
            this.InnerForm.UseTitleBar = true;
            this.InnerForm.Load += new System.EventHandler(this.InnerForm_Load);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Force Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Force Host";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 90);
            this.Controls.Add(this.InnerForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "External Testing";
            this.InnerForm.ControlContents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlContents;
        private Refract.UI.Core.Controls.CBorderedForm InnerForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

