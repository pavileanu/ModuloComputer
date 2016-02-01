namespace Modulo
{
    partial class Calculator
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
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ModuloBox = new System.Windows.Forms.TextBox();
            this.ModuloLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(392, 95);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(180, 20);
            this.NumberBox.TabIndex = 0;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(389, 62);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(44, 13);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "Number";
            // 
            // ModuloBox
            // 
            this.ModuloBox.Location = new System.Drawing.Point(712, 95);
            this.ModuloBox.Name = "ModuloBox";
            this.ModuloBox.Size = new System.Drawing.Size(100, 20);
            this.ModuloBox.TabIndex = 3;
            this.ModuloBox.Leave += new System.EventHandler(this.setModuloBlur);
            //this.ModuloBox.KeyPress += new System.EventHandler(this.Modulo_KeyPress);
            // 
            // ModuloLabel
            // 
            this.ModuloLabel.AutoSize = true;
            this.ModuloLabel.Location = new System.Drawing.Point(709, 62);
            this.ModuloLabel.Name = "ModuloLabel";
            this.ModuloLabel.Size = new System.Drawing.Size(61, 13);
            this.ModuloLabel.TabIndex = 4;
            this.ModuloLabel.Text = "Modulo Set";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Val";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.getValueClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModuloLabel);
            this.Controls.Add(this.ModuloBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NumberBox);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox ModuloBox;
        private System.Windows.Forms.Label ModuloLabel;
        private System.Windows.Forms.Button button1;
    }
}

