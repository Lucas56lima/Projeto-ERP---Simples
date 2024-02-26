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
            label_pagamento = new Label();
            label_parcela = new Label();
            listBox_parcelas = new ListBox();
            label_troco = new Label();
            label_valortroco = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox_pagamentos
            // 
            listBox_pagamentos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_pagamentos.FormattingEnabled = true;
            listBox_pagamentos.IntegralHeight = false;
            listBox_pagamentos.ItemHeight = 17;
            listBox_pagamentos.Location = new Point(104, 12);
            listBox_pagamentos.Name = "listBox_pagamentos";
            listBox_pagamentos.Size = new Size(103, 24);
            listBox_pagamentos.TabIndex = 0;
            // 
            // label_pagamento
            // 
            label_pagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_pagamento.Location = new Point(33, 12);
            label_pagamento.Name = "label_pagamento";
            label_pagamento.Size = new Size(66, 24);
            label_pagamento.TabIndex = 1;
            label_pagamento.Text = "Método";
            label_pagamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_parcela
            // 
            label_parcela.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_parcela.Location = new Point(33, 50);
            label_parcela.Name = "label_parcela";
            label_parcela.Size = new Size(66, 24);
            label_parcela.TabIndex = 3;
            label_parcela.Text = "Parcelas";
            label_parcela.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox_parcelas
            // 
            listBox_parcelas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_parcelas.FormattingEnabled = true;
            listBox_parcelas.IntegralHeight = false;
            listBox_parcelas.ItemHeight = 17;
            listBox_parcelas.Location = new Point(104, 50);
            listBox_parcelas.Name = "listBox_parcelas";
            listBox_parcelas.Size = new Size(103, 24);
            listBox_parcelas.TabIndex = 2;
            // 
            // label_troco
            // 
            label_troco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_troco.Location = new Point(32, 92);
            label_troco.Name = "label_troco";
            label_troco.Size = new Size(66, 24);
            label_troco.TabIndex = 4;
            label_troco.Text = "Troco";
            label_troco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_valortroco
            // 
            label_valortroco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_valortroco.Location = new Point(104, 92);
            label_valortroco.Name = "label_valortroco";
            label_valortroco.Size = new Size(103, 24);
            label_valortroco.TabIndex = 5;
            label_valortroco.Text = "0,00";
            label_valortroco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 133);
            label1.Name = "label1";
            label1.Size = new Size(103, 38);
            label1.TabIndex = 7;
            label1.Text = "0,00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 133);
            label2.Name = "label2";
            label2.Size = new Size(66, 38);
            label2.TabIndex = 6;
            label2.Text = "Total";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frm_pagamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 189);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label_valortroco);
            Controls.Add(label_troco);
            Controls.Add(label_parcela);
            Controls.Add(listBox_parcelas);
            Controls.Add(label_pagamento);
            Controls.Add(listBox_pagamentos);
            Name = "frm_pagamentos";
            Text = "frm_pagamentos";
            ResumeLayout(false);
        }

        #endregion

        private Label label_pagamento;
        public ListBox listBox_pagamentos;
        private Label label_parcela;
        public ListBox listBox_parcelas;
        private Label label_troco;
        private Label label_valortroco;
        private Label label1;
        private Label label2;
    }
}