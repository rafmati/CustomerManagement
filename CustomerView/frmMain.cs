using CommonInterface;
using CustomerModelViewControler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomerView
{
    public partial class frmMain : Form
    {
        #region Fields

        private ITModelViewControler<ICMUser, ICustomerView> _modelViewControler;

        #endregion

        #region Constructor

        public frmMain()
        {
            this.InitializeComponent();
            //changing one simple parameter here, we point to a totally different behavior without any side-effect or cascaded changes affecting the View
            //such parameter could be even located in a config file for much easier switching
            {
                this._modelViewControler = new ControlerFactory().GetControler(AvailableControler.RemoteService);
            }
            this._modelViewControler.LoginAccepted += this._modelView_LoginAccepted;
            this._modelViewControler.LoginRejected += this._modelView_LoginRejected;
            this._modelViewControler.Saved += this._modelView_Saved;
            this._modelViewControler.NotSaved += this._modelView_NotSaved;
            this._modelViewControler.ModelUpdated += this._modelView_ModelUpdated;
        }
        #endregion

        #region CustomerModelView Event handlers

        void _modelView_NotSaved(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                MessageBox.Show(this, "Customer not saved!", "Customer register management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }));
        }

        void _modelView_Saved(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                MessageBox.Show(this, "Customer saved!", "Customer register management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetCustomerInput(false);
            }));
        }

        void _modelView_LoginRejected(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                MessageBox.Show(this, "Login rejected!", "User authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserName.ResetText();
                this.txtUserPassword.ResetText();
                this.gbCustomerMgmt.Enabled = false;
                this.gridCostumer.DataSource = new List<ICustomerView>();
                this.ResetCustomerInput(false);
            }));
        }

        void _modelView_LoginAccepted(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
                {
                    MessageBox.Show(this, "Login accepted!", "User authentication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUserName.ResetText();
                    this.txtUserPassword.ResetText();
                    this.gbCustomerMgmt.Enabled = true;
                }));
        }

        void _modelView_ModelUpdated(object sender, List<ICustomerView> e)
        {
            this.BeginInvoke(new MethodInvoker(delegate()
            {
                this.gridCostumer.DataSource = e;
            }));
        }
        #endregion

        #region Button Event handlers

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this._modelViewControler.UserLogin(new UserDetails(this.txtUserName.Text.Trim(), this.txtUserPassword.Text.Trim()));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ResetCustomerInput(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var userInput = this.GetCurrentInputCustomerData();

                if (string.IsNullOrWhiteSpace(this.txtCustomerID.Text))
                {
                    this._modelViewControler.Add(userInput);
                }
                else
                {
                    this._modelViewControler.Update(userInput);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Invalid format!\nCheck your input and try again.", "Customer register management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this._modelViewControler.Refresh();
        }
        #endregion

        #region Helpers

        private ICustomerView GetCurrentInputCustomerData()
        {
            return new CustomerDetails(string.IsNullOrWhiteSpace(this.txtCustomerID.Text) ? 0 : int.Parse(this.txtCustomerID.Text), this.txtCustomerPersonalNum.Text, this.txtCustomerName.Text, this.txtCustomerLastName.Text,
                        decimal.Parse(this.txtCustomerTotalDebt.Text), this.richTxtNote.Text);
        }

        private void ResetCustomerInput(bool enabledControls_)
        {
            this.txtCustomerID.ResetText();
            this.txtCustomerID.Enabled = enabledControls_;
            this.txtCustomerPersonalNum.ResetText();
            this.txtCustomerPersonalNum.Enabled = enabledControls_;
            this.txtCustomerName.ResetText();
            this.txtCustomerName.Enabled = enabledControls_;
            this.txtCustomerLastName.ResetText();
            this.txtCustomerLastName.Enabled = enabledControls_;
            this.txtCustomerTotalDebt.ResetText();
            this.txtCustomerTotalDebt.Enabled = enabledControls_;
            this.richTxtNote.ResetText();
            this.richTxtNote.Enabled = enabledControls_;

            this.btnNew.Enabled = true;
            this.btnSave.Enabled = false;
            this.btnSearch.Enabled = true;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = !(string.IsNullOrWhiteSpace(this.txtCustomerPersonalNum.Text) ||
                string.IsNullOrWhiteSpace(this.txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(this.txtCustomerLastName.Text) ||
                string.IsNullOrWhiteSpace(this.txtCustomerTotalDebt.Text));
        }

        private void gridCostumer_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridCostumer.SelectedRows != null && this.gridCostumer.SelectedRows.Count > 0)
            {
                this.ResetCustomerInput(true);
                this.DisplayCustomer(this.gridCostumer.SelectedRows[0].DataBoundItem as ICustomerView);
            }
        }

        private void DisplayCustomer(ICustomerView customerView_)
        {
            this.txtCustomerID.Text = customerView_.ID.ToString();
            this.txtCustomerName.Text = customerView_.Name;
            this.txtCustomerLastName.Text = customerView_.LastName;
            this.txtCustomerPersonalNum.Text = customerView_.PersonalNum;
            this.txtCustomerTotalDebt.Text = customerView_.TotalDebt.ToString();
            this.richTxtNote.Text = customerView_.Note;
        }
        #endregion
    }
}