
namespace PL
{
    partial class Frm_Reguladora
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
            this.cbVerificadora = new System.Windows.Forms.ComboBox();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbVerificadora
            // 
            this.cbVerificadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVerificadora.FormattingEnabled = true;
            this.cbVerificadora.Items.AddRange(new object[] {
            "Correo",
            "Fecha",
            "Cedula"});
            this.cbVerificadora.Location = new System.Drawing.Point(62, 61);
            this.cbVerificadora.Name = "cbVerificadora";
            this.cbVerificadora.Size = new System.Drawing.Size(182, 24);
            this.cbVerificadora.TabIndex = 0;
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(297, 63);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(314, 22);
            this.txtVer.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(656, 48);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(113, 49);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Verificar";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado:";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(321, 118);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(272, 22);
            this.txtRes.TabIndex = 4;
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Reguladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 175);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.cbVerificadora);
            this.Name = "Frm_Reguladora";
            this.Text = "Verificadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVerificadora;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRes;
    }
}