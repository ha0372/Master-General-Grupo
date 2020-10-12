namespace Calcular__Notas
{
    partial class frmSuma
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(339, 179);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(220, 118);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(100, 23);
            this.txtD1.TabIndex = 1;
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(421, 118);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(100, 23);
            this.txtD2.TabIndex = 2;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(345, 262);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(100, 23);
            this.txtRes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESE LOS NUMEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESULTADO =";
            // 
            // frmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.btnSumar);
            this.Name = "frmSuma";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}