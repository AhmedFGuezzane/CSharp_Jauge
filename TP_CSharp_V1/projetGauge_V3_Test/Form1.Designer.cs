namespace projetGauge_V3_Test
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_CurrentValue = new System.Windows.Forms.TextBox();
            this.txtBox_MinVal = new System.Windows.Forms.TextBox();
            this.txtBox_MaxVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_SubDivisions = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_InterfaceTitle = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_DivMinus = new System.Windows.Forms.Button();
            this.btn_DivPlus = new System.Windows.Forms.Button();
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nbDiv = new System.Windows.Forms.Label();
            this.btn_HideSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gauge1 = new GaugeV3.Gauge();
            this.controlPanel.SuspendLayout();
            this.panel_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(36, 185);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(209, 47);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Afficher";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valeur a afficher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_CurrentValue
            // 
            this.txtBox_CurrentValue.Location = new System.Drawing.Point(36, 43);
            this.txtBox_CurrentValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_CurrentValue.Name = "txtBox_CurrentValue";
            this.txtBox_CurrentValue.Size = new System.Drawing.Size(208, 22);
            this.txtBox_CurrentValue.TabIndex = 3;
            // 
            // txtBox_MinVal
            // 
            this.txtBox_MinVal.Location = new System.Drawing.Point(36, 95);
            this.txtBox_MinVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_MinVal.Name = "txtBox_MinVal";
            this.txtBox_MinVal.Size = new System.Drawing.Size(208, 22);
            this.txtBox_MinVal.TabIndex = 4;
            // 
            // txtBox_MaxVal
            // 
            this.txtBox_MaxVal.Location = new System.Drawing.Point(36, 149);
            this.txtBox_MaxVal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_MaxVal.Name = "txtBox_MaxVal";
            this.txtBox_MaxVal.Size = new System.Drawing.Size(208, 22);
            this.txtBox_MaxVal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valeur minimum ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valeur maximum";
            // 
            // checkBox_SubDivisions
            // 
            this.checkBox_SubDivisions.AutoSize = true;
            this.checkBox_SubDivisions.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_SubDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SubDivisions.Location = new System.Drawing.Point(35, 252);
            this.checkBox_SubDivisions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_SubDivisions.Name = "checkBox_SubDivisions";
            this.checkBox_SubDivisions.Size = new System.Drawing.Size(157, 17);
            this.checkBox_SubDivisions.TabIndex = 8;
            this.checkBox_SubDivisions.Text = "Afficher sous-divisions ";
            this.checkBox_SubDivisions.UseVisualStyleBackColor = true;
            this.checkBox_SubDivisions.CheckedChanged += new System.EventHandler(this.checkBox_SubDivisions_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 71);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Choisir un thème";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_InterfaceTitle
            // 
            this.lbl_InterfaceTitle.AutoSize = true;
            this.lbl_InterfaceTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InterfaceTitle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_InterfaceTitle.Location = new System.Drawing.Point(471, 32);
            this.lbl_InterfaceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_InterfaceTitle.Name = "lbl_InterfaceTitle";
            this.lbl_InterfaceTitle.Size = new System.Drawing.Size(409, 46);
            this.lbl_InterfaceTitle.TabIndex = 10;
            this.lbl_InterfaceTitle.Text = "Jauge de puissance";
            this.lbl_InterfaceTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlPanel.Controls.Add(this.btn_Reset);
            this.controlPanel.Controls.Add(this.btn_Update);
            this.controlPanel.Controls.Add(this.txtBox_CurrentValue);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.txtBox_MinVal);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.txtBox_MaxVal);
            this.controlPanel.Location = new System.Drawing.Point(33, 32);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(288, 306);
            this.controlPanel.TabIndex = 12;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(36, 239);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(209, 47);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Réinitialiser";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_DivMinus
            // 
            this.btn_DivMinus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DivMinus.FlatAppearance.BorderSize = 0;
            this.btn_DivMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DivMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DivMinus.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_DivMinus.Location = new System.Drawing.Point(36, 171);
            this.btn_DivMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DivMinus.Name = "btn_DivMinus";
            this.btn_DivMinus.Size = new System.Drawing.Size(35, 34);
            this.btn_DivMinus.TabIndex = 10;
            this.btn_DivMinus.Text = "<";
            this.btn_DivMinus.UseVisualStyleBackColor = false;
            this.btn_DivMinus.Click += new System.EventHandler(this.btn_DivMinus_Click);
            // 
            // btn_DivPlus
            // 
            this.btn_DivPlus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DivPlus.FlatAppearance.BorderSize = 0;
            this.btn_DivPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DivPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DivPlus.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_DivPlus.Location = new System.Drawing.Point(211, 171);
            this.btn_DivPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DivPlus.Name = "btn_DivPlus";
            this.btn_DivPlus.Size = new System.Drawing.Size(35, 34);
            this.btn_DivPlus.TabIndex = 11;
            this.btn_DivPlus.Text = ">";
            this.btn_DivPlus.UseVisualStyleBackColor = false;
            this.btn_DivPlus.Click += new System.EventHandler(this.btn_DivPlus_Click);
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Settings.Controls.Add(this.label7);
            this.panel_Settings.Controls.Add(this.label6);
            this.panel_Settings.Controls.Add(this.lbl_nbDiv);
            this.panel_Settings.Controls.Add(this.checkBox_SubDivisions);
            this.panel_Settings.Controls.Add(this.btn_DivMinus);
            this.panel_Settings.Controls.Add(this.comboBox1);
            this.panel_Settings.Controls.Add(this.btn_DivPlus);
            this.panel_Settings.Location = new System.Drawing.Point(1157, 32);
            this.panel_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(288, 306);
            this.panel_Settings.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Paramètres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre de divisions";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_nbDiv
            // 
            this.lbl_nbDiv.AutoSize = true;
            this.lbl_nbDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbDiv.Location = new System.Drawing.Point(131, 181);
            this.lbl_nbDiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nbDiv.Name = "lbl_nbDiv";
            this.lbl_nbDiv.Size = new System.Drawing.Size(15, 16);
            this.lbl_nbDiv.TabIndex = 12;
            this.lbl_nbDiv.Text = "5";
            // 
            // btn_HideSettings
            // 
            this.btn_HideSettings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_HideSettings.FlatAppearance.BorderSize = 0;
            this.btn_HideSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HideSettings.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_HideSettings.Location = new System.Drawing.Point(1092, 32);
            this.btn_HideSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HideSettings.Name = "btn_HideSettings";
            this.btn_HideSettings.Size = new System.Drawing.Size(33, 28);
            this.btn_HideSettings.TabIndex = 14;
            this.btn_HideSettings.Text = "<";
            this.toolTip1.SetToolTip(this.btn_HideSettings, "Cliquer ici pour masquer/afficher le paneau de paramètres");
            this.btn_HideSettings.UseVisualStyleBackColor = false;
            this.btn_HideSettings.Click += new System.EventHandler(this.btn_HideSettings_Click);
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Location = new System.Drawing.Point(533, 313);
            this.comboBox_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(417, 21);
            this.comboBox_Data.TabIndex = 15;
            this.comboBox_Data.Text = "Choisir une donnée à afficher";
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Load.Location = new System.Drawing.Point(960, 311);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(116, 26);
            this.btn_Load.TabIndex = 17;
            this.btn_Load.Text = "Charger";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Save.Location = new System.Drawing.Point(409, 313);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(116, 26);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Sauvegarder";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gauge1
            // 
            this.gauge1.BackColor = System.Drawing.Color.Transparent;
            this.gauge1.CurrentValue = 0F;
            this.gauge1.GaugeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gauge1.GaugeHolderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gauge1.InnerGaugeTxtColor = System.Drawing.Color.White;
            this.gauge1.Location = new System.Drawing.Point(373, 129);
            this.gauge1.Margin = new System.Windows.Forms.Padding(5);
            this.gauge1.MaxValue = 100F;
            this.gauge1.MinValue = 0F;
            this.gauge1.Name = "gauge1";
            this.gauge1.Size = new System.Drawing.Size(736, 201);
            this.gauge1.TabIndex = 0;
            this.gauge1.TextColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1480, 366);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.comboBox_Data);
            this.Controls.Add(this.btn_HideSettings);
            this.Controls.Add(this.panel_Settings);
            this.Controls.Add(this.lbl_InterfaceTitle);
            this.Controls.Add(this.gauge1);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauge de Puissance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel_Settings.ResumeLayout(false);
            this.panel_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GaugeV3.Gauge gauge1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_CurrentValue;
        private System.Windows.Forms.TextBox txtBox_MinVal;
        private System.Windows.Forms.TextBox txtBox_MaxVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_SubDivisions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_InterfaceTitle;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_DivMinus;
        private System.Windows.Forms.Button btn_DivPlus;
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Label lbl_nbDiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_HideSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox_Data;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
    }
}

