
namespace WindowsFormsApp1
{
    partial class LandingPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.keyword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.language = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.keywordRequired = new System.Windows.Forms.Label();
            this.countryRequired = new System.Windows.Forms.Label();
            this.languageRequired = new System.Windows.Forms.Label();
            this.categoryRequired = new System.Windows.Forms.Label();
            this.fill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyword
            // 
            this.keyword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.keyword.Location = new System.Drawing.Point(79, 211);
            this.keyword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.keyword.Multiline = true;
            this.keyword.Name = "keyword";
            this.keyword.PlaceholderText = "Keyword or phrase";
            this.keyword.Size = new System.Drawing.Size(197, 72);
            this.keyword.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(283, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(789, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RedirectToNewsPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(114, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keyword ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(236, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(856, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Window Forms based Application responsible for retrieving data from REST API";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(385, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(848, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Language";
            // 
            // country
            // 
            this.country.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.country.Location = new System.Drawing.Point(348, 211);
            this.country.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.country.MaxLength = 2;
            this.country.Multiline = true;
            this.country.Name = "country";
            this.country.PlaceholderText = "Country name";
            this.country.Size = new System.Drawing.Size(182, 72);
            this.country.TabIndex = 9;
            // 
            // language
            // 
            this.language.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.language.Location = new System.Drawing.Point(827, 211);
            this.language.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.language.MaxLength = 2;
            this.language.Multiline = true;
            this.language.Name = "language";
            this.language.PlaceholderText = "Language";
            this.language.Size = new System.Drawing.Size(182, 72);
            this.language.TabIndex = 11;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.SystemColors.Menu;
            this.labelCategory.Location = new System.Drawing.Point(1124, 126);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(110, 32);
            this.labelCategory.TabIndex = 12;
            this.labelCategory.Text = "Category";
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.category.Location = new System.Drawing.Point(1095, 211);
            this.category.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.category.Multiline = true;
            this.category.Name = "category";
            this.category.PlaceholderText = "Category";
            this.category.Size = new System.Drawing.Size(182, 72);
            this.category.TabIndex = 13;
            // 
            // keywordRequired
            // 
            this.keywordRequired.AutoSize = true;
            this.keywordRequired.BackColor = System.Drawing.Color.Red;
            this.keywordRequired.Location = new System.Drawing.Point(156, 294);
            this.keywordRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.keywordRequired.Name = "keywordRequired";
            this.keywordRequired.Size = new System.Drawing.Size(21, 32);
            this.keywordRequired.TabIndex = 16;
            this.keywordRequired.Text = "!";
            // 
            // countryRequired
            // 
            this.countryRequired.AutoSize = true;
            this.countryRequired.BackColor = System.Drawing.Color.Red;
            this.countryRequired.Location = new System.Drawing.Point(430, 294);
            this.countryRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.countryRequired.Name = "countryRequired";
            this.countryRequired.Size = new System.Drawing.Size(21, 32);
            this.countryRequired.TabIndex = 17;
            this.countryRequired.Text = "!";
            // 
            // languageRequired
            // 
            this.languageRequired.AutoSize = true;
            this.languageRequired.BackColor = System.Drawing.Color.Red;
            this.languageRequired.Location = new System.Drawing.Point(899, 294);
            this.languageRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.languageRequired.Name = "languageRequired";
            this.languageRequired.Size = new System.Drawing.Size(21, 32);
            this.languageRequired.TabIndex = 19;
            this.languageRequired.Text = "!";
            // 
            // categoryRequired
            // 
            this.categoryRequired.AutoSize = true;
            this.categoryRequired.BackColor = System.Drawing.Color.Red;
            this.categoryRequired.Location = new System.Drawing.Point(1174, 294);
            this.categoryRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.categoryRequired.Name = "categoryRequired";
            this.categoryRequired.Size = new System.Drawing.Size(21, 32);
            this.categoryRequired.TabIndex = 20;
            this.categoryRequired.Text = "!";
            // 
            // fill
            // 
            this.fill.AutoSize = true;
            this.fill.BackColor = System.Drawing.SystemColors.Info;
            this.fill.Location = new System.Drawing.Point(542, 229);
            this.fill.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(278, 32);
            this.fill.TabIndex = 22;
            this.fill.Text = "FILL AT LEAST ONE FIELD";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1372, 1071);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.categoryRequired);
            this.Controls.Add(this.languageRequired);
            this.Controls.Add(this.countryRequired);
            this.Controls.Add(this.keywordRequired);
            this.Controls.Add(this.category);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.language);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyword);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Form Based Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.LandingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label keywordRequired;
        private System.Windows.Forms.Label countryRequired;
        private System.Windows.Forms.Label languageRequired;
        private System.Windows.Forms.Label categoryRequired;
        private System.Windows.Forms.Label fill;
    }
}

