using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InterfaceGui
{
    partial class frm_filtroRelatorioFat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_filtroRelatorioFat));
            panel_filterdate = new Panel();
            label_datafinal = new Label();
            label_datainicial = new Label();
            dateTime_final = new DateTimePicker();
            dateTime_inicial = new DateTimePicker();
            panel1 = new Panel();
            btnBuscarFat = new Button();
            checkBox_cancelada = new CheckBox();
            checkBox_aprovada = new CheckBox();
            label1 = new Label();
            panel_filterdate.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_filterdate
            // 
            panel_filterdate.BorderStyle = BorderStyle.Fixed3D;
            panel_filterdate.Controls.Add(label_datafinal);
            panel_filterdate.Controls.Add(label_datainicial);
            panel_filterdate.Controls.Add(dateTime_final);
            panel_filterdate.Controls.Add(dateTime_inicial);
            resources.ApplyResources(panel_filterdate, "panel_filterdate");
            panel_filterdate.Name = "panel_filterdate";
            // 
            // label_datafinal
            // 
            resources.ApplyResources(label_datafinal, "label_datafinal");
            label_datafinal.Name = "label_datafinal";
            // 
            // label_datainicial
            // 
            resources.ApplyResources(label_datainicial, "label_datainicial");
            label_datainicial.Name = "label_datainicial";
            // 
            // dateTime_final
            // 
            resources.ApplyResources(dateTime_final, "dateTime_final");
            dateTime_final.Format = DateTimePickerFormat.Custom;
            dateTime_final.Name = "dateTime_final";
            dateTime_final.Value = new DateTime(2024, 1, 30, 0, 0, 0, 0);
            // 
            // dateTime_inicial
            // 
            resources.ApplyResources(dateTime_inicial, "dateTime_inicial");
            dateTime_inicial.Format = DateTimePickerFormat.Custom;
            dateTime_inicial.Name = "dateTime_inicial";
            dateTime_inicial.Value = new DateTime(2024, 1, 30, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnBuscarFat);
            panel1.Controls.Add(checkBox_cancelada);
            panel1.Controls.Add(checkBox_aprovada);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // btnBuscarFat
            // 
            btnBuscarFat.BackColor = SystemColors.ActiveBorder;
            resources.ApplyResources(btnBuscarFat, "btnBuscarFat");
            btnBuscarFat.Name = "btnBuscarFat";
            btnBuscarFat.UseVisualStyleBackColor = false;
            btnBuscarFat.Click += btnBuscarFat_Click;
            // 
            // checkBox_cancelada
            // 
            resources.ApplyResources(checkBox_cancelada, "checkBox_cancelada");
            checkBox_cancelada.Name = "checkBox_cancelada";
            checkBox_cancelada.UseVisualStyleBackColor = true;
            checkBox_cancelada.CheckedChanged += checkBox_cancelada_CheckedChanged;
            // 
            // checkBox_aprovada
            // 
            resources.ApplyResources(checkBox_aprovada, "checkBox_aprovada");
            checkBox_aprovada.Checked = true;
            checkBox_aprovada.CheckState = CheckState.Checked;
            checkBox_aprovada.Name = "checkBox_aprovada";
            checkBox_aprovada.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // frm_filtroRelatorioFat
            // 
            AccessibleRole = AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(226, 233, 242);
            Controls.Add(panel1);
            Controls.Add(panel_filterdate);
            Name = "frm_filtroRelatorioFat";
            SizeGripStyle = SizeGripStyle.Hide;
            panel_filterdate.ResumeLayout(false);
            panel_filterdate.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnBuscarFat_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTime_inicial.Value;
            DateTime dataFinal = dateTime_final.Value;
                        

        }

        private void checkBox_cancelada_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel_filterdate;
        private DateTimePicker dateTime_final;        
        private DateTimePicker dateTime_inicial;
        private Label label_datafinal;
        private Label label_datainicial;
        private Panel panel1;
        private Label label1;
        private CheckBox checkBox_cancelada;
        private CheckBox checkBox_aprovada;
        private Button btnBuscarFat;
    }
}