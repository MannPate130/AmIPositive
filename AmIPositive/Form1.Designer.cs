
namespace AmIPositive
{
    partial class amIpositive
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.integerTextbox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.positiveOrnegativeLabel = new System.Windows.Forms.Label();
            this.negativeOrpositiveLabel = new System.Windows.Forms.Label();
            this.divisibleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(182, 99);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(147, 25);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input an Integer";
            // 
            // integerTextbox
            // 
            this.integerTextbox.Location = new System.Drawing.Point(424, 100);
            this.integerTextbox.Name = "integerTextbox";
            this.integerTextbox.Size = new System.Drawing.Size(88, 26);
            this.integerTextbox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(424, 166);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(88, 66);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // positiveOrnegativeLabel
            // 
            this.positiveOrnegativeLabel.AutoSize = true;
            this.positiveOrnegativeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveOrnegativeLabel.Location = new System.Drawing.Point(182, 284);
            this.positiveOrnegativeLabel.Name = "positiveOrnegativeLabel";
            this.positiveOrnegativeLabel.Size = new System.Drawing.Size(0, 25);
            this.positiveOrnegativeLabel.TabIndex = 3;
            // 
            // negativeOrpositiveLabel
            // 
            this.negativeOrpositiveLabel.AutoSize = true;
            this.negativeOrpositiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeOrpositiveLabel.Location = new System.Drawing.Point(182, 284);
            this.negativeOrpositiveLabel.Name = "negativeOrpositiveLabel";
            this.negativeOrpositiveLabel.Size = new System.Drawing.Size(0, 25);
            this.negativeOrpositiveLabel.TabIndex = 4;
            // 
            // divisibleLabel
            // 
            this.divisibleLabel.AutoSize = true;
            this.divisibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisibleLabel.Location = new System.Drawing.Point(182, 343);
            this.divisibleLabel.Name = "divisibleLabel";
            this.divisibleLabel.Size = new System.Drawing.Size(0, 25);
            this.divisibleLabel.TabIndex = 5;
            // 
            // amIpositive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divisibleLabel);
            this.Controls.Add(this.negativeOrpositiveLabel);
            this.Controls.Add(this.positiveOrnegativeLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerTextbox);
            this.Controls.Add(this.inputLabel);
            this.Name = "amIpositive";
            this.Text = "If Statements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox integerTextbox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label positiveOrnegativeLabel;
        private System.Windows.Forms.Label negativeOrpositiveLabel;
        private System.Windows.Forms.Label divisibleLabel;
    }
}

