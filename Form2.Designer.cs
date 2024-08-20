namespace projeto_atividade_final
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcule = new System.Windows.Forms.Button();
            this.txtpesoterra = new System.Windows.Forms.TextBox();
            this.rdmerc = new System.Windows.Forms.RadioButton();
            this.rdurano = new System.Windows.Forms.RadioButton();
            this.rdjupiter = new System.Windows.Forms.RadioButton();
            this.rdvenus = new System.Windows.Forms.RadioButton();
            this.rdsat = new System.Windows.Forms.RadioButton();
            this.rdmarte = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CALCULO DO PESO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PESO NA TERRA :";
            // 
            // btncalcule
            // 
            this.btncalcule.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalcule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcule.Location = new System.Drawing.Point(312, 112);
            this.btncalcule.Name = "btncalcule";
            this.btncalcule.Size = new System.Drawing.Size(62, 24);
            this.btncalcule.TabIndex = 4;
            this.btncalcule.Text = "EXIBIR PESO";
            this.btncalcule.UseVisualStyleBackColor = false;
            this.btncalcule.Click += new System.EventHandler(this.btncalcule_Click);
            // 
            // txtpesoterra
            // 
            this.txtpesoterra.Location = new System.Drawing.Point(301, 87);
            this.txtpesoterra.Name = "txtpesoterra";
            this.txtpesoterra.Size = new System.Drawing.Size(90, 20);
            this.txtpesoterra.TabIndex = 6;
            // 
            // rdmerc
            // 
            this.rdmerc.AutoSize = true;
            this.rdmerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmerc.Location = new System.Drawing.Point(138, 119);
            this.rdmerc.Name = "rdmerc";
            this.rdmerc.Size = new System.Drawing.Size(91, 17);
            this.rdmerc.TabIndex = 7;
            this.rdmerc.TabStop = true;
            this.rdmerc.Text = "MERCURIO";
            this.rdmerc.UseVisualStyleBackColor = true;
            // 
            // rdurano
            // 
            this.rdurano.AutoSize = true;
            this.rdurano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdurano.Location = new System.Drawing.Point(138, 188);
            this.rdurano.Name = "rdurano";
            this.rdurano.Size = new System.Drawing.Size(69, 17);
            this.rdurano.TabIndex = 8;
            this.rdurano.TabStop = true;
            this.rdurano.Text = "URANO";
            this.rdurano.UseVisualStyleBackColor = true;
            // 
            // rdjupiter
            // 
            this.rdjupiter.AutoSize = true;
            this.rdjupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdjupiter.Location = new System.Drawing.Point(138, 234);
            this.rdjupiter.Name = "rdjupiter";
            this.rdjupiter.Size = new System.Drawing.Size(77, 17);
            this.rdjupiter.TabIndex = 9;
            this.rdjupiter.TabStop = true;
            this.rdjupiter.Text = "JUPITER";
            this.rdjupiter.UseVisualStyleBackColor = true;
            // 
            // rdvenus
            // 
            this.rdvenus.AutoSize = true;
            this.rdvenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvenus.Location = new System.Drawing.Point(138, 142);
            this.rdvenus.Name = "rdvenus";
            this.rdvenus.Size = new System.Drawing.Size(67, 17);
            this.rdvenus.TabIndex = 10;
            this.rdvenus.TabStop = true;
            this.rdvenus.Text = "VENUS";
            this.rdvenus.UseVisualStyleBackColor = true;
            // 
            // rdsat
            // 
            this.rdsat.AutoSize = true;
            this.rdsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsat.Location = new System.Drawing.Point(138, 211);
            this.rdsat.Name = "rdsat";
            this.rdsat.Size = new System.Drawing.Size(85, 17);
            this.rdsat.TabIndex = 11;
            this.rdsat.TabStop = true;
            this.rdsat.Text = "SATURNO";
            this.rdsat.UseVisualStyleBackColor = true;
            // 
            // rdmarte
            // 
            this.rdmarte.AutoSize = true;
            this.rdmarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmarte.Location = new System.Drawing.Point(138, 165);
            this.rdmarte.Name = "rdmarte";
            this.rdmarte.Size = new System.Drawing.Size(68, 17);
            this.rdmarte.TabIndex = 12;
            this.rdmarte.TabStop = true;
            this.rdmarte.Text = "MARTE";
            this.rdmarte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "EM VARIOS PLANETAS";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdmarte);
            this.Controls.Add(this.rdsat);
            this.Controls.Add(this.rdvenus);
            this.Controls.Add(this.rdjupiter);
            this.Controls.Add(this.rdurano);
            this.Controls.Add(this.rdmerc);
            this.Controls.Add(this.txtpesoterra);
            this.Controls.Add(this.btncalcule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcule;
        private System.Windows.Forms.TextBox txtpesoterra;
        private System.Windows.Forms.RadioButton rdmerc;
        private System.Windows.Forms.RadioButton rdurano;
        private System.Windows.Forms.RadioButton rdjupiter;
        private System.Windows.Forms.RadioButton rdvenus;
        private System.Windows.Forms.RadioButton rdsat;
        private System.Windows.Forms.RadioButton rdmarte;
        private System.Windows.Forms.Label label1;
    }
}