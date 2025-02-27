namespace PartnersDB_Pr3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelPartners = new Label();
            panelFill = new Panel();
            label2 = new Label();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelPartners);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(684, 70);
            panelTop.TabIndex = 0;
            // 
            // labelPartners
            // 
            labelPartners.Dock = DockStyle.Fill;
            labelPartners.Location = new Point(0, 0);
            labelPartners.Margin = new Padding(5);
            labelPartners.Name = "labelPartners";
            labelPartners.Padding = new Padding(10);
            labelPartners.Size = new Size(684, 70);
            labelPartners.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(label2);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 70);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(684, 491);
            panelFill.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(684, 491);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 561);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelPartners;
        private Panel panelFill;
        private Label label2;
    }
}
