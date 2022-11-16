
namespace PL
{
    partial class Frm_Calculadora
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnC = new System.Windows.Forms.Button();
            this.dgvExp1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el primer numero:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(302, 48);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(97, 22);
            this.txtN1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el segundo numero:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(302, 109);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(97, 22);
            this.txtN2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(170, 180);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(97, 45);
            this.btnRestar.TabIndex = 6;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(26, 261);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(97, 45);
            this.btnMulti.TabIndex = 7;
            this.btnMulti.Text = "Multi";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(170, 261);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(97, 45);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnCe
            // 
            this.btnCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCe.Location = new System.Drawing.Point(302, 180);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(97, 45);
            this.btnCe.TabIndex = 9;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvExp1,
            this.dgvOp,
            this.dgvExp2,
            this.dgvOb});
            this.dgvClientes.Location = new System.Drawing.Point(454, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(667, 367);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.TabStop = false;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(302, 261);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(97, 45);
            this.btnC.TabIndex = 18;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // dgvExp1
            // 
            this.dgvExp1.HeaderText = "EXP1";
            this.dgvExp1.MinimumWidth = 6;
            this.dgvExp1.Name = "dgvExp1";
            this.dgvExp1.ReadOnly = true;
            this.dgvExp1.Width = 80;
            // 
            // dgvOp
            // 
            this.dgvOp.HeaderText = "OP";
            this.dgvOp.MinimumWidth = 6;
            this.dgvOp.Name = "dgvOp";
            this.dgvOp.ReadOnly = true;
            this.dgvOp.Width = 80;
            // 
            // dgvExp2
            // 
            this.dgvExp2.HeaderText = "EXP2";
            this.dgvExp2.MinimumWidth = 6;
            this.dgvExp2.Name = "dgvExp2";
            this.dgvExp2.ReadOnly = true;
            this.dgvExp2.Width = 80;
            // 
            // dgvOb
            // 
            this.dgvOb.HeaderText = "Observacion";
            this.dgvOb.MinimumWidth = 6;
            this.dgvOb.Name = "dgvOb";
            this.dgvOb.ReadOnly = true;
            this.dgvOb.Width = 255;
            // 
            // Frm_Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 391);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Calculadora";
            this.Text = "Frm_Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOb;
    }
}