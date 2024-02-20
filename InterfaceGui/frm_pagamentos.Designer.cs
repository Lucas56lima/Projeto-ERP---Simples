namespace InterfaceGui
{
    partial class frm_pagamentos
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
            listBox_pagamentos = new ListBox();
            SuspendLayout();
            // 
            // listBox_pagamentos
            // 
            listBox_pagamentos.FormattingEnabled = true;
            listBox_pagamentos.ItemHeight = 15;
            listBox_pagamentos.Location = new Point(90, 12);
            listBox_pagamentos.Name = "listBox_pagamentos";
            listBox_pagamentos.Size = new Size(103, 34);
            listBox_pagamentos.TabIndex = 0;
            // 
            // frm_pagamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 212);
            Controls.Add(listBox_pagamentos);
            Name = "frm_pagamentos";
            Text = "frm_pagamentos";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_pagamentos;
    }
}