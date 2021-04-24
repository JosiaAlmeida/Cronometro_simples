
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.iniciarbtn = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iniciarbtn
            // 
            this.iniciarbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.iniciarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iniciarbtn.Location = new System.Drawing.Point(12, 75);
            this.iniciarbtn.Name = "iniciarbtn";
            this.iniciarbtn.Size = new System.Drawing.Size(116, 38);
            this.iniciarbtn.TabIndex = 1;
            this.iniciarbtn.Text = "Iniciar";
            this.iniciarbtn.UseVisualStyleBackColor = false;
            this.iniciarbtn.Click += new System.EventHandler(this.iniciarbtn_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(12, 119);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 38);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Turquoise;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(134, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.Location = new System.Drawing.Point(134, 119);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(115, 38);
            this.Closebtn.TabIndex = 5;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(267, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.iniciarbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button iniciarbtn;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label1;
    }
}

