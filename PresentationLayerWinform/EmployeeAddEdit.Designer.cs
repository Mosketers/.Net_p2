namespace PresentationLayerWinform
{
    using BusinessLogicLayer;

    partial class EmployeeAddEdit
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
            this.fulltime = new System.Windows.Forms.RadioButton();
            this.parttime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryOrHourly = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.SalaryOrHourlyIput = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.idEmpleado = new System.Windows.Forms.TextBox();
            this.idEmp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fulltime
            // 
            this.fulltime.AutoSize = true;
            this.fulltime.Location = new System.Drawing.Point(12, 12);
            this.fulltime.Name = "fulltime";
            this.fulltime.Size = new System.Drawing.Size(63, 17);
            this.fulltime.TabIndex = 0;
            this.fulltime.TabStop = true;
            this.fulltime.Text = "Full time";
            this.fulltime.UseVisualStyleBackColor = true;
            // 
            // parttime
            // 
            this.parttime.AutoSize = true;
            this.parttime.Location = new System.Drawing.Point(81, 12);
            this.parttime.Name = "parttime";
            this.parttime.Size = new System.Drawing.Size(70, 17);
            this.parttime.TabIndex = 1;
            this.parttime.TabStop = true;
            this.parttime.Text = "Part Time";
            this.parttime.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // SalaryOrHourly
            // 
            this.SalaryOrHourly.AutoSize = true;
            this.SalaryOrHourly.Location = new System.Drawing.Point(9, 120);
            this.SalaryOrHourly.Name = "SalaryOrHourly";
            this.SalaryOrHourly.Size = new System.Drawing.Size(36, 13);
            this.SalaryOrHourly.TabIndex = 4;
            this.SalaryOrHourly.Text = "Salary";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(80, 68);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 5;
            // 
            // SalaryOrHourlyIput
            // 
            this.SalaryOrHourlyIput.Location = new System.Drawing.Point(80, 121);
            this.SalaryOrHourlyIput.Name = "SalaryOrHourlyIput";
            this.SalaryOrHourlyIput.Size = new System.Drawing.Size(100, 20);
            this.SalaryOrHourlyIput.TabIndex = 7;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 160);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(97, 160);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(80, 95);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(100, 20);
            this.dateInput.TabIndex = 6;
            this.dateInput.Value = new System.DateTime(2016, 4, 3, 17, 24, 15, 0);
            // 
            // idEmpleado
            // 
            this.idEmpleado.Location = new System.Drawing.Point(80, 42);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Size = new System.Drawing.Size(100, 20);
            this.idEmpleado.TabIndex = 10;
            // 
            // idEmp
            // 
            this.idEmp.AutoSize = true;
            this.idEmp.Location = new System.Drawing.Point(9, 45);
            this.idEmp.Name = "idEmp";
            this.idEmp.Size = new System.Drawing.Size(65, 13);
            this.idEmp.TabIndex = 11;
            this.idEmp.Text = "Identificador";
            // 
            // EmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 192);
            this.Controls.Add(this.idEmp);
            this.Controls.Add(this.idEmpleado);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.SalaryOrHourlyIput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.SalaryOrHourly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parttime);
            this.Controls.Add(this.fulltime);
            this.Name = "EmployeeAddEdit";
            this.Text = "EmployeeAddEdit";
            this.Load += new System.EventHandler(this.EmployeeAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fulltime;
        private System.Windows.Forms.RadioButton parttime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SalaryOrHourly;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox SalaryOrHourlyIput;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.TextBox idEmpleado;
        private System.Windows.Forms.Label idEmp;
    }
}