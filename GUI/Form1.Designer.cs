namespace GUI
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StatesLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.herbataButton = new System.Windows.Forms.Button();
            this.kawaButton = new System.Windows.Forms.Button();
            this.restLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "5 zl";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.coin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2 zl";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.coin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1 zł";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.coin_Click);
            // 
            // StatesLabel
            // 
            this.StatesLabel.AutoSize = true;
            this.StatesLabel.Location = new System.Drawing.Point(68, 57);
            this.StatesLabel.Name = "StatesLabel";
            this.StatesLabel.Size = new System.Drawing.Size(37, 13);
            this.StatesLabel.TabIndex = 3;
            this.StatesLabel.Text = "States";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(68, 94);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(28, 13);
            this.SumLabel.TabIndex = 4;
            this.SumLabel.Text = "Sum";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(306, 76);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 5;
            this.StateLabel.Text = "State";
            // 
            // herbataButton
            // 
            this.herbataButton.Location = new System.Drawing.Point(469, 192);
            this.herbataButton.Name = "herbataButton";
            this.herbataButton.Size = new System.Drawing.Size(75, 23);
            this.herbataButton.TabIndex = 6;
            this.herbataButton.Text = "Herbata 5 zl";
            this.herbataButton.UseVisualStyleBackColor = true;
            this.herbataButton.Click += new System.EventHandler(this.herbataButton_Click);
            // 
            // kawaButton
            // 
            this.kawaButton.Location = new System.Drawing.Point(613, 191);
            this.kawaButton.Name = "kawaButton";
            this.kawaButton.Size = new System.Drawing.Size(75, 23);
            this.kawaButton.TabIndex = 7;
            this.kawaButton.Text = "kawa 7 zl";
            this.kawaButton.UseVisualStyleBackColor = true;
            this.kawaButton.Click += new System.EventHandler(this.herbataButton_Click);
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Location = new System.Drawing.Point(71, 122);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(40, 13);
            this.restLabel.TabIndex = 8;
            this.restLabel.Text = "Reszta";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(71, 154);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 9;
            this.productLabel.Text = "Product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.restLabel);
            this.Controls.Add(this.kawaButton);
            this.Controls.Add(this.herbataButton);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.StatesLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label StatesLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Button herbataButton;
        private System.Windows.Forms.Button kawaButton;
        private System.Windows.Forms.Label restLabel;
        private System.Windows.Forms.Label productLabel;
    }
}

