namespace Sea_War
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.singleDeck = new System.Windows.Forms.RadioButton();
            this.doubleDeck = new System.Windows.Forms.RadioButton();
            this.threeDeck = new System.Windows.Forms.RadioButton();
            this.fourDeck = new System.Windows.Forms.RadioButton();
            this.vertical = new System.Windows.Forms.RadioButton();
            this.horizontal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.random_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(630, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sea War";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(970, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 43);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.ExitLabel_ExitGame);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(974, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exit";
            // 
            // playLabel
            // 
            this.playLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playLabel.BackColor = System.Drawing.Color.Transparent;
            this.playLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playLabel.Image = ((System.Drawing.Image)(resources.GetObject("playLabel.Image")));
            this.playLabel.Location = new System.Drawing.Point(941, 437);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(78, 78);
            this.playLabel.TabIndex = 3;
            this.playLabel.Text = "Play";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playLabel.Click += new System.EventHandler(this.playLabel_Click);
            // 
            // singleDeck
            // 
            this.singleDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.singleDeck.BackColor = System.Drawing.Color.Thistle;
            this.singleDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singleDeck.Location = new System.Drawing.Point(3, 3);
            this.singleDeck.Name = "singleDeck";
            this.singleDeck.Size = new System.Drawing.Size(120, 17);
            this.singleDeck.TabIndex = 4;
            this.singleDeck.Text = "Single-deck";
            this.singleDeck.UseVisualStyleBackColor = false;
            // 
            // doubleDeck
            // 
            this.doubleDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doubleDeck.BackColor = System.Drawing.Color.Thistle;
            this.doubleDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doubleDeck.Location = new System.Drawing.Point(3, 32);
            this.doubleDeck.Name = "doubleDeck";
            this.doubleDeck.Size = new System.Drawing.Size(120, 17);
            this.doubleDeck.TabIndex = 5;
            this.doubleDeck.Text = "Double-deck";
            this.doubleDeck.UseVisualStyleBackColor = false;
            // 
            // threeDeck
            // 
            this.threeDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.threeDeck.BackColor = System.Drawing.Color.Thistle;
            this.threeDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeDeck.Location = new System.Drawing.Point(3, 61);
            this.threeDeck.Name = "threeDeck";
            this.threeDeck.Size = new System.Drawing.Size(120, 17);
            this.threeDeck.TabIndex = 6;
            this.threeDeck.Text = "Three-deck";
            this.threeDeck.UseVisualStyleBackColor = false;
            // 
            // fourDeck
            // 
            this.fourDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fourDeck.BackColor = System.Drawing.Color.Thistle;
            this.fourDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourDeck.Location = new System.Drawing.Point(3, 88);
            this.fourDeck.Name = "fourDeck";
            this.fourDeck.Size = new System.Drawing.Size(120, 17);
            this.fourDeck.TabIndex = 7;
            this.fourDeck.Text = "Four-deck";
            this.fourDeck.UseVisualStyleBackColor = false;
            // 
            // vertical
            // 
            this.vertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vertical.BackColor = System.Drawing.Color.Thistle;
            this.vertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertical.Location = new System.Drawing.Point(0, 0);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(120, 17);
            this.vertical.TabIndex = 8;
            this.vertical.Text = "Vertical";
            this.vertical.UseVisualStyleBackColor = false;
            // 
            // horizontal
            // 
            this.horizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.horizontal.BackColor = System.Drawing.Color.Thistle;
            this.horizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horizontal.Location = new System.Drawing.Point(0, 23);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(120, 20);
            this.horizontal.TabIndex = 9;
            this.horizontal.Text = "Horizontal";
            this.horizontal.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.singleDeck);
            this.panel1.Controls.Add(this.fourDeck);
            this.panel1.Controls.Add(this.doubleDeck);
            this.panel1.Controls.Add(this.threeDeck);
            this.panel1.Location = new System.Drawing.Point(12, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 109);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.horizontal);
            this.panel2.Controls.Add(this.vertical);
            this.panel2.Location = new System.Drawing.Point(156, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 49);
            this.panel2.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.BackColor = System.Drawing.Color.Thistle;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(156, 456);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 32);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // random_Button
            // 
            this.random_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.random_Button.BackColor = System.Drawing.Color.Thistle;
            this.random_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random_Button.Location = new System.Drawing.Point(156, 489);
            this.random_Button.Name = "random_Button";
            this.random_Button.Size = new System.Drawing.Size(119, 32);
            this.random_Button.TabIndex = 12;
            this.random_Button.Text = "Random";
            this.random_Button.UseVisualStyleBackColor = false;
            this.random_Button.Click += new System.EventHandler(this.random_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 543);
            this.Controls.Add(this.random_Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea War";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.RadioButton singleDeck;
        private System.Windows.Forms.RadioButton doubleDeck;
        private System.Windows.Forms.RadioButton threeDeck;
        private System.Windows.Forms.RadioButton fourDeck;
        private System.Windows.Forms.RadioButton vertical;
        private System.Windows.Forms.RadioButton horizontal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button random_Button;
    }
}

