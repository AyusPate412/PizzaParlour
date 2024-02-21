namespace PizzaParlour
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.slicesLabel = new System.Windows.Forms.Label();
            this.slicesInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.IndianRed;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-6, 1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(814, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PIZZA PARLOUR";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // slicesLabel
            // 
            this.slicesLabel.AutoSize = true;
            this.slicesLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slicesLabel.Location = new System.Drawing.Point(184, 84);
            this.slicesLabel.Name = "slicesLabel";
            this.slicesLabel.Size = new System.Drawing.Size(191, 26);
            this.slicesLabel.TabIndex = 1;
            this.slicesLabel.Text = "Number of Slices";
            // 
            // slicesInput
            // 
            this.slicesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.slicesInput.Location = new System.Drawing.Point(475, 84);
            this.slicesInput.Name = "slicesInput";
            this.slicesInput.Size = new System.Drawing.Size(100, 26);
            this.slicesInput.TabIndex = 2;
            this.slicesInput.TextChanged += new System.EventHandler(this.slicesInput_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(381, 151);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 34);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(218, 213);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(117, 26);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Subtotal: ";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subtotalOutput.Location = new System.Drawing.Point(475, 213);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 26);
            this.subtotalOutput.TabIndex = 5;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(218, 269);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(60, 26);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.Text = "Tax:";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.Black;
            this.taxOutput.Location = new System.Drawing.Point(475, 269);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 26);
            this.taxOutput.TabIndex = 7;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.Black;
            this.totalOutput.Location = new System.Drawing.Point(475, 324);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 26);
            this.totalOutput.TabIndex = 8;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(218, 324);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(134, 26);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.slicesInput);
            this.Controls.Add(this.slicesLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label slicesLabel;
        private System.Windows.Forms.TextBox slicesInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalLabel;
    }
}

