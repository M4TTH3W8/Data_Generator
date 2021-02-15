
namespace Data_Generator
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
            this.buttonSingleResult = new System.Windows.Forms.Button();
            this.buttonMultipleResults = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelExport = new System.Windows.Forms.Label();
            this.checkBoxXLS = new System.Windows.Forms.CheckBox();
            this.checkBoxCSV = new System.Windows.Forms.CheckBox();
            this.checkBoxXml = new System.Windows.Forms.CheckBox();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.numericSize = new System.Windows.Forms.NumericUpDown();
            this.buttonRemoveField = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.checkBoxJson = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSingleResult
            // 
            this.buttonSingleResult.Location = new System.Drawing.Point(534, 78);
            this.buttonSingleResult.Name = "buttonSingleResult";
            this.buttonSingleResult.Size = new System.Drawing.Size(220, 36);
            this.buttonSingleResult.TabIndex = 2;
            this.buttonSingleResult.Text = "Wygeneruj pojedyńczy wynik";
            this.buttonSingleResult.UseVisualStyleBackColor = true;
            this.buttonSingleResult.Click += new System.EventHandler(this.buttonSingleResult_Click);
            // 
            // buttonMultipleResults
            // 
            this.buttonMultipleResults.Location = new System.Drawing.Point(521, 194);
            this.buttonMultipleResults.Name = "buttonMultipleResults";
            this.buttonMultipleResults.Size = new System.Drawing.Size(246, 57);
            this.buttonMultipleResults.TabIndex = 6;
            this.buttonMultipleResults.Text = "Wygeneruj oraz wyeksportuj wiele wyników";
            this.buttonMultipleResults.UseVisualStyleBackColor = true;
            this.buttonMultipleResults.Click += new System.EventHandler(this.buttonMultipleResults_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.Location = new System.Drawing.Point(519, 257);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(250, 40);
            this.labelAmount.TabIndex = 8;
            this.labelAmount.Text = "Proszę podaj ilość rekordów do wygenerowania";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAmount.Visible = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(596, 417);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 31);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Wygeneruj!";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Visible = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(404, 9);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(148, 17);
            this.labelLanguage.TabIndex = 11;
            this.labelLanguage.Text = "Wybierz język danych!";
            // 
            // labelExport
            // 
            this.labelExport.AutoSize = true;
            this.labelExport.Location = new System.Drawing.Point(528, 337);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(235, 17);
            this.labelExport.TabIndex = 12;
            this.labelExport.Text = "Zaznacz format danych do eksportu";
            this.labelExport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelExport.Visible = false;
            // 
            // checkBoxXLS
            // 
            this.checkBoxXLS.AutoSize = true;
            this.checkBoxXLS.Location = new System.Drawing.Point(547, 366);
            this.checkBoxXLS.Name = "checkBoxXLS";
            this.checkBoxXLS.Size = new System.Drawing.Size(60, 21);
            this.checkBoxXLS.TabIndex = 13;
            this.checkBoxXLS.Text = ".XLS";
            this.checkBoxXLS.UseVisualStyleBackColor = true;
            this.checkBoxXLS.Visible = false;
            // 
            // checkBoxCSV
            // 
            this.checkBoxCSV.AutoSize = true;
            this.checkBoxCSV.Location = new System.Drawing.Point(614, 366);
            this.checkBoxCSV.Name = "checkBoxCSV";
            this.checkBoxCSV.Size = new System.Drawing.Size(61, 21);
            this.checkBoxCSV.TabIndex = 14;
            this.checkBoxCSV.Text = ".CSV";
            this.checkBoxCSV.UseVisualStyleBackColor = true;
            this.checkBoxCSV.Visible = false;
            // 
            // checkBoxXml
            // 
            this.checkBoxXml.AutoSize = true;
            this.checkBoxXml.Location = new System.Drawing.Point(681, 366);
            this.checkBoxXml.Name = "checkBoxXml";
            this.checkBoxXml.Size = new System.Drawing.Size(62, 21);
            this.checkBoxXml.TabIndex = 15;
            this.checkBoxXml.Text = ".XML";
            this.checkBoxXml.UseVisualStyleBackColor = true;
            this.checkBoxXml.Visible = false;
            // 
            // buttonAddField
            // 
            this.buttonAddField.Location = new System.Drawing.Point(12, 12);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(135, 42);
            this.buttonAddField.TabIndex = 16;
            this.buttonAddField.Text = "Dodaj kolejne pole";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Polski",
            "Angielski",
            "Niemiecki"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(410, 30);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLanguage.TabIndex = 17;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(585, 300);
            this.numericAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(120, 22);
            this.numericAmount.TabIndex = 18;
            this.numericAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAmount.Visible = false;
            this.numericAmount.ValueChanged += new System.EventHandler(this.numericAmount_ValueChanged);
            // 
            // numericSize
            // 
            this.numericSize.Location = new System.Drawing.Point(587, 161);
            this.numericSize.Name = "numericSize";
            this.numericSize.Size = new System.Drawing.Size(120, 22);
            this.numericSize.TabIndex = 19;
            this.numericSize.ValueChanged += new System.EventHandler(this.numericSize_ValueChanged);
            // 
            // buttonRemoveField
            // 
            this.buttonRemoveField.Location = new System.Drawing.Point(165, 13);
            this.buttonRemoveField.Name = "buttonRemoveField";
            this.buttonRemoveField.Size = new System.Drawing.Size(205, 41);
            this.buttonRemoveField.TabIndex = 21;
            this.buttonRemoveField.Text = "Usun ostatnie pole";
            this.buttonRemoveField.UseVisualStyleBackColor = true;
            this.buttonRemoveField.Click += new System.EventHandler(this.buttonRemoveField_Click_1);
            // 
            // labelSize
            // 
            this.labelSize.Location = new System.Drawing.Point(519, 121);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(244, 35);
            this.labelSize.TabIndex = 22;
            this.labelSize.Text = "Opcjonalnie:Maksymalna Długość generowanej danej";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxJson
            // 
            this.checkBoxJson.AutoSize = true;
            this.checkBoxJson.Location = new System.Drawing.Point(614, 392);
            this.checkBoxJson.Name = "checkBoxJson";
            this.checkBoxJson.Size = new System.Drawing.Size(64, 21);
            this.checkBoxJson.TabIndex = 23;
            this.checkBoxJson.Text = ".Json";
            this.checkBoxJson.UseVisualStyleBackColor = true;
            this.checkBoxJson.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(810, 453);
            this.Controls.Add(this.checkBoxJson);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonRemoveField);
            this.Controls.Add(this.numericSize);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonAddField);
            this.Controls.Add(this.checkBoxXml);
            this.Controls.Add(this.checkBoxCSV);
            this.Controls.Add(this.checkBoxXLS);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonMultipleResults);
            this.Controls.Add(this.buttonSingleResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1500, 500);
            this.Name = "Form1";
            this.Text = "Random Data Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSingleResult;
        private System.Windows.Forms.Button buttonMultipleResults;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelExport;
        private System.Windows.Forms.CheckBox checkBoxXLS;
        private System.Windows.Forms.CheckBox checkBoxCSV;
        private System.Windows.Forms.CheckBox checkBoxXml;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.NumericUpDown numericSize;
        private System.Windows.Forms.Button buttonRemoveField;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.CheckBox checkBoxJson;
    }
}

