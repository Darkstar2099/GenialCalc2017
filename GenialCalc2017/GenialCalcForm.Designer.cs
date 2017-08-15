namespace GenialCalc2017
{
    partial class GenialCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenialCalcForm));
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.BtnDivisao = new System.Windows.Forms.Button();
            this.BtnMultiplicacao = new System.Windows.Forms.Button();
            this.BtnSubtracao = new System.Windows.Forms.Button();
            this.BtnAdicao = new System.Windows.Forms.Button();
            this.BtnCalcula = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCancelEntry = new System.Windows.Forms.Button();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.BtnNum0 = new System.Windows.Forms.Button();
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.BtnNum3 = new System.Windows.Forms.Button();
            this.BtnNum6 = new System.Windows.Forms.Button();
            this.BtnNum5 = new System.Windows.Forms.Button();
            this.BtnNum4 = new System.Windows.Forms.Button();
            this.BtnNum9 = new System.Windows.Forms.Button();
            this.BtnNum8 = new System.Windows.Forms.Button();
            this.BtnNum7 = new System.Windows.Forms.Button();
            this.BtnSeparadorDecimal = new System.Windows.Forms.Button();
            this.BtnLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpressao
            // 
            this.txtExpressao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtExpressao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpressao.Enabled = false;
            this.txtExpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpressao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtExpressao.Location = new System.Drawing.Point(12, 12);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(378, 34);
            this.txtExpressao.TabIndex = 0;
            this.txtExpressao.TabStop = false;
            this.txtExpressao.Text = "0";
            this.txtExpressao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 52);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(378, 42);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnDivisao
            // 
            this.BtnDivisao.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDivisao.FlatAppearance.BorderSize = 0;
            this.BtnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisao.Location = new System.Drawing.Point(300, 100);
            this.BtnDivisao.Name = "BtnDivisao";
            this.BtnDivisao.Size = new System.Drawing.Size(90, 60);
            this.BtnDivisao.TabIndex = 2;
            this.BtnDivisao.Text = "/";
            this.BtnDivisao.UseVisualStyleBackColor = false;
            this.BtnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMultiplicacao.FlatAppearance.BorderSize = 0;
            this.BtnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacao.Location = new System.Drawing.Point(300, 166);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.Size = new System.Drawing.Size(90, 60);
            this.BtnMultiplicacao.TabIndex = 3;
            this.BtnMultiplicacao.Text = "x";
            this.BtnMultiplicacao.UseVisualStyleBackColor = false;
            this.BtnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // BtnSubtracao
            // 
            this.BtnSubtracao.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSubtracao.FlatAppearance.BorderSize = 0;
            this.BtnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtracao.Location = new System.Drawing.Point(300, 232);
            this.BtnSubtracao.Name = "BtnSubtracao";
            this.BtnSubtracao.Size = new System.Drawing.Size(90, 60);
            this.BtnSubtracao.TabIndex = 4;
            this.BtnSubtracao.Text = "-";
            this.BtnSubtracao.UseVisualStyleBackColor = false;
            this.BtnSubtracao.Click += new System.EventHandler(this.BtnSubtracao_Click);
            // 
            // BtnAdicao
            // 
            this.BtnAdicao.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdicao.FlatAppearance.BorderSize = 0;
            this.BtnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicao.Location = new System.Drawing.Point(300, 298);
            this.BtnAdicao.Name = "BtnAdicao";
            this.BtnAdicao.Size = new System.Drawing.Size(90, 60);
            this.BtnAdicao.TabIndex = 5;
            this.BtnAdicao.Text = "+";
            this.BtnAdicao.UseVisualStyleBackColor = false;
            this.BtnAdicao.Click += new System.EventHandler(this.BtnAdicao_Click);
            // 
            // BtnCalcula
            // 
            this.BtnCalcula.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCalcula.FlatAppearance.BorderSize = 0;
            this.BtnCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcula.Location = new System.Drawing.Point(300, 364);
            this.BtnCalcula.Name = "BtnCalcula";
            this.BtnCalcula.Size = new System.Drawing.Size(90, 60);
            this.BtnCalcula.TabIndex = 6;
            this.BtnCalcula.Text = "=";
            this.BtnCalcula.UseVisualStyleBackColor = false;
            this.BtnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 100);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 60);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "C";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCancelEntry
            // 
            this.BtnCancelEntry.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelEntry.FlatAppearance.BorderSize = 0;
            this.BtnCancelEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelEntry.Location = new System.Drawing.Point(108, 100);
            this.BtnCancelEntry.Name = "BtnCancelEntry";
            this.BtnCancelEntry.Size = new System.Drawing.Size(90, 60);
            this.BtnCancelEntry.TabIndex = 8;
            this.BtnCancelEntry.Text = "CE";
            this.BtnCancelEntry.UseVisualStyleBackColor = false;
            this.BtnCancelEntry.Click += new System.EventHandler(this.BtnCancelEntry_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackSpace.Location = new System.Drawing.Point(204, 100);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(90, 60);
            this.BtnBackSpace.TabIndex = 9;
            this.BtnBackSpace.Text = "BS";
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // BtnNum0
            // 
            this.BtnNum0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum0.FlatAppearance.BorderSize = 0;
            this.BtnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum0.Location = new System.Drawing.Point(108, 364);
            this.BtnNum0.Name = "BtnNum0";
            this.BtnNum0.Size = new System.Drawing.Size(90, 60);
            this.BtnNum0.TabIndex = 10;
            this.BtnNum0.Text = "0";
            this.BtnNum0.UseVisualStyleBackColor = false;
            this.BtnNum0.Click += new System.EventHandler(this.BtnNum0_Click);
            // 
            // BtnNum1
            // 
            this.BtnNum1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum1.FlatAppearance.BorderSize = 0;
            this.BtnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum1.Location = new System.Drawing.Point(12, 298);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(90, 60);
            this.BtnNum1.TabIndex = 11;
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = false;
            this.BtnNum1.Click += new System.EventHandler(this.BtnNum1_Click);
            // 
            // BtnNum2
            // 
            this.BtnNum2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum2.FlatAppearance.BorderSize = 0;
            this.BtnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum2.Location = new System.Drawing.Point(108, 298);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(90, 60);
            this.BtnNum2.TabIndex = 12;
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = false;
            this.BtnNum2.Click += new System.EventHandler(this.BtnNum2_Click);
            // 
            // BtnNum3
            // 
            this.BtnNum3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum3.FlatAppearance.BorderSize = 0;
            this.BtnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum3.Location = new System.Drawing.Point(204, 298);
            this.BtnNum3.Name = "BtnNum3";
            this.BtnNum3.Size = new System.Drawing.Size(90, 60);
            this.BtnNum3.TabIndex = 13;
            this.BtnNum3.Text = "3";
            this.BtnNum3.UseVisualStyleBackColor = false;
            this.BtnNum3.Click += new System.EventHandler(this.BtnNum3_Click);
            // 
            // BtnNum6
            // 
            this.BtnNum6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum6.FlatAppearance.BorderSize = 0;
            this.BtnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum6.Location = new System.Drawing.Point(204, 232);
            this.BtnNum6.Name = "BtnNum6";
            this.BtnNum6.Size = new System.Drawing.Size(90, 60);
            this.BtnNum6.TabIndex = 16;
            this.BtnNum6.Text = "6";
            this.BtnNum6.UseVisualStyleBackColor = false;
            this.BtnNum6.Click += new System.EventHandler(this.BtnNum6_Click);
            // 
            // BtnNum5
            // 
            this.BtnNum5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum5.FlatAppearance.BorderSize = 0;
            this.BtnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum5.Location = new System.Drawing.Point(108, 232);
            this.BtnNum5.Name = "BtnNum5";
            this.BtnNum5.Size = new System.Drawing.Size(90, 60);
            this.BtnNum5.TabIndex = 15;
            this.BtnNum5.Text = "5";
            this.BtnNum5.UseVisualStyleBackColor = false;
            this.BtnNum5.Click += new System.EventHandler(this.BtnNum5_Click);
            // 
            // BtnNum4
            // 
            this.BtnNum4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum4.FlatAppearance.BorderSize = 0;
            this.BtnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum4.Location = new System.Drawing.Point(12, 232);
            this.BtnNum4.Name = "BtnNum4";
            this.BtnNum4.Size = new System.Drawing.Size(90, 60);
            this.BtnNum4.TabIndex = 14;
            this.BtnNum4.Text = "4";
            this.BtnNum4.UseVisualStyleBackColor = false;
            this.BtnNum4.Click += new System.EventHandler(this.BtnNum4_Click);
            // 
            // BtnNum9
            // 
            this.BtnNum9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum9.FlatAppearance.BorderSize = 0;
            this.BtnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum9.Location = new System.Drawing.Point(204, 166);
            this.BtnNum9.Name = "BtnNum9";
            this.BtnNum9.Size = new System.Drawing.Size(90, 60);
            this.BtnNum9.TabIndex = 19;
            this.BtnNum9.Text = "9";
            this.BtnNum9.UseVisualStyleBackColor = false;
            this.BtnNum9.Click += new System.EventHandler(this.BtnNum9_Click);
            // 
            // BtnNum8
            // 
            this.BtnNum8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum8.FlatAppearance.BorderSize = 0;
            this.BtnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum8.Location = new System.Drawing.Point(108, 166);
            this.BtnNum8.Name = "BtnNum8";
            this.BtnNum8.Size = new System.Drawing.Size(90, 60);
            this.BtnNum8.TabIndex = 18;
            this.BtnNum8.Text = "8";
            this.BtnNum8.UseVisualStyleBackColor = false;
            this.BtnNum8.Click += new System.EventHandler(this.BtnNum8_Click);
            // 
            // BtnNum7
            // 
            this.BtnNum7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNum7.FlatAppearance.BorderSize = 0;
            this.BtnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNum7.Location = new System.Drawing.Point(12, 166);
            this.BtnNum7.Name = "BtnNum7";
            this.BtnNum7.Size = new System.Drawing.Size(90, 60);
            this.BtnNum7.TabIndex = 17;
            this.BtnNum7.Text = "7";
            this.BtnNum7.UseVisualStyleBackColor = false;
            this.BtnNum7.Click += new System.EventHandler(this.BtnNum7_Click);
            // 
            // BtnSeparadorDecimal
            // 
            this.BtnSeparadorDecimal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSeparadorDecimal.FlatAppearance.BorderSize = 0;
            this.BtnSeparadorDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeparadorDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeparadorDecimal.Location = new System.Drawing.Point(204, 364);
            this.BtnSeparadorDecimal.Name = "BtnSeparadorDecimal";
            this.BtnSeparadorDecimal.Size = new System.Drawing.Size(90, 60);
            this.BtnSeparadorDecimal.TabIndex = 20;
            this.BtnSeparadorDecimal.Text = ",";
            this.BtnSeparadorDecimal.UseVisualStyleBackColor = false;
            this.BtnSeparadorDecimal.Click += new System.EventHandler(this.BtnSeparadorDecimal_Click);
            // 
            // BtnLogo
            // 
            this.BtnLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnLogo.BackgroundImage = global::GenialCalc2017.Properties.Resources.Genial_Calc_Logo;
            this.BtnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogo.FlatAppearance.BorderSize = 0;
            this.BtnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogo.Location = new System.Drawing.Point(12, 364);
            this.BtnLogo.Name = "BtnLogo";
            this.BtnLogo.Size = new System.Drawing.Size(90, 60);
            this.BtnLogo.TabIndex = 21;
            this.BtnLogo.TabStop = false;
            this.BtnLogo.UseVisualStyleBackColor = false;
            // 
            // GenialCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(407, 444);
            this.Controls.Add(this.BtnLogo);
            this.Controls.Add(this.BtnSeparadorDecimal);
            this.Controls.Add(this.BtnNum9);
            this.Controls.Add(this.BtnNum8);
            this.Controls.Add(this.BtnNum7);
            this.Controls.Add(this.BtnNum6);
            this.Controls.Add(this.BtnNum5);
            this.Controls.Add(this.BtnNum4);
            this.Controls.Add(this.BtnNum3);
            this.Controls.Add(this.BtnNum2);
            this.Controls.Add(this.BtnNum1);
            this.Controls.Add(this.BtnNum0);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.BtnCancelEntry);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCalcula);
            this.Controls.Add(this.BtnAdicao);
            this.Controls.Add(this.BtnSubtracao);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.BtnDivisao);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtExpressao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GenialCalcForm";
            this.Text = "GENIAL Calc";
            this.Load += new System.EventHandler(this.GenialCalcForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenialCalcForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GenialCalcForm_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button BtnDivisao;
        private System.Windows.Forms.Button BtnMultiplicacao;
        private System.Windows.Forms.Button BtnSubtracao;
        private System.Windows.Forms.Button BtnAdicao;
        private System.Windows.Forms.Button BtnCalcula;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCancelEntry;
        private System.Windows.Forms.Button BtnBackSpace;
        private System.Windows.Forms.Button BtnNum0;
        private System.Windows.Forms.Button BtnNum1;
        private System.Windows.Forms.Button BtnNum2;
        private System.Windows.Forms.Button BtnNum3;
        private System.Windows.Forms.Button BtnNum6;
        private System.Windows.Forms.Button BtnNum5;
        private System.Windows.Forms.Button BtnNum4;
        private System.Windows.Forms.Button BtnNum9;
        private System.Windows.Forms.Button BtnNum8;
        private System.Windows.Forms.Button BtnNum7;
        private System.Windows.Forms.Button BtnSeparadorDecimal;
        private System.Windows.Forms.Button BtnLogo;
    }
}

