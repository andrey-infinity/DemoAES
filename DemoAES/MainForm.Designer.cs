namespace DemoAES
{
    partial class MainForm
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
            this.bt_decrypt = new System.Windows.Forms.Button();
            this.bt_encrypt = new System.Windows.Forms.Button();
            this.OD = new System.Windows.Forms.OpenFileDialog();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.lb_new_file_path = new System.Windows.Forms.Label();
            this.lb_file_path = new System.Windows.Forms.Label();
            this.lb_key = new System.Windows.Forms.Label();
            this.key_path = new System.Windows.Forms.TextBox();
            this.bt_key_select = new System.Windows.Forms.Button();
            this.txt_new_file_path = new System.Windows.Forms.TextBox();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.bt_file_select = new System.Windows.Forms.Button();
            this.isHex = new System.Windows.Forms.CheckBox();
            this.ViewMatixGroup = new System.Windows.Forms.GroupBox();
            this.bt_step = new System.Windows.Forms.Button();
            this.isAuto = new System.Windows.Forms.CheckBox();
            this.bt_clipboard = new System.Windows.Forms.Button();
            this.ViewMatrix = new DemoAES.MatrixState();
            this.BoxFileCrypt.SuspendLayout();
            this.ViewMatixGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_decrypt
            // 
            this.bt_decrypt.Location = new System.Drawing.Point(90, 133);
            this.bt_decrypt.Name = "bt_decrypt";
            this.bt_decrypt.Size = new System.Drawing.Size(75, 23);
            this.bt_decrypt.TabIndex = 0;
            this.bt_decrypt.Text = "Decry";
            this.bt_decrypt.UseVisualStyleBackColor = true;
            this.bt_decrypt.Click += new System.EventHandler(this.bt_decrypt_Click);
            // 
            // bt_encrypt
            // 
            this.bt_encrypt.Location = new System.Drawing.Point(9, 133);
            this.bt_encrypt.Name = "bt_encrypt";
            this.bt_encrypt.Size = new System.Drawing.Size(75, 24);
            this.bt_encrypt.TabIndex = 1;
            this.bt_encrypt.Text = "Encry";
            this.bt_encrypt.UseVisualStyleBackColor = true;
            this.bt_encrypt.Click += new System.EventHandler(this.bt_encrypt_Click);
            // 
            // OD
            // 
            this.OD.FileName = "openFileDialog1";
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.Controls.Add(this.lb_new_file_path);
            this.BoxFileCrypt.Controls.Add(this.bt_decrypt);
            this.BoxFileCrypt.Controls.Add(this.bt_encrypt);
            this.BoxFileCrypt.Controls.Add(this.lb_file_path);
            this.BoxFileCrypt.Controls.Add(this.lb_key);
            this.BoxFileCrypt.Controls.Add(this.key_path);
            this.BoxFileCrypt.Controls.Add(this.bt_key_select);
            this.BoxFileCrypt.Controls.Add(this.txt_new_file_path);
            this.BoxFileCrypt.Controls.Add(this.txt_file_path);
            this.BoxFileCrypt.Controls.Add(this.txt_key);
            this.BoxFileCrypt.Controls.Add(this.bt_file_select);
            this.BoxFileCrypt.Location = new System.Drawing.Point(12, 12);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Size = new System.Drawing.Size(416, 165);
            this.BoxFileCrypt.TabIndex = 16;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "Encryption and Decryption for files";
            // 
            // lb_new_file_path
            // 
            this.lb_new_file_path.AutoSize = true;
            this.lb_new_file_path.Location = new System.Drawing.Point(6, 46);
            this.lb_new_file_path.Name = "lb_new_file_path";
            this.lb_new_file_path.Size = new System.Drawing.Size(86, 15);
            this.lb_new_file_path.TabIndex = 17;
            this.lb_new_file_path.Text = "New File Path:";
            // 
            // lb_file_path
            // 
            this.lb_file_path.AutoSize = true;
            this.lb_file_path.Location = new System.Drawing.Point(6, 20);
            this.lb_file_path.Name = "lb_file_path";
            this.lb_file_path.Size = new System.Drawing.Size(58, 15);
            this.lb_file_path.TabIndex = 17;
            this.lb_file_path.Text = "File Path:";
            // 
            // lb_key
            // 
            this.lb_key.AutoSize = true;
            this.lb_key.Location = new System.Drawing.Point(6, 76);
            this.lb_key.Name = "lb_key";
            this.lb_key.Size = new System.Drawing.Size(58, 15);
            this.lb_key.TabIndex = 17;
            this.lb_key.Text = "Key Path:";
            // 
            // key_path
            // 
            this.key_path.Location = new System.Drawing.Point(92, 74);
            this.key_path.Name = "key_path";
            this.key_path.ReadOnly = true;
            this.key_path.Size = new System.Drawing.Size(243, 20);
            this.key_path.TabIndex = 27;
            // 
            // bt_key_select
            // 
            this.bt_key_select.Location = new System.Drawing.Point(341, 71);
            this.bt_key_select.Name = "bt_key_select";
            this.bt_key_select.Size = new System.Drawing.Size(64, 23);
            this.bt_key_select.TabIndex = 26;
            this.bt_key_select.Text = "Key..";
            this.bt_key_select.UseVisualStyleBackColor = true;
            this.bt_key_select.Click += new System.EventHandler(this.bt_key_select_Click);
            // 
            // txt_new_file_path
            // 
            this.txt_new_file_path.Location = new System.Drawing.Point(92, 43);
            this.txt_new_file_path.Name = "txt_new_file_path";
            this.txt_new_file_path.ReadOnly = true;
            this.txt_new_file_path.Size = new System.Drawing.Size(243, 20);
            this.txt_new_file_path.TabIndex = 24;
            // 
            // txt_file_path
            // 
            this.txt_file_path.Location = new System.Drawing.Point(92, 17);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.ReadOnly = true;
            this.txt_file_path.Size = new System.Drawing.Size(243, 20);
            this.txt_file_path.TabIndex = 5;
            // 
            // txt_key
            // 
            this.txt_key.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_key.Location = new System.Drawing.Point(92, 100);
            this.txt_key.MaxLength = 32;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(313, 20);
            this.txt_key.TabIndex = 23;
            this.txt_key.Text = "31273812637812637812638721564523";
            // 
            // bt_file_select
            // 
            this.bt_file_select.Location = new System.Drawing.Point(340, 17);
            this.bt_file_select.Name = "bt_file_select";
            this.bt_file_select.Size = new System.Drawing.Size(64, 23);
            this.bt_file_select.TabIndex = 16;
            this.bt_file_select.Text = "Files..";
            this.bt_file_select.UseVisualStyleBackColor = true;
            this.bt_file_select.Click += new System.EventHandler(this.bt_file_select_Click);
            // 
            // isHex
            // 
            this.isHex.AutoSize = true;
            this.isHex.Location = new System.Drawing.Point(9, 202);
            this.isHex.Name = "isHex";
            this.isHex.Size = new System.Drawing.Size(57, 19);
            this.isHex.TabIndex = 17;
            this.isHex.Text = "isHex";
            this.isHex.UseVisualStyleBackColor = true;
            this.isHex.CheckedChanged += new System.EventHandler(this.isHex_CheckedChanged);
            // 
            // ViewMatixGroup
            // 
            this.ViewMatixGroup.Controls.Add(this.bt_clipboard);
            this.ViewMatixGroup.Controls.Add(this.bt_step);
            this.ViewMatixGroup.Controls.Add(this.isAuto);
            this.ViewMatixGroup.Controls.Add(this.ViewMatrix);
            this.ViewMatixGroup.Controls.Add(this.isHex);
            this.ViewMatixGroup.Location = new System.Drawing.Point(12, 203);
            this.ViewMatixGroup.Name = "ViewMatixGroup";
            this.ViewMatixGroup.Size = new System.Drawing.Size(416, 235);
            this.ViewMatixGroup.TabIndex = 19;
            this.ViewMatixGroup.TabStop = false;
            this.ViewMatixGroup.Text = "State Matrix";
            // 
            // bt_step
            // 
            this.bt_step.Location = new System.Drawing.Point(137, 199);
            this.bt_step.Name = "bt_step";
            this.bt_step.Size = new System.Drawing.Size(75, 23);
            this.bt_step.TabIndex = 20;
            this.bt_step.Text = "Step";
            this.bt_step.UseVisualStyleBackColor = true;
            this.bt_step.Click += new System.EventHandler(this.bt_step_Click);
            // 
            // isAuto
            // 
            this.isAuto.AutoSize = true;
            this.isAuto.Location = new System.Drawing.Point(72, 202);
            this.isAuto.Name = "isAuto";
            this.isAuto.Size = new System.Drawing.Size(59, 19);
            this.isAuto.TabIndex = 19;
            this.isAuto.Text = "isAuto";
            this.isAuto.UseVisualStyleBackColor = true;
            // 
            // bt_clipboard
            // 
            this.bt_clipboard.Location = new System.Drawing.Point(218, 199);
            this.bt_clipboard.Name = "bt_clipboard";
            this.bt_clipboard.Size = new System.Drawing.Size(117, 22);
            this.bt_clipboard.TabIndex = 21;
            this.bt_clipboard.Text = "Copy To ClipBoard";
            this.bt_clipboard.UseVisualStyleBackColor = true;
            this.bt_clipboard.Click += new System.EventHandler(this.bt_clipboard_Click);
            // 
            // ViewMatrix
            // 
            this.ViewMatrix.Hex = false;
            this.ViewMatrix.Location = new System.Drawing.Point(9, 19);
            this.ViewMatrix.Name = "ViewMatrix";
            this.ViewMatrix.Size = new System.Drawing.Size(306, 178);
            this.ViewMatrix.State = null;
            this.ViewMatrix.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.ViewMatixGroup);
            this.Controls.Add(this.BoxFileCrypt);
            this.Name = "MainForm";
            this.Text = "DemoAES";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.ViewMatixGroup.ResumeLayout(false);
            this.ViewMatixGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_decrypt;
        private System.Windows.Forms.Button bt_encrypt;
        private System.Windows.Forms.OpenFileDialog OD;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.TextBox key_path;
        private System.Windows.Forms.Button bt_key_select;
        private System.Windows.Forms.TextBox txt_new_file_path;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button bt_file_select;
        private System.Windows.Forms.Label lb_file_path;
        private System.Windows.Forms.Label lb_key;
        private System.Windows.Forms.Label lb_new_file_path;
        private System.Windows.Forms.CheckBox isHex;
        private MatrixState ViewMatrix;
        private System.Windows.Forms.GroupBox ViewMatixGroup;
        private System.Windows.Forms.CheckBox isAuto;
        private System.Windows.Forms.Button bt_step;
        private System.Windows.Forms.Button bt_clipboard;
    }
}

