namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.registerBird = new System.Windows.Forms.Button();
            this.viewListOfBird = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerBird
            // 
            this.registerBird.Location = new System.Drawing.Point(110, 115);
            this.registerBird.Name = "registerBird";
            this.registerBird.Size = new System.Drawing.Size(90, 25);
            this.registerBird.TabIndex = 0;
            this.registerBird.Text = "Register Bird";
            this.registerBird.UseVisualStyleBackColor = true;
            this.registerBird.Click += new System.EventHandler(this.registerBird_Click);
            // 
            // viewListOfBird
            // 
            this.viewListOfBird.Location = new System.Drawing.Point(257, 115);
            this.viewListOfBird.Name = "viewListOfBird";
            this.viewListOfBird.Size = new System.Drawing.Size(92, 25);
            this.viewListOfBird.TabIndex = 1;
            this.viewListOfBird.Text = "View List of Bird";
            this.viewListOfBird.UseVisualStyleBackColor = true;
            this.viewListOfBird.Click += new System.EventHandler(this.viewListOfBird_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to BirdWatch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewListOfBird);
            this.Controls.Add(this.registerBird);
            this.Name = "Form1";
            this.Text = "BirdWatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBird;
        private System.Windows.Forms.Button viewListOfBird;
        private System.Windows.Forms.Label label1;
    }
}

