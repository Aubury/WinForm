namespace ChildProcess2
{
    partial class ChildProcess2Form
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
            this.AvailableAssemblies = new System.Windows.Forms.ListBox();
            this.StatedAssemblies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvailableAssemblies
            // 
            this.AvailableAssemblies.FormattingEnabled = true;
            this.AvailableAssemblies.ItemHeight = 20;
            this.AvailableAssemblies.Location = new System.Drawing.Point(62, 47);
            this.AvailableAssemblies.Name = "AvailableAssemblies";
            this.AvailableAssemblies.Size = new System.Drawing.Size(372, 224);
            this.AvailableAssemblies.TabIndex = 0;
            // 
            // StatedAssemblies
            // 
            this.StatedAssemblies.FormattingEnabled = true;
            this.StatedAssemblies.ItemHeight = 20;
            this.StatedAssemblies.Location = new System.Drawing.Point(631, 47);
            this.StatedAssemblies.Name = "StatedAssemblies";
            this.StatedAssemblies.Size = new System.Drawing.Size(372, 224);
            this.StatedAssemblies.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Доступные сборки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatedAssemblies);
            this.Controls.Add(this.AvailableAssemblies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableAssemblies;
        private System.Windows.Forms.ListBox StatedAssemblies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

