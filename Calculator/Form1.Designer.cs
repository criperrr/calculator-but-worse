namespace Calculator
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
            this.minus = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.NumericUpDown();
            this.value2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.segue = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.value1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value2)).BeginInit();
            this.SuspendLayout();
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(206, 134);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(72, 113);
            this.minus.TabIndex = 0;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.onOpClick);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(84, 134);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(57, 53);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.onOpClick);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(145, 134);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(57, 53);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.onOpClick);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(84, 193);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(118, 54);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.onOpClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "V1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.Location = new System.Drawing.Point(215, 73);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(46, 32);
            this.operation.TabIndex = 6;
            this.operation.Text = "op";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(426, 69);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(458, 219);
            this.result.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "V2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1.Location = new System.Drawing.Point(84, 69);
            this.value1.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.value1.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.value1.Name = "value1";
            this.value1.ReadOnly = true;
            this.value1.Size = new System.Drawing.Size(118, 38);
            this.value1.TabIndex = 9;
            this.value1.ValueChanged += new System.EventHandler(this.hasValueChanged);
            // 
            // value2
            // 
            this.value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value2.Location = new System.Drawing.Point(267, 71);
            this.value2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.value2.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.value2.Name = "value2";
            this.value2.ReadOnly = true;
            this.value2.Size = new System.Drawing.Size(117, 38);
            this.value2.TabIndex = 10;
            this.value2.ValueChanged += new System.EventHandler(this.hasValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // segue
            // 
            this.segue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segue.ForeColor = System.Drawing.Color.Black;
            this.segue.Location = new System.Drawing.Point(332, 196);
            this.segue.Name = "segue";
            this.segue.Size = new System.Drawing.Size(57, 53);
            this.segue.TabIndex = 13;
            this.segue.Text = "↺";
            this.segue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.segue.UseVisualStyleBackColor = true;
            this.segue.Click += new System.EventHandler(this.segue_Click);
            // 
            // clean
            // 
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean.ForeColor = System.Drawing.Color.Black;
            this.clean.Location = new System.Drawing.Point(332, 134);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(57, 45);
            this.clean.TabIndex = 14;
            this.clean.Text = "←";
            this.clean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 324);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.segue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.division);
            this.Controls.Add(this.minus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.value1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown value1;
        private System.Windows.Forms.NumericUpDown value2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button segue;
        private System.Windows.Forms.Button clean;
    }
}

