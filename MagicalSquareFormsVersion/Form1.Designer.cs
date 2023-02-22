
namespace MagicalSquareFormsVersion
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bGuess = new System.Windows.Forms.Button();
            this.b_Rules = new System.Windows.Forms.Button();
            this.b_Generate = new System.Windows.Forms.Button();
            this.tGuess = new System.Windows.Forms.TextBox();
            this.tGenerate = new System.Windows.Forms.TextBox();
            this.tRules = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bGuess);
            this.splitContainer1.Panel1.Controls.Add(this.b_Rules);
            this.splitContainer1.Panel1.Controls.Add(this.b_Generate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tGuess);
            this.splitContainer1.Panel2.Controls.Add(this.tGenerate);
            this.splitContainer1.Panel2.Controls.Add(this.tRules);
            this.splitContainer1.Size = new System.Drawing.Size(1074, 504);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // bGuess
            // 
            this.bGuess.Enabled = false;
            this.bGuess.Location = new System.Drawing.Point(27, 195);
            this.bGuess.Name = "bGuess";
            this.bGuess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bGuess.Size = new System.Drawing.Size(96, 46);
            this.bGuess.TabIndex = 2;
            this.bGuess.Text = "Guess";
            this.bGuess.UseVisualStyleBackColor = true;
            this.bGuess.Click += new System.EventHandler(this.bGuess_Click);
            // 
            // b_Rules
            // 
            this.b_Rules.Location = new System.Drawing.Point(27, 274);
            this.b_Rules.Name = "b_Rules";
            this.b_Rules.Size = new System.Drawing.Size(96, 46);
            this.b_Rules.TabIndex = 1;
            this.b_Rules.Text = "Rules";
            this.b_Rules.UseVisualStyleBackColor = true;
            this.b_Rules.Click += new System.EventHandler(this.b_Rules_Click);
            // 
            // b_Generate
            // 
            this.b_Generate.Location = new System.Drawing.Point(27, 113);
            this.b_Generate.Name = "b_Generate";
            this.b_Generate.Size = new System.Drawing.Size(96, 46);
            this.b_Generate.TabIndex = 0;
            this.b_Generate.Text = "Generate";
            this.b_Generate.UseVisualStyleBackColor = true;
            this.b_Generate.Click += new System.EventHandler(this.b_Generate_Click);
            // 
            // tGuess
            // 
            this.tGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tGuess.Location = new System.Drawing.Point(227, 283);
            this.tGuess.Multiline = true;
            this.tGuess.Name = "tGuess";
            this.tGuess.ReadOnly = true;
            this.tGuess.Size = new System.Drawing.Size(308, 175);
            this.tGuess.TabIndex = 2;
            this.tGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tGuess.Visible = false;
            // 
            // tGenerate
            // 
            this.tGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tGenerate.Location = new System.Drawing.Point(3, -2);
            this.tGenerate.Multiline = true;
            this.tGenerate.Name = "tGenerate";
            this.tGenerate.ReadOnly = true;
            this.tGenerate.Size = new System.Drawing.Size(861, 504);
            this.tGenerate.TabIndex = 1;
            this.tGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tGenerate.Visible = false;
            // 
            // tRules
            // 
            this.tRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tRules.Location = new System.Drawing.Point(266, 122);
            this.tRules.Multiline = true;
            this.tRules.Name = "tRules";
            this.tRules.ReadOnly = true;
            this.tRules.Size = new System.Drawing.Size(309, 190);
            this.tRules.TabIndex = 0;
            this.tRules.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tRules.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 504);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Magical Square";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_Rules;
        private System.Windows.Forms.Button b_Generate;
        private System.Windows.Forms.Button bGuess;
        private System.Windows.Forms.TextBox tRules;
        private System.Windows.Forms.TextBox tGenerate;
        private System.Windows.Forms.TextBox tGuess;
    }
}

