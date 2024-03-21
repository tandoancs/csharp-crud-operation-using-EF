
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrudOperationUsingEF.Model;

namespace CrudOperationUsingEF
{
    public partial class frmEmployee : Form
    {

        OperationEntities db = new OperationEntities();
        Employee Employee = new Employee();
        int EmpId = 0;

        public frmEmployee()
        {
            InitializeComponent();
        }


        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operationDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.operationDataSet.Employee);
            ClearData();
            SetDataInGridView();
            txtEName.Focus();

        }

        public void ClearData()
        {
            txtEAddress.Text = txtEAge.Text = txtECity.Text = txtEName.Text = txtESalary.Text = string.Empty;
            btnEDelete.Enabled = false;
            btnESave.Text = "Save";
            EmpId = 0;

        }

        public void SetDataInGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Employees.ToList<Employee>();
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            Employee.EmployeeName = txtEName.Text.Trim();
            Employee.EmployeeAge = Convert.ToInt32(txtEAge.Text.Trim());
            Employee.EmployeeAddress = txtEAddress.Text.Trim();
            Employee.EmployeeCity = txtECity.Text.Trim();
            Employee.EmployeeSalary = Convert.ToInt32(txtESalary.Text.Trim());

            if (EmpId > 0 )
            {
                db.Entry(Employee).State = EntityState.Modified;
            } else
            {
                db.Employees.Add(Employee);
            }

            db.SaveChanges();

            ClearData();
            SetDataInGridView();
            MessageBox.Show("Record Save Successfully");


        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                EmpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmployeeId"].Value);
                Console.WriteLine(EmpId);
                Employee = db.Employees.Where(x => x.EmployeeId == EmpId).FirstOrDefault();
                Console.WriteLine(Employee.ToString());

                txtEName.Text = Employee.EmployeeName;
                txtEAge.Text = Employee.EmployeeAge.ToString();
                txtESalary.Text = Employee.EmployeeSalary.ToString();
                txtEAddress.Text = Employee.EmployeeAddress;
                txtECity.Text = Employee.EmployeeCity;

                btnESave.Text = "Update";
                btnEDelete.Enabled = true;

            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure you want to delete this record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                db.Employees.Remove(Employee);
                db.SaveChanges();
                ClearData();
                SetDataInGridView();
                MessageBox.Show("Record Deleted Successfully");
            }
        }

        private void btnECancel_Click(object sender, EventArgs e)
        {
            ClearData();
            SetDataInGridView();
        }
    }
}
