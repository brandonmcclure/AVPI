namespace GAVPI
{
    partial class frm_AddEdit_SpeakAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddEdit_SpeakAction));
            this.chckMultiAdd = new System.Windows.Forms.CheckBox();
            this.txtTimesToAdd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSpeak = new System.Windows.Forms.Label();
            this.cbSpeechValue = new System.Windows.Forms.ComboBox();
            this.cbSpeechType = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chckMultiAdd
            // 
            this.chckMultiAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chckMultiAdd.AutoSize = true;
            this.chckMultiAdd.Location = new System.Drawing.Point(16, 140);
            this.chckMultiAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chckMultiAdd.Name = "chckMultiAdd";
            this.chckMultiAdd.Size = new System.Drawing.Size(149, 21);
            this.chckMultiAdd.TabIndex = 2;
            this.chckMultiAdd.Text = "Add Multiple Times";
            this.chckMultiAdd.UseVisualStyleBackColor = true;
            this.chckMultiAdd.CheckedChanged += new System.EventHandler(this.chckMultiAdd_CheckedChanged);
            // 
            // txtTimesToAdd
            // 
            this.txtTimesToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimesToAdd.Enabled = false;
            this.txtTimesToAdd.Location = new System.Drawing.Point(179, 138);
            this.txtTimesToAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimesToAdd.Name = "txtTimesToAdd";
            this.txtTimesToAdd.Size = new System.Drawing.Size(95, 22);
            this.txtTimesToAdd.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(396, 138);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(288, 138);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSpeak
            // 
            this.lblSpeak.AutoSize = true;
            this.lblSpeak.Location = new System.Drawing.Point(12, 34);
            this.lblSpeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeak.Name = "lblSpeak";
            this.lblSpeak.Size = new System.Drawing.Size(114, 17);
            this.lblSpeak.TabIndex = 16;
            this.lblSpeak.Text = "Speak Item Type";
            // 
            // cbSpeechValue
            // 
            this.cbSpeechValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpeechValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeechValue.FormattingEnabled = true;
            this.cbSpeechValue.Location = new System.Drawing.Point(137, 86);
            this.cbSpeechValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSpeechValue.Name = "cbSpeechValue";
            this.cbSpeechValue.Size = new System.Drawing.Size(368, 24);
            this.cbSpeechValue.TabIndex = 1;
            // 
            // cbSpeechType
            // 
            this.cbSpeechType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpeechType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeechType.FormattingEnabled = true;
            this.cbSpeechType.Location = new System.Drawing.Point(137, 31);
            this.cbSpeechType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSpeechType.Name = "cbSpeechType";
            this.cbSpeechType.Size = new System.Drawing.Size(368, 24);
            this.cbSpeechType.TabIndex = 0;
            this.cbSpeechType.SelectedIndexChanged += new System.EventHandler(this.cbSpeechType_SelectedIndexChanged);
            // 
            // frm_AddEdit_SpeakAction
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(523, 181);
            this.Controls.Add(this.cbSpeechType);
            this.Controls.Add(this.cbSpeechValue);
            this.Controls.Add(this.chckMultiAdd);
            this.Controls.Add(this.txtTimesToAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSpeak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(530, 207);
            this.Name = "frm_AddEdit_SpeakAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Speak Action";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckMultiAdd;
        private System.Windows.Forms.TextBox txtTimesToAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSpeak;
        private System.Windows.Forms.ComboBox cbSpeechValue;
        private System.Windows.Forms.ComboBox cbSpeechType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}