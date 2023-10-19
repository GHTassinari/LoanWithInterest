namespace JurosFinanciamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblLoanValue = new System.Windows.Forms.Label();
            this.txtLoanValue = new System.Windows.Forms.TextBox();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.lblNumberOfInstallments = new System.Windows.Forms.Label();
            this.txtNumberOfInstallments = new System.Windows.Forms.TextBox();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.lblInstallmentlValue = new System.Windows.Forms.Label();
            this.lblTotalnterestValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlLeft.Font = new System.Drawing.Font("Noto Serif Cond", 15.75F);
            this.pnlLeft.Location = new System.Drawing.Point(12, 12);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 426);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlRight.Location = new System.Drawing.Point(588, 12);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(200, 426);
            this.pnlRight.TabIndex = 1;
            // 
            // lblLoanValue
            // 
            this.lblLoanValue.AutoSize = true;
            this.lblLoanValue.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.lblLoanValue.Location = new System.Drawing.Point(291, 32);
            this.lblLoanValue.Name = "lblLoanValue";
            this.lblLoanValue.Size = new System.Drawing.Size(222, 28);
            this.lblLoanValue.TabIndex = 2;
            this.lblLoanValue.Text = "Valor do empréstimo";
            this.lblLoanValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoanValue
            // 
            this.txtLoanValue.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.txtLoanValue.Location = new System.Drawing.Point(296, 63);
            this.txtLoanValue.Name = "txtLoanValue";
            this.txtLoanValue.Size = new System.Drawing.Size(210, 29);
            this.txtLoanValue.TabIndex = 0;
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(275, 95);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(261, 28);
            this.lblAnnualInterestRate.TabIndex = 4;
            this.lblAnnualInterestRate.Text = "Taxa de juros anual em %";
            this.lblAnnualInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(296, 126);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(210, 29);
            this.txtAnnualInterestRate.TabIndex = 1;
            // 
            // lblNumberOfInstallments
            // 
            this.lblNumberOfInstallments.AutoSize = true;
            this.lblNumberOfInstallments.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.lblNumberOfInstallments.Location = new System.Drawing.Point(293, 158);
            this.lblNumberOfInstallments.Name = "lblNumberOfInstallments";
            this.lblNumberOfInstallments.Size = new System.Drawing.Size(213, 28);
            this.lblNumberOfInstallments.TabIndex = 6;
            this.lblNumberOfInstallments.Text = "Número de parcelas";
            this.lblNumberOfInstallments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberOfInstallments
            // 
            this.txtNumberOfInstallments.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.txtNumberOfInstallments.Location = new System.Drawing.Point(296, 189);
            this.txtNumberOfInstallments.Name = "txtNumberOfInstallments";
            this.txtNumberOfInstallments.Size = new System.Drawing.Size(210, 29);
            this.txtNumberOfInstallments.TabIndex = 2;
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculateInterest.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.btnCalculateInterest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculateInterest.Image = global::JurosFinanciamento.Properties.Resources.taxa_de_juro;
            this.btnCalculateInterest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateInterest.Location = new System.Drawing.Point(296, 224);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(208, 35);
            this.btnCalculateInterest.TabIndex = 3;
            this.btnCalculateInterest.Text = "Calcular o total";
            this.btnCalculateInterest.UseVisualStyleBackColor = false;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // lblInstallmentlValue
            // 
            this.lblInstallmentlValue.AutoSize = true;
            this.lblInstallmentlValue.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblInstallmentlValue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInstallmentlValue.Location = new System.Drawing.Point(230, 285);
            this.lblInstallmentlValue.Name = "lblInstallmentlValue";
            this.lblInstallmentlValue.Size = new System.Drawing.Size(137, 22);
            this.lblInstallmentlValue.TabIndex = 9;
            this.lblInstallmentlValue.Text = "Valor da parcela:";
            this.lblInstallmentlValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalnterestValue
            // 
            this.lblTotalnterestValue.AutoSize = true;
            this.lblTotalnterestValue.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblTotalnterestValue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalnterestValue.Location = new System.Drawing.Point(230, 327);
            this.lblTotalnterestValue.Name = "lblTotalnterestValue";
            this.lblTotalnterestValue.Size = new System.Drawing.Size(122, 22);
            this.lblTotalnterestValue.TabIndex = 10;
            this.lblTotalnterestValue.Text = "Total em juros:";
            this.lblTotalnterestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblTotalValue.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalValue.Location = new System.Drawing.Point(230, 367);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(94, 22);
            this.lblTotalValue.TabIndex = 11;
            this.lblTotalValue.Text = "Total pago:";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotalnterestValue);
            this.Controls.Add(this.lblInstallmentlValue);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.txtNumberOfInstallments);
            this.Controls.Add(this.lblNumberOfInstallments);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.lblAnnualInterestRate);
            this.Controls.Add(this.txtLoanValue);
            this.Controls.Add(this.lblLoanValue);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLoanValue;
        private System.Windows.Forms.TextBox txtLoanValue;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.Label lblNumberOfInstallments;
        private System.Windows.Forms.TextBox txtNumberOfInstallments;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Label lblInstallmentlValue;
        private System.Windows.Forms.Label lblTotalnterestValue;
        private System.Windows.Forms.Label lblTotalValue;
    }
}

