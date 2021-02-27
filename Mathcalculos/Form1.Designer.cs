
namespace Mathcalculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSinais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorImput = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinal";
            // 
            // cboSinais
            // 
            this.cboSinais.FormattingEnabled = true;
            this.cboSinais.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.cboSinais.Location = new System.Drawing.Point(171, 62);
            this.cboSinais.Name = "cboSinais";
            this.cboSinais.Size = new System.Drawing.Size(178, 21);
            this.cboSinais.TabIndex = 1;
            this.cboSinais.SelectedIndexChanged += new System.EventHandler(this.cboSinais_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // txtValorImput
            // 
            this.txtValorImput.Location = new System.Drawing.Point(47, 62);
            this.txtValorImput.Name = "txtValorImput";
            this.txtValorImput.Size = new System.Drawing.Size(100, 20);
            this.txtValorImput.TabIndex = 3;
            this.txtValorImput.HideSelectionChanged += new System.EventHandler(this.txtValorImput_HideSelectionChanged);
            this.txtValorImput.Leave += new System.EventHandler(this.txtValorImput_HideSelectionChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(47, 162);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(330, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(44, 102);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(50, 13);
            this.lblFormula.TabIndex = 5;
            this.lblFormula.Text = "Fórmula: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(373, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValorImput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSinais);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSinais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorImput;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
    }
}

