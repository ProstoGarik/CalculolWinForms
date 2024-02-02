namespace Calculol
{
    partial class CalculatorMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMainScreen));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ScreenInputPicBox = new System.Windows.Forms.PictureBox();
            this.OperatorEqButton = new System.Windows.Forms.Button();
            this.EraseCharButton = new System.Windows.Forms.Button();
            this.OperatorBracketEndButton = new System.Windows.Forms.Button();
            this.OperatorBracketStartButton = new System.Windows.Forms.Button();
            this.OperatorDivButton = new System.Windows.Forms.Button();
            this.OperatorMultButton = new System.Windows.Forms.Button();
            this.OperatorMinusButton = new System.Windows.Forms.Button();
            this.Number0Button = new System.Windows.Forms.Button();
            this.Number9Button = new System.Windows.Forms.Button();
            this.Number8Button = new System.Windows.Forms.Button();
            this.Number7Button = new System.Windows.Forms.Button();
            this.Number6Button = new System.Windows.Forms.Button();
            this.Number5Button = new System.Windows.Forms.Button();
            this.Number4Button = new System.Windows.Forms.Button();
            this.OperatorPlusButton = new System.Windows.Forms.Button();
            this.Number3Button = new System.Windows.Forms.Button();
            this.Number2Button = new System.Windows.Forms.Button();
            this.Number1Button = new System.Windows.Forms.Button();
            this.ScreenOutputPicBox = new System.Windows.Forms.PictureBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.OperatorPow2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenInputPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenOutputPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InputTextBox.Location = new System.Drawing.Point(29, 21);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.Size = new System.Drawing.Size(189, 73);
            this.InputTextBox.TabIndex = 18;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(248, 21);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(77, 73);
            this.OutputTextBox.TabIndex = 19;
            // 
            // ScreenInputPicBox
            // 
            this.ScreenInputPicBox.BackgroundImage = global::Calculol.Properties.Resources.FrameGray;
            this.ScreenInputPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreenInputPicBox.Location = new System.Drawing.Point(12, 12);
            this.ScreenInputPicBox.Name = "ScreenInputPicBox";
            this.ScreenInputPicBox.Size = new System.Drawing.Size(223, 90);
            this.ScreenInputPicBox.TabIndex = 23;
            this.ScreenInputPicBox.TabStop = false;
            // 
            // OperatorEqButton
            // 
            this.OperatorEqButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorEqButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorEqButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorEqButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorEqButton.Location = new System.Drawing.Point(272, 393);
            this.OperatorEqButton.Name = "OperatorEqButton";
            this.OperatorEqButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorEqButton.TabIndex = 22;
            this.OperatorEqButton.Text = "=";
            this.OperatorEqButton.UseVisualStyleBackColor = true;
            this.OperatorEqButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EraseCharButton
            // 
            this.EraseCharButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.EraseCharButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EraseCharButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.EraseCharButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EraseCharButton.Location = new System.Drawing.Point(14, 124);
            this.EraseCharButton.Name = "EraseCharButton";
            this.EraseCharButton.Size = new System.Drawing.Size(59, 61);
            this.EraseCharButton.TabIndex = 20;
            this.EraseCharButton.Text = "DEL";
            this.EraseCharButton.UseVisualStyleBackColor = true;
            this.EraseCharButton.Click += new System.EventHandler(this.EraseCharButton_Click);
            // 
            // OperatorBracketEndButton
            // 
            this.OperatorBracketEndButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorBracketEndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorBracketEndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorBracketEndButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorBracketEndButton.Location = new System.Drawing.Point(178, 393);
            this.OperatorBracketEndButton.Name = "OperatorBracketEndButton";
            this.OperatorBracketEndButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorBracketEndButton.TabIndex = 17;
            this.OperatorBracketEndButton.Text = ")";
            this.OperatorBracketEndButton.UseVisualStyleBackColor = true;
            this.OperatorBracketEndButton.Click += new System.EventHandler(this.OperatorBracketEndButton_Click);
            // 
            // OperatorBracketStartButton
            // 
            this.OperatorBracketStartButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperatorBracketStartButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorBracketStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorBracketStartButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.OperatorBracketStartButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperatorBracketStartButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InfoText;
            this.OperatorBracketStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorBracketStartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorBracketStartButton.Location = new System.Drawing.Point(97, 392);
            this.OperatorBracketStartButton.Name = "OperatorBracketStartButton";
            this.OperatorBracketStartButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorBracketStartButton.TabIndex = 16;
            this.OperatorBracketStartButton.Text = "(";
            this.OperatorBracketStartButton.UseVisualStyleBackColor = false;
            this.OperatorBracketStartButton.Click += new System.EventHandler(this.OperatorBracketStartButton_Click);
            // 
            // OperatorDivButton
            // 
            this.OperatorDivButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorDivButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorDivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorDivButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorDivButton.Location = new System.Drawing.Point(274, 325);
            this.OperatorDivButton.Name = "OperatorDivButton";
            this.OperatorDivButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorDivButton.TabIndex = 14;
            this.OperatorDivButton.Text = "/";
            this.OperatorDivButton.UseVisualStyleBackColor = true;
            this.OperatorDivButton.Click += new System.EventHandler(this.OperatorDivButton_Click);
            // 
            // OperatorMultButton
            // 
            this.OperatorMultButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorMultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorMultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorMultButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorMultButton.Location = new System.Drawing.Point(274, 258);
            this.OperatorMultButton.Name = "OperatorMultButton";
            this.OperatorMultButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorMultButton.TabIndex = 13;
            this.OperatorMultButton.Text = "X";
            this.OperatorMultButton.UseVisualStyleBackColor = true;
            this.OperatorMultButton.Click += new System.EventHandler(this.OperatorMultButton_Click);
            // 
            // OperatorMinusButton
            // 
            this.OperatorMinusButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorMinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorMinusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorMinusButton.Location = new System.Drawing.Point(274, 191);
            this.OperatorMinusButton.Name = "OperatorMinusButton";
            this.OperatorMinusButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorMinusButton.TabIndex = 12;
            this.OperatorMinusButton.Text = "-";
            this.OperatorMinusButton.UseVisualStyleBackColor = true;
            this.OperatorMinusButton.Click += new System.EventHandler(this.OperatorMinusButton_Click);
            // 
            // Number0Button
            // 
            this.Number0Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number0Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number0Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number0Button.Location = new System.Drawing.Point(14, 393);
            this.Number0Button.Name = "Number0Button";
            this.Number0Button.Size = new System.Drawing.Size(59, 61);
            this.Number0Button.TabIndex = 11;
            this.Number0Button.Text = "0";
            this.Number0Button.UseVisualStyleBackColor = true;
            this.Number0Button.Click += new System.EventHandler(this.Number0Button_Click);
            // 
            // Number9Button
            // 
            this.Number9Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number9Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number9Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number9Button.Location = new System.Drawing.Point(178, 191);
            this.Number9Button.Name = "Number9Button";
            this.Number9Button.Size = new System.Drawing.Size(59, 61);
            this.Number9Button.TabIndex = 10;
            this.Number9Button.Text = "9";
            this.Number9Button.UseVisualStyleBackColor = true;
            this.Number9Button.Click += new System.EventHandler(this.Number9Button_Click);
            // 
            // Number8Button
            // 
            this.Number8Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number8Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number8Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number8Button.Location = new System.Drawing.Point(97, 191);
            this.Number8Button.Name = "Number8Button";
            this.Number8Button.Size = new System.Drawing.Size(59, 61);
            this.Number8Button.TabIndex = 9;
            this.Number8Button.Text = "8";
            this.Number8Button.UseVisualStyleBackColor = true;
            this.Number8Button.Click += new System.EventHandler(this.Number8Button_Click);
            // 
            // Number7Button
            // 
            this.Number7Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number7Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number7Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number7Button.Location = new System.Drawing.Point(14, 191);
            this.Number7Button.Name = "Number7Button";
            this.Number7Button.Size = new System.Drawing.Size(59, 61);
            this.Number7Button.TabIndex = 8;
            this.Number7Button.Text = "7";
            this.Number7Button.UseVisualStyleBackColor = true;
            this.Number7Button.Click += new System.EventHandler(this.Number7Button_Click);
            // 
            // Number6Button
            // 
            this.Number6Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number6Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number6Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number6Button.Location = new System.Drawing.Point(178, 258);
            this.Number6Button.Name = "Number6Button";
            this.Number6Button.Size = new System.Drawing.Size(59, 61);
            this.Number6Button.TabIndex = 7;
            this.Number6Button.Text = "6";
            this.Number6Button.UseVisualStyleBackColor = true;
            this.Number6Button.Click += new System.EventHandler(this.Number6Button_Click);
            // 
            // Number5Button
            // 
            this.Number5Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number5Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number5Button.Location = new System.Drawing.Point(97, 258);
            this.Number5Button.Name = "Number5Button";
            this.Number5Button.Size = new System.Drawing.Size(59, 61);
            this.Number5Button.TabIndex = 6;
            this.Number5Button.Text = "5";
            this.Number5Button.UseVisualStyleBackColor = true;
            this.Number5Button.Click += new System.EventHandler(this.Number5Button_Click);
            // 
            // Number4Button
            // 
            this.Number4Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number4Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number4Button.Location = new System.Drawing.Point(14, 258);
            this.Number4Button.Name = "Number4Button";
            this.Number4Button.Size = new System.Drawing.Size(59, 61);
            this.Number4Button.TabIndex = 5;
            this.Number4Button.Text = "4";
            this.Number4Button.UseVisualStyleBackColor = true;
            this.Number4Button.Click += new System.EventHandler(this.Number4Button_Click);
            // 
            // OperatorPlusButton
            // 
            this.OperatorPlusButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorPlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorPlusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorPlusButton.Location = new System.Drawing.Point(274, 124);
            this.OperatorPlusButton.Name = "OperatorPlusButton";
            this.OperatorPlusButton.Size = new System.Drawing.Size(59, 61);
            this.OperatorPlusButton.TabIndex = 4;
            this.OperatorPlusButton.Text = "+";
            this.OperatorPlusButton.UseVisualStyleBackColor = true;
            this.OperatorPlusButton.Click += new System.EventHandler(this.OperatorPlusButton_Click);
            // 
            // Number3Button
            // 
            this.Number3Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number3Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number3Button.Location = new System.Drawing.Point(178, 325);
            this.Number3Button.Name = "Number3Button";
            this.Number3Button.Size = new System.Drawing.Size(59, 61);
            this.Number3Button.TabIndex = 3;
            this.Number3Button.Text = "3";
            this.Number3Button.UseVisualStyleBackColor = true;
            this.Number3Button.Click += new System.EventHandler(this.Number3Button_Click);
            // 
            // Number2Button
            // 
            this.Number2Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Number2Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number2Button.Location = new System.Drawing.Point(97, 325);
            this.Number2Button.Name = "Number2Button";
            this.Number2Button.Size = new System.Drawing.Size(59, 61);
            this.Number2Button.TabIndex = 2;
            this.Number2Button.Text = "2";
            this.Number2Button.UseVisualStyleBackColor = true;
            this.Number2Button.Click += new System.EventHandler(this.Number2Button_Click);
            // 
            // Number1Button
            // 
            this.Number1Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.Number1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Number1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number1Button.Location = new System.Drawing.Point(14, 325);
            this.Number1Button.Name = "Number1Button";
            this.Number1Button.Size = new System.Drawing.Size(59, 61);
            this.Number1Button.TabIndex = 1;
            this.Number1Button.Text = "1";
            this.Number1Button.UseVisualStyleBackColor = true;
            this.Number1Button.Click += new System.EventHandler(this.Number1Button_Click);
            // 
            // ScreenOutputPicBox
            // 
            this.ScreenOutputPicBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ScreenOutputPicBox.BackgroundImage = global::Calculol.Properties.Resources.FrameGray;
            this.ScreenOutputPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreenOutputPicBox.Location = new System.Drawing.Point(241, 12);
            this.ScreenOutputPicBox.Name = "ScreenOutputPicBox";
            this.ScreenOutputPicBox.Size = new System.Drawing.Size(91, 90);
            this.ScreenOutputPicBox.TabIndex = 24;
            this.ScreenOutputPicBox.TabStop = false;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.ClearAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearAllButton.Location = new System.Drawing.Point(97, 124);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(59, 61);
            this.ClearAllButton.TabIndex = 25;
            this.ClearAllButton.Text = "CL";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OperatorPow2Button
            // 
            this.OperatorPow2Button.BackgroundImage = global::Calculol.Properties.Resources.FrutigerBG;
            this.OperatorPow2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OperatorPow2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperatorPow2Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperatorPow2Button.Location = new System.Drawing.Point(178, 124);
            this.OperatorPow2Button.Name = "OperatorPow2Button";
            this.OperatorPow2Button.Size = new System.Drawing.Size(59, 61);
            this.OperatorPow2Button.TabIndex = 26;
            this.OperatorPow2Button.Text = "^";
            this.OperatorPow2Button.UseVisualStyleBackColor = true;
            this.OperatorPow2Button.Click += new System.EventHandler(this.OperatorPow2Button_Click);
            // 
            // CalculatorMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(344, 466);
            this.Controls.Add(this.OperatorPow2Button);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.OperatorEqButton);
            this.Controls.Add(this.EraseCharButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OperatorBracketEndButton);
            this.Controls.Add(this.OperatorBracketStartButton);
            this.Controls.Add(this.OperatorDivButton);
            this.Controls.Add(this.OperatorMultButton);
            this.Controls.Add(this.OperatorMinusButton);
            this.Controls.Add(this.Number0Button);
            this.Controls.Add(this.Number9Button);
            this.Controls.Add(this.Number8Button);
            this.Controls.Add(this.Number7Button);
            this.Controls.Add(this.Number6Button);
            this.Controls.Add(this.Number5Button);
            this.Controls.Add(this.Number4Button);
            this.Controls.Add(this.OperatorPlusButton);
            this.Controls.Add(this.Number3Button);
            this.Controls.Add(this.Number2Button);
            this.Controls.Add(this.Number1Button);
            this.Controls.Add(this.ScreenInputPicBox);
            this.Controls.Add(this.ScreenOutputPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 505);
            this.MinimumSize = new System.Drawing.Size(360, 505);
            this.Name = "CalculatorMainScreen";
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.ScreenInputPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenOutputPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Number1Button;
        private System.Windows.Forms.Button Number2Button;
        private System.Windows.Forms.Button Number3Button;
        private System.Windows.Forms.Button OperatorPlusButton;
        private System.Windows.Forms.Button Number6Button;
        private System.Windows.Forms.Button Number5Button;
        private System.Windows.Forms.Button Number4Button;
        private System.Windows.Forms.Button Number9Button;
        private System.Windows.Forms.Button Number8Button;
        private System.Windows.Forms.Button Number7Button;
        private System.Windows.Forms.Button Number0Button;
        private System.Windows.Forms.Button OperatorMinusButton;
        private System.Windows.Forms.Button OperatorMultButton;
        private System.Windows.Forms.Button OperatorDivButton;
        private System.Windows.Forms.Button OperatorBracketStartButton;
        private System.Windows.Forms.Button OperatorBracketEndButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button EraseCharButton;
        private System.Windows.Forms.Button OperatorEqButton;
        private System.Windows.Forms.PictureBox ScreenInputPicBox;
        private System.Windows.Forms.PictureBox ScreenOutputPicBox;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button OperatorPow2Button;
    }
}

