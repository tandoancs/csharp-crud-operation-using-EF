
namespace CrudOperationUsingEF
{
    partial class frmEmployee
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
            this.components = new System.ComponentModel.Container();
            this.lblEName = new System.Windows.Forms.Label();
            this.lblEAge = new System.Windows.Forms.Label();
            this.lblESalary = new System.Windows.Forms.Label();
            this.lblECity = new System.Windows.Forms.Label();
            this.lblEAddress = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationDataSet = new CrudOperationUsingEF.OperationDataSet();
            this.lblETitle = new System.Windows.Forms.Label();
            this.txtEAge = new System.Windows.Forms.TextBox();
            this.txtESalary = new System.Windows.Forms.TextBox();
            this.txtECity = new System.Windows.Forms.TextBox();
            this.txtEAddress = new System.Windows.Forms.TextBox();
            this.btnESave = new System.Windows.Forms.Button();
            this.btnEDelete = new System.Windows.Forms.Button();
            this.btnECancel = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new CrudOperationUsingEF.OperationDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEName.Location = new System.Drawing.Point(12, 85);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(139, 19);
            this.lblEName.TabIndex = 0;
            this.lblEName.Text = "Employee Name";
            // 
            // lblEAge
            // 
            this.lblEAge.AutoSize = true;
            this.lblEAge.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEAge.Location = new System.Drawing.Point(12, 127);
            this.lblEAge.Name = "lblEAge";
            this.lblEAge.Size = new System.Drawing.Size(129, 19);
            this.lblEAge.TabIndex = 0;
            this.lblEAge.Text = "Employee Age";
            // 
            // lblESalary
            // 
            this.lblESalary.AutoSize = true;
            this.lblESalary.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESalary.Location = new System.Drawing.Point(12, 171);
            this.lblESalary.Name = "lblESalary";
            this.lblESalary.Size = new System.Drawing.Size(159, 19);
            this.lblESalary.TabIndex = 0;
            this.lblESalary.Text = "Employee Salary";
            // 
            // lblECity
            // 
            this.lblECity.AutoSize = true;
            this.lblECity.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECity.Location = new System.Drawing.Point(12, 215);
            this.lblECity.Name = "lblECity";
            this.lblECity.Size = new System.Drawing.Size(139, 19);
            this.lblECity.TabIndex = 0;
            this.lblECity.Text = "Employee City";
            // 
            // lblEAddress
            // 
            this.lblEAddress.AutoSize = true;
            this.lblEAddress.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEAddress.Location = new System.Drawing.Point(12, 257);
            this.lblEAddress.Name = "lblEAddress";
            this.lblEAddress.Size = new System.Drawing.Size(169, 19);
            this.lblEAddress.TabIndex = 0;
            this.lblEAddress.Text = "Employee Address";
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(191, 84);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(243, 20);
            this.txtEName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.EmployeeAge,
            this.EmployeeAddress,
            this.EmployeeCity,
            this.EmployeeSalary});
            this.dataGridView1.DataSource = this.employeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(452, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 331);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.operationDataSet;
            // 
            // operationDataSet
            // 
            this.operationDataSet.DataSetName = "OperationDataSet";
            this.operationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblETitle
            // 
            this.lblETitle.AutoSize = true;
            this.lblETitle.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETitle.ForeColor = System.Drawing.Color.Red;
            this.lblETitle.Location = new System.Drawing.Point(251, 31);
            this.lblETitle.Name = "lblETitle";
            this.lblETitle.Size = new System.Drawing.Size(349, 29);
            this.lblETitle.TabIndex = 3;
            this.lblETitle.Text = "THE OPERATION EF MANAGER";
            // 
            // txtEAge
            // 
            this.txtEAge.Location = new System.Drawing.Point(191, 128);
            this.txtEAge.Name = "txtEAge";
            this.txtEAge.Size = new System.Drawing.Size(243, 20);
            this.txtEAge.TabIndex = 2;
            // 
            // txtESalary
            // 
            this.txtESalary.Location = new System.Drawing.Point(191, 170);
            this.txtESalary.Name = "txtESalary";
            this.txtESalary.Size = new System.Drawing.Size(243, 20);
            this.txtESalary.TabIndex = 3;
            // 
            // txtECity
            // 
            this.txtECity.Location = new System.Drawing.Point(191, 214);
            this.txtECity.Name = "txtECity";
            this.txtECity.Size = new System.Drawing.Size(243, 20);
            this.txtECity.TabIndex = 4;
            // 
            // txtEAddress
            // 
            this.txtEAddress.Location = new System.Drawing.Point(191, 256);
            this.txtEAddress.Multiline = true;
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(243, 70);
            this.txtEAddress.TabIndex = 5;
            // 
            // btnESave
            // 
            this.btnESave.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESave.Location = new System.Drawing.Point(16, 370);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(94, 45);
            this.btnESave.TabIndex = 7;
            this.btnESave.Text = "Save";
            this.btnESave.UseVisualStyleBackColor = true;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // btnEDelete
            // 
            this.btnEDelete.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDelete.Location = new System.Drawing.Point(180, 370);
            this.btnEDelete.Name = "btnEDelete";
            this.btnEDelete.Size = new System.Drawing.Size(94, 45);
            this.btnEDelete.TabIndex = 8;
            this.btnEDelete.Text = "Delete";
            this.btnEDelete.UseVisualStyleBackColor = true;
            this.btnEDelete.Click += new System.EventHandler(this.btnEDelete_Click);
            // 
            // btnECancel
            // 
            this.btnECancel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnECancel.Location = new System.Drawing.Point(340, 370);
            this.btnECancel.Name = "btnECancel";
            this.btnECancel.Size = new System.Drawing.Size(94, 45);
            this.btnECancel.TabIndex = 9;
            this.btnECancel.Text = "Cancel";
            this.btnECancel.UseVisualStyleBackColor = true;
            this.btnECancel.Click += new System.EventHandler(this.btnECancel_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.operationDataSet;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.DataPropertyName = "EmployeeAge";
            this.EmployeeAge.HeaderText = "EmployeeAge";
            this.EmployeeAge.Name = "EmployeeAge";
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.DataPropertyName = "EmployeeAddress";
            this.EmployeeAddress.HeaderText = "EmployeeAddress";
            this.EmployeeAddress.Name = "EmployeeAddress";
            // 
            // EmployeeCity
            // 
            this.EmployeeCity.DataPropertyName = "EmployeeCity";
            this.EmployeeCity.HeaderText = "EmployeeCity";
            this.EmployeeCity.Name = "EmployeeCity";
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.DataPropertyName = "EmployeeSalary";
            this.EmployeeSalary.HeaderText = "EmployeeSalary";
            this.EmployeeSalary.Name = "EmployeeSalary";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.btnECancel);
            this.Controls.Add(this.btnEDelete);
            this.Controls.Add(this.btnESave);
            this.Controls.Add(this.lblETitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.txtECity);
            this.Controls.Add(this.txtESalary);
            this.Controls.Add(this.txtEAge);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.lblEAddress);
            this.Controls.Add(this.lblECity);
            this.Controls.Add(this.lblESalary);
            this.Controls.Add(this.lblEAge);
            this.Controls.Add(this.lblEName);
            this.Name = "frmEmployee";
            this.Text = "Crud Operation Using EF";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblEAge;
        private System.Windows.Forms.Label lblESalary;
        private System.Windows.Forms.Label lblECity;
        private System.Windows.Forms.Label lblEAddress;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblETitle;
        private System.Windows.Forms.TextBox txtEAge;
        private System.Windows.Forms.TextBox txtESalary;
        private System.Windows.Forms.TextBox txtECity;
        private System.Windows.Forms.TextBox txtEAddress;
        private System.Windows.Forms.Button btnESave;
        private System.Windows.Forms.Button btnEDelete;
        private System.Windows.Forms.Button btnECancel;
        private OperationDataSet operationDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private OperationDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalary;
    }
}

